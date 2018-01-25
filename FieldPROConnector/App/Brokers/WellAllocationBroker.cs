using Slb.Ocean.Petrel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using WebDataLoader;

namespace FieldPROConnector
{
    class WellAllocationBroker
    {

        private WebConfiguration dcInfo;
        private Frequency frequency;

        public WellAllocationBroker(WebConfiguration config, Frequency frequency)
        {
            this.dcInfo = config;
            this.frequency = frequency;
        }

        public List<WellAllocation> GetAll(string uwi, DateTime start, DateTime end)
        {
            List<WellAllocation> allocations = new List<WellAllocation>();
            WebImporter wi = new WebImporter();
            try
            {
                DataTable dt = wi.LoadDailyProduction(dcInfo.WebServer, dcInfo.WebServerU, dcInfo.WebServerP, uwi);
                foreach (DataRow dr in dt.Rows)
                {
                    var w = this.WellAllocationFromRow(dr);
                    allocations.Add(w);
                }
            }
            catch (Exception e)
            {
                PetrelLogger.InfoOutputWindow("Failed to load wells: " + e.ToString());
            }
            return allocations;
        }

        private WellAllocation WellAllocationFromRow(DataRow r)
        {
            WellAllocation alloc = new WellAllocation();
            alloc.OperativeDate = Convert.ToDateTime(r["DATE"]);
            var dbOil = r["OIL"]; // In bbls
            var dbGas = r["GAS"]; // In Mscf
            var dbWater = r["WATER"]; // In bbls

            alloc.Oil_Bbls = DBNull.Value.Equals(dbOil) ? 0.0 : double.Parse(dbOil.ToString());
            alloc.Gas_Mscf = DBNull.Value.Equals(dbGas) ? 0.0 : double.Parse(dbGas.ToString());
            alloc.Water_Bbls = DBNull.Value.Equals(dbWater) ? 0.0 : double.Parse(dbWater.ToString());

            return alloc;
        }
    }
}
