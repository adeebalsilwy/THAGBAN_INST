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
    
    public partial class TBL_USERS
    {
        public int USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_PASS { get; set; }
        public int EMP_ID { get; set; }
    
        public virtual TBL_EMPLOYEES TBL_EMPLOYEES { get; set; }
    }
}