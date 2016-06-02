using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProjetoFinal.Extension

{
    /// <summary>
    /// Contém métodos para auxiliar na manutenção de informações no contexto da aplicação
    /// </summary>
    public static class ContextHelper
    {

        /// <summary>
        /// Obtém uma informação do contexto da aplicação
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static object GetData(string name)
        {
            if (IsInWebContext())
            {
                return HttpContext.Current.Items[name];
            }
            else
            {
                return CallContext.GetData(name);
            }
        }

        /// <summary>
        /// Atualiza uma informação no contexto da aplicação
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void SetData(string name, object value)
        {
            if (IsInWebContext())
            {
                HttpContext.Current.Items[name] = value;
            }
            else
            {
                CallContext.SetData(name, value);
            }
        }

        /// <summary>
        /// Remove uma informação do contexto da aplicação
        /// </summary>
        /// <param name="name"></param>
        public static void FreeNamedDataSlot(string name)
        {
            if (IsInWebContext())
            {
                HttpContext.Current.Items.Remove(name);
            }
            else
            {
                CallContext.FreeNamedDataSlot(name);
            }
        }

        /// <summary>
        /// Identifica se a aplicação está no contexto Web
        /// </summary>
        /// <returns></returns>
        public static bool IsInWebContext()
        {
            return HttpContext.Current != null;
        }
    }
}
