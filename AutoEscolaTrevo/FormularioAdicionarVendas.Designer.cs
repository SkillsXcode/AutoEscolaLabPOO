namespace AutoEscolaTrevo
{
    partial class frmAdicionarVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarVendas));
            this.pcbCarrinhoRegistrar = new System.Windows.Forms.PictureBox();
            this.lblRegistrarVenda = new System.Windows.Forms.Label();
            this.lblClienteRegistrar = new System.Windows.Forms.Label();
            this.txtTaxaVenda = new System.Windows.Forms.TextBox();
            this.lblTaxaServico = new System.Windows.Forms.Label();
            this.lblTipoPagamento = new System.Windows.Forms.Label();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.txtNomeCpfCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.cmbxTipoPagamento = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataViewServicos = new System.Windows.Forms.DataGridView();
            this.dataViewServicosAdicionados = new System.Windows.Forms.DataGridView();
            this.lblMascValorTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblListaServicos = new System.Windows.Forms.Label();
            this.lblServicosAdicionados = new System.Windows.Forms.Label();
            this.btnAdicionarServico = new System.Windows.Forms.Button();
            this.btnRemoverServico = new System.Windows.Forms.Button();
            this.btnRegistrarVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrinhoRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServicosAdicionados)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCarrinhoRegistrar
            // 
            this.pcbCarrinhoRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrinhoRegistrar.Image")));
            this.pcbCarrinhoRegistrar.Location = new System.Drawing.Point(24, 24);
            this.pcbCarrinhoRegistrar.Name = "pcbCarrinhoRegistrar";
            this.pcbCarrinhoRegistrar.Size = new System.Drawing.Size(168, 153);
            this.pcbCarrinhoRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCarrinhoRegistrar.TabIndex = 12;
            this.pcbCarrinhoRegistrar.TabStop = false;
            // 
            // lblRegistrarVenda
            // 
            this.lblRegistrarVenda.AutoSize = true;
            this.lblRegistrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblRegistrarVenda.Location = new System.Drawing.Point(262, 56);
            this.lblRegistrarVenda.Name = "lblRegistrarVenda";
            this.lblRegistrarVenda.Size = new System.Drawing.Size(387, 58);
            this.lblRegistrarVenda.TabIndex = 13;
            this.lblRegistrarVenda.Text = "Registrar Venda";
            // 
            // lblClienteRegistrar
            // 
            this.lblClienteRegistrar.AutoSize = true;
            this.lblClienteRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClienteRegistrar.Location = new System.Drawing.Point(72, 248);
            this.lblClienteRegistrar.Name = "lblClienteRegistrar";
            this.lblClienteRegistrar.Size = new System.Drawing.Size(79, 25);
            this.lblClienteRegistrar.TabIndex = 14;
            this.lblClienteRegistrar.Text = "Cliente:";
            this.lblClienteRegistrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTaxaVenda
            // 
            this.txtTaxaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTaxaVenda.Location = new System.Drawing.Point(72, 368);
            this.txtTaxaVenda.Name = "txtTaxaVenda";
            this.txtTaxaVenda.Size = new System.Drawing.Size(304, 26);
            this.txtTaxaVenda.TabIndex = 17;
            // 
            // lblTaxaServico
            // 
            this.lblTaxaServico.AutoSize = true;
            this.lblTaxaServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTaxaServico.Location = new System.Drawing.Point(72, 336);
            this.lblTaxaServico.Name = "lblTaxaServico";
            this.lblTaxaServico.Size = new System.Drawing.Size(228, 25);
            this.lblTaxaServico.TabIndex = 16;
            this.lblTaxaServico.Text = "Taxa (em porcentagem):";
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.AutoSize = true;
            this.lblTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTipoPagamento.Location = new System.Drawing.Point(72, 432);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(187, 25);
            this.lblTipoPagamento.TabIndex = 18;
            this.lblTipoPagamento.Text = "Tipo de pagamento:";
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataVenda.Location = new System.Drawing.Point(72, 544);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(149, 25);
            this.lblDataVenda.TabIndex = 20;
            this.lblDataVenda.Text = "Data da Venda:";
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(72, 584);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(296, 22);
            this.dtpDataVenda.TabIndex = 21;
            // 
            // txtNomeCpfCliente
            // 
            this.txtNomeCpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeCpfCliente.Location = new System.Drawing.Point(72, 288);
            this.txtNomeCpfCliente.Name = "txtNomeCpfCliente";
            this.txtNomeCpfCliente.Size = new System.Drawing.Size(304, 26);
            this.txtNomeCpfCliente.TabIndex = 17;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(376, 288);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(80, 32);
            this.btnBuscarCliente.TabIndex = 22;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // cmbxTipoPagamento
            // 
            this.cmbxTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxTipoPagamento.FormattingEnabled = true;
            this.cmbxTipoPagamento.Items.AddRange(new object[] {
            "A VISTA"});
            this.cmbxTipoPagamento.Location = new System.Drawing.Point(72, 472);
            this.cmbxTipoPagamento.Name = "cmbxTipoPagamento";
            this.cmbxTipoPagamento.Size = new System.Drawing.Size(296, 28);
            this.cmbxTipoPagamento.TabIndex = 23;
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
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dataViewServicos
            // 
            this.dataViewServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewServicos.Location = new System.Drawing.Point(480, 208);
            this.dataViewServicos.Name = "dataViewServicos";
            this.dataViewServicos.RowHeadersWidth = 51;
            this.dataViewServicos.RowTemplate.Height = 24;
            this.dataViewServicos.Size = new System.Drawing.Size(240, 344);
            this.dataViewServicos.TabIndex = 25;
            // 
            // dataViewServicosAdicionados
            // 
            this.dataViewServicosAdicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewServicosAdicionados.Location = new System.Drawing.Point(752, 208);
            this.dataViewServicosAdicionados.Name = "dataViewServicosAdicionados";
            this.dataViewServicosAdicionados.RowHeadersWidth = 51;
            this.dataViewServicosAdicionados.RowTemplate.Height = 24;
            this.dataViewServicosAdicionados.Size = new System.Drawing.Size(240, 344);
            this.dataViewServicosAdicionados.TabIndex = 25;
            // 
            // lblMascValorTotal
            // 
            this.lblMascValorTotal.AutoSize = true;
            this.lblMascValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMascValorTotal.Location = new System.Drawing.Point(72, 664);
            this.lblMascValorTotal.Name = "lblMascValorTotal";
            this.lblMascValorTotal.Size = new System.Drawing.Size(145, 25);
            this.lblMascValorTotal.TabIndex = 26;
            this.lblMascValorTotal.Text = "Valor total: R$: ";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValorTotal.ForeColor = System.Drawing.Color.Red;
            this.lblValorTotal.Location = new System.Drawing.Point(216, 664);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(114, 25);
            this.lblValorTotal.TabIndex = 26;
            this.lblValorTotal.Text = "Não apagar";
            // 
            // lblListaServicos
            // 
            this.lblListaServicos.AutoSize = true;
            this.lblListaServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblListaServicos.Location = new System.Drawing.Point(480, 160);
            this.lblListaServicos.Name = "lblListaServicos";
            this.lblListaServicos.Size = new System.Drawing.Size(161, 25);
            this.lblListaServicos.TabIndex = 27;
            this.lblListaServicos.Text = "Lista de Serviços";
            // 
            // lblServicosAdicionados
            // 
            this.lblServicosAdicionados.AutoSize = true;
            this.lblServicosAdicionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblServicosAdicionados.Location = new System.Drawing.Point(760, 160);
            this.lblServicosAdicionados.Name = "lblServicosAdicionados";
            this.lblServicosAdicionados.Size = new System.Drawing.Size(201, 25);
            this.lblServicosAdicionados.TabIndex = 27;
            this.lblServicosAdicionados.Text = "Serviços Adicionados";
            // 
            // btnAdicionarServico
            // 
            this.btnAdicionarServico.BackColor = System.Drawing.Color.Black;
            this.btnAdicionarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdicionarServico.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarServico.Location = new System.Drawing.Point(536, 560);
            this.btnAdicionarServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarServico.Name = "btnAdicionarServico";
            this.btnAdicionarServico.Size = new System.Drawing.Size(123, 39);
            this.btnAdicionarServico.TabIndex = 24;
            this.btnAdicionarServico.Text = "Adicionar";
            this.btnAdicionarServico.UseVisualStyleBackColor = false;
            // 
            // btnRemoverServico
            // 
            this.btnRemoverServico.BackColor = System.Drawing.Color.Black;
            this.btnRemoverServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRemoverServico.ForeColor = System.Drawing.Color.White;
            this.btnRemoverServico.Location = new System.Drawing.Point(816, 560);
            this.btnRemoverServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverServico.Name = "btnRemoverServico";
            this.btnRemoverServico.Size = new System.Drawing.Size(123, 39);
            this.btnRemoverServico.TabIndex = 24;
            this.btnRemoverServico.Text = "Remover";
            this.btnRemoverServico.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarVenda
            // 
            this.btnRegistrarVenda.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRegistrarVenda.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenda.Location = new System.Drawing.Point(648, 672);
            this.btnRegistrarVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarVenda.Name = "btnRegistrarVenda";
            this.btnRegistrarVenda.Size = new System.Drawing.Size(179, 39);
            this.btnRegistrarVenda.TabIndex = 24;
            this.btnRegistrarVenda.Text = "Registrar Venda";
            this.btnRegistrarVenda.UseVisualStyleBackColor = false;
            // 
            // frmAdicionarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.lblServicosAdicionados);
            this.Controls.Add(this.lblListaServicos);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblMascValorTotal);
            this.Controls.Add(this.dataViewServicosAdicionados);
            this.Controls.Add(this.dataViewServicos);
            this.Controls.Add(this.btnAdicionarServico);
            this.Controls.Add(this.btnRemoverServico);
            this.Controls.Add(this.btnRegistrarVenda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cmbxTipoPagamento);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.lblDataVenda);
            this.Controls.Add(this.lblTipoPagamento);
            this.Controls.Add(this.txtNomeCpfCliente);
            this.Controls.Add(this.txtTaxaVenda);
            this.Controls.Add(this.lblTaxaServico);
            this.Controls.Add(this.lblClienteRegistrar);
            this.Controls.Add(this.lblRegistrarVenda);
            this.Controls.Add(this.pcbCarrinhoRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdicionarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioAdicionarVendas";
            this.Load += new System.EventHandler(this.frmAdicionarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrinhoRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServicosAdicionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCarrinhoRegistrar;
        private System.Windows.Forms.Label lblRegistrarVenda;
        private System.Windows.Forms.Label lblClienteRegistrar;
        private System.Windows.Forms.TextBox txtTaxaVenda;
        private System.Windows.Forms.Label lblTaxaServico;
        private System.Windows.Forms.Label lblTipoPagamento;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.TextBox txtNomeCpfCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ComboBox cmbxTipoPagamento;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataViewServicos;
        private System.Windows.Forms.DataGridView dataViewServicosAdicionados;
        private System.Windows.Forms.Label lblMascValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblListaServicos;
        private System.Windows.Forms.Label lblServicosAdicionados;
        private System.Windows.Forms.Button btnAdicionarServico;
        private System.Windows.Forms.Button btnRemoverServico;
        private System.Windows.Forms.Button btnRegistrarVenda;
    }
}