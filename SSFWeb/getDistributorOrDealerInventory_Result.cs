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
    
    public partial class getDistributorOrDealerInventory_Result
    {
        public Nullable<int> InventoryId { get; set; }
        public string InventoryName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> SaleQuantity { get; set; }
        public Nullable<int> ReturnCount { get; set; }
        public Nullable<int> DamagedCount { get; set; }
        public Nullable<int> AvailableQuantity { get; set; }
        public string IsPackage { get; set; }
        public string DealerReturns { get; set; }
        public string DealerDamageCount { get; set; }
        public Nullable<int> AssignedToPackage { get; set; }
    }
}
