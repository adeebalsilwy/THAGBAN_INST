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
    
    public partial class TBL_INST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_INST()
        {
            this.TBL_BOX = new HashSet<TBL_BOX>();
            this.TBL_LEVLE = new HashSet<TBL_LEVLE>();
        }
    
        public int INST_ID { get; set; }
        public string INST_NAME { get; set; }
        public string INST_DESC { get; set; }
        public string INST_LOCATION { get; set; }
        public byte[] INST_LOGO { get; set; }
        public string NOTE { get; set; }
        public string INST_ADMIN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_BOX> TBL_BOX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_LEVLE> TBL_LEVLE { get; set; }
    }
}