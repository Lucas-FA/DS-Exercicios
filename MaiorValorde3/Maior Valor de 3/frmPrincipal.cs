using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaiorDeTres
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double ValorA = System.Convert.ToDouble(txbValorA.Text);
            double ValorB = System.Convert.ToDouble(txbValorB.Text);
            double ValorC = System.Convert.ToDouble(txbValorC.Text);

            if (ValorA > ValorB && ValorA > ValorC)
            {
                lblResposta.Text = "O maior valor é A";
            }

            else if (ValorB > ValorA && ValorB > ValorC)
            {
                lblResposta.Text = "O maior valor é B";
            }

            else if (ValorC > ValorB && ValorC > ValorA)
            {
                lblResposta.Text = "O maior valor é C";
            }
            else if (ValorA == ValorB && ValorA > ValorC)
            {
                lblResposta.Text = "Os maiores valores são A e B";
            }
            else if (ValorB == ValorC && ValorB > ValorA)
            {
                lblResposta.Text = "Os maiores valores são B e C";
            }
            else if (ValorA == ValorC && ValorA > ValorB)
            {
                lblResposta.Text = "Os maiores valores são A e C";
            }
            else
                lblResposta.Text = "Os três valores são iguais";
        }
    }
}
