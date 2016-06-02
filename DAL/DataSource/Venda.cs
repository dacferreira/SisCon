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
    
    public partial class Venda
    {
        public Venda()
        {
            this.Entregas = new HashSet<Entrega>();
            this.ItemPedidoes = new HashSet<ItemPedido>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public Nullable<double> Desconto { get; set; }
        public double ValorTotal { get; set; }
        public System.DateTime Data { get; set; }
        public Nullable<double> Dinheiro { get; set; }
        public Nullable<double> Debito { get; set; }
        public Nullable<double> Credito { get; set; }
        public Nullable<int> QtdParcela { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Entrega> Entregas { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<ItemPedido> ItemPedidoes { get; set; }
    }
}