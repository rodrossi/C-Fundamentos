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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

            bool valido = true;

            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Preencher o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                valido = false;
            }
            
            if (txtSobrenome.Text == string.Empty)
            {
                MessageBox.Show("Preencher Sobrenome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                valido = false;
            }

            if (txtDtNascimento.Text == string.Empty)

            {
                MessageBox.Show("Preencher Data de Nascimento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                valido = false;
            }
            //Se código estiver invalido sai fora.
            if (valido == false)
            {
                return;
            }

            string nome;
            string sobreNome;
            DateTime dataNascimento;

            nome = txtNome.Text;
            sobreNome = txtSobrenome.Text;
            dataNascimento = Convert.ToDateTime(txtDtNascimento.Text);


        





            MessageBox.Show($@"Nome: {nome} 
Sobrenome: {sobreNome}
Data de Nacimento {dataNascimento}");


            
        }
    }
}
