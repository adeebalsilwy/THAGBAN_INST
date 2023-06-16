using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EPS.PL;
using System.IO;
using DevExpress.XtraRichEdit.API.Native;
using THAGBAN_INST.FORM.BUY;
using THAGBAN_INST.DATA;
using EPS.BL;

namespace EPS.AddPage
{
    public partial class Add_Buy : DevExpress.XtraEditors.XtraForm
    {
        public  int id;
        bool state;
        TB_BUY add;
        db_max_instEntities db;
        Note note;
        public double CatQuantity;
        public BuyPage page;
        public int IDGroup;
        public byte[] image;
        double CurrConvertValue;
       public double price;
       public  int ID_Category;
       public int ID_Supplier;
        private double? Suplirment;

        public Add_Buy()
        {
            InitializeComponent();
        }

        private bool Save()
        {
            // check fields

            if (edt_name.Text == "")
            {
                Message("اكمل الحقل لطفا");
            }
            else
            {
                // Add or edit
                 var checkDuplicate = CheckDuplicateData();
                if (id == 0)
                {
                    // Add
                    // Check Duplicate Data

                    if (checkDuplicate == true)
                    {
                        Message("البيانات مكررة");

                    }
                    else
                    {
                        // Add
                        AddData();
                        state = true;
                        page.LoadData();


                        // Add new notification
                        //note = new Note();
                        //Page.Notifications notifications = new Page.Notifications();
                        //var username = Properties.Settings.Default.UserFullName;
                        //var Note = " تمت اجراء عملية شراء جديدة من قبل "+ username;
                        //note.AddNote(Note, notifications, "اضافة");



                    }

                }
                else
                {
                    // Edit
                    // Check Duplicate Data

                    // Edit
                    EditData();
                    state = true;
                    page.LoadData();


                    // Add new notification
                    //note = new Note();
                    //Page.Notifications notifications = new Page.Notifications();
                    //var username = Properties.Settings.Default.UserFullName;
                    //var Note = " تم تعديل مادة في المشتريات حالية من قبل " + username;
                    //note.AddNote(Note, notifications, "تعديل");



                }
            }
            return state;
        }

        private void AddData()
        {
            THAGBAN_INST.adl.method method = new THAGBAN_INST.adl.method();
            if (radio_part.Checked == true)
            {
                Suplirment = Convert.ToDouble(edt_buyall.Text) - Convert.ToDouble(edt_supplierpayment.Text);

                }
            else
            {
                Suplirment = Convert.ToDouble(edt_supplierpayment.Text);

                }
            try
            {
                db = new db_max_instEntities();
                add = new TB_BUY
                {
                    ID_Catgeory = ID_Category,
                    ID_Supplier = ID_Supplier,
                    Name = edt_name.Text,
                    Quantity = Convert.ToDouble(edt_quantity.Text),

                    BuyPrice = Convert.ToDouble(edt_buyprimary.Text),

                    SupplierPyment = Suplirment,

                
                BuyAllValue = Convert.ToDouble(edt_buyall.Text),
                    DateAdd = DateTime.Now,
                };
                db.Entry(add).State = System.Data.Entity.EntityState.Added;
                double t=0;
                if (radio_yes.Checked == true)
                {
                    t = Convert.ToDouble(edt_buyall.Text);
                    method.sub_to_box(THAGBAN_INST.Properties.Settings.Default.inst_id, t);

                }
                else if (radio_part.Checked == true)
                {
                    t = Convert.ToDouble(edt_supplierpayment.Text);
                    method.sub_to_box(THAGBAN_INST.Properties.Settings.Default.inst_id, t);

                }

                

                // Add Catedory Quantity
                TBL_CATEGORIES categories = new TBL_CATEGORIES();
                categories = db.TBL_CATEGORIES.Where(x => x.ID == ID_Category).FirstOrDefault();
                categories.CatName = categories.CatName;
                categories.CatDes = categories.CatDes;
                categories.CatQuantity+= Convert.ToDouble(edt_quantity.Text);
                categories.ID = categories.ID;
                db.Entry(categories).State = System.Data.Entity.EntityState.Modified;




                // Save DataBase
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("b63bb4e2-c3ce-411f-975a-c860580f1dc7");

            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر");

            }
        }






        private void EditData()
        {
            THAGBAN_INST.adl.method method = new THAGBAN_INST.adl.method();
            if (radio_part.Checked == true)
            {
                Suplirment = Convert.ToDouble(edt_buyall.Text) - Convert.ToDouble(edt_supplierpayment.Text);

            }
            else
            {
                Suplirment = Convert.ToDouble(edt_supplierpayment.Text);

            }
            try
            {
                method.add_to_box(THAGBAN_INST.Properties.Settings.Default.inst_id, this.price);
                db = new db_max_instEntities();
                add = new TB_BUY
                {
                    ID = id,
                    ID_Catgeory = ID_Category,
                    ID_Supplier = ID_Supplier,
                    Name = edt_name.Text,
                 
                    Quantity = Convert.ToDouble(edt_quantity.Text),
                   
                    BuyPrice = Convert.ToDouble(edt_buyprimary.Text),
                    SupplierPyment = Convert.ToDouble(edt_supplierpayment.Text),
                    BuyAllValue = Convert.ToDouble(edt_buyall.Text),
                  
                    DateAdd = DateTime.Now,
                };
                db.Entry(add).State = System.Data.Entity.EntityState.Modified;

                double t = 0;
                if (radio_yes.Checked == true)
                {
                    t = Convert.ToDouble(edt_buyall.Text);
                    method.sub_to_box(THAGBAN_INST.Properties.Settings.Default.inst_id, t);

                }
                else if (radio_part.Checked == true)
                {
                    t = Convert.ToDouble(edt_supplierpayment.Text);
                    method.sub_to_box(THAGBAN_INST.Properties.Settings.Default.inst_id, t);

                }

                // Add Catedory Quantity
                TBL_CATEGORIES categories = new TBL_CATEGORIES();
                categories = db.TBL_CATEGORIES.Where(x => x.ID == ID_Category).FirstOrDefault();
                categories.CatName = categories.CatName;
                categories.CatDes = categories.CatDes;
                categories.CatQuantity = Convert.ToDouble(edt_quantity.Text) + categories.CatQuantity;
                categories.ID = categories.ID;
                db.Entry(categories).State = System.Data.Entity.EntityState.Modified;


                // Save DataBase
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("5eb82af2-6df7-42a2-89da-1a50da44d73b");

            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر");

            }
        }

        private bool CheckDuplicateData()
        {
            try
            {
                db = new db_max_instEntities();
                add = db.TB_BUY.Where(x => x.Name == edt_name.Text).FirstOrDefault();
                if (add == null)
                {
                    state = false;
                }
                else
                {
                    state = true;
                }
            }
            catch
            {
                state = false;
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر");
            }


            return state;

        }
        private void Message( string message)
        {
            txt_message.Visible = true;
            timer1.Enabled = true;
            txt_message.Text = message;
            txt_message.BackColor = Color.Red;
            state = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_message.Visible = false;
            timer1.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           Save();
        }

        private void btn_addclose_Click(object sender, EventArgs e)
        {
            var state = Save();
            if (state == true)
            {
                Close();

            }

        }

        private void Add_Categories_Activated(object sender, EventArgs e)
        {
            LoadSupplier();
            LoadCategory();
            SetCurrencyValue();
            //SetCategoryID();

            UpdateData updateData = new UpdateData();
            updateData.UpdateSuppliersData();

        }

        private void SetCurrencyValue()
        {
            // Set Text 
            //edt_primaryunit.Text = Properties.Settings.Default.PrimaryCurrName;
            //edt_secondryunit.Text = Properties.Settings.Default.SecondryCurrName;
            //label11.Text = label8.Text = label9.Text = edt_primaryunit.Text;
            //label10.Text = label6.Text=label14.Text = edt_secondryunit.Text;
            //CurrConvertValue = Properties.Settings.Default.CurrConvertValue;
            //edt_convertvalue.Text = CurrConvertValue.ToString();

        }

        private void combo_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCategoryID();
        }
        private void SetCategoryID()
        {
           
        }
       

        private void link_addnewgroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CategoriesPage page1 = new CategoriesPage();
                Add_Categories page = new Add_Categories();
                page.btn_add.Text = "اضافة";
                page.btn_addclose.Text = "اضافة + غلق";
                page.edt_name.Text = "";
                page.id = 0;
                page.page = page1;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SuppliersPage page1 = new SuppliersPage();
                Add_Suppliers page = new Add_Suppliers();
                page.btn_add.Text = "اضافة";
                page.btn_addclose.Text = "اضافة + غلق";
                page.edt_name.Text = "";
                page.id = 0;
                page.page = page1;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
        }

        private void LoadCategory()
        {
            try
            {
                db = new db_max_instEntities();
                var data = db.TBL_CATEGORIES.ToList();
                edt_category.DataSource = data;
                edt_category.DisplayMember = "CatName";
                edt_category.ValueMember = "ID";
            }
            catch { }
        }
        private void LoadSupplier()
        {
            try
            {
                db = new db_max_instEntities();
                var data = db.TBL_SUPPLIERS.ToList();
                edt_supplier.DataSource = data;
                edt_supplier.DisplayMember = "SupplierName";
                edt_supplier.ValueMember = "ID";
            }
            catch { }
        }

        private void btn_barcodegenerator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var ma = new MemoryStream();
            //var barcodeWriter = new BarcodeWriter();
            //barcodeWriter.Write(edt_barcode.Text).Save(ma,System.Drawing.Imaging.ImageFormat.Png);
            //image = ma.ToArray();
          

        }

        private void edt_cashbuyprimary_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();




        }

        private void edt_cahbuysecondry_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();

        }

        private void edt_creditbuyprimary_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();


        }

        private void edt_creditbuysecondry_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();

        }

        private void edt_buyprimary_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();





        }

        private void edt_buysecondry_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();

        }

        private void radio_yes_CheckedChanged(object sender, EventArgs e)
        {
            edt_supplierpayment.Enabled = false;
            edt_supplierpayment.Text = "0";

        }

        private void radio_no_CheckedChanged(object sender, EventArgs e)
        {
            edt_supplierpayment.Enabled = false;
            edt_supplierpayment.Text =edt_buyall.Text;


        }

        private void radio_part_CheckedChanged(object sender, EventArgs e)
        {
            edt_supplierpayment.Enabled = true;

        }

        private void edt_buyall_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void edt_sellall_Click(object sender, EventArgs e)
        {

        }

        private void edt_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIDSupplier();
        }
        private void SetIDSupplier()
        {
            try
            {
                //db = new DBEPSEntities();
                //var itme = edt_supplier.SelectedItem.ToString();
                //ID_Supplier = db.TB_Suppliers.Where(x => x.SupplierName == itme).Select(x => x.ID).FirstOrDefault();

            }
            catch { }
        }

        private void edt_supplierpayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void edt_buyall_Click(object sender, EventArgs e)
        {

        }

        private void edt_benfit_Click(object sender, EventArgs e)
        {

        }

        private void edt_sellall_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void edt_quantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_quantity.Text, "[^0-9]") || edt_quantity.Text == "")
            {
                edt_quantity.Text = "1";
            }
            else
            {
                SetSellValue();
            }
        }

        private void edt_barcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_changeconvertvalue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FRM_Settings fRM_Settings = new FRM_Settings();
            //fRM_Settings.Show();
        }

        private void edt_secondryunit_Click(object sender, EventArgs e)
        {

        }

        private void Add_Buy_Load(object sender, EventArgs e)
        {

        }

        private void edt_cashbuyprimary_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void edt_cahbuysecondry_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void edt_creditbuyprimary_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void edt_creditbuysecondry_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void edt_buyprimary_DoubleClick(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_buyprimary.Text, "[^0-9]") || edt_buyprimary.Text == "")
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_buyprimary.Text = "0";
            }
            else
            {
                edt_buyall.Text = ((Convert.ToDouble(edt_buyprimary.Text)) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");
            }
        }

        private void edt_buysecondry_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void edt_supplierpayment_DoubleClick(object sender, EventArgs e)
        {

        }

        private void edt_supplierpaymentsec_DoubleClick(object sender, EventArgs e)
        {
           edt_supplierpayment.Text = ((Convert.ToDouble(edt_supplierpayment.Text)) *CurrConvertValue).ToString("#0.00");

        }

        private void SetSellValue()
        {
            try
            {
                edt_buyall.Text= (Convert.ToDouble(edt_buyprimary.Text) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");
                if (radio_yes.Checked == true)
                {
                    edt_supplierpayment.Enabled = false;
                    edt_supplierpayment.Text = "0";
                }
                else if (radio_no.Checked == true)
                {
                    edt_supplierpayment.Enabled = false;
                    edt_supplierpayment.Text = edt_buyall.Text;
                }

            }
            catch { }
        }

        private void edt_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //db = new DBEPSEntities();
                //var itme = edt_category.SelectedItem.ToString();
                ID_Category = Convert.ToInt32(edt_category.SelectedValue.ToString());

            }
            catch { }
        }

        private void edt_supplier_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                //db = new DBEPSEntities();
                //var itme = edt_category.SelectedItem.ToString();
                ID_Supplier = Convert.ToInt32(edt_supplier.SelectedValue.ToString());

            }
            catch { }
        }
    }
}