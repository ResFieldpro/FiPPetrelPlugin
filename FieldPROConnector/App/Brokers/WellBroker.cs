using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data;
using WebDataLoader;
using Slb.Ocean.Petrel;

namespace FieldPROConnector
{
	class WellBroker
	{
		private WebConfiguration dcInfo;
		public WellBroker(WebConfiguration config)
		{
			dcInfo = config;
		}
		public List<Well> GetAll()
		{
			List<Well> wells = new List<Well>();
			WebImporterWrapper wi = new WebImporterWrapper(dcInfo);
			try
			{
				DataTable dt = wi.LoadWells();
				foreach (DataRow dr in dt.Rows)
				{
					var w = this.WellFromRow(dr);
					wells.Add(w);
				}
			}
			catch (Exception e)
			{
				PetrelLogger.InfoOutputWindow("Failed to load wells: " + e.ToString());
			}
			return wells;
		}

		private Well WellFromRow(DataRow dr)
		{
			Well well = new Well();
			well.ID = 1;///just set indicator
			well.Name = dr["NAME"].ToString();
			well.Country = dr["COUNTRY"].ToString();
			well.Field = dr["FIELD"].ToString();
			well.Area = dr["AREA"].ToString();
			well.Uwi = dr["UWI"].ToString();

			well.Tmd = dr["DEPTHTMD"] == DBNull.Value ? 0 : double.Parse(dr["DEPTHTMD"].ToString());
			well.Tvd = dr["DEPTHTVD"] == DBNull.Value ? 0 : double.Parse(dr["DEPTHTVD"].ToString());

			well.X = dr["X"] == DBNull.Value ? 0 : double.Parse(dr["X"].ToString());
			well.Y = dr["Y"] == DBNull.Value ? 0 : double.Parse(dr["Y"].ToString());
			well.Z = dr["Z"] == DBNull.Value ? 0 : double.Parse(dr["Z"].ToString()) * 0.3048; // Feet to meters;

			return well;
		}
	}
}
