﻿using Settings;
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
        public FormConfiguracaoRede()
        {
            InitializeComponent();

        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {


            //return di.GetFiles(pattern);
            if (String.IsNullOrEmpty(tbxIP.Text))
            {
                MessageBox.Show("Preencha o IP da máquina servidora");
                return;
            }


            if (String.IsNullOrEmpty(tbxLoginRede.Text))
            {
                MessageBox.Show("Preencha o nome do usuário da máquina servidora");
                return;
            }



            if (String.IsNullOrEmpty(tbxSenhaRede.Text))
            {
                MessageBox.Show("Preencha o a senha do usuário da máquina servidora ");
                return;
            }

            //Pega o diretorio da pasta compartilhada
            var di = new DirectoryInfo(tbxIP.Text);

            //Procura o arquivo de BD para verificar se a autenticação é válida
            try
            {
                Usuario usuario = new UsuarioDAO().LoginRemoto(tbxLoginRede.Text, tbxSenhaRede.Text, tbxIP.Text);

                if (usuario != null)
                    Process.Start(tbxIP.Text + @"\PALESTRAS\");
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(@"Exemplo: \\servidor\nome do compartilhamento.     \\PC-RECEPCAO\GERENCIADOR");

        }
    }
}