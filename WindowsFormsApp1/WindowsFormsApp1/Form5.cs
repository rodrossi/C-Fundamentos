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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void BtnCalcIdade_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento = DateTime.Parse(txtDtNascimento.Text);
            int idade = DateTime.Today.Year - dataNascimento.Year;

            if (DateTime.Today.Month < dataNascimento.Month)
            {
                idade--;
            }

            if (DateTime.Today.Month == dataNascimento.Month)
            {
                if (DateTime.Today.Day < dataNascimento.Day)
                {
                    idade--;
                }
            }

            MessageBox.Show($"Sua idade é: {idade}");


        }
    }
}
