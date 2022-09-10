namespace WinFormsApp1
{
    partial class Fmr_ValidaSenha
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Bnt_Reset = new System.Windows.Forms.Button();
            this.Btn_VerSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(12, 45);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(218, 23);
            this.Txt_Senha.TabIndex = 0;
            this.Txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyDown);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Resultado.Location = new System.Drawing.Point(12, 90);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 22);
            this.Lbl_Resultado.TabIndex = 1;
            // 
            // Bnt_Reset
            // 
            this.Bnt_Reset.Location = new System.Drawing.Point(245, 42);
            this.Bnt_Reset.Name = "Bnt_Reset";
            this.Bnt_Reset.Size = new System.Drawing.Size(111, 23);
            this.Bnt_Reset.TabIndex = 2;
            this.Bnt_Reset.Text = "Limpa";
            this.Bnt_Reset.UseVisualStyleBackColor = true;
            this.Bnt_Reset.Click += new System.EventHandler(this.Bnt_Reset_Click);
            // 
            // Btn_VerSenha
            // 
            this.Btn_VerSenha.Location = new System.Drawing.Point(245, 71);
            this.Btn_VerSenha.Name = "Btn_VerSenha";
            this.Btn_VerSenha.Size = new System.Drawing.Size(111, 23);
            this.Btn_VerSenha.TabIndex = 3;
            this.Btn_VerSenha.Text = "Ver Senha";
            this.Btn_VerSenha.UseVisualStyleBackColor = true;
            this.Btn_VerSenha.Click += new System.EventHandler(this.Btn_VerSenha_Click);
            // 
            // Fmr_ValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.Btn_VerSenha);
            this.Controls.Add(this.Bnt_Reset);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Txt_Senha);
            this.Name = "Fmr_ValidaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de Senhas";
            this.Load += new System.EventHandler(this.Fmr_ValidaSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Txt_Senha;
        private Label Lbl_Resultado;
        private Button Bnt_Reset;
        private Button Btn_VerSenha;
    }
}