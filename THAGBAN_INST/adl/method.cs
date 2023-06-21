using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using THAGBAN_INST.DATA;
using System.Data.Entity;
using DevExpress.XtraCharts.Native;
using Microsoft.Win32;
using System.Data.Entity.Migrations;

namespace THAGBAN_INST.adl
{
    class method
    {
        db_max_instEntities con = new db_max_instEntities();
        public MemoryStream ms = new MemoryStream();
        public byte[] data;
        public byte[] convert_byte()
        {
            return ms.ToArray();
        }
        public MemoryStream convert_image()
        {
            if (data != null)
            {
                ms = new MemoryStream(data);
                return ms;
            }
            else
                return null;
        }
        public DateTime? convert_date(DateTime old)
        {
            DateTime cournt = DateTime.Now;
            if (old != null)
            {
                string aa = string.Format("{0:dd-MM-yyyy}", old);
                cournt = DateTime.ParseExact(aa, "dd-MM-yyyy", null);

            }
            return cournt;
        }

        public void show_add_message()
        {
            THAGBAN_INST.adl.NotifictionUser notifiction = new THAGBAN_INST.adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
            notifiction.Show();
        }
        public void show_edit_message()
        {
            THAGBAN_INST.adl.NotifictionUser notifiction = new THAGBAN_INST.adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
            notifiction.Show();
        }

        public void show_delete_message()
        {
            THAGBAN_INST.adl.NotifictionUser notifiction = new THAGBAN_INST.adl.NotifictionUser(THAGBAN_INST.Properties.Resources.DeleteNotificationText, THAGBAN_INST.Properties.Resources.Delete_32px);
            notifiction.Show();
        }

        public void show_empty_message()
        {
            THAGBAN_INST.adl.NotifictionUser notifiction = new THAGBAN_INST.adl.NotifictionUser(THAGBAN_INST.Properties.Resources.empty_notifcationText, THAGBAN_INST.Properties.Resources.Notification_128px);
            notifiction.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            notifiction.Show();
        }

        public void show_message_note(string mass)
        {
            THAGBAN_INST.adl.NotifictionUser notifiction = new adl.NotifictionUser(mass, THAGBAN_INST.Properties.Resources.about_32px);
            notifiction.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            notifiction.Show();
        }
        public int add_to_box(int inst_id, double monye)
        {
            int id = 0;
            try
            {
                TBL_INST inst = con.TBL_INST.Find(inst_id);
                TBL_OPRATION opration = new TBL_OPRATION();
                opration.PORATION_AMOUNT = Convert.ToInt32(monye);
                opration.PORATION_DATE = DateTime.Now;
                opration.OPRATION_TYPE = "ايداع";
                opration.INST_ID = Convert.ToInt32(inst_id);


                long total = Convert.ToInt64(inst.INST_TOTAL);
                total = Convert.ToInt64((total + Convert.ToInt32(opration.PORATION_AMOUNT)));
                inst.INST_TOTAL = total.ToString();
                inst.INST_ID = Convert.ToInt32(inst_id);
                con.TBL_OPRATION.AddOrUpdate(opration);
                con.TBL_INST.AddOrUpdate(inst);
                con.SaveChanges();

                return opration.OPRATION_ID;
            } catch (Exception ex)
            {
                return 0;
            }
            finally
            {
            }
        }

        public void update_opration_price(int opration_id,int amount)
        {
            
            try

            {
                int inst_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
                TBL_INST inst = con.TBL_INST.Find(inst_id);
                TBL_OPRATION opration =con.TBL_OPRATION.Find(opration_id);
               int sub= (int)opration.PORATION_AMOUNT;
                opration.OPRATION_ID = opration_id;
                opration.PORATION_AMOUNT = Convert.ToInt32(amount);
                opration.PORATION_DATE = DateTime.Now;
                opration.OPRATION_TYPE = opration.OPRATION_TYPE;
                opration.INST_ID = Convert.ToInt32(inst_id);


                long total = Convert.ToInt64(inst.INST_TOTAL) - sub;
                total = Convert.ToInt64((total + Convert.ToInt32(opration.PORATION_AMOUNT)));
                inst.INST_TOTAL = total.ToString();
                inst.INST_ID = Convert.ToInt32(inst_id);
                con.TBL_OPRATION.AddOrUpdate(opration);
                con.TBL_INST.AddOrUpdate(inst);
                con.SaveChanges();

            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        }

        public int sub_to_box(int inst_id, double monye)
        {
            int id = 0;
            try {
                TBL_INST inst = con.TBL_INST.Find(inst_id);
                TBL_OPRATION opration = new TBL_OPRATION();
                opration.PORATION_AMOUNT = Convert.ToInt32(monye);
                opration.PORATION_DATE = DateTime.Now;
                opration.OPRATION_TYPE = "سحب";
                opration.INST_ID = Convert.ToInt32(inst_id);


                long total = Convert.ToInt64(inst.INST_TOTAL);
                total = Convert.ToInt64((total - Convert.ToInt32(opration.PORATION_AMOUNT)));
                inst.INST_TOTAL = total.ToString();
                inst.INST_ID = Convert.ToInt32(inst_id);
                con.TBL_OPRATION.AddOrUpdate(opration);
                con.TBL_INST.AddOrUpdate(inst);
                con.SaveChanges();
                id = opration.OPRATION_ID;
                return id;
            }
            catch (Exception ex)
            {
                return 0;

            }
        } }
}
    