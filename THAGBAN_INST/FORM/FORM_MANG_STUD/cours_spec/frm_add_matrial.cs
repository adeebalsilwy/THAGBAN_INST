﻿using DevExpress.XtraEditors;
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

namespace THAGBAN_INST.FORM.FRM_MANG_STUD.matrila
{
    public partial class frm_add_matrial : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int id=0;
        public int cours_id = 0;
        public string cours_name;
        public string cours_desc;
        public int spaicla_id;
        public int term_id;
        public string spic_year;


        public frm_add_matrial()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_add_job_Load(object sender, EventArgs e)
        {
           
            if (id != 0)
            {
               TBL_SPE_COURS tbl= con.TBL_SPE_COURS.Find(id);
                // txt_cours_name.Text = tbl.COURS_NAME.ToString();
                cours_id= Convert.ToInt32(tbl.COURS_ID.ToString());
                term_id =Convert.ToInt32(tbl.TERM_ID);
               
                
              

                get_info();
                
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
            com_cours.DataSource = con.TBL_COURS.ToList();
            com_cours.DisplayMember = "COURS_NAME";
            com_cours.ValueMember = "COURS_ID";

        }
        void clear()
        {
            spaicla_id =0;
            id = 0;
            com_cours.Text = "";
            com_spiacl.Text = "";
            com_term.Text="";
            com_year.Text = "";


        }
        bool is_empty()
        {
            if ( com_cours.Text != "" && com_spiacl.Text != "")
            {
                return false;
            }
            else
                return true;

        }
        void get_info()
        {



            com_cours.DataSource = con.TBL_COURS.ToList();
            com_cours.DisplayMember = "COURS_NAME";
            com_cours.ValueMember = "COURS_ID";
            com_cours.SelectedValue = cours_id;

            TBL_TERMS te = con.TBL_TERMS.Find(term_id);
            int year = Convert.ToInt32(te.YEAR_ID);
            spaicla_id = Convert.ToInt32(con.TBL_TERMS.Find(term_id).SPEC_ID.ToString());
            com_spiacl.DataSource = con.TBL_SPECIAL.ToList();
            com_spiacl.DisplayMember = "SPEC_NAME";
            com_spiacl.ValueMember = "SPEC_ID";
            com_spiacl.SelectedValue = spaicla_id;

            com_year.DataSource = con.TBL_YEARS.Where(w => w.SPEC_ID == spaicla_id).ToList();
            com_year.DisplayMember = "YEAR_NAME";
            com_year.ValueMember = "YEAR_ID";
            com_year.SelectedValue = year;


            com_term.DataSource = con.TBL_TERMS.Where(w => w.YEAR_ID == year && w.SPEC_ID == spaicla_id).ToList();
            com_term.DisplayMember = "TERM_NAME";
            com_term.ValueMember = "TERM_ID";




            //com_term.DataSource =con.TBL_TERMS.ToList();
            //com_term.DisplayMember = "TERM_NAME";
            //com_term.ValueMember = "TERM_ID";
            //com_term.SelectedValue = tech_id;



            //com_year.DataSource =con.TBL_YEARS.ToList();
            //com_year.DisplayMember = "YEAR_NAME";
            //com_year.ValueMember = "YEAR_ID";







        }
        void add_spec_cours()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    TBL_SPE_COURS cl = new TBL_SPE_COURS();
                    cl.COURS_ID = Convert.ToInt32(com_cours.SelectedValue.ToString()); ;
                    cl.TERM_ID =Convert.ToInt32(com_term.SelectedValue.ToString());
                    cl.YEAR_ID= Convert.ToInt32(com_year.SelectedValue.ToString());
                    cl.SPEC_ID= Convert.ToInt32(com_spiacl.SelectedValue.ToString());

                    if (id != 0)
                    {
                        //add 
                        cl.ID = Convert.ToInt32(id);
                        con.TBL_SPE_COURS.AddOrUpdate(cl);
                        con.SaveChanges();
                        //toast.Width = this.Width;

                        toast.lbl_mess.Text = "تم التعديل بنجاح";
                        toast.Show();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        con.TBL_SPE_COURS.AddOrUpdate(cl);
                        con.SaveChanges();
                       // toast.Width = this.Width;
                        toast.lbl_mess.Text = "تم الاضافه ينجاح  بنجاح";
                        toast.Show();

                    }
                }
                catch (Exception ex)
                {

                    dialge.Width = this.Width;
                    dialge.lbl_mess.Text = ex.Message;
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
            add_spec_cours();
        }

        private void com_spiacl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(com_spiacl.SelectedValue!= null)
            {
                spaicla_id = Convert.ToInt32(com_spiacl.SelectedValue.ToString());
                com_year.DataSource = con.TBL_YEARS.Where(w => w.SPEC_ID == spaicla_id).ToList();
                com_year.DisplayMember = "YEAR_NAME";
                com_year.ValueMember = "YEAR_ID";

            }
           
        }

        private void com_year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (com_year.SelectedValue != null)
            {
                int year = Convert.ToInt32(com_year.SelectedValue);
                com_term.DataSource = con.TBL_TERMS.Where(w => w.YEAR_ID == year && w.SPEC_ID==spaicla_id).ToList();
                com_term.DisplayMember = "TERM_NAME";
                com_term.ValueMember = "TERM_ID";
            }
         
        }
    }
}