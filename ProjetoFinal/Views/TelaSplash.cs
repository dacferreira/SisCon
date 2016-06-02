using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal.Views
{
    public partial class TelaSplash : Form
    {
        #region [ Construtor ]
        public TelaSplash()
        {
            InitializeComponent();
        }
        #endregion

        #region [ Metodos Principais ]
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(1);
            if (progressBar2.Value == 100)
            {
                timer1.Stop();
            }
        }

        public void SplashScreen()
        {
            Application.Run(new TelaSplash());
        }

        private void TelaSplash_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            for (double count = 0; count <= 1; count += 0.1)
            {
                Opacity = count;
                Refresh();
                Thread.Sleep(15);
            }
        }
        #endregion
    }
}
