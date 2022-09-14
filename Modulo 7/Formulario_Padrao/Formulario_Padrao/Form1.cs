namespace Formulario_Padrao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxLista.AppendText ("ID: " + textBoxID.Text + "Nome: " + textBoxNome.Text + "Tipo: " + textBoxTipo.Text + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelCPF.Visible = false;
            labelCNPJ.Visible = false;
            comboBoxEstado.Visible = false;
            dateTimePicker1.Visible = false;
            labelAbertura.Visible = false;
            labelEstado.Visible = false;
            labelNasc.Visible = false;
            textBoxTipo.Visible = false;
        }

        private void radioButtonPF_CheckedChanged(object sender, EventArgs e)
        {
            labelCPF.Visible = true;
            labelCNPJ.Visible = false;
            labelAbertura.Visible = false;
            textBoxTipo.Visible = true;
            labelNasc.Visible = true;
            labelEstado.Visible=true;
            comboBoxEstado.Visible = true;
            dateTimePicker1.Visible = true;

        }

        private void radioButtonPJ_CheckedChanged(object sender, EventArgs e)
        {
            labelCPF.Visible = false;
            labelNasc.Visible = false;

            labelCNPJ.Visible = true;
            labelAbertura.Visible = true;
            
            textBoxTipo.Visible = true;
            labelEstado.Visible = true;
            comboBoxEstado.Visible = true;
            dateTimePicker1.Visible = true;
        }
    }
}