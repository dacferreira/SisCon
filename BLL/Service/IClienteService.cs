using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;

namespace BLL.Service
{
    public interface IClienteService
    {
        bool Salvar(string CPF, string RG, string Nome, string CNPJ, string RazaoSocial, string InscEstadual, string Endereco
                            , string CEP, string Cidade, string UF, string Celular, string Obs, string Telefone, string tipoPessoa, int codigo, string bairro);
        ClienteModel GetClienteById(int id);

        List<ClienteModel> ObterClientes(string nome, int situacao, string filtro);

        bool Excluir(int codigo);

        bool Ativar(int codigo);
    }
}
