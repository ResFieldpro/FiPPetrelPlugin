using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace FieldPROConnector {
    class WellAllocationBroker {

        private WebConfiguration dcInfo;
        private Frequency frequency;

        public WellAllocationBroker(WebConfiguration config, Frequency frequency)
        {
            this.dcInfo = config;
            this.frequency = frequency;
        }

        public List<WellAllocation> GetAll(string uwi, DateTime start, DateTime end) {
            List<WellAllocation> allocations = new List<WellAllocation>();
            OdbcParameter wellParam = new OdbcParameter("@UWI", uwi);    
            OdbcParameter startParam = new OdbcParameter("@Start", start);
            OdbcParameter endParam = new OdbcParameter("@End", end);
            string sql = String.Format(@"SELECT WELLS.WELL_UWI, WELL_NAME, PROD_DATE, UPTIME_OPERATING_PRODUCING,
                            OIL_VOLUME, GAS_VOLUME, WATER_VOLUME, PRIMARY_OIL_VOLUME, SECONDARY_OIL_VOLUME,
                             0 WATER_INJECTED_VOLUME, 0 GAS_INJECTED_VOLUME, 0 WATER_DISPOSAL_VOLUME
                            FROM {0}, WELLS, DATA_COMPONENTS
                            WHERE WELLS.WELL_KEY_ID = DATA_COMPONENTS.WELL_KEY_ID
                             AND DATA_COMPONENTS.DATA_COMPONENT_ID = {0}.DATA_COMPONENT_ID
                             AND WELLS.WELL_UWI = ?
                             AND PROD_DATE BETWEEN ? AND ?
                            ORDER BY PROD_DATE ASC;", this.ProductionTable());
            var odbcParams = new List<OdbcParameter> {wellParam, startParam, endParam};
				//using (FiPConnection cn = dcInfo.NewConnection()) {
				//	 cn.ExecuteSql(sql, odbcParams, (reader) => {
				//		  var a = this.WellAllocationFromRow(reader);
				//		  allocations.Add(a);
				//		  return a;
				//	 });
				//}
            return allocations;
        }

        private WellAllocation WellAllocationFromRow(OdbcDataReader reader) {
            WellAllocation alloc = new WellAllocation();
            alloc.OperativeDate = reader.GetDateTime(reader.GetOrdinal("PROD_DATE"));
            var dbOil = reader["OIL_VOLUME"]; // In bbls
            var dbGas = reader["GAS_VOLUME"]; // In Mscf
            var dbWater = reader["WATER_VOLUME"]; // In bbls
            var dbWaterInjection = reader["WATER_INJECTED_VOLUME"]; // In bbls
            var dbGasInjection = reader["GAS_INJECTED_VOLUME"]; // In Mscf
            var dbDisposalInjection = reader["WATER_DISPOSAL_VOLUME"]; // In bbls
            var dbEffectiveTime = reader["UPTIME_OPERATING_PRODUCING"];

            alloc.Oil_Bbls = DBNull.Value.Equals(dbOil) ? 0.0 : double.Parse(dbOil.ToString());
            alloc.Gas_Mscf = DBNull.Value.Equals(dbGas) ? 0.0 : double.Parse(dbGas.ToString());
            alloc.Water_Bbls = DBNull.Value.Equals(dbWater) ? 0.0 : double.Parse(dbWater.ToString());
            alloc.WaterInjection_Bbls = DBNull.Value.Equals(dbWaterInjection) ? 0.0 : double.Parse(dbWaterInjection.ToString());
            alloc.DisposalInjection_Bbls = DBNull.Value.Equals(dbDisposalInjection) ? 0.0 : double.Parse(dbDisposalInjection.ToString());
            alloc.EffectiveTime = DBNull.Value.Equals(dbEffectiveTime) ? 0.0 : double.Parse(dbEffectiveTime.ToString());

            return alloc;
        }

        private string ProductionTable() {
            if (this.frequency == Frequency.Daily)
                return "V_PRODUCTION_DAILY_DATA";
            else
                return "V_PRODUCTION_MONTHLY_DATA";
        }
    }
}
