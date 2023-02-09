﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.lsits
{
    public partial class emp_list : DevExpress.XtraEditors.XtraForm
    {
        public string emp_name;
        public int emp_id;
        public emp_list()
        {
            InitializeComponent();
            get_data();


        }

        private void job_list_Load(object sender, EventArgs e)
        {
            get_data();
        }

        void get_sele()
        {
            if (gridView2.SelectedRowsCount > 0)
            {


                emp_name = gridView2.GetFocusedRowCellValue("EMP_NAME").ToString();
                emp_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("EMP_ID").ToString());


            }
        }
        void get_data()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_EMPLOYEES.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TBL_EMPLOYEES.Where(w => w.STATE == true).ToList() ;
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            get_sele();
        }
    }
}