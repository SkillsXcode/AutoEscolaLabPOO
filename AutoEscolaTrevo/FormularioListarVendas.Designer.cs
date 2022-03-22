namespace AutoEscolaTrevo
{
    partial class frmListarVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarVendas));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblListarVenda = new System.Windows.Forms.Label();
            this.dataViewListagemVendas = new System.Windows.Forms.DataGridView();
            this.btnFrmRegistrarNovasVendas = new System.Windows.Forms.Button();
            this.lblSinalMais = new System.Windows.Forms.Label();
            this.pcbCarrinoListagem = new System.Windows.Forms.PictureBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblItensVenda = new System.Windows.Forms.Label();
            this.lblResultadoNomeCliente = new System.Windows.Forms.Label();
            this.txtResultadoItens = new System.Windows.Forms.TextBox();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblResultadoValorVenda = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.lblResultadoFormaPagamento = new System.Windows.Forms.Label();
            this.lblResultadoQuantidadeParcelas = new System.Windows.Forms.Label();
            this.lblQuantidadeParcelas = new System.Windows.Forms.Label();
            this.lblResultadoDataVenda = new System.Windows.Forms.Label();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.lblResultadoValorParcela = new System.Windows.Forms.Label();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.lblResultadoDataVencimento = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewListagemVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrinoListagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(872, 24);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(123, 39);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblListarVenda
            // 
            this.lblListarVenda.AutoSize = true;
            this.lblListarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblListarVenda.Location = new System.Drawing.Point(312, 16);
            this.lblListarVenda.Name = "lblListarVenda";
            this.lblListarVenda.Size = new System.Drawing.Size(481, 58);
            this.lblListarVenda.TabIndex = 12;
            this.lblListarVenda.Text = "Listagem de Vendas";
            this.lblListarVenda.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataViewListagemVendas
            // 
            this.dataViewListagemVendas.AllowUserToAddRows = false;
            this.dataViewListagemVendas.AllowUserToDeleteRows = false;
            this.dataViewListagemVendas.AllowUserToOrderColumns = true;
            this.dataViewListagemVendas.AllowUserToResizeColumns = false;
            this.dataViewListagemVendas.AllowUserToResizeRows = false;
            this.dataViewListagemVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewListagemVendas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataViewListagemVendas.Location = new System.Drawing.Point(16, 248);
            this.dataViewListagemVendas.MultiSelect = false;
            this.dataViewListagemVendas.Name = "dataViewListagemVendas";
            this.dataViewListagemVendas.RowHeadersWidth = 51;
            this.dataViewListagemVendas.RowTemplate.Height = 24;
            this.dataViewListagemVendas.Size = new System.Drawing.Size(472, 432);
            this.dataViewListagemVendas.TabIndex = 13;
            this.dataViewListagemVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewListagemVendas_CellClick);
            this.dataViewListagemVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewListagemVendas_CellContentClick);
            // 
            // btnFrmRegistrarNovasVendas
            // 
            this.btnFrmRegistrarNovasVendas.BackColor = System.Drawing.Color.Black;
            this.btnFrmRegistrarNovasVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmRegistrarNovasVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFrmRegistrarNovasVendas.ForeColor = System.Drawing.Color.White;
            this.btnFrmRegistrarNovasVendas.Location = new System.Drawing.Point(768, 632);
            this.btnFrmRegistrarNovasVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFrmRegistrarNovasVendas.Name = "btnFrmRegistrarNovasVendas";
            this.btnFrmRegistrarNovasVendas.Size = new System.Drawing.Size(232, 48);
            this.btnFrmRegistrarNovasVendas.TabIndex = 14;
            this.btnFrmRegistrarNovasVendas.Text = "Registrar Vendas";
            this.btnFrmRegistrarNovasVendas.UseVisualStyleBackColor = false;
            this.btnFrmRegistrarNovasVendas.Click += new System.EventHandler(this.btnFrmRegistrarNovasVendas_Click);
            // 
            // lblSinalMais
            // 
            this.lblSinalMais.AutoSize = true;
            this.lblSinalMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblSinalMais.ForeColor = System.Drawing.Color.Red;
            this.lblSinalMais.Location = new System.Drawing.Point(720, 624);
            this.lblSinalMais.Name = "lblSinalMais";
            this.lblSinalMais.Size = new System.Drawing.Size(54, 58);
            this.lblSinalMais.TabIndex = 15;
            this.lblSinalMais.Text = "+";
            this.lblSinalMais.Click += new System.EventHandler(this.lblSinalMais_Click);
            // 
            // pcbCarrinoListagem
            // 
            this.pcbCarrinoListagem.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrinoListagem.Image")));
            this.pcbCarrinoListagem.Location = new System.Drawing.Point(24, 24);
            this.pcbCarrinoListagem.Name = "pcbCarrinoListagem";
            this.pcbCarrinoListagem.Size = new System.Drawing.Size(168, 153);
            this.pcbCarrinoListagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCarrinoListagem.TabIndex = 11;
            this.pcbCarrinoListagem.TabStop = false;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomeCliente.Location = new System.Drawing.Point(512, 104);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(66, 20);
            this.lblNomeCliente.TabIndex = 16;
            this.lblNomeCliente.Text = "Cliente:";
            this.lblNomeCliente.Visible = false;
            this.lblNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblItensVenda
            // 
            this.lblItensVenda.AutoSize = true;
            this.lblItensVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblItensVenda.Location = new System.Drawing.Point(512, 248);
            this.lblItensVenda.Name = "lblItensVenda";
            this.lblItensVenda.Size = new System.Drawing.Size(50, 20);
            this.lblItensVenda.TabIndex = 16;
            this.lblItensVenda.Text = "Itens:";
            this.lblItensVenda.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblResultadoNomeCliente
            // 
            this.lblResultadoNomeCliente.AutoSize = true;
            this.lblResultadoNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoNomeCliente.ForeColor = System.Drawing.Color.Red;
            this.lblResultadoNomeCliente.Location = new System.Drawing.Point(576, 104);
            this.lblResultadoNomeCliente.Name = "lblResultadoNomeCliente";
            this.lblResultadoNomeCliente.Size = new System.Drawing.Size(98, 20);
            this.lblResultadoNomeCliente.TabIndex = 16;
            this.lblResultadoNomeCliente.Text = "Não apague";
            this.lblResultadoNomeCliente.Visible = false;
            this.lblResultadoNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // txtResultadoItens
            // 
            this.txtResultadoItens.Location = new System.Drawing.Point(600, 168);
            this.txtResultadoItens.Multiline = true;
            this.txtResultadoItens.Name = "txtResultadoItens";
            this.txtResultadoItens.ReadOnly = true;
            this.txtResultadoItens.Size = new System.Drawing.Size(360, 152);
            this.txtResultadoItens.TabIndex = 17;
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValorVenda.Location = new System.Drawing.Point(512, 408);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(125, 20);
            this.lblValorVenda.TabIndex = 16;
            this.lblValorVenda.Text = "Valor da venda:";
            this.lblValorVenda.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblResultadoValorVenda
            // 
            this.lblResultadoValorVenda.AutoSize = true;
            this.lblResultadoValorVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoValorVenda.ForeColor = System.Drawing.Color.Red;
            this.lblResultadoValorVenda.Location = new System.Drawing.Point(728, 408);
            this.lblResultadoValorVenda.Name = "lblResultadoValorVenda";
            this.lblResultadoValorVenda.Size = new System.Drawing.Size(98, 20);
            this.lblResultadoValorVenda.TabIndex = 16;
            this.lblResultadoValorVenda.Text = "Não apague";
            this.lblResultadoValorVenda.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFormaPagamento.Location = new System.Drawing.Point(512, 368);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(172, 20);
            this.lblFormaPagamento.TabIndex = 16;
            this.lblFormaPagamento.Text = "Forma de pagamento:";
            this.lblFormaPagamento.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblResultadoFormaPagamento
            // 
            this.lblResultadoFormaPagamento.AutoSize = true;
            this.lblResultadoFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoFormaPagamento.ForeColor = System.Drawing.Color.Red;
            this.lblResultadoFormaPagamento.Location = new System.Drawing.Point(728, 368);
            this.lblResultadoFormaPagamento.Name = "lblResultadoFormaPagamento";
            this.lblResultadoFormaPagamento.Size = new System.Drawing.Size(98, 20);
            this.lblResultadoFormaPagamento.TabIndex = 16;
            this.lblResultadoFormaPagamento.Text = "Não apague";
            this.lblResultadoFormaPagamento.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblResultadoQuantidadeParcelas
            // 
            this.lblResultadoQuantidadeParcelas.AutoSize = true;
            this.lblResultadoQuantidadeParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoQuantidadeParcelas.ForeColor = System.Drawing.Color.Red;
            this.lblResultadoQuantidadeParcelas.Location = new System.Drawing.Point(728, 448);
            this.lblResultadoQuantidadeParcelas.Name = "lblResultadoQuantidadeParcelas";
            this.lblResultadoQuantidadeParcelas.Size = new System.Drawing.Size(98, 20);
            this.lblResultadoQuantidadeParcelas.TabIndex = 16;
            this.lblResultadoQuantidadeParcelas.Text = "Não apague";
            this.lblResultadoQuantidadeParcelas.Visible = false;
            this.lblResultadoQuantidadeParcelas.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblQuantidadeParcelas
            // 
            this.lblQuantidadeParcelas.AutoSize = true;
            this.lblQuantidadeParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuantidadeParcelas.Location = new System.Drawing.Point(512, 448);
            this.lblQuantidadeParcelas.Name = "lblQuantidadeParcelas";
            this.lblQuantidadeParcelas.Size = new System.Drawing.Size(191, 20);
            this.lblQuantidadeParcelas.TabIndex = 16;
            this.lblQuantidadeParcelas.Text = "Quantidade de parcelas:";
            this.lblQuantidadeParcelas.Visible = false;
            this.lblQuantidadeParcelas.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblResultadoDataVenda
            // 
            this.lblResultadoDataVenda.AutoSize = true;
            this.lblResultadoDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoDataVenda.ForeColor = System.Drawing.Color.Red;
            this.lblResultadoDataVenda.Location = new System.Drawing.Point(728, 488);
            this.lblResultadoDataVenda.Name = "lblResultadoDataVenda";
            this.lblResultadoDataVenda.Size = new System.Drawing.Size(98, 20);
            this.lblResultadoDataVenda.TabIndex = 16;
            this.lblResultadoDataVenda.Text = "Não apague";
            this.lblResultadoDataVenda.Visible = false;
            this.lblResultadoDataVenda.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDataVenda.Location = new System.Drawing.Point(512, 488);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(122, 20);
            this.lblDataVenda.TabIndex = 16;
            this.lblDataVenda.Text = "Data da venda:";
            this.lblDataVenda.Visible = false;
            this.lblDataVenda.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblResultadoValorParcela
            // 
            this.lblResultadoValorParcela.AutoSize = true;
            this.lblResultadoValorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoValorParcela.ForeColor = System.Drawing.Color.Red;
            this.lblResultadoValorParcela.Location = new System.Drawing.Point(728, 528);
            this.lblResultadoValorParcela.Name = "lblResultadoValorParcela";
            this.lblResultadoValorParcela.Size = new System.Drawing.Size(98, 20);
            this.lblResultadoValorParcela.TabIndex = 16;
            this.lblResultadoValorParcela.Text = "Não apague";
            this.lblResultadoValorParcela.Visible = false;
            this.lblResultadoValorParcela.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblValorParcela.Location = new System.Drawing.Point(512, 528);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(136, 20);
            this.lblValorParcela.TabIndex = 16;
            this.lblValorParcela.Text = "Valor da parcela:";
            this.lblValorParcela.Visible = false;
            this.lblValorParcela.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblResultadoDataVencimento
            // 
            this.lblResultadoDataVencimento.AutoSize = true;
            this.lblResultadoDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResultadoDataVencimento.ForeColor = System.Drawing.Color.Red;
            this.lblResultadoDataVencimento.Location = new System.Drawing.Point(728, 568);
            this.lblResultadoDataVencimento.Name = "lblResultadoDataVencimento";
            this.lblResultadoDataVencimento.Size = new System.Drawing.Size(98, 20);
            this.lblResultadoDataVencimento.TabIndex = 16;
            this.lblResultadoDataVencimento.Text = "Não apague";
            this.lblResultadoDataVencimento.Visible = false;
            this.lblResultadoDataVencimento.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDataVencimento.Location = new System.Drawing.Point(512, 568);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(163, 20);
            this.lblDataVencimento.TabIndex = 16;
            this.lblDataVencimento.Text = "Data do vencimento:";
            this.lblDataVencimento.Visible = false;
            this.lblDataVencimento.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // frmListarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.txtResultadoItens);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.lblDataVenda);
            this.Controls.Add(this.lblQuantidadeParcelas);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.lblItensVenda);
            this.Controls.Add(this.lblResultadoFormaPagamento);
            this.Controls.Add(this.lblResultadoDataVenda);
            this.Controls.Add(this.lblResultadoDataVencimento);
            this.Controls.Add(this.lblResultadoQuantidadeParcelas);
            this.Controls.Add(this.lblResultadoValorParcela);
            this.Controls.Add(this.lblResultadoValorVenda);
            this.Controls.Add(this.lblResultadoNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblSinalMais);
            this.Controls.Add(this.btnFrmRegistrarNovasVendas);
            this.Controls.Add(this.dataViewListagemVendas);
            this.Controls.Add(this.lblListarVenda);
            this.Controls.Add(this.pcbCarrinoListagem);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioListarVendas";
            this.Load += new System.EventHandler(this.FormularioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewListagemVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrinoListagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pcbCarrinoListagem;
        private System.Windows.Forms.Label lblListarVenda;
        private System.Windows.Forms.DataGridView dataViewListagemVendas;
        private System.Windows.Forms.Button btnFrmRegistrarNovasVendas;
        private System.Windows.Forms.Label lblSinalMais;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblItensVenda;
        private System.Windows.Forms.Label lblResultadoNomeCliente;
        private System.Windows.Forms.TextBox txtResultadoItens;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblResultadoValorVenda;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.Label lblResultadoFormaPagamento;
        private System.Windows.Forms.Label lblResultadoQuantidadeParcelas;
        private System.Windows.Forms.Label lblQuantidadeParcelas;
        private System.Windows.Forms.Label lblResultadoDataVenda;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.Label lblResultadoValorParcela;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label lblResultadoDataVencimento;
        private System.Windows.Forms.Label lblDataVencimento;
    }
}