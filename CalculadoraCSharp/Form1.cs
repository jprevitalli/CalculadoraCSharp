using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCSharp
{
    public partial class CALCULADORA : Form
    {
        //Defini as variáveis globais (public) para usar nos cálculos
        
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";


        public CALCULADORA()
        {
            InitializeComponent();
        }

      

        private void btn0_Click(object sender, EventArgs e)
        {
            // Ele pega o 0 e adiciona concatenando. Não subscreve, ele 'seta" dentro nele mesmo
            
            // txtResultado.Text = txtResultado.Text + "0"; (ou pode simplificar)

            txtResultado.Text += "0"; 

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            //converti a variavel para decimal e defino o parâmetro
            valor1 = decimal.Parse (txtResultado.Text, CultureInfo.InvariantCulture);
            // Acima eu importei o CultureInfo para a biblioteca com SystemGlobalization, apertando o "Ctrl+."
            // e ele converte o texto com a pontuação para o formato correto do decimal.

            //Limpo o campo
            txtResultado.Text = "";
            // Informo a operação que vou realizar
            operacao = "SOMA";
            //Informo o usuário
            lblOperacao.Text = "+";


        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString (valor1 + valor2);
            }

            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }

            else if (operacao == "MULTI")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }

            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }


        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULTI";
            lblOperacao.Text = "x";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            // Para limpar todos os campos, variáveis e label
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }
    }
}
