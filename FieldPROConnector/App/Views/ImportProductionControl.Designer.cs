namespace FieldPROConnector {
    partial class ImportProductionControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnImportWellObservedData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTipHotspot11 = new Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot(this.components);
            this.toolTipHotspot10 = new Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot(this.components);
            this.radioDaily = new System.Windows.Forms.RadioButton();
            this.radioMonthly = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtpEnd);
            this.groupBox2.Controls.Add(this.dtpStart);
            this.groupBox2.Location = new System.Drawing.Point(30, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Period";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "End:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Start:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = false;
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(107, 58);
            this.dtpEnd.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowCheckBox = true;
            this.dtpEnd.Size = new System.Drawing.Size(110, 20);
            this.dtpEnd.TabIndex = 1;
            this.dtpEnd.Value = new System.DateTime(2013, 7, 31, 14, 28, 59, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = false;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(107, 31);
            this.dtpStart.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowCheckBox = true;
            this.dtpStart.Size = new System.Drawing.Size(110, 20);
            this.dtpStart.TabIndex = 0;
            // 
            // btnImportWellObservedData
            // 
            this.btnImportWellObservedData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportWellObservedData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportWellObservedData.Location = new System.Drawing.Point(226, 274);
            this.btnImportWellObservedData.Name = "btnImportWellObservedData";
            this.btnImportWellObservedData.Size = new System.Drawing.Size(100, 23);
            this.btnImportWellObservedData.TabIndex = 10;
            this.btnImportWellObservedData.Text = "Import";
            this.btnImportWellObservedData.UseVisualStyleBackColor = true;
            this.btnImportWellObservedData.Click += new System.EventHandler(this.btnImportWellObservedData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolTipHotspot11);
            this.groupBox1.Controls.Add(this.toolTipHotspot10);
            this.groupBox1.Controls.Add(this.radioDaily);
            this.groupBox1.Controls.Add(this.radioMonthly);
            this.groupBox1.Location = new System.Drawing.Point(30, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Production type";
            // 
            // toolTipHotspot11
            // 
            this.toolTipHotspot11.Location = new System.Drawing.Point(125, 52);
            this.toolTipHotspot11.Name = "toolTipHotspot11";
            this.toolTipHotspot11.Size = new System.Drawing.Size(20, 20);
            this.toolTipHotspot11.TabIndex = 3;
            // 
            // toolTipHotspot10
            // 
            this.toolTipHotspot10.Location = new System.Drawing.Point(125, 29);
            this.toolTipHotspot10.Name = "toolTipHotspot10";
            this.toolTipHotspot10.Size = new System.Drawing.Size(20, 20);
            this.toolTipHotspot10.TabIndex = 2;
            // 
            // radioDaily
            // 
            this.radioDaily.AutoSize = true;
            this.radioDaily.Location = new System.Drawing.Point(38, 29);
            this.radioDaily.Name = "radioDaily";
            this.radioDaily.Size = new System.Drawing.Size(48, 17);
            this.radioDaily.TabIndex = 0;
            this.radioDaily.Text = "Daily";
            this.radioDaily.UseVisualStyleBackColor = true;
            // 
            // radioMonthly
            // 
            this.radioMonthly.AutoSize = true;
            this.radioMonthly.Checked = true;
            this.radioMonthly.Location = new System.Drawing.Point(38, 52);
            this.radioMonthly.Name = "radioMonthly";
            this.radioMonthly.Size = new System.Drawing.Size(62, 17);
            this.radioMonthly.TabIndex = 1;
            this.radioMonthly.TabStop = true;
            this.radioMonthly.Text = "Monthly";
            this.radioMonthly.UseVisualStyleBackColor = true;
            // 
            // ImportProductionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnImportWellObservedData);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImportProductionControl";
            this.Size = new System.Drawing.Size(381, 309);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnImportWellObservedData;
        private System.Windows.Forms.GroupBox groupBox1;
        private Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot toolTipHotspot11;
        private Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot toolTipHotspot10;
        private System.Windows.Forms.RadioButton radioDaily;
        private System.Windows.Forms.RadioButton radioMonthly;
    }
}
