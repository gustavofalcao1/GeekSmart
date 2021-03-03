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
    public partial class FormClientesVisu : Form
    {
        public FormClientesVisu()
        {
            InitializeComponent();
        }

        private void ButtonSendCl3_Click(object sender, EventArgs e)
        {
            FormClientesAlt frm = new FormClientesAlt();
            frm.labelIdCl2.Text = labelIdCl4.Text.ToString();
            frm.textBoxNomeCl2.Text = labelNomeCl4.Text.ToString();
            frm.textBoxBiCl2.Text = labelBiCl4.Text.ToString();
            frm.textBoxTelCl2.Text = labelTelCl4.Text.ToString();
            frm.textBoxTeleCl2.Text = labelTeleCl4.Text.ToString();
            frm.textBoxEmailCl2.Text = labelEmailCl4.Text.ToString();
            frm.textBoxCepCl2.Text = labelCepCl4.Text.ToString();
            frm.textBoxNumCl2.Text = labelNumCl4.Text.ToString();
            frm.textBoxMoradaCl2.Text = labelMoradaCl4.Text.ToString();
            frm.textBoxRefCl2.Text = labelRef2.Text.ToString();
            frm.textBoxCidadeCl2.Text = labelCidadeCl4.Text.ToString();
            frm.textBoxDistritoCl2.Text = labelDistritoCl4.Text.ToString();

            this.Close();
            frm.ShowDialog();
        }
    }
}
