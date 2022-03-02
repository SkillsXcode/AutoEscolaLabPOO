namespace AutoEscolaTrevo
{
    partial class PopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp));
            this.pcbAutoEscolaTrevo = new System.Windows.Forms.PictureBox();
            this.lblTextoConfirmacao = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAutoEscolaTrevo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbAutoEscolaTrevo
            // 
            this.pcbAutoEscolaTrevo.Image = ((System.Drawing.Image)(resources.GetObject("pcbAutoEscolaTrevo.Image")));
            this.pcbAutoEscolaTrevo.Location = new System.Drawing.Point(12, 12);
            this.pcbAutoEscolaTrevo.Name = "pcbAutoEscolaTrevo";
            this.pcbAutoEscolaTrevo.Size = new System.Drawing.Size(100, 50);
            this.pcbAutoEscolaTrevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAutoEscolaTrevo.TabIndex = 0;
            this.pcbAutoEscolaTrevo.TabStop = false;
            // 
            // lblTextoConfirmacao
            // 
            this.lblTextoConfirmacao.AutoSize = true;
            this.lblTextoConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoConfirmacao.Location = new System.Drawing.Point(45, 95);
            this.lblTextoConfirmacao.Name = "lblTextoConfirmacao";
            this.lblTextoConfirmacao.Size = new System.Drawing.Size(397, 20);
            this.lblTextoConfirmacao.TabIndex = 1;
            this.lblTextoConfirmacao.Text = "Tem certeza que gostaria de deixar a tela de cadastro?";
            this.lblTextoConfirmacao.Click += new System.EventHandler(this.lblTextoConfirmacao_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Black;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(130, 130);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "Sim";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Black;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(280, 130);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "Não";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.ControlBox = false;
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblTextoConfirmacao);
            this.Controls.Add(this.pcbAutoEscolaTrevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pcbAutoEscolaTrevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbAutoEscolaTrevo;
        private System.Windows.Forms.Label lblTextoConfirmacao;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}