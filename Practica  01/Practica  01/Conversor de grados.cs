using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica__01
{
    public partial class Form1 : Form

    {
        private double valor; //Guardo el valor de entrada en la variable Valor para invocarla
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnC_F_Click(object sender, EventArgs e)
        {
            double fahrenheit = (valor * 9.0 / 5.0) + 32;
            LbResultado.Text = fahrenheit.ToString() + " ° F";


        }

        private void TxtEntrada_TextChanged(object sender, EventArgs e)
        {
            // Validar si el texto es un número válido
            if (!double.TryParse(TxtEntrada.Text, out valor))

            {
                // Mostrar un mensaje de error si la conversión falla en el label Resultado
               
                MessageBox.Show("Ingresa un valor numerico valido" );

            }


        }
        private void LbResultado_Click(object sender, EventArgs e)
        {

        }

        private void BtnC_K_Click(object sender, EventArgs e)
        {
            double Kelvin = (valor + 273.15);
            LbResultado.Text = Kelvin.ToString() + " ° K";
        }

        private void BtnF_C_Click(object sender, EventArgs e)
        {
            double Centigrados = (5 * (valor - 32)) / 9;
            LbResultado.Text = Centigrados.ToString() + " ° C"; 

        }
        private void BtnF_K_Click(object sender, EventArgs e)
        {
            double Kelvin = ((5 * (valor-32)) / 9) + 273.15;
            LbResultado.Text = Kelvin.ToString() + "° K";
        }

        private void BtnK_C_Click(object sender, EventArgs e)
        {
            double Centigrado = valor - 273.15;
            LbResultado.Text = Centigrado.ToString() + "° C";

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtEntrada.Clear();
            LbResultado.Text = "Resultado";
        }
    }
}
