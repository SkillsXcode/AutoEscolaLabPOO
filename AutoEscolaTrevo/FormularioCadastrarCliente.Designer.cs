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
            this.txtBoxDataNascimento = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtBoxRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtBoxDataExpedicao = new System.Windows.Forms.TextBox();
            this.lblDataExpedicao = new System.Windows.Forms.Label();
            this.txtBoxCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 124);
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
            this.txtBoxNome.Location = new System.Drawing.Point(236, 127);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(321, 23);
            this.txtBoxNome.TabIndex = 3;
            // 
            // txtBoxDataNascimento
            // 
            this.txtBoxDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDataNascimento.Location = new System.Drawing.Point(236, 186);
            this.txtBoxDataNascimento.Name = "txtBoxDataNascimento";
            this.txtBoxDataNascimento.Size = new System.Drawing.Size(321, 23);
            this.txtBoxDataNascimento.TabIndex = 5;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataNascimento.Location = new System.Drawing.Point(236, 158);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(154, 20);
            this.lblDataNascimento.TabIndex = 4;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtBoxRg
            // 
            this.txtBoxRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxRg.Location = new System.Drawing.Point(236, 245);
            this.txtBoxRg.Name = "txtBoxRg";
            this.txtBoxRg.Size = new System.Drawing.Size(321, 23);
            this.txtBoxRg.TabIndex = 7;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRg.Location = new System.Drawing.Point(236, 217);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 20);
            this.lblRg.TabIndex = 6;
            this.lblRg.Text = "RG";
            // 
            // txtBoxDataExpedicao
            // 
            this.txtBoxDataExpedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDataExpedicao.Location = new System.Drawing.Point(236, 304);
            this.txtBoxDataExpedicao.Name = "txtBoxDataExpedicao";
            this.txtBoxDataExpedicao.Size = new System.Drawing.Size(321, 23);
            this.txtBoxDataExpedicao.TabIndex = 9;
            // 
            // lblDataExpedicao
            // 
            this.lblDataExpedicao.AutoSize = true;
            this.lblDataExpedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDataExpedicao.Location = new System.Drawing.Point(236, 276);
            this.lblDataExpedicao.Name = "lblDataExpedicao";
            this.lblDataExpedicao.Size = new System.Drawing.Size(144, 20);
            this.lblDataExpedicao.TabIndex = 8;
            this.lblDataExpedicao.Text = "Data de Expedição";
            // 
            // txtBoxCpf
            // 
            this.txtBoxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxCpf.Location = new System.Drawing.Point(236, 363);
            this.txtBoxCpf.Name = "txtBoxCpf";
            this.txtBoxCpf.Size = new System.Drawing.Size(321, 23);
            this.txtBoxCpf.TabIndex = 11;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCpf.Location = new System.Drawing.Point(236, 335);
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
            this.btnCadastrar.Location = new System.Drawing.Point(359, 412);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 30);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // frmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtBoxCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtBoxDataExpedicao);
            this.Controls.Add(this.lblDataExpedicao);
            this.Controls.Add(this.txtBoxRg);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtBoxDataNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblCadastrarCliente);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.TextBox txtBoxDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtBoxRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtBoxDataExpedicao;
        private System.Windows.Forms.Label lblDataExpedicao;
        private System.Windows.Forms.TextBox txtBoxCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Button btnCadastrar;
    }
}