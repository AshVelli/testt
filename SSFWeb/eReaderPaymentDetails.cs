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
    
    public partial class eReaderPaymentDetails
    {
        public int eReaderPaymentDetailId { get; set; }
        public Nullable<int> eReaderSubscriptionDetailId { get; set; }
        public Nullable<System.DateTime> DateOfRegistration { get; set; }
        public Nullable<int> NoOfMonths { get; set; }
        public string TransactionId { get; set; }
        public string PaymentStatus { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string MIHPayId { get; set; }
        public Nullable<decimal> TotalSubscriptionAmount { get; set; }
    
        public virtual eReaderSubscriptionDetails eReaderSubscriptionDetails { get; set; }
    }
}