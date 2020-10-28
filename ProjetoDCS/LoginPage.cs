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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUtilizador.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Deve preencher os campos Utilizador e Palavra Passe", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PaginaInicial paginaInicial = new PaginaInicial();
                paginaInicial.ShowDialog();
            }
        }
        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            RegistarPage registarPage = new RegistarPage();
            registarPage.ShowDialog();
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
