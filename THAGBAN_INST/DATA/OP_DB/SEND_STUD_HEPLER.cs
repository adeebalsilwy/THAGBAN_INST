using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace THAGBAN_INST.DATA.OP_DB
{
    public class SEND_STUD_HEPLER : IDataHelper<TBL_SEND_STUD__COURS>
    {
        db_max_instEntities db = new db_max_instEntities();
        public int Add(TBL_SEND_STUD__COURS table)
        {
            try
            {

                db.TBL_SEND_STUD__COURS.Add(table);
                db.SaveChanges();
                return 1;


            }
            catch
            {
                return 0;
            }
        }


        public int Delete(int Id)
        {
            try
            {
               
                   
                  var tbl=  db.TBL_SEND_STUD__COURS.Find(Id);
                db.TBL_SEND_STUD__COURS.Remove(tbl);
                    db.SaveChanges();
                    return 1;
                
               
            }
            catch
            {
                return 0;
            }
        }


        public int Edit(TBL_SEND_STUD__COURS table)
        {
            try
            {
               
                    db = new db_max_instEntities();
                    db.TBL_SEND_STUD__COURS.AddOrUpdate(table);
                    db.SaveChanges();
                    return 1;
               
            }
            catch
            {
                return 0;
            }
        }

        

        
        public async Task<TBL_SEND_STUD__COURS> FindAsync(int Id)
        {
            try
            {
               
            return await Task.Run(() => db.TBL_SEND_STUD__COURS.Where(x => x.SEND_STUD_ID == Id).First());
               
            }
            catch
            {
                return null;
            }
        }

        public List<TBL_SEND_STUD__COURS> GetAllData() => db.TBL_SEND_STUD__COURS.ToList();

        public Task<List<TBL_SEND_STUD__COURS>> GetAllDataAsync() => db.TBL_SEND_STUD__COURS.ToListAsync();

        
    }
}
