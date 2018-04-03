namespace Palestrantes
{
    partial class FormConfiguracaoRede
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.MaskedTextBox();
            this.tbxSenhaRede = new System.Windows.Forms.MaskedTextBox();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlUsuarios = new System.Windows.Forms.ComboBox();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o caminho da rede.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe seu login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Informe a senha";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(253, 286);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(358, 20);
            this.tbxIP.TabIndex = 1;
            // 
            // tbxSenhaRede
            // 
            this.tbxSenhaRede.Location = new System.Drawing.Point(253, 378);
            this.tbxSenhaRede.Name = "tbxSenhaRede";
            this.tbxSenhaRede.PasswordChar = '*';
            this.tbxSenhaRede.Size = new System.Drawing.Size(226, 20);
            this.tbxSenhaRede.TabIndex = 3;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Location = new System.Drawing.Point(39, 454);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(269, 23);
            this.btnTestarConexao.TabIndex = 4;
            this.btnTestarConexao.Text = "Conectar";
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(593, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "CONFIGURAÇÃO INICIAL PARA AUTENTICAÇÃO";
            // 
            // ddlUsuarios
            // 
            this.ddlUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUsuarios.FormattingEnabled = true;
            this.ddlUsuarios.Location = new System.Drawing.Point(253, 330);
            this.ddlUsuarios.Name = "ddlUsuarios";
            this.ddlUsuarios.Size = new System.Drawing.Size(226, 21);
            this.ddlUsuarios.TabIndex = 2;
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.panelBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(1234, 158);
            this.panelBanner.TabIndex = 30;
            // 
            // FormConfiguracaoRede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.bgInterno;
            this.ClientSize = new System.Drawing.Size(1234, 701);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.ddlUsuarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTestarConexao);
            this.Controls.Add(this.tbxSenhaRede);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConfiguracaoRede";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbxIP;
        private System.Windows.Forms.MaskedTextBox tbxSenhaRede;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlUsuarios;
        private System.Windows.Forms.Panel panelBanner;
    }
}

