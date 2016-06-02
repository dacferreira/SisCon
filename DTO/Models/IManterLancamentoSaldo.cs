using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public interface IManterLancamentoSaldo
    {
        double? Saldo { get; set; }
        double? Lancamento { get; set; }
        double? SaldoAtual { get; set; }
    }
}
