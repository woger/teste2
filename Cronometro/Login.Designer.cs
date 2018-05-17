namespace Cronometro
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlUsuarios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxSenha.Location = new System.Drawing.Point(369, 178);
            this.tbxSenha.MaxLength = 10;
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(150, 20);
            this.tbxSenha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(244, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "GERENCIADOR DE TEMPO";
            // 
            // ddlUsuarios
            // 
            this.ddlUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddlUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUsuarios.FormattingEnabled = true;
            this.ddlUsuarios.Location = new System.Drawing.Point(191, 177);
            this.ddlUsuarios.Name = "ddlUsuarios";
            this.ddlUsuarios.Size = new System.Drawing.Size(152, 21);
            this.ddlUsuarios.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(166)))));
            this.BackgroundImage = global::Cronometro.Properties.Resources.bgLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 451);
            this.Controls.Add(this.ddlUsuarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Formulário de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlUsuarios;
    }
}