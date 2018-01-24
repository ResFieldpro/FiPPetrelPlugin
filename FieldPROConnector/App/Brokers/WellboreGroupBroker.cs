using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;

namespace FieldPROConnector
{
	class WellboreGroupBroker
	{
		private WebConfiguration dcInfo;


		public WellboreGroupBroker(WebConfiguration config)
		{
			dcInfo = config;
		}

		public List<WellboreGroup> GetAllOfWell(string wellId)
		{
			List<WellboreGroup> groups = new List<WellboreGroup>();
			//using (FiPConnection cn = dcInfo.NewConnection()) {
			//	 cn.ExecuteSql(sql, new List<OdbcParameter>(), (reader) => {
			//		  var w = this.WellboreGroupFromRow(reader);
			//		  groups.Add(w);
			//		  return w;
			//	 });
			//}
			return groups;
		}
		private WellboreGroup WellboreGroupFromRow(OdbcDataReader reader)
		{
			WellboreGroup wgp = new WellboreGroup();
			//wgp.ID = int.Parse(reader["ID"].ToString());
			//wgp.Name = reader["NAME"].ToString();
			//wgp.StartDate = reader.GetDateTime(reader.GetOrdinal("START_DATE"));
			//wgp.EndDate = reader.GetDateTime(reader.GetOrdinal("END_DATE"));
			//wgp.TopDepth = double.Parse(reader["TOP_DEPTH"].ToString()) * 0.3048; // Feet to meters;
			//wgp.BaseDepth = double.Parse(reader["BASE_DEPTH"].ToString()) * 0.3048; // Feet to meters;
			//wgp.StandardType = int.Parse(reader["STANDARD_TYPE_ID"].ToString());
			return wgp;
		}
	}
}
