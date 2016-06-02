using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class ProdutoModel
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
        public double MargemLucro { get; set; }
        public string Localizacao { get; set; }
        public double EstoqueMinimo { get; set; }
        public double SaldoAtual { get; set; }
        public bool Situacao { get; set; }
    }
}
