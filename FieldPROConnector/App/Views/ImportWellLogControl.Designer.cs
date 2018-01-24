namespace FieldPROConnector {
    partial class ImportWellLogControl {
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
            this.importFiles = new System.Windows.Forms.Button();
            this.wellLogs = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLoadWellLogs = new System.Windows.Forms.Button();
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // importFiles
            // 
            this.importFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importFiles.Location = new System.Drawing.Point(233, 277);
            this.importFiles.Name = "importFiles";
            this.importFiles.Size = new System.Drawing.Size(90, 23);
            this.importFiles.TabIndex = 0;
            this.importFiles.Text = "Import Files...";
            this.importFiles.UseVisualStyleBackColor = true;
            this.importFiles.Click += new System.EventHandler(this.ImportCheckedFiles);
            // 
            // wellLogs
            // 
            this.wellLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wellLogs.CheckBoxes = true;
            this.wellLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.path,
            this.status});
            this.wellLogs.ContextMenuStrip = this.contextMenuStrip1;
            this.wellLogs.FullRowSelect = true;
            this.wellLogs.Location = new System.Drawing.Point(3, 44);
            this.wellLogs.Name = "wellLogs";
            this.wellLogs.Size = new System.Drawing.Size(331, 222);
            this.wellLogs.TabIndex = 2;
            this.wellLogs.UseCompatibleStateImageBehavior = false;
            this.wellLogs.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 89;
            // 
            // path
            // 
            this.path.Text = "Path";
            this.path.Width = 136;
            // 
            // btnLoadWellLogs
            // 
            this.btnLoadWellLogs.Location = new System.Drawing.Point(3, 11);
            this.btnLoadWellLogs.Name = "btnLoadWellLogs";
            this.btnLoadWellLogs.Size = new System.Drawing.Size(100, 23);
            this.btnLoadWellLogs.TabIndex = 3;
            this.btnLoadWellLogs.Text = "Load Well Logs";
            this.btnLoadWellLogs.UseVisualStyleBackColor = true;
            this.btnLoadWellLogs.Click += new System.EventHandler(this.btnLoadWellLogs_Click);
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAll,
            this.unselectAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // selectAll
            // 
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(134, 22);
            this.selectAll.Text = "Select all";
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // unselectAll
            // 
            this.unselectAll.Name = "unselectAll";
            this.unselectAll.Size = new System.Drawing.Size(134, 22);
            this.unselectAll.Text = "Unselect all";
            this.unselectAll.Click += new System.EventHandler(this.unselectAll_Click);
            // 
            // ImportWellLogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoadWellLogs);
            this.Controls.Add(this.wellLogs);
            this.Controls.Add(this.importFiles);
            this.Name = "ImportWellLogControl";
            this.Size = new System.Drawing.Size(337, 312);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importFiles;
        private System.Windows.Forms.ListView wellLogs;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.Button btnLoadWellLogs;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAll;
        private System.Windows.Forms.ToolStripMenuItem unselectAll;
    }
}
