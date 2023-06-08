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
using THAGBAN_INST.FORM.FORM_MANG_STUD.reports;
using DevExpress.XtraReports.UI;

namespace THAGBAN_INST.FORM.FRM_MANG_STUD.marks
{
    public partial class frm_mang_marks : DevExpress.XtraEditors.XtraUserControl
    {


        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int id;

        public string cours_name;
        public string cours_desc;
        public int spiacla_id;
        public int term_id;

        public frm_mang_marks()
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
            dbContext.TBL_MARKS.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TBL_MARKS.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            frm_add_mark add =new frm_add_mark();
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
            frm_add_mark frm = new frm_add_mark();
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
                try
                {
                    DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        TBL_MARKS del_cle = con.TBL_MARKS.Find(id);
                        // del_doc.DOC_ID = holiday_type_id;

                        con.TBL_MARKS.Remove(del_cle);
                        con.SaveChanges();
                        tost not = new tost();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.DeleteNotificationText, THAGBAN_INST.Properties.Resources.Delete_32px);
                        notifiction.Show();
                    }
                    get_data();
                }catch (Exception ex) { }
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

            report_mark_stud_spice repors = new report_mark_stud_spice();
            List<TBL_MARKS> list = new List<TBL_MARKS>();

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                list.Add(gridView2.GetRow(i) as TBL_MARKS);
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
