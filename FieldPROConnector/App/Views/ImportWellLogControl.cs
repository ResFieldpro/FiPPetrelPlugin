using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Slb.Ocean.Petrel;
using Slb.Ocean.Petrel.DomainObject.Well;

namespace FieldPROConnector {
	public partial class ImportWellLogControl : UserControl {
		public ImportWellLogControl() {
			InitializeComponent();
		}

		private void btnLoadWellLogs_Click(object sender, EventArgs e) {
			LoadWellLogs();
		}

		private void LoadWellLogs() {
			WellRoot wellRoot = WellRoot.Get(PetrelProject.PrimaryProject);
			BoreholeCollection boreholeColl = wellRoot.BoreholeCollection;
			WellLogImporter importer = new WellLogImporter();
			var files = importer.GetWellLogFiles(boreholeColl);
			SetWellLogsList(files);
		}

		private void SetWellLogsList(List<WellLogFile> files) {
			wellLogs.Items.Clear();
			foreach (var f in files) {
			string[] row = { f.Name, f.FullPath, f.Status };
			var listViewItem = new ListViewItem(row);
			listViewItem.Tag = f;
			wellLogs.Items.Add(listViewItem);   
			}
		}

		private void ImportCheckedFiles(object sender, EventArgs e)
		{
			WellLogImporter importer = new WellLogImporter();
			foreach (var f in wellLogs.CheckedItems)
			{
				var item = (ListViewItem)f;
				var file = (WellLogFile)item.Tag;
				if (file.IsFile){
					importer.ImportFile(file.FullPath, true);
				}
		 
			}
		}

		private void selectAll_Click(object sender, EventArgs e) {
			foreach (ListViewItem item in wellLogs.Items) {
				item.Checked = true;
			}
		}

		private void unselectAll_Click(object sender, EventArgs e) {
			foreach (ListViewItem item in wellLogs.Items) {
				item.Checked = false;
			}
		}

	  }
}
