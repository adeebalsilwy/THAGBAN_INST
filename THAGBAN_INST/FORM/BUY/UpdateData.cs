using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;

namespace EPS.BL
{
    public class UpdateData
    {

        private double TotalValue1;
        private double TotalValue2;






        public void UpdateSuppliersData()
        {
            try
            {

                db_max_instEntities db = new db_max_instEntities();
                // Add Supplier Value
                TBL_SUPPLIERS suppliers = new TBL_SUPPLIERS();
                var idsupplierlist = db.TBL_SUPPLIERS.Select(x => x.ID).ToList();

                for (int i = 0; i < idsupplierlist.Count; i++)
                {
                    var id = idsupplierlist[i];
                    suppliers = db.TBL_SUPPLIERS.Where(x => x.ID == id).FirstOrDefault();

                    if (suppliers != null)
                    {
                        TotalValue1 = (double)db.TB_BUY.Where(x => x.ID_Supplier == id).Select(x => x.SupplierPyment).ToArray().Sum();
                        if (TotalValue1 != null || TotalValue2 != null)
                        {
                            suppliers.SupplierBalance = TotalValue1;
                            suppliers.SupplierBalancePrim = Convert.ToDouble(TotalValue2.ToString("#0.00"));

                            db.Set<TBL_SUPPLIERS>().AddOrUpdate(suppliers);
                            db.SaveChanges();

                        }
                    }






                }



            }
            catch
            {
            }
        }








    }
}
