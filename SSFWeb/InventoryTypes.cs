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
    
    public partial class InventoryTypes
    {
        public InventoryTypes()
        {
            this.Inventory = new HashSet<Inventory>();
            this.InventoryCategories = new HashSet<InventoryCategories>();
        }
    
        public int InventoryTypeId { get; set; }
        public string InventoryType { get; set; }
    
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<InventoryCategories> InventoryCategories { get; set; }
    }
}
