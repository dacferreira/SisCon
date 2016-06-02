using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSource;
using DTO.Models;

namespace DAL.Persistence
{
    public class ProdutoDAL
    {
        ProjetoFinalEntities entidade = new ProjetoFinalEntities();

        public List<ProdutoModel> ObterTodos()
        {
            var listaProduto = new List<ProdutoModel>();

            var lista = entidade.Produtos.ToList();
            if (lista != null && lista.Any())
                foreach (var item in lista)
                {
                    var produto = new ProdutoModel();

                    produto.Codigo = item.Id;
                    produto.Descricao = item.Descricao;
                    produto.Marca = item.Marca;
                    produto.PrecoCompra = item.PrecoCompra;
                    produto.PrecoVenda = item.PrecoVenda;
                    produto.MargemLucro = item.MargemLucro;
                    produto.Localizacao = item.Localizacao;
                    produto.SaldoAtual = item.SaldoAtual;
                    produto.Situacao = item.Situacao;
                    listaProduto.Add(produto);
                }
            return listaProduto;
        }

        public bool Salvar(string Descricao, string Marca, double PrecoCompra, double PrecoVenda, double MargemLucro, string Localizacao, double EstoqueAtual, int codigo)
        {
            Produto produto = new Produto();

            try
            {
                produto.Descricao = Descricao;
                produto.Marca = Marca;
                produto.PrecoCompra = PrecoCompra;
                produto.PrecoVenda = PrecoVenda;
                produto.MargemLucro = MargemLucro;
                produto.Localizacao = Localizacao;
                produto.SaldoAtual = Convert.ToInt32(EstoqueAtual);
                produto.Situacao = true;

                if (codigo == 0)
                    entidade.Produtos.Add(produto);
                else
                {
                    produto.Id = codigo;
                    entidade.Produtos.Attach(produto);
                    entidade.Entry(produto).State = EntityState.Modified;
                }
                entidade.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ProdutoModel GetProdutoById(int id)
        {
            ProdutoModel produtoModel = new ProdutoModel();
            var produto = entidade.Produtos.Where(p => p.Id == id).FirstOrDefault();
            if (produto != null)
            {
                produtoModel.Descricao = produto.Descricao;
                produtoModel.PrecoCompra = produto.PrecoCompra;
                produtoModel.PrecoVenda = produto.PrecoVenda;
                produtoModel.MargemLucro = produto.MargemLucro;
                produtoModel.Localizacao = produto.Localizacao;
                produtoModel.SaldoAtual = produto.SaldoAtual;
                produtoModel.Marca = produto.Marca;
                produtoModel.Situacao = produto.Situacao;
            }

            return produtoModel;
        }

        public bool Excluir(int codigo)
        {
            try
            {
                var produto = entidade.Produtos.Where(p => p.Id == codigo).FirstOrDefault();
                produto.Id = codigo;
                produto.Situacao = false;
                entidade.Produtos.Attach(produto);
                entidade.Entry(produto).State = EntityState.Modified;
                entidade.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Ativar(int codigo)
        {
            try
            {
                var produto = entidade.Produtos.Where(p => p.Id == codigo).FirstOrDefault();
                produto.Id = codigo;
                produto.Situacao = true;
                entidade.Produtos.Attach(produto);
                entidade.Entry(produto).State = EntityState.Modified;
                entidade.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
