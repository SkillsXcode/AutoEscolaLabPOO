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
            this.lblPagamentoPendente.Location = new System.Drawing.Point(194, 28);
            this.lblPagamentoPendente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPagamentoPendente.Name = "lblPagamentoPendente";
            this.lblPagamentoPendente.Size = new System.Drawing.Size(357, 37);
            this.lblPagamentoPendente.TabIndex = 0;
            this.lblPagamentoPendente.Text = "Pagamentos Pendentes";
            // 
            // pcbPagamentoPendente
            // 
            this.pcbPagamentoPendente.Image = global::AutoEscolaTrevo.Properties.Resources.payment;
            this.pcbPagamentoPendente.Location = new System.Drawing.Point(33, 28);
            this.pcbPagamentoPendente.Margin = new System.Windows.Forms.Padding(2);
            this.pcbPagamentoPendente.Name = "pcbPagamentoPendente";
            this.pcbPagamentoPendente.Size = new System.Drawing.Size(126, 124);
            this.pcbPagamentoPendente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPagamentoPendente.TabIndex = 1;
            this.pcbPagamentoPendente.TabStop = false;
            // 
            // txtBoxBuscarCliente
            // 
            this.txtBoxBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtBoxBuscarCliente.Location = new System.Drawing.Point(33, 173);
            this.txtBoxBuscarCliente.Name = "txtBoxBuscarCliente";
            this.txtBoxBuscarCliente.Size = new System.Drawing.Size(302, 38);
            this.txtBoxBuscarCliente.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(179, 228);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(156, 38);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // dataGridViewPagamentoPendente
            // 
            this.dataGridViewPagamentoPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagamentoPendente.Location = new System.Drawing.Point(341, 173);
            this.dataGridViewPagamentoPendente.Name = "dataGridViewPagamentoPendente";
            this.dataGridViewPagamentoPendente.Size = new System.Drawing.Size(404, 353);
            this.dataGridViewPagamentoPendente.TabIndex = 4;
            // 
            // frmPagamentoPendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.dataGridViewPagamentoPendente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBoxBuscarCliente);
            this.Controls.Add(this.pcbPagamentoPendente);
            this.Controls.Add(this.lblPagamentoPendente);
            this.Name = "frmPagamentoPendente";
            this.Text = "FormularioPagamentoPendente";
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