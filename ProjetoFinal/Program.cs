using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinal.Views;

namespace ProjetoFinal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Chamar o login antes de iniciar a aplicação
            Form1 fLogin = new Form1();
            fLogin.ShowDialog();

            ////Só inicia se receber True na propriedade "Logado"
            if (fLogin.Logado)
            {
                fLogin.Hide();
                FM_Principal principal = new FM_Principal();
                principal.ShowDialog();
            }
        }
    }
}
