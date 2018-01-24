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
	class WellTrajectoryBroker
	{

		private WebConfiguration dcInfo;

		public WellTrajectoryBroker(WebConfiguration config)
		{
			dcInfo = config;
		}

		public List<WellTrajectory> ForWell(Well well)
		{
			List<WellTrajectory> records = new List<WellTrajectory>();
			try
			{
				WebImporter wi = new WebImporter();
				DataTable dt = wi.LoadSurvey(dcInfo.WebServer, dcInfo.WebServerU, dcInfo.WebServerP, well.Uwi);
				foreach (DataRow dr in dt.Rows)
				{
					var w = this.WellTrajectoryFromRow(dr);
					records.Add(w);
				}
			}
			catch (Exception e)
			{
				PetrelLogger.InfoOutputWindow("Failed to load wells: " + e.ToString());
			}
			return records;
		}

		private WellTrajectory WellTrajectoryFromRow(DataRow dr)
		{
			WellTrajectory wt = new WellTrajectory();
			wt.ID = 1;//just set indicator
			wt.MD = double.Parse(dr["MD"].ToString());
			wt.VD = double.Parse(dr["TVD"].ToString());
			wt.Inclination = double.Parse(dr["INCLINATION"].ToString());
			wt.Azimuth = double.Parse(dr["AZIMUTH"].ToString());
			wt.NS = double.Parse(dr["NS"].ToString());
			wt.EW = double.Parse(dr["WE"].ToString());

			return wt;
		}
	}
}
