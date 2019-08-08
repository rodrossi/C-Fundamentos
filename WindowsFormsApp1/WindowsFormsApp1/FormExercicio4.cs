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
    public partial class FormExercicio4 : Form
    {
        public FormExercicio4()
        {
            InitializeComponent();
        }

        private void BtnCalcQtdLitros_Click(object sender, EventArgs e)
        {
            /*Elabore um programa em C# que efetue o cálculo da quantidade 
            de litros de combustível gastos em uma viagem, utilizando um automóvel 
            que faz 12 km por litro. Para obter o cálculo, o usuário deve fornecer 
            o tempo gasto (tempo) e a velocidade média (velocidade) durante a viagem. 
            Desta fórmula será possível obter a distância percorrida com a fórmula 
            (distância ß tempo * velocidade). Possuindo o valor da distância , basta 
            calcular a quantidade de litros de combustível utilizada na viagem utilizando a 
            fórmula (litros = distância/12). Ao final, o algoritmo deve apresentar os valores 
            da velocidade média (velocidade), tempo gasto na viagem (tempo), a distância 
            percorrida (distância) e a quantidade de litros (litros) utilizados na viagem*/

           var tempoGasto = TimeSpan.Parse(txtTempoGasto.Text).TotalHours;
            var velocidademedia = Convert.ToDouble(txtVelocidadeMedia.Text);
            var distancia = tempoGasto * velocidademedia;
            var quantidadeLitros = distancia / 12;

            MessageBox.Show($"Velocidade Média {velocidademedia}KM, Tempo Gasto {txtTempoGasto.Text}Horas, Distancia percorrida {distancia}KM, Quantidade de Litros {quantidadeLitros}Litros");


        }
    }
}
