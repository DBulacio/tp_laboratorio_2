using System;
using Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        void Limpiar()
        {
            this.lblResultado.Text = "";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string n1 = txtNumero1.Text;
            string n2 = txtNumero2.Text;
            string op = cmbOperador.Text;
            //leo todo y se lo mando a Operar()
            double resultado = Operar(n1, n2, op);

            lblResultado.Text = resultado.ToString();
        }




        static double Operar(string n1, string n2, string op)
        {
            Numero num1 = new Numero(n1);
            Numero num2 = new Numero(n2);

            return Calculadora.Operar(num1, num2, op);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string res = lblResultado.Text;

            res = Numero.DecimalBinario(res);
            lblResultado.Text = res;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string res = lblResultado.Text;

            res = Numero.BinarioDecimal(res);
            lblResultado.Text = res;
        }
    }

}
