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
    
    public partial class provider_passport
    {
        public int id { get; set; }
        public Nullable<int> fid { get; set; }
        public string passport_id { get; set; }
        public int passport_gender { get; set; }
        public string passport_nationality { get; set; }
        public string passport_birthplace { get; set; }
        public Nullable<System.DateTime> passport_birthdate { get; set; }
        public string passport_issueplace { get; set; }
        public Nullable<System.DateTime> passport_issuedate { get; set; }
        public Nullable<System.DateTime> passport_expiredate { get; set; }
        public Nullable<System.DateTime> passport_outofsy_date { get; set; }
        public Nullable<System.DateTime> passport_intoeg_date { get; set; }
        public string passport_in_port { get; set; }
        public string passport_out_port { get; set; }
    
        public virtual provider provider { get; set; }
    }
}
