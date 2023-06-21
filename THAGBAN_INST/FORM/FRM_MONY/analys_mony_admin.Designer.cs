namespace THAGBAN_INST.FORM.FRM_MONY
{
    partial class analys_mony_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(analys_mony_admin));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            this.panel14 = new System.Windows.Forms.Panel();
            this.ch_years = new DevExpress.XtraEditors.CheckEdit();
            this.ch_month = new DevExpress.XtraEditors.CheckEdit();
            this.com_years = new System.Windows.Forms.ComboBox();
            this.com_month = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_buy1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lb_buy2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_benfit1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lb_benfit2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_sell1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lb_sell2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_years.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_month.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.ch_years);
            this.panel14.Controls.Add(this.ch_month);
            this.panel14.Controls.Add(this.com_years);
            this.panel14.Controls.Add(this.com_month);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(956, 69);
            this.panel14.TabIndex = 11;
            // 
            // ch_years
            // 
            this.ch_years.Location = new System.Drawing.Point(687, 23);
            this.ch_years.Name = "ch_years";
            this.ch_years.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_years.Properties.Appearance.Options.UseFont = true;
            this.ch_years.Properties.Caption = "اختيار العام الدراسي";
            this.ch_years.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_years.Size = new System.Drawing.Size(198, 28);
            this.ch_years.TabIndex = 135;
            this.ch_years.CheckedChanged += new System.EventHandler(this.ch_lect_CheckedChanged);
            // 
            // ch_month
            // 
            this.ch_month.Location = new System.Drawing.Point(287, 22);
            this.ch_month.Name = "ch_month";
            this.ch_month.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_month.Properties.Appearance.Options.UseFont = true;
            this.ch_month.Properties.Caption = "اختيار الشهر";
            this.ch_month.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_month.Size = new System.Drawing.Size(149, 28);
            this.ch_month.TabIndex = 134;
            this.ch_month.CheckedChanged += new System.EventHandler(this.ch_grou_CheckedChanged);
            // 
            // com_years
            // 
            this.com_years.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_years.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_years.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_years.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_years.FormattingEnabled = true;
            this.com_years.Location = new System.Drawing.Point(454, 18);
            this.com_years.Name = "com_years";
            this.com_years.Size = new System.Drawing.Size(185, 37);
            this.com_years.TabIndex = 120;
            this.com_years.SelectedIndexChanged += new System.EventHandler(this.com_lect_SelectedIndexChanged);
            this.com_years.SelectionChangeCommitted += new System.EventHandler(this.com_lect_SelectedIndexChanged);
            this.com_years.SelectedValueChanged += new System.EventHandler(this.com_lect_SelectedIndexChanged);
            // 
            // com_month
            // 
            this.com_month.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_month.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_month.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_month.FormattingEnabled = true;
            this.com_month.Location = new System.Drawing.Point(103, 14);
            this.com_month.Name = "com_month";
            this.com_month.Size = new System.Drawing.Size(168, 32);
            this.com_month.TabIndex = 119;
            this.com_month.SelectedIndexChanged += new System.EventHandler(this.com_group_SelectedIndexChanged);
            this.com_month.SelectionChangeCommitted += new System.EventHandler(this.com_group_SelectedIndexChanged);
            this.com_month.SelectedValueChanged += new System.EventHandler(this.com_group_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 565);
            this.panel1.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.lb_buy1);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.lb_buy2);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Location = new System.Drawing.Point(22, 40);
            this.panel7.Margin = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 225);
            this.panel7.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(154, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 79);
            this.label7.TabIndex = 5;
            this.label7.Text = "الرصيد ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_buy1
            // 
            this.lb_buy1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_buy1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_buy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_buy1.ForeColor = System.Drawing.Color.White;
            this.lb_buy1.Location = new System.Drawing.Point(0, 129);
            this.lb_buy1.Name = "lb_buy1";
            this.lb_buy1.Size = new System.Drawing.Size(280, 48);
            this.lb_buy1.TabIndex = 4;
            this.lb_buy1.Text = "0.00";
            this.lb_buy1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Teal;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 25);
            this.panel8.TabIndex = 3;
            // 
            // lb_buy2
            // 
            this.lb_buy2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_buy2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_buy2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_buy2.ForeColor = System.Drawing.Color.White;
            this.lb_buy2.Location = new System.Drawing.Point(0, 177);
            this.lb_buy2.Name = "lb_buy2";
            this.lb_buy2.Size = new System.Drawing.Size(280, 48);
            this.lb_buy2.TabIndex = 2;
            this.lb_buy2.Text = "0.00";
            this.lb_buy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 40);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel11.Controls.Add(this.label13);
            this.panel11.Controls.Add(this.lb_benfit1);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.lb_benfit2);
            this.panel11.Controls.Add(this.pictureBox5);
            this.panel11.Location = new System.Drawing.Point(353, 40);
            this.panel11.Margin = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(286, 225);
            this.panel11.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(128, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 79);
            this.label13.TabIndex = 5;
            this.label13.Text = "اجمالي الخارج";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_benfit1
            // 
            this.lb_benfit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_benfit1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_benfit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_benfit1.ForeColor = System.Drawing.Color.White;
            this.lb_benfit1.Location = new System.Drawing.Point(0, 129);
            this.lb_benfit1.Name = "lb_benfit1";
            this.lb_benfit1.Size = new System.Drawing.Size(286, 48);
            this.lb_benfit1.TabIndex = 4;
            this.lb_benfit1.Text = "0.00";
            this.lb_benfit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Olive;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(286, 25);
            this.panel12.TabIndex = 3;
            // 
            // lb_benfit2
            // 
            this.lb_benfit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_benfit2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_benfit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_benfit2.ForeColor = System.Drawing.Color.White;
            this.lb_benfit2.Location = new System.Drawing.Point(0, 177);
            this.lb_benfit2.Name = "lb_benfit2";
            this.lb_benfit2.Size = new System.Drawing.Size(286, 48);
            this.lb_benfit2.TabIndex = 2;
            this.lb_benfit2.Text = "0.00";
            this.lb_benfit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::THAGBAN_INST.Properties.Resources.icons8_euro_4;
            this.pictureBox5.Location = new System.Drawing.Point(6, 40);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(116, 79);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.lb_sell1);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.lb_sell2);
            this.panel9.Controls.Add(this.pictureBox4);
            this.panel9.Location = new System.Drawing.Point(662, 40);
            this.panel9.Margin = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(279, 225);
            this.panel9.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(133, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 79);
            this.label10.TabIndex = 5;
            this.label10.Text = "اجمالي الدخل ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sell1
            // 
            this.lb_sell1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sell1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_sell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sell1.ForeColor = System.Drawing.Color.White;
            this.lb_sell1.Location = new System.Drawing.Point(0, 129);
            this.lb_sell1.Name = "lb_sell1";
            this.lb_sell1.Size = new System.Drawing.Size(279, 48);
            this.lb_sell1.TabIndex = 4;
            this.lb_sell1.Text = "0.00";
            this.lb_sell1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(279, 25);
            this.panel10.TabIndex = 3;
            // 
            // lb_sell2
            // 
            this.lb_sell2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sell2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_sell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sell2.ForeColor = System.Drawing.Color.White;
            this.lb_sell2.Location = new System.Drawing.Point(0, 177);
            this.lb_sell2.Name = "lb_sell2";
            this.lb_sell2.Size = new System.Drawing.Size(279, 48);
            this.lb_sell2.TabIndex = 2;
            this.lb_sell2.Text = "0.00";
            this.lb_sell2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 40);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(116, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.chartControl1);
            this.panel13.Controls.Add(this.panel3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 309);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(956, 256);
            this.panel13.TabIndex = 9;
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
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // chartControl1
            // 
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_OPRATION);
            xyDiagram1.AxisX.MinorCount = 30;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.MinorCount = 30;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisYScrolling = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.ItemVisibilityMode = DevExpress.XtraCharts.LegendItemVisibilityMode.AutoGeneratedAndCustom;
            this.chartControl1.Legend.MarkerOffset = 1;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "OPRATION_TYPE";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "PORATION_DATE";
            this.chartControl1.SeriesTemplate.DataSorted = true;
            this.chartControl1.SeriesTemplate.SeriesDataMember = "OPRATION_TYPE";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "PORATION_AMOUNT";
            this.chartControl1.Size = new System.Drawing.Size(956, 209);
            this.chartControl1.TabIndex = 9;
            // 
            // analys_mony_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel14);
            this.Name = "analys_mony_admin";
            this.Size = new System.Drawing.Size(956, 634);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ch_years.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_month.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel14;
        private DevExpress.XtraEditors.CheckEdit ch_years;
        private DevExpress.XtraEditors.CheckEdit ch_month;
        public System.Windows.Forms.ComboBox com_years;
        public System.Windows.Forms.ComboBox com_month;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_buy1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lb_buy2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_benfit1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lb_benfit2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_sell1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lb_sell2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
