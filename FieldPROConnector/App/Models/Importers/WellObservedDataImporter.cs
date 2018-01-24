using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slb.Ocean.Petrel;
using System.Data.Odbc;
using Slb.Ocean.Petrel.DomainObject.Well;
using Slb.Ocean.Core;
using Slb.Ocean.Petrel.DomainObject;
using System.Windows.Forms;

namespace FieldPROConnector
{
    enum Frequency { Daily, Monthly }

    class WellObservedDataImporter
    {
        private DateTime start;
        private DateTime end;
        private Frequency frequency;

        public void Import(Frequency frequency, DateTime start, bool hasStart, DateTime end, bool hasEnd)
        {
            this.start = hasStart ? start : DateTime.ParseExact("1900-01-01", "yyyy-MM-dd", null);
            this.end = hasEnd ? end : DateTime.ParseExact("2100-01-01", "yyyy-MM-dd", null);
            this.frequency = frequency;
            this.ImportObservedData();
        }

        private void ImportObservedData() {
            WellRoot wellRoot = WellRoot.Get(PetrelProject.PrimaryProject);
            ObservedDataSet observedDataSet = EnsureDailyDataSet();
            IProgress p = PetrelLogger.NewProgress(0, wellRoot.BoreholeCollection.Count, ProgressType.Cancelable, Cursors.WaitCursor);
            using (p) {
                p.SetProgressText("Importing well allocations...");
                foreach (var well in wellRoot.BoreholeCollection) {
                    var allocations = WellAllocation.Broker(frequency).GetAll(well.UWI, start, end);
                    ImportObservedDataForWell(well, allocations, observedDataSet);
                    p.ProgressStatus = p.ProgressStatus + 1;
                }
            }
        }

        private void ImportObservedDataForWell(Borehole bh, List<WellAllocation> wellAllocations, ObservedDataSet observedDataSet)
        {
            ObservedDataSetForWell odsFw = ObservedDataSetForWell.NullObject;

            DeleteExistentDataSetForWell(bh, observedDataSet);


            string opIdName = "Oil production rate";
            string gpIdName = "Gas production rate";
            string wpIdName = "Water production rate";
            string wiIdName = "Water injection rate";
            string ufIdName = "Uptime fraction";
            FlowType flow = FlowType.Default;

            var timeSteps = new List<DateTime>();
            using (ITransaction tr = DataManager.NewTransaction())
            {
                Template opt = PetrelProject.WellKnownTemplates.ProductionGroup.ProductionRateOil;
                Template gpt = PetrelProject.WellKnownTemplates.ProductionGroup.ProductionRateGas;
                Template wpt = PetrelProject.WellKnownTemplates.ProductionGroup.ProductionRateWater;
                Template wit = PetrelProject.WellKnownTemplates.ProductionGroup.InjectionRateWater;
                Template utf = PetrelProject.WellKnownTemplates.ProductionGroup.UptimeFraction;
                tr.Lock(observedDataSet);
                odsFw = observedDataSet.CreateObservedDataSetForWell(bh, flow, timeSteps);

                // Create each data version (columns)
                CreateEmptyObservedData(odsFw, opt, opIdName);
                CreateEmptyObservedData(odsFw, gpt, gpIdName);
                CreateEmptyObservedData(odsFw, wpt, wpIdName);
                CreateEmptyObservedData(odsFw, wit, wiIdName);
                CreateEmptyObservedData(odsFw, utf, ufIdName);          

                // Append data
                foreach (WellAllocation allocation in wellAllocations)
                {
                    odsFw.Append(
                        allocation.OperativeDate,
                        odsFw.ObservedDatas,
                        new List<double>{
                                    ProductionRate(allocation.Oil, allocation.EffectiveTime),
                                    ProductionRate(allocation.Gas, allocation.EffectiveTime),
                                    ProductionRate(allocation.Water, allocation.EffectiveTime),
                                    ProductionRate(allocation.WaterInjection, allocation.EffectiveTime),
                                    allocation.EffectiveTime});
                }

                tr.Commit();
            }
        }

        private double ProductionRate(double production, double days)
        {
            if (days <= 0) return 0.0;
            return production / (days * 24 * 60 * 60);
        }

        private void CreateEmptyObservedData(ObservedDataSetForWell odsFw, Template template, string versionDataName)
        {
            foreach (ObservedDataVersionSelection odvs in odsFw.GetObservedDataVersionSelections(template))
            {
                if (odvs.Name == versionDataName)
                {
                    odsFw.CreateObservedData(odvs, new List<double>());
                }
            }
        }

        private static void DeleteExistentDataSetForWell(Borehole bh, ObservedDataSet observedDataSet)
        {
            if (bh.ObservedDataSetCount > 0)
            {
                foreach (ObservedDataSetForWell tmpDS in bh.ObservedDataSets)
                {
                    if (tmpDS.Name == observedDataSet.Name)
                    {
                        using (ITransaction tr = DataManager.NewTransaction())
                        {
                            // Destructive delete of the previous observed data set for the well.
                            tr.Lock(tmpDS);
                            tmpDS.Delete();
                            tr.Commit();
                        }
                        break;
                    }
                }
            }
        }

        private ObservedDataSet EnsureDailyDataSet()
        {
            return EnsureDataSetNamed("FIELDPRO " + this.GetProductionType() + " Production");
        }

        private string GetProductionType()
        {
            if (this.frequency == Frequency.Daily)
                return "Daily";
            else
                return "Monthly";
        }

        private ObservedDataSet EnsureDataSetNamed(string dataSetName)
        {
            WellRoot wellRoot = WellRoot.Get(PetrelProject.PrimaryProject);
            ObservedDataSet observedDataSet = ObservedDataSet.NullObject;
            foreach (ObservedDataSet oDSet in wellRoot.Observed.ObservedDataSets)
            {
                if (oDSet.Name == dataSetName)
                {
                    observedDataSet = oDSet;
                    break;
                }
            }
            if (observedDataSet == null)
            {
                using (ITransaction tr = DataManager.NewTransaction())
                {
                    tr.Lock(wellRoot);
                    observedDataSet = wellRoot.Observed.CreateObservedDataSet(dataSetName);
                    tr.Commit();
                }
            }

            return observedDataSet;
        }
    }
}
