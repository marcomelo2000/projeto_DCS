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
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void questionário1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Questionario questionario = new Questionario();
            questionario.MdiParent = this;
            questionario.Show();
        }
    }
}
