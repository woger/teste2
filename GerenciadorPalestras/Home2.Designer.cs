namespace Server
{
    partial class Home2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home2));
            this.btnEvento = new System.Windows.Forms.Button();
            this.btnSalas = new System.Windows.Forms.Button();
            this.btnPalestrante = new System.Windows.Forms.Button();
            this.btnProgramacao = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaDoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palestrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palestranteNoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEvento
            // 
            this.btnEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnEvento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEvento.BackgroundImage")));
            this.btnEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEvento.Location = new System.Drawing.Point(207, 351);
            this.btnEvento.Name = "btnEvento";
            this.btnEvento.Size = new System.Drawing.Size(157, 157);
            this.btnEvento.TabIndex = 0;
            this.btnEvento.UseVisualStyleBackColor = false;
            this.btnEvento.Click += new System.EventHandler(this.btnEvento_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnSalas.BackgroundImage = global::Server.Properties.Resources.btn_salas;
            this.btnSalas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalas.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalas.Location = new System.Drawing.Point(423, 351);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(157, 157);
            this.btnSalas.TabIndex = 1;
            this.btnSalas.UseVisualStyleBackColor = false;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // btnPalestrante
            // 
            this.btnPalestrante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnPalestrante.BackgroundImage = global::Server.Properties.Resources.btn_palestrante;
            this.btnPalestrante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPalestrante.Location = new System.Drawing.Point(636, 351);
            this.btnPalestrante.Name = "btnPalestrante";
            this.btnPalestrante.Size = new System.Drawing.Size(157, 157);
            this.btnPalestrante.TabIndex = 2;
            this.btnPalestrante.UseVisualStyleBackColor = false;
            this.btnPalestrante.Click += new System.EventHandler(this.btnPalestrante_Click);
            // 
            // btnProgramacao
            // 
            this.btnProgramacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnProgramacao.BackgroundImage = global::Server.Properties.Resources.btn_programacao;
            this.btnProgramacao.FlatAppearance.BorderSize = 0;
            this.btnProgramacao.Location = new System.Drawing.Point(844, 351);
            this.btnProgramacao.Name = "btnProgramacao";
            this.btnProgramacao.Size = new System.Drawing.Size(157, 157);
            this.btnProgramacao.TabIndex = 3;
            this.btnProgramacao.UseVisualStyleBackColor = false;
            this.btnProgramacao.Click += new System.EventHandler(this.btnProgramacao_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnAjuda.BackgroundImage = global::Server.Properties.Resources.btn_ajuda;
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjuda.Location = new System.Drawing.Point(1139, 58);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(76, 76);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.palestranteNoEventoToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventoToolStripMenuItem,
            this.salaDoEventoToolStripMenuItem,
            this.palestrantesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // salaDoEventoToolStripMenuItem
            // 
            this.salaDoEventoToolStripMenuItem.Name = "salaDoEventoToolStripMenuItem";
            this.salaDoEventoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.salaDoEventoToolStripMenuItem.Text = "Salas do Evento";
            this.salaDoEventoToolStripMenuItem.Click += new System.EventHandler(this.salasDoEventoToolStripMenuItem_Click);
            // 
            // palestrantesToolStripMenuItem
            // 
            this.palestrantesToolStripMenuItem.Name = "palestrantesToolStripMenuItem";
            this.palestrantesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.palestrantesToolStripMenuItem.Text = "Palestrantes";
            this.palestrantesToolStripMenuItem.Click += new System.EventHandler(this.palestrantesToolStripMenuItem_Click);
            // 
            // palestranteNoEventoToolStripMenuItem
            // 
            this.palestranteNoEventoToolStripMenuItem.Name = "palestranteNoEventoToolStripMenuItem";
            this.palestranteNoEventoToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.palestranteNoEventoToolStripMenuItem.Text = "Palestrante no Evento";
            this.palestranteNoEventoToolStripMenuItem.Click += new System.EventHandler(this.programaçãoDoEventoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eventoToolStripMenuItem.Text = "Evento";
            this.eventoToolStripMenuItem.Click += new System.EventHandler(this.eventoToolStripMenuItem_Click);
            // 
            // Home2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Server.Properties.Resources.bg_home;
            this.ClientSize = new System.Drawing.Size(1254, 721);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnPalestrante);
            this.Controls.Add(this.btnSalas);
            this.Controls.Add(this.btnEvento);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnProgramacao);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvento;
        private System.Windows.Forms.Button btnSalas;
        private System.Windows.Forms.Button btnPalestrante;
        private System.Windows.Forms.Button btnProgramacao;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaDoEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palestrantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palestranteNoEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
    }
}