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
            this.btnGerenciarServicos = new System.Windows.Forms.Button();
            this.btnGerenciarCliente = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbGerenciarCliente = new System.Windows.Forms.PictureBox();
            this.pcbGerenciarServico = new System.Windows.Forms.PictureBox();
            this.pcbGerenciarPagamentos = new System.Windows.Forms.PictureBox();
            this.btnInserirPagamento = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerenciarServicos
            // 
            this.btnGerenciarServicos.BackColor = System.Drawing.Color.Black;
            this.btnGerenciarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGerenciarServicos.ForeColor = System.Drawing.Color.White;
            this.btnGerenciarServicos.Location = new System.Drawing.Point(379, 228);
            this.btnGerenciarServicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerenciarServicos.Name = "btnGerenciarServicos";
            this.btnGerenciarServicos.Size = new System.Drawing.Size(200, 39);
            this.btnGerenciarServicos.TabIndex = 1;
            this.btnGerenciarServicos.Text = "Gerenciar Serviços";
            this.btnGerenciarServicos.UseVisualStyleBackColor = false;
            this.btnGerenciarServicos.Click += new System.EventHandler(this.btnGerenciarServicos_Click);
            // 
            // btnGerenciarCliente
            // 
            this.btnGerenciarCliente.BackColor = System.Drawing.Color.Black;
            this.btnGerenciarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGerenciarCliente.ForeColor = System.Drawing.Color.White;
            this.btnGerenciarCliente.Location = new System.Drawing.Point(54, 228);
            this.btnGerenciarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerenciarCliente.Name = "btnGerenciarCliente";
            this.btnGerenciarCliente.Size = new System.Drawing.Size(200, 39);
            this.btnGerenciarCliente.TabIndex = 1;
            this.btnGerenciarCliente.Text = "Gerenciar Cliente";
            this.btnGerenciarCliente.UseVisualStyleBackColor = false;
            this.btnGerenciarCliente.Click += new System.EventHandler(this.btnGerenciarCliente_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.Black;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Location = new System.Drawing.Point(704, 224);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(200, 39);
            this.btnVendas.TabIndex = 11;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(736, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pcbGerenciarCliente
            // 
            this.pcbGerenciarCliente.Image = global::AutoEscolaTrevo.Properties.Resources.client;
            this.pcbGerenciarCliente.Location = new System.Drawing.Point(90, 120);
            this.pcbGerenciarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGerenciarCliente.Name = "pcbGerenciarCliente";
            this.pcbGerenciarCliente.Size = new System.Drawing.Size(128, 103);
            this.pcbGerenciarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGerenciarCliente.TabIndex = 2;
            this.pcbGerenciarCliente.TabStop = false;
            // 
            // pcbGerenciarServico
            // 
            this.pcbGerenciarServico.Image = ((System.Drawing.Image)(resources.GetObject("pcbGerenciarServico.Image")));
            this.pcbGerenciarServico.Location = new System.Drawing.Point(416, 120);
            this.pcbGerenciarServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGerenciarServico.Name = "pcbGerenciarServico";
            this.pcbGerenciarServico.Size = new System.Drawing.Size(128, 103);
            this.pcbGerenciarServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGerenciarServico.TabIndex = 0;
            this.pcbGerenciarServico.TabStop = false;
            // 
            // pcbGerenciarPagamentos
            // 
            this.pcbGerenciarPagamentos.Image = ((System.Drawing.Image)(resources.GetObject("pcbGerenciarPagamentos.Image")));
            this.pcbGerenciarPagamentos.Location = new System.Drawing.Point(90, 384);
            this.pcbGerenciarPagamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGerenciarPagamentos.Name = "pcbGerenciarPagamentos";
            this.pcbGerenciarPagamentos.Size = new System.Drawing.Size(128, 103);
            this.pcbGerenciarPagamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGerenciarPagamentos.TabIndex = 12;
            this.pcbGerenciarPagamentos.TabStop = false;
            // 
            // btnInserirPagamento
            // 
            this.btnInserirPagamento.BackColor = System.Drawing.Color.Black;
            this.btnInserirPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnInserirPagamento.ForeColor = System.Drawing.Color.White;
            this.btnInserirPagamento.Location = new System.Drawing.Point(40, 512);
            this.btnInserirPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInserirPagamento.Name = "btnInserirPagamento";
            this.btnInserirPagamento.Size = new System.Drawing.Size(200, 39);
            this.btnInserirPagamento.TabIndex = 1;
            this.btnInserirPagamento.Text = "Inserir Pagamento";
            this.btnInserirPagamento.UseVisualStyleBackColor = false;
            this.btnInserirPagamento.Click += new System.EventHandler(this.btnInserirPagamento_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(728, 352);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.BackColor = System.Drawing.Color.Black;
            this.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(712, 504);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(200, 39);
            this.btnGerarRelatorio.TabIndex = 13;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // frmGerenciamentoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.pcbGerenciarPagamentos);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInserirPagamento);
            this.Controls.Add(this.btnGerenciarCliente);
            this.Controls.Add(this.pcbGerenciarCliente);
            this.Controls.Add(this.btnGerenciarServicos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pcbGerenciarServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciamentoGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento Geral";
            this.Load += new System.EventHandler(this.frmGerenciamentoGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbGerenciarServico;
        private System.Windows.Forms.Button btnGerenciarServicos;
        private System.Windows.Forms.PictureBox pcbGerenciarCliente;
        private System.Windows.Forms.Button btnGerenciarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.PictureBox pcbGerenciarPagamentos;
        private System.Windows.Forms.Button btnInserirPagamento;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGerarRelatorio;
    }
}

