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
using THAGBAN_INST.DATA;
using EntityState = System.Data.Entity.EntityState;
using THAGBAN_INST.FORM.BUY;

namespace EPS.PL
{
    public partial class BuyPage : DevExpress.XtraEditors.XtraUserControl
    {
        db_max_instEntities db;
        TB_BUY add;
        public int id;
        string valuePayment;
        public BuyPage()
        {
            InitializeComponent();
            LoadData();
            SetCurrncyValue();


        }
        private void SetCurrncyValue()
        {
            gridView1.Columns["SupplierPyment"].Caption = "الديون - " ;
            gridView1.Columns["BuyAllValue"].Caption = " الشراء الكلي - " ;


        }

        // Load Data Method
        public void LoadData()
        {
            db_max_instEntities dbContext = new db_max_instEntities();
            dbContext.TB_BUY.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_BUY.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Buy page = new Add_Buy();
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
                add = new TB_BUY();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add = db.TB_BUY.Where(x => x.ID == id).FirstOrDefault();
                    Add_Buy page = new Add_Buy();
                    page.page = this;
                    page.btn_add.Text = "تعديل";
                    page.btn_addclose.Text = "تعديل + غلق";
                    page.id = id;
                    page.page = this;
                    page.ID_Category = (int)add.ID_Catgeory;
                    page.ID_Supplier = (int)add.ID_Supplier;
                    page.edt_name.Text = add.Name;
                    page.edt_quantity.Text = add.Quantity.ToString();
                 
                    page.edt_buyprimary.Text = add.BuyPrice.ToString();
                    page.edt_supplierpayment.Text = add.SupplierPyment.ToString();
                    page.edt_buyall.Text = add.BuyAllValue.ToString();

                    page.price = (double)(add.BuyAllValue - add.SupplierPyment);
                    MessageBox.Show(page.price.ToString());
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
                add = new TB_BUY();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات , سيتم حذف جميع البيانات المرتبطة", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.TB_BUY.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(add).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();

                        // Add new notification
                       

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
            gridControl1.ShowPrintPreview();
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            try
            {
                db = new db_max_instEntities();
                add = new TB_BUY();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add = db.TB_BUY.Where(x => x.ID == id).FirstOrDefault();
                    Add_Buy page = new Add_Buy();
                    page.page = this;
                    page.btn_add.Visible = false;
                    page.Enabled = false;
                    page.btn_addclose.Visible = false;
                    page.id = id;
                    page.page = this;
                    page.ID_Category = (int)add.ID_Catgeory;
                    page.ID_Supplier = (int)add.ID_Supplier;
                    page.edt_name.Text = add.Name;
                  
                    page.edt_quantity.Text = add.Quantity.ToString();
                  
                    page.edt_buyprimary.Text = add.BuyPrice.ToString();
                    page.edt_supplierpayment.Text = add.SupplierPyment.ToString();
                    page.edt_buyall.Text = add.BuyAllValue.ToString();
                   
                    page.Show();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات , اختر صف لعرضه", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
           valuePayment= XtraInputBox.Show("اكتب المبلغ المراد دفعة في عملة + ],تذكر سيتم التسديد هنا وفي بيانات المورد ويتم اعتماد  سعر التحويل الحالي بين العملتين", "عمل دفعة","0.00");
            if (valuePayment != null)
            {
                MakePayment();
                LoadData();
            }
            

        }

        private void MakePayment()
        {

            try { 
            db = new db_max_instEntities();
            add = new TB_BUY();
            id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
             add = db.TB_BUY.Where(x => x.ID == id).FirstOrDefault();

                if (id != 0)
            {

                db = new db_max_instEntities();

                add = new TB_BUY
                {
                    ID = add.ID,
                    ID_Catgeory = add.ID_Catgeory,
                    ID_Supplier = add.ID_Supplier,
                    Name = add.Name,
                   
                    Quantity = add.Quantity,
                   
                    SupplierPyment = add.SupplierPyment - Convert.ToDouble(valuePayment),
                    BuyAllValue = add.BuyAllValue,
                    DateAdd = add.DateAdd,
                    Description = add.Description,
                   
                };

                    TBL_SuppliersPayments logs = new TBL_SuppliersPayments
                    {
                        SUPLAYER_ID = add.ID_Supplier,
                        Pamnent = Convert.ToDouble(valuePayment),
                        Date = DateTime.Now
                    };
                    db.TBL_SuppliersPayments.Add(logs);

                    db.Set<TB_BUY>().AddOrUpdate(add);

                // Save DataBase
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("f1449fe1-3838-416b-b71a-c50500f603ee");
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات , اختر صف لعمل الدفعة", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch
            {

            }
        }

        private void btn_showdateofpayments_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                db = new db_max_instEntities();
                var logs = new FRM_PamymnetsLogSuppliers();
                logs.Text = logs.Text + " - قائمة رقم " + id.ToString();
              //  logs.gridControl1.DataSource = db.TBL_SuppliersPayments.Where(x => x.SellID == id).ToList();
                logs.Show();
            }
            catch { }
        }
    }
}
