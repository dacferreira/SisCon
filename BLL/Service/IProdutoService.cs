using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;

namespace BLL.Service
{
    public interface IProdutoService
    {
        bool Salvar(string Descricao, string Marca, double PrecoCompra, double PrecoVenda, double MargemLucro, string Localizacao, double EstoqueAtual, int codigo);

        ProdutoModel GetProdutoById(int id);

        List<ProdutoModel> ObterProdutos(string nome, int situacao, string filtro);

        bool Excluir(int codigo);
    }
}
