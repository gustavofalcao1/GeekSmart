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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void ButtonSendVd1_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Insert Into Vendas (DataVenda,Cliente,Vendedor,Produto,Quantidade,Valor) Values ";
                SQL += "('" + dateTimePickerDvVd1.Text + "','" + textBoxClienteVd1.Text + "','" + textBoxVendedorVd1.Text + "','" + textBoxProdVd1.Text + "','" + textBoxQuantVd1.Text + "','" + textBoxValorVd1.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Cadastrado com Sucesso!");

                textBoxClienteVd1.Clear();
                textBoxVendedorVd1.Clear();
                textBoxProdVd1.Clear();
                textBoxQuantVd1.Clear();
                textBoxValorVd1.Clear();

                conn.Close();

            }//Conexão com arquivo de base de dados e registro dos dados na base
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }//Mensagem de erro
        }
    }
}
