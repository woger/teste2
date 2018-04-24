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
        public static System.Timers.Timer aTimer = new System.Timers.Timer();
        int ID = 0;
        public FormUsuario()
        {
            InitializeComponent();
            MostrarDados();
            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            dataGridView1.Columns["Senha"].Visible = false;
            dataGridView1.Columns["Perfil"].Visible = false;
            dataGridView1.Columns["Codigo"].Visible = false;
            dataGridView1.Columns["Nome"].Visible = false;
            dataGridView1.Columns["PerfilToString"].Visible = false;
            dataGridView1.Columns["Perfil"].Visible = false;
            //dataGridView1.Columns["PerfilToString"].HeaderText = "Perfil";

            Evento evento = new EventoDAO().VerificaExistenciaEvento();
            if (evento != null) // Se for edição
            {
                panelBanner.BackgroundImage = new Bitmap(evento.PathFile);
            }
        }

        void MensagemSucesso(string texto)
        {
            lblDadosSalvos.Text = texto;
            lblDadosSalvos.Visible = true;

            aTimer.Elapsed += aTimer_Elapsed;
            aTimer.Interval = 2000; //milisecunde
            aTimer.Enabled = true;
        }

        void aTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            aTimer.Enabled = false;
            this.Invoke(new MethodInvoker(() => lblDadosSalvos.Visible = false));
        }

        public void MostrarDados()
        {
            dataGridView1.DataSource = new UsuarioDAO().ListarTodos();
        }

        private void ClearData()
        {
            tbxLogin.Text = tbxSenha.Text = tbxConfirmaSenha.Text = string.Empty;
            ID = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxSenha.Text.Trim()))
            {
                MessageBox.Show("A senha é obrigatória");
                return;
            }

            if (String.IsNullOrEmpty(tbxConfirmaSenha.Text.Trim()))
            {
                MessageBox.Show("A confirmação da senha é obrigatória");
                return;
            }

            if (!tbxConfirmaSenha.Text.Trim().Equals(tbxSenha.Text.Trim()))
            {
                MessageBox.Show("As senhas não conferem");
                return;
            }

            Usuario usuario = new Usuario();
            if (this.ID != 0)
                usuario = new UsuarioDAO().BuscarPorID(this.ID);
            usuario.Login = tbxLogin.Text;
            usuario.Senha = tbxSenha.Text;
            //usuario.Perfil = (int)(EnumPerfil)int.Parse(ddlPerfil.SelectedItem.ToString());

            new UsuarioDAO().SalvarUsuario(usuario);
            MensagemSucesso("Dados Salvos com sucesso!");
            ClearData();
            this.MostrarDados();
            btnSalvar.Visible = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
            tbxLogin.Text = dataGridView1.Rows[e.RowIndex].Cells["Login"].Value.ToString();
            tbxSenha.Text = tbxConfirmaSenha.Text = dataGridView1.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
            tbxConfirmaSenha.Text = tbxConfirmaSenha.Text = dataGridView1.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
            //ddlPerfil.SelectedValue = Enum.Parse(typeof(EnumPerfil), (dataGridView1.Rows[e.RowIndex].Cells["Perfil"].Value.ToString()));
            //ddlPerfil.SelectedItem = (EnumPerfil)int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Perfil"].Value.ToString());
            btnSalvar.Visible = true;
        }
    }
}
