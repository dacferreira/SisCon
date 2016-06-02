using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IManterClienteModel
    {
        string Endereco { get; set; }
        string CEP { get; set; }
        string Cidade { get; set; }
        string Bairro { get; set; }
        string UF { get; set; }
        string Telefone { get; set; }
        string Celular { get; set; }
        string Obs { get; set; }
        string CPF { get; set; }
        string RG { get; set; }
        string Nome { get; set; }
        string CNPJ { get; set; }
        string RazaoSocial { get; set; }
        string InscEstadual { get; set; }
        bool PessoaFisica { get; set; }
        bool PessoaJuridica { get; set; }
        string ApelidoSessao { get; set; }
        string CPFSessao { get; set; }
        string RGSessao { get; set; }
        string CNPJSessao { get; set; }
        string NomeSessao { get; set; }
        string RazaoSocialSessao { get; set; }
        string InscEstadualSessao { get; set; }
    }
}
