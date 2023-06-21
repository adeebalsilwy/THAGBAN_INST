﻿using DevExpress.XtraEditors;
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
using THAGBAN_INST.DATA;
using EntityState = System.Data.Entity.EntityState;

namespace THAGBAN_INST.FORM.BUY
{
    public partial class CategoriesPage : DevExpress.XtraEditors.XtraUserControl
    {
        db_max_instEntities db;
        TBL_CATEGORIES add;
        public int id;
        public CategoriesPage()
        {
            InitializeComponent();
            LoadData();
            
        }


        // Load Data Method
        public void LoadData()
        {
            db_max_instEntities dbContext = new db_max_instEntities();
            dbContext.TBL_CATEGORIES.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TBL_CATEGORIES.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Categories page = new Add_Categories();
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
                add = new TBL_CATEGORIES();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add = db.TBL_CATEGORIES.Where(x => x.ID == id).FirstOrDefault();
                    Add_Categories page = new Add_Categories();
                    page.btn_add.Text = "تعديل";
                    page.btn_addclose.Text = "تعديل + غلق";
                    page.edt_name.Text = add.CatName;
                    page.edt_description.Text = add.CatDes;
                    page.CatQuantity = (double)add.CatQuantity;
                    page.id = id;
                    page.stor_id=Convert.ToInt32(db.TBL_CATEGORIES.Find(id).STOR_ID.ToString());
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
                add = new TBL_CATEGORIES();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات , سيتم حذف جميع البيانات المرتبطة", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.TBL_CATEGORIES.Where(x => x.ID == id).FirstOrDefault();
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

       
    }
}
