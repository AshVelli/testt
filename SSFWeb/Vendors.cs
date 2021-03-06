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
    
    public partial class Vendors
    {
        public Vendors()
        {
            this.VendorPayments = new HashSet<VendorPayments>();
        }
    
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<int> StateID { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> PinCode { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string Fax { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string AlternateAddress { get; set; }
        public string AlternatePhoneNo { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> InventoryTypeId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual ICollection<VendorPayments> VendorPayments { get; set; }
    }
}
