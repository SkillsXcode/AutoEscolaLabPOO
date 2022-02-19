namespace AutoEscolaTrevo
{
    partial class FormularioRegistrarVenda
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegistrarVenda = new System.Windows.Forms.Label();
            this.dataGridViewListagemClientes = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnRegistrarVenda = new System.Windows.Forms.Button();
            this.lblListagemClientes = new System.Windows.Forms.Label();
            this.lblListagemServicos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListagemClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRegistrarVenda
            // 
            this.lblRegistrarVenda.AutoSize = true;
            this.lblRegistrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblRegistrarVenda.Location = new System.Drawing.Point(239, 28);
            this.lblRegistrarVenda.Name = "lblRegistrarVenda";
            this.lblRegistrarVenda.Size = new System.Drawing.Size(307, 46);
            this.lblRegistrarVenda.TabIndex = 1;
            this.lblRegistrarVenda.Text = "Registrar Venda";
            // 
            // dataGridViewListagemClientes
            // 
            this.dataGridViewListagemClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListagemClientes.Location = new System.Drawing.Point(33, 231);
            this.dataGridViewListagemClientes.Name = "dataGridViewListagemClientes";
            this.dataGridViewListagemClientes.Size = new System.Drawing.Size(318, 225);
            this.dataGridViewListagemClientes.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(396, 231);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(318, 225);
            this.dataGridView2.TabIndex = 3;
            // 
            // btnRegistrarVenda
            // 
            this.btnRegistrarVenda.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegistrarVenda.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenda.Location = new System.Drawing.Point(291, 488);
            this.btnRegistrarVenda.Name = "btnRegistrarVenda";
            this.btnRegistrarVenda.Size = new System.Drawing.Size(157, 31);
            this.btnRegistrarVenda.TabIndex = 4;
            this.btnRegistrarVenda.Text = "Registrar Venda";
            this.btnRegistrarVenda.UseVisualStyleBackColor = false;
            // 
            // lblListagemClientes
            // 
            this.lblListagemClientes.AutoSize = true;
            this.lblListagemClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblListagemClientes.Location = new System.Drawing.Point(29, 208);
            this.lblListagemClientes.Name = "lblListagemClientes";
            this.lblListagemClientes.Size = new System.Drawing.Size(157, 20);
            this.lblListagemClientes.TabIndex = 5;
            this.lblListagemClientes.Text = "Listagem de Clientes";
            // 
            // lblListagemServicos
            // 
            this.lblListagemServicos.AutoSize = true;
            this.lblListagemServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblListagemServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblListagemServicos.Location = new System.Drawing.Point(392, 208);
            this.lblListagemServicos.Name = "lblListagemServicos";
            this.lblListagemServicos.Size = new System.Drawing.Size(160, 20);
            this.lblListagemServicos.TabIndex = 6;
            this.lblListagemServicos.Text = "Listagem de Serviços";
            this.lblListagemServicos.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormularioRegistrarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.lblListagemServicos);
            this.Controls.Add(this.lblListagemClientes);
            this.Controls.Add(this.btnRegistrarVenda);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridViewListagemClientes);
            this.Controls.Add(this.lblRegistrarVenda);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormularioRegistrarVenda";
            this.Text = "FormularioRegistrarVenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListagemClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRegistrarVenda;
        private System.Windows.Forms.DataGridView dataGridViewListagemClientes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRegistrarVenda;
        private System.Windows.Forms.Label lblListagemClientes;
        private System.Windows.Forms.Label lblListagemServicos;
    }
}