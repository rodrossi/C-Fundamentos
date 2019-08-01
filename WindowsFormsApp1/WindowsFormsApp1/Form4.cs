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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {


            decimal saldo = Convert.ToDecimal(txtSaldo.Text);
            DateTime previsaoSaque = Convert.ToDateTime(txtPsaque.Text);
            int totalMeses = Convert.ToInt32((previsaoSaque - DateTime.Today).TotalDays/30);
            decimal reajuste = 0.37m/100;

            for (int i = 0; i < totalMeses; i++)
            {
                saldo += saldo * reajuste;
            }

            //decimal rendimento = saldo * reajuste * totalMeses + saldo;

            MessageBox.Show($"O rendimento é:  {(saldo).ToString("C") } ");

        }
    }
}
