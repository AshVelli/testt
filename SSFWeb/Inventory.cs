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
    
    public partial class Inventory
    {
        public Inventory()
        {
            this.DistributorInventoryMovementDetails = new HashSet<DistributorInventoryMovementDetails>();
            this.eBooks = new HashSet<eBooks>();
            this.InventorySales = new HashSet<InventorySales>();
            this.UserComments = new HashSet<UserComments>();
        }
    
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public Nullable<decimal> InventoryPrice { get; set; }
        public Nullable<int> InventoryTypeId { get; set; }
        public Nullable<int> InventoryCategoryId { get; set; }
        public string InventoryImage { get; set; }
        public string ShotDescription { get; set; }
        public string LongDescription { get; set; }
        public Nullable<int> FirstPrintedYear { get; set; }
        public Nullable<int> RePrintedYear { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string DvdOrCd { get; set; }
        public string MediaType { get; set; }
        public string MediaFile { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string Author { get; set; }
    
        public virtual ICollection<DistributorInventoryMovementDetails> DistributorInventoryMovementDetails { get; set; }
        public virtual ICollection<eBooks> eBooks { get; set; }
        public virtual InventoryCategories InventoryCategories { get; set; }
        public virtual InventoryTypes InventoryTypes { get; set; }
        public virtual ICollection<InventorySales> InventorySales { get; set; }
        public virtual ICollection<UserComments> UserComments { get; set; }
    }
}