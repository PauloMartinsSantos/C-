namespace Formulario_Padrao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.radioButtonPF = new System.Windows.Forms.RadioButton();
            this.radioButtonPJ = new System.Windows.Forms.RadioButton();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAbertura = new System.Windows.Forms.Label();
            this.labelNasc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxLista = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(140, 36);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(78, 25);
            this.textBoxID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.Location = new System.Drawing.Point(140, 94);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(660, 25);
            this.textBoxNome.TabIndex = 3;
            // 
            // radioButtonPF
            // 
            this.radioButtonPF.AutoSize = true;
            this.radioButtonPF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPF.Location = new System.Drawing.Point(140, 140);
            this.radioButtonPF.Name = "radioButtonPF";
            this.radioButtonPF.Size = new System.Drawing.Size(106, 21);
            this.radioButtonPF.TabIndex = 4;
            this.radioButtonPF.TabStop = true;
            this.radioButtonPF.Text = "Pessoa Física";
            this.radioButtonPF.UseVisualStyleBackColor = true;
            this.radioButtonPF.CheckedChanged += new System.EventHandler(this.radioButtonPF_CheckedChanged);
            // 
            // radioButtonPJ
            // 
            this.radioButtonPJ.AutoSize = true;
            this.radioButtonPJ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPJ.Location = new System.Drawing.Point(274, 140);
            this.radioButtonPJ.Name = "radioButtonPJ";
            this.radioButtonPJ.Size = new System.Drawing.Size(120, 21);
            this.radioButtonPJ.TabIndex = 5;
            this.radioButtonPJ.TabStop = true;
            this.radioButtonPJ.Text = "Pessoa Jurídica";
            this.radioButtonPJ.UseVisualStyleBackColor = true;
            this.radioButtonPJ.CheckedChanged += new System.EventHandler(this.radioButtonPJ_CheckedChanged);
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCNPJ.Location = new System.Drawing.Point(75, 187);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(50, 16);
            this.labelCNPJ.TabIndex = 6;
            this.labelCNPJ.Text = "CNPJ:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCPF.Location = new System.Drawing.Point(84, 187);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(40, 16);
            this.labelCPF.TabIndex = 7;
            this.labelCPF.Text = "CPF:";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTipo.Location = new System.Drawing.Point(140, 187);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(254, 25);
            this.textBoxTipo.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // labelAbertura
            // 
            this.labelAbertura.AutoSize = true;
            this.labelAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAbertura.Location = new System.Drawing.Point(52, 240);
            this.labelAbertura.Name = "labelAbertura";
            this.labelAbertura.Size = new System.Drawing.Size(70, 16);
            this.labelAbertura.TabIndex = 11;
            this.labelAbertura.Text = "Abertura:";
            // 
            // labelNasc
            // 
            this.labelNasc.AutoSize = true;
            this.labelNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNasc.Location = new System.Drawing.Point(33, 240);
            this.labelNasc.Name = "labelNasc";
            this.labelNasc.Size = new System.Drawing.Size(93, 16);
            this.labelNasc.TabIndex = 10;
            this.labelNasc.Text = "Nascimento:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(140, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLista
            // 
            this.textBoxLista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLista.Location = new System.Drawing.Point(12, 426);
            this.textBoxLista.Multiline = true;
            this.textBoxLista.Name = "textBoxLista";
            this.textBoxLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLista.Size = new System.Drawing.Size(788, 193);
            this.textBoxLista.TabIndex = 15;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEstado.Location = new System.Drawing.Point(57, 289);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(60, 16);
            this.labelEstado.TabIndex = 17;
            this.labelEstado.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia - BA",
            "Ceará - CE",
            "Distrito Federal - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO"});
            this.comboBoxEstado.Location = new System.Drawing.Point(140, 289);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(254, 23);
            this.comboBoxEstado.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 674);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textBoxLista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAbertura);
            this.Controls.Add(this.labelNasc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelCNPJ);
            this.Controls.Add(this.radioButtonPJ);
            this.Controls.Add(this.radioButtonPF);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário_Padrão";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxID;
        private Label label2;
        private TextBox textBoxNome;
        private RadioButton radioButtonPF;
        private RadioButton radioButtonPJ;
        private Label labelCNPJ;
        private Label labelCPF;
        private TextBox textBoxTipo;
        private DateTimePicker dateTimePicker1;
        private Label labelAbertura;
        private Label labelNasc;
        private Button button1;
        private TextBox textBoxLista;
        private Label labelEstado;
        private ComboBox comboBoxEstado;
    }
}