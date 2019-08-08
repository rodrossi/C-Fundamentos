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
    public partial class frmAluno : Form
    {
        string[] alunos = new string[8];
        public frmAluno()
        {
            InitializeComponent();
            lblTamanhoArray.Text = string.Empty;

            alunos[0] = "Rossi";
            alunos[1] = "Patrick";
            alunos[2] = "Erick";
            alunos[3] = "Vivian";
            alunos[4] = "Rogerio";
            alunos[5] = "Genna";
            alunos[6] = "Victor";
            alunos[7] = "Fabio";

        }


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

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            #region Primeiro Item
            if (alunos.Length >= 1)
            {
                lblPrimeiroItem.Text = alunos[0];
            }
            #endregion

            #region Primeira Letra R

            lblNomeLetraR.Text = string.Empty;
            foreach (var aluno in alunos)
            {
                if (aluno.StartsWith("R"))
                {
                    lblNomeLetraR.Text += $"{aluno},";
                }
            }
            #endregion
            {


            }


            

        }
    }
}
