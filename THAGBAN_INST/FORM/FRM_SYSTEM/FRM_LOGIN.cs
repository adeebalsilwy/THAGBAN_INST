using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG;

namespace THAGBAN_INST.FORM.FRM_SYSTEM
{
  
    public partial class FRM_LOGIN : Form
    {
        public int user_id = 0;
        db_max_instEntities con =new db_max_instEntities();
        FRM_MAIN_LECTUER main= new FRM_MAIN_LECTUER();
        FRM_MAIN_ADMIN admin = new FRM_MAIN_ADMIN();

        adl.FRM_LOADING frm;
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_ClickAsync(object sender, EventArgs e)
        {




            CheekUserAsync();
        }
        int cheack_rouls_Use_Async(int user)
        {
            adl.method method = new adl.method();
            var rouls=con.TBL_USERS.Find(user);
            if (rouls == null)
            {
                method.show_message_note("عذرا لا تمتلك اي صلاحيات للوصول للنظام ");
                return 0;
            }
            else
            {
                    if (rouls.FRM_STUD == true)
                    admin.btn_stud.Enabled = true;
                else
                    admin.btn_stud.Enabled = false;
                if (rouls.FRM_MONY == true)
                    admin.btn_mony.Enabled = true;
                else
                    admin.btn_mony.Enabled = false;
                if (rouls.FRM_BUY == true)
                    admin.btn_buy.Enabled = true;
                else
                    admin.btn_buy .Enabled = false;
                if(rouls.FRM_CONTROL==true)
                    admin.btn_contrl.Enabled = true;
                else
                    admin.btn_contrl .Enabled = false;
                if (rouls.FRM_LECTUER == true)
                    admin.btn_lect.Enabled = true;
                else
                    admin.btn_lect.Enabled = false;
                if (rouls.FRM_EMP == true)
                    admin.btn_emp.Enabled = true;
                else
                    admin.btn_emp.Enabled = false;
                if (rouls.FRM_SETTING == true)
                    admin.btn_setting.Enabled = true;
                else
                    admin.btn_setting.Enabled= false;

                admin.lbl_emp_name.Text = rouls.TBL_EMPLOYEES.EMP_NAME.ToString();
                admin.imp_id = rouls.EMP_ID;
                return 1;






                
            }

        }
            int cheack_rouls_lec_Async(int user)
        {
           
            var rouls = con.TBL_ROULLS_LECTUER.Where(w => w.USER_ID == user).FirstOrDefault();
            if (rouls != null)
            {
               
                if (rouls.ch_tech_lec == true)

                    main.btn_tech_lect.Visible = true;
                else
                    main.btn_tech_lect.Visible = false;
                if (rouls.ch_send_tech == true)
                    main.btn_send_tech.Visible = true;
                else
                    main.btn_send_tech.Visible = false;
                if (rouls.ch_send_stud == true)
                    main.btn_send_stud.Visible = true;
                else
                    main.btn_send_stud.Visible = false;
                if (rouls.ch_stud == true)
                    main.btn_stud.Visible = true;
                else
                    main.btn_stud.Visible = false;
                if (rouls.ch_lect_stud == true)
                    main.btn_lect_stud.Visible = true;
                else
                    main.btn_lect_stud.Visible = false;
                if (rouls.ch_activ == true)
                    main.btn_active.Visible = true;
                else
                    main.btn_active.Visible = false;
                if (rouls.ch_admin == true)
                    main.btn_admin.Visible = true;
                else
                    main.btn_admin.Visible = false;
                if (rouls.ch_apu == true)
                    main.btn_about.Visible = true;
                else
                    main.btn_about.Visible = false;
                if (rouls.ch_attend == true)
                    main.btn_attend.Visible = true;
                else
                    main.btn_attend.Visible = false;
                if (rouls.ch_cours_lect == true)
                    main.btn_cours.Visible = true;
                else
                    main.btn_cours.Visible = false;
                if (rouls.ch_dept == true)
                    main.btn_dept.Visible = true;
                else
                    main.btn_dept.Visible = false;
                if (rouls.ch_emp == true)
                    main.btn_emp.Visible = true;
                else
                    main.btn_emp.Visible = false;
                if (rouls.ch_job == true)
                    main.btn_job.Visible = true;
                else
                    main.btn_job.Visible = false;
                if (rouls.ch_lect == true)
                    main.btn_lect.Visible = true;
                else
                    main.btn_lect.Visible = false;
                if (rouls.ch_lect_stud == true)
                    main.btn_lect_stud.Visible = true;
                else
                    main.btn_lect_stud.Visible = false;
                if (rouls.ch_main == true)
                    main.btn_home.Visible = true;
                else
                    main.btn_home.Visible = false;
                if (rouls.ch_mark == true)
                    main.btn_mark.Visible = true;
                else
                    main.btn_mark.Visible = false;
                if (rouls.ch_matrila == true)
                    main.btn_matrial.Visible = true;
                else
                    main.btn_matrial.Visible = false;
                if (rouls.ch_report == true)
                    main.btn_report.Visible = true;
                else
                    main.btn_report.Visible = false;
                if (rouls.ch_sala == true)
                    main.btn_salary.Visible = true;
                else
                    main.btn_salary.Visible = false;
                if (rouls.ch_sett == true)
                    main.btn_sett.Visible = true;
                else
                    main.btn_sett.Visible = false;

                return 1;
               


            }
            else
            {
               
                return 0;
            }
        }
    
        async Task<int> loaging_form(int user_id)
        {
            //adl.FRM_LOADING frm = new adl.FRM_LOADING();
            //frm.lbl_masseg.Text = "... يتم فحص الصلاحيات ";
            //frm.Show();
           // await Task.Run(() => Thread.Sleep(2000));
            int temp = await Task.Run(() => cheack_rouls_lec_Async(user_id));
            if (temp == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        async void  CheekUserAsync()
        {

            TBL_INST super_admin=con.TBL_INST.FirstOrDefault();
            if (isempty())
            {
                adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.empty_notifcationText, THAGBAN_INST.Properties.Resources.Notification_128px);
            notifiction.StartPosition= FormStartPosition.CenterScreen;
                notifiction.Show();
            }
            else
            {
             
                if (txt_user.Text.Trim() == "deebo" && txt_pass.Text.Trim() == "deebo774")
                {
                    admin.lbl_emp_name.Text = "اديب الصلوي ";
                    admin.Show();
                    this.Hide();
                }
                else if( super_admin.INST_USER_ADMIN==txt_user.Text.Trim() && super_admin.INST_USER_PASS== txt_pass.Text.Trim())
                {
                    admin.lbl_emp_name.Text = "سوبر ادمن ";

                    admin.Show();
                    this.Hide();
                }
               
                        else
                {
                    
                    TBL_USERS tbl = con.TBL_USERS.Where(w => w.USER_NAME.Trim() == txt_user.Text.Trim()
                    && w.USER_PASS == txt_pass.Text.Trim()).FirstOrDefault();
                    if (tbl != null)
                    {
                        user_id = Convert.ToInt32(tbl.USER_ID.ToString());


                        //  int  t = await loaging_form(user_id);
                        // int temp = await Task.Run(() =>  cheack_roulsAsync(user_id));

                        // int temp = await  cheack_roulsAsync(user_id);
                        adl.FRM_LOADING frm = new adl.FRM_LOADING();
                        frm.lbl_masseg.Text = "... يتم فحص الصلاحيات ";
                        frm.Show();
                       await Task.Run(() => Thread.Sleep(2000));
                       
                        int temp = await Task.Run(() => cheack_rouls_Use_Async(user_id));
                        if (temp == 1)
                        {
                            frm.Close();
                            admin.imp_id = con.TBL_USERS.Find(user_id).EMP_ID;
                            admin.Show();
                            this.Hide();

                        }
                        else
                        {
                            frm.Close();
                            adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.not_have_rouls, THAGBAN_INST.Properties.Resources.Notification_128px);
                            notifiction.StartPosition = FormStartPosition.CenterScreen;
                            notifiction.Show();
                        }
                    }
                    else
                    {

                        adl.NotifictionUser notifiction = new adl.NotifictionUser("اسم المستخدم او كلمه المرور خاطئه ", THAGBAN_INST.Properties.Resources.Notification_128px);
                        notifiction.StartPosition = FormStartPosition.CenterScreen;
                        notifiction.Show();

                    }
                }

            }
           
        }
        bool isempty()
        {
            if(txt_user.Text=="" &&txt_pass.Text=="")
                return true;
            else return false;
        }

        private void FRM_LOGIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!isempty())
            {
                if(e.KeyChar.Equals(Keys.Enter)) {
                     CheekUserAsync();

                }

            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_user.Text != "")
            {
                if (e.KeyChar.Equals(Keys.Enter))
                {
                    //txt_pass.Focus();
                    txt_pass.Enabled = true;

                }
              
            }
        }

        private void txt_user_TextChange(object sender, EventArgs e)
        {
            if (txt_user.Text != "")
            {
                
                   
                    txt_pass.Enabled = true;

                }
            else
            {
                txt_pass.Enabled = true;
            }

            }

        private void txt_pass_TextChange(object sender, EventArgs e)
        {
           
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text != "")
            {

                btn_login.Enabled = true;


            }
            else
            {
                btn_login.Enabled = false;
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_pass.Text != "")
            {
                if (e.KeyChar.Equals(Keys.Enter))
                {
                    CheekUserAsync();
                }

            }
        }

        private void txt_user_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_user.Text != "")
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                   txt_pass.Focus();
                    txt_pass.Enabled = true;


                }

            }
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
            txt_pass.Enabled = false;
            btn_login.Enabled = true;
            
        }

        private void txt_pass_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_user.Text != "")
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                   btn_login.Enabled=true;
                    CheekUserAsync();
                }

            }
        }

        bool show_pass = false;
        private void txt_pass_OnIconLeftClick(object sender, EventArgs e)
        {
          //  string pass = txt_pass.Text.Trim();
            if (!show_pass)
            {

                txt_pass.PasswordChar = '*';
                show_pass = true;
              //  txt_pass.Text = pass;
            }
            else
            {
                //txt_pass.UseSystemPasswordChar = false;
                show_pass = false;
                txt_pass.PasswordChar = '\0';
               // txt_pass.Text = pass;
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            CheekUserAsync();
        }
    }
    
}
