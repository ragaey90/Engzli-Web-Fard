//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Engzli.Fard.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class provider_residence
    {
        public int id { get; set; }
        public Nullable<int> fid { get; set; }
        public string residence_city { get; set; }
        public string residence_neighborhood { get; set; }
        public string residence_fulladdress { get; set; }
        public string residence_nationality { get; set; }
        public string residence_insy { get; set; }
    
        public virtual provider provider { get; set; }
    }
}
