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
using EPS.PL;
using THAGBAN_INST.FORM.BUY;
using THAGBAN_INST.DATA;

namespace EPS.AddPage
{
    public partial class Add_Categories : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        bool state;
        TBL_CATEGORIES add;
        db_max_instEntities db;
        public double CatQuantity;
        public CategoriesPage page;
        public int IDGroup;



        public Add_Categories()
        {
            InitializeComponent();
        }

        private bool Save()
        {
            // check fields

            THAGBAN_INST.adl.method method = new THAGBAN_INST.adl.method();
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
                      //  method.show_add_message();

                        // Add new notification




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
                  //  method.show_edit_message();

                    // Add new notification




                }
            }
            return state;
        }

        private void AddData()
        {
            try
            {
                db = new db_max_instEntities();
                add = new TBL_CATEGORIES
                {
                    CatName = edt_name.Text,
                    CatDes = edt_description.Text,
                    CatQuantity = CatQuantity,

                };
                db.Entry(add).State = System.Data.Entity.EntityState.Added;
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
            try
            {
                db = new db_max_instEntities();
                add = new TBL_CATEGORIES
                {
                    ID = id,
                    CatName = edt_name.Text,
                    CatDes = edt_description.Text,
                    CatQuantity = CatQuantity,


                };
                db.Entry(add).State = System.Data.Entity.EntityState.Modified;
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
                add = db.TBL_CATEGORIES.Where(x => x.CatName == edt_name.Text).FirstOrDefault();
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
        private void Message(string message)
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
        }



        private void combo_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void link_addnewgroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}