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
    
    public partial class Couriers
    {
        public Couriers()
        {
            this.UserOrders = new HashSet<UserOrders>();
        }
    
        public int CourierId { get; set; }
        public string CourierName { get; set; }
        public Nullable<decimal> Charges { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual ICollection<UserOrders> UserOrders { get; set; }
    }
}
