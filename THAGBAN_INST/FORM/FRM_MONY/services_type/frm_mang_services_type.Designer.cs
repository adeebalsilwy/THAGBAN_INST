﻿namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER
{
    partial class frm_mang_services_type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mang_services_type));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBL_SERVICE_TYPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSERVICE_TYPE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICE_TYPE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERVICE_TYPE_PRICE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edite = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_SERVICE_TYPEBindingSource)).BeginInit();
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
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 493);
            this.panel2.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBL_SERVICE_TYPEBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(925, 493);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // tBL_SERVICE_TYPEBindingSource
            // 
            this.tBL_SERVICE_TYPEBindingSource.DataSource = typeof(THAGBAN_INST.DATA.TBL_SERVICE_TYPE);
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
            this.colSERVICE_TYPE_ID,
            this.colSERVICE_TYPE_NAME,
            this.colSERVICE_TYPE_PRICE});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            // 
            // colSERVICE_TYPE_ID
            // 
            this.colSERVICE_TYPE_ID.Caption = "التسلسل";
            this.colSERVICE_TYPE_ID.FieldName = "SERVICE_TYPE_ID";
            this.colSERVICE_TYPE_ID.Name = "colSERVICE_TYPE_ID";
            this.colSERVICE_TYPE_ID.Visible = true;
            this.colSERVICE_TYPE_ID.VisibleIndex = 0;
            // 
            // colSERVICE_TYPE_NAME
            // 
            this.colSERVICE_TYPE_NAME.Caption = "اسم الخدمه";
            this.colSERVICE_TYPE_NAME.FieldName = "SERVICE_TYPE_NAME";
            this.colSERVICE_TYPE_NAME.Name = "colSERVICE_TYPE_NAME";
            this.colSERVICE_TYPE_NAME.Visible = true;
            this.colSERVICE_TYPE_NAME.VisibleIndex = 1;
            // 
            // colSERVICE_TYPE_PRICE
            // 
            this.colSERVICE_TYPE_PRICE.Caption = "سعر الخدمه";
            this.colSERVICE_TYPE_PRICE.FieldName = "SERVICE_TYPE_PRICE";
            this.colSERVICE_TYPE_PRICE.Name = "colSERVICE_TYPE_PRICE";
            this.colSERVICE_TYPE_PRICE.Visible = true;
            this.colSERVICE_TYPE_PRICE.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btn_delete);
            this.panelControl1.Controls.Add(this.btn_edite);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 493);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(925, 55);
            this.panelControl1.TabIndex = 8;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
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
            this.simpleButton1.Location = new System.Drawing.Point(215, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(101, 50);
            this.simpleButton1.TabIndex = 45;
            this.simpleButton1.Text = "تحديث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseBackColor = true;
            this.btn_delete.Appearance.Options.UseBorderColor = true;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(345, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_delete.Size = new System.Drawing.Size(101, 50);
            this.btn_delete.TabIndex = 44;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_edite.Location = new System.Drawing.Point(495, 2);
            this.btn_edite.Name = "btn_edite";
            this.btn_edite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_edite.Size = new System.Drawing.Size(101, 50);
            this.btn_edite.TabIndex = 43;
            this.btn_edite.Text = "تعديل";
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
            this.btn_save.Location = new System.Drawing.Point(609, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(101, 50);
            this.btn_save.TabIndex = 42;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frm_mang_services_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frm_mang_services_type";
            this.Size = new System.Drawing.Size(925, 548);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBL_SERVICE_TYPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edite;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.BindingSource tBL_SERVICE_TYPEBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICE_TYPE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICE_TYPE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSERVICE_TYPE_PRICE;
    }
}
