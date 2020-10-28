namespace ProjetoDCS
{
    partial class RegistarPage
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
            this.labelConfirmacaoPassword = new System.Windows.Forms.Label();
            this.textBoxUtilizador = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmacaoPassword = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
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
            this.labelPassword.Location = new System.Drawing.Point(12, 45);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Palavra-Passe";
            // 
            // labelConfirmacaoPassword
            // 
            this.labelConfirmacaoPassword.AutoSize = true;
            this.labelConfirmacaoPassword.Location = new System.Drawing.Point(12, 67);
            this.labelConfirmacaoPassword.Name = "labelConfirmacaoPassword";
            this.labelConfirmacaoPassword.Size = new System.Drawing.Size(128, 13);
            this.labelConfirmacaoPassword.TabIndex = 2;
            this.labelConfirmacaoPassword.Text = "Confirme a Palavra-Passe";
            // 
            // textBoxUtilizador
            // 
            this.textBoxUtilizador.Location = new System.Drawing.Point(68, 12);
            this.textBoxUtilizador.Name = "textBoxUtilizador";
            this.textBoxUtilizador.Size = new System.Drawing.Size(163, 20);
            this.textBoxUtilizador.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(93, 38);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(182, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmacaoPassword
            // 
            this.textBoxConfirmacaoPassword.Location = new System.Drawing.Point(146, 64);
            this.textBoxConfirmacaoPassword.Name = "textBoxConfirmacaoPassword";
            this.textBoxConfirmacaoPassword.Size = new System.Drawing.Size(176, 20);
            this.textBoxConfirmacaoPassword.TabIndex = 5;
            this.textBoxConfirmacaoPassword.UseSystemPasswordChar = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(12, 100);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(93, 100);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // RegistarPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 330);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxConfirmacaoPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUtilizador);
            this.Controls.Add(this.labelConfirmacaoPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUtilizador);
            this.Name = "RegistarPage";
            this.Text = "Registar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUtilizador;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmacaoPassword;
        private System.Windows.Forms.TextBox textBoxUtilizador;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmacaoPassword;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}