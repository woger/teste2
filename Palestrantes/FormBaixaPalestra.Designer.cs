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
            this.ddlData = new System.Windows.Forms.ComboBox();
            this.ddlSala = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlPalestrante = new System.Windows.Forms.ComboBox();
            this.btnBaixarPorData = new System.Windows.Forms.Button();
            this.btnBaixarPorSala = new System.Windows.Forms.Button();
            this.btnBaixarPorHorario = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baixar Arquivos de Palestras";
            // 
            // ddlData
            // 
            this.ddlData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlData.FormattingEnabled = true;
            this.ddlData.Location = new System.Drawing.Point(371, 156);
            this.ddlData.Name = "ddlData";
            this.ddlData.Size = new System.Drawing.Size(227, 21);
            this.ddlData.TabIndex = 2;
            // 
            // ddlSala
            // 
            this.ddlSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSala.FormattingEnabled = true;
            this.ddlSala.Location = new System.Drawing.Point(371, 211);
            this.ddlSala.Name = "ddlSala";
            this.ddlSala.Size = new System.Drawing.Size(227, 21);
            this.ddlSala.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horário Palestrante";
            // 
            // ddlPalestrante
            // 
            this.ddlPalestrante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPalestrante.FormattingEnabled = true;
            this.ddlPalestrante.Location = new System.Drawing.Point(371, 272);
            this.ddlPalestrante.Name = "ddlPalestrante";
            this.ddlPalestrante.Size = new System.Drawing.Size(227, 21);
            this.ddlPalestrante.TabIndex = 7;
            // 
            // btnBaixarPorData
            // 
            this.btnBaixarPorData.Location = new System.Drawing.Point(649, 153);
            this.btnBaixarPorData.Name = "btnBaixarPorData";
            this.btnBaixarPorData.Size = new System.Drawing.Size(103, 23);
            this.btnBaixarPorData.TabIndex = 8;
            this.btnBaixarPorData.Text = "Baixar por Data";
            this.btnBaixarPorData.UseVisualStyleBackColor = true;
            this.btnBaixarPorData.Click += new System.EventHandler(this.btnBaixarPorData_Click);
            // 
            // btnBaixarPorSala
            // 
            this.btnBaixarPorSala.Location = new System.Drawing.Point(649, 211);
            this.btnBaixarPorSala.Name = "btnBaixarPorSala";
            this.btnBaixarPorSala.Size = new System.Drawing.Size(103, 23);
            this.btnBaixarPorSala.TabIndex = 9;
            this.btnBaixarPorSala.Text = "Baixar por Sala";
            this.btnBaixarPorSala.UseVisualStyleBackColor = true;
            this.btnBaixarPorSala.Click += new System.EventHandler(this.btnBaixarPorSala_Click);
            // 
            // btnBaixarPorHorario
            // 
            this.btnBaixarPorHorario.Location = new System.Drawing.Point(649, 264);
            this.btnBaixarPorHorario.Name = "btnBaixarPorHorario";
            this.btnBaixarPorHorario.Size = new System.Drawing.Size(103, 23);
            this.btnBaixarPorHorario.TabIndex = 10;
            this.btnBaixarPorHorario.Text = "Baixar por Horário";
            this.btnBaixarPorHorario.UseVisualStyleBackColor = true;
            this.btnBaixarPorHorario.Click += new System.EventHandler(this.btnBaixarPorHorario_Click);
            // 
            // FormBaixaPalestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 660);
            this.Controls.Add(this.btnBaixarPorHorario);
            this.Controls.Add(this.btnBaixarPorSala);
            this.Controls.Add(this.btnBaixarPorData);
            this.Controls.Add(this.ddlPalestrante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlSala);
            this.Controls.Add(this.ddlData);
            this.Controls.Add(this.label1);
            this.Name = "FormBaixaPalestra";
            this.Text = "FormBaixaPalestra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlData;
        private System.Windows.Forms.ComboBox ddlSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlPalestrante;
        private System.Windows.Forms.Button btnBaixarPorData;
        private System.Windows.Forms.Button btnBaixarPorSala;
        private System.Windows.Forms.Button btnBaixarPorHorario;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}