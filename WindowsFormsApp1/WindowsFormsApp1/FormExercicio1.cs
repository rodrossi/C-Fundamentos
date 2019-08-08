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
    public partial class FormExercicio1 : Form
    {
        public FormExercicio1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //Elabore um programa em C# que apresenta que 
            //coleta um número qualquer informado pelo usuário.
            //Após informado o número o programa deverá
            //apresentar se o número multiplicado por ele mesmo.

            decimal numeroDigitado = Convert.ToDecimal(txtNum.Text);
            numeroDigitado = numeroDigitado * numeroDigitado;

            MessageBox.Show($"A Multiplicação é {numeroDigitado}");
        }
    }
}
