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

namespace THAGBAN_INST.FORM.BUY.out_come
{
    public partial class FRM_ADD_camout : DevExpress.XtraEditors.XtraForm
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast =new tost();
        dialge dialge = new dialge();
        public int out_id=0;
        THAGBAN_INST.adl.method method1 = new adl.method();
    
       public bool state;
        private int categorie_id=0;
        private int? out_optin_id=0;
        private int stor_id;
        int qualty = 0;

        public FRM_ADD_camout()
        {
            InitializeComponent();
            get_data();
            
        }

        void get_data()
        {
            com_stor.DataSource = con.TBL_STORS.ToList();
            com_stor.DisplayMember = "STOR_NAME";
            com_stor.ValueMember = "STOR_ID";
            if (out_id!=0)
                com_stor.SelectedValue = stor_id;

           
        }

        void get_categ()
        {
           var data = con.TBL_CATEGORIES.Where(w => w.STOR_ID == stor_id).ToList();

            if (data.Count > 0)
            {
                com_category.DataSource = data.Where(w => w.CatQuantity > 0).ToList();
                com_category.DisplayMember = "CatName";
                com_category.ValueMember = "ID";
                if (out_id != 0)
                    com_category.SelectedValue = stor_id;
            }
            else
            {
                com_category.Text = "";
                com_category.DataSource = null;
                method1.show_empty_message();

            }
           
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_level();
            
        }
        void clear()
        {
            out_id = 0;
            txt_quaty.Text = "";
        }
        bool is_empty()
        {
            if (txt_quaty.Text != "" )
            {
                return false;
            }
            else
                return true;

        }

        void sub_qualty_category(int cat_id,int qualty)
        {
            TBL_CATEGORIES tbl = con.TBL_CATEGORIES.Find(categorie_id);
            tbl.STOR_ID = tbl.STOR_ID;
            tbl.CatName = tbl.CatName;
            tbl.CatDes = tbl.CatDes;
            tbl.CatQuantity -= qualty;
            tbl.ID = tbl.ID;
           
            con.TBL_CATEGORIES.AddOrUpdate(tbl);
            con.SaveChanges();
        }
        void add_qualty_category(int cat_id, int qualty)
        {
            TBL_CATEGORIES tbl = con.TBL_CATEGORIES.Find(categorie_id);
            tbl.STOR_ID = tbl.STOR_ID;
            tbl.CatName = tbl.CatName;
            tbl.CatDes = tbl.CatDes;
            tbl.CatQuantity += qualty;
            tbl.ID = tbl.ID;

            con.TBL_CATEGORIES.AddOrUpdate(tbl);
            con.SaveChanges();
        }
        void add_level()
        {
            THAGBAN_INST.adl.method method = new THAGBAN_INST.adl.method();
            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
            try
                {
                    TBL_OutCome cl = new TBL_OutCome();
                    cl.Categiry_ID = categorie_id;
                    cl.OutCoualty =Convert.ToInt32(txt_quaty.Text);
                    cl.AddedDate = (DateTime)method.convert_date(DateTime.Now);
                    if (txt_note.Text == "")
                        cl.note = "لا توجد ملاحصات";
                    else
                        cl.note = txt_note.Text;




                    if (out_id != 0)
                    {
                        //add 
                        add_qualty_category(cl.Categiry_ID, qualty);
                        sub_qualty_category(cl.Categiry_ID, cl.OutCoualty);
                        cl.Id = Convert.ToInt32(out_id);
                        con.TBL_OutCome.AddOrUpdate(cl);
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
                        sub_qualty_category(cl.Categiry_ID, cl.OutCoualty);
                        con.TBL_OutCome.AddOrUpdate(cl);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();
                        clear();

                    }
                   
                    
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show(ex.Message+ex.InnerException.ToString());
                    //dialge.Width = this.Width;
                    //dialge.lbl_mess.Text=ex.Message;
                    //dialge.Show();
                }
              
            }
            else
            {
                dialge.Width = this.Width;
                dialge.lbl_mess.Text ="الرجاء ادخال جميع البيانات ";
                dialge.Show();



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
            if (out_id != 0)
            {
                TBL_OutCome tbl = con.TBL_OutCome.Find(out_id);
                txt_quaty.Text = tbl.OutCoualty.ToString();
                categorie_id = tbl.Categiry_ID;
                txt_note.Text = tbl.note;
                qualty = tbl.OutCoualty;
                
               

             }
        }

        private void txt_quaty_TextChanged(object sender, EventArgs e)
        {

        }

        private void com_stor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                stor_id = Convert.ToInt32(com_stor.SelectedValue.ToString());
                get_categ();
            }
            catch(Exception ex)
            {

            }
        }

        private void com_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                categorie_id = Convert.ToInt32(com_category.SelectedValue.ToString());
               
            }
            catch (Exception ex)
            {

            }
        }
    }
}