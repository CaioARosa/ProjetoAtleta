namespace ProjetoAtleta
{
    partial class Frm_pessoa
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnIdade = new System.Windows.Forms.Button();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 85);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(105, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data de nascimento:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 136);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(135, 133);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(78, 172);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar Dados";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnIdade
            // 
            this.btnIdade.Location = new System.Drawing.Point(78, 201);
            this.btnIdade.Name = "btnIdade";
            this.btnIdade.Size = new System.Drawing.Size(100, 23);
            this.btnIdade.TabIndex = 7;
            this.btnIdade.Text = "Calcular idade";
            this.btnIdade.UseVisualStyleBackColor = true;
            this.btnIdade.Click += new System.EventHandler(this.btnIdade_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(109, 237);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(78, 266);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 9;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(135, 82);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 10;
            // 
            // Frm_pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 334);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.btnIdade);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNome);
            this.Name = "Frm_pessoa";
            this.Text = "PESSOA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtDataNascimento;
    }
}

