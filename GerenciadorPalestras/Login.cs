using Settings;
using Settings.Configuracoes;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ArquivoBD.CriarArquivosBD();
            tbxLogin.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.DAO.UsuarioDAO usuarioDAO = new Settings.DAO.UsuarioDAO();
            Usuario usuario = usuarioDAO.Login(tbxLogin.Text, tbxSenha.Text);
            if(usuario != null)
            {
                this.Hide();

                HelperUsuario.RegistrarLogin(usuario);

                new Home().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não localizado");
            }
        }
    }
}
