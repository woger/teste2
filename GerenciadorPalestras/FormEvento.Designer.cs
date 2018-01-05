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
            this.btnBuscarBanner = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.tbxDataEvento = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.btnExcluirData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Evento";
            // 
            // tbxNomeEvento
            // 
            this.tbxNomeEvento.Location = new System.Drawing.Point(192, 54);
            this.tbxNomeEvento.Name = "tbxNomeEvento";
            this.tbxNomeEvento.Size = new System.Drawing.Size(307, 20);
            this.tbxNomeEvento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datas do Evento";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(192, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datas Cadastradas";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBuscarBanner
            // 
            this.btnBuscarBanner.Location = new System.Drawing.Point(895, 12);
            this.btnBuscarBanner.Name = "btnBuscarBanner";
            this.btnBuscarBanner.Size = new System.Drawing.Size(183, 23);
            this.btnBuscarBanner.TabIndex = 5;
            this.btnBuscarBanner.Text = "Importar Banner";
            this.btnBuscarBanner.UseVisualStyleBackColor = true;
            this.btnBuscarBanner.Click += new System.EventHandler(this.btnBuscarBanner_Click);
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(324, 113);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(75, 23);
            this.btnAddData.TabIndex = 3;
            this.btnAddData.Text = "+";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // tbxDataEvento
            // 
            this.tbxDataEvento.Location = new System.Drawing.Point(192, 113);
            this.tbxDataEvento.Mask = "00/00/0000";
            this.tbxDataEvento.Name = "tbxDataEvento";
            this.tbxDataEvento.Size = new System.Drawing.Size(78, 20);
            this.tbxDataEvento.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(628, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 154);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(420, 352);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(280, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbxFileName
            // 
            this.tbxFileName.Enabled = false;
            this.tbxFileName.Location = new System.Drawing.Point(617, 14);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(272, 20);
            this.tbxFileName.TabIndex = 11;
            // 
            // btnExcluirData
            // 
            this.btnExcluirData.Location = new System.Drawing.Point(324, 186);
            this.btnExcluirData.Name = "btnExcluirData";
            this.btnExcluirData.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirData.TabIndex = 12;
            this.btnExcluirData.Text = "Excluir Data";
            this.btnExcluirData.UseVisualStyleBackColor = true;
            this.btnExcluirData.Click += new System.EventHandler(this.btnExcluirData_Click);
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 503);
            this.Controls.Add(this.btnExcluirData);
            this.Controls.Add(this.tbxFileName);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxDataEvento);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.btnBuscarBanner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNomeEvento);
            this.Controls.Add(this.label1);
            this.Name = "FormEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEvento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnBuscarBanner;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.MaskedTextBox tbxDataEvento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbxFileName;
        private System.Windows.Forms.Button btnExcluirData;
    }
}