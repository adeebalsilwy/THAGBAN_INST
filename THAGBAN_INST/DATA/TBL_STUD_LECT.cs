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
    
    public partial class TBL_STUD_LECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_STUD_LECT()
        {
            this.TBL_LECT_MARK = new HashSet<TBL_LECT_MARK>();
        }
    
        public int LECT_STUD_ID { get; set; }
        public Nullable<int> LECT_ID { get; set; }
        public Nullable<int> STUD_ID { get; set; }
        public Nullable<int> LECT_TECH_ID { get; set; }
        public Nullable<int> COURS_ID { get; set; }
        public Nullable<System.DateTime> LECT_STUD_DATE { get; set; }
    
        public virtual TBL_LECT_COURS TBL_LECT_COURS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_LECT_MARK> TBL_LECT_MARK { get; set; }
        public virtual TBL_LECT_TECH_COURS TBL_LECT_TECH_COURS { get; set; }
        public virtual TBL_LECTUER TBL_LECTUER { get; set; }
        public virtual TBL_STUDENTS TBL_STUDENTS { get; set; }
    }
}
