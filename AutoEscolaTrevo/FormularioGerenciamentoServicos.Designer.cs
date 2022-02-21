namespace AutoEscolaTrevo
{
    partial class frmGerenciamentoServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciamentoServicos));
            this.pcbServico = new System.Windows.Forms.PictureBox();
            this.lblGerenciarServicos = new System.Windows.Forms.Label();
            this.dataViewServicos = new System.Windows.Forms.DataGridView();
            this.txtBuscarServico = new System.Windows.Forms.TextBox();
            this.btnBuscarServico = new System.Windows.Forms.Button();
            this.btnCadastrarServico = new System.Windows.Forms.Button();
            this.btnExcluirServico = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbServico
            // 
            this.pcbServico.Image = ((System.Drawing.Image)(resources.GetObject("pcbServico.Image")));
            this.pcbServico.Location = new System.Drawing.Point(40, 24);
            this.pcbServico.Name = "pcbServico";
            this.pcbServico.Size = new System.Drawing.Size(136, 104);
            this.pcbServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbServico.TabIndex = 0;
            this.pcbServico.TabStop = false;
            // 
            // lblGerenciarServicos
            // 
            this.lblGerenciarServicos.AutoSize = true;
            this.lblGerenciarServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerenciarServicos.Location = new System.Drawing.Point(324, 24);
            this.lblGerenciarServicos.Name = "lblGerenciarServicos";
            this.lblGerenciarServicos.Size = new System.Drawing.Size(360, 46);
            this.lblGerenciarServicos.TabIndex = 1;
            this.lblGerenciarServicos.Text = "Gerenciar Serviços";
            // 
            // dataViewServicos
            // 
            this.dataViewServicos.AllowUserToAddRows = false;
            this.dataViewServicos.AllowUserToResizeColumns = false;
            this.dataViewServicos.AllowUserToResizeRows = false;
            this.dataViewServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewServicos.Location = new System.Drawing.Point(40, 376);
            this.dataViewServicos.MultiSelect = false;
            this.dataViewServicos.Name = "dataViewServicos";
            this.dataViewServicos.RowHeadersWidth = 51;
            this.dataViewServicos.RowTemplate.Height = 24;
            this.dataViewServicos.Size = new System.Drawing.Size(720, 328);
            this.dataViewServicos.TabIndex = 6;
            this.dataViewServicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewServicos_CellContentClick);
            // 
            // txtBuscarServico
            // 
            this.txtBuscarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBuscarServico.Location = new System.Drawing.Point(40, 312);
            this.txtBuscarServico.Name = "txtBuscarServico";
            this.txtBuscarServico.Size = new System.Drawing.Size(512, 28);
            this.txtBuscarServico.TabIndex = 7;
            // 
            // btnBuscarServico
            // 
            this.btnBuscarServico.BackColor = System.Drawing.Color.Black;
            this.btnBuscarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBuscarServico.ForeColor = System.Drawing.Color.White;
            this.btnBuscarServico.Location = new System.Drawing.Point(560, 304);
            this.btnBuscarServico.Name = "btnBuscarServico";
            this.btnBuscarServico.Size = new System.Drawing.Size(200, 40);
            this.btnBuscarServico.TabIndex = 8;
            this.btnBuscarServico.Text = "Buscar";
            this.btnBuscarServico.UseVisualStyleBackColor = false;
            this.btnBuscarServico.Click += new System.EventHandler(this.btnBuscarServico_Click);
            // 
            // btnCadastrarServico
            // 
            this.btnCadastrarServico.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCadastrarServico.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarServico.Location = new System.Drawing.Point(40, 208);
            this.btnCadastrarServico.Name = "btnCadastrarServico";
            this.btnCadastrarServico.Size = new System.Drawing.Size(200, 40);
            this.btnCadastrarServico.TabIndex = 9;
            this.btnCadastrarServico.Text = "+    Cadastrar";
            this.btnCadastrarServico.UseVisualStyleBackColor = false;
            this.btnCadastrarServico.Click += new System.EventHandler(this.btnCadastrarServico_Click);
            // 
            // btnExcluirServico
            // 
            this.btnExcluirServico.BackColor = System.Drawing.Color.Black;
            this.btnExcluirServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExcluirServico.ForeColor = System.Drawing.Color.White;
            this.btnExcluirServico.Location = new System.Drawing.Point(784, 664);
            this.btnExcluirServico.Name = "btnExcluirServico";
            this.btnExcluirServico.Size = new System.Drawing.Size(200, 40);
            this.btnExcluirServico.TabIndex = 12;
            this.btnExcluirServico.Text = "Excluir";
            this.btnExcluirServico.UseVisualStyleBackColor = false;
            this.btnExcluirServico.Click += new System.EventHandler(this.btnExcluirServico_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(862, 24);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(122, 39);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmGerenciamentoServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluirServico);
            this.Controls.Add(this.btnCadastrarServico);
            this.Controls.Add(this.btnBuscarServico);
            this.Controls.Add(this.txtBuscarServico);
            this.Controls.Add(this.dataViewServicos);
            this.Controls.Add(this.lblGerenciarServicos);
            this.Controls.Add(this.pcbServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciamentoServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioGerenciamentoServicos";
            this.Load += new System.EventHandler(this.FormularioGerenciamentoServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbServico;
        private System.Windows.Forms.Label lblGerenciarServicos;
        private System.Windows.Forms.DataGridView dataViewServicos;
        private System.Windows.Forms.TextBox txtBuscarServico;
        private System.Windows.Forms.Button btnBuscarServico;
        private System.Windows.Forms.Button btnCadastrarServico;
        private System.Windows.Forms.Button btnExcluirServico;
        private System.Windows.Forms.Button btnVoltar;
    }
}