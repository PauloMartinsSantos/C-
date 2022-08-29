using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolina_Etanol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double etanol = Convert.ToDouble(textBoxEtanol.Text);
            double gasolina = Convert.ToDouble(textBoxGasolina.Text);
            double resultado;

            resultado = etanol / gasolina;

            if(resultado < 0.7)
            {
                labelResultado.Text = "ETANOL";
            }
            else
            {
                labelResultado.Text = "GASOLINA";
            }

            // TO DO: Tratamento na entrada de dados
        }
    }
}
