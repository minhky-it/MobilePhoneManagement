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
    
    public partial class DetailReceipt
    {
        public string billID { get; set; }
        public string productID { get; set; }
        public Nullable<int> quantity { get; set; }
    
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
