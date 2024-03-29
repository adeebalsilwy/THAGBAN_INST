﻿using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_MANG_STUD.terms
{
    public partial class frm_add_terms : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int term_id=0;

        public string term_name;
        public string spec_year;
        public int spaicla_id;


        public frm_add_terms()
        {
            InitializeComponent();
        }

        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_add_job_Load(object sender, EventArgs e)
        {
           
            if (term_id != 0)
            {
               TBL_TERMS tbl= con.TBL_TERMS.Find(term_id);
                txt_term_name.Text = tbl.TERM_NAME.ToString();
                com_term_year.DataSource = con.TBL_YEARS.ToList();
                com_term_year.DisplayMember = "YEAR_NAME";
                com_term_year.ValueMember = "YEAR_ID";
                //spaicla_id = Convert.ToInt32(con.TBL_YEARS.Find(year).SPEC_ID);
                //   com_term_year.Text = con.TBL_TERMS.Find(tech_id).SPEC_YEAR.ToString();
                com_spiacl.DataSource = con.TBL_SPECIAL.ToList();
                com_spiacl.DisplayMember = "SPEC_NAME";
                com_spiacl.ValueMember = "SPEC_ID";
                com_spiacl.SelectedValue = spaicla_id;
            }
            else
            {
                get_data();
            }
           
        }
     
        public void get_data()
        {

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_SPECIAL.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                com_spiacl.DataSource = dbContext.TBL_SPECIAL.Local.ToBindingList();
                com_spiacl.DisplayMember = "SPEC_NAME";
                com_spiacl.ValueMember = "SPEC_ID";
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        void clear()
        {
            spaicla_id =0;
            term_id = 0;
            com_term_year.Text = "";
            txt_term_name.Text = "";
            com_spiacl.Text = "";


        }
        bool is_empty()
        {
            if (com_term_year.Text != "" && txt_term_name.Text != "" && com_spiacl.Text != "")
            {
                return false;
            }
            else
                return true;

        }

        void add_terms()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    TBL_TERMS cl = new TBL_TERMS();
                    cl.TERM_NAME = txt_term_name.Text;
                    //cl.YEAR_ID =Convert.ToInt32(com_term_year.SelectedValue);
                    //cl.SPEC_ID = Convert.ToInt32(com_spiacl.SelectedValue);

                    if (term_id != 0)
                    {
                        //add 
                        cl.TERM_ID = Convert.ToInt32(term_id);
                        con.TBL_TERMS.AddOrUpdate(cl);
                        con.SaveChanges();
                        toast.Width = this.Width;

                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        con.TBL_TERMS.AddOrUpdate(cl);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();

                    }
                }
                catch (Exception ex)
                {

                    //dialge.Width = this.Width;
                    dialge.lbl_mess.Text ="لايمكن اضافه الترم " +
                        "لنفس السنه لنفس التخصص ";
                    dialge.Show();
                }
                clear();
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
            add_terms();
        }

        private void com_spiacl_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
            if (com_spiacl.SelectedValue!= null)
            {
                spaicla_id=Convert.ToInt32(com_spiacl.SelectedValue.ToString());
              // com_term_year.DataSource=con.TBL_YEARS.Where(w=>w.SPEC_ID==spaicla_id).ToList();
                com_term_year.DisplayMember = "YEAR_NAME";
                com_term_year.ValueMember = "YEAR_ID";
                

            }
        }

        private void com_spiacl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void com_term_year_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}