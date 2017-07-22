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
    
    public partial class SubscriptionDetails
    {
        public int SubscriptionDetailId { get; set; }
        public Nullable<int> SubscriberId { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<int> NoOfMonths { get; set; }
        public Nullable<int> NoOfMagazines { get; set; }
        public Nullable<System.DateTime> DateOfRegistration { get; set; }
        public string TransactionId { get; set; }
        public string PaymentStatus { get; set; }
        public string MIHPayId { get; set; }
        public Nullable<int> NoOfSubscriptions { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual Subscribers Subscribers { get; set; }
        public virtual SubscriptionType SubscriptionType { get; set; }
    }
}