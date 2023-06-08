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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesTemplate seriesTemplate1 = new DevExpress.XtraCharts.SeriesTemplate();
            DevExpress.XtraCharts.SeriesTemplateAdapter seriesTemplateAdapter1 = new DevExpress.XtraCharts.SeriesTemplateAdapter();
            DevExpress.XtraCharts.SeriesKeyColorColorizer seriesKeyColorColorizer1 = new DevExpress.XtraCharts.SeriesKeyColorColorizer();
            DevExpress.XtraCharts.SeriesTemplate seriesTemplate2 = new DevExpress.XtraCharts.SeriesTemplate();
            DevExpress.XtraCharts.SeriesTemplate seriesTemplate3 = new DevExpress.XtraCharts.SeriesTemplate();
            this.panel14 = new System.Windows.Forms.Panel();
            this.ch_spice = new DevExpress.XtraEditors.CheckEdit();
            this.ch_grou = new DevExpress.XtraEditors.CheckEdit();
            this.com_spice = new System.Windows.Forms.ComboBox();
            this.com_years = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_pad1 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lbl_pad2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_good1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_good2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_spice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_grou.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.ch_spice);
            this.panel14.Controls.Add(this.ch_grou);
            this.panel14.Controls.Add(this.com_spice);
            this.panel14.Controls.Add(this.com_years);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(956, 69);
            this.panel14.TabIndex = 11;
            // 
            // ch_spice
            // 
            this.ch_spice.Location = new System.Drawing.Point(736, 23);
            this.ch_spice.Name = "ch_spice";
            this.ch_spice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_spice.Properties.Appearance.Options.UseFont = true;
            this.ch_spice.Properties.Caption = "اختيار التخصص";
            this.ch_spice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_spice.Size = new System.Drawing.Size(149, 28);
            this.ch_spice.TabIndex = 135;
            this.ch_spice.CheckedChanged += new System.EventHandler(this.ch_lect_CheckedChanged);
            // 
            // ch_grou
            // 
            this.ch_grou.Location = new System.Drawing.Point(362, 23);
            this.ch_grou.Name = "ch_grou";
            this.ch_grou.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_grou.Properties.Appearance.Options.UseFont = true;
            this.ch_grou.Properties.Caption = "اختيار العام الدراسي";
            this.ch_grou.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_grou.Size = new System.Drawing.Size(149, 28);
            this.ch_grou.TabIndex = 134;
            this.ch_grou.CheckedChanged += new System.EventHandler(this.ch_grou_CheckedChanged);
            // 
            // com_spice
            // 
            this.com_spice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_spice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_spice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_spice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_spice.FormattingEnabled = true;
            this.com_spice.Location = new System.Drawing.Point(534, 18);
            this.com_spice.Name = "com_spice";
            this.com_spice.Size = new System.Drawing.Size(185, 37);
            this.com_spice.TabIndex = 120;
            this.com_spice.SelectedIndexChanged += new System.EventHandler(this.com_lect_SelectedIndexChanged);
            // 
            // com_years
            // 
            this.com_years.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_years.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_years.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_years.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_years.FormattingEnabled = true;
            this.com_years.Location = new System.Drawing.Point(184, 18);
            this.com_years.Name = "com_years";
            this.com_years.Size = new System.Drawing.Size(132, 37);
            this.com_years.TabIndex = 119;
            this.com_years.SelectedIndexChanged += new System.EventHandler(this.com_group_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 565);
            this.panel1.TabIndex = 12;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(956, 309);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel15.Controls.Add(this.label3);
            this.panel15.Controls.Add(this.lbl_pad1);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.lbl_pad2);
            this.panel15.Controls.Add(this.pictureBox6);
            this.panel15.Location = new System.Drawing.Point(20, 17);
            this.panel15.Margin = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(370, 225);
            this.panel15.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(200, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 79);
            this.label3.TabIndex = 5;
            this.label3.Text = "الراسبين";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pad1
            // 
            this.lbl_pad1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pad1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_pad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pad1.ForeColor = System.Drawing.Color.White;
            this.lbl_pad1.Location = new System.Drawing.Point(0, 129);
            this.lbl_pad1.Name = "lbl_pad1";
            this.lbl_pad1.Size = new System.Drawing.Size(370, 48);
            this.lbl_pad1.TabIndex = 4;
            this.lbl_pad1.Text = "0.00";
            this.lbl_pad1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // lbl_pad2
            // 
            this.lbl_pad2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pad2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_pad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pad2.ForeColor = System.Drawing.Color.White;
            this.lbl_pad2.Location = new System.Drawing.Point(0, 177);
            this.lbl_pad2.Name = "lbl_pad2";
            this.lbl_pad2.Size = new System.Drawing.Size(370, 48);
            this.lbl_pad2.TabIndex = 2;
            this.lbl_pad2.Text = "0.00";
            this.lbl_pad2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lbl_good1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lbl_good2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(430, 17);
            this.panel5.Margin = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 225);
            this.panel5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(129, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 79);
            this.label4.TabIndex = 5;
            this.label4.Text = "الناجحين";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_good1
            // 
            this.lbl_good1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_good1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_good1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_good1.ForeColor = System.Drawing.Color.White;
            this.lbl_good1.Location = new System.Drawing.Point(0, 129);
            this.lbl_good1.Name = "lbl_good1";
            this.lbl_good1.Size = new System.Drawing.Size(369, 48);
            this.lbl_good1.TabIndex = 4;
            this.lbl_good1.Text = "0.00";
            this.lbl_good1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // lbl_good2
            // 
            this.lbl_good2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_good2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_good2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_good2.ForeColor = System.Drawing.Color.White;
            this.lbl_good2.Location = new System.Drawing.Point(0, 177);
            this.lbl_good2.Name = "lbl_good2";
            this.lbl_good2.Size = new System.Drawing.Size(369, 48);
            this.lbl_good2.TabIndex = 2;
            this.lbl_good2.Text = "0.00";
            this.lbl_good2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.chartControl1.AppearanceNameSerializable = "Dark Flat";
            this.chartControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_STUDENTS);
            xyDiagram1.AxisX.Title.Text = "الشهر";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "اقبال الطلاب";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteBaseColorNumber = 1;
            this.chartControl1.SeriesDataMember = "STUD_ID";
            series1.ArgumentDataMember = "STUD_NAME";
            series1.ColorDataMember = "LECT_STUD_DATE";
            series1.CrosshairLabelPattern = "{A}";
            series1.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            series1.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            series1.DateTimeSummaryOptions.SummaryFunction = "SUM([STUD_ID])";
            series1.Name = "Series 1";
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series1.ShowInLegend = false;
            series1.ToolTipSeriesPattern = "";
            series2.ArgumentDataMember = "STUD_NAME";
            series2.ColorDataMember = "LECT_STUD_DATE";
            series2.CrosshairLabelPattern = "{A}";
            series2.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            series2.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            series2.DateTimeSummaryOptions.SummaryFunction = "SUM([STUD_ID])";
            series2.Name = "Series 2";
            series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series2.ShowInLegend = false;
            series2.ToolTipSeriesPattern = "";
            series3.ArgumentDataMember = "STUD_NAME";
            series3.ColorDataMember = "LECT_STUD_DATE";
            series3.CrosshairLabelPattern = "{A}";
            series3.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            series3.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            series3.DateTimeSummaryOptions.SummaryFunction = "SUM([STUD_ID])";
            series3.Name = "Series 3";
            series3.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series3.ShowInLegend = false;
            series3.ToolTipSeriesPattern = "";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series1,
        series2,
        series3};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "STUD_NAME";
            seriesTemplate1.DataAdapter = seriesTemplateAdapter1;
            seriesTemplate1.SeriesColorizer = seriesKeyColorColorizer1;
            seriesTemplate1.SeriesDataMember = null;
            seriesTemplate1.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            this.chartControl1.SeriesTemplate.ArgumentDrillTemplate = seriesTemplate1;
            this.chartControl1.SeriesTemplate.ColorDataMember = "LECT_STUD_DATE";
            this.chartControl1.SeriesTemplate.CrosshairLabelPattern = "{A}";
            this.chartControl1.SeriesTemplate.DateTimeSummaryOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month;
            this.chartControl1.SeriesTemplate.DateTimeSummaryOptions.MeasureUnitMultiplier = 1;
            this.chartControl1.SeriesTemplate.DateTimeSummaryOptions.SummaryFunction = "SUM([STUD_ID])";
            this.chartControl1.SeriesTemplate.SeriesDataMember = "STUD_ID";
            seriesTemplate2.SeriesDataMember = null;
            this.chartControl1.SeriesTemplate.SeriesDrillTemplate = seriesTemplate2;
            seriesTemplate3.SeriesDataMember = null;
            this.chartControl1.SeriesTemplate.SeriesPointDrillTemplate = seriesTemplate3;
            this.chartControl1.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            this.chartControl1.SeriesTemplate.ShowInLegend = false;
            this.chartControl1.SeriesTemplate.ToolTipSeriesPattern = "";
            this.chartControl1.Size = new System.Drawing.Size(956, 209);
            this.chartControl1.TabIndex = 8;
            // 
            // analys_control_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel14);
            this.Name = "analys_control_admin";
            this.Size = new System.Drawing.Size(956, 634);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ch_spice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_grou.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel14;
        private DevExpress.XtraEditors.CheckEdit ch_spice;
        private DevExpress.XtraEditors.CheckEdit ch_grou;
        public System.Windows.Forms.ComboBox com_spice;
        public System.Windows.Forms.ComboBox com_years;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_good1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_good2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_pad1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lbl_pad2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}
