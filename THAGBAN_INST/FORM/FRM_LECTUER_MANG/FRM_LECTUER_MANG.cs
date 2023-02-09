using DevExpress.PivotGrid.OLAP.AdoWrappers;
using DevExpress.XtraBars;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using THAGBAN_INST.DATA;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.attends;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.holidays;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.job;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.part_salary;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.users;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.cours;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_mark;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_salary;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_send_stud;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_stud;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_students;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lecteurs;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.matrial;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.reports;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.students;
using THAGBAN_INST.reports.emp_reports;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG
{
    public partial class FRM_LECTUER_MANG : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        bool PageStageClose;
        XtraTabPage XtraPage;
        db_max_instEntities con = new db_max_instEntities();
        private int lect_id;
        private int stud_lect_id;
        private object temp_tech_lect_id;

        public FRM_LECTUER_MANG()
        {
            InitializeComponent();
            get_info();





        }



        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            
        }

     
        private void SelectPage(DevExpress.XtraEditors.XtraUserControl control, string PageTitle)
        {
            try
            {
                foreach (XtraTabPage pageindex in xtraTabControl1.TabPages)
                {
                    if (pageindex.Text == PageTitle)
                    {
                        PageStageClose = false;
                        XtraPage = pageindex;
                        break;

                    }
                    else
                    {
                        PageStageClose = true;
                    }
                }
                if (PageStageClose == true)
                {
                    control.Dock = DockStyle.Fill;
                    xtraTabControl1.TabPages.Add();
                    var CurrentPage = xtraTabControl1.TabPages.Last();
                    xtraTabControl1.SelectedTabPage = CurrentPage;
                    CurrentPage.Text = PageTitle;
                    CurrentPage.Controls.Add(control);
                }
                else
                {

                    xtraTabControl1.SelectedTabPage = XtraPage;
                }
            }
            catch { }

        }
        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            frm_mang_emp frm = new frm_mang_emp();
            //xtrahomepage.ControlAdded(frm_deot);
            SelectPage(frm, "الموظفين");
        }

        private void btn_groups_Click(object sender, EventArgs e)
        {
            frm_mange_dept frm_deot =new frm_mange_dept();
            //xtrahomepage.ControlAdded(frm_deot);
            SelectPage(frm_deot, "الاقسام");
            
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            // close tab bage 
            if (xtraTabControl1.SelectedTabPage != xtraTabControl1.TabPages[0])
            {
                xtraTabControl1.TabPages.Remove(xtraTabControl1.SelectedTabPage);

            }
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {

            frm_mang_jobs frm_deot = new frm_mang_jobs();
            //xtrahomepage.ControlAdded(frm_deot);
            SelectPage(frm_deot, "الوظائف");
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            frm_mange_lect_cours frm = new frm_mange_lect_cours();
            SelectPage(frm, "الكورسات");
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            lectuer_user frm = new lectuer_user();
            SelectPage(frm, "الدورات");
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            frm_mang_attends frm = new frm_mang_attends();
            SelectPage(frm, " سجل الدوام  ");
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            frm_mang_matrial frm = new frm_mang_matrial();
            SelectPage(frm, "مواد الدورات");
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            frm_mang_part frm = new frm_mang_part();
            SelectPage(frm, "الاقساط");

        }

        private void btn_anylsis_Click(object sender, EventArgs e)
        {
            analsiys_lect_main frm =new analsiys_lect_main();
            SelectPage(frm, "التقارير ");
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            frm_mang_stud frm = new frm_mang_stud();
            SelectPage(frm, "الطلاب");

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            frm_mang_lect_tech frm = new frm_mang_lect_tech();
            SelectPage(frm, "الدورات المفتوحه");
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            frm_mang_lect_stud frm = new frm_mang_lect_stud();
            SelectPage(frm, "دورات الطلاب");
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            frm_mang_lect_marks frm=new frm_mang_lect_marks();
            SelectPage(frm, "الدرجات");

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            frm_mang_lect_sal frm = new frm_mang_lect_sal();
            SelectPage(frm, "اقساط المدرسين");

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            frm_mang_lect_send_sal frm = new frm_mang_lect_send_sal();
            SelectPage(frm, "سندات الطلاب");
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
           
        }

        private void hom_page_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            frm_setting frm = new frm_setting();

            //  frm_main_send frm = new frm_main_send();
            frm.ShowDialog();
        }
        private void LoadHomePage()
        {


            try
            {
                home_page page = new home_page();
                page.Dock = DockStyle.Fill;
                xtraTabControl1.Controls.Clear();
                xtraTabControl1.Controls.Add(page);
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages.First();
            }
            catch (Exception ex) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.ToString();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        void get_info()
        {
            adl.method meth = new adl.method();
            int inst_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
            label1.Text = con.TBL_INST.Find(inst_id).INST_NAME;
            meth.data = con.TBL_INST.Find(inst_id).INST_LOGO;
            if (meth.data != null)
                pictureBox1.Image = Image.FromStream(meth.convert_image());

        }
    }


}
