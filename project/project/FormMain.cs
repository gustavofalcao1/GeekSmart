using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public static void ThreadProc()
        {
            Application.Run(new FormHome());
            Application.Run(new FormClientes());
            Application.Run(new FormMain());
            Application.Run(new FormEmpre());
            Application.Run(new FormProdutos());
            Application.Run(new FormVendas());
            Application.Run(new FormAbout());
        }
        private void FecharFormulariosFilhos()
        {
            // percorre todos os formulários abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();

                    this.homeToolStripMenuItem.BackColor = Color.Gray;
                    this.clientesToolStripMenuItem.BackColor = Color.Gray;
                    this.produtosToolStripMenuItem.BackColor = Color.Gray;
                    this.vendasToolStripMenuItem.BackColor = Color.Gray;
                    this.empreToolStripMenuItem.BackColor = Color.Gray;
                }
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            FormHome f = new FormHome();
            f.MdiParent = this;
            f.Show();
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            this.homeToolStripMenuItem.BackColor = Color.MediumTurquoise;

            FormHome f = new FormHome();
            f.MdiParent = this;
            f.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            this.clientesToolStripMenuItem.BackColor = Color.MediumTurquoise;

            FormClientes f = new FormClientes();
            f.MdiParent = this;
            f.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            this.produtosToolStripMenuItem.BackColor = Color.MediumTurquoise;

            FormProdutos f = new FormProdutos();
            f.MdiParent = this;
            f.Show();
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            this.vendasToolStripMenuItem.BackColor = Color.MediumTurquoise;

            FormVendas f = new FormVendas();
            f.MdiParent = this;
            f.Show();
        }

        private void EmpreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();

            this.empreToolStripMenuItem.BackColor = Color.MediumTurquoise;

            FormEmpre f = new FormEmpre();
            f.MdiParent = this;
            f.Show();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }
    }
}
