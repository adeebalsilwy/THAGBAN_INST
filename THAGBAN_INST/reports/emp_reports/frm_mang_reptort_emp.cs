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
using DevExpress.XtraReports;
using DevExpress.XtraReports.ReportGeneration;
using DevExpress.XtraGrid.Columns;

namespace THAGBAN_INST.reports.emp_reports
{
    public partial class frm_mang_reptort_emp : DevExpress.XtraEditors.XtraUserControl
    {
        db_max_instEntities con = new db_max_instEntities();
       
        public int part_id = 0;
       


        public DateTime part_date;

        List<TBL_PART_SALARY> part_salary;
        public frm_mang_reptort_emp()
        {
            InitializeComponent();


            get_data();
        }
        void get_data()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_PART_SALARY.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TBL_PART_SALARY.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            part_id = 0;
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
                    part_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("PART_ID").ToString());
                   
                }catch (Exception ex)
                {

                }
            }
        }

       

        private void gridView2_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_sel();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            part_salary_report report= new part_salary_report();
            if (part_id!=0)
            {
                report.DataSource = con.TBL_PART_SALARY.Find(part_id);
            }
            report.ShowPreviewDialog();
        }

       
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            part_salary_report report = new part_salary_report();
           
           
            report.ShowPreviewDialog();
        }

       
        private void frm_mang_reptort_emp_Load(object sender, EventArgs e)
        {
            get_data();
        }
    }
}
