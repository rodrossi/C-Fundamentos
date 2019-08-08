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
    public partial class FormExercicio3 : Form
    {
        public FormExercicio3()
        {
            InitializeComponent();
        }

        private void BtnCalculo_Click(object sender, EventArgs e)
        {
            /* Elabore um programa em C# que coleta o salário atual de 
            um funcionário e o valor percentual de reajuste ao qual o 
            funcionário tem direito. Após coletadas estas informações, 
            apresente o novo salário do funcionário.*/

            decimal salarioAtual = Convert.ToDecimal(txtSalarioAtual.Text);
            decimal reajuste = Convert.ToDecimal(txtReajuste.Text);

            decimal salarioFinal = salarioAtual + salarioAtual * (reajuste / 100);

            MessageBox.Show($"O Salario com o Reajuste é: {(salarioFinal).ToString("C")}");

        }
    }
}
