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
   public class ClienteDAL
    {
        ProjetoFinalEntities entidade = new ProjetoFinalEntities();

        public bool Salvar(string CPF, string RG, string Nome, string CNPJ, string RazaoSocial, string InscEstadual, string Endereco
                         , string CEP, string Cidade, string UF, string Celular, string Obs, string Telefone, string tipoPessoa, int codigo, string bairro)
        {
            Cliente cliente = new Cliente();
            PessoaFisica pessoaFisica = new PessoaFisica();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();

            try
            {
                cliente.Endereco = Endereco;
                cliente.CEP = CEP;
                cliente.Cidade = Cidade;
                cliente.Bairro = bairro;
                cliente.UF = UF;
                cliente.Celular = Celular.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                cliente.Obs = Obs;
                cliente.Telefone = Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                cliente.TipoPessoa = tipoPessoa;
                if (tipoPessoa == "F")
                {
                    pessoaFisica.CPF = CPF;
                    pessoaFisica.RG = RG;
                    pessoaFisica.Nome = Nome;
                }
                if (tipoPessoa == "J")
                {
                    pessoaJuridica.CNPJ = CNPJ;
                    pessoaJuridica.RazaoSocial = RazaoSocial;
                    pessoaJuridica.InscEstadual = InscEstadual;
                }

                if (codigo == 0)
                {
                    if (tipoPessoa == "F")
                        cliente.PessoaFisicas.Add(pessoaFisica);
                    if (tipoPessoa == "J")
                        cliente.PessoaJuridicas.Add(pessoaJuridica);
                }
                else
                {
                    //cliente.Id = codigo;
                    if (tipoPessoa == "F")
                    {
                        var cientebyid = GetClienteById(codigo);
                        if (cientebyid.PessoaFisica)
                        {
                            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ProjetoFinal;Integrated Security=True");

                            string sql2 = "UPDATE PessoaFisica SET CPF = " + "'" + CPF.ToString() + "'" + ", RG =" + "'" + RG.ToString() + "'" + ", Nome =" +
                                            "'" + Nome + "'" + " WHERE idCliente=" + codigo + 
                                            " UPDATE Cliente SET Endereco =" + "'" + Endereco + "'" + ", CEP =" +"'" + CEP + "'" + ", Cidade =" + "'" + Cidade + "'" +
                                            ", Bairro =" + "'" + bairro + "'" + ", UF = " + "'" + UF + "'" +
                                            ", Telefone =" + "'" + Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "") + "'" +
                                            ", Celular =" + "'" + Celular.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "") + "'" +
                                            ", Obs =" + "'" + Obs + "'" + ", TipoPessoa = 'F'" +
                                            " Where id =" + codigo;

                            SqlCommand myCommand2 = new SqlCommand(sql2, conn);

                            try
                            {
                                conn.Open();
                                myCommand2.ExecuteNonQuery();

                                return true;
                            }
                            catch (Exception ex)
                            {
                                return false;
                                Console.WriteLine("Error: " + ex);
                            }
                            finally
                            {
                                conn.Close();
                            }                            
                        }
                        else
                        {
                            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ProjetoFinal;Integrated Security=True");
                            string sql2 = "INSERT INTO PessoaFisica " +
                                            "SELECT IdCliente = " + codigo + ", CPF = " + "'" + CPF.ToString() + "'" + ", RG =" + "'" + RG.ToString() + "'" + ", Nome =" +
                                            "'" + Nome + "'" +
                                            " UPDATE Cliente SET Endereco =" + "'" + Endereco + "'" + ", CEP =" + "'" + CEP + "'" + ", Cidade =" + "'" + Cidade + "'" +
                                            ", Bairro =" + "'" + bairro + "'" + ", Telefone =" + "'" + Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "") + "'" +
                                            ", Celular =" + "'" + Celular.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "") + "'" +
                                            ", Obs =" + "'" + Obs + "'" + ", TipoPessoa = 'F'" +
                                            " Where id =" + codigo;

                            SqlCommand myCommand2 = new SqlCommand(sql2, conn);

                            try
                            {
                                conn.Open();
                                myCommand2.ExecuteNonQuery();

                                return true;
                            }
                            catch (Exception ex)
                            {
                                return false;
                                Console.WriteLine("Error: " + ex);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                    if (tipoPessoa == "J")
                    {
                        var cientebyid = GetClienteById(codigo);
                        if (cientebyid.PessoaJuridica)
                        {
                            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ProjetoFinal;Integrated Security=True");

                            string sql2 = "UPDATE PessoaJuridica SET CNPJ = " + "'" + CNPJ.ToString() + "'" + ", InscEstadual =" + "'" + InscEstadual.ToString() + "'"
                                            + ", RazaoSocial =" + "'" + RazaoSocial + "'" + " WHERE idCliente=" + codigo +
                                            " UPDATE Cliente SET Endereco =" + "'" + Endereco + "'" + ", CEP =" + "'" + CEP + "'" + ", Cidade =" + "'" + Cidade + "'" +
                                            ", Bairro =" + "'" + bairro + "'" + ", Telefone =" + "'" + Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "") + "'" +
                                            ", Celular =" + "'" + Celular.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "") + "'" +
                                            ", Obs =" + "'" + Obs + "'" + ", TipoPessoa = 'J'" +
                                            " Where id =" + codigo;

                            SqlCommand myCommand2 = new SqlCommand(sql2, conn);

                            try
                            {
                                conn.Open();
                                myCommand2.ExecuteNonQuery();

                                return true;
                            }
                            catch (Exception ex)
                            {
                                return false;
                                Console.WriteLine("Error: " + ex);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                        else
                        {
                            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ProjetoFinal;Integrated Security=True");

                            string sql2 = "INSERT INTO PessoaJuridica" +
                                            " SELECT IdCliente = " + codigo + ", CNPJ =" + "'" + CNPJ.ToString() + "'"  + ", RazaoSocial =" + "'" + RazaoSocial + "'" + 
                                            ", InscEstadual =" + "'" + InscEstadual.ToString() + "'" +                                             
                                            " UPDATE Cliente SET Endereco =" + "'" + Endereco + "'" + ", CEP =" + "'" + CEP + "'" + ", Cidade =" + "'" + Cidade + "'" +
                                            ", Bairro =" + "'" + bairro + "'" + ", Telefone =" + "'" + Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "") + "'" +
                                            ", Celular =" + "'" + Celular.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "") + "'" +
                                            ", Obs =" + "'" + Obs + "'" + ", TipoPessoa = 'J'" +
                                            " Where id =" + codigo;

                            SqlCommand myCommand2 = new SqlCommand(sql2, conn);

                            try
                            {
                                conn.Open();
                                myCommand2.ExecuteNonQuery();

                                return true;
                            }
                            catch (Exception ex)
                            {
                                return false;
                                Console.WriteLine("Error: " + ex);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                }
                entidade.Clientes.Add(cliente);
                entidade.SaveChanges();

                return true;
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
                        // raise a new exception nesting
                        // the current instance as InnerException
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
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<ClienteModel> ObterTodos()
        {
            var listaCliente = new List<ClienteModel>();

            var lista = entidade.Clientes.ToList();
            if (lista != null && lista.Any())
                foreach (var item in lista)
                {
                    var usuario = new ClienteModel();

                    usuario.Codigo = item.Id;
                    usuario.Endereco = item.Endereco;
                    usuario.Celular = item.Celular;
                    usuario.CEP = item.CEP;
                    usuario.Cidade = item.Cidade;
                    usuario.Bairro = item.Bairro;
                    usuario.Obs = item.Obs;
                    usuario.Telefone = item.Telefone;
                    usuario.UF = item.UF;
                    if (item.TipoPessoa == "F")
                    {
                        usuario.PessoaFisica = true;
                        if(item.PessoaFisicas != null && item.PessoaFisicas.Any()){
                            usuario.Nome = item.PessoaFisicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().Nome;
                            usuario.CPF = item.PessoaFisicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().CPF;
                            usuario.RG = item.PessoaFisicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().RG;
                        }
                    }
                    else
                    {
                        usuario.PessoaJuridica = true;
                        if (item.PessoaJuridicas != null && item.PessoaJuridicas.Any())
                        {
                            usuario.CNPJ = item.PessoaJuridicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().CNPJ;
                            usuario.InscEstadual = item.PessoaJuridicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().InscEstadual;
                            usuario.RazaoSocial = item.PessoaJuridicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().RazaoSocial;
                        }
                    }
                    
                    listaCliente.Add(usuario);
                }
            return listaCliente;
        }

        public bool Excluir(int codigo)
        {
            try
            {
                var cliente = entidade.Clientes.Where(p => p.Id == codigo).FirstOrDefault();
                cliente.Id = codigo;
                entidade.Clientes.Attach(cliente);
                entidade.Entry(cliente).State = EntityState.Modified;
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
                var cliente = entidade.Clientes.Where(p => p.Id == codigo).FirstOrDefault();
                cliente.Id = codigo;
                entidade.Clientes.Attach(cliente);
                entidade.Entry(cliente).State = EntityState.Modified;
                entidade.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public ClienteModel GetClienteById(int id)
        {
            ClienteModel cliente = new ClienteModel();
            var item = entidade.Clientes.Where(p => p.Id == id).FirstOrDefault();
            if (item != null)
            {
                cliente.Codigo = item.Id;
                cliente.Endereco = item.Endereco;
                cliente.Celular = item.Celular;
                cliente.CEP = item.CEP;
                cliente.Cidade = item.Cidade;
                cliente.Bairro = item.Bairro;
                cliente.Obs = item.Obs;
                cliente.Telefone = item.Telefone;
                cliente.UF = item.UF;
                if (item.TipoPessoa == "F")
                {
                    cliente.PessoaFisica = true;
                    if (item.PessoaFisicas != null && item.PessoaFisicas.Any())
                    {
                        cliente.Nome = item.PessoaFisicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().Nome;
                        cliente.CPF = item.PessoaFisicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().CPF;
                        cliente.RG = item.PessoaFisicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().RG;
                    }
                }
                else
                {
                    cliente.PessoaJuridica = true;
                    if (item.PessoaJuridicas != null && item.PessoaJuridicas.Any())
                    {
                        cliente.CNPJ = item.PessoaJuridicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().CNPJ;
                        cliente.InscEstadual = item.PessoaJuridicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().InscEstadual;
                        cliente.RazaoSocial = item.PessoaJuridicas.Where(p => p.IdCliente == item.Id).FirstOrDefault().RazaoSocial;
                    }
                }

            }

            return cliente;
        }
    }
}
