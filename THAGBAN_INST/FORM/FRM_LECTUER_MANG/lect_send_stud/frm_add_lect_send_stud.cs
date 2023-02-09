﻿using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.PivotGrid.OLAP.AdoWrappers;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.adl;
using THAGBAN_INST.DATA;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.job;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.lsits;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_report;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_send_stud
{
    public partial class frm_add_lect_send_stud : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        int print_id = 0;
        public int emp_id = 0;
        public int id = 0;
        public int part_id = 0;
        public int part_paid = 0;
        public int tech_lect_id = 0;
        public int temp_stud_lect_id = 0;
        public int part_rest;
        public int emp_salary;
        
       
        public int total_amount;
        public int total_paid;
        public int lect_id=0;
        public int temp_lect_id = 0;
        int temp_stud_id;
        int stud_id;

        public DateTime part_date;




        public frm_add_lect_send_stud()
        {
            InitializeComponent();
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        public void get_emp()
        {

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.

            // Bind data to control when loading complete
            com_emp_name.DataSource = dbContext.TBL_EMPLOYEES.Join(dbContext.TBL_JOB.
            Where(w => w.JOB_NAME == "مدرس"), s => s.TBL_JOB.JOB_ID, w => w.JOB_ID
            , (tech, job) => new
            {
                tech.EMP_NAME,
                tech.EMP_ID,
            }).ToList();
            com_emp_name.DisplayMember = "EMP_NAME";
            com_emp_name.ValueMember = "EMP_ID";
            if (part_id != 0)
            {
               //om_stud.SelectedValue = temp_stud_id;
            }




        }

      


        void clear()
        {
            emp_salary =0;
            emp_id = 0;
            txt_emp_salary.Text = "";
           
            txt_part_paid.Text ="";
            txt_part_rest.Text = "";
            part_paid = 0;
            part_rest = 0;
            com_emp_name.Text = "";
            part_id = 0;
            total_paid = 0;
            total_amount = 0;
            txt_part_date.Value = DateTime.Now;
            //txt_part_month.Value = DateTime.Now.Month;
            //txt_emp_year.Text = DateTime.Now.Year.ToString();






        }
        bool is_empty()
        {
            if (com_emp_name.Text != "" && com_stud.Text!="" && txt_part_paid.Text!="" && txt_part_rest.Text!=""&& com_group.Text!=""&& com_lect.Text!="")
            {
                
               


                return false;
            }
            else
                return true;

        }

        void add_part_of_salary()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            adl.method method = new adl.method();
          
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    TBL_SEND_STUD_LECT cl = new TBL_SEND_STUD_LECT();

                    cl.STUD_ID = Convert.ToInt32(com_stud.SelectedValue) ;

                   // cl.TECH_LECT_ID = Convert.ToInt32(com_group.SelectedValue);

                  
                    cl.STUD_LECT_ID = Convert.ToInt32(com_lect.SelectedValue);
                    cl.TECH_LECT_ID=Convert.ToInt32(com_group.SelectedValue);
                    int lec_id = Convert.ToInt32(con.TBL_STUD_LECT.Find(cl.STUD_LECT_ID).LECT_ID);
                    cl.LECT_ID = Convert.ToInt32(lec_id);
                    cl.PAID_UP = Convert.ToInt32(txt_part_paid.Text);
                    cl.REST = Convert.ToInt32(txt_part_rest.Text);
                    cl.INST_ID = THAGBAN_INST.Properties.Settings.Default.inst_id;
                    cl.SEND_STUD_DATE = method.convert_date(txt_part_date.Value);


                    if (part_id != 0)
                    {
                        //add 
                        cl.SEND_STUD_ID = Convert.ToInt32(part_id);
                        print_id=cl.SEND_STUD_ID;
                        con.TBL_SEND_STUD_LECT.AddOrUpdate(cl);
                        con.SaveChanges();

                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();

                        clear();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();

                        //update 
                        con.TBL_SEND_STUD_LECT.AddOrUpdate(cl);
                        con.SaveChanges();
                        print_id = cl.SEND_STUD_ID;
                        notifiction.Show();
                        clear();

                    }
                }
                catch (Exception ex)
                {


                    //dialge.Width = this.Width;
                    //dialge.lbl_mess.Text ="تاكد من ادخال البيانات بالشكل الصحيح ";
                    //dialge.Show();
                    MessageBox.Show(ex.Message + ex.InnerException.ToString());
                }
              
            }
            else
            {
                dialge.Width = this.Width;
                dialge.lbl_mess.Text = "الرجاء ادخال جميع البيانات ";
                dialge.Show();



            }


        }

        void get_lect()
        {
            try
            {

                if (com_stud.SelectedValue != null)
                {
                    stud_id = Convert.ToInt32(com_stud.SelectedValue.ToString());
                    lbl_l_name.Text = con.TBL_STUDENTS.Find(stud_id).STUD_LNAME.ToString();

                  //om_lect.Items.Clear();

                    //var temp1 = con.TBL_STUD_LECT.
                    //      Where(w => w.STUD_ID == stud_id).Join(con.TBL_LECT_TECH_COURS.Where(w => w.STATE == true),
                    //      s => s.TBL_LECT_TECH_COURS.LECT_ID,
                    //      a => a.LECT_ID, (stud, cours) => new
                    //      {
                    //          stud.LECT_STUD_ID,
                    //          cours.TBL_LECTUER.LECT_NAME,

                    //      }).Distinct().ToList();
                    //  var temp = con.TBL_STUD_LECT.Find(stud_id);

                    var temp1 = (from sl in con.TBL_STUD_LECT.Where(w => w.STUD_ID == stud_id)
                                 join
                                tl in con.TBL_LECT_TECH_COURS.Where(w => w.STATE == true) on
                                sl.LECT_TECH_ID equals tl.TECH_LECT_ID
                                 join l in con.TBL_LECTUER on
                                 tl.LECT_ID equals l.LECT_ID
                                 select new
                                 {
                                     sl.LECT_STUD_ID,
                                     sl.TBL_LECTUER.LECT_NAME

                                 }).Distinct().ToList();
                    if (temp1.Count > 0)
                    {
                        com_lect.DataSource = temp1.ToList();
                        com_lect.DisplayMember = "LECT_NAME";
                        com_lect.ValueMember = "LECT_STUD_ID";
                        if (part_id != 0)
                        {
                            com_lect.SelectedValue = temp_stud_lect_id;
                        }
                    }
                    else
                    {
                        com_lect.Items.Clear();
                        com_lect.Text = "";
                        com_lect.DataSource = null;
                        com_lect.SelectedValue = null;
                    }
                }


            }
            catch (Exception ex)
            {

                com_lect.Text = "";
                com_lect.DataSource = null;
                com_lect.SelectedValue = null;
            }
        }
        void get_group()
        {
       
            try
            {
                if (com_lect.Items.Count <= 0)
                {
                    com_group.Items.Clear();
                    com_group.DataSource = null;
                    com_group.SelectedValue = null;
                }
                

                lect_id = Convert.ToInt32(com_lect.SelectedValue);

                var temp = con.TBL_STUD_LECT.Where(w => w.LECT_STUD_ID == lect_id).Join(
                          con.TBL_LECT_TECH_COURS, tl => tl.TBL_LECT_TECH_COURS.TECH_LECT_ID,
                          sl => sl.TECH_LECT_ID, (tl, sl) => new
                          {
                              sl.GROUP_NAME,
                              sl.TECH_LECT_ID,
                            
                          }
                          )
                          .ToList();
                if (temp != null)
                {
                    com_group.DataSource = temp;
                    com_group.DisplayMember = "GROUP_NAME";
                    com_group.ValueMember = "TECH_LECT_ID";

                    if (part_id == 0)
                    {
                       // com_group.SelectedValue = temp_stud_lect_id;
                    }
                }
                else
                {
                    com_group.Items.Clear();
                    com_group.DataSource = null;
                    com_group.Text = "";
                }
            
              
            }catch(Exception ex) {

            }


        }
        public void get_data()
        {


            com_stud.DataSource = con.TBL_STUDENTS.ToList();
            com_stud.DisplayMember = "STUD_NAME";
            com_stud.ValueMember = "STUD_ID";

            if (part_id != 0)
            {
                com_stud.SelectedValue = temp_stud_id;
            }
        }
        private void frm_add_emp_Load(object sender, EventArgs e)
        {


            cheak();

            if (part_id != 0)
            {
                TBL_SEND_STUD_LECT data_form = con.TBL_SEND_STUD_LECT.Find(part_id);
                temp_stud_id =Convert.ToInt32(data_form.STUD_ID);
               // temp_lect_id = Convert.ToInt32(data_form.LECT_ID);
                temp_stud_lect_id = Convert.ToInt32(data_form.STUD_LECT_ID);

                // txt_emp_year.Text = data_form.PART_YEAR.ToString();
                lect_id =(int) data_form.LECT_ID;
                txt_part_date.Value =data_form.SEND_STUD_DATE.Value;
                // txt_part_month.Value = data_form.PART_MONTH ;
                txt_emp_salary.Text = con.TBL_LECTUER.Find(lect_id).LECT_PRICE.ToString();
                txt_part_paid.Text = data_form.PAID_UP.ToString();
                txt_part_rest.Text = data_form.REST.ToString();


                get_data();
                get_lect();
                get_emp();
                get_salary();
                //holiday_type_id = Convert.ToInt32(com_holiday_type.SelectedValue.ToString());
                //stud_id= Convert.ToInt32(com_emp_name.SelectedValue.ToString());
               // label1.Text = "emp=" + emp_id.ToString() + "hold";


            }
            else
            {
                get_emp();
                get_data();
                txt_part_date.Value = DateTime.Now;
                //txt_part_month.Value = DateTime.Now.Month;
                //txt_emp_year.Text = DateTime.Now.Year.ToString();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            clear();
          

        }

        private void com_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
       

       

        

       

    private void btn_save_Click(object sender, EventArgs e)
        {
            add_part_of_salary();

        }

        private void com_job_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void btn_emp_list_Click(object sender, EventArgs e)
        {
            emp_list frm = new emp_list();
            frm.ShowDialog(this);
            emp_id = frm.emp_id;
            com_emp_name.Text = frm.emp_name;
        }

        
void get_salary()
        {
            if (stud_id != 0)
            {
                try
                {
                    if (part_id == 0)
                    {
                        if (com_lect.SelectedValue != null)
                        {
                            int id = Convert.ToInt32(com_lect.SelectedValue);
                            int lec = Convert.ToInt32(con.TBL_STUD_LECT.Find(id).LECT_ID);

                            if (lec != 0)
                            {
                                TBL_LECTUER tem_sal = con.TBL_LECTUER.Where(w => w.LECT_ID == lec).FirstOrDefault();
                                if (tem_sal != null)
                                {
                                    txt_emp_salary.Text = tem_sal.LECT_PRICE.ToString();

                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                  //  MessageBox.Show(ex.Message);
                }
            }

        }
         int Get_piad() {
            int temp=0;
            lect_id=Convert.ToInt32(com_lect.SelectedValue);
            tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
            emp_id = Convert.ToInt32(com_emp_name.SelectedValue);
            stud_id= Convert.ToInt32(com_stud.SelectedValue);
            var a = con.TBL_SEND_STUD_LECT.
                Where(w => w.STUD_LECT_ID == lect_id  && w.STUD_ID == stud_id &&w.SEND_STUD_ID!=part_id).ToList();
              
            if (a != null)
            {
                if (part_id == 0)
                {
                    total_paid = Convert.ToInt32(a.Sum(w => (int?)w.PAID_UP) ?? 0);

                }
                //else
                //{

                //    total_paid = Convert.ToInt32(a.Sum(w => (int?)w.PAID_UP) ?? 0);
                //}
                emp_salary =Convert.ToInt32(txt_emp_salary.Text);

                part_rest= (emp_salary - total_paid);
                if (part_rest == 0)
                {

                    txt_part_rest.Text = "تم تسديد كل الميلغ";
                    btn_save.Enabled = false;


                }
                else
                txt_part_rest.Text = part_rest.ToString();

            }

            return total_paid;

        }
        private void com_emp_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (com_emp_name.SelectedItem != null)
            {
                try
                {
                    emp_id = Convert.ToInt32(com_emp_name.SelectedValue);
                    get_lect();
                  ///  get_salary();
                }catch(Exception ex)
                {
                    
                }
            }
        }

        private void txt_part_month_ValueChanged(object sender, EventArgs e)
        {
            get_salary();
        }

        private void txt_emp_year_TextChange(object sender, EventArgs e)
        {
            get_salary();
        }

        private void txt_part_paid_TextChange(object sender, EventArgs e)
        {

        }

        private void com_lect_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void com_lect_SelectedValueChanged(object sender, EventArgs e)
        {
            if (com_lect.SelectedValue != null)
            {
                try
                {
                    lect_id=Convert.ToInt32(com_lect.SelectedValue);
                    get_group();
                    get_salary();
                    Get_piad();
                }catch(Exception ex)
                {

                }
            }
        }

        private void com_group_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (com_group.SelectedValue!=null)

            {
                try
                {
                    tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
                    com_emp_name.SelectedValue=con.TBL_LECT_TECH_COURS.Find(tech_lect_id).TECHER_ID;
                    get_salary();
                    Get_piad();

                }
                catch(Exception ex) { }
            }
        }

        private void txt_part_paid_TextChanged(object sender, EventArgs e)
        {

            try
            {
                total_amount = Convert.ToInt32(txt_emp_salary.Text) - Get_piad();
                part_paid = Convert.ToInt32(txt_part_paid.Text);
                if (part_paid <= part_rest)
                {
                    txt_part_rest.Text = (total_amount - part_paid).ToString();
                    btn_save.Enabled = true;
                }
                else
                {
                    txt_part_rest.Text = "المبلغ اكبرمن المتبقي";
                    btn_save.Enabled = false;
                }

            }
            catch(Exception ex)
            {

            }
        }

        private void com_stud_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            if (com_stud.SelectedValue != null)
            {


                try
                {
                    if (com_stud.SelectedValue != null)
                    {
                        stud_id = Convert.ToInt32(com_stud.SelectedValue.ToString());
                        lbl_l_name.Text = con.TBL_STUDENTS.Find(stud_id).STUD_LNAME.ToString();

                        get_lect();
                        
                    }


                }
                catch (Exception ex) { }
            }
        }

        void cheak()
        {
            if (checkEdit1.Checked)
            {
                com_emp_name.Enabled = true;
            }
            else
                com_emp_name.Enabled = false;
        }
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            cheak();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            send_lect report = new send_lect();
            add_part_of_salary();
          //  MessageBox.Show(print_id+"");
            int inst_id=Convert.ToInt32(con.TBL_SEND_STUD_LECT.Find(print_id).INST_ID);
           TBL_INST inst= con.TBL_INST.Find(inst_id);
            //report.DataSource= class_send.get_send_stud(10);
            report.DataSource = con.TBL_SEND_STUD_LECT.Find(print_id);

           // report.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.SEND_STUD_ID.Equals(print_id)).ToList();
            //report.lbl_inst_name.Text = inst.INST_NAME;
            //report.lbl_inst_desc.Text = inst.INST_DESC;
            //report.lbl_inst_location.Text = inst.INST_LOCATION;

            report.ShowRibbonPreview();
        }
    }
}