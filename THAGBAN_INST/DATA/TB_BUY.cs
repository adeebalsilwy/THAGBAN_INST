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
    
    public partial class TB_BUY
    {
        public int ID { get; set; }
        public Nullable<int> ID_Catgeory { get; set; }
        public Nullable<int> ID_Supplier { get; set; }
        public string Name { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> SupplierPyment { get; set; }
        public Nullable<double> BuyPrice { get; set; }
        public Nullable<double> BuyAllValue { get; set; }
        public Nullable<System.DateTime> DateAdd { get; set; }
        public string Description { get; set; }
    
        public virtual TBL_CATEGORIES TBL_CATEGORIES { get; set; }
        public virtual TBL_SUPPLIERS TBL_SUPPLIERS { get; set; }
    }
}
