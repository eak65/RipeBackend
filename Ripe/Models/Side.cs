//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ripe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Side
    {
        public Side()
        {
            this.MenuSections = new HashSet<MenuSection>();
        }
    
        public int Id { get; set; }
    
        public virtual ICollection<MenuSection> MenuSections { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
