namespace THAGBAN_INST.FORM.FRM_CONTORL.siryal_number
{
    partial class frm_add_siryal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_siryal));
            this.com_spiacl = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.com_years_mark = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ch_all = new DevExpress.XtraEditors.CheckEdit();
            this.lbl_count = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_all.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // com_spiacl
            // 
            this.com_spiacl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_spiacl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_spiacl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_spiacl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_spiacl.FormattingEnabled = true;
            this.com_spiacl.Location = new System.Drawing.Point(64, 71);
            this.com_spiacl.Name = "com_spiacl";
            this.com_spiacl.Size = new System.Drawing.Size(221, 32);
            this.com_spiacl.TabIndex = 88;
            this.com_spiacl.SelectionChangeCommitted += new System.EventHandler(this.com_spiacl_SelectionChangeCommitted);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(319, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 20);
            this.labelControl4.TabIndex = 87;
            this.labelControl4.Text = "التخصص";
            // 
            // com_years_mark
            // 
            this.com_years_mark.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_years_mark.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_years_mark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_years_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_years_mark.FormattingEnabled = true;
            this.com_years_mark.Location = new System.Drawing.Point(64, 149);
            this.com_years_mark.Name = "com_years_mark";
            this.com_years_mark.Size = new System.Drawing.Size(221, 32);
            this.com_years_mark.TabIndex = 62;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(301, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 20);
            this.labelControl5.TabIndex = 61;
            this.labelControl5.Text = "العام الدراسي";
            // 
            // ch_all
            // 
            this.ch_all.Location = new System.Drawing.Point(15, 27);
            this.ch_all.Name = "ch_all";
            this.ch_all.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_all.Properties.Appearance.Options.UseFont = true;
            this.ch_all.Properties.Caption = "عمل ارقام سريه لكل التخصصات والطلاب";
            this.ch_all.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_all.Size = new System.Drawing.Size(367, 28);
            this.ch_all.TabIndex = 136;
            this.ch_all.CheckedChanged += new System.EventHandler(this.ch_all_CheckedChanged);
            // 
            // lbl_count
            // 
            this.lbl_count.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Appearance.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbl_count.Appearance.Options.UseFont = true;
            this.lbl_count.Appearance.Options.UseForeColor = true;
            this.lbl_count.Location = new System.Drawing.Point(181, 116);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(63, 17);
            this.lbl_count.TabIndex = 138;
            this.lbl_count.Text = "عدد الطلاب";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(289, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 17);
            this.labelControl2.TabIndex = 137;
            this.labelControl2.Text = "اجمالي عدد الطلاب";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(289, 227);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 20);
            this.labelControl1.TabIndex = 140;
            this.labelControl1.Text = "صيغه الارقام السريه";
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
            this.btn_save.Location = new System.Drawing.Point(247, 277);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(150, 50);
            this.btn_save.TabIndex = 141;
            this.btn_save.Text = "توليد الارقام";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(36, 277);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(133, 50);
            this.simpleButton1.TabIndex = 142;
            this.simpleButton1.Text = "اضافة";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(81, 215);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(176, 32);
            this.textEdit1.TabIndex = 143;
            // 
            // frm_add_siryal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 339);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ch_all);
            this.Controls.Add(this.com_years_mark);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.com_spiacl);
            this.Controls.Add(this.labelControl4);
            this.Name = "frm_add_siryal";
            this.Text = "frm_add_siryal";
            this.Activated += new System.EventHandler(this.frm_add_siryal_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ch_all.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox com_spiacl;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public System.Windows.Forms.ComboBox com_years_mark;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit ch_all;
        private DevExpress.XtraEditors.LabelControl lbl_count;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}