//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyApp_HiepBui
{
    using System;
    using System.Collections.Generic;
    
    public partial class TYPE_OF_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TYPE_OF_USER()
        {
            this.EMPLOYEES = new HashSet<EMPLOYEE>();
        }
    
        public string IDTypeUser { get; set; }
        public string NameTypeOfUser { get; set; }
        public string IDAuthority { get; set; }
    
        public virtual AUTHORITY AUTHORITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEE> EMPLOYEES { get; set; }
    }
}
