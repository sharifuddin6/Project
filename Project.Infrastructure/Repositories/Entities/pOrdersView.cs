//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Infrastructure.Repositories.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class pOrdersView
    {
        public int Id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string Email { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string Code { get; set; }
        public Nullable<double> Value { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> Total { get; set; }
    }
}
