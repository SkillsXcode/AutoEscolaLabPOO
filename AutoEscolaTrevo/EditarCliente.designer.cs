namespace AutoEscolaTrevo
{
    partial class frmEditarCliente
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
            this.maskedtxtboxCpf = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataExpedicao = new System.Windows.Forms.DateTimePicker();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDataExpedicao = new System.Windows.Forms.Label();
            this.txtBoxRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblEditarCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedtxtboxCpf
            // 
            this.maskedtxtboxCpf.Location = new System.Drawing.Point(325, 454);
            this.maskedtxtboxCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedtxtboxCpf.Mask = "000.000.000-00";
            this.maskedtxtboxCpf.Name = "maskedtxtboxCpf";
            this.maskedtxtboxCpf.Size = new System.Drawing.Size(421, 22);
            this.maskedtxtboxCpf.TabIndex = 28;
            // 
            // dtpDataExpedicao
            // 
            this.dtpDataExpedicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataExpedicao.Location = new System.Drawing.Point(325, 380);
            this.dtpDataExpedicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataExpedicao.Name = "dtpDataExpedicao";
            this.dtpDataExpedicao.Size = new System.Drawing.Size(421, 22);
            this.dtpDataExpedicao.TabIndex = 27;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(325, 229);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(421, 22);
            this.dtpDataNascimento.TabIndex = 26;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(489, 491);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 37);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpf.Location = new System.Drawing.Point(325, 417);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(52, 25);
            this.lblCpf.TabIndex = 24;
            this.lblCpf.Text = "CPF";
            // 
            // lblDataExpedicao
            // 
            this.lblDataExpedicao.AutoSize = true;
            this.lblDataExpedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataExpedicao.Location = new System.Drawing.Point(325, 343);
            this.lblDataExpedicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataExpedicao.Name = "lblDataExpedicao";
            this.lblDataExpedicao.Size = new System.Drawing.Size(177, 25);
            this.lblDataExpedicao.TabIndex = 23;
            this.lblDataExpedicao.Text = "Data de Expedição";
            // 
            // txtBoxRg
            // 
            this.txtBoxRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxRg.Location = new System.Drawing.Point(325, 303);
            this.txtBoxRg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxRg.Name = "txtBoxRg";
            this.txtBoxRg.Size = new System.Drawing.Size(421, 26);
            this.txtBoxRg.TabIndex = 22;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRg.Location = new System.Drawing.Point(325, 266);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(40, 25);
            this.lblRg.TabIndex = 21;
            this.lblRg.Text = "RG";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataNascimento.Location = new System.Drawing.Point(325, 192);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(188, 25);
            this.lblDataNascimento.TabIndex = 20;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNome.Location = new System.Drawing.Point(325, 151);
            this.txtBoxNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(421, 26);
            this.txtBoxNome.TabIndex = 19;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeCliente.Location = new System.Drawing.Point(325, 114);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(64, 25);
            this.lblNomeCliente.TabIndex = 18;
            this.lblNomeCliente.Text = "Nome";
            // 
            // lblEditarCliente
            // 
            this.lblEditarCliente.AutoSize = true;
            this.lblEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblEditarCliente.Location = new System.Drawing.Point(315, 27);
            this.lblEditarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditarCliente.Name = "lblEditarCliente";
            this.lblEditarCliente.Size = new System.Drawing.Size(325, 58);
            this.lblEditarCliente.TabIndex = 17;
            this.lblEditarCliente.Text = "Editar Cliente";
            // 
            // frmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.maskedtxtboxCpf);
            this.Controls.Add(this.dtpDataExpedicao);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDataExpedicao);
            this.Controls.Add(this.txtBoxRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblEditarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCliente";
            this.Load += new System.EventHandler(this.frmEditarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox maskedtxtboxCpf;
        public System.Windows.Forms.DateTimePicker dtpDataExpedicao;
        public System.Windows.Forms.DateTimePicker dtpDataNascimento;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDataExpedicao;
        public System.Windows.Forms.TextBox txtBoxRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblDataNascimento;
        public System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label lblNomeCliente;
        public System.Windows.Forms.Label lblEditarCliente;
    }
}