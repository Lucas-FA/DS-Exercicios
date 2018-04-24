using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double dNum1 = System.Convert.ToDouble(txbValor1.Text);
            double dNum2 = System.Convert.ToDouble(txbValor2.Text);
            double dRes = dNum1 + dNum2;
            lblResultadoSoma.Text = dRes.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double dNum1 = System.Convert.ToDouble(txbValor1.Text);
            double dNum2 = System.Convert.ToDouble(txbValor2.Text);
            double dRes = dNum1 - dNum2;
            lblResultadoSubtracao.Text = dRes.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double dNum1 = System.Convert.ToDouble(txbValor1.Text);
            double dNum2 = System.Convert.ToDouble(txbValor2.Text);
            double dRes = dNum1 * dNum2;
            lblResultadoMult.Text = dRes.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double dNum1 = System.Convert.ToDouble(txbValor1.Text);
            double dNum2 = System.Convert.ToDouble(txbValor2.Text);
            double dRes = dNum1 / dNum2;
            lblResultadoDiv.Text = dRes.ToString();
        }
    }
}
