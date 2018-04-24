using GerenciadorPalestras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public partial class Home2 : Form
    {
        public Home2()
        {
            InitializeComponent();

            btnEvento.TabStop = false;
            btnEvento.FlatStyle = FlatStyle.Flat;
            btnEvento.FlatAppearance.BorderSize = 0;
            btnEvento.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnSalas.TabStop = false;
            btnSalas.FlatStyle = FlatStyle.Flat;
            btnSalas.FlatAppearance.BorderSize = 0;
            btnSalas.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnPalestrante.TabStop = false;
            btnPalestrante.FlatStyle = FlatStyle.Flat;
            btnPalestrante.FlatAppearance.BorderSize = 0;
            btnPalestrante.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnProgramacao.TabStop = false;
            btnProgramacao.FlatStyle = FlatStyle.Flat;
            btnProgramacao.FlatAppearance.BorderSize = 0;
            

            btnAjuda.TabStop = false;
            btnAjuda.FlatStyle = FlatStyle.Flat;
            btnAjuda.FlatAppearance.BorderSize = 0;
            btnAjuda.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnUsuarios.TabStop = false;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            btnHome.TabStop = false;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btnHome.Visible = false;
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.FecharJanelasFilhas();
            FormEvento formEvento = new FormEvento();
            //formEvento.Tag = this;
            formEvento.MdiParent = this;
            formEvento.ControlBox = false;
            formEvento.Width = this.Width;

            formEvento.StartPosition = FormStartPosition.CenterScreen;
            formEvento.Show();
            
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            ////this.Hide();
            this.FecharJanelasFilhas();
            FormSalaEvento formSalaEvento = new FormSalaEvento();
            formSalaEvento.MdiParent = this;
            formSalaEvento.ControlBox = false;
            formSalaEvento.Width = this.Width;

            formSalaEvento.StartPosition = FormStartPosition.CenterScreen;
            formSalaEvento.Show();
            
        }

        private void btnPalestrante_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.FecharJanelasFilhas();
            FormPalestrante formPalestrante = new FormPalestrante();
            formPalestrante.MdiParent = this;
            formPalestrante.ControlBox = false;
            formPalestrante.Width = this.Width;

            formPalestrante.StartPosition = FormStartPosition.CenterScreen;
            formPalestrante.Show();
        }

        private void btnProgramacao_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.FecharJanelasFilhas();


            FormMontarAgendaEvento formMontarAgendaEvento = new FormMontarAgendaEvento();
            formMontarAgendaEvento.MdiParent = this;
            formMontarAgendaEvento.ControlBox = false;
            formMontarAgendaEvento.Width = this.Width;

            formMontarAgendaEvento.StartPosition = FormStartPosition.CenterScreen;
            formMontarAgendaEvento.Show();
        }

        private void FecharJanelasFilhas()
        {
            btnEvento.Visible = btnPalestrante.Visible = btnSalas.Visible = btnProgramacao.Visible = btnAjuda.Visible = btnUsuarios.Visible = false;
            foreach (Form childForm in MdiChildren)
                childForm.Close();
            btnHome.Visible = true;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //this.Hide();
        //    FormAjuda formAjuda = new FormAjuda();

        //    formAjuda.MdiParent = this;
        //    //formMontarAgendaEvento.ControlBox = false;

        //    formAjuda.StartPosition = FormStartPosition.CenterScreen;
        //    formAjuda.Show();
        //    this.FecharJanelasFilhas();
        //}

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnEvento_Click(null, null);
        }

        private void salasDoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnSalas_Click(null, null);
        }

        private void palestrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnPalestrante_Click(null, null);
        }

        private void programaçãoDoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnProgramacao_Click(null, null);
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnAjuda_Click(null, null);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.FecharJanelasFilhas();

            FormAjuda formAjuda = new FormAjuda();

            formAjuda.MdiParent = this;
            formAjuda.ControlBox = false;
            formAjuda.Width = this.Width;

            formAjuda.StartPosition = FormStartPosition.CenterScreen;
            formAjuda.Show();
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnEvento.Visible = btnPalestrante.Visible = btnSalas.Visible = btnProgramacao.Visible = btnAjuda.Visible = btnUsuarios.Visible = true;
            foreach (Form childForm in MdiChildren)
                childForm.Close();
            btnHome.Visible = false;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEvento.Visible = btnPalestrante.Visible = btnSalas.Visible = btnProgramacao.Visible = btnAjuda.Visible = btnUsuarios.Visible = true;
            foreach (Form childForm in MdiChildren)
                childForm.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.FecharJanelasFilhas();

            FormUsuario formUsuario = new FormUsuario();

            formUsuario.MdiParent = this;
            formUsuario.ControlBox = false;
            formUsuario.Width = this.Width;

            formUsuario.StartPosition = FormStartPosition.CenterScreen;
            formUsuario.Show();
        }

        //private void btnAjuda_Paint(object sender, PaintEventArgs e)
        //{
        //    Bitmap bmp = Properties.Resources.Help1;
        //    bmp.MakeTransparent(Color.White);
        //    int x = (btnAjuda.Width - bmp.Width) / 2;
        //    int y = (btnAjuda.Height - bmp.Height) / 2;
        //    e.Graphics.DrawImage(bmp, x, y);
        //}
    }
}
