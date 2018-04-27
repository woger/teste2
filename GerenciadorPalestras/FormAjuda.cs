using Server;
using Settings;
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

namespace GerenciadorPalestras
{
    public partial class FormAjuda : Form
    {
        public FormAjuda()
        {
            
            InitializeComponent();
            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            richTextBox1.Select(0, 10);
            richTextBox1.SelectionColor = Color.White;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);

            richTextBox1.Text = richTextBox1.Text.Replace("@diretorio", Settings.Configuracoes.ArquivoBD.DIRETORIO_INSTALACAO);

            richTextBox1.Text = richTextBox1.Text.Replace("@PALESTRANTE", new Settings.DAO.UsuarioDAO().RetornaSenhaPalestrante());
            richTextBox1.Text = richTextBox1.Text.Replace("@MONITOR", new Settings.DAO.UsuarioDAO().RetornaSenhaMonitor());

            //Evento evento = new EventoDAO().VerificaExistenciaEvento();
            //if (evento != null) // Se for edição
            //{
            //    panelBanner.BackgroundImage = new Bitmap(evento.PathFile);                
            //}
            if (System.IO.File.Exists(Evento.DIRETORIO_INSTALACAO_BANNER(string.Empty)))
            {
                //pictureBox1.Image = Resize(new Bitmap(evento.PathFile), pictureBox1.Width, pictureBox1.Height);
                panelBanner.BackgroundImage = Helper.Resize(new Bitmap(Evento.DIRETORIO_INSTALACAO_BANNER(string.Empty)), panelBanner.Width, panelBanner.Height);
            }
        }

        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            Home2 home = new Home2();

            //formMontarAgendaEvento.MdiParent = this;
            //formMontarAgendaEvento.ControlBox = false;

            home.StartPosition = FormStartPosition.CenterScreen;
            home.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnVoltar_Click(null, null);
        }
    }
}
