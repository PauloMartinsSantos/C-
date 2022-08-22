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

            else if (Regex.IsMatch(txtBoxAporte.Text, @"^[A - Za - záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$"))
            {
                //Obs: Campos tratados apenas para não aceitar letras, demais tratamentos serão desenvolvidos em exemplos futuros

                msgErro = "APORTE";
                MessageBox.Show("[ERRO] Valor digitado inválido no campo: " + msgErro);

            }

            else if (Regex.IsMatch(txtBoxPrazo.Text, @"^[A - Za - záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$"))
            {
                //Obs: Campos tratados apenas para não aceitar letras, demais tratamentos serão desenvolvidos em exemplos futuros

                msgErro = "PRAZO";
                MessageBox.Show("[ERRO] Valor digitado inválido no campo: " + msgErro);

            }

            else if (Regex.IsMatch(txtBoxTaxa.Text, @"^[A - Za - záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$"))
            {
                //Obs: Campos tratados apenas para não aceitar letras, demais tratamentos serão desenvolvidos em exemplos futuros

                msgErro = "TAXA";
                MessageBox.Show("[ERRO] Valor digitado inválido no campo: " + msgErro);

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
