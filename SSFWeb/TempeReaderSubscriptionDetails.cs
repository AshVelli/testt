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
    
    public partial class TempeReaderSubscriptionDetails
    {
        public int TempEReaderSubscriptionDetailId { get; set; }
        public Nullable<int> SubscriberId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> eBookId { get; set; }
        public Nullable<System.DateTime> DateOfRegistration { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<int> NoOfMonths { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> TotalSubscriptionAmount { get; set; }
        public Nullable<bool> IsPaymentSuccess { get; set; }
    
        public virtual eBooks eBooks { get; set; }
        public virtual Subscribers Subscribers { get; set; }
        public virtual Users Users { get; set; }
    }
}
