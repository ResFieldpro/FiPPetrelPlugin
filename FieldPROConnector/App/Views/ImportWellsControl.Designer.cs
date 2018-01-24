namespace FieldPROConnector
{
    partial class ImportWellsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.toolTipHotspot13 = new Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot(this.components);
			this.label11 = new System.Windows.Forms.Label();
			this.countryComboBox = new System.Windows.Forms.ComboBox();
			this.toolTipHotspot9 = new Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot(this.components);
			this.toolTipHotspot8 = new Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot(this.components);
			this.toolTipHotspot7 = new Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot(this.components);
			this.toolTipHotspot6 = new Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot(this.components);
			this.btnLoadWells = new System.Windows.Forms.Button();
			this.btnImportWells = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.wellsListBox = new System.Windows.Forms.CheckedListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.selectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.unselectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.fieldComboBox = new System.Windows.Forms.ComboBox();
			this.areaComboBox = new System.Windows.Forms.ComboBox();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolTipHotspot13
			// 
			this.toolTipHotspot13.Location = new System.Drawing.Point(312, 32);
			this.toolTipHotspot13.Name = "toolTipHotspot13";
			this.toolTipHotspot13.Size = new System.Drawing.Size(20, 20);
			this.toolTipHotspot13.TabIndex = 29;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(2, 35);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 13);
			this.label11.TabIndex = 28;
			this.label11.Text = "Country:";
			// 
			// countryComboBox
			// 
			this.countryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.countryComboBox.FormattingEnabled = true;
			this.countryComboBox.Location = new System.Drawing.Point(73, 32);
			this.countryComboBox.Name = "countryComboBox";
			this.countryComboBox.Size = new System.Drawing.Size(232, 21);
			this.countryComboBox.TabIndex = 27;
			this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBoxSelectedIndexChanged);
			// 
			// toolTipHotspot9
			// 
			this.toolTipHotspot9.Location = new System.Drawing.Point(180, 4);
			this.toolTipHotspot9.Name = "toolTipHotspot9";
			this.toolTipHotspot9.Size = new System.Drawing.Size(20, 20);
			this.toolTipHotspot9.TabIndex = 26;
			// 
			// toolTipHotspot8
			// 
			this.toolTipHotspot8.Location = new System.Drawing.Point(312, 116);
			this.toolTipHotspot8.Name = "toolTipHotspot8";
			this.toolTipHotspot8.Size = new System.Drawing.Size(20, 20);
			this.toolTipHotspot8.TabIndex = 25;
			// 
			// toolTipHotspot7
			// 
			this.toolTipHotspot7.Location = new System.Drawing.Point(312, 86);
			this.toolTipHotspot7.Name = "toolTipHotspot7";
			this.toolTipHotspot7.Size = new System.Drawing.Size(20, 20);
			this.toolTipHotspot7.TabIndex = 24;
			// 
			// toolTipHotspot6
			// 
			this.toolTipHotspot6.Location = new System.Drawing.Point(312, 59);
			this.toolTipHotspot6.Name = "toolTipHotspot6";
			this.toolTipHotspot6.Size = new System.Drawing.Size(20, 20);
			this.toolTipHotspot6.TabIndex = 23;
			// 
			// btnLoadWells
			// 
			this.btnLoadWells.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLoadWells.Location = new System.Drawing.Point(73, 3);
			this.btnLoadWells.Name = "btnLoadWells";
			this.btnLoadWells.Size = new System.Drawing.Size(100, 23);
			this.btnLoadWells.TabIndex = 22;
			this.btnLoadWells.Text = "Load Wells";
			this.btnLoadWells.UseVisualStyleBackColor = true;
			this.btnLoadWells.Click += new System.EventHandler(this.btnLoadWells_Click);
			// 
			// btnImportWells
			// 
			this.btnImportWells.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnImportWells.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImportWells.Location = new System.Drawing.Point(128, 259);
			this.btnImportWells.Name = "btnImportWells";
			this.btnImportWells.Size = new System.Drawing.Size(100, 23);
			this.btnImportWells.TabIndex = 21;
			this.btnImportWells.Text = "Import";
			this.btnImportWells.UseVisualStyleBackColor = true;
			this.btnImportWells.Click += new System.EventHandler(this.btnImportWells_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(2, 116);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "Wells:";
			// 
			// wellsListBox
			// 
			this.wellsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.wellsListBox.CheckOnClick = true;
			this.wellsListBox.ContextMenuStrip = this.contextMenuStrip1;
			this.wellsListBox.FormattingEnabled = true;
			this.wellsListBox.Location = new System.Drawing.Point(73, 116);
			this.wellsListBox.Name = "wellsListBox";
			this.wellsListBox.Size = new System.Drawing.Size(232, 124);
			this.wellsListBox.TabIndex = 19;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAll,
            this.unselectAll});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
			// 
			// selectAll
			// 
			this.selectAll.Name = "selectAll";
			this.selectAll.Size = new System.Drawing.Size(128, 22);
			this.selectAll.Text = "Select all";
			this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
			// 
			// unselectAll
			// 
			this.unselectAll.Name = "unselectAll";
			this.unselectAll.Size = new System.Drawing.Size(128, 22);
			this.unselectAll.Text = "Unselect all";
			this.unselectAll.Click += new System.EventHandler(this.unselectAll_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(2, 89);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Field:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(2, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Area:";
			// 
			// fieldComboBox
			// 
			this.fieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.fieldComboBox.FormattingEnabled = true;
			this.fieldComboBox.Location = new System.Drawing.Point(73, 86);
			this.fieldComboBox.Name = "fieldComboBox";
			this.fieldComboBox.Size = new System.Drawing.Size(232, 21);
			this.fieldComboBox.TabIndex = 16;
			this.fieldComboBox.SelectedIndexChanged += new System.EventHandler(this.fieldComboBoxSelectedIndexChanged);
			// 
			// areaComboBox
			// 
			this.areaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.areaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.areaComboBox.FormattingEnabled = true;
			this.areaComboBox.Location = new System.Drawing.Point(73, 59);
			this.areaComboBox.Name = "areaComboBox";
			this.areaComboBox.Size = new System.Drawing.Size(232, 21);
			this.areaComboBox.TabIndex = 15;
			this.areaComboBox.SelectedIndexChanged += new System.EventHandler(this.areaComboBoxSelectedIndexChanged);
			// 
			// ImportWellsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toolTipHotspot13);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.countryComboBox);
			this.Controls.Add(this.toolTipHotspot9);
			this.Controls.Add(this.toolTipHotspot8);
			this.Controls.Add(this.toolTipHotspot7);
			this.Controls.Add(this.toolTipHotspot6);
			this.Controls.Add(this.btnLoadWells);
			this.Controls.Add(this.btnImportWells);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.wellsListBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.fieldComboBox);
			this.Controls.Add(this.areaComboBox);
			this.Name = "ImportWellsControl";
			this.Size = new System.Drawing.Size(360, 300);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot toolTipHotspot13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox countryComboBox;
        private Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot toolTipHotspot9;
        private Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot toolTipHotspot8;
        private Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot toolTipHotspot7;
        private Slb.Ocean.Petrel.UI.Controls.ToolTipHotspot toolTipHotspot6;
        private System.Windows.Forms.Button btnLoadWells;
        private System.Windows.Forms.Button btnImportWells;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox wellsListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAll;
		  private System.Windows.Forms.ToolStripMenuItem unselectAll;
    }
}
