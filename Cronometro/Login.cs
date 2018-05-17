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

namespace Cronometro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            try
            {
                ArquivoBD.CriarArquivosCronometroBD();
            }
            catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao definir as propriedades dos arquivos da aplicação. Contacte o administrador. Erro: " + e.Message);
            }
            tbxLogin.Focus();
            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.DAO.UsuarioDAO usuarioDAO = new Settings.DAO.UsuarioDAO();
            Usuario usuario = usuarioDAO.Login(tbxLogin.Text, tbxSenha.Text);
            if(usuario != null)
            {
                this.Hide();

                HelperUsuario.RegistrarLogin(usuario);

                new Home2((EnumPerfil)Enum.Parse(typeof(EnumPerfil), usuario.Perfil.ToString())).ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não localizado");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
