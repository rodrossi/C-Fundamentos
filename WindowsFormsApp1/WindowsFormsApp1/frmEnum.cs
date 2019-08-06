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
    public partial class frmEnum : Form
    {
        public frmEnum()
        {
            InitializeComponent();
        }

        enum TimeEnum
        {
            Bambis,
            CorinthiansBiMundial,
            Santos,
            Porkinhas,
            Portuguesa

        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.ToLower().Trim();
            TimeEnum time;

            if (nome == "fabio" || nome == "kleber" || nome == "rossi" || nome == "vivian")
            {
                time = TimeEnum.CorinthiansBiMundial;
            }
            else if (nome == "patrick" || nome == "erik")
            {
                time = TimeEnum.Porkinhas;
            }
            else if (nome == "victor" || nome == "genna")
            {
                time = TimeEnum.Bambis;
            }
            else if (nome == "rogerio")
            {
                time = TimeEnum.Santos;
            }
            else
            {
                time = TimeEnum.Portuguesa;
            }
            switch (time)
            {
                case TimeEnum.Bambis:
                   txtNome.Text =($"{nome} seu time é de baitolão");
                    break;
                case TimeEnum.CorinthiansBiMundial:
                   txtNome.Text =($"{nome} seu time é lendario");
                    break;
                case TimeEnum.Santos:
                   txtNome.Text =($"{nome} seu time só na era Pelé");
                    break;
                case TimeEnum.Porkinhas:
                   txtNome.Text =($"{nome} Seu time é um lixo sem mundial");
                    break;
                case TimeEnum.Portuguesa:
                   txtNome.Text =($"{nome} Seu time da dó");
                    break;
                default:
                   txtNome.Text =($"Vai se foder");
                    break;
            }
            {

            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
        }
    }
}
