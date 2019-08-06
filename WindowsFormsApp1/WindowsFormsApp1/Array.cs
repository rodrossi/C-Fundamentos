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
    public partial class Array : Form
    {
        public Array()
        {
            InitializeComponent();
            lblTamanhoArray.Text = string.Empty;
        }

        string[] alunos = new string[8];
        private void BtnOK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] == null)
                {
                    alunos[i] = txtNome.Text;
                    lblTamanhoArray.Text += $"{txtNome.Text} \r\n";
                    txtNome.Text = string.Empty;
                    break;
                }
            }
          
        }
    }
}
