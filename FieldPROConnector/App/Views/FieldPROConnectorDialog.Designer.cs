namespace FieldPROConnector
{
    partial class FieldPROConnectorDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.WellsList = new System.Windows.Forms.CheckedListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.importWellsControl1 = new FieldPROConnector.ImportWellsControl();
			this.importProductionControl1 = new FieldPROConnector.ImportProductionControl();
			this.importFilesControl1 = new FieldPROConnector.ImportWellLogControl();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(8, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(370, 334);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.importWellsControl1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(362, 308);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Wells";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.importProductionControl1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(362, 308);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Production";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.importFilesControl1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(362, 308);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "File Import";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.button1);
			this.tabPage4.Controls.Add(this.WellsList);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(362, 308);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Export Wells";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.tabPage4.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage4_Paint);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(281, 268);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Export";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// WellsList
			// 
			this.WellsList.FormattingEnabled = true;
			this.WellsList.Location = new System.Drawing.Point(3, 3);
			this.WellsList.Name = "WellsList";
			this.WellsList.Size = new System.Drawing.Size(353, 259);
			this.WellsList.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Location = new System.Drawing.Point(2, 352);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(391, 37);
			this.panel2.TabIndex = 2;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(301, 7);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Close";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// importWellsControl1
			// 
			this.importWellsControl1.Location = new System.Drawing.Point(0, 12);
			this.importWellsControl1.Name = "importWellsControl1";
			this.importWellsControl1.Size = new System.Drawing.Size(359, 296);
			this.importWellsControl1.TabIndex = 0;
			// 
			// importProductionControl1
			// 
			this.importProductionControl1.Location = new System.Drawing.Point(0, 12);
			this.importProductionControl1.Name = "importProductionControl1";
			this.importProductionControl1.Size = new System.Drawing.Size(359, 293);
			this.importProductionControl1.TabIndex = 0;
			// 
			// importFilesControl1
			// 
			this.importFilesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.importFilesControl1.Location = new System.Drawing.Point(3, 3);
			this.importFilesControl1.Name = "importFilesControl1";
			this.importFilesControl1.Size = new System.Drawing.Size(356, 302);
			this.importFilesControl1.TabIndex = 0;
			this.importFilesControl1.Load += new System.EventHandler(this.importFilesControl1_Load);
			// 
			// FieldPROConnectorDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 390);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FieldPROConnectorDialog";
			this.Text = "FIELDPRO Connector";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ImportWellsControl importWellsControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage tabPage2;
        private ImportProductionControl importProductionControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private ImportWellLogControl importFilesControl1;
		  private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
		  private System.Windows.Forms.CheckedListBox WellsList;
    }
}