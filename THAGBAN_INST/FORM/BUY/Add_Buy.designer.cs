
namespace EPS.AddPage
{
    partial class Add_Buy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Buy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addclose = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_message = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radio_part = new System.Windows.Forms.RadioButton();
            this.edt_buyall = new System.Windows.Forms.Label();
            this.radio_no = new System.Windows.Forms.RadioButton();
            this.radio_yes = new System.Windows.Forms.RadioButton();
            this.edt_supplierpayment = new System.Windows.Forms.TextBox();
            this.edt_buyprimary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.edt_quantity = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.link_addnewgroups = new System.Windows.Forms.LinkLabel();
            this.edt_supplier = new System.Windows.Forms.ComboBox();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_addclose);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 435);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 48);
            this.panel1.TabIndex = 0;
            // 
            // btn_addclose
            // 
            this.btn_addclose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_addclose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addclose.Appearance.Options.UseFont = true;
            this.btn_addclose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_addclose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_addclose.ImageOptions.SvgImage")));
            this.btn_addclose.Location = new System.Drawing.Point(5, 4);
            this.btn_addclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addclose.Name = "btn_addclose";
            this.btn_addclose.Size = new System.Drawing.Size(143, 38);
            this.btn_addclose.TabIndex = 1;
            this.btn_addclose.Text = "اضافة+ غلق";
            this.btn_addclose.Click += new System.EventHandler(this.btn_addclose_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(476, 4);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(143, 38);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_message
            // 
            this.txt_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.ForeColor = System.Drawing.Color.White;
            this.txt_message.Location = new System.Drawing.Point(0, 403);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(628, 32);
            this.txt_message.TabIndex = 3;
            this.txt_message.Text = "رسالة";
            this.txt_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_message.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "67317d9e-9c1a-45dc-9c6f-79273460fd6a";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b63bb4e2-c3ce-411f-975a-c860580f1dc7", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت الاضافة بنجاح", "تمت الاضافة بنجاح", "تمت الاضافة بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("5eb82af2-6df7-42a2-89da-1a50da44d73b", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "تمت عملية التعديل بنجاح", "تمت عملية التعديل بنجاح", "تمت عملية التعديل بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.edt_quantity);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.link_addnewgroups);
            this.groupBox2.Controls.Add(this.edt_supplier);
            this.groupBox2.Controls.Add(this.edt_name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.edt_category);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(588, 335);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "السعر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(538, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "الكمية";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.radio_part);
            this.groupBox3.Controls.Add(this.edt_buyall);
            this.groupBox3.Controls.Add(this.radio_no);
            this.groupBox3.Controls.Add(this.radio_yes);
            this.groupBox3.Controls.Add(this.edt_supplierpayment);
            this.groupBox3.Controls.Add(this.edt_buyprimary);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(7, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(239, 210);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "شراء";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(68, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "سعر الشراء الكلي";
            // 
            // radio_part
            // 
            this.radio_part.AutoSize = true;
            this.radio_part.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_part.Location = new System.Drawing.Point(6, 74);
            this.radio_part.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_part.Name = "radio_part";
            this.radio_part.Size = new System.Drawing.Size(46, 17);
            this.radio_part.TabIndex = 3;
            this.radio_part.Text = "جزء";
            this.radio_part.UseVisualStyleBackColor = true;
            this.radio_part.CheckedChanged += new System.EventHandler(this.radio_part_CheckedChanged);
            // 
            // edt_buyall
            // 
            this.edt_buyall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_buyall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_buyall.ForeColor = System.Drawing.Color.Teal;
            this.edt_buyall.Location = new System.Drawing.Point(20, 170);
            this.edt_buyall.Name = "edt_buyall";
            this.edt_buyall.Size = new System.Drawing.Size(210, 31);
            this.edt_buyall.TabIndex = 1;
            this.edt_buyall.Text = "0.000";
            this.edt_buyall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radio_no
            // 
            this.radio_no.AutoSize = true;
            this.radio_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_no.Location = new System.Drawing.Point(56, 74);
            this.radio_no.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_no.Name = "radio_no";
            this.radio_no.Size = new System.Drawing.Size(32, 17);
            this.radio_no.TabIndex = 3;
            this.radio_no.Text = "لا";
            this.radio_no.UseVisualStyleBackColor = true;
            this.radio_no.CheckedChanged += new System.EventHandler(this.radio_no_CheckedChanged);
            // 
            // radio_yes
            // 
            this.radio_yes.AutoSize = true;
            this.radio_yes.Checked = true;
            this.radio_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_yes.Location = new System.Drawing.Point(94, 72);
            this.radio_yes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radio_yes.Name = "radio_yes";
            this.radio_yes.Size = new System.Drawing.Size(43, 17);
            this.radio_yes.TabIndex = 3;
            this.radio_yes.TabStop = true;
            this.radio_yes.Text = "نعم";
            this.radio_yes.UseVisualStyleBackColor = true;
            this.radio_yes.CheckedChanged += new System.EventHandler(this.radio_yes_CheckedChanged);
            // 
            // edt_supplierpayment
            // 
            this.edt_supplierpayment.Enabled = false;
            this.edt_supplierpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_supplierpayment.Location = new System.Drawing.Point(56, 110);
            this.edt_supplierpayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_supplierpayment.Name = "edt_supplierpayment";
            this.edt_supplierpayment.Size = new System.Drawing.Size(166, 26);
            this.edt_supplierpayment.TabIndex = 2;
            this.edt_supplierpayment.Text = "0";
            this.edt_supplierpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_supplierpayment.TextChanged += new System.EventHandler(this.edt_supplierpayment_TextChanged);
            // 
            // edt_buyprimary
            // 
            this.edt_buyprimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_buyprimary.Location = new System.Drawing.Point(51, 25);
            this.edt_buyprimary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_buyprimary.Name = "edt_buyprimary";
            this.edt_buyprimary.Size = new System.Drawing.Size(166, 26);
            this.edt_buyprimary.TabIndex = 2;
            this.edt_buyprimary.Text = "0";
            this.edt_buyprimary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edt_buyprimary.TextChanged += new System.EventHandler(this.edt_buyprimary_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(143, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "هل تم التسديد؟";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(16, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "ريال";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(3, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "ريال";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edt_quantity
            // 
            this.edt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_quantity.Location = new System.Drawing.Point(267, 257);
            this.edt_quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_quantity.Name = "edt_quantity";
            this.edt_quantity.Size = new System.Drawing.Size(321, 26);
            this.edt_quantity.TabIndex = 2;
            this.edt_quantity.Text = "1";
            this.edt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(277, 167);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "جديد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(515, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم المادة";
            // 
            // link_addnewgroups
            // 
            this.link_addnewgroups.AutoSize = true;
            this.link_addnewgroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_addnewgroups.Location = new System.Drawing.Point(277, 90);
            this.link_addnewgroups.Name = "link_addnewgroups";
            this.link_addnewgroups.Size = new System.Drawing.Size(33, 17);
            this.link_addnewgroups.TabIndex = 6;
            this.link_addnewgroups.TabStop = true;
            this.link_addnewgroups.Text = "جديد";
            // 
            // edt_supplier
            // 
            this.edt_supplier.AllowDrop = true;
            this.edt_supplier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_supplier.FormattingEnabled = true;
            this.edt_supplier.Location = new System.Drawing.Point(267, 186);
            this.edt_supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_supplier.Name = "edt_supplier";
            this.edt_supplier.Size = new System.Drawing.Size(321, 28);
            this.edt_supplier.TabIndex = 5;
            this.edt_supplier.SelectedIndexChanged += new System.EventHandler(this.edt_supplier_SelectedIndexChanged_1);
            this.edt_supplier.SelectionChangeCommitted += new System.EventHandler(this.edt_supplier_SelectedIndexChanged_1);
            this.edt_supplier.SelectedValueChanged += new System.EventHandler(this.edt_supplier_SelectedIndexChanged_1);
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(261, 57);
            this.edt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(321, 26);
            this.edt_name.TabIndex = 2;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(530, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "المورد";
            // 
            // edt_category
            // 
            this.edt_category.AllowDrop = true;
            this.edt_category.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.edt_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_category.FormattingEnabled = true;
            this.edt_category.Location = new System.Drawing.Point(267, 126);
            this.edt_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edt_category.Name = "edt_category";
            this.edt_category.Size = new System.Drawing.Size(321, 28);
            this.edt_category.TabIndex = 5;
            this.edt_category.SelectedIndexChanged += new System.EventHandler(this.edt_category_SelectedIndexChanged);
            this.edt_category.SelectionChangeCommitted += new System.EventHandler(this.edt_category_SelectedIndexChanged);
            this.edt_category.SelectedValueChanged += new System.EventHandler(this.edt_category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(530, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "الصنف";
            // 
            // Add_Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Buy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملية شراء";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Add_Categories_Activated);
            this.Load += new System.EventHandler(this.Add_Buy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton btn_addclose;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label txt_message;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radio_part;
        public System.Windows.Forms.Label edt_buyall;
        private System.Windows.Forms.RadioButton radio_no;
        private System.Windows.Forms.RadioButton radio_yes;
        public System.Windows.Forms.TextBox edt_supplierpayment;
        public System.Windows.Forms.TextBox edt_buyprimary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox edt_quantity;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_addnewgroups;
        public System.Windows.Forms.ComboBox edt_supplier;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox edt_category;
        private System.Windows.Forms.Label label2;
    }
}