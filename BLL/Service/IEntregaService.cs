using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public interface IEntregaService
    {
        List<EntregaModel> ObterEntregas(string nome, string situacao, string filtro);
        List<EntregaModel> GetALL();
        List<ItemConsultarEntregaModel> GetItens(int idVenda);
    }
}
