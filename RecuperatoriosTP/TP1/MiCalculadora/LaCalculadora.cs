using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        Calculadora calculadora = new Calculadora();

        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void Limpiar()
        {
            this.txtIn.Clear();
            this.txtIn2.Clear();
            this.lblResult.Text = "";
            this.cmbSelec.Text = "";
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResult.Text = this.Operar(txtIn.Text, txtIn2.Text, cmbSelec.Text).ToString();
        }

        private double Operar(string num1, string num2, string operador)
        {
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
            lblResult.Text = Numero.DecimalBinario(lblResult.Text);
        }

        private void btnAdec_Click(object sender, EventArgs e)
        {
            lblResult.Text = Numero.BinarioDecimal(lblResult.Text);
        }
    }
}
