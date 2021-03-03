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
    public partial class FormVendasVisu : Form
    {
        public FormVendasVisu()
        {
            InitializeComponent();
        }

        private void ButtonSendVd3_Click(object sender, EventArgs e)
        {
            FormVendasAlt frm = new FormVendasAlt();
            frm.labelIdVd2.Text = labelIdVd4.Text.ToString();
            frm.dateTimePickerDvVd2.Text = labelDvVd4.Text.ToString();
            frm.textBoxClienteVd2.Text = labelClienteVd4.Text.ToString();
            frm.textBoxVendedorVd2.Text = labelVendedorVd4.Text.ToString();
            frm.textBoxProdVd2.Text = labelProdVd4.Text.ToString();
            frm.textBoxQuantVd2.Text = labelQuantVd4.Text.ToString();
            frm.textBoxValorVd2.Text = labelValorVd4.Text.ToString();

            this.Close();
            frm.ShowDialog();
        }
    }
}
