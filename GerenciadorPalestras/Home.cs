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
    }
}
