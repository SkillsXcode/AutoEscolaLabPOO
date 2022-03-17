namespace AutoEscolaTrevo
{
    partial class frmGerenciarPagamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarPagamentos));
            this.pcbGerenciarPagamentos = new System.Windows.Forms.PictureBox();
            this.dataViewListagemVendas = new System.Windows.Forms.DataGridView();
            this.lblSelecaoPagamentos = new System.Windows.Forms.Label();
            this.btnPagarVenda = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewListagemVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbGerenciarPagamentos
            // 
            this.pcbGerenciarPagamentos.Image = ((System.Drawing.Image)(resources.GetObject("pcbGerenciarPagamentos.Image")));
            this.pcbGerenciarPagamentos.Location = new System.Drawing.Point(16, 16);
            this.pcbGerenciarPagamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGerenciarPagamentos.Name = "pcbGerenciarPagamentos";
            this.pcbGerenciarPagamentos.Size = new System.Drawing.Size(128, 103);
            this.pcbGerenciarPagamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGerenciarPagamentos.TabIndex = 3;
            this.pcbGerenciarPagamentos.TabStop = false;
            // 
            // dataViewListagemVendas
            // 
            this.dataViewListagemVendas.AllowUserToAddRows = false;
            this.dataViewListagemVendas.AllowUserToDeleteRows = false;
            this.dataViewListagemVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewListagemVendas.Location = new System.Drawing.Point(16, 232);
            this.dataViewListagemVendas.Name = "dataViewListagemVendas";
            this.dataViewListagemVendas.RowHeadersWidth = 51;
            this.dataViewListagemVendas.RowTemplate.Height = 24;
            this.dataViewListagemVendas.Size = new System.Drawing.Size(776, 472);
            this.dataViewListagemVendas.TabIndex = 4;
            // 
            // lblSelecaoPagamentos
            // 
            this.lblSelecaoPagamentos.AutoSize = true;
            this.lblSelecaoPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblSelecaoPagamentos.Location = new System.Drawing.Point(240, 40);
            this.lblSelecaoPagamentos.Name = "lblSelecaoPagamentos";
            this.lblSelecaoPagamentos.Size = new System.Drawing.Size(570, 58);
            this.lblSelecaoPagamentos.TabIndex = 13;
            this.lblSelecaoPagamentos.Text = "Seleção de Pagamentos";
            // 
            // btnPagarVenda
            // 
            this.btnPagarVenda.BackColor = System.Drawing.Color.Black;
            this.btnPagarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPagarVenda.ForeColor = System.Drawing.Color.Yellow;
            this.btnPagarVenda.Location = new System.Drawing.Point(808, 632);
            this.btnPagarVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagarVenda.Name = "btnPagarVenda";
            this.btnPagarVenda.Size = new System.Drawing.Size(168, 72);
            this.btnPagarVenda.TabIndex = 14;
            this.btnPagarVenda.Text = "Pagar";
            this.btnPagarVenda.UseVisualStyleBackColor = false;
            this.btnPagarVenda.Click += new System.EventHandler(this.btnPagarVenda_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(872, 8);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 40);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBuscarCliente.Location = new System.Drawing.Point(16, 192);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(568, 34);
            this.txtBuscarCliente.TabIndex = 15;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(608, 184);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(184, 40);
            this.btnBuscarCliente.TabIndex = 14;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmGerenciarPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPagarVenda);
            this.Controls.Add(this.lblSelecaoPagamentos);
            this.Controls.Add(this.dataViewListagemVendas);
            this.Controls.Add(this.pcbGerenciarPagamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioGerenciarPagamentos";
            this.Load += new System.EventHandler(this.frmGerenciarPagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewListagemVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbGerenciarPagamentos;
        private System.Windows.Forms.DataGridView dataViewListagemVendas;
        private System.Windows.Forms.Label lblSelecaoPagamentos;
        private System.Windows.Forms.Button btnPagarVenda;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}