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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            //Empregados
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL = "Select * from Empregados";
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "Empregados");

                dataGridViewEmpre1.DataSource = DS.Tables["Empregados"];

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

            //Clientes
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL = "Select * from Clientes";
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "Clientes");

                dataGridViewClientes1.DataSource = DS.Tables["Clientes"];

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

            //Produtos
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL = "Select * from Produtos";
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "Produtos");

                dataGridViewProdutos1.DataSource = DS.Tables["Produtos"];

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

            //Vendas
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();

                string SQL = "Select * from Vendas";
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "Vendas");

                dataGridViewVendas1.DataSource = DS.Tables["Vendas"];

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void VisualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpreVisu frm = new FormEmpreVisu();
            frm.labelIdEm4.Text = dataGridViewEmpre1.SelectedCells[0].Value.ToString();
            frm.labelNomeEm4.Text = dataGridViewEmpre1.SelectedCells[1].Value.ToString();
            frm.labelNissEm4.Text = dataGridViewEmpre1.SelectedCells[2].Value.ToString();
            frm.labelFunEm4.Text = dataGridViewEmpre1.SelectedCells[3].Value.ToString();
            frm.labelTelEm4.Text = dataGridViewEmpre1.SelectedCells[4].Value.ToString();
            frm.labelEmailEm4.Text = dataGridViewEmpre1.SelectedCells[5].Value.ToString();
            frm.labelCepEm4.Text = dataGridViewEmpre1.SelectedCells[6].Value.ToString();
            frm.labelNumEm4.Text = dataGridViewEmpre1.SelectedCells[7].Value.ToString();
            frm.labelMoradaEm4.Text = dataGridViewEmpre1.SelectedCells[8].Value.ToString();
            frm.labelRef2.Text = dataGridViewEmpre1.SelectedCells[9].Value.ToString();
            frm.labelCidadeEm4.Text = dataGridViewEmpre1.SelectedCells[10].Value.ToString();
            frm.labelDistritoEm4.Text = dataGridViewEmpre1.SelectedCells[11].Value.ToString();

            frm.ShowDialog();
        }

        private void AlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpreAlt frm = new FormEmpreAlt();
            frm.labelIdEm2.Text = dataGridViewEmpre1.SelectedCells[0].Value.ToString();
            frm.textBoxNomeEm2.Text = dataGridViewEmpre1.SelectedCells[1].Value.ToString();
            frm.textBoxNissEm2.Text = dataGridViewEmpre1.SelectedCells[2].Value.ToString();
            frm.comboBoxFunEm2.Text = dataGridViewEmpre1.SelectedCells[3].Value.ToString();
            frm.textBoxTelEm2.Text = dataGridViewEmpre1.SelectedCells[4].Value.ToString();
            frm.textBoxEmailEm2.Text = dataGridViewEmpre1.SelectedCells[5].Value.ToString();
            frm.textBoxCepEm2.Text = dataGridViewEmpre1.SelectedCells[6].Value.ToString();
            frm.textBoxNumEm2.Text = dataGridViewEmpre1.SelectedCells[7].Value.ToString();
            frm.textBoxMoradaEm2.Text = dataGridViewEmpre1.SelectedCells[8].Value.ToString();
            frm.textBoxRefEm2.Text = dataGridViewEmpre1.SelectedCells[9].Value.ToString();
            frm.textBoxCidadeEm2.Text = dataGridViewEmpre1.SelectedCells[10].Value.ToString();
            frm.textBoxDistritoEm2.Text = dataGridViewEmpre1.SelectedCells[11].Value.ToString();

            frm.ShowDialog();
        }

        private void ExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();
                string ID = dataGridViewEmpre1.SelectedCells[0].Value.ToString();
                string SQL = "Delete * from Empregados where ID =" + ID;
                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar os Dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MessageBox.Show("Dados apagados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void VisualizarStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormClientesVisu frm = new FormClientesVisu();
            frm.labelIdCl4.Text = dataGridViewClientes1.SelectedCells[0].Value.ToString();
            frm.labelNomeCl4.Text = dataGridViewClientes1.SelectedCells[1].Value.ToString();
            frm.labelBiCl4.Text = dataGridViewClientes1.SelectedCells[2].Value.ToString();
            frm.labelTelCl4.Text = dataGridViewClientes1.SelectedCells[3].Value.ToString();
            frm.labelTeleCl4.Text = dataGridViewClientes1.SelectedCells[4].Value.ToString();
            frm.labelEmailCl4.Text = dataGridViewClientes1.SelectedCells[5].Value.ToString();
            frm.labelCepCl4.Text = dataGridViewClientes1.SelectedCells[6].Value.ToString();
            frm.labelNumCl4.Text = dataGridViewClientes1.SelectedCells[7].Value.ToString();
            frm.labelMoradaCl4.Text = dataGridViewClientes1.SelectedCells[8].Value.ToString();
            frm.labelRef2.Text = dataGridViewClientes1.SelectedCells[9].Value.ToString();
            frm.labelCidadeCl4.Text = dataGridViewClientes1.SelectedCells[10].Value.ToString();
            frm.labelDistritoCl4.Text = dataGridViewClientes1.SelectedCells[11].Value.ToString();

            frm.ShowDialog();
        }

        private void AlterarStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormClientesAlt frm = new FormClientesAlt();
            frm.labelIdCl2.Text = dataGridViewClientes1.SelectedCells[0].Value.ToString();
            frm.textBoxNomeCl2.Text = dataGridViewClientes1.SelectedCells[1].Value.ToString();
            frm.textBoxBiCl2.Text = dataGridViewClientes1.SelectedCells[2].Value.ToString();
            frm.textBoxTelCl2.Text = dataGridViewClientes1.SelectedCells[3].Value.ToString();
            frm.textBoxTeleCl2.Text = dataGridViewClientes1.SelectedCells[4].Value.ToString();
            frm.textBoxEmailCl2.Text = dataGridViewClientes1.SelectedCells[5].Value.ToString();
            frm.textBoxCepCl2.Text = dataGridViewClientes1.SelectedCells[6].Value.ToString();
            frm.textBoxNumCl2.Text = dataGridViewClientes1.SelectedCells[7].Value.ToString();
            frm.textBoxMoradaCl2.Text = dataGridViewClientes1.SelectedCells[8].Value.ToString();
            frm.textBoxRefCl2.Text = dataGridViewClientes1.SelectedCells[9].Value.ToString();
            frm.textBoxCidadeCl2.Text = dataGridViewClientes1.SelectedCells[10].Value.ToString();
            frm.textBoxDistritoCl2.Text = dataGridViewClientes1.SelectedCells[11].Value.ToString();

            frm.ShowDialog();
        }

        private void ExcluirStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();
                string ID = dataGridViewClientes1.SelectedCells[0].Value.ToString();
                string SQL = "Delete * from Clientes where ID =" + ID;
                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar os Dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MessageBox.Show("Dados apagados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void VizualizarStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProdutosVisu frm = new FormProdutosVisu();
            frm.labelIdPd4.Text = dataGridViewProdutos1.SelectedCells[0].Value.ToString();
            frm.labelDescriPd4.Text = dataGridViewProdutos1.SelectedCells[1].Value.ToString();
            frm.labelPcPd4.Text = dataGridViewProdutos1.SelectedCells[2].Value.ToString();
            frm.labelPvPd4.Text = dataGridViewProdutos1.SelectedCells[3].Value.ToString();
            frm.labelMedPd4.Text = dataGridViewProdutos1.SelectedCells[4].Value.ToString();
            frm.labelEstoPd4.Text = dataGridViewProdutos1.SelectedCells[5].Value.ToString();
            frm.labelEstoMPd4.Text = dataGridViewProdutos1.SelectedCells[6].Value.ToString();

            frm.ShowDialog();
        }

        private void AlterarStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormProdutosAlt frm = new FormProdutosAlt();
            frm.labelIdPd2.Text = dataGridViewProdutos1.SelectedCells[0].Value.ToString();
            frm.textBoxDescriPd2.Text = dataGridViewProdutos1.SelectedCells[1].Value.ToString();
            frm.textBoxPcPd2.Text = dataGridViewProdutos1.SelectedCells[2].Value.ToString();
            frm.textBoxPvPd2.Text = dataGridViewProdutos1.SelectedCells[3].Value.ToString();
            frm.comboBoxMedPd2.Text = dataGridViewProdutos1.SelectedCells[4].Value.ToString();
            frm.textBoxEstoPd2.Text = dataGridViewProdutos1.SelectedCells[5].Value.ToString();
            frm.textBoxEstoMPd2.Text = dataGridViewProdutos1.SelectedCells[6].Value.ToString();

            frm.ShowDialog();
        }

        private void ExcluirStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();
                string ID = dataGridViewProdutos1.SelectedCells[0].Value.ToString();
                string SQL = "Delete * from Produtos where ID =" + ID;
                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar os Dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MessageBox.Show("Dados apagados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void VizualizarStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormVendasVisu frm = new FormVendasVisu();
            frm.labelIdVd4.Text = dataGridViewVendas1.SelectedCells[0].Value.ToString();
            frm.labelDvVd4.Text = dataGridViewVendas1.SelectedCells[1].Value.ToString();
            frm.labelClienteVd4.Text = dataGridViewVendas1.SelectedCells[2].Value.ToString();
            frm.labelVendedorVd4.Text = dataGridViewVendas1.SelectedCells[3].Value.ToString();
            frm.labelProdVd4.Text = dataGridViewVendas1.SelectedCells[4].Value.ToString();
            frm.labelQuantVd4.Text = dataGridViewVendas1.SelectedCells[5].Value.ToString();
            frm.labelValorVd4.Text = dataGridViewVendas1.SelectedCells[6].Value.ToString();

            frm.ShowDialog();
        }

        private void AlterarStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormVendasAlt frm = new FormVendasAlt();
            frm.labelIdVd2.Text = dataGridViewVendas1.SelectedCells[0].Value.ToString();
            frm.dateTimePickerDvVd2.Text = dataGridViewVendas1.SelectedCells[1].Value.ToString();
            frm.textBoxClienteVd2.Text = dataGridViewVendas1.SelectedCells[2].Value.ToString();
            frm.textBoxVendedorVd2.Text = dataGridViewVendas1.SelectedCells[3].Value.ToString();
            frm.textBoxProdVd2.Text = dataGridViewVendas1.SelectedCells[4].Value.ToString();
            frm.textBoxQuantVd2.Text = dataGridViewVendas1.SelectedCells[5].Value.ToString();
            frm.textBoxValorVd2.Text = dataGridViewVendas1.SelectedCells[6].Value.ToString();

            frm.ShowDialog();
        }

        private void ExcluirStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                string StringCon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\GeekSmart\base.mdb";
                OleDbConnection conn = new OleDbConnection(StringCon);
                conn.Open();
                string ID = dataGridViewVendas1.SelectedCells[0].Value.ToString();
                string SQL = "Delete * from Vendas where ID =" + ID;
                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();

                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar os Dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MessageBox.Show("Dados apagados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
    }
}
