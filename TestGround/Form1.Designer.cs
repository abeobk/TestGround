namespace TestGround {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.flatPropertyGrid1 = new Abeo.Controls.FlatPropertyGrid();
            this.logView1 = new LotusAPI.Controls.LogView();
            this.SuspendLayout();
            // 
            // flatPropertyGrid1
            // 
            this.flatPropertyGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatPropertyGrid1.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.flatPropertyGrid1.CategorySplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatPropertyGrid1.CommandsBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatPropertyGrid1.CommandsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.flatPropertyGrid1.CommandsLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.flatPropertyGrid1.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.flatPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flatPropertyGrid1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatPropertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatPropertyGrid1.HelpBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatPropertyGrid1.HelpForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.flatPropertyGrid1.HelpVisible = false;
            this.flatPropertyGrid1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.flatPropertyGrid1.Location = new System.Drawing.Point(594, 0);
            this.flatPropertyGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flatPropertyGrid1.Name = "flatPropertyGrid1";
            this.flatPropertyGrid1.SelectedItemWithFocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.flatPropertyGrid1.SelectedItemWithFocusForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatPropertyGrid1.Size = new System.Drawing.Size(624, 926);
            this.flatPropertyGrid1.TabIndex = 1;
            this.flatPropertyGrid1.ToolbarVisible = false;
            this.flatPropertyGrid1.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatPropertyGrid1.ViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatPropertyGrid1.ViewForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            // 
            // logView1
            // 
            this.logView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.logView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logView1.ColorDateTime = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.logView1.ColorDebug = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.logView1.ColorError = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
            this.logView1.ColorFatal = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.logView1.ColorInfo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.logView1.ColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.logView1.ColorTrace = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.logView1.ColorWarning = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.logView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logView1.Font = new System.Drawing.Font("Consolas", 9F);
            this.logView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.logView1.Location = new System.Drawing.Point(0, 0);
            this.logView1.Name = "logView1";
            this.logView1.ReadOnly = true;
            this.logView1.ShowDateTime = false;
            this.logView1.Size = new System.Drawing.Size(594, 926);
            this.logView1.TabIndex = 0;
            this.logView1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 926);
            this.Controls.Add(this.logView1);
            this.Controls.Add(this.flatPropertyGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LotusAPI.Controls.LogView logView1;
        private Abeo.Controls.FlatPropertyGrid flatPropertyGrid1;
    }
}

