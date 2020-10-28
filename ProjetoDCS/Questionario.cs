using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDCS
{
    public partial class Questionario : Form
    {
        int id;
        string genero, nacionalidade, curso, cidade, idade;
        public Questionario()
        {
            InitializeComponent();
        }
        private void buttonSubmeter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado.\nQuestionário inserido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            id++;
            if(radioButtonM.Checked)
            {
                genero = "Masculino";
            }
            if(radioButtonF.Checked)
            {
                genero = "Feminino";
            }
            nacionalidade = comboBoxNacionalidade.Text;
            idade = numericUpDownIdade.Value.ToString();
            curso = comboBoxCurso.Text;
            cidade = comboBoxCidade.Text;
            textBoxNRespostas.Text = id.ToString();
            string[] arr = new string[8];
            ListViewItem item;
            arr[0] = id.ToString();
            arr[1] = genero;
            arr[2] = idade.ToString();
            arr[3] = nacionalidade;
            arr[4] = curso;
            arr[5] = cidade;
            item = new ListViewItem(arr);
            listViewResultados.Items.Add(item);
            limpar();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void limpar()
        {
            radioButtonF.Checked = false;
            radioButtonM.Checked = true;
            numericUpDownIdade.Value = 0;
            comboBoxNacionalidade.Text = "";
            comboBoxCurso.Text = "";
            comboBoxCidade.Text = "";
        }
    }
}
