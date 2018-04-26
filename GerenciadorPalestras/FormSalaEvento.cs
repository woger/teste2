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
    public partial class FormSalaEvento : Form
    {

        public static System.Timers.Timer aTimer = new System.Timers.Timer();
        int ID = 0;
        public FormSalaEvento()
        {
            InitializeComponent();
            MostrarDados();
            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            panelBanner.Width = this.Width;
            Evento evento = new EventoDAO().VerificaExistenciaEvento();
            if (evento != null) // Se for edição
            {
                panelBanner.BackgroundImage = new Bitmap(evento.PathFile);
            }
        }

        public void MostrarDados()
        {
            dataGridView1.DataSource = new SalaDAO().ListarTodos(string.Empty);
            dataGridView1.Columns["Codigo"].Visible = false;
            tbxNomeSala.Focus();

            this.btnAtualizar.Visible = this.btnExcluir.Visible = false;
            this.btnIncluir.Visible = true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxNomeSala.Text))
            {
                if(new SalaDAO().BuscarPorNome(tbxNomeSala.Text.ToUpper(), string.Empty) != null)
                {
                    MessageBox.Show("Já existe uma sala com o mesmo nome");
                    return;
                }

                if (String.IsNullOrEmpty(tbxIP.Text))
                {
                    MessageBox.Show("O IP é Obrigatório");
                    return;
                }
                new SalaDAO().Inserir(tbxNomeSala.Text.Trim(), tbxIP.Text.Trim());
                //MessageBox.Show("Sala incluída com sucesso");
                MensagemSucesso("Sala incluída com sucesso");
                this.MostrarDados();
                ClearData();
            }
            else
            {
                MessageBox.Show("Informe o nome da sala");
                return;
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ID != 0 && !String.IsNullOrEmpty(tbxNomeSala.Text))
            {
                new SalaDAO().Atualizar(this.ID, tbxNomeSala.Text, tbxIP.Text.Trim());
                //MessageBox.Show("Sala atualizada com sucesso");
                MensagemSucesso("Sala atualizada com sucesso");
                ClearData();
                this.MostrarDados();
            }
            else
            {
                MessageBox.Show("Selecione uma sala para atualizar");
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                try
                {
                    new SalaDAO().Excluir(this.ID);

                    //MessageBox.Show("Sala excluída com sucesso");
                    MensagemSucesso("Sala excluída com sucesso");
                    ClearData();
                    this.MostrarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao excluir: "+ ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione uma sala para deletar");
                return;
            }
        }

        private void ClearData()
        {
            tbxNomeSala.Text = tbxIP.Text = string.Empty;
            ID = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbxNomeSala.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxIP.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxNomeSala.Focus();

            if (this.ID == 0)
            {
                this.btnAtualizar.Visible = this.btnExcluir.Visible = false;
                this.btnIncluir.Visible = true;
            }
            else
            {
                this.btnAtualizar.Visible = this.btnExcluir.Visible = true;
                this.btnIncluir.Visible = false;
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
    }
}
