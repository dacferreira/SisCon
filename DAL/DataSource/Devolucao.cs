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
    
    public partial class Devolucao
    {
        public Devolucao()
        {
            this.ItemDevolucaos = new HashSet<ItemDevolucao>();
        }
    
        public int Id { get; set; }
        public System.DateTime Data { get; set; }
        public int IdItemPedido { get; set; }
    
        public virtual ICollection<ItemDevolucao> ItemDevolucaos { get; set; }
        public virtual ItemPedido ItemPedido { get; set; }
    }
}
