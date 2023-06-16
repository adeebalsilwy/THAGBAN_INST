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
using EPS.PL;
using System.Data.Entity.Migrations;
using THAGBAN_INST.DATA;
using THAGBAN_INST.FORM.BUY;

namespace EPS.AddPage
{
    public partial class Add_Suppliers : DevExpress.XtraEditors.XtraForm
    {
        public  int id;
        bool state;
        db_max_instEntities db;
        TBL_SUPPLIERS add;
        public SuppliersPage page;
        public double SupplierBalance;
       


        public Add_Suppliers()
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
                    
                    if(checkDuplicate == true)
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
                       



                    }
                    
                }
                else
                {
                    // Edit
                   
                        // Edit
                        EditData();
                        state = true;
                        page.LoadData();


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
                add = new TBL_SUPPLIERS
                {
                    SupplierName = edt_name.Text,
                    SupplierAddress = edt_address.Text,
                    SupplierBalance = 0.00,
                    SupplierBalancePrim = 0.00,

                    SupplierPhone = Convert.ToInt64(edt_phonenumber.Text),
                    SupplierDate=DateTime.Now


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
                add = db.TBL_SUPPLIERS.Where(x => x.ID == id).FirstOrDefault();

                add = new TBL_SUPPLIERS
                {
                    ID=id,
                    SupplierName = edt_name.Text,
                    SupplierAddress = edt_address.Text,
                    SupplierPhone = Convert.ToInt64(edt_phonenumber.Text),
                    SupplierDate = DateTime.Now,
                    SupplierBalance=add.SupplierBalance,
                    SupplierBalancePrim=add.SupplierBalancePrim
                    



                };
                db.Set<TBL_SUPPLIERS>().AddOrUpdate(add);
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
                add = db.TBL_SUPPLIERS.Where(x => x.SupplierName == edt_name.Text).FirstOrDefault();
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
                Save();
           
                Close();

            
           
        }

        private void Add_Categories_Activated(object sender, EventArgs e)
        {
            
        }

        private void edt_phonenumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_phonenumber.Text, "[^0-9]") || edt_phonenumber.Text == "")
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_phonenumber.Text = "0";
            }
        }
    }
}