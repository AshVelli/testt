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
    
    public partial class getRequestStockById_Result
    {
        public int InventoryRequestId { get; set; }
        public Nullable<int> DistributorOrDealerId { get; set; }
        public string DistributorOrDealerName { get; set; }
        public string UserType { get; set; }
        public string RequestedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> NetAmount { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public Nullable<decimal> Balance { get; set; }
    }
}
