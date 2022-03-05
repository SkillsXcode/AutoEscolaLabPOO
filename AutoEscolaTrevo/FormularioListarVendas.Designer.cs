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
            this.lblListarVenda.Location = new System.Drawing.Point(309, 48);
            this.lblListarVenda.Name = "lblListarVenda";
            this.lblListarVenda.Size = new System.Drawing.Size(481, 58);
            this.lblListarVenda.TabIndex = 12;
            this.lblListarVenda.Text = "Listagem de Vendas";
            this.lblListarVenda.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataViewListagemVendas
            // 
            this.dataViewListagemVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewListagemVendas.Location = new System.Drawing.Point(16, 248);
            this.dataViewListagemVendas.Name = "dataViewListagemVendas";
            this.dataViewListagemVendas.RowHeadersWidth = 51;
            this.dataViewListagemVendas.RowTemplate.Height = 24;
            this.dataViewListagemVendas.Size = new System.Drawing.Size(472, 432);
            this.dataViewListagemVendas.TabIndex = 13;
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
            this.btnFrmRegistrarNovasVendas.Text = "Registrar Novas Vendas";
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
            // frmListarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
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
    }
}