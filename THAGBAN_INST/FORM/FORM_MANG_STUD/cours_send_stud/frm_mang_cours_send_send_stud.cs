﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.employees;
using THAGBAN_INST.DATA;
using THAGBAN_INST.reports.emp_reports;
using DevExpress.XtraReports.UI;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_report;
using THAGBAN_INST.FORM.FORM_MANG_STUD.reports;

namespace THAGBAN_INST.FORM.FRM_MANG_STUD.cours_send_stud
{
    public partial class frm_mang_cours_send_send_stud : DevExpress.XtraEditors.XtraUserControl
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


        public frm_mang_cours_send_send_stud()
        {
            InitializeComponent();


            get_data();


           
        }
        void get_data()
        { // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            THAGBAN_INST.DATA.db_max_instEntities dbContext = new THAGBAN_INST.DATA.db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_SEND_STUD__COURS.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TBL_SEND_STUD__COURS.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_sel();
        }
        void get_sel()
        {
            if (gridView2.SelectedRowsCount > 0)
            {
                try
                {
                    part_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("SEND_STUD_ID").ToString());
                   
                }catch (Exception ex)
                {

                }
            }
        }

        private void btn_edite_Click(object sender, EventArgs e)
        {
            frm_add_cours_send_send_stud frm= new   frm_add_cours_send_send_stud();
            get_sel();
            frm.part_id = part_id;
            frm.btn_save.Text = "تعديل";
            frm.ShowDialog();
            get_data();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            frm_add_cours_send_send_stud frm = new frm_add_cours_send_send_stud();
            frm.part_id = 0;
            frm.ShowDialog();
            get_data();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            get_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
        }
        void delete()
        {
            if (part_id != 0)
            {
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {

                    try
                    {
                        TBL_SEND_STUD__COURS del_cle = con.TBL_SEND_STUD__COURS.Find(part_id);
                        // del_doc.DOC_ID = holiday_type_id;

                        con.TBL_SEND_STUD__COURS.Remove(del_cle);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.DeleteNotificationText, THAGBAN_INST.Properties.Resources.Delete_32px);
                        notifiction.Show();
                    }catch(Exception ex)
                    {

                    }

                }
                get_data();
            }
        }

        private void gridView2_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_sel();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            report_send_stud_cours repors = new report_send_stud_cours();
            List<TBL_SEND_STUD__COURS> list = new List<TBL_SEND_STUD__COURS>();

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                list.Add(gridView2.GetRow(i) as TBL_SEND_STUD__COURS);
            }
            repors.DataSource = list;
            repors.DataMember = "";
            int ints_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
            adl.method method = new adl.method();
            method.data = con.TBL_INST.Find(ints_id).INST_LOGO;

            repors.Watermark.Image = Image.FromStream(method.convert_image());
            repors.ShowRibbonPreview();

        }
    }
}