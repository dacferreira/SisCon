using DAL.DataSource;
using DAL.Persistence;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class VendaService : IVendaService
    {
        public bool Salvar(List<DTO.Models.ItemConsultarProdutoModelVenda> listaVenda, DTO.Models.ItemConsultarClienteModel clienteModel, double? ValorPago,
            double? TotalVenda, double? Dinheiro, double? Debito, double? Credito, UsuarioModel user, int quantidadeParcela,double? ValorDesconto)
        {
            return new VendaDAL().Salvar(listaVenda, clienteModel, ValorPago, TotalVenda, Dinheiro, Debito, Credito, user, quantidadeParcela, ValorDesconto);
        }

        public List<ItemConsultarProdutoVenda> ObterTodos(int? codigoVenda)
        {
            return new VendaDAL().ObterTodos(codigoVenda);
        }

        public bool SalvarDevolucao(int codigoItemPedido, double quantidade,DateTime data,int codigoProduto)
        {
            return new VendaDAL().SalvarDevolucao(codigoItemPedido, quantidade, data, codigoProduto);
        }

        public List<IVendaModel> GetAll()
        {
            return new VendaDAL().GetAll();
        }

        public List<IVendaDevolucaoModel> GetAllDevolucoes()
        {
            return new VendaDAL().GetAllDevolucoes();
        }
    }
}
