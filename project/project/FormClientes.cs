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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Insert Into Clientes(Nome,BI,Telemovel,Telefone,Email,CEP,Número,Morada,Referencia,Cidade,Distrito) Values ";
                SQL += "('" + textBoxNomeCl1.Text + "','" + textBoxBiCl1.Text + "','" + textBoxTelCl1.Text + "','" + textBoxTeleCl1.Text + "','" + textBoxEmailCl1.Text + "','" + textBoxCepCl1.Text + "','" + textBoxNumCl1.Text + "','" + textBoxMoradaCl1.Text + "','" + textBoxRefCl1.Text + "','" + textBoxCidadeCl1.Text + "','" + textBoxDistritoCl1.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Cadastrado com Sucesso!");

                textBoxNomeCl1.Clear();
                textBoxBiCl1.Clear();
                textBoxTelCl1.Clear();
                textBoxTeleCl1.Clear();
                textBoxEmailCl1.Clear();
                textBoxCepCl1.Clear();
                textBoxNumCl1.Clear();
                textBoxMoradaCl1.Clear();
                textBoxRefCl1.Clear();
                textBoxCidadeCl1.Clear();
                textBoxDistritoCl1.Clear();

                conn.Close();

            }//Conexão com arquivo de base de dados e registro dos dados na base
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }//Mensagem de erro
        }
    }
}
