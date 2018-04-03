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
    public partial class FormPalestrante : Form
    {
        public static System.Timers.Timer aTimer = new System.Timers.Timer();
        int ID = 0;

        public FormPalestrante()
        {
            InitializeComponent();
            MostrarDados();
            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            Evento evento = new EventoDAO().VerificaExistenciaEvento();
            if (evento != null) // Se for edição
            {
                panelBanner.BackgroundImage = new Bitmap(evento.PathFile);
            }
        }

        public void MostrarDados()
        {
            dataGridView1.DataSource = new PalestranteDAO().ListarTodos();
            dataGridView1.Columns["Codigo"].Visible = false;
            tbxPalestrante.Focus();
            this.btnAtualizar.Visible = this.btnExcluir.Visible = false;
            this.btnIncluir.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                try
                {
                    new PalestranteDAO().Excluir(this.ID);
                    MensagemSucesso("Palestrante excluído com sucesso");
                    //MessageBox.Show("Palestrante excluído com sucesso");
                    ClearData();
                    this.MostrarDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao excluir: " + ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Selecione um palestrante para deletar");
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

        private void ClearData()
        {
            tbxPalestrante.Text = string.Empty;
            ID = 0;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ID != 0 && !String.IsNullOrEmpty(tbxPalestrante.Text))
            {
                new PalestranteDAO().Atualizar(this.ID, tbxPalestrante.Text);
                MensagemSucesso("Palestrante atualizado com sucesso");
                //MessageBox.Show("Palestrante atualizado com sucesso");
                ClearData();
                this.MostrarDados();
            }
            else
            {
                MessageBox.Show("Selecione um palestrante para atualizar");
                return;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxPalestrante.Text))
            {
                new PalestranteDAO().Inserir(tbxPalestrante.Text.Trim());
                MensagemSucesso("Palestrante incluído com sucesso");
                //MessageBox.Show("Palestrante incluído com sucesso");
                this.MostrarDados();
                ClearData();
            }
            else
            {
                MessageBox.Show("Informe o nome do palestrante");
                return;
            }
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbxPalestrante.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxPalestrante.Focus();

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

        private void panelBanner_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
