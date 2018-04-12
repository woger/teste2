using Server;
using Settings;
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

            Evento evento = new EventoDAO().VerificaExistenciaEvento();
            if (evento != null) // Se for edição
            {
                panelBanner.BackgroundImage = new Bitmap(evento.PathFile);                
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}
