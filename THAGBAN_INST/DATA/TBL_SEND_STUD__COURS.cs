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
    
    public partial class TBL_SEND_STUD__COURS
    {
        public int SEND_STUD_ID { get; set; }
        public Nullable<int> STUD_ID { get; set; }
        public Nullable<int> PAID_UP { get; set; }
        public Nullable<int> REST { get; set; }
        public Nullable<System.DateTime> SEND_STUD_DATE { get; set; }
        public Nullable<int> OPRATIN_ID { get; set; }
        public Nullable<int> STUD_SPEC_ID { get; set; }
        public Nullable<bool> SEND_STATE_BANK { get; set; }
    
        public virtual TBL_OPRATION TBL_OPRATION { get; set; }
        public virtual TBL_STUD_SPEC TBL_STUD_SPEC { get; set; }
        public virtual TBL_STUDENTS TBL_STUDENTS { get; set; }
    }
}
