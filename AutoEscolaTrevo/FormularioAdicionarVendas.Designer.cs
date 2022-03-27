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
            this.lblTipoPagamento = new System.Windows.Forms.Label();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
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
            this.dataViewCliente = new System.Windows.Forms.DataGridView();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblMscNomeCliente = new System.Windows.Forms.Label();
            this.lblValorEntrada = new System.Windows.Forms.Label();
            this.lblNumeroParcelas = new System.Windows.Forms.Label();
            this.mskTxtNumeroParcelas = new System.Windows.Forms.MaskedTextBox();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.lblResultadoValorParcela = new System.Windows.Forms.Label();
            this.numUpDownValorEntrada = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrinhoRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServicosAdicionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownValorEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCarrinhoRegistrar
            // 
            this.pcbCarrinhoRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrinhoRegistrar.Image")));
            this.pcbCarrinhoRegistrar.Location = new System.Drawing.Point(24, 24);
            this.pcbCarrinhoRegistrar.Name = "pcbCarrinhoRegistrar";
            this.pcbCarrinhoRegistrar.Size = new System.Drawing.Size(144, 128);
            this.pcbCarrinhoRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCarrinhoRegistrar.TabIndex = 12;
            this.pcbCarrinhoRegistrar.TabStop = false;
            // 
            // lblRegistrarVenda
            // 
            this.lblRegistrarVenda.AutoSize = true;
            this.lblRegistrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRegistrarVenda.Location = new System.Drawing.Point(216, 24);
            this.lblRegistrarVenda.Name = "lblRegistrarVenda";
            this.lblRegistrarVenda.Size = new System.Drawing.Size(210, 31);
            this.lblRegistrarVenda.TabIndex = 13;
            this.lblRegistrarVenda.Text = "Registrar Venda";
            // 
            // lblClienteRegistrar
            // 
            this.lblClienteRegistrar.AutoSize = true;
            this.lblClienteRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblClienteRegistrar.Location = new System.Drawing.Point(560, 169);
            this.lblClienteRegistrar.Name = "lblClienteRegistrar";
            this.lblClienteRegistrar.Size = new System.Drawing.Size(79, 25);
            this.lblClienteRegistrar.TabIndex = 14;
            this.lblClienteRegistrar.Text = "Cliente:";
            this.lblClienteRegistrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.AutoSize = true;
            this.lblTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTipoPagamento.Location = new System.Drawing.Point(8, 560);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(187, 25);
            this.lblTipoPagamento.TabIndex = 18;
            this.lblTipoPagamento.Text = "Tipo de pagamento:";
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataVenda.Location = new System.Drawing.Point(272, 560);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(149, 25);
            this.lblDataVenda.TabIndex = 20;
            this.lblDataVenda.Text = "Data da Venda:";
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dtpDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(272, 600);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(240, 26);
            this.dtpDataVenda.TabIndex = 21;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBuscarCliente.Location = new System.Drawing.Point(640, 168);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(240, 26);
            this.txtBuscarCliente.TabIndex = 17;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(896, 162);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(136, 32);
            this.btnBuscarCliente.TabIndex = 22;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // cmbxTipoPagamento
            // 
            this.cmbxTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbxTipoPagamento.FormattingEnabled = true;
            this.cmbxTipoPagamento.Items.AddRange(new object[] {
            "À VISTA (Dinheiro)",
            "À VISTA (Débito)",
            "PRAZO (Crédito)",
            "PRAZO (Carnê)"});
            this.cmbxTipoPagamento.Location = new System.Drawing.Point(8, 600);
            this.cmbxTipoPagamento.Name = "cmbxTipoPagamento";
            this.cmbxTipoPagamento.Size = new System.Drawing.Size(240, 28);
            this.cmbxTipoPagamento.TabIndex = 23;
            this.cmbxTipoPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbxTipoPagamento_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(936, 8);
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
            this.dataViewServicos.AllowUserToAddRows = false;
            this.dataViewServicos.AllowUserToResizeColumns = false;
            this.dataViewServicos.AllowUserToResizeRows = false;
            this.dataViewServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewServicos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataViewServicos.Location = new System.Drawing.Point(16, 208);
            this.dataViewServicos.MultiSelect = false;
            this.dataViewServicos.Name = "dataViewServicos";
            this.dataViewServicos.ReadOnly = true;
            this.dataViewServicos.RowHeadersWidth = 51;
            this.dataViewServicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataViewServicos.RowTemplate.Height = 24;
            this.dataViewServicos.Size = new System.Drawing.Size(240, 240);
            this.dataViewServicos.TabIndex = 25;
            this.dataViewServicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewServicos_CellContentClick);
            // 
            // dataViewServicosAdicionados
            // 
            this.dataViewServicosAdicionados.AllowUserToAddRows = false;
            this.dataViewServicosAdicionados.AllowUserToDeleteRows = false;
            this.dataViewServicosAdicionados.AllowUserToResizeColumns = false;
            this.dataViewServicosAdicionados.AllowUserToResizeRows = false;
            this.dataViewServicosAdicionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewServicosAdicionados.Location = new System.Drawing.Point(288, 208);
            this.dataViewServicosAdicionados.Name = "dataViewServicosAdicionados";
            this.dataViewServicosAdicionados.ReadOnly = true;
            this.dataViewServicosAdicionados.RowHeadersWidth = 51;
            this.dataViewServicosAdicionados.RowTemplate.Height = 24;
            this.dataViewServicosAdicionados.Size = new System.Drawing.Size(240, 240);
            this.dataViewServicosAdicionados.TabIndex = 25;
            this.dataViewServicosAdicionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewServicosAdicionados_CellContentClick);
            // 
            // lblMascValorTotal
            // 
            this.lblMascValorTotal.AutoSize = true;
            this.lblMascValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMascValorTotal.Location = new System.Drawing.Point(696, 680);
            this.lblMascValorTotal.Name = "lblMascValorTotal";
            this.lblMascValorTotal.Size = new System.Drawing.Size(145, 25);
            this.lblMascValorTotal.TabIndex = 26;
            this.lblMascValorTotal.Text = "Valor total: R$: ";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValorTotal.ForeColor = System.Drawing.Color.Purple;
            this.lblValorTotal.Location = new System.Drawing.Point(840, 680);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(19, 25);
            this.lblValorTotal.TabIndex = 26;
            this.lblValorTotal.Text = "-";
            // 
            // lblListaServicos
            // 
            this.lblListaServicos.AutoSize = true;
            this.lblListaServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblListaServicos.Location = new System.Drawing.Point(56, 168);
            this.lblListaServicos.Name = "lblListaServicos";
            this.lblListaServicos.Size = new System.Drawing.Size(161, 25);
            this.lblListaServicos.TabIndex = 27;
            this.lblListaServicos.Text = "Lista de Serviços";
            // 
            // lblServicosAdicionados
            // 
            this.lblServicosAdicionados.AutoSize = true;
            this.lblServicosAdicionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblServicosAdicionados.Location = new System.Drawing.Point(312, 168);
            this.lblServicosAdicionados.Name = "lblServicosAdicionados";
            this.lblServicosAdicionados.Size = new System.Drawing.Size(201, 25);
            this.lblServicosAdicionados.TabIndex = 27;
            this.lblServicosAdicionados.Text = "Serviços Adicionados";
            this.lblServicosAdicionados.Click += new System.EventHandler(this.lblServicosAdicionados_Click);
            // 
            // btnAdicionarServico
            // 
            this.btnAdicionarServico.BackColor = System.Drawing.Color.Black;
            this.btnAdicionarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdicionarServico.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarServico.Location = new System.Drawing.Point(72, 464);
            this.btnAdicionarServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarServico.Name = "btnAdicionarServico";
            this.btnAdicionarServico.Size = new System.Drawing.Size(123, 39);
            this.btnAdicionarServico.TabIndex = 24;
            this.btnAdicionarServico.Text = "Adicionar";
            this.btnAdicionarServico.UseVisualStyleBackColor = false;
            this.btnAdicionarServico.Click += new System.EventHandler(this.btnAdicionarServico_Click);
            // 
            // btnRemoverServico
            // 
            this.btnRemoverServico.BackColor = System.Drawing.Color.Black;
            this.btnRemoverServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRemoverServico.ForeColor = System.Drawing.Color.White;
            this.btnRemoverServico.Location = new System.Drawing.Point(352, 464);
            this.btnRemoverServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoverServico.Name = "btnRemoverServico";
            this.btnRemoverServico.Size = new System.Drawing.Size(123, 39);
            this.btnRemoverServico.TabIndex = 24;
            this.btnRemoverServico.Text = "Remover";
            this.btnRemoverServico.UseVisualStyleBackColor = false;
            this.btnRemoverServico.Click += new System.EventHandler(this.btnRemoverServico_Click);
            // 
            // btnRegistrarVenda
            // 
            this.btnRegistrarVenda.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRegistrarVenda.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenda.Location = new System.Drawing.Point(442, 672);
            this.btnRegistrarVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarVenda.Name = "btnRegistrarVenda";
            this.btnRegistrarVenda.Size = new System.Drawing.Size(179, 39);
            this.btnRegistrarVenda.TabIndex = 24;
            this.btnRegistrarVenda.Text = "Registrar Venda";
            this.btnRegistrarVenda.UseVisualStyleBackColor = false;
            this.btnRegistrarVenda.Click += new System.EventHandler(this.btnRegistrarVenda_Click);
            // 
            // dataViewCliente
            // 
            this.dataViewCliente.AllowUserToAddRows = false;
            this.dataViewCliente.AllowUserToDeleteRows = false;
            this.dataViewCliente.AllowUserToResizeColumns = false;
            this.dataViewCliente.AllowUserToResizeRows = false;
            this.dataViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCliente.Location = new System.Drawing.Point(560, 208);
            this.dataViewCliente.MultiSelect = false;
            this.dataViewCliente.Name = "dataViewCliente";
            this.dataViewCliente.ReadOnly = true;
            this.dataViewCliente.RowHeadersWidth = 51;
            this.dataViewCliente.RowTemplate.Height = 24;
            this.dataViewCliente.Size = new System.Drawing.Size(480, 240);
            this.dataViewCliente.TabIndex = 25;
            this.dataViewCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewCliente_CellClick);
            this.dataViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewCliente_CellContentClick);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeCliente.ForeColor = System.Drawing.Color.Purple;
            this.lblNomeCliente.Location = new System.Drawing.Point(560, 488);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(307, 25);
            this.lblNomeCliente.TabIndex = 28;
            this.lblNomeCliente.Text = "Nenhum(a) cliente selecionado(a)";
            this.lblNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblMscNomeCliente
            // 
            this.lblMscNomeCliente.AutoSize = true;
            this.lblMscNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMscNomeCliente.Location = new System.Drawing.Point(560, 464);
            this.lblMscNomeCliente.Name = "lblMscNomeCliente";
            this.lblMscNomeCliente.Size = new System.Drawing.Size(189, 25);
            this.lblMscNomeCliente.TabIndex = 29;
            this.lblMscNomeCliente.Text = "Cliente selecionado:";
            this.lblMscNomeCliente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMscNomeCliente_MouseDown);
            // 
            // lblValorEntrada
            // 
            this.lblValorEntrada.AutoSize = true;
            this.lblValorEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValorEntrada.Location = new System.Drawing.Point(528, 560);
            this.lblValorEntrada.Name = "lblValorEntrada";
            this.lblValorEntrada.Size = new System.Drawing.Size(164, 25);
            this.lblValorEntrada.TabIndex = 20;
            this.lblValorEntrada.Text = "Valor da Entrada:";
            // 
            // lblNumeroParcelas
            // 
            this.lblNumeroParcelas.AutoSize = true;
            this.lblNumeroParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumeroParcelas.Location = new System.Drawing.Point(712, 560);
            this.lblNumeroParcelas.Name = "lblNumeroParcelas";
            this.lblNumeroParcelas.Size = new System.Drawing.Size(195, 25);
            this.lblNumeroParcelas.TabIndex = 20;
            this.lblNumeroParcelas.Text = "Numero de Parcelas:";
            this.lblNumeroParcelas.Visible = false;
            this.lblNumeroParcelas.Click += new System.EventHandler(this.lblNumeroParcelas_Click);
            // 
            // mskTxtNumeroParcelas
            // 
            this.mskTxtNumeroParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mskTxtNumeroParcelas.Location = new System.Drawing.Point(720, 600);
            this.mskTxtNumeroParcelas.Mask = "00";
            this.mskTxtNumeroParcelas.Name = "mskTxtNumeroParcelas";
            this.mskTxtNumeroParcelas.Size = new System.Drawing.Size(100, 26);
            this.mskTxtNumeroParcelas.TabIndex = 31;
            this.mskTxtNumeroParcelas.ValidatingType = typeof(int);
            this.mskTxtNumeroParcelas.Visible = false;
            this.mskTxtNumeroParcelas.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTxtNumeroParcelas_MaskInputRejected);
            this.mskTxtNumeroParcelas.TextChanged += new System.EventHandler(this.mskTxtNumeroParcelas_TextChanged);
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblValorParcela.Location = new System.Drawing.Point(8, 672);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(162, 25);
            this.lblValorParcela.TabIndex = 18;
            this.lblValorParcela.Text = "Valor da Parcela:";
            // 
            // lblResultadoValorParcela
            // 
            this.lblResultadoValorParcela.AutoSize = true;
            this.lblResultadoValorParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultadoValorParcela.ForeColor = System.Drawing.Color.Purple;
            this.lblResultadoValorParcela.Location = new System.Drawing.Point(176, 672);
            this.lblResultadoValorParcela.Name = "lblResultadoValorParcela";
            this.lblResultadoValorParcela.Size = new System.Drawing.Size(19, 25);
            this.lblResultadoValorParcela.TabIndex = 28;
            this.lblResultadoValorParcela.Text = "-";
            this.lblResultadoValorParcela.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // numUpDownValorEntrada
            // 
            this.numUpDownValorEntrada.DecimalPlaces = 2;
            this.numUpDownValorEntrada.Location = new System.Drawing.Point(536, 600);
            this.numUpDownValorEntrada.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpDownValorEntrada.Name = "numUpDownValorEntrada";
            this.numUpDownValorEntrada.Size = new System.Drawing.Size(152, 22);
            this.numUpDownValorEntrada.TabIndex = 32;
            this.numUpDownValorEntrada.ValueChanged += new System.EventHandler(this.numUpDownValorEntrada_ValueChanged);
            // 
            // frmAdicionarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1063, 721);
            this.Controls.Add(this.numUpDownValorEntrada);
            this.Controls.Add(this.mskTxtNumeroParcelas);
            this.Controls.Add(this.lblResultadoValorParcela);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblMscNomeCliente);
            this.Controls.Add(this.lblServicosAdicionados);
            this.Controls.Add(this.lblListaServicos);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblMascValorTotal);
            this.Controls.Add(this.dataViewServicosAdicionados);
            this.Controls.Add(this.dataViewCliente);
            this.Controls.Add(this.dataViewServicos);
            this.Controls.Add(this.btnAdicionarServico);
            this.Controls.Add(this.btnRemoverServico);
            this.Controls.Add(this.btnRegistrarVenda);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cmbxTipoPagamento);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.lblNumeroParcelas);
            this.Controls.Add(this.lblValorEntrada);
            this.Controls.Add(this.lblDataVenda);
            this.Controls.Add(this.lblValorParcela);
            this.Controls.Add(this.lblTipoPagamento);
            this.Controls.Add(this.txtBuscarCliente);
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
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAdicionarVendas_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrinhoRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServicosAdicionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownValorEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCarrinhoRegistrar;
        private System.Windows.Forms.Label lblRegistrarVenda;
        private System.Windows.Forms.Label lblClienteRegistrar;
        private System.Windows.Forms.Label lblTipoPagamento;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.TextBox txtBuscarCliente;
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
        private System.Windows.Forms.DataGridView dataViewCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblMscNomeCliente;
        private System.Windows.Forms.Label lblValorEntrada;
        private System.Windows.Forms.Label lblNumeroParcelas;
        private System.Windows.Forms.MaskedTextBox mskTxtNumeroParcelas;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label lblResultadoValorParcela;
        private System.Windows.Forms.NumericUpDown numUpDownValorEntrada;
    }
}