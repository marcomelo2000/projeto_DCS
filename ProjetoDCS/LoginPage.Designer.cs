namespace ProjetoDCS
{
    partial class LoginPage
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
            this.labelUtilizador = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUtilizador = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUtilizador
            // 
            this.labelUtilizador.AutoSize = true;
            this.labelUtilizador.Location = new System.Drawing.Point(12, 9);
            this.labelUtilizador.Name = "labelUtilizador";
            this.labelUtilizador.Size = new System.Drawing.Size(50, 13);
            this.labelUtilizador.TabIndex = 0;
            this.labelUtilizador.Text = "Utilizador";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 43);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Palavra-Passe";
            // 
            // textBoxUtilizador
            // 
            this.textBoxUtilizador.Location = new System.Drawing.Point(68, 12);
            this.textBoxUtilizador.Name = "textBoxUtilizador";
            this.textBoxUtilizador.Size = new System.Drawing.Size(163, 20);
            this.textBoxUtilizador.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(93, 38);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(162, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(15, 73);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.Location = new System.Drawing.Point(96, 73);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistar.TabIndex = 5;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(177, 73);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 329);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonRegistar);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUtilizador);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUtilizador);
            this.Name = "LoginPage";
            this.Text = "Página de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUtilizador;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUtilizador;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.Button buttonSair;
    }
}