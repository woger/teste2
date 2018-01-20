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
            this.tbxLoginRede = new System.Windows.Forms.TextBox();
            this.tbxSenhaRede = new System.Windows.Forms.MaskedTextBox();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o caminho da rede.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe seu login de palestrante ou de Monitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Informe a senha";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(580, 282);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(358, 20);
            this.tbxIP.TabIndex = 3;
            // 
            // tbxLoginRede
            // 
            this.tbxLoginRede.Location = new System.Drawing.Point(580, 323);
            this.tbxLoginRede.Name = "tbxLoginRede";
            this.tbxLoginRede.Size = new System.Drawing.Size(226, 20);
            this.tbxLoginRede.TabIndex = 4;
            // 
            // tbxSenhaRede
            // 
            this.tbxSenhaRede.Location = new System.Drawing.Point(580, 362);
            this.tbxSenhaRede.Name = "tbxSenhaRede";
            this.tbxSenhaRede.PasswordChar = '*';
            this.tbxSenhaRede.Size = new System.Drawing.Size(226, 20);
            this.tbxSenhaRede.TabIndex = 5;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Location = new System.Drawing.Point(363, 417);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(269, 23);
            this.btnTestarConexao.TabIndex = 6;
            this.btnTestarConexao.Text = "Conectar";
            this.btnTestarConexao.UseVisualStyleBackColor = true;
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Configuração Inicial para autenticação";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(269, 299);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Exibir Exemplo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormConfiguracaoRede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 620);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTestarConexao);
            this.Controls.Add(this.tbxSenhaRede);
            this.Controls.Add(this.tbxLoginRede);
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
        private System.Windows.Forms.TextBox tbxLoginRede;
        private System.Windows.Forms.MaskedTextBox tbxSenhaRede;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

