namespace ProjetoDCS
{
    partial class Questionario
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
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelNacionalidade = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.numericUpDownIdade = new System.Windows.Forms.NumericUpDown();
            this.comboBoxNacionalidade = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.comboBoxCidade = new System.Windows.Forms.ComboBox();
            this.buttonSubmeter = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.listViewResultados = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIdade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNacionalidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNRespostas = new System.Windows.Forms.Label();
            this.textBoxNRespostas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(12, 9);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 0;
            this.labelGenero.Text = "Género";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(12, 42);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(34, 13);
            this.labelIdade.TabIndex = 1;
            this.labelIdade.Text = "Idade";
            // 
            // labelNacionalidade
            // 
            this.labelNacionalidade.AutoSize = true;
            this.labelNacionalidade.Location = new System.Drawing.Point(12, 71);
            this.labelNacionalidade.Name = "labelNacionalidade";
            this.labelNacionalidade.Size = new System.Drawing.Size(75, 13);
            this.labelNacionalidade.TabIndex = 2;
            this.labelNacionalidade.Text = "Nacionalidade";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(12, 99);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(34, 13);
            this.labelCurso.TabIndex = 3;
            this.labelCurso.Text = "Curso";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(12, 123);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 4;
            this.labelCidade.Text = "Cidade";
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(60, 12);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(73, 17);
            this.radioButtonM.TabIndex = 5;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Masculino";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(139, 12);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(67, 17);
            this.radioButtonF.TabIndex = 6;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "Feminino";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // numericUpDownIdade
            // 
            this.numericUpDownIdade.Location = new System.Drawing.Point(60, 35);
            this.numericUpDownIdade.Name = "numericUpDownIdade";
            this.numericUpDownIdade.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIdade.TabIndex = 8;
            // 
            // comboBoxNacionalidade
            // 
            this.comboBoxNacionalidade.FormattingEnabled = true;
            this.comboBoxNacionalidade.Items.AddRange(new object[] {
            "Portugues",
            "Espanhol",
            "Francês",
            "Brasileiro",
            "Inglês",
            "Outros"});
            this.comboBoxNacionalidade.Location = new System.Drawing.Point(93, 61);
            this.comboBoxNacionalidade.Name = "comboBoxNacionalidade";
            this.comboBoxNacionalidade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNacionalidade.TabIndex = 9;
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Items.AddRange(new object[] {
            "Desenvolvimento Web e Multimédia",
            "Design Gráfico",
            "Design Industrial",
            "Mecânica Automóvel",
            "TIC"});
            this.comboBoxCurso.Location = new System.Drawing.Point(52, 88);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCurso.TabIndex = 10;
            // 
            // comboBoxCidade
            // 
            this.comboBoxCidade.FormattingEnabled = true;
            this.comboBoxCidade.Items.AddRange(new object[] {
            "Aveiro",
            "Beja",
            "Braga",
            "Bragança",
            "Castelo Branco",
            "Coimbra",
            "Évora",
            "Faro",
            "Guarda",
            "Leiria",
            "Lisboa",
            "Portalegre",
            "Porto",
            "Santarém",
            "Setúbal",
            "Viana do Castelo",
            "Vila Real",
            "Viseu",
            "Madeira",
            "Açores"});
            this.comboBoxCidade.Location = new System.Drawing.Point(58, 115);
            this.comboBoxCidade.Name = "comboBoxCidade";
            this.comboBoxCidade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCidade.TabIndex = 11;
            // 
            // buttonSubmeter
            // 
            this.buttonSubmeter.Location = new System.Drawing.Point(12, 142);
            this.buttonSubmeter.Name = "buttonSubmeter";
            this.buttonSubmeter.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmeter.TabIndex = 12;
            this.buttonSubmeter.Text = "Submeter";
            this.buttonSubmeter.UseVisualStyleBackColor = true;
            this.buttonSubmeter.Click += new System.EventHandler(this.buttonSubmeter_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(93, 142);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(174, 142);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 14;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // listViewResultados
            // 
            this.listViewResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderGenero,
            this.columnHeaderIdade,
            this.columnHeaderNacionalidade,
            this.columnHeaderCurso,
            this.columnHeaderCidade});
            this.listViewResultados.GridLines = true;
            this.listViewResultados.HideSelection = false;
            this.listViewResultados.Location = new System.Drawing.Point(323, 12);
            this.listViewResultados.Name = "listViewResultados";
            this.listViewResultados.Size = new System.Drawing.Size(565, 284);
            this.listViewResultados.TabIndex = 15;
            this.listViewResultados.UseCompatibleStateImageBehavior = false;
            this.listViewResultados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Nº";
            this.columnHeaderId.Width = 30;
            // 
            // columnHeaderGenero
            // 
            this.columnHeaderGenero.Text = "Género";
            // 
            // columnHeaderIdade
            // 
            this.columnHeaderIdade.Text = "Idade";
            // 
            // columnHeaderNacionalidade
            // 
            this.columnHeaderNacionalidade.Text = "Nacionalidade";
            this.columnHeaderNacionalidade.Width = 90;
            // 
            // columnHeaderCurso
            // 
            this.columnHeaderCurso.Text = "Curso";
            this.columnHeaderCurso.Width = 150;
            // 
            // columnHeaderCidade
            // 
            this.columnHeaderCidade.Text = "Cidade";
            this.columnHeaderCidade.Width = 150;
            // 
            // labelNRespostas
            // 
            this.labelNRespostas.AutoSize = true;
            this.labelNRespostas.Location = new System.Drawing.Point(320, 305);
            this.labelNRespostas.Name = "labelNRespostas";
            this.labelNRespostas.Size = new System.Drawing.Size(87, 13);
            this.labelNRespostas.TabIndex = 16;
            this.labelNRespostas.Text = "Nº de Respostas";
            // 
            // textBoxNRespostas
            // 
            this.textBoxNRespostas.Enabled = false;
            this.textBoxNRespostas.Location = new System.Drawing.Point(413, 302);
            this.textBoxNRespostas.Name = "textBoxNRespostas";
            this.textBoxNRespostas.Size = new System.Drawing.Size(100, 20);
            this.textBoxNRespostas.TabIndex = 17;
            // 
            // Questionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 334);
            this.Controls.Add(this.textBoxNRespostas);
            this.Controls.Add(this.labelNRespostas);
            this.Controls.Add(this.listViewResultados);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSubmeter);
            this.Controls.Add(this.comboBoxCidade);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.comboBoxNacionalidade);
            this.Controls.Add(this.numericUpDownIdade);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.labelNacionalidade);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelGenero);
            this.Name = "Questionario";
            this.Text = "Questionário";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.Label labelNacionalidade;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.NumericUpDown numericUpDownIdade;
        private System.Windows.Forms.ComboBox comboBoxNacionalidade;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.ComboBox comboBoxCidade;
        private System.Windows.Forms.Button buttonSubmeter;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ListView listViewResultados;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderGenero;
        private System.Windows.Forms.ColumnHeader columnHeaderIdade;
        private System.Windows.Forms.ColumnHeader columnHeaderNacionalidade;
        private System.Windows.Forms.ColumnHeader columnHeaderCurso;
        private System.Windows.Forms.ColumnHeader columnHeaderCidade;
        private System.Windows.Forms.Label labelNRespostas;
        private System.Windows.Forms.TextBox textBoxNRespostas;
    }
}