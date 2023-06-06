using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA.NET
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }
        //Metódo para a aplicação de números na TxtBox, aplicados a todos os números.
        private void aplicarNumero(object sender, EventArgs e)
        {
            var botao = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";
            txtResultado.Text += botao.Text;

        }

        // Códigos para realizar as opreerações no Botão de (=).
        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2= Convert.ToDouble(txtResultado.Text);

            if (operador == '+')
            {
                txtResultado.Text = (valor1 + valor2).ToString();
                valor1= Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '-')
            {
                txtResultado.Text = (valor1 - valor2).ToString();
                valor1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '×')
            {
                txtResultado.Text = (valor1 * valor2).ToString();
                valor1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '÷')
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text = (valor1 / valor2).ToString();
                    valor1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("ERRO!! Não pode dividir um valor por 0.");
                }
            }

        }

        // Comandos definidos para a função do Botão (Deletar).
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring (0, txtResultado.Text.Length - 1);

            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        // Comandos definidos para a função do Botão (C).
        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            operador = '\0';
            txtResultado.Text = "0"; 

        }

        // Comandos definidos para a função do Botão (CE).
        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0"; 
        }

        // Código para utilizar o (. ou ,) no programa.
        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        // Código especifico para utilizar a funcionalidade do (+/-).
        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtResultado.Text);
            valor1 *= -1;
            txtResultado.Text = valor1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Comandos definidos para realizar as operações de operadores espéciais no progrma.
        private void clicarOperador(object sender, EventArgs e)
        {
            var botao = ((Button)sender);
            operador = Convert.ToChar(botao.Tag);

            valor1 = Convert.ToDouble(txtResultado.Text);

            if (operador == '²')
            {
                valor1 = Math.Pow(valor1, 2);
                txtResultado.Text = valor1.ToString();
            }
            else if (operador == '√')
            {
                valor1 = Math.Sqrt(valor1);
                txtResultado.Text = valor1.ToString();
            }
            else if (operador == '%')
            {
                valor1 = valor1 /100;
                txtResultado.Text = valor1.ToString();
            }
            else if (operador == 'π')
            {
                txtResultado.Text =Convert.ToString(Math.PI);
            }
            else if (operador == '!')
            {
                for(double i=valor1-1; i>=1; i--)
                {
                    valor1 = valor1 * i;
                    txtResultado.Text = valor1.ToString();
                }
                
            }
            else if (operador == 'e')
            {
                txtResultado.Text = Convert.ToString(Math.E);
            }
            else if (operador == 'l')
            {
                txtResultado.Text = Convert.ToString(Math.Log10(valor1));
            }
            else if (operador == 'm')
            {
                if (valor1 < 0)
                {
                    txtResultado.Text = (valor1 * (-1)).ToString();
                }
            }
            else if (operador == 't')
            {
                txtResultado.Text = Convert.ToString(Math.Tan(valor1));
            }
            else if (operador == 's')
            {
                txtResultado.Text = Convert.ToString(Math.Sin(valor1));
            }
            else if (operador == 'c')
            {
                txtResultado.Text = Convert.ToString(Math.Cos(valor1));
            }
            else
            {
                txtResultado.Text = "0";
            }
        }
    }
}
