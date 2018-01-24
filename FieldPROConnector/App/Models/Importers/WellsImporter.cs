using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Slb.Ocean.Petrel;
using System.Data.Odbc;
using Slb.Ocean.Petrel.DomainObject.Well;
using Slb.Ocean.Core;
using Slb.Ocean.Geometry;
using System.Windows.Forms;

namespace FieldPROConnector
{
	class WellsImporter
	{
		public void Import(List<Well> wells, WebConfiguration dcInfo)
		{
			PetrelLogger.InfoOutputWindow("Start import process...");
			ImportWells(wells, dcInfo);
		}
		private void ImportWells(List<Well> wells, WebConfiguration wc)
		{
			WellRoot wellRoot = WellRoot.Get(PetrelProject.PrimaryProject);
			EnsureBoreholeCollection(wellRoot);
			BoreholeCollection boreholeColl = wellRoot.BoreholeCollection;

			IProgress p = PetrelLogger.NewProgress(0, wells.Count, ProgressType.Cancelable, Cursors.WaitCursor);
			using (p)
			{
				foreach (Well well in wells)
				{
					if (p.IsCanceled) break;
					p.SetProgressText("Importing well " + well.Name);
					Application.DoEvents();
					ImportWell(well, boreholeColl);
					p.ProgressStatus = p.ProgressStatus + 1;
				}
			}
		}
		private void ImportWell(Well well, BoreholeCollection boreholeColl)
		{
			string uwi = well.Uwi;
			if (uwi.Trim().Length == 0)
			{
				PetrelLogger.InfoOutputWindow("Unable to import well: " + well.Name + " => UWI not defined.");
				return;
			}
			Borehole borehole = boreholeColl.FindWellByUWI(uwi);
			PetrelLogger.InfoOutputWindow("Importing well named: " + well.Name);
			if (borehole == null)
			{
				PetrelLogger.InfoOutputWindow("Creating well named: " + well.Name);
				CreateWell(well, boreholeColl);
			}
			else
			{
				PetrelLogger.InfoOutputWindow("Skip existing well: " + well.Name);
			}
		}
		private void CreateWell(Well well, BoreholeCollection boreholeColl)
		{
			using (ITransaction tr = DataManager.NewTransaction())
			{
				tr.Lock(boreholeColl);
				Borehole borehole = boreholeColl.CreateBorehole(well.Name);
				borehole.Comments = "Imported from FIELDPRO";
				borehole.UWI = well.Uwi;
				var coordinates = well.CartesianCoordinates();
				borehole.WellHead = new Point2(coordinates["X"], coordinates["Y"]);
				ReferenceLevel kb = new ReferenceLevel("KB", well.Z, "Kelly bushing");
				borehole.WorkingReferenceLevel = kb;
				var trajectoryRecords = this.GetTrajectoryRecords(well);
				try { borehole.Trajectory.Records = trajectoryRecords; }
				catch (ArgumentOutOfRangeException ex)
				{
					PetrelLogger.InfoOutputWindow("Failed to set trajectory: " + ex.ToString());
				}
				SetProperty("Field", well.Field, borehole, true);
				SetProperty("Area", well.Area, borehole, true);
				SetProperty("Country", well.Country, borehole, true);
				SetProperty("FIELDPRO ID", well.ID.ToString(), borehole, false);
				tr.Commit();
			}
		}
		public static Well Borehole2Well(Borehole b)
		{
			Well w = new Well();
			w.Name = b.Name;
			w.Uwi = b.UWI;
			w.X = b.WellHead.X;
			w.Y = b.WellHead.Y;
			w.Field = GetProperty(b, "Field");
			w.Area = GetProperty(b, "Area");
			w.Country = GetProperty(b, "Country");
			return w;
		}
		private List<TrajectoryRecord> GetTrajectoryRecords(Well well)
		{
			var records = new List<TrajectoryRecord>();
			var temp = WellTrajectory.Broker.ForWell(well);
			foreach (var r in temp)
			{
				records.Add(r.TrajectoryRecord());
			}
			return records;
		}
		private static string GetProperty(Borehole well, string propertyName)
		{
			BoreholePropertyCollection bhPropertyColl = well.BoreholeCollection.BoreholePropertyCollection;
			DictionaryBoreholeProperty dicProperty = FindDictionaryProperty(bhPropertyColl, propertyName);
			return well.PropertyAccess.GetPropertyValue<string>(dicProperty).ToString();
		}
		private void SetProperty(string propertyName, string value, Borehole well, Boolean isPropertyGroup)
		{
			using (ITransaction tr = DataManager.NewTransaction())
			{
				BoreholePropertyCollection bhPropertyColl = well.BoreholeCollection.BoreholePropertyCollection;

				DictionaryBoreholeProperty dicProperty = DictionaryBoreholeProperty.NullObject;
				dicProperty = FindDictionaryProperty(bhPropertyColl, propertyName);
				if (dicProperty == null)
				{   // Create attribute from BoreholePropertyCollection
					tr.Lock(bhPropertyColl);
					dicProperty = bhPropertyColl.CreateDictionaryProperty(typeof(string), propertyName);
					dicProperty.IsGroupProperty = isPropertyGroup;
				}
				tr.Lock(well);
				well.PropertyAccess.SetPropertyValue(dicProperty, value);
				tr.Commit();
			}
		}
		public static DictionaryBoreholeProperty FindDictionaryProperty(BoreholePropertyCollection bhpc, string propName)
		{
			DictionaryBoreholeProperty dbhp = DictionaryBoreholeProperty.NullObject;
			foreach (DictionaryBoreholeProperty p in bhpc.DictionaryProperties)
			{
				if (p.Name == propName)
				{
					if (p.DataType == typeof(string))
					{
						dbhp = p;
						break;
					}
				}
			}
			return dbhp;
		}
		private void EnsureBoreholeCollection(WellRoot wr)
		{
			if (!wr.HasBoreholeCollection)
			{
				using (ITransaction tr = DataManager.NewTransaction())
				{
					tr.Lock(wr);
					wr.CreateBoreholeCollection();
					tr.Commit();
				}
			}
		}
	}
}
