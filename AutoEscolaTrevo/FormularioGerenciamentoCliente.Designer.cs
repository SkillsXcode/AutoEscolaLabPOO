﻿namespace AutoEscolaTrevo
{
    partial class frmGerenciamentoCliente
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
            this.pcbCliente = new System.Windows.Forms.PictureBox();
            this.lblGerenciarClientes = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.dataViewCliente = new System.Windows.Forms.DataGridView();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnVoltarGerenciarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCliente
            // 
            this.pcbCliente.Image = global::AutoEscolaTrevo.Properties.Resources.client;
            this.pcbCliente.Location = new System.Drawing.Point(24, 20);
            this.pcbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbCliente.Name = "pcbCliente";
            this.pcbCliente.Size = new System.Drawing.Size(126, 124);
            this.pcbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCliente.TabIndex = 0;
            this.pcbCliente.TabStop = false;
            // 
            // lblGerenciarClientes
            // 
            this.lblGerenciarClientes.AutoSize = true;
            this.lblGerenciarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblGerenciarClientes.Location = new System.Drawing.Point(232, 28);
            this.lblGerenciarClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGerenciarClientes.Name = "lblGerenciarClientes";
            this.lblGerenciarClientes.Size = new System.Drawing.Size(350, 46);
            this.lblGerenciarClientes.TabIndex = 1;
            this.lblGerenciarClientes.Text = "Gerenciar Clientes";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(30, 169);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(150, 32);
            this.btnCadastrarCliente.TabIndex = 2;
            this.btnCadastrarCliente.Text = "+    Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // dataViewCliente
            // 
            this.dataViewCliente.AllowUserToAddRows = false;
            this.dataViewCliente.AllowUserToResizeColumns = false;
            this.dataViewCliente.AllowUserToResizeRows = false;
            this.dataViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewCliente.Location = new System.Drawing.Point(30, 306);
            this.dataViewCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataViewCliente.MultiSelect = false;
            this.dataViewCliente.Name = "dataViewCliente";
            this.dataViewCliente.RowHeadersWidth = 51;
            this.dataViewCliente.Size = new System.Drawing.Size(540, 266);
            this.dataViewCliente.TabIndex = 3;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtBuscarCliente.Location = new System.Drawing.Point(30, 251);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(385, 24);
            this.txtBuscarCliente.TabIndex = 4;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(420, 247);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(150, 32);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.Black;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEditarCliente.ForeColor = System.Drawing.Color.White;
            this.btnEditarCliente.Location = new System.Drawing.Point(588, 474);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(150, 32);
            this.btnEditarCliente.TabIndex = 6;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Visible = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.Black;
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExcluirCliente.ForeColor = System.Drawing.Color.White;
            this.btnExcluirCliente.Location = new System.Drawing.Point(588, 540);
            this.btnExcluirCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(150, 32);
            this.btnExcluirCliente.TabIndex = 7;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnVoltarGerenciarCliente
            // 
            this.btnVoltarGerenciarCliente.BackColor = System.Drawing.Color.Black;
            this.btnVoltarGerenciarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarGerenciarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVoltarGerenciarCliente.ForeColor = System.Drawing.Color.White;
            this.btnVoltarGerenciarCliente.Location = new System.Drawing.Point(652, 9);
            this.btnVoltarGerenciarCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltarGerenciarCliente.Name = "btnVoltarGerenciarCliente";
            this.btnVoltarGerenciarCliente.Size = new System.Drawing.Size(92, 32);
            this.btnVoltarGerenciarCliente.TabIndex = 8;
            this.btnVoltarGerenciarCliente.Text = "Voltar";
            this.btnVoltarGerenciarCliente.UseVisualStyleBackColor = false;
            this.btnVoltarGerenciarCliente.Click += new System.EventHandler(this.btnVoltarGerenciarCliente_Click);
            // 
            // frmGerenciamentoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.btnVoltarGerenciarCliente);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.dataViewCliente);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.lblGerenciarClientes);
            this.Controls.Add(this.pcbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciamentoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioGerenciamentodeCliente";
            this.Load += new System.EventHandler(this.frmGerenciamentoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCliente;
        private System.Windows.Forms.Label lblGerenciarClientes;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.DataGridView dataViewCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnVoltarGerenciarCliente;
    }
}