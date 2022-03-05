namespace AutoEscolaTrevo
{
    partial class frmPagamentoPendente
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
            this.lblPagamentoPendente = new System.Windows.Forms.Label();
            this.pcbPagamentoPendente = new System.Windows.Forms.PictureBox();
            this.txtBoxBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dataGridViewPagamentoPendente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPagamentoPendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagamentoPendente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPagamentoPendente
            // 
            this.lblPagamentoPendente.AutoSize = true;
            this.lblPagamentoPendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblPagamentoPendente.Location = new System.Drawing.Point(259, 34);
            this.lblPagamentoPendente.Name = "lblPagamentoPendente";
            this.lblPagamentoPendente.Size = new System.Drawing.Size(445, 46);
            this.lblPagamentoPendente.TabIndex = 0;
            this.lblPagamentoPendente.Text = "Pagamentos Pendentes";
            // 
            // pcbPagamentoPendente
            // 
            this.pcbPagamentoPendente.Image = global::AutoEscolaTrevo.Properties.Resources.payment;
            this.pcbPagamentoPendente.Location = new System.Drawing.Point(44, 34);
            this.pcbPagamentoPendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbPagamentoPendente.Name = "pcbPagamentoPendente";
            this.pcbPagamentoPendente.Size = new System.Drawing.Size(168, 153);
            this.pcbPagamentoPendente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPagamentoPendente.TabIndex = 1;
            this.pcbPagamentoPendente.TabStop = false;
            // 
            // txtBoxBuscarCliente
            // 
            this.txtBoxBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtBoxBuscarCliente.Location = new System.Drawing.Point(44, 213);
            this.txtBoxBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxBuscarCliente.Name = "txtBoxBuscarCliente";
            this.txtBoxBuscarCliente.Size = new System.Drawing.Size(401, 45);
            this.txtBoxBuscarCliente.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(239, 281);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(208, 47);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // dataGridViewPagamentoPendente
            // 
            this.dataGridViewPagamentoPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagamentoPendente.Location = new System.Drawing.Point(455, 213);
            this.dataGridViewPagamentoPendente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPagamentoPendente.Name = "dataGridViewPagamentoPendente";
            this.dataGridViewPagamentoPendente.RowHeadersWidth = 51;
            this.dataGridViewPagamentoPendente.Size = new System.Drawing.Size(539, 434);
            this.dataGridViewPagamentoPendente.TabIndex = 4;
            // 
            // frmPagamentoPendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.dataGridViewPagamentoPendente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBoxBuscarCliente);
            this.Controls.Add(this.pcbPagamentoPendente);
            this.Controls.Add(this.lblPagamentoPendente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPagamentoPendente";
            this.Text = "FormularioPagamentoPendente";
            this.Load += new System.EventHandler(this.frmPagamentoPendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPagamentoPendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagamentoPendente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPagamentoPendente;
        private System.Windows.Forms.PictureBox pcbPagamentoPendente;
        private System.Windows.Forms.TextBox txtBoxBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridViewPagamentoPendente;
    }
}