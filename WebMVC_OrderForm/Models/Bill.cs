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
    
    public partial class Bill
    {
        public Bill()
        {
            this.DetailReceipts = new HashSet<DetailReceipt>();
        }
    
        public string billID { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string fullname { get; set; }
    
        public virtual ICollection<DetailReceipt> DetailReceipts { get; set; }
    }
}
