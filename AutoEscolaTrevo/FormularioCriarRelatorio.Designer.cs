﻿namespace AutoEscolaTrevo
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
            this.chkBoxRelatorioSintetico = new System.Windows.Forms.CheckBox();
            this.chkBoxRelatorioAnalitico = new System.Windows.Forms.CheckBox();
            this.chkRelatorioSintetico = new System.Windows.Forms.CheckBox();
            this.btnGerarPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblRelatorios.Location = new System.Drawing.Point(259, 34);
            this.lblRelatorios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(251, 58);
            this.lblRelatorios.TabIndex = 0;
            this.lblRelatorios.Text = "Relatórios";
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
            this.txtBoxRelatorio.Location = new System.Drawing.Point(95, 258);
            this.txtBoxRelatorio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxRelatorio.Name = "txtBoxRelatorio";
            this.txtBoxRelatorio.Size = new System.Drawing.Size(557, 45);
            this.txtBoxRelatorio.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(692, 258);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(127, 47);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // chkBoxRelatorioSintetico
            // 
            this.chkBoxRelatorioSintetico.AutoSize = true;
            this.chkBoxRelatorioSintetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkBoxRelatorioSintetico.Location = new System.Drawing.Point(95, 334);
            this.chkBoxRelatorioSintetico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxRelatorioSintetico.Name = "chkBoxRelatorioSintetico";
            this.chkBoxRelatorioSintetico.Size = new System.Drawing.Size(190, 29);
            this.chkBoxRelatorioSintetico.TabIndex = 4;
            this.chkBoxRelatorioSintetico.Text = "Relatório Sintético";
            this.chkBoxRelatorioSintetico.UseVisualStyleBackColor = true;
            // 
            // chkBoxRelatorioAnalitico
            // 
            this.chkBoxRelatorioAnalitico.AutoSize = true;
            this.chkBoxRelatorioAnalitico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkBoxRelatorioAnalitico.Location = new System.Drawing.Point(345, 334);
            this.chkBoxRelatorioAnalitico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBoxRelatorioAnalitico.Name = "chkBoxRelatorioAnalitico";
            this.chkBoxRelatorioAnalitico.Size = new System.Drawing.Size(189, 29);
            this.chkBoxRelatorioAnalitico.TabIndex = 5;
            this.chkBoxRelatorioAnalitico.Text = "Relatório Analítico";
            this.chkBoxRelatorioAnalitico.UseVisualStyleBackColor = true;
            // 
            // chkRelatorioSintetico
            // 
            this.chkRelatorioSintetico.AutoSize = true;
            this.chkRelatorioSintetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkRelatorioSintetico.Location = new System.Drawing.Point(608, 334);
            this.chkRelatorioSintetico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRelatorioSintetico.Name = "chkRelatorioSintetico";
            this.chkRelatorioSintetico.Size = new System.Drawing.Size(190, 29);
            this.chkRelatorioSintetico.TabIndex = 6;
            this.chkRelatorioSintetico.Text = "Relatório Sintético";
            this.chkRelatorioSintetico.UseVisualStyleBackColor = true;
            // 
            // btnGerarPdf
            // 
            this.btnGerarPdf.BackColor = System.Drawing.Color.Black;
            this.btnGerarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGerarPdf.ForeColor = System.Drawing.Color.White;
            this.btnGerarPdf.Location = new System.Drawing.Point(639, 427);
            this.btnGerarPdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGerarPdf.Name = "btnGerarPdf";
            this.btnGerarPdf.Size = new System.Drawing.Size(180, 47);
            this.btnGerarPdf.TabIndex = 7;
            this.btnGerarPdf.Text = "Gerar PDF";
            this.btnGerarPdf.UseVisualStyleBackColor = false;
            // 
            // FormularioCriarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.btnGerarPdf);
            this.Controls.Add(this.chkRelatorioSintetico);
            this.Controls.Add(this.chkBoxRelatorioAnalitico);
            this.Controls.Add(this.chkBoxRelatorioSintetico);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBoxRelatorio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRelatorios);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioCriarRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioCriarRelatorio";
            this.Load += new System.EventHandler(this.FormularioCriarRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxRelatorio;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.CheckBox chkBoxRelatorioSintetico;
        private System.Windows.Forms.CheckBox chkBoxRelatorioAnalitico;
        private System.Windows.Forms.CheckBox chkRelatorioSintetico;
        private System.Windows.Forms.Button btnGerarPdf;
    }
}