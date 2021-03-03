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
    public partial class FormProdutosVisu : Form
    {
        public FormProdutosVisu()
        {
            InitializeComponent();
        }

        private void ButtonSendPd3_Click(object sender, EventArgs e)
        {
            FormProdutosAlt frm = new FormProdutosAlt();
            frm.labelIdPd2.Text = labelIdPd4.Text.ToString();
            frm.textBoxDescriPd2.Text = labelDescriPd4.Text.ToString();
            frm.textBoxPcPd2.Text = labelPcPd4.Text.ToString();
            frm.textBoxPvPd2.Text = labelPvPd4.Text.ToString();
            frm.comboBoxMedPd2.Text = labelMedPd4.Text.ToString();
            frm.textBoxEstoPd2.Text = labelEstoPd4.Text.ToString();
            frm.textBoxEstoMPd2.Text = labelEstoMPd4.Text.ToString();

            this.Close();
            frm.ShowDialog();
        }
    }
}
