using Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Diagnostics;
using Settings.DAO;


namespace Palestrantes
{
    public partial class FormConfiguracaoRede : Form
    {
        public string CAMINHO_REDE = @"\\10.10.10.10\SERVER";
        public FormConfiguracaoRede()
        {
            InitializeComponent();
            panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            Dictionary<int, string> dictionaryUsuarios = new Dictionary<int, string>();

            dictionaryUsuarios.Add(2, "MEDIADESK");
            dictionaryUsuarios.Add(3, "HOUSEMIX");
            ddlUsuarios.DataSource = new BindingSource(dictionaryUsuarios, null);
            ddlUsuarios.DisplayMember = "Value";
            ddlUsuarios.ValueMember = "Key";
            ddlUsuarios.SelectedIndex = -1;

        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {


            //return di.GetFiles(pattern);
            if (!String.IsNullOrEmpty(tbxIP.Text))
            {
                //MessageBox.Show("Preencha o IP da máquina servidora");
                //return;
                CAMINHO_REDE = tbxIP.Text;
            }


            if (ddlUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o nome do usuário");
                return;
            }



            if (String.IsNullOrEmpty(tbxSenhaRede.Text))
            {
                MessageBox.Show("Informe a senha");
                return;
            }

            //Pega o diretorio da pasta compartilhada
            //var di = new DirectoryInfo(tbxIP.Text);

            //Procura o arquivo de BD para verificar se a autenticação é válida
            try
            {
                Usuario usuario = new UsuarioDAO().LoginRemoto(((KeyValuePair<int, string>)ddlUsuarios.SelectedItem).Value, tbxSenhaRede.Text, this.CAMINHO_REDE);

                if (usuario != null)
                {
                    if (usuario.Perfil == (int)EnumPerfil.MONITOR)
                    {
                        FormBaixaPalestra formEvento = new FormBaixaPalestra(this.CAMINHO_REDE);

                        //formEvento.MdiParent = this;
                        //formEvento.ControlBox = false;

                        formEvento.StartPosition = FormStartPosition.CenterScreen;
                        formEvento.Show();
                        this.Hide();
                    }
                    //Process.Start(tbxIP.Text + @"\PALESTRAS\");
                    else
                    {
                        FormEnvioPalestra formEvento = new FormEnvioPalestra(this.CAMINHO_REDE);

                        //formEvento.MdiParent = this;
                        //formEvento.ControlBox = false;

                        formEvento.StartPosition = FormStartPosition.CenterScreen;
                        formEvento.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos. Tente novamente");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar acessar o caminho informado:" + ex.Message);
                return;
            }
        }

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    MessageBox.Show(@"Exemplo: \\servidor\nome do compartilhamento.     \\PC-RECEPCAO\GERENCIADOR");

        //}
    }
}
