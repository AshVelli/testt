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
    
    public partial class TempShippingAddress
    {
        public int TempAddressId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Address { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public string City { get; set; }
        public Nullable<int> PinCode { get; set; }
        public string MobileNo { get; set; }
    
        public virtual Districts Districts { get; set; }
        public virtual States States { get; set; }
        public virtual Users Users { get; set; }
    }
}
