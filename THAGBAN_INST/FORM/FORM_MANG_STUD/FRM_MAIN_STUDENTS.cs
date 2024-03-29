﻿using DevExpress.XtraBars;
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
using THAGBAN_INST.FORM.FRM_LECTUER_MANG;
using THAGBAN_INST.FORM.FRM_MANG_STUD;
using THAGBAN_INST.FORM.FRM_MANG_STUD.cours_send_stud;
using THAGBAN_INST.FORM.FRM_MANG_STUD.level;
using THAGBAN_INST.FORM.FRM_MANG_STUD.marks;
using THAGBAN_INST.FORM.FRM_MANG_STUD.matrila;
using THAGBAN_INST.FORM.FRM_MANG_STUD.stud_foloder;
using THAGBAN_INST.FORM.FRM_MANG_STUD.students;
using THAGBAN_INST.FORM.FRM_MANG_STUD.terms;
using THAGBAN_INST.FORM.FRM_SYSTEM;
using THAGBAN_INST.reports.emp_reports;

namespace THAGBAN_INST.FORM
{
    public partial class FRM_MAIN_STUDENTS : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        bool PageStageClose;
        XtraTabPage XtraPage;
        public int imp_id = 0;
        db_max_instEntities con = new db_max_instEntities();
        public FRM_MAIN_STUDENTS()
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

            frm_mang_jobs frm_deot = new frm_mang_jobs();
            //xtrahomepage.ControlAdded(frm_deot);
            SelectPage(frm_deot, "الوظائف");
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            frm_mang_holiday_type frm = new frm_mang_holiday_type();
            SelectPage(frm, "انواع الاجازات ");
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            //frm_mang_holiday frm = new frm_mang_holiday();
            //SelectPage(frm, " الاجازات ");
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
            frm_mang_part frm = new frm_mang_part();
            SelectPage(frm, "الاقساط");

        }

        private void btn_anylsis_Click(object sender, EventArgs e)
        {
            frm_mang_reptort_emp frm =new frm_mang_reptort_emp();
            SelectPage(frm, "التقارير ");
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
          
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            frm_mang_spical frm = new frm_mang_spical();
            SelectPage(frm, "التخصصات");
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
           
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {

            frm_mang_folo_stud frm = new frm_mang_folo_stud();
            SelectPage(frm, "ملفات الطلاب");
        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {

            frm_mang_terms frm = new frm_mang_terms();
            SelectPage(frm, "الاترام");
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            frm_mange_level frm = new frm_mange_level();
            SelectPage(frm, "المستويات  ");
        }

        private void accordionControlElement22_Click(object sender, EventArgs e)
        {
            frm_mang_matril frm = new frm_mang_matril();
            SelectPage(frm, "مواد التخصصات ");
        }

        private void accordionControlElement21_Click(object sender, EventArgs e)
        {
            frm_mange_cours frm = new frm_mange_cours();
            SelectPage(frm, "المواد ");
        }

        private void accordionControlElement23_Click(object sender, EventArgs e)
        {
            frm_mang_stud frm = new frm_mang_stud();
            //xtrahomepage.ControlAdded(frm_deot);
            SelectPage(frm, "الطلاب");
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            frm_mang_marks frm=new frm_mang_marks();
            SelectPage(frm, "الدرجات");
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            frm_mang_cours_send_send_stud frm = new frm_mang_cours_send_send_stud();
            SelectPage(frm, "سندات الطلاب");

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            AboutBox frm = new AboutBox();
            frm.ShowDialog();
        }
    }


}
