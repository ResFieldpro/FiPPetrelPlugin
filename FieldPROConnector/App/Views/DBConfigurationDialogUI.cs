using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Slb.Ocean.Petrel.UI;

namespace FieldPROConnector
{
	partial class DBConfigurationDialogUI : Form
	{
		public DBConfigurationDialogUI()
		{
			InitializeComponent();
			this.btnOK.Image = PetrelImages.OK;
			this.btnCancel.Image = PetrelImages.Cancel;
			this.btnApply.Image = PetrelImages.Apply;
			this.UpdateGuiFromModel();
		}
		private void UpdateGuiFromModel()
		{
			var dcInfo = WebConfiguration.Current;
			this.WebServerTextBox.Text = dcInfo.WebServer;
			this.WebServerUTextBox.Text = dcInfo.WebServerU;
			this.WebServerPTextBox.Text = dcInfo.WebServerP;
		}
		private void UpdateModelFromGui()
		{
			var dcInfo = WebConfiguration.Current;
			dcInfo.WebServer = this.WebServerTextBox.Text;
			dcInfo.WebServerU = this.WebServerUTextBox.Text;
			dcInfo.WebServerP = this.WebServerPTextBox.Text;
			dcInfo.WriteToRegistry();
		}
		private void btnTestConnection_Click(object sender, EventArgs e)
		{
			UpdateModelFromGui();
			WebConfiguration.Current.TestConnection(true);
		}
		private void btnApply_Click(object sender, EventArgs e)
		{
			this.UpdateModelFromGui();
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			this.btnApply_Click(sender, e);
			this.FindForm().Close();
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.FindForm().Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			WebImporterWrapper wi = new WebImporterWrapper(this.WebServerTextBox.Text, this.WebServerUTextBox.Text, this.WebServerPTextBox.Text);
			if (wi.TestWebServer())
			{
				MessageBox.Show("Successfully connected to eFieldpro web server.", "Fieldpro connector");
			}
			else
			{
				MessageBox.Show("Failed to connect to eFieldpro web server.", "Fieldpro connector");
			}
		}
	}
}
