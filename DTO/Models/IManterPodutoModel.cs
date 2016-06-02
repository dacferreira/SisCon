using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IManterPodutoModel
    {
        string Descricao { get; set; }
        string Marca { get; set; }
        double? PrecoCompra { get; set; }
        double? PrecoVenda { get; set; }
        double? MargemLucro { get; set; }
        string Localizacao { get; set; }
        double? EstoqueMinimo { get; set; }
        double? EstoqueAtual { get; set; }
        string NomeProdutoSessao { get; set; }
        string MarcaProdutoSessao { get; set; }       
    }
}
