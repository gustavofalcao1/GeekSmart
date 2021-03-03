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
    public partial class FormClientesAlt : Form
    {
        public FormClientesAlt()
        {
            InitializeComponent();
        }

        private void ButtonSendCl2_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL;

                SQL = "Update Clientes set Nome ='" + textBoxNomeCl2.Text + "',";
                SQL += "BI = '" + textBoxBiCl2.Text + "',";
                SQL += "Telemovel = '" + textBoxTelCl2.Text + "',";
                SQL += "Telefone = '" + textBoxTeleCl2.Text + "',";
                SQL += "CEP = '" + textBoxCepCl2.Text + "',";
                SQL += "Número = '" + textBoxNumCl2.Text + "',";
                SQL += "Morada = '" + textBoxMoradaCl2.Text + "',";
                SQL += "Referencia = '" + textBoxRefCl2.Text + "',";
                SQL += "Cidade = '" + textBoxCidadeCl2.Text + "',";
                SQL += "Distrito = '" + textBoxDistritoCl2.Text + "' ";
                SQL += "Where ID = " + labelIdCl2.Text;

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

        private void TextBoxNomeCl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxDistritoCl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxCidadeCl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxBiCl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxRefCl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxTelCl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMoradaCl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxTeleCl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNumCl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxEmailCl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxCepCl2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
