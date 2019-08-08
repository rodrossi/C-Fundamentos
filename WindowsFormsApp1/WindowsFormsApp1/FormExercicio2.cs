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
    public partial class FormExercicio2 : Form
    {
        public FormExercicio2()
        {
            InitializeComponent();
        }

        private void TxtPrimNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculo_Click(object sender, EventArgs e)
        {

            /*Elabore um programa em C# que apresenta que coleta 
            dois números quaisquer(A e B) informados pelo usuário.
            Após informado o número o programa deverá apresentar
            o resultado da fórmula:
            X = ((A * 9) / (87 – B))² */

            double n1 = Convert.ToDouble(txtPrimNum.Text);
            double n2 = Convert.ToDouble(txtSegNum.Text);

            MessageBox.Show($" O resultado da formula é: {Math.Pow(((n1 * 9) / (87 - n2)), 2)}").ToString();
        }
    }
}
