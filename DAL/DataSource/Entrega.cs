//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.DataSource
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entrega
    {
        public int Id { get; set; }
        public int IdVenda { get; set; }
        public System.DateTime DataEntrega { get; set; }
        public string Status { get; set; }
    
        public virtual Venda Venda { get; set; }
    }
}
