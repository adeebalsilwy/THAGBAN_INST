using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using THAGBAN_INST.DATA;
using System.Data.Entity;

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
      
    }
}
    