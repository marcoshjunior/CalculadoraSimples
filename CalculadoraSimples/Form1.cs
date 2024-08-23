using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        double valor1;
        double valor2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
        }

        private void operacao_click(object sender, EventArgs e)
        {
            valor1 = Double.Parse(txt_num1.Text);
            valor2 = Double.Parse(txt_num2.Text);
            //obtem o texto do botao que eu clicar
            string tipo_operacao = (sender as Button).Text;
            //formatando a label
            lbl_resultado.Text = String.Format("{0} {1} {2} = {3}", valor1.ToString(), tipo_operacao, valor2.ToString(), operacao(tipo_operacao));
        }

        private string operacao(string tipo)
        {
            double resultado = 0;

            switch (tipo)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "x":
                    resultado = valor1 * valor2;
                    break;
                case "%":
                    resultado = valor1 / valor2;
                    break;
            }

            return resultado.ToString();
        }
    }
}
