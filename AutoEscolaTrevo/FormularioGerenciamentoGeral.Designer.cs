﻿namespace AutoEscolaTrevo
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVendas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbGerenciarServico
            // 
            this.pcbGerenciarServico.Image = ((System.Drawing.Image)(resources.GetObject("pcbGerenciarServico.Image")));
            this.pcbGerenciarServico.Location = new System.Drawing.Point(312, 98);
            this.pcbGerenciarServico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbGerenciarServico.Name = "pcbGerenciarServico";
            this.pcbGerenciarServico.Size = new System.Drawing.Size(96, 84);
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
            this.btnGerenciarServicos.Location = new System.Drawing.Point(284, 185);
            this.btnGerenciarServicos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGerenciarServicos.Name = "btnGerenciarServicos";
            this.btnGerenciarServicos.Size = new System.Drawing.Size(150, 32);
            this.btnGerenciarServicos.TabIndex = 1;
            this.btnGerenciarServicos.Text = "Gerenciar Serviços";
            this.btnGerenciarServicos.UseVisualStyleBackColor = false;
            this.btnGerenciarServicos.Click += new System.EventHandler(this.btnGerenciarServicos_Click);
            // 
            // pcbGerenciarCliente
            // 
            this.pcbGerenciarCliente.Image = global::AutoEscolaTrevo.Properties.Resources.client;
            this.pcbGerenciarCliente.Location = new System.Drawing.Point(68, 98);
            this.pcbGerenciarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbGerenciarCliente.Name = "pcbGerenciarCliente";
            this.pcbGerenciarCliente.Size = new System.Drawing.Size(96, 84);
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
            this.btnGerenciarCliente.Location = new System.Drawing.Point(40, 185);
            this.btnGerenciarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGerenciarCliente.Name = "btnGerenciarCliente";
            this.btnGerenciarCliente.Size = new System.Drawing.Size(150, 32);
            this.btnGerenciarCliente.TabIndex = 1;
            this.btnGerenciarCliente.Text = "Gerenciar Cliente";
            this.btnGerenciarCliente.UseVisualStyleBackColor = false;
            this.btnGerenciarCliente.Click += new System.EventHandler(this.btnGerenciarCliente_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Black;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(652, 9);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(92, 32);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.Black;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Location = new System.Drawing.Point(528, 182);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(150, 32);
            this.btnVendas.TabIndex = 11;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // frmGerenciamentoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnGerenciarCliente);
            this.Controls.Add(this.pcbGerenciarCliente);
            this.Controls.Add(this.btnGerenciarServicos);
            this.Controls.Add(this.pcbGerenciarServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciamentoGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento Geral";
            this.Load += new System.EventHandler(this.frmGerenciamentoGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGerenciarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbGerenciarServico;
        private System.Windows.Forms.Button btnGerenciarServicos;
        private System.Windows.Forms.PictureBox pcbGerenciarCliente;
        private System.Windows.Forms.Button btnGerenciarCliente;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVendas;
    }
}

