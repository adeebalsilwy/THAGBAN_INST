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
using System.IO;

using System.Data.Entity.Migrations;
using System.Threading;
using System.Diagnostics;
using DeviceId;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_SYSTEM
{
    public partial class FRM_A : DevExpress.XtraEditors.XtraForm
    {
        //DBEPSEntities db;
        //TB_ABC add;
       db_max_instEntities con = new db_max_instEntities();
        DeviceIdBuilder DEVIECE = new DeviceIdBuilder();
        string mac_address = "";
        string tempkey = "";
        private string key;

        public FRM_A()
        {
            InitializeComponent();
            CheckState();
           
                mac_address = DEVIECE.AddMacAddress(excludeWireless: true).ToString();
            txt_name.Text = mac_address;
               lbl_key.Text= mac_address.Substring(0,5) ;
            lbl_key.Visible = false;
          key = "deebo" + lbl_key.Text + "1697402";
           // label4.Text = key.ToString();



        }

        string encoding()
        {
            //string temp= Encoding.ASCII.GetString(rs2); ;
            string temp = mac_address.Substring(5);

            return "";
        }
       

        private void CheckState()
        {
            try
            {

                var rs1 = con.TBL_ACTIVE_SYSTEM.Select(w => w.Mack_address).First();
                var rs2 = con.TBL_ACTIVE_SYSTEM.Select(X => X.Mack_address).First();
                if (rs1==null)
                {
                    txt_state.Text = "هل تمتلك مفتاح تفعيل مرخص , يمكنك التفعيل الان ";
                    pic_key.BringToFront();
                    panel2.Enabled = true;
                }
                else
                {

                    txt_state.Text = "البرنامج مفعل ";
                    pic_done.BringToFront();
                    
                   // txt_name.Text =;
                   
                   txt_seryal.Text ="تم التفعيل بواسطه المطور";
                    panel2.Enabled = false;


                }
            }
            catch
            {

            }
        
    }

        private void txt_state_Click(object sender, EventArgs e)
        {
           

        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if ( txt_seryal.Text == "")
            {
                MessageBox.Show("قم بمليء الحقول رجاءا");
            }
            else
            {
                try
                {
                    

                        txt_state.Text = " ...يتم تفعيل المنتج الان ";
                        await Task.Run(() => Thread.Sleep(2000));
                        
                        if (key == txt_seryal.Text)
                        {
                            // await Task.Run(() => Done());

                            TBL_ACTIVE_SYSTEM tbl = new TBL_ACTIVE_SYSTEM();

                            tbl.Mack_address = mac_address;
                        tbl.Key = key.ToString();
                            tbl.Added_date = DateTime.Now;

                            con.TBL_ACTIVE_SYSTEM.AddOrUpdate(tbl);
                            con.SaveChanges();
                            CheckState();
                        THAGBAN_INST.Properties.Settings.Default.ISActive = true;
                        Properties.Settings.Default.Save();
                            MessageBox.Show("تهانينا :) تم تفعيل البرنامج بنجاح , سيتم اعادة تشغيل البرنامج لضبط كافة الاعدادات");
                            Application.Restart();
                        }
                        else
                        {
                            CheckState();
                            txt_state.Text = "خطأ مفتاح المنتج غير صالح ";


                        

                    }



                }
                catch
                {
                    MessageBox.Show("يبدو انك غير متصل في الشبكة , عملية التفعيل تحتاج الى توفر الاتصال في الشبكة");

                }
            }





            //private async void Done()
            //{
            //    IFirebaseConfig config = new FirebaseConfig
            //    {
            //        AuthSecret = "enter auth secret",
            //        BasePath = "enter path"
            //    };
            //    //  IFirebaseClient client = new FirebaseClient(config);

            //    var Date = new DataDone
            //    {
            //        UserName = txt_name.Text,
            //        Code = txt_seryal.Text

            //    };
            //    // FirebaseResponse response = await client.PushAsync("liclistActive", Date);

            //}
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("enter url here");
        }
    }

    class DataDone
    {
        public string UserName { get; set; }
        public string Code { get; set; }
    }
    
}