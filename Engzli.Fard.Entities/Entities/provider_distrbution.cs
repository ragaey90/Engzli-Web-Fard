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
    
    public partial class provider_distrbution
    {
        public int id { get; set; }
        public int fid { get; set; }
        public int rv { get; set; }
        public int finance { get; set; }
        public string medical { get; set; }
        public string furniture { get; set; }
        public string other { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string note { get; set; }
    
        public virtual provider provider { get; set; }
    }
}