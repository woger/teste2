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
            // ddlData
            // 
            this.ddlData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlData.FormattingEnabled = true;
            this.ddlData.Location = new System.Drawing.Point(190, 220);
            this.ddlData.Name = "ddlData";
            this.ddlData.Size = new System.Drawing.Size(402, 21);
            this.ddlData.TabIndex = 2;
            // 
            // ddlSala
            // 
            this.ddlSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSala.FormattingEnabled = true;
            this.ddlSala.Location = new System.Drawing.Point(190, 278);
            this.ddlSala.Name = "ddlSala";
            this.ddlSala.Size = new System.Drawing.Size(402, 21);
            this.ddlSala.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horário Palestrante";
            // 
            // ddlPalestrante
            // 
            this.ddlPalestrante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPalestrante.FormattingEnabled = true;
            this.ddlPalestrante.Location = new System.Drawing.Point(190, 331);
            this.ddlPalestrante.Name = "ddlPalestrante";
            this.ddlPalestrante.Size = new System.Drawing.Size(402, 21);
            this.ddlPalestrante.TabIndex = 7;
            // 
            // btnBaixarPorData
            // 
            this.btnBaixarPorData.Location = new System.Drawing.Point(631, 219);
            this.btnBaixarPorData.Name = "btnBaixarPorData";
            this.btnBaixarPorData.Size = new System.Drawing.Size(103, 23);
            this.btnBaixarPorData.TabIndex = 8;
            this.btnBaixarPorData.Text = "Baixar por Data";
            this.btnBaixarPorData.UseVisualStyleBackColor = true;
            this.btnBaixarPorData.Click += new System.EventHandler(this.btnBaixarPorData_Click);
            // 
            // btnBaixarPorSala
            // 
            this.btnBaixarPorSala.Location = new System.Drawing.Point(631, 277);
            this.btnBaixarPorSala.Name = "btnBaixarPorSala";
            this.btnBaixarPorSala.Size = new System.Drawing.Size(103, 23);
            this.btnBaixarPorSala.TabIndex = 9;
            this.btnBaixarPorSala.Text = "Baixar por Sala";
            this.btnBaixarPorSala.UseVisualStyleBackColor = true;
            this.btnBaixarPorSala.Click += new System.EventHandler(this.btnBaixarPorSala_Click);
            // 
            // btnBaixarPorHorario
            // 
            this.btnBaixarPorHorario.Location = new System.Drawing.Point(631, 330);
            this.btnBaixarPorHorario.Name = "btnBaixarPorHorario";
            this.btnBaixarPorHorario.Size = new System.Drawing.Size(103, 23);
            this.btnBaixarPorHorario.TabIndex = 10;
            this.btnBaixarPorHorario.Text = "Baixar por Horário";
            this.btnBaixarPorHorario.UseVisualStyleBackColor = true;
            this.btnBaixarPorHorario.Click += new System.EventHandler(this.btnBaixarPorHorario_Click);
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
        private System.Windows.Forms.Button button1;
    }
}