using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;

namespace FieldPROConnector
{
    class WellAllocation
    {
        public string Uwi { get; set; }
        public DateTime OperativeDate { get; set; }
        public double Oil { get; set; }
        public double Gas { get; set; }
        public double Water { get; set; }
        public double WaterInjection { get; set; }
        public double DisposalInjection { get; set; }
        public double EffectiveTime { get; set; }

        public WellAllocation()
        {
            OperativeDate = DateTime.Now;
            Uwi = "";
            Oil = 0.0;
            Gas = 0.0;
            Water = 0.0;
            WaterInjection = 0.0;
            DisposalInjection = 0.0;
            EffectiveTime = 0.0;
        }

        public static WellAllocationBroker Broker(Frequency f) {
            return new WellAllocationBroker(WebConfiguration.Current, f);
        }
        public double Oil_Bbls { set { Oil = ConvertBblsToM3(value); } }
        public double Gas_Mscf { set { Gas = ConvertMscfToM3(value); } }
        public double Water_Bbls { set { Water = ConvertBblsToM3(value); } }
        public double WaterInjection_Bbls { set { WaterInjection = ConvertBblsToM3(value); } }
        public double DisposalInjection_Bbls { set { DisposalInjection = ConvertBblsToM3(value); } }
        private double ConvertBblsToM3(double value) {
            return value * 0.15899;
        }
        private double ConvertMscfToM3(double value) {
            return value * 0.028317 * 1000;
        }
    }
}