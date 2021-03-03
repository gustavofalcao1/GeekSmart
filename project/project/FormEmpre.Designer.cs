namespace project
{
    partial class FormEmpre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpre));
            this.labelTitleEm1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFunEm1 = new System.Windows.Forms.ComboBox();
            this.buttonSendEm1 = new System.Windows.Forms.Button();
            this.textBoxNomeEm1 = new System.Windows.Forms.TextBox();
            this.textBoxDistritoEm1 = new System.Windows.Forms.TextBox();
            this.labelNomeEm1 = new System.Windows.Forms.Label();
            this.labelDistritoEm1 = new System.Windows.Forms.Label();
            this.labelNissEm1 = new System.Windows.Forms.Label();
            this.textBoxCidadeEm1 = new System.Windows.Forms.TextBox();
            this.textBoxNissEm1 = new System.Windows.Forms.TextBox();
            this.labelCidadeEm1 = new System.Windows.Forms.Label();
            this.labelFunEm1 = new System.Windows.Forms.Label();
            this.textBoxRefEm1 = new System.Windows.Forms.TextBox();
            this.labelRefEm1 = new System.Windows.Forms.Label();
            this.labelTelEm1 = new System.Windows.Forms.Label();
            this.textBoxMoradaEm1 = new System.Windows.Forms.TextBox();
            this.textBoxTelEm1 = new System.Windows.Forms.TextBox();
            this.labelMoradaEm1 = new System.Windows.Forms.Label();
            this.labelEmailEm1 = new System.Windows.Forms.Label();
            this.textBoxNumEm1 = new System.Windows.Forms.TextBox();
            this.textBoxEmailEm1 = new System.Windows.Forms.TextBox();
            this.labelNumEm1 = new System.Windows.Forms.Label();
            this.labelCepEm1 = new System.Windows.Forms.Label();
            this.textBoxCepEm1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitleEm1
            // 
            this.labelTitleEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleEm1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitleEm1.Location = new System.Drawing.Point(3, 35);
            this.labelTitleEm1.Name = "labelTitleEm1";
            this.labelTitleEm1.Size = new System.Drawing.Size(1121, 46);
            this.labelTitleEm1.TabIndex = 3;
            this.labelTitleEm1.Text = "Cadastro de Empregados";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.comboBoxFunEm1);
            this.groupBox1.Controls.Add(this.buttonSendEm1);
            this.groupBox1.Controls.Add(this.textBoxNomeEm1);
            this.groupBox1.Controls.Add(this.textBoxDistritoEm1);
            this.groupBox1.Controls.Add(this.labelNomeEm1);
            this.groupBox1.Controls.Add(this.labelDistritoEm1);
            this.groupBox1.Controls.Add(this.labelNissEm1);
            this.groupBox1.Controls.Add(this.textBoxCidadeEm1);
            this.groupBox1.Controls.Add(this.textBoxNissEm1);
            this.groupBox1.Controls.Add(this.labelCidadeEm1);
            this.groupBox1.Controls.Add(this.labelFunEm1);
            this.groupBox1.Controls.Add(this.textBoxRefEm1);
            this.groupBox1.Controls.Add(this.labelRefEm1);
            this.groupBox1.Controls.Add(this.labelTelEm1);
            this.groupBox1.Controls.Add(this.textBoxMoradaEm1);
            this.groupBox1.Controls.Add(this.textBoxTelEm1);
            this.groupBox1.Controls.Add(this.labelMoradaEm1);
            this.groupBox1.Controls.Add(this.labelEmailEm1);
            this.groupBox1.Controls.Add(this.textBoxNumEm1);
            this.groupBox1.Controls.Add(this.textBoxEmailEm1);
            this.groupBox1.Controls.Add(this.labelNumEm1);
            this.groupBox1.Controls.Add(this.labelCepEm1);
            this.groupBox1.Controls.Add(this.textBoxCepEm1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 622);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxFunEm1
            // 
            this.comboBoxFunEm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFunEm1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFunEm1.FormattingEnabled = true;
            this.comboBoxFunEm1.Items.AddRange(new object[] {
            "Gestor Geral",
            "Gestor de Vendas",
            "Gestor Administrativo",
            "Gestor Técnico",
            "Setor de Vendas",
            "Setor Técnico",
            "Setor Administrativo"});
            this.comboBoxFunEm1.Location = new System.Drawing.Point(209, 136);
            this.comboBoxFunEm1.Name = "comboBoxFunEm1";
            this.comboBoxFunEm1.Size = new System.Drawing.Size(351, 33);
            this.comboBoxFunEm1.TabIndex = 2;
            // 
            // buttonSendEm1
            // 
            this.buttonSendEm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSendEm1.BackgroundImage")));
            this.buttonSendEm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSendEm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendEm1.Location = new System.Drawing.Point(1024, 532);
            this.buttonSendEm1.Name = "buttonSendEm1";
            this.buttonSendEm1.Size = new System.Drawing.Size(88, 82);
            this.buttonSendEm1.TabIndex = 11;
            this.buttonSendEm1.UseVisualStyleBackColor = true;
            this.buttonSendEm1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxNomeEm1
            // 
            this.textBoxNomeEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeEm1.Location = new System.Drawing.Point(209, 30);
            this.textBoxNomeEm1.Name = "textBoxNomeEm1";
            this.textBoxNomeEm1.Size = new System.Drawing.Size(642, 31);
            this.textBoxNomeEm1.TabIndex = 0;
            // 
            // textBoxDistritoEm1
            // 
            this.textBoxDistritoEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDistritoEm1.Location = new System.Drawing.Point(209, 560);
            this.textBoxDistritoEm1.Name = "textBoxDistritoEm1";
            this.textBoxDistritoEm1.Size = new System.Drawing.Size(290, 31);
            this.textBoxDistritoEm1.TabIndex = 10;
            // 
            // labelNomeEm1
            // 
            this.labelNomeEm1.AutoSize = true;
            this.labelNomeEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeEm1.Location = new System.Drawing.Point(106, 27);
            this.labelNomeEm1.Name = "labelNomeEm1";
            this.labelNomeEm1.Size = new System.Drawing.Size(97, 31);
            this.labelNomeEm1.TabIndex = 0;
            this.labelNomeEm1.Text = "Nome*";
            // 
            // labelDistritoEm1
            // 
            this.labelDistritoEm1.AutoSize = true;
            this.labelDistritoEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistritoEm1.Location = new System.Drawing.Point(92, 557);
            this.labelDistritoEm1.Name = "labelDistritoEm1";
            this.labelDistritoEm1.Size = new System.Drawing.Size(111, 31);
            this.labelDistritoEm1.TabIndex = 0;
            this.labelDistritoEm1.Text = "Distrito*";
            // 
            // labelNissEm1
            // 
            this.labelNissEm1.AutoSize = true;
            this.labelNissEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNissEm1.Location = new System.Drawing.Point(114, 80);
            this.labelNissEm1.Name = "labelNissEm1";
            this.labelNissEm1.Size = new System.Drawing.Size(89, 31);
            this.labelNissEm1.TabIndex = 0;
            this.labelNissEm1.Text = "NISS*";
            // 
            // textBoxCidadeEm1
            // 
            this.textBoxCidadeEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidadeEm1.Location = new System.Drawing.Point(209, 507);
            this.textBoxCidadeEm1.Name = "textBoxCidadeEm1";
            this.textBoxCidadeEm1.Size = new System.Drawing.Size(351, 31);
            this.textBoxCidadeEm1.TabIndex = 9;
            // 
            // textBoxNissEm1
            // 
            this.textBoxNissEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNissEm1.Location = new System.Drawing.Point(209, 83);
            this.textBoxNissEm1.Name = "textBoxNissEm1";
            this.textBoxNissEm1.Size = new System.Drawing.Size(297, 31);
            this.textBoxNissEm1.TabIndex = 1;
            // 
            // labelCidadeEm1
            // 
            this.labelCidadeEm1.AutoSize = true;
            this.labelCidadeEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidadeEm1.Location = new System.Drawing.Point(92, 504);
            this.labelCidadeEm1.Name = "labelCidadeEm1";
            this.labelCidadeEm1.Size = new System.Drawing.Size(111, 31);
            this.labelCidadeEm1.TabIndex = 0;
            this.labelCidadeEm1.Text = "Cidade*";
            // 
            // labelFunEm1
            // 
            this.labelFunEm1.AutoSize = true;
            this.labelFunEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunEm1.Location = new System.Drawing.Point(87, 133);
            this.labelFunEm1.Name = "labelFunEm1";
            this.labelFunEm1.Size = new System.Drawing.Size(116, 31);
            this.labelFunEm1.TabIndex = 0;
            this.labelFunEm1.Text = "Função*";
            // 
            // textBoxRefEm1
            // 
            this.textBoxRefEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRefEm1.Location = new System.Drawing.Point(209, 454);
            this.textBoxRefEm1.Name = "textBoxRefEm1";
            this.textBoxRefEm1.Size = new System.Drawing.Size(453, 31);
            this.textBoxRefEm1.TabIndex = 8;
            // 
            // labelRefEm1
            // 
            this.labelRefEm1.AutoSize = true;
            this.labelRefEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefEm1.Location = new System.Drawing.Point(46, 451);
            this.labelRefEm1.Name = "labelRefEm1";
            this.labelRefEm1.Size = new System.Drawing.Size(146, 31);
            this.labelRefEm1.TabIndex = 0;
            this.labelRefEm1.Text = "Referencia";
            // 
            // labelTelEm1
            // 
            this.labelTelEm1.AutoSize = true;
            this.labelTelEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelEm1.Location = new System.Drawing.Point(53, 186);
            this.labelTelEm1.Name = "labelTelEm1";
            this.labelTelEm1.Size = new System.Drawing.Size(150, 31);
            this.labelTelEm1.TabIndex = 0;
            this.labelTelEm1.Text = "Telemovel*";
            // 
            // textBoxMoradaEm1
            // 
            this.textBoxMoradaEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoradaEm1.Location = new System.Drawing.Point(209, 401);
            this.textBoxMoradaEm1.Name = "textBoxMoradaEm1";
            this.textBoxMoradaEm1.Size = new System.Drawing.Size(453, 31);
            this.textBoxMoradaEm1.TabIndex = 7;
            // 
            // textBoxTelEm1
            // 
            this.textBoxTelEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelEm1.Location = new System.Drawing.Point(209, 189);
            this.textBoxTelEm1.Name = "textBoxTelEm1";
            this.textBoxTelEm1.Size = new System.Drawing.Size(311, 31);
            this.textBoxTelEm1.TabIndex = 3;
            // 
            // labelMoradaEm1
            // 
            this.labelMoradaEm1.AutoSize = true;
            this.labelMoradaEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoradaEm1.Location = new System.Drawing.Point(87, 398);
            this.labelMoradaEm1.Name = "labelMoradaEm1";
            this.labelMoradaEm1.Size = new System.Drawing.Size(105, 31);
            this.labelMoradaEm1.TabIndex = 0;
            this.labelMoradaEm1.Text = "Morada";
            // 
            // labelEmailEm1
            // 
            this.labelEmailEm1.AutoSize = true;
            this.labelEmailEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailEm1.Location = new System.Drawing.Point(111, 239);
            this.labelEmailEm1.Name = "labelEmailEm1";
            this.labelEmailEm1.Size = new System.Drawing.Size(92, 31);
            this.labelEmailEm1.TabIndex = 0;
            this.labelEmailEm1.Text = "Email*";
            // 
            // textBoxNumEm1
            // 
            this.textBoxNumEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumEm1.Location = new System.Drawing.Point(209, 348);
            this.textBoxNumEm1.Name = "textBoxNumEm1";
            this.textBoxNumEm1.Size = new System.Drawing.Size(121, 31);
            this.textBoxNumEm1.TabIndex = 6;
            // 
            // textBoxEmailEm1
            // 
            this.textBoxEmailEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailEm1.Location = new System.Drawing.Point(209, 242);
            this.textBoxEmailEm1.Name = "textBoxEmailEm1";
            this.textBoxEmailEm1.Size = new System.Drawing.Size(453, 31);
            this.textBoxEmailEm1.TabIndex = 4;
            // 
            // labelNumEm1
            // 
            this.labelNumEm1.AutoSize = true;
            this.labelNumEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumEm1.Location = new System.Drawing.Point(82, 345);
            this.labelNumEm1.Name = "labelNumEm1";
            this.labelNumEm1.Size = new System.Drawing.Size(110, 31);
            this.labelNumEm1.TabIndex = 0;
            this.labelNumEm1.Text = "Número";
            // 
            // labelCepEm1
            // 
            this.labelCepEm1.AutoSize = true;
            this.labelCepEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCepEm1.Location = new System.Drawing.Point(9, 292);
            this.labelCepEm1.Name = "labelCepEm1";
            this.labelCepEm1.Size = new System.Drawing.Size(194, 31);
            this.labelCepEm1.TabIndex = 0;
            this.labelCepEm1.Text = "Código Postal*";
            // 
            // textBoxCepEm1
            // 
            this.textBoxCepEm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCepEm1.Location = new System.Drawing.Point(209, 295);
            this.textBoxCepEm1.Name = "textBoxCepEm1";
            this.textBoxCepEm1.Size = new System.Drawing.Size(268, 31);
            this.textBoxCepEm1.TabIndex = 5;
            // 
            // FormEmpre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1128, 700);
            this.Controls.Add(this.labelTitleEm1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpre";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitleEm1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNomeEm1;
        private System.Windows.Forms.Label labelDistritoEm1;
        private System.Windows.Forms.Label labelNissEm1;
        private System.Windows.Forms.Label labelCidadeEm1;
        private System.Windows.Forms.Label labelFunEm1;
        private System.Windows.Forms.Label labelRefEm1;
        private System.Windows.Forms.Label labelTelEm1;
        private System.Windows.Forms.Label labelMoradaEm1;
        private System.Windows.Forms.Label labelEmailEm1;
        private System.Windows.Forms.Label labelNumEm1;
        private System.Windows.Forms.Label labelCepEm1;
        public System.Windows.Forms.Button buttonSendEm1;
        public System.Windows.Forms.TextBox textBoxNomeEm1;
        public System.Windows.Forms.TextBox textBoxDistritoEm1;
        public System.Windows.Forms.TextBox textBoxCidadeEm1;
        public System.Windows.Forms.TextBox textBoxNissEm1;
        public System.Windows.Forms.TextBox textBoxRefEm1;
        public System.Windows.Forms.TextBox textBoxMoradaEm1;
        public System.Windows.Forms.TextBox textBoxTelEm1;
        public System.Windows.Forms.TextBox textBoxNumEm1;
        public System.Windows.Forms.TextBox textBoxEmailEm1;
        public System.Windows.Forms.TextBox textBoxCepEm1;
        public System.Windows.Forms.ComboBox comboBoxFunEm1;
    }
}