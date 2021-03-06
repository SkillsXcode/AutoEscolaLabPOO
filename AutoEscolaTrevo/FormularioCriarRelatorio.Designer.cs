namespace AutoEscolaTrevo
{
    partial class FormularioCriarRelatorio
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
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarClienteRelatorio = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblResultadoNomeCliente = new System.Windows.Forms.Label();
            this.lblQuantidadeVendas = new System.Windows.Forms.Label();
            this.lblResultadoQuantidadeVendas = new System.Windows.Forms.Label();
            this.dataViewCliente = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblRelatorios.Location = new System.Drawing.Point(389, 24);
            this.lblRelatorios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(226, 58);
            this.lblRelatorios.TabIndex = 0;
            this.lblRelatorios.Text = "Relatório";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoEscolaTrevo.Properties.Resources.relatorio;
            this.pictureBox1.Location = new System.Drawing.Point(44, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarClienteRelatorio
            // 
            this.txtBuscarClienteRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBuscarClienteRelatorio.Location = new System.Drawing.Point(40, 208);
            this.txtBuscarClienteRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarClienteRelatorio.Name = "txtBuscarClienteRelatorio";
            this.txtBuscarClienteRelatorio.Size = new System.Drawing.Size(736, 36);
            this.txtBuscarClienteRelatorio.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(784, 207);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(200, 39);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNomeCliente.Location = new System.Drawing.Point(40, 608);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(88, 29);
            this.lblNomeCliente.TabIndex = 8;
            this.lblNomeCliente.Text = "Nome:";
            this.lblNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblResultadoNomeCliente
            // 
            this.lblResultadoNomeCliente.AutoSize = true;
            this.lblResultadoNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblResultadoNomeCliente.ForeColor = System.Drawing.Color.Purple;
            this.lblResultadoNomeCliente.Location = new System.Drawing.Point(128, 608);
            this.lblResultadoNomeCliente.Name = "lblResultadoNomeCliente";
            this.lblResultadoNomeCliente.Size = new System.Drawing.Size(26, 29);
            this.lblResultadoNomeCliente.TabIndex = 9;
            this.lblResultadoNomeCliente.Text = "y";
            this.lblResultadoNomeCliente.Visible = false;
            this.lblResultadoNomeCliente.Click += new System.EventHandler(this.lblResultadoNomeCliente_Click);
            // 
            // lblQuantidadeVendas
            // 
            this.lblQuantidadeVendas.AutoSize = true;
            this.lblQuantidadeVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuantidadeVendas.Location = new System.Drawing.Point(40, 656);
            this.lblQuantidadeVendas.Name = "lblQuantidadeVendas";
            this.lblQuantidadeVendas.Size = new System.Drawing.Size(191, 29);
            this.lblQuantidadeVendas.TabIndex = 8;
            this.lblQuantidadeVendas.Text = "Qtd. de vendas:";
            this.lblQuantidadeVendas.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblResultadoQuantidadeVendas
            // 
            this.lblResultadoQuantidadeVendas.AutoSize = true;
            this.lblResultadoQuantidadeVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblResultadoQuantidadeVendas.ForeColor = System.Drawing.Color.Purple;
            this.lblResultadoQuantidadeVendas.Location = new System.Drawing.Point(232, 656);
            this.lblResultadoQuantidadeVendas.Name = "lblResultadoQuantidadeVendas";
            this.lblResultadoQuantidadeVendas.Size = new System.Drawing.Size(25, 29);
            this.lblResultadoQuantidadeVendas.TabIndex = 9;
            this.lblResultadoQuantidadeVendas.Text = "x";
            this.lblResultadoQuantidadeVendas.Visible = false;
            this.lblResultadoQuantidadeVendas.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataViewCliente
            // 
            this.dataViewCliente.AllowUserToAddRows = false;
            this.dataViewCliente.AllowUserToResizeColumns = false;
            this.dataViewCliente.AllowUserToResizeRows = false;
            this.dataViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCliente.Location = new System.Drawing.Point(40, 256);
            this.dataViewCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataViewCliente.MultiSelect = false;
            this.dataViewCliente.Name = "dataViewCliente";
            this.dataViewCliente.ReadOnly = true;
            this.dataViewCliente.RowHeadersWidth = 51;
            this.dataViewCliente.Size = new System.Drawing.Size(952, 328);
            this.dataViewCliente.TabIndex = 13;
            this.dataViewCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewCliente_CellClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(864, 16);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(120, 40);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormularioCriarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataViewCliente);
            this.Controls.Add(this.lblResultadoQuantidadeVendas);
            this.Controls.Add(this.lblQuantidadeVendas);
            this.Controls.Add(this.lblResultadoNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarClienteRelatorio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRelatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioCriarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioCriarRelatorio";
            this.Load += new System.EventHandler(this.FormularioCriarRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarClienteRelatorio;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblResultadoNomeCliente;
        private System.Windows.Forms.Label lblQuantidadeVendas;
        private System.Windows.Forms.DataGridView dataViewCliente;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblResultadoQuantidadeVendas;
    }
}