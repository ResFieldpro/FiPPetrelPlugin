using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FieldPROConnector {
    class WellLogFile {
        private WellLogFile parent;

        public string ID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string ParentID { get; set; }
        public string FullPath {
            get {
                if (HasParent()) { return this.Parent.Path + "\\" + this.Path; } else { return this.Path; }
            }
        }

        public WellLogFile Parent {
            get {
                if (HasParent()) { parent = this; } else { parent = Broker.GetWithID(ParentID).First(); }
                return parent;
            }
        }

        private bool HasParent() {
            return !String.IsNullOrEmpty(this.ParentID);
        }

        public bool IsFile {
            get {
                return File.Exists(this.FullPath);
            }
        }

        public bool IsFolder {
            get {
                return Directory.Exists(this.FullPath);
            }
        }

        public string Status {
            get {
                if (IsFolder) { return "Folder OK"; } else { if (IsFile) { return "File OK"; } else { return "Invalid!"; } }
            }
        }

        public static WellLogFileBroker Broker {
            get {
                return new WellLogFileBroker(WebConfiguration.Current);
            }
        }
    }
}
