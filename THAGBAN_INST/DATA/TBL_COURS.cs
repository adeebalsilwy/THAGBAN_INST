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
    
    public partial class TBL_COURS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_COURS()
        {
            this.TBL_MARKS = new HashSet<TBL_MARKS>();
            this.TBL_SPE_COURS = new HashSet<TBL_SPE_COURS>();
            this.TBL_STUD_STUDY_COURS = new HashSet<TBL_STUD_STUDY_COURS>();
        }
    
        public int COURS_ID { get; set; }
        public string COURS_NAME { get; set; }
        public string COURS_DESC { get; set; }
        public Nullable<int> NUMBER_HOURS { get; set; }
        public Nullable<int> MIN_MARK { get; set; }
        public Nullable<int> MAX_MARK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_MARKS> TBL_MARKS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SPE_COURS> TBL_SPE_COURS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_STUD_STUDY_COURS> TBL_STUD_STUDY_COURS { get; set; }
    }
}
