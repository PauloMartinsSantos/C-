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

namespace Projeto_1___Calculadora_de_Rendimentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal aporte;
            int prazo;
            decimal taxa;
            decimal valorFinal;
            string msgErro;
                        
            if(txtBoxAporte.Text == string.Empty || txtBoxPrazo.Text == string.Empty || txtBoxTaxa.Text == string.Empty)
            {
                MessageBox.Show("[ERRO] preencha todos os campos");
            }

            else if (Regex.IsMatch(txtBoxAporte.Text,@"^|^\d +$"))
            {
                msgErro = "APORTE";
                MessageBox.Show("[ERRO] Valor digitado {0} no inválido!",msgErro);

            }

            else {

                aporte = Convert.ToDecimal(txtBoxAporte.Text);
                prazo = Convert.ToInt32(txtBoxPrazo.Text);
                taxa = Convert.ToDecimal(txtBoxTaxa.Text);

                taxa = taxa / 100;
            valorFinal = aporte;            

            for(int i = 0; i < prazo; i++)
            {
                valorFinal = valorFinal + (valorFinal * taxa);
            }

            string[] vf;
            vf = Convert.ToString(valorFinal).Split(',');

            txtBoxValortotal.Text = vf[0] + "," + vf[1].Substring(0,2);
            
            decimal lucro = valorFinal - aporte;
            
            string[] lf;
            lf = Convert.ToString(lucro).Split(',');
            txtBoxLucro.Text = lf[0] + "," + lf[1].Substring(0, 2);
            }


        }
    }
}
