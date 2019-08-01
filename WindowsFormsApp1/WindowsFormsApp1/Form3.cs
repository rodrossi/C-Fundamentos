using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int valorInteiro;
            decimal valorDecimal;
            DateTime data;

            valorInteiro = Convert.ToInt32(txtValorInteiro.Text);
            valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);
            data = Convert.ToDateTime(txtData.Text);
        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            int valorInteiro = Convert.ToInt32(txtValorInteiro.Text);
            decimal valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);
            decimal resultado = valorInteiro + valorDecimal;
            MessageBox.Show($"O resultado da soma é: {resultado}");
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            int valorInteiro = Convert.ToInt32(txtValorInteiro.Text);
            decimal valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);
            decimal resultaS = valorInteiro - valorDecimal;

            MessageBox.Show($"O resultado da Subtração é:{resultaS}");
        }

        private void BtnFormula_Click(object sender, EventArgs e)
        {
            //dividir valor inteiro com valor decimal
            //multiplicar o resultado por 1,5 e exibir
            //em mensagem de alerta

            int valorInteiro = Convert.ToInt32(txtValorInteiro.Text);
            decimal valorDecimal = Convert.ToDecimal(txtValorDecimal.Text);
            decimal mult = 1.5m;

            decimal result = valorInteiro / valorDecimal * mult;

            MessageBox.Show($"O resultado é: {result}", "Alert",MessageBoxButtons.OK,MessageBoxIcon.Information); 
                

        }
    }
}
