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
    
    public partial class usersmg
    {
        public int id { get; set; }
        public Nullable<int> fid { get; set; }
        public string name { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public int role { get; set; }
        public int active { get; set; }
        public string hint { get; set; }
    
        public virtual user user1 { get; set; }
    }
}
