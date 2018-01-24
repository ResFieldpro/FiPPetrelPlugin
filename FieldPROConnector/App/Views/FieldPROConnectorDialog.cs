using Slb.Ocean.Core;
using Slb.Ocean.Petrel;
using Slb.Ocean.Petrel.DomainObject.Well;
using Slb.Ocean.Petrel.UI;
using Slb.Ocean.Petrel.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FieldPROConnector
{
	public partial class FieldPROConnectorDialog : Form
	{
		public FieldPROConnectorDialog()
		{
			InitializeComponent();

			this.btnCancel.Image = PetrelImages.Cancel;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.FindForm().Close();
		}

		private void importFilesControl1_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			WellRoot wellRoot = WellRoot.Get(PetrelProject.PrimaryProject);
			BoreholeCollection boreholeColl = wellRoot.BoreholeCollection;
			string text = "";
			foreach (Borehole bh in boreholeColl)
			{
				bool bok = false;
				foreach (object itemChecked in WellsList.CheckedItems)
				{
					if (itemChecked.ToString() == bh.Name)
					{
						bok = true;
						break;
					}
				}
				if (!bok)
					continue;
				PetrelLogger.InfoOutputWindow("Loading: " + bh.Name);
				Well w = WellsImporter.Borehole2Well(bh);
				text += w.Serialize() + Environment.NewLine;
				//IEnumerable<TrajectoryRecord> ie = bh.Trajectory.Records;
				//foreach (TrajectoryRecord r in ie)
				//{
				//	PetrelLogger.InfoOutputWindow(string.Format("data: {0}, {1}, {2}", r.MD, r.Inclination, r.Azimuth));
				//}
			}
			if (!string.IsNullOrEmpty(text))
			{
				string datafile = System.IO.Path.GetTempPath() + "petrelwells.txt";
				System.IO.File.WriteAllText(datafile, Well.TxtHeader + Environment.NewLine + text);
				string migfile = AssemblyDirectory + "\\Petrelwells.mig";
				WebImporterWrapper wi = new WebImporterWrapper(WebConfiguration.Current);
				int id = wi.UploadWells(datafile, migfile);
			}
		}
		public static string AssemblyDirectory
		{
			get
			{
				string codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
				UriBuilder uri = new UriBuilder(codeBase);
				string path = Uri.UnescapeDataString(uri.Path);
				return Path.GetDirectoryName(path);
			}
		}
		private bool bwellsshown = false;
		public class MyListBoxItem
		{
			public string Text { get; set; }
			public string Value { get; set; }
		}
		private void tabPage4_Paint(object sender, PaintEventArgs e)
		{
			if (!bwellsshown)
			{
				bwellsshown = true;
				WellsList.Items.Clear();
				WellRoot wellRoot = WellRoot.Get(PetrelProject.PrimaryProject);
				BoreholeCollection boreholeColl = wellRoot.BoreholeCollection;
				foreach (Borehole bh in boreholeColl)
				{
					WellsList.Items.Add(bh.Name, true);
				}
			}
		}
	}
}
