﻿using Settings;
using Settings.Configuracoes;
using Settings.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class FormUsuario : Form
    {
        public static System.Timers.Timer aTimer = new System.Timers.Timer();
        int ID = 0;
        public Settings.EnumPerfil PerfilUsuarioLogado;
        public FormUsuario(Settings.EnumPerfil pPerfilUsuarioLogado)
        {
            this.PerfilUsuarioLogado = pPerfilUsuarioLogado;
            InitializeComponent();
            MostrarDados();
            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            dataGridView1.Columns["Senha"].Visible = false;
            dataGridView1.Columns["Perfil"].Visible = false;
            dataGridView1.Columns["Codigo"].Visible = false;
            dataGridView1.Columns["Nome"].Visible = false;
            dataGridView1.Columns["PerfilToString"].Visible = false;
            dataGridView1.Columns["Perfil"].Visible = false;
            //dataGridView1.Columns["PerfilToString"].HeaderText = "Perfil";
            //panelBanner.Width = this.Width;

            //Evento evento = new EventoDAO().VerificaExistenciaEvento();
            //if (evento != null) // Se for edição
            //{
            //    panelBanner.BackgroundImage = new Bitmap(evento.PathFile);
            //}
            //if (System.IO.File.Exists(Evento.DIRETORIO_INSTALACAO_BANNER(string.Empty)))
            //{
            //    //pictureBox1.Image = Resize(new Bitmap(evento.PathFile), pictureBox1.Width, pictureBox1.Height);
            //    panelBanner.BackgroundImage = Helper.Resize(new Bitmap(Evento.DIRETORIO_INSTALACAO_BANNER(string.Empty)), panelBanner.Width, panelBanner.Height);
            //}
            btnHome.TabStop = false;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            //btnHome.Visible = false;
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

        public void MostrarDados()
        {
            dataGridView1.DataSource = new UsuarioDAO().ListarTodos();
        }

        private void ClearData()
        {
            tbxLogin.Text = tbxSenha.Text = tbxConfirmaSenha.Text = string.Empty;
            ID = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxSenha.Text.Trim()))
            {
                MessageBox.Show("A senha é obrigatória");
                return;
            }

            if (String.IsNullOrEmpty(tbxConfirmaSenha.Text.Trim()))
            {
                MessageBox.Show("A confirmação da senha é obrigatória");
                return;
            }

            if (!tbxConfirmaSenha.Text.Trim().Equals(tbxSenha.Text.Trim()))
            {
                MessageBox.Show("As senhas não conferem");
                return;
            }

            Usuario usuario = new Usuario();
            if (this.ID != 0)
                usuario = new UsuarioDAO().BuscarPorID(this.ID);
            usuario.Login = tbxLogin.Text;
            usuario.Senha = tbxSenha.Text;
            //usuario.Perfil = (int)(EnumPerfil)int.Parse(ddlPerfil.SelectedItem.ToString());

            new UsuarioDAO().SalvarUsuario(usuario);
            MensagemSucesso("Dados Salvos com sucesso!");
            ClearData();
            this.MostrarDados();
            btnSalvar.Visible = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
            tbxLogin.Text = dataGridView1.Rows[e.RowIndex].Cells["Login"].Value.ToString();
            tbxSenha.Text = tbxConfirmaSenha.Text = dataGridView1.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
            tbxConfirmaSenha.Text = tbxConfirmaSenha.Text = dataGridView1.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
            //ddlPerfil.SelectedValue = Enum.Parse(typeof(EnumPerfil), (dataGridView1.Rows[e.RowIndex].Cells["Perfil"].Value.ToString()));
            //ddlPerfil.SelectedItem = (EnumPerfil)int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Perfil"].Value.ToString());
            btnSalvar.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home2 home = new Home2(PerfilUsuarioLogado);
            home.StartPosition = FormStartPosition.CenterScreen;
            home.ShowDialog();
        }
    }
}
