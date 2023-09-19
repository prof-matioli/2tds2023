using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade não implementada!",
            "Aviso do sistema!", MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fCli = new frmCliente();
            fCli.MdiParent = this;
            fCli.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor:\nJosé Alberto Matioli",
            "Aviso do sistema!", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Confirma saída?",
            "Aviso do sistema!", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (resp == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto fProd = new frmProduto();
            fProd.MdiParent = this;
            fProd.Show();
        }
    }
}
