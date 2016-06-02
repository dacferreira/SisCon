using DAL.Persistence;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class EntregaService : IEntregaService
    {
        public List<EntregaModel> ObterEntregas(string nome, string situacao, string filtro)
        {
            List<EntregaModel> lista = new EntregaDAL().ObterTodos();
            
            return lista;
        }

        public List<EntregaModel> GetALL()
        {
            List<EntregaModel> lista = new EntregaDAL().ObterTodos();

            return lista;
        }

        public List<ItemConsultarEntregaModel> GetItens(int idVenda)
        {
            List<ItemConsultarEntregaModel> lista = new EntregaDAL().ObterTodosItens(idVenda);

            return lista;
        }
        
        public bool ConfirmarEntrega(ItemEntregaModel itemEntrega)
        {
            return new EntregaDAL().ConfirmaEntrega(itemEntrega);
        }
    }
}
