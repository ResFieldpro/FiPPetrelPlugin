using Slb.Ocean.Petrel.DomainObject.Well;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace FieldPROConnector
{
	class WellLogFileBroker
	{
		private WebConfiguration dcInfo;
		public WellLogFileBroker(WebConfiguration config)
		{
			dcInfo = config;
		}
		public List<WellLogFile> GetAllOfWell(string wellId)
		{
			List<WellLogFile> files = new List<WellLogFile>();
			//string sql = String.Format("SELECT B.ID, B.NAME, B.PARENT_ID, B.MOUNT_PATH FROM HYPERLINKS_ASSIGNED_OBJECTS A INNER JOIN HYPERLINKS B ON A.RI_ID = B.ID WHERE A.OBJ_TYPE = 2 AND A.OBJ_KEY = {0}", wellId);
			//using(FiPConnection cn = dcInfo.NewConnection())
			//{
			//	 cn.ExecuteSql(sql, new List<OdbcParameter>(), (reader) => {
			//		  var w = this.WellLogFileFromRow(reader);
			//		  files.Add(w);
			//		  return w;});
			//}
			return files;
		}
		public List<WellLogFile> GetWithID(string id)
		{
			List<WellLogFile> files = new List<WellLogFile>();
			//string sql = String.Format("SELECT ID, NAME, PARENT_ID, MOUNT_PATH FROM HYPERLINKS WHERE ID = {0}", id);
			//using (FiPConnection cn = dcInfo.NewConnection()) {
			//	 cn.ExecuteSql(sql, new List<OdbcParameter>(), (reader) => {
			//		  var w = this.WellLogFileFromRow(reader);
			//		  files.Add(w);
			//		  return w;
			//	 });
			//}
			return files;
		}
		private WellLogFile WellLogFileFromRow(OdbcDataReader reader)
		{
			WellLogFile wellLogFile = new WellLogFile();
			wellLogFile.ID = reader["ID"].ToString();
			wellLogFile.Name = reader["NAME"].ToString();
			wellLogFile.ParentID = reader["PARENT_ID"].ToString();
			wellLogFile.Path = reader["MOUNT_PATH"].ToString();

			return wellLogFile;
		}
	}
}
