using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;

namespace FieldPROConnector {

    enum StandardType {
        None,
        Casing,
        Tubing,
        Liner,
        Pump
    }

    class WellboreGroup {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TopDepth { get; set; }
        public double BaseDepth { get; set; }
        public int StandardType { get; set; }

        public override string ToString() {
            return this.Name;
        }

        public static WellboreGroupBroker Broker {
            get {
                return new WellboreGroupBroker(WebConfiguration.Current);
            }
        }

    }

}

