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
    
    public partial class TBL_SPE_COURS
    {
        public int ID { get; set; }
        public int COURS_ID { get; set; }
        public Nullable<int> TERM_ID { get; set; }
        public Nullable<int> YEAR_ID { get; set; }
        public Nullable<int> SPEC_ID { get; set; }
    
        public virtual TBL_COURS TBL_COURS { get; set; }
        public virtual TBL_SPECIAL TBL_SPECIAL { get; set; }
        public virtual TBL_TERMS TBL_TERMS { get; set; }
        public virtual TBL_YEARS TBL_YEARS { get; set; }
    }
}
