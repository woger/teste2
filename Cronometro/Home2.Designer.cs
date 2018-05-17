namespace Cronometro
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
            this.btnHorarios = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaDoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palestrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palestranteNoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHorarios
            // 
            this.btnHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnHorarios.BackgroundImage = global::Cronometro.Properties.Resources.cadastrar_tempo;
            this.btnHorarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHorarios.Location = new System.Drawing.Point(148, 173);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(157, 157);
            this.btnHorarios.TabIndex = 0;
            this.btnHorarios.UseVisualStyleBackColor = false;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.palestranteNoEventoToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
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
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eventoToolStripMenuItem.Text = "Evento";
            this.eventoToolStripMenuItem.Click += new System.EventHandler(this.eventoToolStripMenuItem_Click);
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
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnUsuarios.BackgroundImage = global::Cronometro.Properties.Resources.btb_home_usuario;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.Location = new System.Drawing.Point(445, 173);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(157, 157);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "DASHBOARD";
            // 
            // Home2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Cronometro.Properties.Resources.bgInterno;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnHorarios);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaDoEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palestrantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palestranteNoEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label label1;
    }
}