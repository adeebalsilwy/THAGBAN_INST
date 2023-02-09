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
using System.Configuration;
using System.IO;
using THAGBAN_INST.DATA;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace THAGBAN_INST.FORM
{
    public partial class frm_setting : DevExpress.XtraEditors.XtraForm
    {
        string connect_str = "";
        string server_name = @".\sqlexpress";
        adl.method methods = new adl.method();
        public int inst_id = 0;
        public string inst_name;
        public string inst_location;
        public string inst_desc;
        db_max_instEntities con =new  db_max_instEntities();
        TBL_INST inst = new TBL_INST();
        public frm_setting()
        {
            InitializeComponent();
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)

        {
            const string qu="\"";
            var connect_strring = @"metadata=res://*/DATA.Model1.csdl|res://*/DATA.Model1.ssdl|res://*/DATA.Model1.msl;provider=System.Data.SqlClient;provider connection string="+ qu + ";data source="+ server_name + ";initial catalog=db_max_inst;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework"+ qu + ";";
            var conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            conf.ConnectionStrings.ConnectionStrings["db_max_instEntities"].ConnectionString = connect_strring;
            conf.Save();
            ConfigurationManager.RefreshSection("connectionString");
            var str = conf.ConnectionStrings.ConnectionStrings["db_max_instEntities"].ConnectionString;
            MessageBox.Show(str);
            Application.Restart();
        }


        private void btn_save_inst_Click(object sender, EventArgs e)
        {
            if (txt_inst_name.Text != "" && txt_inst_location.Text != "" && txt_inst_desc.Text != "")
            {
                pic_logo.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                inst.INST_LOCATION = txt_inst_location.Text;
                inst.INST_LOGO = methods.convert_byte();
                inst.INST_DESC = txt_inst_desc.Text;
                inst.INST_NAME = txt_inst_name.Text;
                if (inst_id == 0)
                {
                    
                    con.TBL_INST.Add(inst);
                    con.SaveChanges();
                    tost tos = new tost();
                    tos.lbl_mess.Text = "تمت الاضافه بنجاح ";
                    tos.Show();
                    get_data();

                }
                else
                {
                    inst.INST_ID = inst_id;
                    con.TBL_INST.AddOrUpdate(inst);
                    con.SaveChanges();
                    tost tos = new tost();
                    tos.lbl_mess.Text = "تمت التعديل  بنجاح ";
                    tos.Show();
                    get_data();

                }
            }
        }
        public List<TBL_INST> list;
       void get_data()

        { 
            TBL_INST obj_inst = new TBL_INST();

            db_max_instEntities con = new db_max_instEntities();
            //con.TBL_INST.LoadAsync().ContinueWith(loadTask =>
            //{
            //    list = con.TBL_INST.ToList();
            //}, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            list = con.TBL_INST.ToList();
            if (list!=null && list.Count>0)
            {
                txt_inst_desc.Text = list.FirstOrDefault().INST_DESC.ToString();
                txt_inst_location.Text = list.FirstOrDefault().INST_LOCATION.ToString();
                txt_inst_name.Text = list.FirstOrDefault().INST_NAME.ToString();
                inst_id = list.FirstOrDefault().INST_ID;
                methods.data = list.FirstOrDefault().INST_LOGO;
                if(methods.data!=null)
                pic_logo.Image = Image.FromStream(methods.convert_image());

            }
        }
        private void frm_setting_Load(object sender, EventArgs e)
        {

            get_data();
            
        }

        private void btn_groups_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage2;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage1;
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage4;
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage3;
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    db_max_instEntities db = new db_max_instEntities();
                    string dbname = db.Database.Connection.Database;
                    string dbBackUp = "EPSback" + DateTime.Now.ToString("yyyyMMddHHmm");
                    var fullpath = folder.SelectedPath.ToString() + dbBackUp + ".bak";
                    string sqlCommand = @"BACKUP DATABASE [{0}] TO  DISK = '" + fullpath + "' WITH NOFORMAT, NOINIT,  NAME = N'DBEPS', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, dbBackUp));
                    MessageBox.Show("تم النسخ الاحتياطي بنجاح");
                }
            }
            catch
            {
                MessageBox.Show("خطأ , لا يمكن النسخ الاحتياطي الى المسار المحدد, الرجاء تحديد مسار مختلف, تذكر لا تحدد القرص C");
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog folder = new OpenFileDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    db_max_instEntities db = new db_max_instEntities();

                    string dbname = db.Database.Connection.Database;
                    string dbBackUp = "EPSback" + DateTime.Now.ToString("yyyyMMddHHmm");
                    string sqlCommand = @"Use master;Restore DATABASE [{0}] From  DISK = '" + folder.FileName + "'";
                    int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname));
                    MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن استعادة النسخة الاحتياطية, يرجى التأكد من الملف المختار" + ex.Message.ToString());
            }
        }

        private void pic_logo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void navigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdb_inter_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}