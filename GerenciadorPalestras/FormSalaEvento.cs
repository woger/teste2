﻿using Settings.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerenciadorPalestras
{
    public partial class FormSalaEvento : Form
    {

        public static System.Timers.Timer aTimer = new System.Timers.Timer();
        int ID = 0;
        public FormSalaEvento()
        {
            InitializeComponent();
            MostrarDados();
            panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            
        }

        public void MostrarDados()
        {
            dataGridView1.DataSource = new SalaDAO().ListarTodos(string.Empty);
            dataGridView1.Columns["Codigo"].Visible = false;
            tbxNomeSala.Focus();

            this.btnAtualizar.Visible = this.btnExcluir.Visible = false;
            this.btnIncluir.Visible = true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxNomeSala.Text))
            {
                new SalaDAO().Inserir(tbxNomeSala.Text.Trim());
                //MessageBox.Show("Sala incluída com sucesso");
                MensagemSucesso("Sala incluída com sucesso");
                this.MostrarDados();
                ClearData();
            }
            else
            {
                MessageBox.Show("Informe o nome da sala");
                return;
            }
        }

        void MensagemSucesso(string texto)
        {
            lblDadosSalvos.Text = texto;
            lblDadosSalvos.Visible = true;

            aTimer.Elapsed += aTimer_Elapsed;
            aTimer.Interval = 2000; //milisecunde
            aTimer.Enabled = true;
        }

        void aTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            aTimer.Enabled = false;
            this.Invoke(new MethodInvoker(() => lblDadosSalvos.Visible = false));
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ID != 0 && !String.IsNullOrEmpty(tbxNomeSala.Text))
            {
                new SalaDAO().Atualizar(this.ID, tbxNomeSala.Text);
                //MessageBox.Show("Sala atualizada com sucesso");
                MensagemSucesso("Sala atualizada com sucesso");
                ClearData();
                this.MostrarDados();
            }
            else
            {
                MessageBox.Show("Selecione uma sala para atualizar");
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                try
                {
                    new SalaDAO().Excluir(this.ID);

                    //MessageBox.Show("Sala excluída com sucesso");
                    MensagemSucesso("Sala excluída com sucesso");
                    ClearData();
                    this.MostrarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao excluir: "+ ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione uma sala para deletar");
                return;
            }
        }

        private void ClearData()
        {
            tbxNomeSala.Text = string.Empty;
            ID = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbxNomeSala.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxNomeSala.Focus();

            if (this.ID == 0)
            {
                this.btnAtualizar.Visible = this.btnExcluir.Visible = false;
                this.btnIncluir.Visible = true;
            }
            else
            {
                this.btnAtualizar.Visible = this.btnExcluir.Visible = true;
                this.btnIncluir.Visible = false;
            }
        }
    }
}
