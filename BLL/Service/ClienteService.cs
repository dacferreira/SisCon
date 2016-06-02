using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Persistence;
using DTO.Models;

namespace BLL.Service
{
    public class ClienteService : IClienteService
    {
        public bool Salvar(string CPF, string RG, string Nome, string CNPJ, string RazaoSocial, string InscEstadual, string Endereco
                            , string CEP, string Cidade, string UF, string Celular, string Obs, string Telefone, string tipoPessoa, int codigo, string bairro)
        {
            return new ClienteDAL().Salvar(CPF, RG, Nome, CNPJ, RazaoSocial, InscEstadual, Endereco, CEP, Cidade, UF, Celular, Obs, Telefone, tipoPessoa, codigo, bairro);
        }

        public ClienteModel GetClienteById(int id)
        {
            return new ClienteDAL().GetClienteById(id);
        }

        public List<ClienteModel> ObterClientes(string nome, int situacao, string filtro)
        {
            List<ClienteModel> lista = new ClienteDAL().ObterTodos();
            List<ClienteModel> novalista = new List<ClienteModel>();
            if (situacao != 2)
            {
                if (filtro == "NOME/RAZÃO SOCIAL")
                {
                    var lista1 = lista.Where(p => p.PessoaFisica && p.Nome.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
                    var lista2 = lista.Where(p => p.PessoaJuridica && p.RazaoSocial.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

                    var listaUnion = lista1.Union(lista2);
                    novalista = listaUnion.ToList();
                }
                if (filtro == "CPF/CNPJ")
                {
                    var lista1 = lista.Where(p => p.PessoaFisica && p.CPF.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
                    var lista2 = lista.Where(p => p.PessoaJuridica && p.CNPJ.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

                    var listaUnion = lista1.Union(lista2);
                    novalista = listaUnion.ToList();
                }
                if (filtro == "RG/INCR. ESTADUAL")
                {
                    var lista1 = lista.Where(p => p.PessoaFisica && p.RG.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
                    var lista2 = lista.Where(p => p.PessoaJuridica && p.InscEstadual.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

                    var listaUnion = lista1.Union(lista2);
                    novalista = listaUnion.ToList();
                }
                if (filtro == "Endereço")
                    novalista = lista.Where(p =>p.Endereco.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

            }
            else
            {
                if (situacao == 2)
                {
                    if (filtro == "NOME/RAZÃO SOCIAL")
                    {
                        var lista1 = lista.Where(p => p.PessoaFisica && p.Nome.ToLower().Contains(nome.ToLower())).ToList();
                        var lista2 = lista.Where(p => p.PessoaJuridica && p.RazaoSocial.ToLower().Contains(nome.ToLower())).ToList();

                        var listaUnion = lista1.Union(lista2);
                        novalista = listaUnion.ToList();
                    }
                    if (filtro == "CPF/CNPJ")
                    {
                        var lista1 = lista.Where(p => p.PessoaFisica && p.CPF.ToLower().Contains(nome.ToLower())).ToList();
                        var lista2 = lista.Where(p => p.PessoaJuridica && p.CNPJ.ToLower().Contains(nome.ToLower())).ToList();

                        var listaUnion = lista1.Union(lista2);
                        novalista = listaUnion.ToList();
                    }
                    if (filtro == "RG/INCR. ESTADUAL")
                    {
                        var lista1 = lista.Where(p => p.PessoaFisica && p.RG.ToLower().Contains(nome.ToLower())).ToList();
                        var lista2 = lista.Where(p => p.PessoaJuridica && p.InscEstadual.ToLower().Contains(nome.ToLower())).ToList();

                        var listaUnion = lista1.Union(lista2);
                        novalista = listaUnion.ToList();
                    }
                    if (filtro == "Endereço")
                        novalista = lista.Where(p => p.Endereco.ToLower().Contains(nome.ToLower())).ToList();
                }
                else
                {
                    if (filtro == "NOME/RAZÃO SOCIAL")
                    {
                        var lista1 = lista.Where(p => p.PessoaFisica && p.Nome.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
                        var lista2 = lista.Where(p => p.PessoaJuridica && p.Nome.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

                        var listaUnion = lista1.Union(lista2);
                        novalista = listaUnion.ToList();
                    }
                    if (filtro == "CPF/CNPJ")
                    {
                        var lista1 = lista.Where(p => p.PessoaFisica && p.CPF.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
                        var lista2 = lista.Where(p => p.PessoaJuridica && p.CNPJ.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

                        var listaUnion = lista1.Union(lista2);
                        novalista = listaUnion.ToList();
                    }
                    if (filtro == "RG/INCR. ESTADUAL")
                    {
                        var lista1 = lista.Where(p => p.PessoaFisica && p.RG.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
                        var lista2 = lista.Where(p => p.PessoaJuridica && p.InscEstadual.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();

                        var listaUnion = lista1.Union(lista2);
                        novalista = listaUnion.ToList();
                    }
                    if (filtro == "Endereço")
                        novalista = lista.Where(p => p.Endereco.ToLower().Contains(nome.ToLower()) && p.Situacao == Convert.ToBoolean(situacao)).ToList();
                }
            }
            return novalista;
        }

        public bool Excluir(int codigo)
        {
            return new ClienteDAL().Excluir(codigo);
        }
        public bool Ativar(int codigo)
        {
            return new ClienteDAL().Ativar(codigo);
        }
        public bool ExisteNome(string Nome)
        {
            ClienteModel novalista = new ClienteModel();
            List<ClienteModel> clientelista = new List<ClienteModel>();
            var clientes = new ClienteDAL().ObterTodos();
            clientelista = clientes.Where(p => p.PessoaFisica == true).ToList();

            novalista = clientelista.Where(p => p.Nome.Equals(Nome)).FirstOrDefault();
            if (novalista != null)
                return true;
            else
                return false;
        }
        public bool ExisteApelido(string apelido)
        {
            //ClienteModel novalista = new ClienteModel();
            //List<ClienteModel> clientelista = new List<ClienteModel>();

            //var clientes = new ClienteDAL().ObterTodos();
            //clientelista = clientes.Where(p => p.PessoaFisica == true).ToList();

            //novalista = clientelista.Where(p => p.Apelido.Equals(apelido)).FirstOrDefault();
            //if (novalista != null)
            //    return true;
            //else
                return false;
        }
        public bool ExisteCPF(string cpf)
        {
            ClienteModel novalista = new ClienteModel();
            List<ClienteModel> clientelista = new List<ClienteModel>();
            var clientes = new ClienteDAL().ObterTodos();
            clientelista = clientes.Where(p => p.PessoaFisica == true).ToList();

            novalista = clientelista.Where(p => p.CPF.Equals(cpf)).FirstOrDefault();
            if (novalista != null)
                return true;
            else
                return false;
        }
        public bool ExisteRG(string rg)
        {
            ClienteModel novalista = new ClienteModel();
            List<ClienteModel> clientelista = new List<ClienteModel>();
            var clientes = new ClienteDAL().ObterTodos();
            clientelista = clientes.Where(p => p.PessoaFisica == true).ToList();

            novalista = clientelista.Where(p => p.RG.Equals(rg)).FirstOrDefault();
            if (novalista != null)
                return true;
            else
                return false;
        }
        public bool ExisteCNPJ(string cnpj)
        {
            ClienteModel novalista = new ClienteModel();
            List<ClienteModel> clientelista = new List<ClienteModel>();
            var clientes = new ClienteDAL().ObterTodos();
            clientelista = clientes.Where(p => p.PessoaJuridica == true).ToList();

            novalista = clientelista.Where(p => p.CNPJ.Equals(cnpj)).FirstOrDefault();
            if (novalista != null)
                return true;
            else
                return false;
        }
        public bool ExisteRazaoSocial(string razaoSocial)
        {
            ClienteModel novalista = new ClienteModel();
            List<ClienteModel> clientelista = new List<ClienteModel>();
            var clientes = new ClienteDAL().ObterTodos();
            clientelista = clientes.Where(p => p.PessoaJuridica == true).ToList();

            novalista = clientelista.Where(p => p.RazaoSocial.Equals(razaoSocial)).FirstOrDefault();
            if (novalista != null)
                return true;
            else
                return false;
        }
        public bool ExisteInscEstadual(string inscEstadual)
        {
            ClienteModel novalista = new ClienteModel();
            List<ClienteModel> clientelista = new List<ClienteModel>();
            var clientes = new ClienteDAL().ObterTodos();
            clientelista = clientes.Where(p => p.PessoaJuridica == true).ToList();

            novalista = clientelista.Where(p => p.InscEstadual.Equals(inscEstadual)).FirstOrDefault();
            if (novalista != null)
                return true;
            else
                return false;
        }
    }
}
