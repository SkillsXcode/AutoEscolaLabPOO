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
            this.txtBoxRelatorio = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblResultadoNomeCliente = new System.Windows.Forms.Label();
            this.lblQuantidadeVendas = new System.Windows.Forms.Label();
            this.lblResultadoQuantidadeVendas = new System.Windows.Forms.Label();
            this.lblPagamentosRealizados = new System.Windows.Forms.Label();
            this.lblResultadoPagamentosRealizados = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblRelatorios.Location = new System.Drawing.Point(309, 34);
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxRelatorio
            // 
            this.txtBoxRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtBoxRelatorio.Location = new System.Drawing.Point(40, 224);
            this.txtBoxRelatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxRelatorio.Name = "txtBoxRelatorio";
            this.txtBoxRelatorio.Size = new System.Drawing.Size(736, 45);
            this.txtBoxRelatorio.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(784, 232);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(200, 39);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(792, 672);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Gerar Relatório";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNomeCliente.Location = new System.Drawing.Point(40, 592);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(67, 24);
            this.lblNomeCliente.TabIndex = 8;
            this.lblNomeCliente.Text = "Nome:";
            this.lblNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblResultadoNomeCliente
            // 
            this.lblResultadoNomeCliente.AutoSize = true;
            this.lblResultadoNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblResultadoNomeCliente.Location = new System.Drawing.Point(280, 584);
            this.lblResultadoNomeCliente.Name = "lblResultadoNomeCliente";
            this.lblResultadoNomeCliente.Size = new System.Drawing.Size(60, 24);
            this.lblResultadoNomeCliente.TabIndex = 9;
            this.lblResultadoNomeCliente.Text = "label2";
            this.lblResultadoNomeCliente.Click += new System.EventHandler(this.lblResultadoNomeCliente_Click);
            // 
            // lblQuantidadeVendas
            // 
            this.lblQuantidadeVendas.AutoSize = true;
            this.lblQuantidadeVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblQuantidadeVendas.Location = new System.Drawing.Point(40, 632);
            this.lblQuantidadeVendas.Name = "lblQuantidadeVendas";
            this.lblQuantidadeVendas.Size = new System.Drawing.Size(143, 24);
            this.lblQuantidadeVendas.TabIndex = 8;
            this.lblQuantidadeVendas.Text = "Qtd. de vendas:";
            this.lblQuantidadeVendas.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblResultadoQuantidadeVendas
            // 
            this.lblResultadoQuantidadeVendas.AutoSize = true;
            this.lblResultadoQuantidadeVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblResultadoQuantidadeVendas.Location = new System.Drawing.Point(280, 632);
            this.lblResultadoQuantidadeVendas.Name = "lblResultadoQuantidadeVendas";
            this.lblResultadoQuantidadeVendas.Size = new System.Drawing.Size(60, 24);
            this.lblResultadoQuantidadeVendas.TabIndex = 9;
            this.lblResultadoQuantidadeVendas.Text = "label2";
            this.lblResultadoQuantidadeVendas.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPagamentosRealizados
            // 
            this.lblPagamentosRealizados.AutoSize = true;
            this.lblPagamentosRealizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPagamentosRealizados.Location = new System.Drawing.Point(40, 672);
            this.lblPagamentosRealizados.Name = "lblPagamentosRealizados";
            this.lblPagamentosRealizados.Size = new System.Drawing.Size(210, 24);
            this.lblPagamentosRealizados.TabIndex = 8;
            this.lblPagamentosRealizados.Text = "Pagamentos realizados:";
            this.lblPagamentosRealizados.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblResultadoPagamentosRealizados
            // 
            this.lblResultadoPagamentosRealizados.AutoSize = true;
            this.lblResultadoPagamentosRealizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblResultadoPagamentosRealizados.Location = new System.Drawing.Point(280, 672);
            this.lblResultadoPagamentosRealizados.Name = "lblResultadoPagamentosRealizados";
            this.lblResultadoPagamentosRealizados.Size = new System.Drawing.Size(60, 24);
            this.lblResultadoPagamentosRealizados.TabIndex = 9;
            this.lblResultadoPagamentosRealizados.Text = "label2";
            this.lblResultadoPagamentosRealizados.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(936, 280);
            this.dataGridView1.TabIndex = 10;
            // 
            // FormularioCriarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblResultadoPagamentosRealizados);
            this.Controls.Add(this.lblPagamentosRealizados);
            this.Controls.Add(this.lblResultadoQuantidadeVendas);
            this.Controls.Add(this.lblQuantidadeVendas);
            this.Controls.Add(this.lblResultadoNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBoxRelatorio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRelatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioCriarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioCriarRelatorio";
            this.Load += new System.EventHandler(this.FormularioCriarRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxRelatorio;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblResultadoNomeCliente;
        private System.Windows.Forms.Label lblQuantidadeVendas;
        private System.Windows.Forms.Label lblResultadoQuantidadeVendas;
        private System.Windows.Forms.Label lblPagamentosRealizados;
        private System.Windows.Forms.Label lblResultadoPagamentosRealizados;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}