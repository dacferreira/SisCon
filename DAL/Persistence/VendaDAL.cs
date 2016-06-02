using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;
using DAL.DataSource;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class VendaDAL
    {
        ProjetoFinalEntities entidade = new ProjetoFinalEntities();
        public bool Salvar(List<DTO.Models.ItemConsultarProdutoModelVenda> listaVenda, DTO.Models.ItemConsultarClienteModel clienteModel, double? ValorPago,
            double? TotalVenda, double? Dinheiro, double? Debito, double? Credito, UsuarioModel user, int quantidadeParcela,double? ValorDesconto)
        {
            ItemPedido itemPedido = new ItemPedido();
            List<ItemPedido> listaitemPedido = new List<ItemPedido>();
            
            Venda venda = new Venda();
            Entrega entrega = new Entrega();
            List<Entrega> listaentrega = new List<Entrega>();
            Produto produto = new Produto();
            Cliente cliente = new Cliente();
            Usuario usuario = new Usuario();
            try
            {
                if (clienteModel != null && clienteModel.Codigo != 0)
                {
                    cliente = entidade.Clientes.Where(p => p.Id == clienteModel.Codigo).FirstOrDefault();
                    venda.IdCliente = cliente.Id;

                    entrega.DataEntrega = DateTime.Today.AddDays(1);
                    entrega.Status = "Pendente";
                    listaentrega.Add(entrega);
                }
                double? valorDesconto = default(double?);
                foreach (var item in listaVenda)
                {
                    itemPedido.Quantidade = item.Quantidade;
                    itemPedido.Produto = entidade.Produtos.Where(p => p.Id == item.Codigo).FirstOrDefault();
                    valorDesconto = valorDesconto + item.PrecoVenda;
                    listaitemPedido.Add(itemPedido);
                }

               usuario = entidade.Usuarios.Where(p =>p.Login == user.Login).FirstOrDefault();
               venda.IdUsuario = usuario.Id;
               venda.Desconto = ValorDesconto;
               venda.ValorTotal = TotalVenda.Value;
               venda.Data = DateTime.Now;
               venda.Dinheiro = Dinheiro;
               venda.Debito = Debito;
               venda.Credito = Credito;
               venda.QtdParcela = quantidadeParcela;

               venda.Cliente = cliente;
               venda.Entregas = listaentrega;
               venda.ItemPedidoes = listaitemPedido;
               venda.Usuario = usuario;

                
               SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ProjetoFinal;Integrated Security=True");

               string Descontovalor = Convert.ToString(venda.Desconto.HasValue ? venda.Desconto.Value : default(double));//declara variavel
               Descontovalor = Descontovalor.Replace(".", "");//troca (ponto) por vazio
               Descontovalor = Descontovalor.Replace(",", ".");//troca (virgula) por (ponto)

               DateTime data = venda.Data;

                string ValorTotalvalor = Convert.ToString(venda.ValorTotal);//declara variavel
               ValorTotalvalor = ValorTotalvalor.Replace(".", "");//troca (ponto) por vazio
               ValorTotalvalor = ValorTotalvalor.Replace(",", ".");//troca (virgula) por (ponto)


               string Dinheirovalor = Convert.ToString(venda.Dinheiro.HasValue ? venda.Dinheiro.Value : default(double));//declara variavel
               Dinheirovalor = Dinheirovalor.Replace(".", "");//troca (ponto) por vazio
               Dinheirovalor = Dinheirovalor.Replace(",", ".");//troca (virgula) por (ponto)


               string Debitovalor = Convert.ToString(venda.Debito.HasValue ? venda.Debito.Value : default(double));//declara variavel
               Debitovalor = Debitovalor.Replace(".", "");//troca (ponto) por vazio
               Debitovalor = Debitovalor.Replace(",", ".");//troca (virgula) por (ponto)

               string Creditovalor = Convert.ToString(venda.Credito.HasValue ? venda.Credito.Value : default(double));//declara variavel
               Creditovalor = Creditovalor.Replace(".", "");//troca (ponto) por vazio
               Creditovalor = Creditovalor.Replace(",", ".");//troca (virgula) por (ponto)
               
               string sql2 = "Insert into Venda " +
                   " SELECT  " + (cliente.Id != 0 ? cliente.Id + " IdCliente, " : " Null IdCliente, ") + usuario.Id + " IdUsuario, " +
                   "CAST(" + (!string.IsNullOrWhiteSpace(Descontovalor) ? Descontovalor : "") + " AS float)" + " Desconto, " +
                   "CAST(" + ValorTotalvalor + " AS float)" + " ValorTotal, " +
                   "'" + data + "'" + " Data, " +
                   "CAST(" + (!string.IsNullOrWhiteSpace(Dinheirovalor) ? Dinheirovalor : "") + " AS float)" + " Dinheiro, " +
                   "CAST(" + (!string.IsNullOrWhiteSpace(Debitovalor) ? Debitovalor : "") + " AS float)" + " Debito," +
                   "CAST(" + (!string.IsNullOrWhiteSpace(Creditovalor) ? Creditovalor : "") + " AS float)" + " Credito"+ "," +
                   ((!string.IsNullOrWhiteSpace(Creditovalor) && Creditovalor != "0") ? (venda.QtdParcela + " QtdParcela") : "NULL QtdParcela");



               List<Venda> listanovaVenda = new List<Venda>();
               List<Venda> listanovaVendaTeste = new List<Venda>();
               Venda novaVenda = new Venda();

               SqlCommand myCommand2 = new SqlCommand(sql2, conn);

               try
               {
                   conn.Open();
                   myCommand2.ExecuteNonQuery();
                   listanovaVenda = entidade.Vendas.ToList();
                   foreach (var item in listanovaVenda)
                   {
                       novaVenda.Id = item.Id;
                       novaVenda.IdCliente = item.IdCliente;
                       novaVenda.IdUsuario = item.IdUsuario;
                       listanovaVendaTeste.Add(novaVenda);
                   }
                   int idClienteLast = listanovaVendaTeste.LastOrDefault().Id;
                   foreach (var item in listaVenda)
                   {
                       string sql3 = "Insert into ItemPedido " +
                           " SELECT  " + item.Quantidade + " Quantidade, " + item.Codigo + " IdProduto, " + idClienteLast + " IdVenda, " + (item.Entrega ? 1 : 0) + " Entrega";
                       SqlCommand myCommand3 = new SqlCommand(sql3, conn);

                       myCommand3.ExecuteNonQuery();

                       Produto produtoCadastrado = new Produto();
                       produtoCadastrado = entidade.Produtos.Where(p => p.Id == item.Codigo).FirstOrDefault();

                       if (produtoCadastrado != null)
                       {
                           produtoCadastrado.SaldoAtual = produtoCadastrado.SaldoAtual - item.Quantidade;

                           string SaldoAtualvalor = Convert.ToString(produtoCadastrado.SaldoAtual);
                           SaldoAtualvalor = SaldoAtualvalor.Replace(".", "");//troca (ponto) por vazio
                           SaldoAtualvalor = SaldoAtualvalor.Replace(",", ".");//troca (virgula) por (ponto)


                           string sql5 = "update Produto SET SaldoAtual =" + "CAST(" + SaldoAtualvalor + " AS float)" + " Where Id =" + item.Codigo;
                           SqlCommand myCommand5 = new SqlCommand(sql5, conn);

                           myCommand5.ExecuteNonQuery();
                       }
                   }
                   if (venda.IdCliente != null)
                   {

                       string sql4 = "Insert into Entrega " +
                           " SELECT  " + idClienteLast + " IdVenda, " + "'"+ DateTime.Today.AddDays(1) +"'" + " DataEntrega, " +  "'Pendente' Status";
                       SqlCommand myCommand4 = new SqlCommand(sql4, conn);

                       myCommand4.ExecuteNonQuery();
                   }
                   return true;
               }catch (Exception)
               {
                   return false;
               }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            catch (System.Data.UpdateException dbEx)
            {
                Exception raise = dbEx;
                var teste = dbEx.StateEntries.ToString();
                throw raise;
            }
            catch (System.Data.DBConcurrencyException dbEx)
            {
                Exception raise = dbEx;
                var teste = dbEx.Message.ToString();
                throw raise;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public List<ItemConsultarProdutoVenda> ObterTodos(int? codigoVenda)
        {
            List<ItemConsultarProdutoVenda> lista = new List<ItemConsultarProdutoVenda>();
            var listaPedidos = entidade.ItemPedidoes.ToList();
            var listaProdutos = entidade.Produtos.ToList();
            
            var result = (from w in listaPedidos
                          join e in listaProdutos on w.IdProduto equals e.Id
                          where w.IdVenda.Equals(codigoVenda)
                          select e);

            if (result.Any())
            {
                foreach (var item in result)
                {
                    ItemConsultarProdutoVenda itemConsulta = new ItemConsultarProdutoVenda();
                    itemConsulta.Codigo = item.Id;
                    itemConsulta.CodigoItemPedido = item.ItemPedidoes.Where(p => p.IdProduto == item.Id && p.IdVenda == codigoVenda).FirstOrDefault().Id;
                    itemConsulta.Descricao = item.ItemPedidoes.Where(p => p.IdProduto == item.Id && p.IdVenda == codigoVenda).FirstOrDefault().Produto.Descricao;
                    itemConsulta.Marca = item.ItemPedidoes.Where(p => p.IdProduto == item.Id && p.IdVenda == codigoVenda).FirstOrDefault().Produto.Marca;
                    itemConsulta.PrecoUnitario = item.ItemPedidoes.Where(p => p.IdProduto == item.Id && p.IdVenda == codigoVenda).FirstOrDefault().Produto.PrecoVenda;
                    itemConsulta.Quantidade = item.ItemPedidoes.Where(p => p.IdProduto == item.Id && p.IdVenda == codigoVenda).FirstOrDefault().Quantidade;
                    itemConsulta.Valor = itemConsulta.PrecoUnitario * itemConsulta.Quantidade;
                    lista.Add(itemConsulta);
                }
            }

            return lista;
        }

        public bool SalvarDevolucao(int codigoItemPedido, double quantidade, DateTime data, int codigoProduto)
        {
            int quantidadeProduto = Convert.ToInt32(quantidade);

            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ProjetoFinal;Integrated Security=True");

            try
            {
                string sql = "Insert into Devolucao " +
                    " SELECT  " + "'" + data + "'" + " Data, " + codigoItemPedido + " IdItemPedido";
                SqlCommand myCommand = new SqlCommand(sql, conn);
                conn.Open();

                myCommand.ExecuteNonQuery();

                List<Devolucao> devolucao = new List<Devolucao>();
                devolucao = entidade.Devolucaos.ToList();
                int idDevolucao = 0;
                if (devolucao.Any())
                {
                    idDevolucao = devolucao.LastOrDefault().Id;

                    string sql2 = "Insert into ItemDevolucao " +
                        " SELECT  " + quantidadeProduto + " Quantidade, " + codigoProduto + " IdProduto," + idDevolucao + " IdDevolucao";
                    SqlCommand myCommand1 = new SqlCommand(sql2, conn);

                    myCommand1.ExecuteNonQuery();

                     Produto produtoCadastrado = new Produto();
                       produtoCadastrado = entidade.Produtos.Where(p => p.Id == codigoProduto).FirstOrDefault();

                       if (produtoCadastrado != null)
                       {
                           produtoCadastrado.SaldoAtual = produtoCadastrado.SaldoAtual + quantidadeProduto;

                           string SaldoAtualvalor = Convert.ToString(produtoCadastrado.SaldoAtual);
                           SaldoAtualvalor = SaldoAtualvalor.Replace(".", "");//troca (ponto) por vazio
                           SaldoAtualvalor = SaldoAtualvalor.Replace(",", ".");//troca (virgula) por (ponto)

                           string sql3 = "update Produto SET SaldoAtual =" + "CAST(" + SaldoAtualvalor + " AS float)" + " Where Id =" + codigoProduto;
                           SqlCommand myCommand3 = new SqlCommand(sql3, conn);

                           myCommand3.ExecuteNonQuery();
                       }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }


        public List<IVendaModel> GetAll()
        {
            List<Venda> listanovaVenda = new List<Venda>();
            List<IVendaModel> listanovaVendaTeste = new List<IVendaModel>();

            listanovaVenda = entidade.Vendas.ToList();
            foreach (var item in listanovaVenda)
            {
                IVendaModel novaVenda = new IVendaModel();
                novaVenda.Id = item.Id;
                novaVenda.IdCliente = item.IdCliente;
                novaVenda.IdUsuario = item.IdUsuario;
                novaVenda.Data = item.Data;
                novaVenda.Dinheiro = item.Dinheiro;
                novaVenda.Debito = item.Debito;
                novaVenda.Credito = item.Credito;
                novaVenda.Desconto = item.Desconto;

                novaVenda.ValorTotal = item.ValorTotal;
                listanovaVendaTeste.Add(novaVenda);
            }

            return listanovaVendaTeste;
        }

        public List<IVendaDevolucaoModel> GetAllDevolucoes()
        {
            List<IVendaDevolucaoModel> listaModel = new List<IVendaDevolucaoModel>();
            var listaPedidos = entidade.ItemPedidoes.ToList();
            var listaProdutos = entidade.Produtos.ToList();
            var listaVendas = entidade.Vendas.ToList();
            var listaDevolucao = entidade.Devolucaos.ToList();
            var listaItemDevolucao = entidade.ItemDevolucaos.ToList();
            
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ProjetoFinal;Integrated Security=True");

            try
            {
                string sql = "SELECT V.ID, IP.IDPRODUTO, IP.QUANTIDADE AS QUANTIDADEVENDA, M.QUANTIDADE AS QUANTIDADEDEVOLUCAO " +
                                "FROM DBO.VENDA V " +
                                "JOIN DBO.ITEMPEDIDO IP " +
                                "    ON V.ID = IP.IDVENDA " +
                                "JOIN ( " +
                                "SELECT IP.IDVENDA, ID.IDPRODUTO, ID.QUANTIDADE  " +
                                "FROM DBO.DEVOLUCAO D " +
                                "JOIN DBO.ITEMDEVOLUCAO ID " +
                                "    ON D.ID = ID.IDDEVOLUCAO " +
                                "JOIN DBO.ITEMPEDIDO IP " +
                                "    ON D.IDITEMPEDIDO = IP.ID " +
                                ")M " +
                                "ON V.ID = M.IDVENDA AND IP.IDPRODUTO = M.IDPRODUTO";
                SqlCommand myCommand = new SqlCommand(sql, conn);
                conn.Open();

                SqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    IVendaDevolucaoModel model = new IVendaDevolucaoModel();
                    model.CodigoVenda = Convert.ToInt32(reader[0]);
                    model.CodigoProduto = Convert.ToInt32(reader[1]);
                    model.QuantidadeVenda = Convert.ToInt32(reader[2]);
                    model.QuantidadeDevolucao = Convert.ToInt32(reader[3]);
                    listaModel.Add(model);
                }
                reader.Close();
            }
            catch (Exception)
            {
                listaModel = new List<IVendaDevolucaoModel>();
            }
            return listaModel;
        }
    }
}
