﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.job
{
    public partial class frm_add_job : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int job_id;

        public string job_name;
        public string job_desc;
        public string job_note;
        public string dept_id;
        public string dept_name;


        public frm_add_job()
        {
            InitializeComponent();
        }

        void get_job_first()
        {
            try
            {
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                var temp = con.TBL_LECT_MATRIAL.ToList();
                if (temp.Count > 0)
                {
                    foreach (var item in temp)
                    {
                        source.Add(item.MATRIAL_LECT_NAME);
                    }
                }
                txt_job_name.AutoCompleteCustomSource = source;
            }
            catch (Exception ex)
            {

            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_add_job_Load(object sender, EventArgs e)
        {
            get_data();
            if (job_id != 0)
            {
                com_dept.SelectedValue = dept_id;
                txt_job_name.Text = job_name;
                txt_job_note.Text = job_note;
                txt_job_desc.Text = job_desc;
            }
           
        }
        public void get_data()
        {

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_DEPT.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                com_dept.DataSource = dbContext.TBL_DEPT.Local.ToBindingList();
                com_dept.DisplayMember = "DEPT_NAME";
                com_dept.ValueMember = "DEPT_ID";
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        void clear()
        {
            dept_id ="";
            job_id = 0;
            txt_job_desc.Text = "";
            txt_job_name.Text = "";
            com_dept.Text = "";
            txt_job_note.Text = "";


        }
        bool is_empty()
        {
            if (txt_job_desc.Text != "" && txt_job_name.Text != "" && com_dept.Text != "")
            {
                return false;
            }
            else
                return true;

        }

        void add_dept()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    TBL_JOB cl = new TBL_JOB();
                    cl.JOB_NAME = txt_job_name.Text.Trim().ToString();
                    cl.JOB_DESC = txt_job_desc.Text;
                    cl.NOTE= txt_job_note.Text;
                    cl.DEPT_ID =Convert.ToInt32(com_dept.SelectedValue.ToString());

                    if (job_id != 0)
                    {
                        //add 
                        cl.JOB_ID = Convert.ToInt32(job_id);
                        con.TBL_JOB.AddOrUpdate(cl);
                        con.SaveChanges();
                        toast.Width = this.Width;

                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();
                        clear();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        con.TBL_JOB.AddOrUpdate(cl);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();
                        clear();

                    }
                }
                catch (Exception ex)
                {

                    dialge.Width = this.Width;
                    dialge.lbl_mess.Text = ex.Message;
                    dialge.Show();
                }
              
            }
            else
            {
                dialge.Width = this.Width;
                dialge.lbl_mess.Text = "الرجاء ادخال جميع البيانات ";
                dialge.Show();



            }


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_dept();
        }
    }
}