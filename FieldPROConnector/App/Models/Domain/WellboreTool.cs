using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;

namespace FieldPROConnector {

    enum UseType {
        Normal,
        CasingShoe,
        FluidFlow,
        Collar,
        Packer,
        LinerHanger,
        Plug,
        Nipple
    }

    class WellboreTool {
        public int ID { get; set; }
        public int GroupID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TopDepth { get; set; }
        public double BaseDepth { get; set; }
        public double Length { get; set; }
        public int UseType { get; set; }

        public override string ToString() {
            return this.Name;
        }

        /* TO_DO ESTE BROKER FALTA CREARLO
        public static WellboreToolBroker Broker {
            get {
                return new WellboreToolBroker(DBConfiguration.Current);
            }
        }*/

    }

}

