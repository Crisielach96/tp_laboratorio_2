using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        Numero n1 = new Numero();

        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtIn.Clear();
            this.txtIn2.Clear();
            this.lblResult.Text = "";
            this.cmbSelec.Text = "";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string num1 = this.txtIn.Text;
            string num2 = this.txtIn2.Text;
            string operador = this.cmbSelec.Text;
            double resp = LaCalculadora.Operar(num1, num2, operador);
            string respF = Convert.ToString(resp);
            lblResult.Text = respF;
        }

        private static double Operar(string num1, string num2, string operador)
        {
            Calculadora calculadora = new Calculadora();
            Numero numero = new Numero(num1);
            Numero numero2 = new Numero(num2);
            double resp = calculadora.Operar(numero, numero2, operador);
            return resp;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABin_Click(object sender, EventArgs e)
        {
            string num1 = this.txtIn.Text;
            this.lblResult.Text = n1.DecimalBinario(num1);
        }

        private void btnAdec_Click(object sender, EventArgs e)
        {
            string num1 = this.txtIn.Text;
            this.lblResult.Text = n1.BinarioDecimal(num1);
        }
    }
}
