//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSFWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubscriptionType
    {
        public SubscriptionType()
        {
            this.SubscriptionAmount = new HashSet<SubscriptionAmount>();
            this.SubscriptionDetails = new HashSet<SubscriptionDetails>();
            this.TempSubscriptionDetails = new HashSet<TempSubscriptionDetails>();
        }
    
        public int TypeId { get; set; }
        public string Type { get; set; }
        public Nullable<int> NoOfMagazines { get; set; }
        public Nullable<int> NoOfYears { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ReleaseDay { get; set; }
    
        public virtual ICollection<SubscriptionAmount> SubscriptionAmount { get; set; }
        public virtual ICollection<SubscriptionDetails> SubscriptionDetails { get; set; }
        public virtual ICollection<TempSubscriptionDetails> TempSubscriptionDetails { get; set; }
    }
}
