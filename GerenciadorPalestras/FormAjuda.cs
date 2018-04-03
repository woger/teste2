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
            panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            richTextBox1.Select(0, 10);
            richTextBox1.SelectionColor = Color.White;
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);

            richTextBox1.Text = richTextBox1.Text.Replace("@diretorio", Settings.Configuracoes.ArquivoBD.DIRETORIO_INSTALACAO);

            richTextBox1.Text = richTextBox1.Text.Replace("@PALESTRANTE", new Settings.DAO.UsuarioDAO().RetornaSenhaPalestrante());
            richTextBox1.Text = richTextBox1.Text.Replace("@MONITOR", new Settings.DAO.UsuarioDAO().RetornaSenhaMonitor());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
