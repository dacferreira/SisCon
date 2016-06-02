using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IFormaPagamentoModel
    {
        string Descricao { get; set; }
        string RazaoSocial { get; set; }
        int? DescontoValor { get; set; }
        string Endereco { get; set; }
        string Telefone { get; set; }
        double? Dinheiro { get; set; }
        double? Debito { get; set; }
        double? TotalVenda { get; set; }
        double? Troco{ get; set; }
        double? ValorPago { get; set; }
        double? Credito { get; set; }
        bool Entrega { get; set; }
        bool NotaFiscal { get; set; }
        bool Desconto { get; set; }
        int? Vezes { get; set; }
        List<int> ListaVezes { get; set; }
    }
}
