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
using THAGBAN_INST.DATA;
using THAGBAN_INST.FORM.FRM_MANG_STUD.spical;
using DevExpress.XtraScheduler.UI;
using DevExpress.XtraBars.Ribbon.Drawing;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_mark
{
    public partial class frm_mang_lect_marks : DevExpress.XtraEditors.XtraUserControl
    {


        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int id;

        public string cours_name;
        public string cours_desc;
        public int spiacla_id;
        public int term_id;

        public frm_mang_lect_marks()
        {
            InitializeComponent();
            get_data();




        }

        public void get_data()
        {



            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            THAGBAN_INST.DATA.db_max_instEntities dbContext = new THAGBAN_INST.DATA.db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_LECT_MARK.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TBL_LECT_MARK.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            frm_add_lect_mark add =new frm_add_lect_mark();
            add.id =0;
            add.ShowDialog();
            get_data();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            get_data();
        }

        private void btn_edite_Click(object sender, EventArgs e)
        {
            frm_add_lect_mark frm = new frm_add_lect_mark();
            //frm.holiday_type_name=holiday_type_name;
            //frm.lect_id = spiacla_id;
            //frm.cours_name=cours_name;
            frm.id=id;
            //frm.cours_desc=cours_desc;
            frm.btn_save.Text = "تعديل";
          
            frm.ShowDialog();
            get_data();
        }

        void delete()
        {
            if (id != 0)
            {
                DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    TBL_LECT_MARK del_cle = con.TBL_LECT_MARK.Find(id);
                    // del_doc.DOC_ID = holiday_type_id;

                    con.TBL_LECT_MARK.Remove(del_cle);
                    con.SaveChanges();
                    tost not = new tost();
                    not.Width = this.Width;
                    not.lbl_mess.Text = "تم الحذف بنجاح ";
                }
                get_data();
            }
        }

        void get_sele()
        {
            if (gridView2.SelectedRowsCount > 0)

            {
                try
                {

                    id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("MARK_ID").ToString());

                }catch(Exception e) { }
                // stud_id = gridView2.GetSelectedRows("DEPT_NAME").ToString();

            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            get_sele();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
            get_data();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            get_sele();
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            get_sele();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            get_sele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            gridControl1.ShowRibbonPrintPreview();
            
            
        }
    }
}