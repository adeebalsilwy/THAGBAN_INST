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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.Remoting.Contexts;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_salary
{
    public partial class frm_mang_lect_sal : DevExpress.XtraEditors.XtraUserControl
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
        private int lect_id;
        private int tech_lect_id;

        public frm_mang_lect_sal()
        {
            InitializeComponent();
            cheack_change();


            get_data();
           
        }
        void get_data()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            THAGBAN_INST.DATA.db_max_instEntities dbContext = new THAGBAN_INST.DATA.db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_SEND_TECT_LECT.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TBL_SEND_TECT_LECT.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        void get_spic()
        {
            if(ch_lect.Checked==true && ch_grou.Checked==false)
            {
                try
                {
                    if (com_lect.SelectedValue != null)
                    {
                        lect_id = Convert.ToInt32(com_lect.SelectedValue);
                        gridControl1.DataSource = con.TBL_SEND_TECT_LECT.Where(w => w.LECT_ID == lect_id).ToList();

                    }
                }
                catch (Exception ex)
                {

                }
            }
           
            else if (ch_lect.Checked == true && ch_grou.Checked == true)
            {
                try
                {
                    if (com_lect.SelectedValue != null)
                    {
                        lect_id = Convert.ToInt32(com_lect.SelectedValue);
                        tech_lect_id=Convert.ToInt32(com_group.SelectedValue);
                        gridControl1.DataSource = con.TBL_SEND_TECT_LECT.Where(w => w.LECT_ID == lect_id && w.TECH_LECT_ID == tech_lect_id).ToList();

                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                get_data();
            }

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
            frm_add_lect_sal frm= new frm_add_lect_sal();
            get_sel();
            frm.part_id = part_id;
            frm.btn_save.Text = "تعديل";
            frm.ShowDialog();
            get_data();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            frm_add_lect_sal frm = new frm_add_lect_sal();
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
                    try {
                        TBL_SEND_TECT_LECT del_cle = con.TBL_SEND_TECT_LECT.Find(part_id);
                        // del_doc.DOC_ID = holiday_type_id;

                        con.TBL_SEND_TECT_LECT.Remove(del_cle);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.DeleteNotificationText, THAGBAN_INST.Properties.Resources.Delete_32px);
                        notifiction.Show();
                    }catch (Exception ex) { }
                    get_data();
                }
            }
        }

        private void gridView2_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_sel();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        public void get_lect()
        {
            var tbl = con.TBL_LECT_TECH_COURS.Where(w => w.STATE == true)
                .Join(con.TBL_LECTUER, l => l.TBL_LECTUER.LECT_ID, tl => tl.LECT_ID,
                (l, tl) => new
                {

                    l.LECT_ID,

                    tl.LECT_NAME,

                }).Distinct();


            if (tbl != null)
            {
                com_lect.DataSource = tbl.ToList();
                com_lect.DisplayMember = "LECT_NAME";
                com_lect.ValueMember = "LECT_ID";
                //  lbl_lect_tech.Text = tbl.Count().ToString();
                get_group();


            }
            else
            {
                com_lect.DataSource = null;
                com_lect.Items.Clear();
                com_lect.Text = "";
            }
        }
        public void get_group()
        {
            try
            {

                lect_id = Convert.ToInt32(com_lect.SelectedValue);
                var temp = con.TBL_LECT_TECH_COURS.Where(w => w.LECT_ID == lect_id).Distinct().ToList();
                if (temp != null)
                {
                    com_group.DataSource = temp;
                    com_group.DisplayMember = "GROUP_NAME";
                    com_group.ValueMember = "TECH_LECT_ID";


                }
                else
                {
                    com_group.DataSource = null;
                    com_group.Items.Clear();
                    com_group.Text = "";
                }
            }
            catch (Exception ex) { }


        }

        private void ch_lect_CheckedChanged(object sender, EventArgs e)
        {
            cheack_change();
            get_lect();
            get_spic();
        }
        void cheack_change()
        {

            if (ch_lect.Checked)
            {
                com_lect.Enabled = true;
                get_spic();
            }
            else
            {
                com_lect.Enabled = false;
            }
            if (ch_grou.Checked)
            {
                com_group.Enabled = true;
                get_spic();

            }
            else
            {
                //groupBox1.Enabled = false;
                //groupBox1.Visible = false;
                com_group.Enabled = false;
            }
            
        }

        private void ch_grou_CheckedChanged(object sender, EventArgs e)
        {
            cheack_change();
            get_spic();
            get_group();
        }

        private void com_lect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (com_lect.SelectedValue != null)
                {
                    lect_id = Convert.ToInt32(com_lect.SelectedValue);
                    get_group();
                    get_spic();


                }
            }
            catch (Exception ex) { }
        }

        private void com_group_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (com_group.SelectedValue != null)
                {
                    tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
                    get_spic();


                }
            }
            catch (Exception ex) { }
        }

        private void com_lect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (com_lect.SelectedValue != null)
                {
                    lect_id = Convert.ToInt32(com_lect.SelectedValue);
                    get_group();
                    get_spic();


                }
            }
            catch (Exception ex) { }
        }
    }
}