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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        private void ButtonSendPd1_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Insert Into Produtos (Descrição,PreçoCompra,PreçoVenda,Medida,Estoque,EstoqueMínimo) Values ";
                SQL += "('" + textBoxDescriPd1.Text + "','" + textBoxPcPd1.Text + "','" + textBoxPvPd1.Text + "','" + comboBoxMedPd1.Text + "','" + textBoxEstoPd1.Text + "','" + textBoxEstoMPd1.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Cadastrado com Sucesso!");

                textBoxDescriPd1.Clear();
                textBoxPcPd1.Clear();
                textBoxPvPd1.Clear();
                textBoxEstoPd1.Clear();
                textBoxEstoMPd1.Clear();

                conn.Close();

            }//Conexão com arquivo de base de dados e registro dos dados na base
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }//Mensagem de erro
        }

    }
}
