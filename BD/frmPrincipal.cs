﻿using System;
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

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fCliente = new frmCliente();
            fCliente.MdiParent = this;
            fCliente.Show();
        }

        private void mnuProduto(object sender, EventArgs e)
        {
            frmProduto fProduto = new frmProduto();
            fProduto.MdiParent = this;
            fProduto.Show();
        }

        private void frmClose(object sender, FormClosingEventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Confirma saída?", "Aviso do sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(resp==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void produtosMySqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutosMySql fProdutoMySql = new frmProdutosMySql();
            fProdutoMySql.MdiParent = this;
            fProdutoMySql.Show();
        }
    }
}
