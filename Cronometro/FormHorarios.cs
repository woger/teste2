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
    public partial class FormHorarios : Form
    {

        public static System.Timers.Timer aTimer = new System.Timers.Timer();
        int ID = 0;
        int IndexSelected = 0;
        //private System.Windows.Forms.Timer timer1;
        int minutos = 0;
        int segundos = 0;
        public FormHorarios()
        {
            InitializeComponent();
            MostrarDados();
            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            //panelBanner.Width = this.Width;
            //Evento evento = new EventoDAO().VerificaExistenciaEvento();
            //if (System.IO.File.Exists(Evento.DIRETORIO_INSTALACAO_BANNER(string.Empty)))
            //{
            //    //pictureBox1.Image = Resize(new Bitmap(evento.PathFile), pictureBox1.Width, pictureBox1.Height);
            //    panelBanner.BackgroundImage = Helper.Resize(new Bitmap(Evento.DIRETORIO_INSTALACAO_BANNER(string.Empty)), panelBanner.Width, panelBanner.Height);
            //}

            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn = new DataGridViewButtonColumn();
            //dataGridView1.Columns.Add(btn);
            //btn.HeaderText = "Tempo";
            ////btn.Text = "Clique aqui";
            //btn.Name = "time";
            //btn.UseColumnTextForButtonValue = true;
            //dataGridView1.CellFormatting += dataGridView1_CellClick;


            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Iniciar";
            btn.Text = "Clique aqui";
            btn.Name = "btnIniciar";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.Columns["Temporizador"].HeaderText = "Minutos";
            dataGridView1.Columns["Contador"].HeaderText = "Tempo";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnIniciar"].Index)
            {
                this.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                Tempo tempo = new TempoDAO().BuscarPorCodigo(this.ID);

                FormCronometro formCronometro = new FormCronometro(tempo.Temporizador);

                //formCronometro.MdiParent = this;
                formCronometro.ControlBox = true;
                
                //formCronometro.Width = this.Width;
                //btnHome.SetBounds(formUsuario.lblPositionHome.Location.X, formUsuario.lblPositionHome.Location.Y, btnHome.Width, btnHome.Height);
                formCronometro.StartPosition = FormStartPosition.CenterScreen;
                formCronometro.Show();
                IndexSelected = e.RowIndex;
                //dataGridView1.CellFormatting += DataGridView1_CellFormatting;
                minutos = int.Parse(tempo.Temporizador.Split(':')[0]);
                segundos = int.Parse(tempo.Temporizador.Split(':')[1]);
                if (timer1 != null)
                    timer1.Stop();
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();
            }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //this.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            Tempo tempo = new TempoDAO().BuscarPorCodigo(this.ID);
            //if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("time"))
            //{
                minutos = int.Parse(tempo.Temporizador.Split(':')[0]);
                segundos = int.Parse(tempo.Temporizador.Split(':')[1]);
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                timer1.Start();

            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (segundos == 0)
            {
                if (minutos == 0)
                    timer1.Stop();
                else
                {
                    segundos = 59;
                    minutos--;
                }
            }
            else
                segundos--;

            //DataGridViewButtonColumn

            //((DataGridViewDisableButtonCell)dataGridView1["btnIniciar", IndexSelected]).
            if(dataGridView1["Contador", IndexSelected] != null)
                dataGridView1["Contador",IndexSelected].Value = minutos.ToString("00") + ":" + segundos.ToString("00");

            
            //Tempo tempo = new TempoDAO().BuscarPorCodigo(this.ID);

            //lblContador.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
        }

        public void MostrarDados()
        {
            dataGridView1.DataSource = new TempoDAO().ListarTodos();
            dataGridView1.Columns["Codigo"].Visible = false;
            tbxNome.Focus();

            this.btnAtualizar.Visible = this.btnExcluir.Visible = false;
            this.btnIncluir.Visible = true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxNome.Text))
            {
                
                if (String.IsNullOrEmpty(tbxHorario.Text))
                {
                    MessageBox.Show("O Tempo é Obrigatório");
                    return;
                }
                new TempoDAO().Inserir(tbxNome.Text.Trim(), tbxHorario.Text.Trim());
                //MessageBox.Show("Sala incluída com sucesso");
                MensagemSucesso("Tempo incluído com sucesso");
                this.MostrarDados();
                ClearData();
            }
            else
            {
                MessageBox.Show("Informe um nome para o horário");
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
            if (ID != 0 && !String.IsNullOrEmpty(tbxNome.Text))
            {
                new TempoDAO().Atualizar(this.ID, tbxNome.Text, tbxHorario.Text.Trim());
                //MessageBox.Show("Sala atualizada com sucesso");
                MensagemSucesso("Tempo atualizado com sucesso");
                ClearData();
                this.MostrarDados();
            }
            else
            {
                MessageBox.Show("Selecione um tempo para atualizar");
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                try
                {
                    new TempoDAO().Excluir(this.ID);

                    //MessageBox.Show("Sala excluída com sucesso");
                    MensagemSucesso("Horário excluído com sucesso");
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
                MessageBox.Show("Selecione um horário para deletar");
                return;
            }
        }

        private void ClearData()
        {
            tbxNome.Text = tbxHorario.Text = string.Empty;
            ID = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            tbxNome.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxHorario.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbxNome.Focus();

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
