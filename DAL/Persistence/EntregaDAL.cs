using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;
using DAL.DataSource;
using System.Data;

namespace DAL.Persistence
{
    public class EntregaDAL
    {
        ProjetoFinalEntities entidade = new ProjetoFinalEntities();

        public List<EntregaModel> ObterTodos()
        {
            var listaentrega = new List<EntregaModel>();

            var listaEntrega = entidade.Entregas.ToList();
            var listaVenda = entidade.Vendas.ToList();

            if (listaEntrega.Any())
            {
                foreach (var item in listaEntrega)
                {
                    var entrega = new EntregaModel();
                    entrega.Codigo = item.Id;
                    entrega.Credito = item.Venda.Credito;
                    entrega.DataCompra = item.Venda.Data;
                    entrega.DataEntrega = item.DataEntrega;
                    entrega.Debito = item.Venda.Debito;
                    entrega.Desconto = item.Venda.Desconto;
                    entrega.Dinheiro = item.Venda.Dinheiro;
                    entrega.idVenda = item.Venda.Id;
                    entrega.idCliente = item.Venda.IdCliente;
                    entrega.idUsuario = item.Venda.IdUsuario;
                    entrega.QuantidadeParcela = item.Venda.QtdParcela;
                    entrega.Status = item.Status;
                    entrega.ValorTotal = item.Venda.ValorTotal;
                    listaentrega.Add(entrega);
                }
            }

            return listaentrega;
        }

        public bool ConfirmaEntrega(ItemEntregaModel itemEntrega)
        {
            Entrega entrega = new Entrega();

            try
            {
                var listaEntrega = entidade.Entregas.ToList();

                entrega = listaEntrega.Where(p => p.Id == itemEntrega.Codigo.Value).FirstOrDefault();
                entrega.DataEntrega = itemEntrega.DataEntrega;
                entrega.Status = itemEntrega.Status;

                entidade.Entregas.Attach(entrega);
                entidade.Entry(entrega).State = EntityState.Modified;
                entidade.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<ItemConsultarEntregaModel> ObterTodosItens(int idVenda)
        {
            List<ItemConsultarEntregaModel> listaitemConsulta = new List<ItemConsultarEntregaModel>();
            var listaPedidos = entidade.ItemPedidoes.ToList();
            var listaProdutos = entidade.Produtos.ToList();
            var listaEntrega = entidade.Entregas.ToList();

            var result = (from w in listaEntrega
                          join e in listaPedidos on w.IdVenda equals e.IdVenda where e.IdVenda.Equals(idVenda)
                          join f in listaProdutos on e.IdProduto equals f.Id
                          select e);

            if (result.Any())
            {
                foreach (var item in result.Where(p => p.Entrega))
                {
                    ItemConsultarEntregaModel itemConsulta = new ItemConsultarEntregaModel();
                    itemConsulta.Codigo = item.IdProduto;
                    itemConsulta.Descricao = item.Produto.Descricao;
                    itemConsulta.Quantidade = item.Quantidade;
                    itemConsulta.Marca = item.Produto.Marca;
                    listaitemConsulta.Add(itemConsulta);
                }
            }

            return listaitemConsulta;
        }
    }
}
