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
    
    public partial class ITEM_IN_ORDER
    {
        public string IDItemInOrder { get; set; }
        public string IDItem { get; set; }
        public string IDOrder { get; set; }
        public int NumberItem { get; set; }
    
        public virtual ITEM ITEM { get; set; }
        public virtual ORDER ORDER { get; set; }
    }
}
