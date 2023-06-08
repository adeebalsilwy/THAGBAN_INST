namespace THAGBAN_INST.FORM.FRM_CONTORL
{
    partial class frm_control_seryal_number
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_control_seryal_number));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTUD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIRYAL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIRYAL_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIRYAL_YEARS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBL_SPECIAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.com_years_mark = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_count = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.com_spical = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_export = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edite = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.colTBL_STUD_SPEC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBL_STUD_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_STATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_PHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 548);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 484);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(925, 433);
            this.panel4.TabIndex = 10;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_SIRYAL_STUDENTS);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(925, 433);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseFont = true;
            this.gridView2.Appearance.ViewCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTUD_ID,
            this.colSTUD_ID1,
            this.colSIRYAL_ID,
            this.colSIRYAL_NUMBER,
            this.colSIRYAL_YEARS,
            this.colTBL_SPECIAL});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            // 
            // colSTUD_ID
            // 
            this.colSTUD_ID.Caption = "اسم الطالب ";
            this.colSTUD_ID.FieldName = "TBL_STUDENTS.STUD_NAME";
            this.colSTUD_ID.Name = "colSTUD_ID";
            this.colSTUD_ID.Visible = true;
            this.colSTUD_ID.VisibleIndex = 1;
            this.colSTUD_ID.Width = 156;
            // 
            // colSTUD_ID1
            // 
            this.colSTUD_ID1.Caption = "اللقب";
            this.colSTUD_ID1.FieldName = "TBL_STUDENTS.STUD_LNAME";
            this.colSTUD_ID1.Name = "colSTUD_ID1";
            this.colSTUD_ID1.Visible = true;
            this.colSTUD_ID1.VisibleIndex = 2;
            this.colSTUD_ID1.Width = 114;
            // 
            // colSIRYAL_ID
            // 
            this.colSIRYAL_ID.Caption = "التسلسل";
            this.colSIRYAL_ID.FieldName = "SIRYAL_ID";
            this.colSIRYAL_ID.Name = "colSIRYAL_ID";
            this.colSIRYAL_ID.Visible = true;
            this.colSIRYAL_ID.VisibleIndex = 0;
            this.colSIRYAL_ID.Width = 116;
            // 
            // colSIRYAL_NUMBER
            // 
            this.colSIRYAL_NUMBER.Caption = "الرقم السري ";
            this.colSIRYAL_NUMBER.FieldName = "SIRYAL_NUMBER";
            this.colSIRYAL_NUMBER.Name = "colSIRYAL_NUMBER";
            this.colSIRYAL_NUMBER.Visible = true;
            this.colSIRYAL_NUMBER.VisibleIndex = 5;
            this.colSIRYAL_NUMBER.Width = 211;
            // 
            // colSIRYAL_YEARS
            // 
            this.colSIRYAL_YEARS.Caption = "العام الدراسي";
            this.colSIRYAL_YEARS.FieldName = "TBL_YEARS_MARK.YEARS_DATA";
            this.colSIRYAL_YEARS.Name = "colSIRYAL_YEARS";
            this.colSIRYAL_YEARS.Visible = true;
            this.colSIRYAL_YEARS.VisibleIndex = 4;
            this.colSIRYAL_YEARS.Width = 120;
            // 
            // colTBL_SPECIAL
            // 
            this.colTBL_SPECIAL.Caption = "التخصص";
            this.colTBL_SPECIAL.FieldName = "TBL_SPECIAL.SPEC_NAME";
            this.colTBL_SPECIAL.Name = "colTBL_SPECIAL";
            this.colTBL_SPECIAL.Visible = true;
            this.colTBL_SPECIAL.VisibleIndex = 3;
            this.colTBL_SPECIAL.Width = 187;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.com_years_mark);
            this.panel3.Controls.Add(this.labelControl5);
            this.panel3.Controls.Add(this.lbl_count);
            this.panel3.Controls.Add(this.labelControl2);
            this.panel3.Controls.Add(this.com_spical);
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 51);
            this.panel3.TabIndex = 9;
            // 
            // com_years_mark
            // 
            this.com_years_mark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_years_mark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_years_mark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_years_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_years_mark.FormattingEnabled = true;
            this.com_years_mark.Location = new System.Drawing.Point(249, 13);
            this.com_years_mark.Name = "com_years_mark";
            this.com_years_mark.Size = new System.Drawing.Size(221, 32);
            this.com_years_mark.TabIndex = 67;
            this.com_years_mark.SelectionChangeCommitted += new System.EventHandler(this.com_years_mark_SelectionChangeCommitted);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(518, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 20);
            this.labelControl5.TabIndex = 66;
            this.labelControl5.Text = "العام الدراسي";
            // 
            // lbl_count
            // 
            this.lbl_count.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Appearance.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbl_count.Appearance.Options.UseFont = true;
            this.lbl_count.Appearance.Options.UseForeColor = true;
            this.lbl_count.Location = new System.Drawing.Point(38, 15);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(63, 17);
            this.lbl_count.TabIndex = 65;
            this.lbl_count.Text = "عدد الطلاب";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(139, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 17);
            this.labelControl2.TabIndex = 64;
            this.labelControl2.Text = "عدد الطلاب";
            // 
            // com_spical
            // 
            this.com_spical.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_spical.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_spical.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_spical.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_spical.FormattingEnabled = true;
            this.com_spical.Location = new System.Drawing.Point(608, 8);
            this.com_spical.Name = "com_spical";
            this.com_spical.Size = new System.Drawing.Size(197, 37);
            this.com_spical.TabIndex = 61;
            this.com_spical.SelectionChangeCommitted += new System.EventHandler(this.com_spical_SelectionChangeCommitted);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(811, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 20);
            this.labelControl4.TabIndex = 60;
            this.labelControl4.Text = "اسم التخصص";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_export);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btn_edite);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 484);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(925, 64);
            this.panelControl1.TabIndex = 8;
            // 
            // btn_export
            // 
            this.btn_export.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_export.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_export.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Appearance.Options.UseBackColor = true;
            this.btn_export.Appearance.Options.UseBorderColor = true;
            this.btn_export.Appearance.Options.UseFont = true;
            this.btn_export.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_export.ImageOptions.SvgImage")));
            this.btn_export.Location = new System.Drawing.Point(324, 9);
            this.btn_export.Name = "btn_export";
            this.btn_export.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_export.Size = new System.Drawing.Size(155, 50);
            this.btn_export.TabIndex = 46;
            this.btn_export.Text = "تصدير اكسل";
            this.btn_export.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(485, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(101, 50);
            this.simpleButton1.TabIndex = 45;
            this.simpleButton1.Text = "تحديث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_edite
            // 
            this.btn_edite.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_edite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edite.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_edite.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edite.Appearance.Options.UseBackColor = true;
            this.btn_edite.Appearance.Options.UseBorderColor = true;
            this.btn_edite.Appearance.Options.UseFont = true;
            this.btn_edite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edite.ImageOptions.Image")));
            this.btn_edite.Location = new System.Drawing.Point(608, 9);
            this.btn_edite.Name = "btn_edite";
            this.btn_edite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_edite.Size = new System.Drawing.Size(136, 50);
            this.btn_edite.TabIndex = 43;
            this.btn_edite.Text = "طباعه الارقام";
            this.btn_edite.Click += new System.EventHandler(this.btn_edite_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_save.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_save.Appearance.Options.UseBackColor = true;
            this.btn_save.Appearance.Options.UseBorderColor = true;
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(757, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(101, 50);
            this.btn_save.TabIndex = 42;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // colTBL_STUD_SPEC1
            // 
            this.colTBL_STUD_SPEC1.Caption = "تاريخ التسجيل ";
            this.colTBL_STUD_SPEC1.FieldName = "TBL_STUD_SPEC";
            this.colTBL_STUD_SPEC1.Name = "colTBL_STUD_SPEC1";
            this.colTBL_STUD_SPEC1.Width = 108;
            // 
            // colTBL_STUD_SPEC
            // 
            this.colTBL_STUD_SPEC.Caption = "التخصص";
            this.colTBL_STUD_SPEC.FieldName = "TBL_STUD_SPEC";
            this.colTBL_STUD_SPEC.Name = "colTBL_STUD_SPEC";
            this.colTBL_STUD_SPEC.Width = 88;
            // 
            // colSTUD_STATE
            // 
            this.colSTUD_STATE.Caption = "حاله الطالب";
            this.colSTUD_STATE.FieldName = "STUD_STATE";
            this.colSTUD_STATE.Name = "colSTUD_STATE";
            this.colSTUD_STATE.Width = 88;
            // 
            // colSTUD_PHONE
            // 
            this.colSTUD_PHONE.Caption = "الهاتف";
            this.colSTUD_PHONE.FieldName = "STUD_PHONE";
            this.colSTUD_PHONE.Name = "colSTUD_PHONE";
            this.colSTUD_PHONE.Width = 88;
            // 
            // frm_control_seryal_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frm_control_seryal_number";
            this.Size = new System.Drawing.Size(925, 548);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_edite;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL_STUD_SPEC1;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL_STUD_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_STATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_PHONE;
        private DevExpress.XtraEditors.SimpleButton btn_export;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lbl_count;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public System.Windows.Forms.ComboBox com_spical;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colSIRYAL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSIRYAL_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colSIRYAL_YEARS;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL_SPECIAL;
        public System.Windows.Forms.ComboBox com_years_mark;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
