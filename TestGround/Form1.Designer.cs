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
            this.components = new System.ComponentModel.Container();
            this.flatPropertyGrid1 = new Abeo.Controls.FlatPropertyGrid();
            this.logView1 = new LotusAPI.Controls.LogView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.roundImageView1 = new Abeo.Controls.Roundable.RoundImageView();
            this.roundImageView2 = new Abeo.Controls.Roundable.RoundImageView();
            this.roundImageView3 = new Abeo.Controls.Roundable.RoundImageView();
            this.roundImageView4 = new Abeo.Controls.Roundable.RoundImageView();
            this.flatTheme1 = new Abeo.Controls.FlatTheme(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flatPropertyGrid1
            // 
            this.flatPropertyGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatPropertyGrid1.CategoryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.flatPropertyGrid1.CategorySplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatPropertyGrid1.CommandsActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(59)))), ((int)(((byte)(39)))));
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
            this.flatPropertyGrid1.Location = new System.Drawing.Point(629, 0);
            this.flatPropertyGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flatPropertyGrid1.Name = "flatPropertyGrid1";
            this.flatPropertyGrid1.SelectedItemWithFocusBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.flatPropertyGrid1.SelectedItemWithFocusForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatPropertyGrid1.Size = new System.Drawing.Size(276, 435);
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
            this.logView1.ColorError = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.logView1.Size = new System.Drawing.Size(629, 435);
            this.logView1.TabIndex = 0;
            this.logView1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(609, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 104);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roundImageView1
            // 
            this.roundImageView1.BackColor = System.Drawing.Color.Transparent;
            this.roundImageView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.roundImageView1.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.roundImageView1.BorderRadius = 10;
            this.roundImageView1.BorderThickness = 0;
            this.roundImageView1.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView1.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.roundImageView1.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView1.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.roundImageView1.DebugMode = false;
            this.roundImageView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roundImageView1.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView1.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundImageView1.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundImageView1.Icon = null;
            this.roundImageView1.IconPortion = 0.3F;
            this.roundImageView1.IconSize = 24;
            this.roundImageView1.IconVisible = false;
            this.roundImageView1.Image = null;
            this.roundImageView1.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Zoom;
            this.roundImageView1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.roundImageView1.Location = new System.Drawing.Point(579, 0);
            this.roundImageView1.MouseMoveEventPeriod = 100;
            this.roundImageView1.Name = "roundImageView1";
            this.roundImageView1.Size = new System.Drawing.Size(160, 118);
            this.roundImageView1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.roundImageView1.TabIndex = 4;
            this.roundImageView1.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.roundImageView1.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.roundImageView1.TagOffset = 5;
            this.roundImageView1.TagVisible = false;
            this.roundImageView1.TagWidth = 5;
            this.roundImageView1.Text = null;
            this.roundImageView1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundImageView1.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundImageView1.Theme = null;
            // 
            // roundImageView2
            // 
            this.roundImageView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.roundImageView2.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.roundImageView2.BorderRadius = 10;
            this.roundImageView2.BorderThickness = 0;
            this.roundImageView2.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.roundImageView2.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.roundImageView2.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.roundImageView2.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView2.DebugMode = false;
            this.roundImageView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roundImageView2.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.roundImageView2.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundImageView2.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.roundImageView2.Icon = null;
            this.roundImageView2.IconPortion = 0.3F;
            this.roundImageView2.IconSize = 24;
            this.roundImageView2.IconVisible = false;
            this.roundImageView2.Image = null;
            this.roundImageView2.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Zoom;
            this.roundImageView2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.roundImageView2.Location = new System.Drawing.Point(745, 0);
            this.roundImageView2.MouseMoveEventPeriod = 100;
            this.roundImageView2.Name = "roundImageView2";
            this.roundImageView2.Size = new System.Drawing.Size(160, 118);
            this.roundImageView2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.roundImageView2.TabIndex = 4;
            this.roundImageView2.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.roundImageView2.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.roundImageView2.TagOffset = 5;
            this.roundImageView2.TagVisible = false;
            this.roundImageView2.TagWidth = 5;
            this.roundImageView2.Text = null;
            this.roundImageView2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundImageView2.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundImageView2.Theme = null;
            // 
            // roundImageView3
            // 
            this.roundImageView3.BackColor = System.Drawing.Color.Transparent;
            this.roundImageView3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.roundImageView3.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.roundImageView3.BorderRadius = 10;
            this.roundImageView3.BorderThickness = 0;
            this.roundImageView3.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView3.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.roundImageView3.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView3.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.roundImageView3.DebugMode = false;
            this.roundImageView3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roundImageView3.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView3.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundImageView3.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundImageView3.Icon = null;
            this.roundImageView3.IconPortion = 0.3F;
            this.roundImageView3.IconSize = 24;
            this.roundImageView3.IconVisible = false;
            this.roundImageView3.Image = null;
            this.roundImageView3.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Zoom;
            this.roundImageView3.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.roundImageView3.Location = new System.Drawing.Point(579, 124);
            this.roundImageView3.MouseMoveEventPeriod = 100;
            this.roundImageView3.Name = "roundImageView3";
            this.roundImageView3.Size = new System.Drawing.Size(160, 118);
            this.roundImageView3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.roundImageView3.TabIndex = 4;
            this.roundImageView3.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.roundImageView3.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.roundImageView3.TagOffset = 5;
            this.roundImageView3.TagVisible = false;
            this.roundImageView3.TagWidth = 5;
            this.roundImageView3.Text = null;
            this.roundImageView3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundImageView3.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundImageView3.Theme = null;
            // 
            // roundImageView4
            // 
            this.roundImageView4.BackColor = System.Drawing.Color.Transparent;
            this.roundImageView4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.roundImageView4.BorderCorners = Abeo.Controls.Roundable.Corners.All;
            this.roundImageView4.BorderRadius = 10;
            this.roundImageView4.BorderThickness = 0;
            this.roundImageView4.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView4.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(212)))));
            this.roundImageView4.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView4.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(77)))));
            this.roundImageView4.DebugMode = false;
            this.roundImageView4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roundImageView4.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.roundImageView4.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundImageView4.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.roundImageView4.Icon = null;
            this.roundImageView4.IconPortion = 0.3F;
            this.roundImageView4.IconSize = 24;
            this.roundImageView4.IconVisible = false;
            this.roundImageView4.Image = null;
            this.roundImageView4.ImageSizeMode = Abeo.Controls.Roundable.SizeMode.Zoom;
            this.roundImageView4.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            this.roundImageView4.Location = new System.Drawing.Point(745, 124);
            this.roundImageView4.MouseMoveEventPeriod = 100;
            this.roundImageView4.Name = "roundImageView4";
            this.roundImageView4.Size = new System.Drawing.Size(160, 118);
            this.roundImageView4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.roundImageView4.TabIndex = 4;
            this.roundImageView4.TagColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(66)))), ((int)(((byte)(129)))));
            this.roundImageView4.TagLocation = Abeo.Controls.Roundable.TagLocation.Left;
            this.roundImageView4.TagOffset = 5;
            this.roundImageView4.TagVisible = false;
            this.roundImageView4.TagWidth = 5;
            this.roundImageView4.Text = null;
            this.roundImageView4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.roundImageView4.TextIconRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundImageView4.Theme = null;
            // 
            // flatTheme1
            // 
            this.flatTheme1.BackColor = System.Drawing.Color.Transparent;
            this.flatTheme1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(110)))), ((int)(((byte)(118)))));
            this.flatTheme1.BorderRadius = 10;
            this.flatTheme1.BorderThickness = 0;
            this.flatTheme1.ContentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatTheme1.ContentBackColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.flatTheme1.ContentBackColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.flatTheme1.ContentBackColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.flatTheme1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.flatTheme1.ForeColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatTheme1.ForeColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.flatTheme1.ForeColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.flatTheme1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.flatTheme1.ProgressForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 435);
            this.Controls.Add(this.roundImageView4);
            this.Controls.Add(this.roundImageView3);
            this.Controls.Add(this.roundImageView2);
            this.Controls.Add(this.roundImageView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logView1);
            this.Controls.Add(this.flatPropertyGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LotusAPI.Controls.LogView logView1;
        private Abeo.Controls.FlatPropertyGrid flatPropertyGrid1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Abeo.Controls.Roundable.RoundImageView roundImageView1;
        private Abeo.Controls.Roundable.RoundImageView roundImageView2;
        private Abeo.Controls.Roundable.RoundImageView roundImageView3;
        private Abeo.Controls.Roundable.RoundImageView roundImageView4;
        private Abeo.Controls.FlatTheme flatTheme1;
    }
}

