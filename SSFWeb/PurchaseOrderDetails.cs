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
    
    public partial class PurchaseOrderDetails
    {
        public int PurchaseOrderDetailId { get; set; }
        public Nullable<int> PurchaseOrderId { get; set; }
        public Nullable<int> InventoryId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> ActualCost { get; set; }
        public Nullable<decimal> SellingPrice { get; set; }
        public string BatchId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> SaleQuantity { get; set; }
        public Nullable<int> PreviousPurchaseOrderId { get; set; }
    
        public virtual PurchaseOrderDetails PurchaseOrderDetails1 { get; set; }
        public virtual PurchaseOrderDetails PurchaseOrderDetails2 { get; set; }
        public virtual PurchaseOrders PurchaseOrders { get; set; }
    }
}
