namespace GestaoHotel
{
    partial class frmHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotel));
            btnAbrir = new Button();
            btnLocalizar = new Button();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            txtCNPJ = new TextBox();
            txtCodigo = new TextBox();
            txtNomeHotel = new TextBox();
            txtNomeGerente = new TextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            cboUF = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtInscEst = new TextBox();
            txtCEP = new TextBox();
            txtTelefone = new TextBox();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            txtNumero = new TextBox();
            btnCancel = new Button();
            btnBuscaCodigo = new Button();
            btnBuscaCnpj = new Button();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrir.Image = Properties.Resources.open;
            btnAbrir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrir.Location = new Point(12, 14);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(82, 50);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir";
            btnAbrir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLocalizar.Image = (Image)resources.GetObject("btnLocalizar.Image");
            btnLocalizar.Location = new Point(100, 14);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(94, 50);
            btnLocalizar.TabIndex = 1;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.Location = new Point(200, 14);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(101, 50);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Image = Properties.Resources.save;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(307, 14);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 50);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluir.Image = Properties.Resources.clean;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(478, 15);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 50);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnterior.Image = Properties.Resources.back;
            btnAnterior.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnterior.Location = new Point(604, 14);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(92, 50);
            btnAnterior.TabIndex = 5;
            btnAnterior.Text = "Anterior";
            btnAnterior.TextAlign = ContentAlignment.MiddleRight;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnProximo.Image = (Image)resources.GetObject("btnProximo.Image");
            btnProximo.ImageAlign = ContentAlignment.MiddleRight;
            btnProximo.Location = new Point(702, 14);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(86, 50);
            btnProximo.TabIndex = 6;
            btnProximo.Text = "Próximo";
            btnProximo.TextAlign = ContentAlignment.MiddleLeft;
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(524, 102);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(184, 25);
            txtCNPJ.TabIndex = 7;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCodigo.Location = new Point(177, 102);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 25);
            txtCodigo.TabIndex = 8;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtNomeHotel
            // 
            txtNomeHotel.Location = new Point(177, 135);
            txtNomeHotel.Name = "txtNomeHotel";
            txtNomeHotel.Size = new Size(237, 25);
            txtNomeHotel.TabIndex = 9;
            // 
            // txtNomeGerente
            // 
            txtNomeGerente.Location = new Point(177, 168);
            txtNomeGerente.Name = "txtNomeGerente";
            txtNomeGerente.Size = new Size(237, 25);
            txtNomeGerente.TabIndex = 10;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(177, 201);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(237, 25);
            txtEndereco.TabIndex = 11;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(177, 233);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(237, 25);
            txtBairro.TabIndex = 12;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(177, 266);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(237, 25);
            txtCidade.TabIndex = 13;
            // 
            // cboUF
            // 
            cboUF.FormattingEnabled = true;
            cboUF.Items.AddRange(new object[] { "SP", "MG", "RJ", "DF", "GO", "TO", "AM" });
            cboUF.Location = new Point(420, 266);
            cboUF.Name = "cboUF";
            cboUF.Size = new Size(76, 25);
            cboUF.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 16;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 398);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 17;
            label3.Text = "e-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 365);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 18;
            label1.Text = "Celular:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 335);
            label4.Name = "label4";
            label4.Size = new Size(60, 17);
            label4.TabIndex = 19;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 299);
            label5.Name = "label5";
            label5.Size = new Size(33, 17);
            label5.TabIndex = 20;
            label5.Text = "CEP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 270);
            label6.Name = "label6";
            label6.Size = new Size(80, 17);
            label6.TabIndex = 21;
            label6.Text = "Cidade / UF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 233);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 22;
            label7.Text = "Bairro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 201);
            label8.Name = "label8";
            label8.Size = new Size(105, 17);
            label8.TabIndex = 23;
            label8.Text = "Endereço / Nro.:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(89, 138);
            label9.Name = "label9";
            label9.Size = new Size(82, 17);
            label9.TabIndex = 24;
            label9.Text = "Nome Hotel:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(74, 168);
            label10.Name = "label10";
            label10.Size = new Size(97, 17);
            label10.TabIndex = 25;
            label10.Text = "Nome Gerente:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(478, 102);
            label11.Name = "label11";
            label11.Size = new Size(40, 17);
            label11.TabIndex = 26;
            label11.Text = "CNPJ:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(458, 138);
            label12.Name = "label12";
            label12.Size = new Size(60, 17);
            label12.TabIndex = 27;
            label12.Text = "Insc. Est.:";
            // 
            // txtInscEst
            // 
            txtInscEst.Location = new Point(524, 138);
            txtInscEst.Name = "txtInscEst";
            txtInscEst.Size = new Size(184, 25);
            txtInscEst.TabIndex = 28;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(177, 299);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 25);
            txtCEP.TabIndex = 29;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(177, 332);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(161, 25);
            txtTelefone.TabIndex = 30;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(177, 365);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(161, 25);
            txtCelular.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(177, 398);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 25);
            txtEmail.TabIndex = 32;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(420, 201);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(76, 25);
            txtNumero.TabIndex = 33;
            // 
            // btnCancel
            // 
            btnCancel.BackgroundImageLayout = ImageLayout.None;
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Image = Properties.Resources.cancelar2;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(388, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 50);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "cancelar";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBuscaCodigo
            // 
            btnBuscaCodigo.Location = new Point(283, 102);
            btnBuscaCodigo.Name = "btnBuscaCodigo";
            btnBuscaCodigo.Size = new Size(31, 27);
            btnBuscaCodigo.TabIndex = 35;
            btnBuscaCodigo.Text = "...";
            btnBuscaCodigo.UseVisualStyleBackColor = true;
            btnBuscaCodigo.Click += button1_Click;
            // 
            // btnBuscaCnpj
            // 
            btnBuscaCnpj.Location = new Point(714, 102);
            btnBuscaCnpj.Name = "btnBuscaCnpj";
            btnBuscaCnpj.Size = new Size(30, 25);
            btnBuscaCnpj.TabIndex = 36;
            btnBuscaCnpj.Text = "...";
            btnBuscaCnpj.UseVisualStyleBackColor = true;
            btnBuscaCnpj.Click += btnBuscaCnpj_Click;
            // 
            // frmHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(btnBuscaCnpj);
            Controls.Add(btnBuscaCodigo);
            Controls.Add(btnCancel);
            Controls.Add(txtNumero);
            Controls.Add(txtEmail);
            Controls.Add(txtCelular);
            Controls.Add(txtTelefone);
            Controls.Add(txtCEP);
            Controls.Add(txtInscEst);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboUF);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(txtNomeGerente);
            Controls.Add(txtNomeHotel);
            Controls.Add(txtCodigo);
            Controls.Add(txtCNPJ);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(btnLocalizar);
            Controls.Add(btnAbrir);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmHotel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Hotel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrir;
        private Button btnLocalizar;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnAnterior;
        private Button btnProximo;
        private TextBox txtCNPJ;
        private TextBox txtCodigo;
        private TextBox txtNomeHotel;
        private TextBox txtNomeGerente;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private ComboBox cboUF;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtInscEst;
        private TextBox txtCEP;
        private TextBox txtTelefone;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private TextBox txtNumero;
        private Button btnCancel;
        private Button btnBuscaCodigo;
        private Button btnBuscaCnpj;
    }
}