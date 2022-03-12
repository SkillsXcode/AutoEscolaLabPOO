namespace AutoEscolaTrevo
{
    partial class frmCadastrarCliente
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
            this.lblCadastrarCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtBoxRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblDataExpedicao = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.dtpDataExpedicao = new System.Windows.Forms.DateTimePicker();
            this.btnVoltarCadastrarCliente = new System.Windows.Forms.Button();
            this.maskedtxtboxCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoEscolaTrevo.Properties.Resources.client_plus;
            this.pictureBox1.Location = new System.Drawing.Point(33, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCadastrarCliente
            // 
            this.lblCadastrarCliente.AutoSize = true;
            this.lblCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblCadastrarCliente.Location = new System.Drawing.Point(228, 28);
            this.lblCadastrarCliente.Name = "lblCadastrarCliente";
            this.lblCadastrarCliente.Size = new System.Drawing.Size(329, 46);
            this.lblCadastrarCliente.TabIndex = 1;
            this.lblCadastrarCliente.Text = "Cadastrar Cliente";
            this.lblCadastrarCliente.Click += new System.EventHandler(this.lblCadastrarCliente_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeCliente.Location = new System.Drawing.Point(236, 99);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(51, 20);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Nome";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNome.Location = new System.Drawing.Point(236, 129);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(317, 23);
            this.txtBoxNome.TabIndex = 3;
            this.txtBoxNome.TextChanged += new System.EventHandler(this.txtBoxNome_TextChanged);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataNascimento.Location = new System.Drawing.Point(236, 162);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(154, 20);
            this.lblDataNascimento.TabIndex = 4;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtBoxRg
            // 
            this.txtBoxRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxRg.Location = new System.Drawing.Point(236, 252);
            this.txtBoxRg.Name = "txtBoxRg";
            this.txtBoxRg.Size = new System.Drawing.Size(317, 23);
            this.txtBoxRg.TabIndex = 7;
            this.txtBoxRg.TextChanged += new System.EventHandler(this.txtBoxRg_TextChanged);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRg.Location = new System.Drawing.Point(236, 222);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 20);
            this.lblRg.TabIndex = 6;
            this.lblRg.Text = "RG";
            // 
            // lblDataExpedicao
            // 
            this.lblDataExpedicao.AutoSize = true;
            this.lblDataExpedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataExpedicao.Location = new System.Drawing.Point(236, 285);
            this.lblDataExpedicao.Name = "lblDataExpedicao";
            this.lblDataExpedicao.Size = new System.Drawing.Size(144, 20);
            this.lblDataExpedicao.TabIndex = 8;
            this.lblDataExpedicao.Text = "Data de Expedição";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpf.Location = new System.Drawing.Point(236, 345);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 10;
            this.lblCpf.Text = "CPF";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(359, 405);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 30);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(236, 192);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(317, 20);
            this.dtpDataNascimento.TabIndex = 13;
            this.dtpDataNascimento.ValueChanged += new System.EventHandler(this.dtpDataNascimento_ValueChanged);
            // 
            // dtpDataExpedicao
            // 
            this.dtpDataExpedicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataExpedicao.Location = new System.Drawing.Point(236, 315);
            this.dtpDataExpedicao.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataExpedicao.Name = "dtpDataExpedicao";
            this.dtpDataExpedicao.Size = new System.Drawing.Size(317, 20);
            this.dtpDataExpedicao.TabIndex = 14;
            // 
            // btnVoltarCadastrarCliente
            // 
            this.btnVoltarCadastrarCliente.BackColor = System.Drawing.Color.Black;
            this.btnVoltarCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVoltarCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnVoltarCadastrarCliente.Location = new System.Drawing.Point(652, 9);
            this.btnVoltarCadastrarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarCadastrarCliente.Name = "btnVoltarCadastrarCliente";
            this.btnVoltarCadastrarCliente.Size = new System.Drawing.Size(92, 32);
            this.btnVoltarCadastrarCliente.TabIndex = 15;
            this.btnVoltarCadastrarCliente.Text = "Voltar";
            this.btnVoltarCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnVoltarCadastrarCliente.Click += new System.EventHandler(this.btnVoltarCadastrarCliente_Click);
            // 
            // maskedtxtboxCpf
            // 
            this.maskedtxtboxCpf.Location = new System.Drawing.Point(236, 375);
            this.maskedtxtboxCpf.Mask = "000.000.000-00";
            this.maskedtxtboxCpf.Name = "maskedtxtboxCpf";
            this.maskedtxtboxCpf.Size = new System.Drawing.Size(317, 20);
            this.maskedtxtboxCpf.TabIndex = 16;
            this.maskedtxtboxCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // frmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.maskedtxtboxCpf);
            this.Controls.Add(this.btnVoltarCadastrarCliente);
            this.Controls.Add(this.dtpDataExpedicao);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDataExpedicao);
            this.Controls.Add(this.txtBoxRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblCadastrarCliente);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioCadastrarCliente";
            this.Load += new System.EventHandler(this.frmCadastrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblDataExpedicao;
        private System.Windows.Forms.Label lblCpf;
        public System.Windows.Forms.TextBox txtBoxNome;
        public System.Windows.Forms.Button btnCadastrar;
        public System.Windows.Forms.DateTimePicker dtpDataNascimento;
        public System.Windows.Forms.DateTimePicker dtpDataExpedicao;
        public System.Windows.Forms.MaskedTextBox maskedtxtboxCpf;
        public System.Windows.Forms.TextBox txtBoxRg;
        public System.Windows.Forms.Label lblCadastrarCliente;
        public System.Windows.Forms.Button btnVoltarCadastrarCliente;
    }
}