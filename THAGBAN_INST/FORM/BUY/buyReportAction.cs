using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using THAGBAN_INST.DATA;

namespace EPS.Report
{
    public partial class buyReportAction : DevExpress.XtraReports.UI.XtraReport
    {
        db_max_instEntities db;
        TB_BUY Sell;
        int ID;
        DateTime StartDate1;
        DateTime EndDate;

        public buyReportAction( int ID, DateTime StartDate, DateTime EndDate)
        {
            
            InitializeComponent();
            this.ID = ID;
            this.StartDate1 = StartDate;
            this.EndDate = EndDate;
            
            LoadData();
            LoadDataForReport();
           SetCompanyDetails();
            SetCurrncyValue();
        }

        private void SetCurrncyValue()
        {
         


        }
        private void LoadDataForReport()
        {
            try
            {
                db = new db_max_instEntities();
                Sell = db.TB_BUY.Where(x => x.ID_Supplier == ID&&
                  DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year, StartDate1.Month, StartDate1.Day, 1, 1, 1)
               && DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1)
                ).FirstOrDefault();
                if (Sell != null)
                {
                    txt_customarname.Text = Sell.TBL_SUPPLIERS.SupplierName.ToString();
                    txt_cridet.Text = db.TB_BUY.Where(x => x.ID_Supplier == ID &&
                  DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year, StartDate1.Month, StartDate1.Day, 1, 1, 1)
                && DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1)).Select(x => x.SupplierPyment).ToArray().Sum().ToString();
  //                  txt_secodcurr.Text = db.TB_BUY.Where(x => x.ID_Supplier == ID &&
  //DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year, StartDate1.Month, StartDate1.Day, 1, 1, 1)

  
                }
            }
            catch { }
        }
            private void LoadData()
            {
            
           
            try
            {
                db = new db_max_instEntities();
                var data1 = db.TB_BUY.Where(x => x.ID_Supplier == ID &&
                DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year,StartDate1.Month,StartDate1.Day,1,1,1)
               && DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1))
 
                    .Select(x => new { x.Name, x.TBL_CATEGORIES.CatName, x.TBL_SUPPLIERS.SupplierName, x.SupplierPyment,x.DateAdd}).ToList();              
                    gridControl1.DataSource = data1;
                }
                catch
            { 
                
            }
            }


            private void SetCompanyDetails()
        {
          int  inst_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
            txt_companyname.Text = db.TBL_INST.Find(inst_id).INST_NAME;
            txt_companydescription.Text = db.TBL_INST.Find(inst_id).INST_DESC;
            txt_currancy.Text = "ريال";
           
            // Set picture after set it from settings
            try
            {
                byte[] imgebyte =db.TBL_INST.Find(inst_id).INST_LOGO;

                if (imgebyte != null)
                {
                    MemoryStream ma = new MemoryStream(imgebyte);


                    pic_company.Image = Image.FromStream(ma);
                }
               
            }
            catch
            {

            }
           

        }

        private void buyReportAction_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {
           
        }
    }

    
}
