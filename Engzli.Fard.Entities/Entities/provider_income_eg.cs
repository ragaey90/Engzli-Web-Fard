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
    
    public partial class provider_income_eg
    {
        public int id { get; set; }
        public Nullable<int> fid { get; set; }
        public string income_eg_des { get; set; }
        public string income_eg_rentprice { get; set; }
        public string income_eg_pay { get; set; }
    
        public virtual provider provider { get; set; }
    }
}
