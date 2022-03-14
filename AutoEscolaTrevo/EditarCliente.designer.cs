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
            this.maskedtxtboxCpf.Location = new System.Drawing.Point(244, 369);
            this.maskedtxtboxCpf.Mask = "000.000.000-00";
            this.maskedtxtboxCpf.Name = "maskedtxtboxCpf";
            this.maskedtxtboxCpf.Size = new System.Drawing.Size(317, 20);
            this.maskedtxtboxCpf.TabIndex = 28;
            // 
            // dtpDataExpedicao
            // 
            this.dtpDataExpedicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataExpedicao.Location = new System.Drawing.Point(244, 309);
            this.dtpDataExpedicao.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataExpedicao.Name = "dtpDataExpedicao";
            this.dtpDataExpedicao.Size = new System.Drawing.Size(317, 20);
            this.dtpDataExpedicao.TabIndex = 27;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(244, 186);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(317, 20);
            this.dtpDataNascimento.TabIndex = 26;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(367, 399);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 30);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpf.Location = new System.Drawing.Point(244, 339);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 24;
            this.lblCpf.Text = "CPF";
            // 
            // lblDataExpedicao
            // 
            this.lblDataExpedicao.AutoSize = true;
            this.lblDataExpedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataExpedicao.Location = new System.Drawing.Point(244, 279);
            this.lblDataExpedicao.Name = "lblDataExpedicao";
            this.lblDataExpedicao.Size = new System.Drawing.Size(144, 20);
            this.lblDataExpedicao.TabIndex = 23;
            this.lblDataExpedicao.Text = "Data de Expedição";
            // 
            // txtBoxRg
            // 
            this.txtBoxRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxRg.Location = new System.Drawing.Point(244, 246);
            this.txtBoxRg.Name = "txtBoxRg";
            this.txtBoxRg.Size = new System.Drawing.Size(317, 23);
            this.txtBoxRg.TabIndex = 22;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRg.Location = new System.Drawing.Point(244, 216);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 20);
            this.lblRg.TabIndex = 21;
            this.lblRg.Text = "RG";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataNascimento.Location = new System.Drawing.Point(244, 156);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(154, 20);
            this.lblDataNascimento.TabIndex = 20;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNome.Location = new System.Drawing.Point(244, 123);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(317, 23);
            this.txtBoxNome.TabIndex = 19;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeCliente.Location = new System.Drawing.Point(244, 93);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(51, 20);
            this.lblNomeCliente.TabIndex = 18;
            this.lblNomeCliente.Text = "Nome";
            // 
            // lblEditarCliente
            // 
            this.lblEditarCliente.AutoSize = true;
            this.lblEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblEditarCliente.Location = new System.Drawing.Point(236, 22);
            this.lblEditarCliente.Name = "lblEditarCliente";
            this.lblEditarCliente.Size = new System.Drawing.Size(259, 46);
            this.lblEditarCliente.TabIndex = 17;
            this.lblEditarCliente.Text = "Editar Cliente";
            // 
            // frmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(754, 586);
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
            this.Name = "frmEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCliente";
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