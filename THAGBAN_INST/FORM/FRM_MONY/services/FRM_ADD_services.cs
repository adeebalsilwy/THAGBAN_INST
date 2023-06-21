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

namespace THAGBAN_INST.FORM.FRM_MONY.services
{
    public partial class FRM_ADD_services : DevExpress.XtraEditors.XtraForm
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast =new tost();
        dialge dialge = new dialge();
        public int services_type_id;
        public int services_id = 0;
       


        public FRM_ADD_services()
        {
            InitializeComponent();
            get_data();
            get_coustmer_name();


        }

        void get_data()
        {
            com_service_type.DataSource = con.TBL_SERVICE_TYPE.ToList();
            com_service_type.DisplayMember = "SERVICE_TYPE_NAME";
            com_service_type.ValueMember = "SERVICE_TYPE_ID";
            if (services_id != 0)
                com_service_type.SelectedValue = services_type_id;
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
            txt_coustomer_phone.Text = "";
            txt_service_name.Text = "";
        }
        bool is_empty()
        {
            if ( txt_service_name.Text != "" && txt_coustomer_name.Text!="" && txt_coustomer_phone.Text!="" && txt_service_price.Text!="")
            {
                return false;
            }
            else
                return true;

        }

        void add_holday_type()
        {
            adl.method method = new adl.method();
            int inst_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
            try
                {
                    TBL_SERVICES cl = new TBL_SERVICES();
                    cl.SERVICE_NAME = txt_service_name.Text;
                    cl.COUSTOMER_PHONE =txt_coustomer_phone.Text;
                    cl.COUSTOMER_NAME = txt_coustomer_name.Text;
                    cl.SERVICE_PRICE = Convert.ToDouble(txt_service_price.Text);
                    cl.SERVICE_TYPE_ID = services_type_id;
                    cl.NOTE = txt_note.Text;
                    if (services_id != 0)
                    {
                        //add 
                        cl.SERVICE_ID = Convert.ToInt32(services_id);
                        int opration_id = (int)con.TBL_SERVICES.Find(services_id).OPRATION_ID;
                        method.update_opration_price(opration_id, (int)cl.SERVICE_PRICE);
                        con.TBL_SERVICES.AddOrUpdate(cl);
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

                       cl.OPRATION_ID=  method.add_to_box(inst_id, (double)cl.SERVICE_PRICE);
                        con.TBL_SERVICES.AddOrUpdate(cl);
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
            if (services_id != 0)
            {
                TBL_SERVICES TBL = con.TBL_SERVICES.Find(services_id);
                txt_coustomer_phone.Text = TBL.COUSTOMER_PHONE.ToString();
                txt_service_name.Text = TBL.SERVICE_NAME;
                txt_coustomer_name.Text = TBL.COUSTOMER_NAME;
                txt_note.Text = TBL.NOTE;
                txt_service_price.Text=TBL.SERVICE_PRICE.ToString();
                services_type_id = (int)TBL.SERVICE_TYPE_ID;
            }
        }

        private void txt_coustomer_phone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void com_service_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                services_type_id = Convert.ToInt32(com_service_type.SelectedValue.ToString());
            }catch(Exception ex)
            {

            }
        }

        private void txt_coustomer_name_TextChanged(object sender, EventArgs e)
        {

        }

        void get_coustmer_name()
        {
            AutoCompleteStringCollection stringCollection = new AutoCompleteStringCollection();
           var data= con.TBL_SERVICES.Select(w=>w.COUSTOMER_NAME).ToList();
       txt_coustomer_name.AutoCompleteCustomSource.AddRange(con.TBL_SERVICES.Select(w => w.COUSTOMER_NAME).ToArray());
         
            //foreach (var e in data)
            //{
            //    stringCollection.Add(e.ToString());
            //}
         //   txt_coustomer_name.AutoCompleteCustomSource = stringCollection;
        }

        private void txt_coustomer_name_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_coustomer_name.Text != "")
                {
                    var data = con.TBL_SERVICES.Where(w => w.COUSTOMER_NAME == txt_coustomer_name.Text.Trim()).FirstOrDefault();
                    if(data != null)
                    {
                        txt_coustomer_phone.Text = data.COUSTOMER_PHONE.ToString();
                    }
                }
            }
            catch(Exception ex) { }
        }
        void get_phone()
        {
            try
            {
                if (txt_coustomer_name.Text != "")
                {
                    var data = con.TBL_SERVICES.Where(w => w.COUSTOMER_NAME == txt_coustomer_name.Text.Trim()).FirstOrDefault();
                    if (data != null)
                    {
                        txt_coustomer_phone.Text = data.COUSTOMER_PHONE.ToString();
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}