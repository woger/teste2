namespace GerenciadorPalestras
{
    partial class FormEvento
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNomeEvento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddData = new System.Windows.Forms.Button();
            this.tbxDataEvento = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluirData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.lblDadosSalvos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(377, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Evento";
            // 
            // tbxNomeEvento
            // 
            this.tbxNomeEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxNomeEvento.Location = new System.Drawing.Point(533, 427);
            this.tbxNomeEvento.Name = "tbxNomeEvento";
            this.tbxNomeEvento.Size = new System.Drawing.Size(307, 20);
            this.tbxNomeEvento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(379, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datas do Evento";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(536, 518);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(378, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datas Cadastradas";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddData
            // 
            this.btnAddData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddData.Location = new System.Drawing.Point(678, 469);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(75, 23);
            this.btnAddData.TabIndex = 3;
            this.btnAddData.Text = "+";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // tbxDataEvento
            // 
            this.tbxDataEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxDataEvento.Location = new System.Drawing.Point(533, 472);
            this.tbxDataEvento.Mask = "00/00/0000";
            this.tbxDataEvento.Name = "tbxDataEvento";
            this.tbxDataEvento.Size = new System.Drawing.Size(120, 20);
            this.tbxDataEvento.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(473, 619);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(280, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluirData
            // 
            this.btnExcluirData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirData.Location = new System.Drawing.Point(668, 517);
            this.btnExcluirData.Name = "btnExcluirData";
            this.btnExcluirData.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirData.TabIndex = 12;
            this.btnExcluirData.Text = "Excluir Data";
            this.btnExcluirData.UseVisualStyleBackColor = true;
            this.btnExcluirData.Click += new System.EventHandler(this.btnExcluirData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(25, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "DADOS DO EVENTO";
            // 
            // panelBanner
            // 
            this.panelBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.panelBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(1234, 150);
            this.panelBanner.TabIndex = 16;
            // 
            // lblDadosSalvos
            // 
            this.lblDadosSalvos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDadosSalvos.AutoSize = true;
            this.lblDadosSalvos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.lblDadosSalvos.ForeColor = System.Drawing.Color.White;
            this.lblDadosSalvos.Location = new System.Drawing.Point(591, 645);
            this.lblDadosSalvos.Name = "lblDadosSalvos";
            this.lblDadosSalvos.Size = new System.Drawing.Size(35, 13);
            this.lblDadosSalvos.TabIndex = 29;
            this.lblDadosSalvos.Text = "label4";
            this.lblDadosSalvos.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(0, 720);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Para atualizar o banner, crie um arquivo com o nome \"banner.jpg\" na pasta do Serv" +
    "er.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(379, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 30);
            this.label6.TabIndex = 31;
            this.label6.Text = "Para atualizar o banner, crie um arquivo com o nome \r\n\"banner.jpg\" na pasta do se" +
    "rver";
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = global::Server.Properties.Resources.bgInterno;
            this.ClientSize = new System.Drawing.Size(1234, 733);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDadosSalvos);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluirData);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbxDataEvento);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNomeEvento);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados do Evento";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNomeEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.MaskedTextBox tbxDataEvento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluirData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Label lblDadosSalvos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}