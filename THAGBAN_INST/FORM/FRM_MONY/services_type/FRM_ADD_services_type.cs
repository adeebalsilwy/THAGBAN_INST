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
using THAGBAN_INST.FORM.FRM_EMP_MANEGER;
using THAGBAN_INST.FORM;
using System.Data.Entity.Migrations;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_MONY.services_type
{
    public partial class FRM_ADD_services_type : DevExpress.XtraEditors.XtraForm
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast =new tost();
        dialge dialge = new dialge();
        public int services_type_id;

       public string holday_type_name;
       public string holday_type_dec;
       public string dept_state;


        public FRM_ADD_services_type()
        {
            InitializeComponent();
            
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_holday_type();
            
        }
        void clear()
        {
            services_type_id = 0;
            txt_service_type_price.Text = "";
            txt_service_type_name.Text = "";
        }
        bool is_empty()
        {
            if ( txt_service_type_name.Text != "" )
            {
                return false;
            }
            else
                return true;

        }

        void add_holday_type()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
            try
                {
                    TBL_SERVICE_TYPE cl = new TBL_SERVICE_TYPE();
                    cl.SERVICE_TYPE_NAME = txt_service_type_name.Text;
                    cl.SERVICE_TYPE_PRICE =Convert.ToDouble(txt_service_type_price.Text);
                    if (services_type_id != 0)
                    {
                        //add 
                        cl.SERVICE_TYPE_ID = Convert.ToInt32(services_type_id);
                        con.TBL_SERVICE_TYPE.AddOrUpdate(cl);
                        con.SaveChanges();
                        toast.Width = this.Width;

                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();
                        clear();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        con.TBL_SERVICE_TYPE.AddOrUpdate(cl);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();
                        clear();

                    }
                }
                catch (Exception ex)
                {
                   
                    dialge.Width = this.Width;
                    dialge.lbl_mess.Text=ex.Message;
                    dialge.Show();
                }
               
            }
            else
            {
                adl.method method = new adl.method();
                method.show_empty_message();


            }


        }

        private void ch_open_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
        }

        private void ch_close_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }
       

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void FRM_ADD_DEP_Load(object sender, EventArgs e)
        {
            if (services_type_id != 0)
            {
                TBL_SERVICE_TYPE TBL = con.TBL_SERVICE_TYPE.Find(services_type_id);
                txt_service_type_price.Text = TBL.SERVICE_TYPE_PRICE.ToString();
                txt_service_type_name.Text = TBL.SERVICE_TYPE_NAME;
            }
        }
    }
}