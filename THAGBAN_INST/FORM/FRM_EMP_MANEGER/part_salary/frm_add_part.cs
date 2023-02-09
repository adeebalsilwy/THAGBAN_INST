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
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.job;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.lsits;

namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.part_salary
{
    public partial class frm_add_part : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int emp_id = 0;
        public int part_id = 0;
        public int part_paid = 0;
        public int part_rest;
        public int emp_salary;
        public int part_month;
        public string emp_name;
        public int part_year;
        public int total_amount;
        public int total_paid;


        public DateTime part_date;




        public frm_add_part()
        {
            InitializeComponent();
            get_emp();
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
            dbContext.TBL_EMPLOYEES.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                com_emp_name.DataSource = dbContext.TBL_EMPLOYEES.Where(w => w.STATE == true).ToList(); 
                com_emp_name.DisplayMember = "EMP_NAME";
                com_emp_name.ValueMember = "EMP_ID";
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            

        }

      


        void clear()
        {
            emp_salary =0;
            emp_id = 0;
            txt_emp_salary.Text = "";
           
            txt_part_paid.Text ="";
            txt_part_rest.Text = "";
            part_month = 0;
            part_paid = 0;
            part_rest = 0;
            part_year = 0;
            com_emp_name.Text = "";
            part_id = 0;
            total_paid = 0;
            total_amount = 0;
            txt_part_date.Value = DateTime.Now;
            txt_part_month.Value = DateTime.Now.Month;
            txt_emp_year.Text = DateTime.Now.Year.ToString();






        }
        bool is_empty()
        {
            if (com_emp_name.Text != "" && txt_part_paid.Text!="" && txt_part_rest.Text!=""&& txt_emp_year.Text!="")
            {
                part_paid = Convert.ToInt32(txt_part_paid.Text);
                part_rest = Convert.ToInt32(txt_part_rest.Text);
                part_year = Convert.ToInt32(txt_emp_year.Text);
                part_month =Convert.ToInt32(txt_part_month.Value);
                emp_salary = Convert.ToInt32(txt_emp_salary.Text);
                string aa = string.Format("{0:dd-MM-yyyy}", txt_part_date.Value);
                part_date= DateTime.ParseExact(aa, "dd-MM-yyyy", null);
               


                return false;
            }
            else
                return true;

        }

        void add_part_of_salary()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    TBL_PART_SALARY cl = new TBL_PART_SALARY();

                    cl.EMP_ID = emp_id;
                    cl.PART_MONTH = part_month;
                    cl.PART_PAID = part_paid;
                    cl.PART_YEAR = part_year;
                    cl.SLAARY_DATE = part_date;
                    cl.PAID_REST = part_rest;

                    if (part_id != 0)
                    {
                        //add 
                        cl.PART_ID = Convert.ToInt32(part_id);
                        con.TBL_PART_SALARY.AddOrUpdate(cl);
                        con.SaveChanges();

                        toast.lbl_mess.Text = "تم التعديل بنجاح";
                        toast.Show();
                        clear();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        con.TBL_PART_SALARY.AddOrUpdate(cl);
                        con.SaveChanges();
                        toast.lbl_mess.Text = "تم الاضافه ينجاح  بنجاح";
                        toast.Show();
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

       
        private void frm_add_emp_Load(object sender, EventArgs e)
        {

           get_emp();
           

            if (part_id != 0)
            {
                var data_form = con.TBL_PART_SALARY.Find(part_id);
                emp_id = data_form.EMP_ID;
                var employee = con.TBL_EMPLOYEES.Find(data_form.EMP_ID);
                com_emp_name.Text = employee.EMP_NAME.ToString();
                txt_emp_year.Text = data_form.PART_YEAR.ToString();
                txt_part_date.Value = data_form.SLAARY_DATE;
                txt_part_month.Value = data_form.PART_MONTH ;
                txt_part_paid.Text = data_form.PART_PAID.ToString();
                txt_part_rest.Text = data_form.PAID_REST.ToString();
                
                
               
                get_salary();
                //holiday_type_id = Convert.ToInt32(com_holiday_type.SelectedValue.ToString());
                //stud_id= Convert.ToInt32(com_emp_name.SelectedValue.ToString());
                label1.Text = "emp=" + emp_id.ToString() + "hold";


            }
            else
            {
                txt_part_date.Value = DateTime.Now;
                txt_part_month.Value = DateTime.Now.Month;
                txt_emp_year.Text = DateTime.Now.Year.ToString();
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
            if (emp_id != 0)
            {
                try
                {
                   var d =con.TBL_EMPLOYEES.Find(emp_id);
                    emp_salary = Convert.ToInt32(d.EMP_SALARY);
                    txt_emp_salary.Text = emp_salary.ToString();

                    //  string salary =con.TBL_EMPLOYEES.Where(w=>w.EMP_ID==stud_id).Select(w=>w.EMP_SALARY).ToString();
                    part_month = Convert.ToInt32(txt_part_month.Value.ToString());
                    part_year = Convert.ToInt32(txt_emp_year.Text);
                    var total =con.TBL_PART_SALARY.Where(w => w.EMP_ID == emp_id && w.PART_MONTH == part_month && w.PART_YEAR == part_year).Sum(w =>(int?)w.PART_PAID)??0;
                    //tech_spical = Convert.ToInt32(salary);
                    label1.Text = total.ToString();
                    total_paid = Convert.ToInt32(total);
                    part_rest = emp_salary - total_paid;
                    
                    txt_part_rest.Text =part_rest.ToString();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void com_emp_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (com_emp_name.SelectedItem != null)
            {
                emp_id = Convert.ToInt32(com_emp_name.SelectedValue);
                get_salary();
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
            if (txt_part_paid.Text != "")
            {
                txt_part_rest.Text = (part_rest - Convert.ToInt32(txt_part_paid.Text)).ToString();
            }
        }
    }
}