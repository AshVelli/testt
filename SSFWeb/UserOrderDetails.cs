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
    
    public partial class UserOrderDetails
    {
        public int UserOrderDetailId { get; set; }
        public Nullable<int> InventoryId { get; set; }
        public Nullable<int> UserOrderId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual UserOrders UserOrders { get; set; }
    }
}
