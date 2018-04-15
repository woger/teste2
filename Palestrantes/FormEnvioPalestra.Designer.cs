namespace Palestrantes
{
    partial class FormEnvioPalestra
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
            this.ddlPalestrante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlTema = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviarArquivo = new System.Windows.Forms.Button();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(25, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENVIO DE PALESTRAS";
            // 
            // ddlPalestrante
            // 
            this.ddlPalestrante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPalestrante.FormattingEnabled = true;
            this.ddlPalestrante.Location = new System.Drawing.Point(480, 288);
            this.ddlPalestrante.Name = "ddlPalestrante";
            this.ddlPalestrante.Size = new System.Drawing.Size(362, 21);
            this.ddlPalestrante.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(147)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(277, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione o Palestrante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(147)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(277, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecione o Tema";
            // 
            // ddlTema
            // 
            this.ddlTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTema.FormattingEnabled = true;
            this.ddlTema.Location = new System.Drawing.Point(480, 340);
            this.ddlTema.Name = "ddlTema";
            this.ddlTema.Size = new System.Drawing.Size(362, 21);
            this.ddlTema.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(147)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(280, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Arquivo(s) da apresentação";
            // 
            // btnEnviarArquivo
            // 
            this.btnEnviarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarArquivo.Location = new System.Drawing.Point(480, 389);
            this.btnEnviarArquivo.Name = "btnEnviarArquivo";
            this.btnEnviarArquivo.Size = new System.Drawing.Size(161, 38);
            this.btnEnviarArquivo.TabIndex = 8;
            this.btnEnviarArquivo.Text = "Enviar arquivos";
            this.btnEnviarArquivo.UseVisualStyleBackColor = true;
            this.btnEnviarArquivo.Click += new System.EventHandler(this.btnEnviarArquivo_Click);
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(147)))));
            this.lblNomeArquivo.ForeColor = System.Drawing.Color.White;
            this.lblNomeArquivo.Location = new System.Drawing.Point(477, 484);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(86, 13);
            this.lblNomeArquivo.TabIndex = 9;
            this.lblNomeArquivo.Text = "Nenhum Arquivo";
            // 
            // btnExplorar
            // 
            this.btnExplorar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExplorar.Location = new System.Drawing.Point(681, 389);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(161, 38);
            this.btnExplorar.TabIndex = 11;
            this.btnExplorar.Text = "Explorar arquivos";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.panelBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(1234, 158);
            this.panelBanner.TabIndex = 31;
            // 
            // FormEnvioPalestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client.Properties.Resources.bgInterno;
            this.ClientSize = new System.Drawing.Size(1234, 701);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.btnExplorar);
            this.Controls.Add(this.lblNomeArquivo);
            this.Controls.Add(this.btnEnviarArquivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlTema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlPalestrante);
            this.Controls.Add(this.label1);
            this.Name = "FormEnvioPalestra";
            this.Text = "Enviar Palestra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlPalestrante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlTema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviarArquivo;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.Panel panelBanner;
    }
}