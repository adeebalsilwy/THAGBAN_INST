namespace THAGBAN_INST.FORM.FRM_CONTORL
{
    partial class analys_control_admin
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.ch_years = new DevExpress.XtraEditors.CheckEdit();
            this.com_years = new System.Windows.Forms.ComboBox();
            this.ch_spec = new DevExpress.XtraEditors.CheckEdit();
            this.com_spic = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_pad_y1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_good_y1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_pad_y2 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lbl_pad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_years.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_spec.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.chartControl1);
            this.panel13.Controls.Add(this.panel3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 378);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(956, 256);
            this.panel13.TabIndex = 9;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 209);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 47);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "تحتاج الى تحديث كافة البيانات في الصفحات البرنامج لجلب البيانات بشكل الصحيح";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(729, 6);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(224, 38);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "تحديث البيانات";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.ch_years);
            this.panel14.Controls.Add(this.com_years);
            this.panel14.Controls.Add(this.ch_spec);
            this.panel14.Controls.Add(this.com_spic);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(956, 69);
            this.panel14.TabIndex = 13;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // ch_years
            // 
            this.ch_years.Location = new System.Drawing.Point(499, 21);
            this.ch_years.Name = "ch_years";
            this.ch_years.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_years.Properties.Appearance.Options.UseFont = true;
            this.ch_years.Properties.Caption = "العام الدراسي";
            this.ch_years.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_years.Size = new System.Drawing.Size(111, 28);
            this.ch_years.TabIndex = 137;
            this.ch_years.CheckedChanged += new System.EventHandler(this.ch_years_CheckedChanged);
            // 
            // com_years
            // 
            this.com_years.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_years.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_years.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_years.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_years.FormattingEnabled = true;
            this.com_years.Location = new System.Drawing.Point(284, 14);
            this.com_years.Name = "com_years";
            this.com_years.Size = new System.Drawing.Size(165, 37);
            this.com_years.TabIndex = 136;
            this.com_years.SelectedIndexChanged += new System.EventHandler(this.com_years_SelectedIndexChanged);
            // 
            // ch_spec
            // 
            this.ch_spec.Location = new System.Drawing.Point(850, 21);
            this.ch_spec.Name = "ch_spec";
            this.ch_spec.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_spec.Properties.Appearance.Options.UseFont = true;
            this.ch_spec.Properties.Caption = "التخصص";
            this.ch_spec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_spec.Size = new System.Drawing.Size(94, 28);
            this.ch_spec.TabIndex = 135;
            this.ch_spec.CheckedChanged += new System.EventHandler(this.ch_lect_CheckedChanged_1);
            // 
            // com_spic
            // 
            this.com_spic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_spic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_spic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_spic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_spic.FormattingEnabled = true;
            this.com_spic.Location = new System.Drawing.Point(659, 18);
            this.com_spic.Name = "com_spic";
            this.com_spic.Size = new System.Drawing.Size(185, 37);
            this.com_spic.TabIndex = 120;
            this.com_spic.SelectedIndexChanged += new System.EventHandler(this.com_lect_SelectedIndexChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 634);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.panel15);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(956, 378);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::THAGBAN_INST.Properties.Resources.icons8_ok_200px1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_pad_y1
            // 
            this.lbl_pad_y1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pad_y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pad_y1.ForeColor = System.Drawing.Color.White;
            this.lbl_pad_y1.Location = new System.Drawing.Point(11, 147);
            this.lbl_pad_y1.Name = "lbl_pad_y1";
            this.lbl_pad_y1.Size = new System.Drawing.Size(94, 48);
            this.lbl_pad_y1.TabIndex = 2;
            this.lbl_pad_y1.Text = "0.00";
            this.lbl_pad_y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_pad_y1.Click += new System.EventHandler(this.lbl_good2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(369, 25);
            this.panel6.TabIndex = 3;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // lbl_good_y1
            // 
            this.lbl_good_y1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_good_y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_good_y1.ForeColor = System.Drawing.Color.White;
            this.lbl_good_y1.Location = new System.Drawing.Point(199, 147);
            this.lbl_good_y1.Name = "lbl_good_y1";
            this.lbl_good_y1.Size = new System.Drawing.Size(121, 48);
            this.lbl_good_y1.TabIndex = 4;
            this.lbl_good_y1.Text = "0.00";
            this.lbl_good_y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_good_y1.Click += new System.EventHandler(this.lbl_good1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(161, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 49);
            this.label4.TabIndex = 5;
            this.label4.Text = "الطلاب الناجحين ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lbl_good_y1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lbl_pad_y1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(430, 17);
            this.panel5.Margin = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 225);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::THAGBAN_INST.Properties.Resources.icons8_internal_96px_1;
            this.pictureBox6.Location = new System.Drawing.Point(11, 40);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(116, 79);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // lbl_pad_y2
            // 
            this.lbl_pad_y2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pad_y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pad_y2.ForeColor = System.Drawing.Color.White;
            this.lbl_pad_y2.Location = new System.Drawing.Point(3, 147);
            this.lbl_pad_y2.Name = "lbl_pad_y2";
            this.lbl_pad_y2.Size = new System.Drawing.Size(95, 48);
            this.lbl_pad_y2.TabIndex = 2;
            this.lbl_pad_y2.Text = "0.00";
            this.lbl_pad_y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_pad_y2.Click += new System.EventHandler(this.lbl_pad2_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(370, 25);
            this.panel16.TabIndex = 3;
            this.panel16.Paint += new System.Windows.Forms.PaintEventHandler(this.panel16_Paint);
            // 
            // lbl_pad
            // 
            this.lbl_pad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pad.ForeColor = System.Drawing.Color.White;
            this.lbl_pad.Location = new System.Drawing.Point(202, 147);
            this.lbl_pad.Name = "lbl_pad";
            this.lbl_pad.Size = new System.Drawing.Size(95, 48);
            this.lbl_pad.TabIndex = 4;
            this.lbl_pad.Text = "0.00";
            this.lbl_pad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_pad.Click += new System.EventHandler(this.lbl_pad1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(133, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 79);
            this.label3.TabIndex = 5;
            this.label3.Text = "الطلاب الراسبين ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel15.Controls.Add(this.label3);
            this.panel15.Controls.Add(this.lbl_pad);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.lbl_pad_y2);
            this.panel15.Controls.Add(this.pictureBox6);
            this.panel15.Location = new System.Drawing.Point(20, 17);
            this.panel15.Margin = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(370, 225);
            this.panel15.TabIndex = 6;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            // 
            // chartControl1
            // 
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_MARKS);
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.MarkerOffset = 1;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "TBL_COURS.COURS_NAME";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "TBL_SPECIAL.SPEC_NAME";
            this.chartControl1.SeriesTemplate.DataSorted = true;
            this.chartControl1.SeriesTemplate.SeriesDataMember = "TBL_COURS.COURS_NAME";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "MARK_COURS";
            this.chartControl1.Size = new System.Drawing.Size(956, 209);
            this.chartControl1.TabIndex = 8;
            // 
            // analys_control_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Name = "analys_control_admin";
            this.Size = new System.Drawing.Size(956, 634);
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ch_years.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_spec.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Panel panel14;
        private DevExpress.XtraEditors.CheckEdit ch_spec;
        public System.Windows.Forms.ComboBox com_spic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.CheckEdit ch_years;
        public System.Windows.Forms.ComboBox com_years;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_pad;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lbl_pad_y2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_good_y1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_pad_y1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
