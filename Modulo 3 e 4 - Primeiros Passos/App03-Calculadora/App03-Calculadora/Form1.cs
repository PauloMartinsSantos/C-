using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace App03_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor;
            int quantidade;
            double resultado;

            if (txtBoxValor.Text == string.Empty )
            {
                MessageBox.Show("Preencha o Valor do produto");
            }
            else if (Regex.IsMatch(txtBoxValor.Text, @"^[A - Za - záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ,.;:/?°<>´`=_¹²³£¢¬{[}}ºç!@#$%¨&*()_*-+.]+$"))
            {
                MessageBox.Show("[ERRO] Digite um valor válido");

            }
            else if(txtBoxQuantidade.Text == string.Empty)
            {
                MessageBox.Show("Preencha a quantidade");
            }

            else if (Regex.IsMatch(txtBoxQuantidade.Text, @"^[0-9]+$"))
            {
                    valor = Convert.ToDouble(txtBoxValor.Text);
                    quantidade = Convert.ToInt32(txtBoxQuantidade.Text);
                    resultado = valor * quantidade;
                    lblTotal.Text = Convert.ToString(resultado);
                }
                else
                {
                    MessageBox.Show("[ERRO] Digite um valor válido");
                }                  
                    
            }            
        }
    }

