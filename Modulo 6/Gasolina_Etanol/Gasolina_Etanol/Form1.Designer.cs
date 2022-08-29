namespace Gasolina_Etanol
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEtanol = new System.Windows.Forms.TextBox();
            this.textBoxGasolina = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Etanol     R$:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Gasolina R$:";
            // 
            // textBoxEtanol
            // 
            this.textBoxEtanol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEtanol.Location = new System.Drawing.Point(192, 25);
            this.textBoxEtanol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEtanol.Name = "textBoxEtanol";
            this.textBoxEtanol.Size = new System.Drawing.Size(55, 26);
            this.textBoxEtanol.TabIndex = 2;
            // 
            // textBoxGasolina
            // 
            this.textBoxGasolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGasolina.Location = new System.Drawing.Point(192, 65);
            this.textBoxGasolina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxGasolina.Name = "textBoxGasolina";
            this.textBoxGasolina.Size = new System.Drawing.Size(55, 26);
            this.textBoxGasolina.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(109, 116);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(115, 25);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "É mais vantajoso abastecer com:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(128, 214);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(56, 20);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "*** ***";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 280);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.textBoxGasolina);
            this.Controls.Add(this.textBoxEtanol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparador_Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEtanol;
        private System.Windows.Forms.TextBox textBoxGasolina;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultado;
    }
}

