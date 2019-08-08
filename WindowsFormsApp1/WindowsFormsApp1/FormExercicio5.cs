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
    public partial class FormExercicio5 : Form
    {
        public FormExercicio5()
        {
            InitializeComponent();
        }

        private void BtnCalculoSalario_Click(object sender, EventArgs e)
        {
            string nome = (txtNome.Text).ToString();
            decimal salarioFixo = Convert.ToDecimal(txtsalarioFixo.Text);
            decimal volumeVenda = Convert.ToDecimal(txtvolumeVenda.Text);
            decimal salarioFinal = salarioFixo + (volumeVenda * 10 / 100);

            MessageBox.Show($"O salário do {nome} este mês é {(salarioFinal).ToString("C")}");
        }
    }
}
