namespace AutoEscolaTrevo
{
    partial class frmGerenciamentoGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciamentoGeral));
            this.pcbGerenciarServico = new System.Windows.Forms.PictureBox();
            this.btnGerenciarServicos = new System.Windows.Forms.Button();
            this.pcbGerenciarCliente = new System.Windows.Forms.PictureBox();
            this.btnGerenciarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbGerenciarServico
            // 
            this.pcbGerenciarServico.Image = ((System.Drawing.Image)(resources.GetObject("pcbGerenciarServico.Image")));
            this.pcbGerenciarServico.Location = new System.Drawing.Point(443, 14);
            this.pcbGerenciarServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGerenciarServico.Name = "pcbGerenciarServico";
            this.pcbGerenciarServico.Size = new System.Drawing.Size(128, 103);
            this.pcbGerenciarServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGerenciarServico.TabIndex = 0;
            this.pcbGerenciarServico.TabStop = false;
            // 
            // btnGerenciarServicos
            // 
            this.btnGerenciarServicos.BackColor = System.Drawing.Color.Black;
            this.btnGerenciarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGerenciarServicos.ForeColor = System.Drawing.Color.White;
            this.btnGerenciarServicos.Location = new System.Drawing.Point(407, 130);
            this.btnGerenciarServicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerenciarServicos.Name = "btnGerenciarServicos";
            this.btnGerenciarServicos.Size = new System.Drawing.Size(200, 39);
            this.btnGerenciarServicos.TabIndex = 1;
            this.btnGerenciarServicos.Text = "Gerenciar Serviços";
            this.btnGerenciarServicos.UseVisualStyleBackColor = false;
            this.btnGerenciarServicos.Click += new System.EventHandler(this.btnGerenciarServicos_Click);
            // 
            // pcbGerenciarCliente
            // 
            this.pcbGerenciarCliente.Image = global::AutoEscolaTrevo.Properties.Resources.client;
            this.pcbGerenciarCliente.Location = new System.Drawing.Point(121, 14);
            this.pcbGerenciarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGerenciarCliente.Name = "pcbGerenciarCliente";
            this.pcbGerenciarCliente.Size = new System.Drawing.Size(128, 103);
            this.pcbGerenciarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGerenciarCliente.TabIndex = 2;
            this.pcbGerenciarCliente.TabStop = false;
            // 
            // btnGerenciarCliente
            // 
            this.btnGerenciarCliente.BackColor = System.Drawing.Color.Black;
            this.btnGerenciarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGerenciarCliente.ForeColor = System.Drawing.Color.White;
            this.btnGerenciarCliente.Location = new System.Drawing.Point(91, 133);
            this.btnGerenciarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGerenciarCliente.Name = "btnGerenciarCliente";
            this.btnGerenciarCliente.Size = new System.Drawing.Size(200, 39);
            this.btnGerenciarCliente.TabIndex = 3;
            this.btnGerenciarCliente.Text = "Gerenciar Cliente";
            this.btnGerenciarCliente.UseVisualStyleBackColor = false;
            this.btnGerenciarCliente.Click += new System.EventHandler(this.btnGerenciarCliente_Click);
            // 
            // frmGerenciamentoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.btnGerenciarCliente);
            this.Controls.Add(this.pcbGerenciarCliente);
            this.Controls.Add(this.btnGerenciarServicos);
            this.Controls.Add(this.pcbGerenciarServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGerenciamentoGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento Geral";
            this.Load += new System.EventHandler(this.frmGerenciamentoGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbGerenciarServico;
        private System.Windows.Forms.Button btnGerenciarServicos;
        private System.Windows.Forms.PictureBox pcbGerenciarCliente;
        private System.Windows.Forms.Button btnGerenciarCliente;
    }
}

