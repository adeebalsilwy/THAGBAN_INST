//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace THAGBAN_INST.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_HOLIDAYS
    {
        public int HOLIDAY_ID { get; set; }
        public int HOLIDAY_TYPE_ID { get; set; }
        public System.DateTime HOLIDAY_START { get; set; }
        public System.DateTime HOLIDAY_END { get; set; }
        public int HOLIDAY_N_DAY { get; set; }
        public int EMP_ID { get; set; }
        public string NOTE { get; set; }
    
        public virtual TBL_EMPLOYEES TBL_EMPLOYEES { get; set; }
        public virtual TBL_HOLIDAY_TYPE TBL_HOLIDAY_TYPE { get; set; }
    }
}
