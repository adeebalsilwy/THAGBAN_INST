using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.users
{
    partial class frm_mang_users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mang_users));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_PASS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMP_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMP_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edite = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.colFRM_MONY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRM_LECTUER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRM_CONTROL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRM_BUY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRM_SETTING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 478);
            this.panel2.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_USERS);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(925, 478);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEMP_ID,
            this.colUSER_ID,
            this.colUSER_NAME,
            this.colUSER_PASS,
            this.colEMP_ID1,
            this.colEMP_ID2,
            this.colFRM_MONY,
            this.colFRM_LECTUER,
            this.colFRM_CONTROL,
            this.colFRM_BUY,
            this.colFRM_SETTING});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged_1);
            // 
            // colEMP_ID
            // 
            this.colEMP_ID.Caption = "اسم الموظف ";
            this.colEMP_ID.FieldName = "TBL_EMPLOYEES.EMP_NAME";
            this.colEMP_ID.Name = "colEMP_ID";
            this.colEMP_ID.Visible = true;
            this.colEMP_ID.VisibleIndex = 1;
            this.colEMP_ID.Width = 121;
            // 
            // colUSER_ID
            // 
            this.colUSER_ID.Caption = "التسلسل";
            this.colUSER_ID.FieldName = "USER_ID";
            this.colUSER_ID.Name = "colUSER_ID";
            this.colUSER_ID.Visible = true;
            this.colUSER_ID.VisibleIndex = 0;
            this.colUSER_ID.Width = 59;
            // 
            // colUSER_NAME
            // 
            this.colUSER_NAME.Caption = "اسم المستخدم";
            this.colUSER_NAME.FieldName = "USER_NAME";
            this.colUSER_NAME.Name = "colUSER_NAME";
            this.colUSER_NAME.Visible = true;
            this.colUSER_NAME.VisibleIndex = 2;
            this.colUSER_NAME.Width = 119;
            // 
            // colUSER_PASS
            // 
            this.colUSER_PASS.Caption = "كلمه المرور ";
            this.colUSER_PASS.FieldName = "USER_PASS";
            this.colUSER_PASS.Name = "colUSER_PASS";
            this.colUSER_PASS.Visible = true;
            this.colUSER_PASS.VisibleIndex = 3;
            this.colUSER_PASS.Width = 112;
            // 
            // colEMP_ID1
            // 
            this.colEMP_ID1.Caption = "شؤون الموظفين";
            this.colEMP_ID1.FieldName = "FRM_EMP";
            this.colEMP_ID1.Name = "colEMP_ID1";
            this.colEMP_ID1.Visible = true;
            this.colEMP_ID1.VisibleIndex = 4;
            this.colEMP_ID1.Width = 112;
            // 
            // colEMP_ID2
            // 
            this.colEMP_ID2.Caption = "شؤون الطلاب";
            this.colEMP_ID2.FieldName = "FRM_STUD";
            this.colEMP_ID2.Name = "colEMP_ID2";
            this.colEMP_ID2.Visible = true;
            this.colEMP_ID2.VisibleIndex = 5;
            this.colEMP_ID2.Width = 116;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btn_delete);
            this.panelControl1.Controls.Add(this.btn_edite);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 478);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(925, 70);
            this.panelControl1.TabIndex = 8;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(255, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(101, 50);
            this.simpleButton1.TabIndex = 37;
            this.simpleButton1.Text = "تحديث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseBorderColor = true;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(385, 10);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_delete.Size = new System.Drawing.Size(101, 50);
            this.btn_delete.TabIndex = 35;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edite
            // 
            this.btn_edite.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_edite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edite.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edite.Appearance.Options.UseBorderColor = true;
            this.btn_edite.Appearance.Options.UseFont = true;
            this.btn_edite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edite.ImageOptions.Image")));
            this.btn_edite.Location = new System.Drawing.Point(535, 10);
            this.btn_edite.Name = "btn_edite";
            this.btn_edite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_edite.Size = new System.Drawing.Size(101, 50);
            this.btn_edite.TabIndex = 34;
            this.btn_edite.Text = "تعديل";
            this.btn_edite.Click += new System.EventHandler(this.btn_edite_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseBorderColor = true;
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(649, 10);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(101, 50);
            this.btn_save.TabIndex = 33;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // colFRM_MONY
            // 
            this.colFRM_MONY.Caption = "الماليه";
            this.colFRM_MONY.FieldName = "FRM_MONY";
            this.colFRM_MONY.Name = "colFRM_MONY";
            this.colFRM_MONY.Visible = true;
            this.colFRM_MONY.VisibleIndex = 6;
            this.colFRM_MONY.Width = 53;
            // 
            // colFRM_LECTUER
            // 
            this.colFRM_LECTUER.Caption = "الدورات الخارجيه";
            this.colFRM_LECTUER.FieldName = "FRM_LECTUER";
            this.colFRM_LECTUER.Name = "colFRM_LECTUER";
            this.colFRM_LECTUER.Visible = true;
            this.colFRM_LECTUER.VisibleIndex = 7;
            this.colFRM_LECTUER.Width = 53;
            // 
            // colFRM_CONTROL
            // 
            this.colFRM_CONTROL.Caption = "الكنترول";
            this.colFRM_CONTROL.FieldName = "FRM_CONTROL";
            this.colFRM_CONTROL.Name = "colFRM_CONTROL";
            this.colFRM_CONTROL.Visible = true;
            this.colFRM_CONTROL.VisibleIndex = 8;
            this.colFRM_CONTROL.Width = 52;
            // 
            // colFRM_BUY
            // 
            this.colFRM_BUY.Caption = "الماليه";
            this.colFRM_BUY.FieldName = "FRM_BUY";
            this.colFRM_BUY.Name = "colFRM_BUY";
            this.colFRM_BUY.Visible = true;
            this.colFRM_BUY.VisibleIndex = 9;
            this.colFRM_BUY.Width = 52;
            // 
            // colFRM_SETTING
            // 
            this.colFRM_SETTING.Caption = "الاعدادت";
            this.colFRM_SETTING.FieldName = "FRM_SETTING";
            this.colFRM_SETTING.Name = "colFRM_SETTING";
            this.colFRM_SETTING.Visible = true;
            this.colFRM_SETTING.VisibleIndex = 10;
            this.colFRM_SETTING.Width = 61;
            // 
            // frm_mang_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frm_mang_users";
            this.Size = new System.Drawing.Size(925, 548);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edite;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_PASS;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colFRM_MONY;
        private DevExpress.XtraGrid.Columns.GridColumn colFRM_LECTUER;
        private DevExpress.XtraGrid.Columns.GridColumn colFRM_CONTROL;
        private DevExpress.XtraGrid.Columns.GridColumn colFRM_BUY;
        private DevExpress.XtraGrid.Columns.GridColumn colFRM_SETTING;
    }
}
