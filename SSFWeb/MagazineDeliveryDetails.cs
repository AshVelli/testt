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
    
    public partial class MagazineDeliveryDetails
    {
        public int DeliveryId { get; set; }
        public Nullable<int> SubscriberId { get; set; }
        public Nullable<System.DateTime> SentDate { get; set; }
    
        public virtual Subscribers Subscribers { get; set; }
    }
}