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
    public partial class FormEmpreAlt : Form
    {
        public FormEmpreAlt()
        {
            InitializeComponent();
        }
        public static void ThreadProc()
        {
            Application.Run(new FormMain());
        }
        private void ButtonSendEm2_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Update Empregados set Nome ='" + textBoxNomeEm2.Text + "',";
                SQL += "NISS = '" + textBoxNissEm2.Text + "',";
                SQL += "Função = '" + comboBoxFunEm2.Text + "',";
                SQL += "Telemovel = '" + textBoxTelEm2.Text + "',";
                SQL += "CEP = '" + textBoxCepEm2.Text + "',";
                SQL += "Número = '" + textBoxNumEm2.Text + "',";
                SQL += "Morada = '" + textBoxMoradaEm2.Text + "',";
                SQL += "Referencia = '" + textBoxRefEm2.Text + "',";
                SQL += "Cidade = '" + textBoxCidadeEm2.Text + "',";
                SQL += "Distrito = '" + textBoxDistritoEm2.Text + "' ";
                SQL += "Where ID = " + labelIdEm2.Text;

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
