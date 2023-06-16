using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using EPS.AddPage;
using System.Data.Entity.Migrations;
using DevExpress.XtraReports.UI;
using EPS.PL;
using THAGBAN_INST.DATA;
using EntityState = System.Data.Entity.EntityState;
using EPS.Page;

namespace THAGBAN_INST.FORM.BUY
{
    public partial class SuppliersPage : DevExpress.XtraEditors.XtraUserControl
    {
        db_max_instEntities db;
        TBL_SUPPLIERS add;
        public int id;
        string valuePayment;
        int ID_Supplier;
        double TotalValue1;
        double TotalValue2;
        public SuppliersPage()
        {
            InitializeComponent();
            LoadData();
            SetCurrncyValue();


        }
        // Load Data Method
        public void LoadData()
        {
            UpdateCustomerValue();
           db_max_instEntities dbContext = new db_max_instEntities();
            dbContext.TBL_SUPPLIERS.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TBL_SUPPLIERS.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        // Set Currnecy
        private void SetCurrncyValue()
        {
            //var primarycurrname = Properties.Settings.Default.PrimaryCurrName;
            //var secodrycurrname = Properties.Settings.Default.SecondryCurrName;
            //gridView1.Columns[1].Caption = "الرصيد - " + primarycurrname;
            //gridView1.Columns[2].Caption = "الرصيد - " + secodrycurrname;


        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Suppliers page = new Add_Suppliers();
                page.btn_add.Text = "اضافة";
                page.btn_addclose.Text = "اضافة + غلق";
                page.edt_name.Text = "";
                page.id = 0;
                page.page = this;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                db = new db_max_instEntities();
                add = new TBL_SUPPLIERS();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add = db.TBL_SUPPLIERS.Where(x => x.ID == id).FirstOrDefault();
                    Add_Suppliers page = new Add_Suppliers();
                    page.btn_add.Text = "تعديل";
                    page.btn_addclose.Text = "تعديل + غلق";
                    page.edt_name.Text = add.SupplierName;
                    page.edt_phonenumber.Text = add.SupplierPhone.ToString();
                    page.SupplierBalance = (double)add.SupplierBalance;
                    page.id = id;
                    page.page = this;
                    page.Show();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها, اختر صف لتعديله", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات","خطأ في الاتصال",MessageBoxButtons.OK,MessageBoxIcon.Information); 

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            LoadData();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new db_max_instEntities();
                add = new TBL_SUPPLIERS();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات , سيتم حذف جميع البيانات المرتبطة", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.TBL_SUPPLIERS.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(add).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();

                        //// Add new notification
                        //BL.Note note = new BL.Note();
                        //Page.Notifications notifications = new Page.Notifications();
                        //var username = Properties.Settings.Default.UserFullName;
                        //var Note = " تم حذف مورد من قبل " + username;
                        //note.AddNote(Note, notifications, "حذف");

                    }

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لحذفها", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , سيتم تصفير الديون من جميع عمليات الشراء المرتبطة بهذا المورد", "اجراء تصفير حساب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dilogeresult == DialogResult.Yes)
            {
                var ID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));

                try
                {
                    db = new db_max_instEntities();
                    var listid = db.TB_BUY.Where(x => x.ID_Supplier == ID).Select(x => x.ID).ToList();
                    for (int i = 0; i < listid.Count; i++)
                    {
                        TB_BUY buy = new TB_BUY();
                        var id = listid[i];
                        buy = db.TB_BUY.Where(x => x.ID_Supplier == ID && x.ID == id).FirstOrDefault();
                        buy.SupplierPyment = 0;
                        db.Set<TB_BUY>().AddOrUpdate(buy);
                        db.SaveChanges();
                    }
                    MessageBox.Show("تم تصفير الحساب بنجاح");
                    // Add new notification
                    
                }
                catch { }
            }

            LoadData();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));

            SetDateForPrintReport report = new SetDateForPrintReport();
            report.ID = ID;
            report.ReportName = "الموردين";

            report.Show();


        }


       

        private void UpdateCustomerValue()
        {
            try
            {

                db = new db_max_instEntities();
                // Add Supplier Value
                TBL_SUPPLIERS suppliers = new TBL_SUPPLIERS();
                var idsupplierlist = db.TBL_SUPPLIERS.Select(x => x.ID).ToList();

                for (int i = 0; i < idsupplierlist.Count; i++)
                {
                    var id = idsupplierlist[i];
                    suppliers = db.TBL_SUPPLIERS.Where(x => x.ID == id).FirstOrDefault();

                    if (suppliers != null)
                    {
                        TotalValue1 = (double)db.TB_BUY.Where(x => x.ID_Supplier == id).Select(x => x.SupplierPyment).ToArray().Sum();
                        if (TotalValue1 != null || TotalValue2 != null)
                        {
                            suppliers.SupplierBalance = TotalValue1;
                            suppliers.SupplierBalancePrim = Convert.ToDouble(TotalValue2.ToString("#0.00"));

                            db.Set<TBL_SUPPLIERS>().AddOrUpdate(suppliers);
                            db.SaveChanges();

                        }
                    }






                }



                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_showdateofpayments_Click(object sender, EventArgs e)
        {
            try
            {
                db = new db_max_instEntities();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                add = db.TBL_SUPPLIERS.Where(x => x.ID == id).FirstOrDefault();
                FRM_PamymnetsLogSuppliers logs = new FRM_PamymnetsLogSuppliers();
                logs.Text = logs.Text + " - اسم المورد  " + add.SupplierName.ToString();
                logs.gridControl1.DataSource = db.TBL_SuppliersPayments.Where(x => x.SUPLAYER_ID == id).ToList();
                logs.Show();
            }
            catch { }
        }
    }
}
