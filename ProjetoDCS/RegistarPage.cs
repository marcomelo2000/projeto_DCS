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
    public partial class RegistarPage : Form
    {
        public RegistarPage()
        {
            InitializeComponent();
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text==textBoxConfirmacaoPassword.Text)
            {
                MessageBox.Show("Utilizador criado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PaginaInicial paginaInicial = new PaginaInicial();
                paginaInicial.ShowDialog();
            }
            else
            {
                MessageBox.Show("As palavras-passe não são iguais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
