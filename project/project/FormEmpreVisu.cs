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
    public partial class FormEmpreVisu : Form
    {
        public FormEmpreVisu()
        {
            InitializeComponent();
        }

        private void ButtonSendEm3_Click(object sender, EventArgs e)
        {
            FormEmpreAlt frm = new FormEmpreAlt();
            frm.labelIdEm2.Text = labelIdEm4.Text.ToString();
            frm.textBoxNomeEm2.Text = labelNomeEm4.Text.ToString();
            frm.textBoxNissEm2.Text = labelNissEm4.Text.ToString();
            frm.comboBoxFunEm2.Text = labelFunEm4.Text.ToString();
            frm.textBoxTelEm2.Text = labelTelEm4.Text.ToString();
            frm.textBoxEmailEm2.Text = labelEmailEm4.Text.ToString();
            frm.textBoxCepEm2.Text = labelCepEm4.Text.ToString();
            frm.textBoxNumEm2.Text = labelNumEm4.Text.ToString();
            frm.textBoxMoradaEm2.Text = labelMoradaEm4.Text.ToString();
            frm.textBoxRefEm2.Text = labelRef2.Text.ToString();
            frm.textBoxCidadeEm2.Text = labelCidadeEm4.Text.ToString();
            frm.textBoxDistritoEm2.Text = labelDistritoEm4.Text.ToString();

            this.Close();
            frm.ShowDialog();
        }
    }
}
