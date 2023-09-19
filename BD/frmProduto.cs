using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class frmProduto : Form
    {
        DataSet dsProduto;
        public frmProduto()
        {
            InitializeComponent();
            carregaDataGrid();
        }

        private void carregaDataGrid()
        {
            String sqlSelect = "select * from Produto";
            try
            {
                //Lê a string de conexão do arquivo de configuração da aplicação, App.config
                String conString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open(); // tenta abrir a conexão
                    SqlCommand cmd = new SqlCommand(sqlSelect, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dsProduto = new DataSet();
                    da.Fill(dsProduto, "Produto");
                    DataTable dtProduto = dsProduto.Tables["Produto"];

                    // 2. seta DataSource
                    grdrodutos.DataSource = dtProduto;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha ao tentar conectar com o BD!\n" + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Falha geral do sistema!");
            }

        }

    }
}
