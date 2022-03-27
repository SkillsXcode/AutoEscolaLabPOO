namespace AutoEscolaTrevo
{
    partial class frmAutenticacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutenticacao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSenhaAutenticacao = new System.Windows.Forms.Label();
            this.txtSenhaAutenticacao = new System.Windows.Forms.TextBox();
            this.btnEntrarAutenticacao = new System.Windows.Forms.Button();
            this.btnSairFormularioGeral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblSenhaAutenticacao
            // 
            this.lblSenhaAutenticacao.AutoSize = true;
            this.lblSenhaAutenticacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSenhaAutenticacao.Location = new System.Drawing.Point(389, 425);
            this.lblSenhaAutenticacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaAutenticacao.Name = "lblSenhaAutenticacao";
            this.lblSenhaAutenticacao.Size = new System.Drawing.Size(235, 25);
            this.lblSenhaAutenticacao.TabIndex = 5;
            this.lblSenhaAutenticacao.Text = "Insira a senha de acesso:";
            // 
            // txtSenhaAutenticacao
            // 
            this.txtSenhaAutenticacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSenhaAutenticacao.Location = new System.Drawing.Point(288, 454);
            this.txtSenhaAutenticacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaAutenticacao.Name = "txtSenhaAutenticacao";
            this.txtSenhaAutenticacao.PasswordChar = '*';
            this.txtSenhaAutenticacao.Size = new System.Drawing.Size(427, 26);
            this.txtSenhaAutenticacao.TabIndex = 6;
            this.txtSenhaAutenticacao.UseSystemPasswordChar = true;
            // 
            // btnEntrarAutenticacao
            // 
            this.btnEntrarAutenticacao.BackColor = System.Drawing.Color.Black;
            this.btnEntrarAutenticacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarAutenticacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEntrarAutenticacao.ForeColor = System.Drawing.Color.White;
            this.btnEntrarAutenticacao.Location = new System.Drawing.Point(442, 499);
            this.btnEntrarAutenticacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrarAutenticacao.Name = "btnEntrarAutenticacao";
            this.btnEntrarAutenticacao.Size = new System.Drawing.Size(123, 39);
            this.btnEntrarAutenticacao.TabIndex = 16;
            this.btnEntrarAutenticacao.Text = "Entrar";
            this.btnEntrarAutenticacao.UseVisualStyleBackColor = false;
            this.btnEntrarAutenticacao.Click += new System.EventHandler(this.btnEntrarAutenticacao_Click);
            // 
            // btnSairFormularioGeral
            // 
            this.btnSairFormularioGeral.BackColor = System.Drawing.Color.Black;
            this.btnSairFormularioGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairFormularioGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSairFormularioGeral.ForeColor = System.Drawing.Color.White;
            this.btnSairFormularioGeral.Location = new System.Drawing.Point(864, 8);
            this.btnSairFormularioGeral.Name = "btnSairFormularioGeral";
            this.btnSairFormularioGeral.Size = new System.Drawing.Size(123, 39);
            this.btnSairFormularioGeral.TabIndex = 17;
            this.btnSairFormularioGeral.Text = "Sair";
            this.btnSairFormularioGeral.UseVisualStyleBackColor = false;
            this.btnSairFormularioGeral.Click += new System.EventHandler(this.btnSairFormularioGeral_Click);
            // 
            // frmAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.btnSairFormularioGeral);
            this.Controls.Add(this.btnEntrarAutenticacao);
            this.Controls.Add(this.txtSenhaAutenticacao);
            this.Controls.Add(this.lblSenhaAutenticacao);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAutenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioAutenticacao";
            this.Load += new System.EventHandler(this.frmAutenticacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSenhaAutenticacao;
        private System.Windows.Forms.TextBox txtSenhaAutenticacao;
        private System.Windows.Forms.Button btnEntrarAutenticacao;
        private System.Windows.Forms.Button btnSairFormularioGeral;
    }
}