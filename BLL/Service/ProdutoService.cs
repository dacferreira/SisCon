using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Persistence;
using DTO.Models;

namespace BLL.Service
{
    public class ProdutoService : IProdutoService
    {
        public bool Salvar(string Descricao, string Marca, double PrecoCompra, double PrecoVenda, double MargemLucro, string Localizacao, double EstoqueAtual, int codigo)
        {
            return new ProdutoDAL().Salvar(Descricao, Marca, PrecoCompra, PrecoVenda, MargemLucro, Localizacao, EstoqueAtual, codigo);
        }
        
        public ProdutoModel GetProdutoById(int id)
        {
            return new ProdutoDAL().GetProdutoById(id);
        }

        public List<ProdutoModel> ObterProdutos(string nome, int situacao, string filtro)//Método usuado na Pesquisa de usuário, retorna os usuarios pesquisados
        {
            List<ProdutoModel> lista = new ProdutoDAL().ObterTodos();
            List<ProdutoModel> novalista = new List<ProdutoModel>();
            if (situacao != 2)
            {
                if (filtro == "Descrição")
                    novalista = lista.Where(p => p.Descricao.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

                else
                    novalista = lista.Where(p => p.Localizacao.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
            }
            else
            {
                if (situacao == 2)
                {
                    if (filtro == "Descrição")
                        novalista = lista.Where(p => p.Descricao.ToLower().Contains(nome.ToLower())).ToList();

                    else
                        novalista = lista.Where(p => p.Localizacao.ToLower().Contains(nome.ToLower())).ToList();
                }
                else
                {
                    if (filtro == "Descrição")
                        novalista = lista.Where(p => p.Descricao.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

                    else
                        novalista = lista.Where(p => p.Localizacao.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
                }
            }
            return novalista;
        }

        public bool Excluir(int codigo)
        {
            return new ProdutoDAL().Excluir(codigo);
        }

        public bool Ativar(int codigo)
        {
            return new ProdutoDAL().Ativar(codigo);
        }

        public bool ExisteNome(string Descricao)
        {
            ProdutoModel novalista = new ProdutoModel();
            var produtos = new ProdutoDAL().ObterTodos();
            novalista = produtos.Where(p => p.Descricao.Equals(Descricao)).FirstOrDefault();
            if (novalista != null)
                return true;
            else
                return false;
        }

        public bool ExisteMarca(string Marca)
        {
            ProdutoModel novalista = new ProdutoModel();
            var produtos = new ProdutoDAL().ObterTodos();
            novalista = produtos.Where(p => p.Marca.Equals(Marca)).FirstOrDefault();
            if (novalista != null)
                return true;
            else
                return false;
        }
    }
}
