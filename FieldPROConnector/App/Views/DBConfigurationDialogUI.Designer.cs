namespace FieldPROConnector
{
    partial class DBConfigurationDialogUI
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnApply = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.WebServerPTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.WebServerUTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.WebServerTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.toolTipManager1 = new Slb.Ocean.Petrel.UI.Controls.ToolTipManager(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolTipManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnOK);
			this.panel2.Controls.Add(this.btnApply);
			this.panel2.Location = new System.Drawing.Point(1, 263);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(402, 37);
			this.panel2.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(312, 7);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOK.Location = new System.Drawing.Point(231, 7);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnApply
			// 
			this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnApply.Location = new System.Drawing.Point(150, 7);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(75, 23);
			this.btnApply.TabIndex = 4;
			this.btnApply.Text = "&Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.WebServerPTextBox);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.WebServerUTextBox);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.WebServerTextBox);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(402, 257);
			this.panel1.TabIndex = 2;
			// 
			// WebServerPTextBox
			// 
			this.WebServerPTextBox.Location = new System.Drawing.Point(115, 64);
			this.WebServerPTextBox.Name = "WebServerPTextBox";
			this.WebServerPTextBox.PasswordChar = '*';
			this.WebServerPTextBox.Size = new System.Drawing.Size(233, 20);
			this.WebServerPTextBox.TabIndex = 41;
			this.WebServerPTextBox.Text = "web";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(34, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 13);
			this.label9.TabIndex = 40;
			this.label9.Text = "Password:";
			// 
			// WebServerUTextBox
			// 
			this.WebServerUTextBox.Location = new System.Drawing.Point(115, 38);
			this.WebServerUTextBox.Name = "WebServerUTextBox";
			this.WebServerUTextBox.Size = new System.Drawing.Size(233, 20);
			this.WebServerUTextBox.TabIndex = 39;
			this.WebServerUTextBox.Text = "web";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(34, 38);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 38;
			this.label8.Text = "User:";
			// 
			// WebServerTextBox
			// 
			this.WebServerTextBox.Location = new System.Drawing.Point(115, 12);
			this.WebServerTextBox.Name = "WebServerTextBox";
			this.WebServerTextBox.Size = new System.Drawing.Size(233, 20);
			this.WebServerTextBox.TabIndex = 36;
			this.WebServerTextBox.Text = "http://localhost/eFIELDPRO/";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 13);
			this.label6.TabIndex = 35;
			this.label6.Text = "Web Server:";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(115, 90);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(233, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Test connection...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// DBConfigurationDialogUI
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(403, 302);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DBConfigurationDialogUI";
			this.ShowInTaskbar = false;
			this.Text = "FIELDPRO database connection configuration";
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolTipManager1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnApply;
		  private System.Windows.Forms.Panel panel1;
        private Slb.Ocean.Petrel.UI.Controls.ToolTipManager toolTipManager1;
		  private System.Windows.Forms.TextBox WebServerTextBox;
		  private System.Windows.Forms.Label label6;
		  private System.Windows.Forms.TextBox WebServerPTextBox;
		  private System.Windows.Forms.Label label9;
		  private System.Windows.Forms.TextBox WebServerUTextBox;
		  private System.Windows.Forms.Label label8;
		  private System.Windows.Forms.Button button1;

    }
}
