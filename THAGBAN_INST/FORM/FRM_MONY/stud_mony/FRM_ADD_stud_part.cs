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

namespace THAGBAN_INST.FORM.FRM_MONY.stud_mony
{
    public partial class FRM_ADD_stud_part : DevExpress.XtraEditors.XtraForm
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast =new tost();
        dialge dialge = new dialge();
        public int SEND_STUD_ID =0;
        private int stud_id=0;
        private int mark_id;
        private int spec_id;
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
            var data = con.TBL_STUD_SPEC.Where(w => w.STUD_ID == stud_id).Join(con.TBL_SPECIAL, m => m.SPEC_ID,
               co => co.SPEC_ID, (cours, ap) => new
               {
                   cours.SPEC_ID,
                   cours.TBL_SPECIAL.SPEC_NAME,
               }).ToList();
            if (data.Count > 0)
            {
                com_spice.DataSource = data;
                com_spice.DisplayMember = "SPEC_NAME";
                com_spice.ValueMember = "SPEC_ID";
               
            }
            else
            {
                com_spice.Text = "";
                THAGBAN_INST.adl.NotifictionUser notifiction = new adl.NotifictionUser("الطالب غير مسجل في اي كورس ",THAGBAN_INST.Properties.Resources.about_32px);
                notifiction.Show();
            }
        }
        public FRM_ADD_stud_part()
        {
            InitializeComponent();
            get_stud_data();


        }
        void add_griev()
        {
            THAGBAN_INST.adl.method method=new adl.method();
            if (!isempty())
            {
                TBL_SEND_STUD_SPEC obj=new TBL_SEND_STUD_SPEC();
                obj.SPEC_ID = spec_id;
           obj.SEND_STUD_DATE= method.convert_date(txt_date.Value);
                obj.PAID_UP = Convert.ToInt32(txt_price.Text);
                obj.NOTE = txt_note.Text;
                obj.STUD_ID = stud_id;
                obj.REST =Convert.ToInt32(lbl_spec_price.Text)-(Convert.ToInt32(lbl_paid_total.Text)+obj.PAID_UP);

                if (SEND_STUD_ID  == 0)
                {
                    int opration_id = method.add_to_box(inst_id, (double)obj.PAID_UP);
                    obj.OPRATIN_ID = opration_id;
                    con.TBL_SEND_STUD_SPEC.Add(obj);
                    con.SaveChanges();
                    method.show_add_message();
                }
                else
                {
                    obj.OPRATIN_ID = con.TBL_SEND_STUD_SPEC.Find(SEND_STUD_ID).OPRATIN_ID;
                    obj.SEND_STUD_ID = SEND_STUD_ID ;
                    method.update_opration_price((int)obj.OPRATIN_ID, (int)obj.PAID_UP);
                    con.TBL_SEND_STUD_SPEC.AddOrUpdate(obj);
                    con.SaveChanges();
                    method.show_edit_message();
                }
                print_id = obj.SEND_STUD_ID;

               
               

            }
            else
            {
                method.show_empty_message();
            }
        }
        bool isempty()
        {
            if (stud_id != 0 && txt_price.Text != "" && spec_id != 0)
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
            SEND_STUD_ID  = 0;
            txt_price.Text = "";
            com_stud.Text = "";
            com_spice.Text = "";
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
            if (SEND_STUD_ID  != 0)
            {
                TBL_SEND_STUD_SPEC tbl= con.TBL_SEND_STUD_SPEC.Find(SEND_STUD_ID );
                spec_id =Convert.ToInt32(tbl.SPEC_ID);
                stud_id= Convert.ToInt32(tbl.STUD_ID);
                txt_date.Value = (DateTime)tbl.SEND_STUD_DATE;
                txt_price.Text = tbl.PAID_UP.ToString();
                price= tbl.PAID_UP;
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
                get_spec_datils();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        void get_spec_datils()
        {

            lbl_spec_price.Text  = con.TBL_SPECIAL.Find(spec_id).SPEC_PRICE.ToString();
            lbl_paid_total.Text = con.TBL_SEND_STUD_SPEC.Where(w => w.STUD_ID == stud_id && w.SPEC_ID == spec_id)
                .Sum(w => w.PAID_UP).ToString();
            int s = 0;
             s= (Convert.ToInt32(lbl_spec_price.Text) - Convert.ToInt32(lbl_paid_total.Text));
           
            lbl_rest.Text = s.ToString();
        }
        private void com_cours_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                spec_id = Convert.ToInt32(com_spice.SelectedValue.ToString());
                get_spec_datils();
            }
            catch (Exception ex)
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

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}