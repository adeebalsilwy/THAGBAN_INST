using DevExpress.XtraBars;
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
using THAGBAN_INST.FORM.FRM_CONTORL;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.attends;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.holidays;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.job;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.part_salary;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.users;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_salary;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_send_stud;
using THAGBAN_INST.FORM.FRM_MANG_STUD.cours_send_stud;
using THAGBAN_INST.FORM.FRM_MONY;
using THAGBAN_INST.FORM.FRM_MONY.services;
using THAGBAN_INST.FORM.FRM_MONY.stud_mony;
using THAGBAN_INST.FORM.FRM_SYSTEM;
using THAGBAN_INST.reports.emp_reports;

namespace THAGBAN_INST.FORM
{
    public partial class FRM_MAIN_MONY : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        bool PageStageClose;
        XtraTabPage XtraPage;
        public int imp_id = 0;
        db_max_instEntities con = new db_max_instEntities();
        public FRM_MAIN_MONY()
        {
            InitializeComponent();
        }

        private void LoadHomePage()
        {


            try
            {
                home_page page = new home_page();
                page.Dock = DockStyle.Fill;
                xtraTabControl1.Controls.Add(page);
                xtraTabControl1.Controls.Clear();
                xtraTabControl1.TabPages.Clear();

                PageStageClose = true;
                // xtraTabControl1.TabPages.Add(xtraTabControl1.TabPages.First());
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages.First();
                xtraTabControl1.SelectedTabPage.Text = "الرئيسيه";





            }
            catch (Exception ex) { }
        }

        private bool check_user()
        {
            adl.method method = new adl.method();

            if (imp_id != 0)
            {
                TBL_EMPLOYEES tbl = con.TBL_EMPLOYEES.Find(imp_id);
                if (tbl.TBL_JOB.JOB_NAME == "مدير")
                    return true;
                else
                {
                    method.show_message_note("ليس لديك صلاحيه الوصول الى هذه الواجهه");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            if (imp_id != 0)
                labl_user_name.Text = con.TBL_EMPLOYEES.Find(imp_id).EMP_NAME.ToString();

            LoadHomePage();
            xtraTabControl1.Controls.Clear();
            //xtraTabControl1.TabPages.Clear();
            home_page frm = new home_page();
            SelectPage(frm, "الرئيسيه");
            PageStageClose = true;
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
            frm_mang_services frm = new frm_mang_services();
            //xtrahomepage.ControlAdded(frm_deot);
            SelectPage(frm, "الخدمات ");
        }

        private void btn_groups_Click(object sender, EventArgs e)
        {
            //frm_mange_dept frm_deot =new frm_mange_dept();
            ////xtrahomepage.ControlAdded(frm_deot);
            //SelectPage(frm_deot, "الاقسام");
            
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

            frm_mang_part frm_deot = new frm_mang_part();
            //xtrahomepage.ControlAdded(frm_deot);
            SelectPage(frm_deot, "حسابات الموظفين ");
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            frm_mang_services_type frm = new frm_mang_services_type();
            SelectPage(frm, "انواع الخدمات ");
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            frm_mang_attends frm = new frm_mang_attends();
            SelectPage(frm, " سجل الدوام  ");
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            frm_mang_users frm = new frm_mang_users();
            SelectPage(frm, "المستخدمين ");
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            //frm_mang_part frm = new frm_mang_part();
            //SelectPage(frm, "الاقساط");

        }

        private void btn_anylsis_Click(object sender, EventArgs e)
        {
            analys_mony_admin frm =new analys_mony_admin();
            SelectPage(frm, "التقارير ");
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            frm_mang_lect_sal frm = new frm_mang_lect_sal();
            SelectPage(frm, "حسابات مدرسين الدورات ");
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            frm_mang_lect_send_sal frm = new frm_mang_lect_send_sal();
            SelectPage(frm, "حسابات طلاب الدورات ");
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            frm_mange_grievance frm = new frm_mange_grievance();
            SelectPage(frm, "حسابات  التظلمات ");

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            frm_mang_cours_send_send_stud frm = new frm_mang_cours_send_send_stud();
            SelectPage(frm, "حسابات  الطلاب ");
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutBox frm = new AboutBox();
            frm.ShowDialog();
        }
    }


}
