using Settings;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            lblNomeUsuario.Text = "Bem-vindo " + HelperUsuario.UsuarioLogado().Nome;
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cadastro do Evento
            this.FecharJanelasFilhas();

            FormEvento formEvento = new FormEvento();

            formEvento.MdiParent = this;
            formEvento.ControlBox = false;

            formEvento.StartPosition = FormStartPosition.CenterScreen;
            formEvento.Show();
        }

        private void salasDoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cadastro de Salas do Evento
            this.FecharJanelasFilhas();

            FormSalaEvento formSalaEvento = new FormSalaEvento();

            formSalaEvento.MdiParent = this;
            formSalaEvento.ControlBox = false;

            formSalaEvento.StartPosition = FormStartPosition.CenterScreen;
            formSalaEvento.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cadastro de Usuários do Evento
            this.FecharJanelasFilhas();

            FormUsuario formUsuario = new FormUsuario();

            formUsuario.MdiParent = this;
            formUsuario.ControlBox = false;

            formUsuario.StartPosition = FormStartPosition.CenterScreen;
            formUsuario.Show();
        }

        private void bannerDoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cadastrar o Banner do Evento
        }

        private void FecharJanelasFilhas()
        {
            foreach (Form childForm in MdiChildren)
                childForm.Close();
        }

        private void palestrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FecharJanelasFilhas();

            FormPalestrante formPalestrante = new FormPalestrante();

            formPalestrante.MdiParent = this;
            formPalestrante.ControlBox = false;

            formPalestrante.StartPosition = FormStartPosition.CenterScreen;
            formPalestrante.Show();
        }

        private void palestranteNoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FecharJanelasFilhas();

            FormMontarAgendaEvento formMontarAgendaEvento = new FormMontarAgendaEvento();

            formMontarAgendaEvento.MdiParent = this;
            formMontarAgendaEvento.ControlBox = false;

            formMontarAgendaEvento.StartPosition = FormStartPosition.CenterScreen;
            formMontarAgendaEvento.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
