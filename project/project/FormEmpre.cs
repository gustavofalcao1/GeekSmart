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
    public partial class FormEmpre : Form
    {
        public FormEmpre()
        {
            InitializeComponent();
        }
        public string ID;
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Insert Into Empregados (Nome,NISS,Função,Telemovel,Email,CEP,Número,Morada,Referencia,Cidade,Distrito) Values ";
                SQL += "('" + textBoxNomeEm1.Text + "','" + textBoxNissEm1.Text + "','" + comboBoxFunEm1.Text + "','" + textBoxTelEm1.Text + "','" + textBoxEmailEm1.Text + "','" + textBoxCepEm1.Text + "','" + textBoxNumEm1.Text + "','" + textBoxMoradaEm1.Text + "','" + textBoxRefEm1.Text + "','" + textBoxCidadeEm1.Text + "','" + textBoxDistritoEm1.Text + "')";

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Cadastrado com Sucesso!");

                textBoxNomeEm1.Clear();
                textBoxNissEm1.Clear();
                textBoxTelEm1.Clear();
                textBoxEmailEm1.Clear();
                textBoxCepEm1.Clear();
                textBoxNumEm1.Clear();
                textBoxMoradaEm1.Clear();
                textBoxRefEm1.Clear();
                textBoxCidadeEm1.Clear();
                textBoxDistritoEm1.Clear();

                conn.Close();

            }//Conexão com arquivo de base de dados e registro dos dados na base
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }//Mensagem de erro
        }

    }
}
