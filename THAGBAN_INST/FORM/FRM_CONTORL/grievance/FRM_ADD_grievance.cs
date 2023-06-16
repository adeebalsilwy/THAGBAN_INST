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
using THAGBAN_INST.FORM.FRM_EMP_MANEGER;
using THAGBAN_INST.FORM;
using System.Data.Entity.Migrations;
using THAGBAN_INST.DATA;
using THAGBAN_INST.reports.control_report;
using DevExpress.XtraReports.UI;

namespace THAGBAN_INST.FORM.FRM_CONTORL
{
    public partial class FRM_ADD_grievance : DevExpress.XtraEditors.XtraForm
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast =new tost();
        dialge dialge = new dialge();
        public int griev_id=0;
        private int stud_id=0;
        private int mark_id;
        private int cours_id;
        private int print_id=0;
        private int inst_id=0;
        private double? price;

        void get_stud_data()
        {
            com_stud.DataSource = con.TBL_STUD_SPEC.Join(con.TBL_STUDENTS.Where(w=>w.STUD_STATE==true), sp => sp.STUD_ID,
                st => st.STUD_ID, (stud, ap) => new
                {
                    stud.TBL_STUDENTS.STUD_NAME,
                    stud.TBL_STUDENTS.STUD_ID
                }).ToList();
            com_stud.DisplayMember = "STUD_NAME";
            com_stud.ValueMember = "STUD_ID";

           
        }
        void get_cours()
        {
            var data = con.TBL_MARKS.Where(w => w.STUD_ID == stud_id).Join(con.TBL_COURS, m => m.COURS_ID,
               co => co.COURS_ID, (cours, ap) => new
               {
                   cours.COURS_ID,
                   cours.TBL_COURS.COURS_NAME,
               }).ToList();
            if (data.Count > 0)
            {
                com_cours.DataSource = data;
                com_cours.DisplayMember = "COURS_NAME";
                com_cours.ValueMember = "COURS_ID";
            }
            else
            {
                com_cours.Text = "";
                THAGBAN_INST.adl.NotifictionUser notifiction = new adl.NotifictionUser("لا توجد مواد مسجله للطالب ",THAGBAN_INST.Properties.Resources.about_32px);
                notifiction.Show();
            }
        }
        public FRM_ADD_grievance()
        {
            InitializeComponent();
            get_stud_data();


        }
        void add_griev()
        {
            THAGBAN_INST.adl.method method=new adl.method();
            if (!isempty())
            {
                TBL_GREIVANCES obj=new TBL_GREIVANCES();
                obj.MARK_ID= Convert.ToInt32(con.TBL_MARKS.Where(w => w.COURS_ID == cours_id && w.STUD_ID == stud_id).FirstOrDefault().MARK_ID.ToString());
           obj.GREIVANCE_DATE= method.convert_date(txt_date.Value);
                obj.PRICE = Convert.ToDouble(txt_price.Text);
                obj.NOTE = txt_note.Text;
                if (griev_id == 0)
                {
                    con.TBL_GREIVANCES.Add(obj);
                    con.SaveChanges();
                    method.show_add_message();
                }
                else
                {
                    obj.GREIVANCE_ID= griev_id;
                    method.sub_to_box(inst_id, (double)price);
                    con.TBL_GREIVANCES.AddOrUpdate(obj);
                    con.SaveChanges();
                    method.show_edit_message();
                }
                print_id = obj.GREIVANCE_ID;

                method.add_to_box(inst_id, (double)obj.PRICE);
            }
            else
            {
                method.show_empty_message();
            }
        }
        bool isempty()
        {
            if (stud_id != 0 && txt_price.Text != "" && cours_id != 0)
                return false;
            else
                return true;
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            
        }
        void clear()
        {
            griev_id = 0;
            txt_price.Text = "";
            com_stud.Text = "";
            com_cours.Text = "";
            txt_note.Text = "";

          
        }
       

        private void ch_open_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
        }

        private void ch_close_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }
       

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void FRM_ADD_DEP_Load(object sender, EventArgs e)
        {
            if (griev_id != 0)
            {
                TBL_GREIVANCES tbl= con.TBL_GREIVANCES.Find(griev_id);
                cours_id =Convert.ToInt32(tbl.TBL_MARKS.COURS_ID);
                stud_id= Convert.ToInt32(tbl.TBL_MARKS.STUD_ID);
                mark_id= Convert.ToInt32(tbl.MARK_ID);
                txt_date.Value = (DateTime)tbl.GREIVANCE_DATE;
                txt_price.Text = tbl.PRICE.ToString();
                price= tbl.PRICE;
                txt_note.Text=tbl.NOTE.ToString();

            }
            inst_id = con.TBL_INST.FirstOrDefault().INST_ID;
        }

        private void txt_cours_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            add_griev();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void com_stud_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                stud_id= Convert.ToInt32(com_stud.SelectedValue.ToString());
                lbl_Name.Text = con.TBL_STUDENTS.Find(stud_id).STUD_LNAME.ToString();
                get_cours();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void com_cours_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cours_id = Convert.ToInt32(com_cours.SelectedValue.ToString());
                lbl_mark.Text = con.TBL_MARKS.Where(w => w.COURS_ID == cours_id && w.STUD_ID == stud_id).FirstOrDefault().MARK_COURS.ToString();

            }catch (Exception ex)
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            report_gerive report = new report_gerive();
            add_griev();
            report.DataSource = con.TBL_GREIVANCES.Find(print_id);
            report.ShowRibbonPreview();


        }
    }
}