using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class FormProdutosAlt : Form
    {
        public FormProdutosAlt()
        {
            InitializeComponent();
        }

        private void ButtonSendPd2_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Update Produtos set Descrição ='" + textBoxDescriPd2.Text + "',";
                SQL += "PreçoCompra = '" + textBoxPcPd2.Text + "',";
                SQL += "PreçoVenda = '" + textBoxPvPd2.Text + "',";
                SQL += "Medida = '" + comboBoxMedPd2.Text + "',";
                SQL += "Estoque = '" + textBoxEstoPd2.Text + "',";
                SQL += "EstoqueMínimo = '" + textBoxEstoMPd2.Text + "' ";
                SQL += "Where ID = " + labelIdPd2.Text;

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados com Sucesso!");
                this.Close();

                conn.Close();

            }//Conexão com arquivo de base de dados e registro dos dados na base
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }//Mensagem de erro
        }

    }
}
