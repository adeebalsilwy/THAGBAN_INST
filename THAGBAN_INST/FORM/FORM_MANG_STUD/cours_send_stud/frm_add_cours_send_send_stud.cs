using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using THAGBAN_INST.adl;
using THAGBAN_INST.DATA;
using THAGBAN_INST.DATA.OP_DB;
using THAGBAN_INST.FORM.FORM_MANG_STUD.reports;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_report;

namespace THAGBAN_INST.FORM.FRM_MANG_STUD.cours_send_stud
{
    public partial class frm_add_cours_send_send_stud : DevExpress.XtraEditors.XtraForm
    {
        SEND_STUD_HEPLER sEND_STUD_HEPLER = new SEND_STUD_HEPLER();
        db_max_instEntities con = new db_max_instEntities();
        TBL_INST inst;
        tost toast = new tost();
        dialge dialge = new dialge();
        int print_id = 0;
        public int emp_id = 0;
        public int id = 0;
        public int part_id = 0;
        public int part_paid = 0;
        public int part_rest;
        public int spical_price;


        public int total_amount;
        public int total_paid;
        public int spical_id = 0;
        public int temp_spic_id = 0;
        int temp_stud_id;
        int stud_id;

        public DateTime part_date;




        public frm_add_cours_send_send_stud()
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


        void clear()
        {
            spical_price = 0;
            emp_id = 0;
            txt_spic_price.Text = string.Empty;

            txt_part_paid.Text = string.Empty;
            txt_part_rest.Text = string.Empty;
            part_paid = 0;
            part_rest = 0;
            part_id = 0;
            total_paid = 0;
            total_amount = 0;
            txt_part_date.Value = DateTime.Now;
            //txt_part_month.Value = DateTime.Now.Month;
            //txt_emp_year.Text = DateTime.Now.Year.ToString();






        }
        bool is_empty()
        {
            if (com_stud.Text != string.Empty && txt_part_paid.Text != string.Empty && txt_part_rest.Text != string.Empty && com_SPICAEL.Text != string.Empty)
            {




                return false;
            }
            else
                return true;

        }

        private void Add_part_of_salary()
        {

            tost toast = new tost();
            dialge dialge1 = new dialge();
            adl.method method1 = new adl.method();
            db_max_instEntities con1 = new db_max_instEntities();


            if (is_empty() != true)
                //cheak add or edit 
                try
                {
                    TBL_SEND_STUD__COURS cl = new TBL_SEND_STUD__COURS();

                    cl.STUD_ID = Convert.ToInt32(com_stud.SelectedValue.ToString());


                    cl.STUD_SPEC_ID = Convert.ToInt32(com_SPICAEL.SelectedValue.ToString());
                    cl.PAID_UP = Convert.ToInt32(txt_part_paid.Text);
                    cl.REST = Convert.ToInt32(txt_part_rest.Text);

                    cl.SEND_STUD_DATE = method1.convert_date(txt_part_date.Value);
                    // add opration
                    int temp_ins = THAGBAN_INST.Properties.Settings.Default.inst_id;
                    inst = con.TBL_INST.Find(temp_ins);
                    TBL_OPRATION opration = new TBL_OPRATION();
                    opration.PORATION_AMOUNT = Convert.ToInt32(cl.PAID_UP);
                    opration.PORATION_DATE = cl.SEND_STUD_DATE;
                    opration.OPRATION_TYPE = "ايداع";
                    opration.INST_ID = Convert.ToInt32(temp_ins);

                    // int temp_ins = 1;
                    if (checkEdit1.Checked==false)
                    {
                        long total = Convert.ToInt64(inst.INST_TOTAL);
                        total = Convert.ToInt64((total + Convert.ToInt32(opration.PORATION_AMOUNT)));
                        inst.INST_TOTAL = total.ToString();
                        cl.SEND_STATE_BANK = false;
                        inst.INST_ID = temp_ins;
                        con1.TBL_INST.AddOrUpdate(inst);
                        con1.SaveChanges();
                    }
                    else
                    {
                        cl.SEND_STATE_BANK = true;
                        long total = Convert.ToInt64(inst.INST_TOTAL);
                        total = Convert.ToInt64((total +0));
                        inst.INST_TOTAL = total.ToString();
                        inst.INST_ID = temp_ins;
                        con1.TBL_INST.AddOrUpdate(inst);
                        con1.SaveChanges();
                    }

                    if (part_id != 0)
                    {
                        //add 
                        opration.OPRATION_ID = Convert.ToInt32(cl.OPRATIN_ID);
                        con1.TBL_OPRATION.AddOrUpdate(opration);
                        cl.SEND_STUD_ID = Convert.ToInt32(part_id);
                        print_id = cl.SEND_STUD_ID;
                        con1.TBL_SEND_STUD__COURS.AddOrUpdate(cl);
                        con1.SaveChanges();

                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();

                        clear();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        con1.TBL_OPRATION.AddOrUpdate(opration);
                        con1.SaveChanges();
                        cl.OPRATIN_ID = opration.OPRATION_ID;
                        con1.TBL_SEND_STUD__COURS.AddOrUpdate(cl);
                        con1.SaveChanges();
                        print_id = cl.SEND_STUD_ID;
                        notifiction.Show();
                        clear();

                    }
                    // MessageBox.Show(inst.INST_TOTAL);
                }
                catch (Exception ex)
                {


                   
                    MessageBox.Show(ex.Message);
                }
            else
            {
                dialge1.Width = this.Width;
                dialge1.lbl_mess.Text = "الرجاء ادخال جميع البيانات ";
                dialge1.Show();



            }

        }

       
        public void get_data()
        {



           
                // stud_id = Convert.ToInt16(com_stud.SelectedValue.ToString());
                com_stud.DataSource = (from sp in con.TBL_STUD_SPEC
                                       join st in con.TBL_STUDENTS.Where(w => w.STUD_STATE == true)
                     on sp.STUD_ID equals st.STUD_ID
                                       select new

                                       {
                                           sp.STUD_ID,
                                           st.STUD_NAME,


                                       }
                    ).ToList();
                com_stud.DisplayMember = "STUD_NAME";
                com_stud.ValueMember = "STUD_ID";
            if (part_id != 0)
            {
                com_stud.SelectedValue = temp_stud_id;
            }

        }
        void get_spical()
        {
            try
            {


                com_SPICAEL.DataSource = (from sp in con.TBL_SPECIAL
                                          join stsp in con.TBL_STUD_SPEC.Where(w => w.STUD_ID == stud_id)
                                          on sp.SPEC_ID equals stsp.SPEC_ID
                                          select new
                                          {
                                              sp.SPEC_NAME,
                                              stsp.STUD_SPEC_ID,
                                          }).ToList();

                com_SPICAEL.DisplayMember = "SPEC_NAME";
                com_SPICAEL.ValueMember = "STUD_SPEC_ID";
                if (part_id != 0)
                {
                    com_SPICAEL.SelectedValue = temp_spic_id;
                }
            }

            catch
            {

            }
        }
        private void frm_add_emp_Load(object sender, EventArgs e)
        {


            cheak();

            if (part_id != 0)
            {
                TBL_SEND_STUD__COURS data_form = con.TBL_SEND_STUD__COURS.Find(part_id);
                temp_stud_id = Convert.ToInt32(data_form.STUD_ID);
                // temp_spic_id = Convert.ToInt32(data_form.LECT_ID);

                // txt_emp_year.Text = data_form.PART_YEAR.ToString();
                temp_spic_id = (int)data_form.STUD_SPEC_ID;
                txt_part_date.Value = data_form.SEND_STUD_DATE.Value;
                // txt_part_month.Value = data_form.PART_MONTH ;
                txt_spic_price.Text = con.TBL_STUD_SPEC.Find(temp_spic_id).TBL_SPECIAL.SPEC_PRICE.ToString();
                txt_part_paid.Text = data_form.PAID_UP.ToString();
                txt_part_rest.Text = data_form.REST.ToString();
                int temo = Convert.ToInt32(data_form.OPRATIN_ID);
                if (data_form.SEND_STATE_BANK==true)
                {
                    checkEdit1.Checked = true;
                }
                else
                {
                    checkEdit1.Checked=false;
                }
                get_inst_data(temo);

                get_data();
                //  get_lect();
                get_salary();
                //holiday_type_id = Convert.ToInt32(com_holiday_type.SelectedValue.ToString());
                //stud_id= Convert.ToInt32(com_emp_name.SelectedValue.ToString());
                // label1.Text = "emp=" + emp_id.ToString() + "hold";


            }
            else
            {
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


        void get_inst_data(int opri_id)
        {
            int temp_oprid = opri_id;
            TBL_OPRATION opra = con.TBL_OPRATION.Find(temp_oprid);
            inst = con.TBL_INST.Find(opra.INST_ID);
            long total = Convert.ToInt64(inst.INST_TOTAL);
            total = Convert.ToInt64(total - opra.PORATION_AMOUNT);
            inst.INST_TOTAL = total.ToString();
            //MessageBox.Show(inst.INST_TOTAL);
            inst.INST_ID = opra.INST_ID;

            /// add

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            tost toast1 = new tost();
            dialge dialge1 = new dialge();
            adl.method method1 = new adl.method();
            db_max_instEntities con1 = new db_max_instEntities();


            if (is_empty() != true)
            {
                Add_part_of_salary();
            }
                //cheak add or edit 
               

        }

        private void com_job_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btn_emp_list_Click(object sender, EventArgs e)
        {
            //emp_list frm = new emp_list();
            //frm.ShowDialog(this);
            //emp_id = frm.emp_id;
        }


        void get_salary()
        {
            if (stud_id != 0)
            {
                try
                {
                    if (part_id == 0)
                    {
                        if (com_SPICAEL.SelectedValue != null)
                        {
                            int id = Convert.ToInt32(com_SPICAEL.SelectedValue);
                            int spic = Convert.ToInt32(con.TBL_STUD_SPEC.Find(id).SPEC_ID);

                            txt_spic_price.Text = con.TBL_SPECIAL.Find(spic).SPEC_PRICE.ToString();


                        }
                    }
                }
                catch (Exception ex)
                {
                    //  MessageBox.Show(ex.Message);
                }
            }

        }
        int Get_piad()
        {
            int temp = 0;
            spical_id = Convert.ToInt32(com_SPICAEL.SelectedValue);
            stud_id = Convert.ToInt32(com_stud.SelectedValue);
            var a = con.TBL_SEND_STUD__COURS.
                Where(w => w.STUD_SPEC_ID == spical_id && w.STUD_ID == stud_id && w.SEND_STUD_ID != part_id).ToList();

            if (a != null)
            {
                if (part_id == 0)
                {
                    total_paid = Convert.ToInt32(a.Sum(w => w.PAID_UP) ?? 0);

                }

                spical_price = Convert.ToInt32(txt_spic_price.Text);

                part_rest = (spical_price - total_paid);
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
            if (com_SPICAEL.SelectedValue != null)
            {
                try
                {
                    spical_id = Convert.ToInt32(com_SPICAEL.SelectedValue);
                    get_salary();
                    Get_piad();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void com_group_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (com_group.SelectedValue!=null)

            //{
            //    try
            //    {
            //        tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
            //        com_emp_name.SelectedValue=db.TBL_LECT_TECH_COURS.Find(tech_lect_id).TECHER_ID;
            //        get_salary();
            //        Get_piad();

            //    }
            //    catch(Exception ex) { }
            //}
        }

        private void txt_part_paid_TextChanged(object sender, EventArgs e)
        {

            try
            {
                total_amount = Convert.ToInt32(txt_spic_price.Text) - Get_piad();
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
            catch (Exception ex)
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

                        get_spical();


                    }


                }
                catch (Exception ex) { }
            }
        }

        void cheak()
        {
            if (checkEdit1.Checked)
            {
                //  com_emp_name.Enabled = true;
            }
            else
            { }
            //  com_emp_name.Enabled = false;
        }
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            cheak();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            report_send_stud_cours report = new report_send_stud_cours();
           


            if (is_empty() != true)
            {
                Add_part_of_salary();
            }
                //cheak add or edit 
               
           
            //  MessageBox.Show(print_id+"");
            int inst_id = Convert.ToInt32(con.TBL_SEND_STUD__COURS.Find(print_id).TBL_OPRATION.INST_ID);
            TBL_INST inst = con.TBL_INST.Find(inst_id);
            //report.DataSource= class_send.get_send_stud(10);
            report.DataSource = con.TBL_SEND_STUD__COURS.Find(print_id);

            
            report.ShowRibbonPreview();
        }

        private void com_SPICAEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                spical_id = Convert.ToInt32(com_SPICAEL.SelectedValue);
                get_salary();

            }
            catch (Exception ex) { }
        }

        private void txt_spic_price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}