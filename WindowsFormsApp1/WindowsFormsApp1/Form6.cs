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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtData.Text = string.Empty;
            txtDias.Text = string.Empty;
            txtMeses.Text = string.Empty;


        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(txtData.Text);
            int qtdDias = Convert.ToInt32(txtDias.Text);
            // data = data.AddDays(Convert.ToInt32(txtDias.Text));
            data = data.AddDays(qtdDias);

            //formato 06-08-2019
            //dd-MM-yy - Mostra o ano apenas com 2 digitos.
            //dd-MMM-yy - Mostra por extenso abreviado o mês
            //dd-MMMM-yy - MOstra por exrtenso o nome do mês inteiro.
            lblQtdDias.Text = data.ToString("dd-MMMM-yyyy");
            int qtdMeses = Convert.ToInt32(txtMeses.Text);
            var dataMeses = Convert.ToDateTime(txtData.Text);
            dataMeses = dataMeses.AddMonths(qtdMeses);
            lblQtdMeses.Text = dataMeses.ToString("dd/MM/yy");
            
            
        }
    }
}
