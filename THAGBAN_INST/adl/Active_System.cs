using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.FORM.FRM_SYSTEM;

namespace THAGBAN_INST.adl
{
    public class Active_System
    {
        private readonly FRM_Start main;
        public Active_System(FRM_Start main) {
           this.main = main;
           
        }
        public void cheak_trial()
        {
            if (Properties.Settings.Default.IsFirstOpen != true)

            {
                DateTime cournt_date = DateTime.Now;
                Properties.Settings.Default.Start_Date = DateTime.Now;
                Properties.Settings.Default.End_Date = cournt_date.AddDays(30);
                Properties.Settings.Default.IsFirstOpen = true;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Save(); ;
                MessageBox.Show("انت تستخدم النسخع التجريبيه حتى تاريخ  '" + Properties.Settings.Default.End_Date.ToString() + "'  ");
            }
            else
            {
                if (DateTime.Now > Properties.Settings.Default.End_Date && Properties.Settings.Default.ISActive == false)
                {

                   
                   main.Enabled = false;
                    FRM_A frm = new FRM_A();
                    frm.Show();


                }
                else
                {
                    if (Properties.Settings.Default.ISActive)
                    {
                        //FRM_LOGIN frm = new FRM_LOGIN();
                        //frm.Show();
                    }
                    else
                    {
                        var day = Properties.Settings.Default.End_Date.Day - Properties.Settings.Default.Start_Date.Day;

                        MessageBox.Show("متبقي لك من الايام  (" + day.ToString() + ") ");
                        FRM_LOGIN frm = new FRM_LOGIN();

                       frm.Show();
                    }
                }
            }

        }

    }
}
