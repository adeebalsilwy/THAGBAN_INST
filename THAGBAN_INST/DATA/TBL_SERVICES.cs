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
    
    public partial class TBL_SERVICES
    {
        public int SERVICE_ID { get; set; }
        public string SERVICE_NAME { get; set; }
        public string COUSTOMER_NAME { get; set; }
        public string COUSTOMER_PHONE { get; set; }
        public Nullable<double> SERVICE_PRICE { get; set; }
        public string NOTE { get; set; }
        public Nullable<int> OPRATION_ID { get; set; }
        public Nullable<int> SERVICE_TYPE_ID { get; set; }
    
        public virtual TBL_OPRATION TBL_OPRATION { get; set; }
        public virtual TBL_SERVICE_TYPE TBL_SERVICE_TYPE { get; set; }
    }
}
