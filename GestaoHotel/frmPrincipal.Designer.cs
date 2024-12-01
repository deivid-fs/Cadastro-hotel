namespace GestaoHotel
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuHospedagem = new ToolStripMenuItem();
            testeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuEncerrar = new ToolStripMenuItem();
            mnuCadastro = new ToolStripMenuItem();
            mnuCadastroHotel = new ToolStripMenuItem();
            quartosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHospedagem, mnuCadastro });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(683, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHospedagem
            // 
            mnuHospedagem.DropDownItems.AddRange(new ToolStripItem[] { testeToolStripMenuItem, toolStripMenuItem1, mnuEncerrar });
            mnuHospedagem.Name = "mnuHospedagem";
            mnuHospedagem.Size = new Size(90, 20);
            mnuHospedagem.Text = "Hospedagem";
            // 
            // testeToolStripMenuItem
            // 
            testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            testeToolStripMenuItem.Size = new Size(180, 22);
            testeToolStripMenuItem.Text = "Teste";
            testeToolStripMenuItem.Click += testeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // mnuEncerrar
            // 
            mnuEncerrar.Name = "mnuEncerrar";
            mnuEncerrar.Size = new Size(180, 22);
            mnuEncerrar.Text = "Encerrar";
            mnuEncerrar.Click += mnuEncerrar_Click;
            // 
            // mnuCadastro
            // 
            mnuCadastro.DropDownItems.AddRange(new ToolStripItem[] { mnuCadastroHotel, quartosToolStripMenuItem });
            mnuCadastro.Name = "mnuCadastro";
            mnuCadastro.Size = new Size(66, 20);
            mnuCadastro.Text = "Cadastro";
            // 
            // mnuCadastroHotel
            // 
            mnuCadastroHotel.Name = "mnuCadastroHotel";
            mnuCadastroHotel.Size = new Size(180, 22);
            mnuCadastroHotel.Text = "Hotéis";
            mnuCadastroHotel.Click += mnuCadastroHotel_Click;
            // 
            // quartosToolStripMenuItem
            // 
            quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            quartosToolStripMenuItem.Size = new Size(180, 22);
            quartosToolStripMenuItem.Text = "Quartos";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 410);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Gestão de Hotel";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHospedagem;
        private ToolStripMenuItem testeToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuEncerrar;
        private ToolStripMenuItem mnuCadastro;
        private ToolStripMenuItem mnuCadastroHotel;
        private ToolStripMenuItem quartosToolStripMenuItem;
    }
}
