﻿namespace GerenciadorPalestras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimparFiltroData = new System.Windows.Forms.Button();
            this.btnLimparFiltroSala = new System.Windows.Forms.Button();
            this.btnLimparFiltroPalestrante = new System.Windows.Forms.Button();
            this.ddlFiltroPalestrantes = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxTema = new System.Windows.Forms.TextBox();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.lblDadosSalvos = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblPositionHome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(20, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAMAÇÃO DO EVENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione a Sala";
            // 
            // ddlData
            // 
            this.ddlData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlData.FormattingEnabled = true;
            this.ddlData.Location = new System.Drawing.Point(234, 280);
            this.ddlData.Name = "ddlData";
            this.ddlData.Size = new System.Drawing.Size(269, 21);
            this.ddlData.TabIndex = 1;
            // 
            // ddlSala
            // 
            this.ddlSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSala.FormattingEnabled = true;
            this.ddlSala.Location = new System.Drawing.Point(234, 353);
            this.ddlSala.Name = "ddlSala";
            this.ddlSala.Size = new System.Drawing.Size(269, 21);
            this.ddlSala.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecione o Palestrante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selecione a Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Informe o Horário";
            // 
            // tbxHorario
            // 
            this.tbxHorario.Location = new System.Drawing.Point(234, 416);
            this.tbxHorario.Mask = "00:00";
            this.tbxHorario.Name = "tbxHorario";
            this.tbxHorario.Size = new System.Drawing.Size(269, 20);
            this.tbxHorario.TabIndex = 3;
            this.tbxHorario.ValidatingType = typeof(System.DateTime);
            // 
            // ddlPalestrante
            // 
            this.ddlPalestrante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPalestrante.FormattingEnabled = true;
            this.ddlPalestrante.Location = new System.Drawing.Point(234, 467);
            this.ddlPalestrante.Name = "ddlPalestrante";
            this.ddlPalestrante.Size = new System.Drawing.Size(269, 21);
            this.ddlPalestrante.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(589, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 373);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ddlDataFiltro
            // 
            this.ddlDataFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDataFiltro.FormattingEnabled = true;
            this.ddlDataFiltro.Location = new System.Drawing.Point(594, 280);
            this.ddlDataFiltro.Name = "ddlDataFiltro";
            this.ddlDataFiltro.Size = new System.Drawing.Size(100, 21);
            this.ddlDataFiltro.TabIndex = 7;
            this.ddlDataFiltro.SelectedIndexChanged += new System.EventHandler(this.ddlDataFiltro_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(591, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filtrar por Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(801, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Filtrar por Sala";
            // 
            // ddlSalaFiltro
            // 
            this.ddlSalaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSalaFiltro.FormattingEnabled = true;
            this.ddlSalaFiltro.Location = new System.Drawing.Point(804, 280);
            this.ddlSalaFiltro.Name = "ddlSalaFiltro";
            this.ddlSalaFiltro.Size = new System.Drawing.Size(112, 21);
            this.ddlSalaFiltro.TabIndex = 9;
            this.ddlSalaFiltro.SelectedIndexChanged += new System.EventHandler(this.ddlSalaFiltro_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(300, 560);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1021, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Filtrar por Palestrante";
            // 
            // btnLimparFiltroData
            // 
            this.btnLimparFiltroData.ForeColor = System.Drawing.Color.Black;
            this.btnLimparFiltroData.Location = new System.Drawing.Point(701, 278);
            this.btnLimparFiltroData.Name = "btnLimparFiltroData";
            this.btnLimparFiltroData.Size = new System.Drawing.Size(33, 23);
            this.btnLimparFiltroData.TabIndex = 8;
            this.btnLimparFiltroData.Text = "x";
            this.btnLimparFiltroData.UseVisualStyleBackColor = true;
            this.btnLimparFiltroData.Click += new System.EventHandler(this.btnLimparFiltroData_Click);
            // 
            // btnLimparFiltroSala
            // 
            this.btnLimparFiltroSala.ForeColor = System.Drawing.Color.Black;
            this.btnLimparFiltroSala.Location = new System.Drawing.Point(922, 278);
            this.btnLimparFiltroSala.Name = "btnLimparFiltroSala";
            this.btnLimparFiltroSala.Size = new System.Drawing.Size(33, 23);
            this.btnLimparFiltroSala.TabIndex = 10;
            this.btnLimparFiltroSala.Text = "x";
            this.btnLimparFiltroSala.UseVisualStyleBackColor = true;
            this.btnLimparFiltroSala.Click += new System.EventHandler(this.btnLimparFiltroSala_Click);
            // 
            // btnLimparFiltroPalestrante
            // 
            this.btnLimparFiltroPalestrante.ForeColor = System.Drawing.Color.Black;
            this.btnLimparFiltroPalestrante.Location = new System.Drawing.Point(1157, 278);
            this.btnLimparFiltroPalestrante.Name = "btnLimparFiltroPalestrante";
            this.btnLimparFiltroPalestrante.Size = new System.Drawing.Size(33, 23);
            this.btnLimparFiltroPalestrante.TabIndex = 12;
            this.btnLimparFiltroPalestrante.Text = "x";
            this.btnLimparFiltroPalestrante.UseVisualStyleBackColor = true;
            this.btnLimparFiltroPalestrante.Click += new System.EventHandler(this.btnLimparFiltroPalestrante_Click);
            // 
            // ddlFiltroPalestrantes
            // 
            this.ddlFiltroPalestrantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFiltroPalestrantes.FormattingEnabled = true;
            this.ddlFiltroPalestrantes.Location = new System.Drawing.Point(1024, 280);
            this.ddlFiltroPalestrantes.Name = "ddlFiltroPalestrantes";
            this.ddlFiltroPalestrantes.Size = new System.Drawing.Size(121, 21);
            this.ddlFiltroPalestrantes.TabIndex = 11;
            this.ddlFiltroPalestrantes.SelectedIndexChanged += new System.EventHandler(this.ddlFiltroPalestrantes_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(354, 601);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 23);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(37, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Informe o Tema da Palestra";
            // 
            // tbxTema
            // 
            this.tbxTema.Location = new System.Drawing.Point(234, 520);
            this.tbxTema.MaxLength = 40;
            this.tbxTema.Name = "tbxTema";
            this.tbxTema.Size = new System.Drawing.Size(269, 20);
            this.tbxTema.TabIndex = 5;
            // 
            // panelBanner
            // 
            this.panelBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(96)))));
            this.panelBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(1234, 158);
            this.panelBanner.TabIndex = 27;
            // 
            // lblDadosSalvos
            // 
            this.lblDadosSalvos.AutoSize = true;
            this.lblDadosSalvos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.lblDadosSalvos.ForeColor = System.Drawing.Color.White;
            this.lblDadosSalvos.Location = new System.Drawing.Point(317, 618);
            this.lblDadosSalvos.Name = "lblDadosSalvos";
            this.lblDadosSalvos.Size = new System.Drawing.Size(0, 13);
            this.lblDadosSalvos.TabIndex = 28;
            this.lblDadosSalvos.Visible = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Location = new System.Drawing.Point(247, 601);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(101, 23);
            this.btnAtualizar.TabIndex = 29;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Visible = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblPositionHome
            // 
            this.lblPositionHome.AutoSize = true;
            this.lblPositionHome.Location = new System.Drawing.Point(909, 178);
            this.lblPositionHome.Name = "lblPositionHome";
            this.lblPositionHome.Size = new System.Drawing.Size(35, 13);
            this.lblPositionHome.TabIndex = 32;
            this.lblPositionHome.Text = "label5";
            // 
            // FormMontarAgendaEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Server.Properties.Resources.bgInterno;
            this.ClientSize = new System.Drawing.Size(1234, 741);
            this.Controls.Add(this.lblPositionHome);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblDadosSalvos);
            this.Controls.Add(this.tbxTema);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.ddlFiltroPalestrantes);
            this.Controls.Add(this.btnLimparFiltroPalestrante);
            this.Controls.Add(this.btnLimparFiltroSala);
            this.Controls.Add(this.btnLimparFiltroData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSalvar);
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
            this.Controls.Add(this.panelBanner);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "FormMontarAgendaEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programação do Evento";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimparFiltroData;
        private System.Windows.Forms.Button btnLimparFiltroSala;
        private System.Windows.Forms.Button btnLimparFiltroPalestrante;
        private System.Windows.Forms.ComboBox ddlFiltroPalestrantes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxTema;
        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Label lblDadosSalvos;
        private System.Windows.Forms.Button btnAtualizar;
        public System.Windows.Forms.Label lblPositionHome;
    }
}