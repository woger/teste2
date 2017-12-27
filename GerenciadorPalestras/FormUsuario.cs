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
    public partial class FormUsuario : Form
    {
        int ID = 0;
        public FormUsuario()
        {
            InitializeComponent();
            MostrarDados();
            dataGridView1.Columns["Senha"].Visible = false;
            dataGridView1.Columns["Perfil"].Visible = false;
            dataGridView1.Columns["PerfilToString"].HeaderText = "Perfil";
            ddlPerfil.DataSource = Enum.GetValues(typeof(EnumPerfil));
            ddlPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlPerfil.SelectedItem = null;
        }

        public void MostrarDados()
        {
            dataGridView1.DataSource = new UsuarioDAO().ListarTodos();
        }

        private void ClearData()
        {
            tbxNome.Text = tbxLogin.Text = tbxSenha.Text = tbxConfirmaSenha.Text = string.Empty;
            ddlPerfil.SelectedItem = null;
            ID = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbxNome.Text.Trim()))
            {
                MessageBox.Show("O nome é obrigatório");
                return;
            }

            if (String.IsNullOrEmpty(tbxNome.Text.Trim()))
            {
                MessageBox.Show("O login é obrigatório");
                return;
            }

            if (String.IsNullOrEmpty(tbxNome.Text.Trim()))
            {
                MessageBox.Show("A senha é obrigatória");
                return;
            }

            if (String.IsNullOrEmpty(tbxNome.Text.Trim()))
            {
                MessageBox.Show("A confirmação da senha é obrigatória");
                return;
            }

            if (ddlPerfil.SelectedItem == null)
            {
                MessageBox.Show("Informe o perfil do usuário");
                return;
            }

            Usuario usuario = new Usuario();
            if (this.ID != 0)
                usuario = new UsuarioDAO().BuscarPorID(this.ID);
            usuario.Nome = tbxNome.Text;
            usuario.Login = tbxLogin.Text;
            usuario.Senha = tbxSenha.Text;
            //usuario.Perfil = (int)(EnumPerfil)int.Parse(ddlPerfil.SelectedItem.ToString());
            usuario.Perfil = (int)(EnumPerfil)ddlPerfil.SelectedItem;

            new UsuarioDAO().SalvarUsuario(usuario);
            MessageBox.Show("Dados Salvos com sucesso!");
            ClearData();
            this.MostrarDados();            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
            tbxNome.Text = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            tbxLogin.Text = dataGridView1.Rows[e.RowIndex].Cells["Login"].Value.ToString();
            tbxSenha.Text = tbxConfirmaSenha.Text = dataGridView1.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
            //ddlPerfil.SelectedValue = Enum.Parse(typeof(EnumPerfil), (dataGridView1.Rows[e.RowIndex].Cells["Perfil"].Value.ToString()));
            ddlPerfil.SelectedItem = (EnumPerfil)int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Perfil"].Value.ToString());
        }
    }
}