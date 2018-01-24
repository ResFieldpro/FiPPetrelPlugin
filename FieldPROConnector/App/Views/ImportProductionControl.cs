using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Slb.Ocean.Petrel.UI;

namespace FieldPROConnector {
    public partial class ImportProductionControl : UserControl {
        public ImportProductionControl() {
            InitializeComponent();

            this.btnImportWellObservedData.Image = PetrelImages.DownArrow;
        }

        private void btnImportWellObservedData_Click(object sender, EventArgs e) {
            var importer = new WellObservedDataImporter();
            try {
                Cursor.Current = Cursors.WaitCursor;
                importer.Import(this.GetImportFrequency(), this.dtpStart.Value, this.dtpStart.Checked, this.dtpEnd.Value, this.dtpEnd.Checked);
            }
            finally {
                Cursor.Current = Cursors.Default;
            }
        }

        private Frequency GetImportFrequency() {
            if (this.radioDaily.Checked)
                return Frequency.Daily;
            else
                return Frequency.Monthly;
        }
    }
}
