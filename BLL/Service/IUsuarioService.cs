using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Models;

namespace BLL.Service
{
   public interface IUsuarioService
    {
        UsuarioModel GetUsuarioByLogin(string login, string senha);
    }
}
