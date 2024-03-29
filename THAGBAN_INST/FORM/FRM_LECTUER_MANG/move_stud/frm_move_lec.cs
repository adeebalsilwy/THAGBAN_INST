﻿using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
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

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.move_stud
{
    public partial class frm_move_lec : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int stud_lect_id=0;
        public int temp_stud_id = 0;
        int tech_lect_id = 0;
        public string matrial_name;
        public int cours_id;
        public int lect_id;
        public int stud_id;
        public int temp_cours_id;
        public int temp_lect_id;
        DateTime stud_date;


        public frm_move_lec()
        {
            InitializeComponent();
        }

        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_add_job_Load(object sender, EventArgs e)
        {

            get_data();
           
        }
     
        public void get_data()
        {

           
            //This line of code is generated by Data Source Configuration Wizard
            //Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_LECT_COURS.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                com_com_cours.DataSource = dbContext.TBL_LECT_COURS.Local.ToBindingList();


                com_com_cours.DisplayMember = "LECT_COURS_NAME";
                com_com_cours.ValueMember = "LECT_COURS_ID";

                if (stud_lect_id != 0)
                    com_com_cours.SelectedValue = temp_cours_id;
                //   com_term_year.Text = con.TBL_TERMS.Find(tech_id).SPEC_YEAR.ToString();


            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            com_to_cours.DataSource = con.TBL_LECT_COURS.ToList();


            com_to_cours.DisplayMember = "LECT_COURS_NAME";
            com_to_cours.ValueMember = "LECT_COURS_ID";
        }
        void clear()
        {
            lect_id =0;
            stud_lect_id = 0;
            com_lect.Text = "";
            com_com_cours.Text = "";


        }
        bool is_empty()
        {
            if (com_lect.Text != "" &&com_to_lect.Text!=""&& com_group.Text!=""&& com_to_cours.Text != "" && com_com_cours.Text != "")
            {
                return false;
            }
            else
                return true;

        }
        void add_send()
        {
            TBL_SEND_STUD_LECT cl = new TBL_SEND_STUD_LECT();

           

            // cl.TECH_LECT_ID = Convert.ToInt32(com_group.SelectedValue);


            cl.STUD_LECT_ID = Convert.ToInt32(com_lect.SelectedValue);
            cl.TECH_LECT_ID = Convert.ToInt32(com_group.SelectedValue);
            int lec_id = Convert.ToInt32(con.TBL_STUD_LECT.Find(cl.STUD_LECT_ID).LECT_ID);
            cl.LECT_ID = Convert.ToInt32(lec_id);
            cl.PAID_UP = 0;
            cl.REST = con.TBL_LECTUER.Find(lec_id).LECT_PRICE;
            cl.INST_ID = THAGBAN_INST.Properties.Settings.Default.inst_id;
            cl.SEND_STUD_DATE = DateTime.Now;

        }
        void add_stud_lect()
        {

            int count_mov = 0;
            int count_pass = 0;
            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    // cl.LECT_ID = com_stud.Text;
                    int from_lec = Convert.ToInt32(com_lect.SelectedValue);
                    int to_lec = Convert.ToInt32(com_to_lect.SelectedValue);

                    int from_cours = Convert.ToInt32(com_com_cours.SelectedValue);
                    int to_cours = Convert.ToInt32(com_to_cours.SelectedValue);
                    string group_name = com_group.Text;
                    int from_tech_lec = Convert.ToInt32(com_group.SelectedValue);
                    //  con.TBL_STUD_LECT.Where(w=)
                    //var all_stud = (from stud in con.TBL_STUD_LECT.Where(w=>w.LECT_ID==from_lec)
                    //                join
                    //             cours in con.TBL_LECT_COURS on stud.COURS_ID
                    //             equals cours.LECT_COURS_ID
                    //                join
                    //             tech in con.TBL_LECT_TECH_COURS.Where(w => w.GROUP_NAME.Equals(group_name)) on
                    //             cours.LECT_COURS_ID equals tech.COURS_ID
                    //                select new
                    //                {
                    //                    stud.LECT_TECH_ID,
                    //                    stud.COURS_ID,
                    //                    stud.LECT_ID,
                    //                    stud.LECT_STUD_DATE,
                    //                    stud.STUD_ID,
                    //                }).ToList();

                    var temp = con.TBL_STUD_LECT.Where(w => w.COURS_ID == from_cours
                    && w.LECT_TECH_ID == from_tech_lec && w.LECT_ID == from_lec).ToList();
                    //, (stud, tech) => new
                    //{
                    //    stud.LECT_TECH_ID,
                    //    stud.COURS_ID,
                    //    stud.LECT_ID,
                    //    stud.LECT_STUD_DATE,
                    //    stud.STUD_ID,
                    //}
                    //).ToList();
                    // lect_id = Convert.ToInt32(com_to_lect.SelectedValue);
                    foreach (var item in temp)
                    {
                       
                            TBL_STUD_LECT cl = new TBL_STUD_LECT();
                            cl.STUD_ID = item.STUD_ID;
                            cl.LECT_TECH_ID =item.LECT_TECH_ID;
                            //lect_id = Convert.ToInt32(com_to_lect.SelectedValue);
                            //  TBL_LECT_TECH_COURS tbl = con.TBL_LECT_TECH_COURS.Find(lect_id);
                            cl.LECT_ID = to_lec;
                            cl.COURS_ID = to_cours;

                            // cl.STUD_ID = Convert.ToInt32(com_stud.SelectedValue);
                            string aa = string.Format("{0:dd-MM-yyyy}", txt_lect_stud_date.Value);
                            stud_date = DateTime.ParseExact(aa, "dd-MM-yyyy", null);
                            cl.LECT_STUD_DATE = stud_date;
                            con.TBL_STUD_LECT.AddOrUpdate(cl);


                        TBL_SEND_STUD_LECT sns = new TBL_SEND_STUD_LECT();



                        // cl.TECH_LECT_ID = Convert.ToInt32(com_group.SelectedValue);


                        sns.STUD_LECT_ID = Convert.ToInt32(cl.LECT_STUD_ID);
                        sns.TECH_LECT_ID = Convert.ToInt32(com_group.SelectedValue);
                        int lec_id = Convert.ToInt32(com_lect.SelectedValue);
                        sns.LECT_ID = Convert.ToInt32(lec_id);
                        sns.PAID_UP = 0;
                        sns.STUD_ID = item.STUD_ID;
                        sns.REST = con.TBL_LECTUER.Find(lec_id).LECT_PRICE;
                        sns.INST_ID = THAGBAN_INST.Properties.Settings.Default.inst_id;
                        sns.SEND_STUD_DATE = DateTime.Now;
                        con.TBL_SEND_STUD_LECT.Add(sns);
                        con.SaveChanges();

                            count_mov++;







                        adl.NotifictionUser notifiction = new adl.NotifictionUser(" '" + count_pass + "' عدد الطلاب الغير منقولين \n '" + temp.Count + "'  جمالي عدد الطلاب في الدوره \n '" + count_mov + "' عدد الطلاب المنقولين ", THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Height = this.Height / 2;
                        notifiction.Show();

                    }
                }
                catch (Exception ex)
                {
                    count_mov++;
                    MessageBox.Show(ex.Message + ex.InnerException);
                    //dialge.Width = this.Width;
                    //dialge.lbl_mess.Text ="لايمكن نقل  الطلاب " +
                    //    "لنفس الكورس  ولنفس الدوره ";
                    //dialge.Show();
                }
               // clear();
            }
            else
            {
                dialge.Width = this.Width;
                dialge.lbl_mess.Text = "الرجاء ادخال جميع البيانات ";
                dialge.Show();



            }

            get_data();


        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("هل تريد تاكيد نقل \nجميع الطلاب الى المستوى المحدد ", "تحذير النقل ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                add_stud_lect();
            }
            get_data();
        }

        private void com_spiacl_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (com_com_cours.SelectedValue != null)
            {
                try
                {
                    cours_id = Convert.ToInt32(com_com_cours.SelectedValue.ToString());
                    get_lect();
                }catch(Exception ex) { }



            }
        }
       
        void get_lect()
        {
            cours_id = Convert.ToInt32(com_com_cours.SelectedValue);
            var tbl = con.TBL_LECT_TECH_COURS.Where(w => w.COURS_ID == cours_id && w.STATE == true)
                .Join(con.TBL_LECTUER, l => l.TBL_LECTUER.LECT_ID, tl => tl.LECT_ID,
                (l, tl) => new
                {
                    l.LECT_ID,
                  //  l.GROUP_NAME,
                    l.TBL_LECTUER.LECT_NAME,

                }).Distinct();

            //var tbl1 = (from tl in con.TBL_LECT_TECH_COURS.Where(w => w.STATE == true)
            //            join
            //         l in con.TBL_LECTUER on tl.LECT_ID equals l.LECT_ID
            //            join c in con.TBL_LECT_COURS.Where(w => w.LECT_COURS_ID == spec_id) on 
            //            l.LECT_COURS_ID equals c.LECT_COURS_ID
            //            select new
            //            {
            //                TECH_LECT_ID = tl.TECH_LECT_ID,
            //                LECT_NAME = l.LECT_NAME,
            //            }).Distinct().ToList();


            //var tbl1= con.TBL_LECTUER.Join(con.TBL_LECT_COURS.Where(w=>w.LECT_COURS_ID==spec_id),
            //    l=>l.TBL_LECT_COURS.LECT_COURS_ID,
            //    c=>c.LECT_COURS_ID,
            //    (l,c)=>new
            //    {
            //        l.LECT_ID,
            //        l.LECT_NAME,
            //    }).Distinct().ToList();


            if (tbl != null)
            {
                com_lect.DataSource = tbl.ToList();
                com_lect.DisplayMember = "LECT_NAME";
                com_lect.ValueMember = "LECT_ID";
               

               

                if (stud_lect_id == 0)
                {
                    com_lect.SelectedValue = temp_lect_id;
                }
            }
        }
        void get_group()
        {
            //var tbl = con.TBL_LECT_TECH_COURS.Where(w => w.COURS_ID == stud_lect_id && w.STATE == true)
            //    .Join(con.TBL_LECTUER, l => l.TBL_LECTUER.LECT_ID, tl => tl.LECT_ID,
            //    (l, tl) => new
            //    {
            //        l.TECH_LECT_ID,
            //        l.GROUP_NAME,
            //        tl.LECT_NAME,

            //    });




            lect_id = Convert.ToInt32(com_lect.SelectedValue);
                com_group.DataSource =con.TBL_LECT_TECH_COURS.Where(w=>w.STATE==true && w.LECT_ID==lect_id).ToList();
                com_group.DisplayMember = "GROUP_NAME";
                com_group.ValueMember = "TECH_LECT_ID";

                if (stud_lect_id == 0)
                {
                    com_group.SelectedValue = temp_lect_id;
                }
            
        }
        private void com_term_year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (com_lect.SelectedValue != null)
            {
                try
                {

                    tech_lect_id=Convert.ToInt32(com_lect.SelectedValue);
                    get_group();
                }catch(Exception ex)
                {

                }
            }
        }

        private void com_stud_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //if (com_stud.SelectedValue != null)
                //{
                //    stud_id = Convert.ToInt32(com_stud.SelectedValue.ToString());
                //    lbl_l_name.Text = con.TBL_STUDENTS.Find(stud_id).STUD_LNAME.ToString();
                    //com_com_cours.DataSource = con.TBL_STUD_LECT.
                    //    Where(w => w.STUD_ID == stud_id).Join(con.TBL_LECT_COURS, s => s.TBL_LECT_COURS.LECT_COURS_ID,
                    //    a => a.LECT_COURS_ID, (stud, cours) => new
                    //    {
                    //        cours.LECT_COURS_ID,
                    //        cours.LECT_COURS_NAME,
                    //    }).ToList();
                    //var temp=con.TBL_STUD_LECT.Find(stud_id);
                    //if (temp != null)
                    //{
                    //    com_com_cours.DataSource = con.TBL_LECT_COURS.
                    //        Where(w => w.LECT_COURS_ID == temp.COURS_ID).Join(con.TBL_LECT_COURS, s => s.TBL_LECT_COURS.LECT_COURS_ID,
                    //        a => a.LECT_COURS_ID, (stud, cours) => new
                    //        {
                    //            cours.LECT_COURS_ID,
                    //            cours.LECT_COURS_NAME,
                    //        }).ToList();


                    //    com_com_cours.DisplayMember = "LECT_COURS_NAME";
                    //    com_com_cours.ValueMember = "LECT_COURS_ID";
                    //}
                //}
            }
            catch (Exception ex)
            {

            }

        }

        private void com_to_cours_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(com_to_cours.SelectedValue!=null)
            {
                try
                {
                    temp_cours_id=Convert.ToInt32(com_to_cours.SelectedValue.ToString());
                    var tbl = con.TBL_LECT_TECH_COURS.Where(w => w.COURS_ID == temp_cours_id && w.STATE == true)
                .Join(con.TBL_LECTUER, l => l.TBL_LECTUER.LECT_ID, tl => tl.LECT_ID,
                (l, tl) => new
                {
                    l.LECT_ID,
                   // l.GROUP_NAME,
                    tl.LECT_NAME,

                }).Distinct();


                    if (tbl != null)
                    {
                        com_to_lect.DataSource = tbl.ToList();
                        com_to_lect.DisplayMember = "LECT_NAME";
                        com_to_lect.ValueMember = "LECT_ID";


    
                    }
                }catch(Exception ex) { }
            }
        }

        private void com_lect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(com_lect.SelectedValue!=null)
            {
                try
                {
                    tech_lect_id = Convert.ToInt32(com_lect.SelectedValue);
                    get_group();
                }catch(Exception ex) { }
            }
        }
    }
}