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
    
    public partial class TBL_STUD_SPEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_STUD_SPEC()
        {
            this.TBL_SEND_STUD__COURS = new HashSet<TBL_SEND_STUD__COURS>();
        }
    
        public int STUD_SPEC_ID { get; set; }
        public Nullable<int> STUD_ID { get; set; }
        public Nullable<int> SPEC_ID { get; set; }
        public System.DateTime STUD_SPEC_YEAR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SEND_STUD__COURS> TBL_SEND_STUD__COURS { get; set; }
        public virtual TBL_SPECIAL TBL_SPECIAL { get; set; }
        public virtual TBL_STUDENTS TBL_STUDENTS { get; set; }
    }
}
