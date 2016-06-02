using DAL.DataSource;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public interface IVendaService
    {
        bool Salvar(List<DTO.Models.ItemConsultarProdutoModelVenda> listaVenda, DTO.Models.ItemConsultarClienteModel clienteModel, double? ValorPago, double? TotalVenda,
            double? Dinheiro, double? Debito, double? Credito, UsuarioModel user, int quantidadeParcela, double? ValorDesconto);

        List<ItemConsultarProdutoVenda> ObterTodos(int? codigoVenda);

        bool SalvarDevolucao(int codigoItemPedido, double quantidade, DateTime data, int codigoProduto);

        List<IVendaModel> GetAll();

        List<IVendaDevolucaoModel> GetAllDevolucoes();
    }
}
