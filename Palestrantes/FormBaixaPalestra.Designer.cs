namespace Palestrantes
{
    partial class FormBaixaPalestra
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
            this.ddlSala = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBaixarPorSala = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(21, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "BAIXAR ARQUIVOS DE PALESTRAS";
            // 
            // ddlSala
            // 
            this.ddlSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSala.FormattingEnabled = true;
            this.ddlSala.Location = new System.Drawing.Point(191, 278);
            this.ddlSala.Name = "ddlSala";
            this.ddlSala.Size = new System.Drawing.Size(402, 21);
            this.ddlSala.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sala";
            // 
            // btnBaixarPorSala
            // 
            this.btnBaixarPorSala.Location = new System.Drawing.Point(296, 327);
            this.btnBaixarPorSala.Name = "btnBaixarPorSala";
            this.btnBaixarPorSala.Size = new System.Drawing.Size(177, 23);
            this.btnBaixarPorSala.TabIndex = 9;
            this.btnBaixarPorSala.Text = "Sincronizar";
            this.btnBaixarPorSala.UseVisualStyleBackColor = true;
            this.btnBaixarPorSala.Click += new System.EventHandler(this.btnBaixarPorSala_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpar Seleção";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBaixaPalestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Palestrantes.Properties.Resources.bgInterno;
            this.ClientSize = new System.Drawing.Size(1234, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBaixarPorSala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlSala);
            this.Controls.Add(this.label1);
            this.Name = "FormBaixaPalestra";
            this.Text = "FormBaixaPalestra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlSala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBaixarPorSala;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
    }
}