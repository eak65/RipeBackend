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
    
    public partial class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Review { get; set; }
        public int FoodItemId { get; set; }
        public int UserUserId { get; set; }
    
        public virtual FoodItem FoodItem { get; set; }
        public virtual User User { get; set; }
    }
}
