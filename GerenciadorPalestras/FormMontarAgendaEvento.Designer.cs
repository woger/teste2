namespace GerenciadorPalestras
{
    partial class FormMontarAgendaEvento
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
            this.ddlData = new System.Windows.Forms.ComboBox();
            this.ddlSala = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxHorario = new System.Windows.Forms.MaskedTextBox();
            this.ddlPalestrante = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ddlDataFiltro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlSalaFiltro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlPalestranteFiltro = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(814, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monte a Agenda do Evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione a Sala";
            // 
            // ddlData
            // 
            this.ddlData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlData.FormattingEnabled = true;
            this.ddlData.Location = new System.Drawing.Point(242, 101);
            this.ddlData.Name = "ddlData";
            this.ddlData.Size = new System.Drawing.Size(269, 21);
            this.ddlData.TabIndex = 2;
            // 
            // ddlSala
            // 
            this.ddlSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSala.FormattingEnabled = true;
            this.ddlSala.Location = new System.Drawing.Point(242, 168);
            this.ddlSala.Name = "ddlSala";
            this.ddlSala.Size = new System.Drawing.Size(269, 21);
            this.ddlSala.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecione o Palestrante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selecione a Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Informe o Horário";
            // 
            // tbxHorario
            // 
            this.tbxHorario.Location = new System.Drawing.Point(242, 236);
            this.tbxHorario.Mask = "00:00";
            this.tbxHorario.Name = "tbxHorario";
            this.tbxHorario.Size = new System.Drawing.Size(269, 20);
            this.tbxHorario.TabIndex = 7;
            this.tbxHorario.ValidatingType = typeof(System.DateTime);
            // 
            // ddlPalestrante
            // 
            this.ddlPalestrante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPalestrante.FormattingEnabled = true;
            this.ddlPalestrante.Location = new System.Drawing.Point(242, 290);
            this.ddlPalestrante.Name = "ddlPalestrante";
            this.ddlPalestrante.Size = new System.Drawing.Size(269, 21);
            this.ddlPalestrante.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(804, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(888, 582);
            this.dataGridView1.TabIndex = 9;
            // 
            // ddlDataFiltro
            // 
            this.ddlDataFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDataFiltro.FormattingEnabled = true;
            this.ddlDataFiltro.Location = new System.Drawing.Point(831, 106);
            this.ddlDataFiltro.Name = "ddlDataFiltro";
            this.ddlDataFiltro.Size = new System.Drawing.Size(197, 21);
            this.ddlDataFiltro.TabIndex = 10;
            this.ddlDataFiltro.SelectedIndexChanged += new System.EventHandler(this.ddlDataFiltro_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(861, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filtrar por Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1167, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Filtrar por Sala";
            // 
            // ddlSalaFiltro
            // 
            this.ddlSalaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSalaFiltro.FormattingEnabled = true;
            this.ddlSalaFiltro.Location = new System.Drawing.Point(1137, 106);
            this.ddlSalaFiltro.Name = "ddlSalaFiltro";
            this.ddlSalaFiltro.Size = new System.Drawing.Size(197, 21);
            this.ddlSalaFiltro.TabIndex = 12;
            this.ddlSalaFiltro.SelectedIndexChanged += new System.EventHandler(this.ddlSalaFiltro_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1477, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Filtrar por Palestrante";
            // 
            // ddlPalestranteFiltro
            // 
            this.ddlPalestranteFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPalestranteFiltro.FormattingEnabled = true;
            this.ddlPalestranteFiltro.Location = new System.Drawing.Point(1447, 106);
            this.ddlPalestranteFiltro.Name = "ddlPalestranteFiltro";
            this.ddlPalestranteFiltro.Size = new System.Drawing.Size(197, 21);
            this.ddlPalestranteFiltro.TabIndex = 14;
            this.ddlPalestranteFiltro.SelectedIndexChanged += new System.EventHandler(this.ddlPalestranteFiltro_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(225, 382);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(177, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormMontarAgendaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 769);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ddlPalestranteFiltro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ddlSalaFiltro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlDataFiltro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ddlPalestrante);
            this.Controls.Add(this.tbxHorario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlSala);
            this.Controls.Add(this.ddlData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMontarAgendaEvento";
            this.Text = "FormMontarAgendaEvento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlData;
        private System.Windows.Forms.ComboBox ddlSala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbxHorario;
        private System.Windows.Forms.ComboBox ddlPalestrante;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ddlDataFiltro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlSalaFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlPalestranteFiltro;
        private System.Windows.Forms.Button btnSalvar;
    }
}