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
            this.txtBoxCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.dtpDataExpedicao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoEscolaTrevo.Properties.Resources.client_plus;
            this.pictureBox1.Location = new System.Drawing.Point(44, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCadastrarCliente
            // 
            this.lblCadastrarCliente.AutoSize = true;
            this.lblCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblCadastrarCliente.Location = new System.Drawing.Point(304, 34);
            this.lblCadastrarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrarCliente.Name = "lblCadastrarCliente";
            this.lblCadastrarCliente.Size = new System.Drawing.Size(415, 58);
            this.lblCadastrarCliente.TabIndex = 1;
            this.lblCadastrarCliente.Text = "Cadastrar Cliente";
            this.lblCadastrarCliente.Click += new System.EventHandler(this.lblCadastrarCliente_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNomeCliente.Location = new System.Drawing.Point(315, 122);
            this.lblNomeCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(64, 25);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Nome";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNome.Location = new System.Drawing.Point(315, 156);
            this.txtBoxNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(427, 26);
            this.txtBoxNome.TabIndex = 3;
            this.txtBoxNome.TextChanged += new System.EventHandler(this.txtBoxNome_TextChanged);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataNascimento.Location = new System.Drawing.Point(315, 194);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(188, 25);
            this.lblDataNascimento.TabIndex = 4;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtBoxRg
            // 
            this.txtBoxRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxRg.Location = new System.Drawing.Point(315, 302);
            this.txtBoxRg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxRg.Name = "txtBoxRg";
            this.txtBoxRg.Size = new System.Drawing.Size(427, 26);
            this.txtBoxRg.TabIndex = 7;
            this.txtBoxRg.TextChanged += new System.EventHandler(this.txtBoxRg_TextChanged);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRg.Location = new System.Drawing.Point(315, 267);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(40, 25);
            this.lblRg.TabIndex = 6;
            this.lblRg.Text = "RG";
            // 
            // lblDataExpedicao
            // 
            this.lblDataExpedicao.AutoSize = true;
            this.lblDataExpedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataExpedicao.Location = new System.Drawing.Point(315, 340);
            this.lblDataExpedicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataExpedicao.Name = "lblDataExpedicao";
            this.lblDataExpedicao.Size = new System.Drawing.Size(177, 25);
            this.lblDataExpedicao.TabIndex = 8;
            this.lblDataExpedicao.Text = "Data de Expedição";
            // 
            // txtBoxCpf
            // 
            this.txtBoxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxCpf.Location = new System.Drawing.Point(315, 447);
            this.txtBoxCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCpf.Name = "txtBoxCpf";
            this.txtBoxCpf.Size = new System.Drawing.Size(427, 26);
            this.txtBoxCpf.TabIndex = 11;
            this.txtBoxCpf.TextChanged += new System.EventHandler(this.txtBoxCpf_TextChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpf.Location = new System.Drawing.Point(315, 412);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(52, 25);
            this.lblCpf.TabIndex = 10;
            this.lblCpf.Text = "CPF";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(479, 507);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(119, 37);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(320, 232);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(416, 22);
            this.dtpDataNascimento.TabIndex = 13;
            this.dtpDataNascimento.ValueChanged += new System.EventHandler(this.dtpDataNascimento_ValueChanged);
            // 
            // dtpDataExpedicao
            // 
            this.dtpDataExpedicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataExpedicao.Location = new System.Drawing.Point(320, 376);
            this.dtpDataExpedicao.Name = "dtpDataExpedicao";
            this.dtpDataExpedicao.Size = new System.Drawing.Size(416, 22);
            this.dtpDataExpedicao.TabIndex = 14;
            // 
            // frmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.dtpDataExpedicao);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtBoxCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDataExpedicao);
            this.Controls.Add(this.txtBoxRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblCadastrarCliente);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCadastrarCliente";
            this.Text = "FormularioCadastrarCliente";
            this.Load += new System.EventHandler(this.frmCadastrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCadastrarCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtBoxRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblDataExpedicao;
        private System.Windows.Forms.TextBox txtBoxCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.DateTimePicker dtpDataExpedicao;
    }
}