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
    
    public partial class TBL_OutCome
    {
        public int Id { get; set; }
        public int OutCoualty { get; set; }
        public int Categiry_ID { get; set; }
        public System.DateTime AddedDate { get; set; }
        public string note { get; set; }
    
        public virtual TBL_CATEGORIES TBL_CATEGORIES { get; set; }
    }
}