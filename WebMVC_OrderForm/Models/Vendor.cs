//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMVC_OrderForm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vendor
    {
        public Vendor()
        {
            this.DetailOrderForms = new HashSet<DetailOrderForm>();
            this.Products = new HashSet<Product>();
        }
    
        public string vendorID { get; set; }
        public string vendorName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<DetailOrderForm> DetailOrderForms { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
