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
using THAGBAN_INST.FORM.FRM_CONTORL;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG;
using THAGBAN_INST.FORM.FRM_SYSTEM;

namespace THAGBAN_INST.FORM
{
    public partial class FRM_MAIN_ADMIN : DevExpress.XtraEditors.XtraForm
    {
        public int imp_id;
        public FRM_MAIN_ADMIN()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FRM_MAIN_EMPLOYEE frm=new FRM_MAIN_EMPLOYEE();
            frm.imp_id = imp_id;
            frm.ShowDialog(this);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FRM_MAIN_MONY frm=new FRM_MAIN_MONY();
            frm.imp_id = imp_id;
            frm.ShowDialog(this);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FRM_MAIN_LECTUER frm = new FRM_MAIN_LECTUER();
            frm.ShowDialog(this);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FRM_MAIN_CONTROL frm = new FRM_MAIN_CONTROL();
            frm.ShowDialog(this);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FRM_MAIN_STUDENTS frm = new FRM_MAIN_STUDENTS();
            frm.ShowDialog(this);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            FRM_MAIN_BUY frm = new FRM_MAIN_BUY();
            frm.ShowDialog(this);
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frm_setting frm = new frm_setting();
            frm.ShowDialog(this);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            FRM_CLOCE frm = new FRM_CLOCE();
            this.Hide();
            frm.ShowDialog(this);
            
        }

        private void FRM_MAIN_ADMIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}