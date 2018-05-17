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
        public Settings.EnumPerfil PerfilUsuarioLogado;
        private static FormCronometro formCronometro = null;
        public FormHorarios(Settings.EnumPerfil pPerfilUsuarioLogado)
        {
            this.PerfilUsuarioLogado = pPerfilUsuarioLogado;
            InitializeComponent();
            MostrarDados();
            btnHome.TabStop = false;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            if (pPerfilUsuarioLogado == EnumPerfil.MONITOR)
            {
                //Desabilita Cadastro
                lblNome.Visible = lblMinuto.Visible = tbxHorario.Visible = tbxNome.Visible = btnAtualizar.Visible = btnExcluir.Visible = btnIncluir.Visible = false;
            }
            //btnHome.Visible = false;
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
            btn.HeaderText = string.Empty;
            btn.DefaultCellStyle.BackColor = Color.White;
            btn.Text = "Iniciar";
            //dataGridView1.CellPainting += DataGridView1_CellPainting;
            btn.Name = "btnIniciar";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.Columns["Temporizador"].HeaderText = "Minutos";
            dataGridView1.Columns["Contador"].HeaderText = "Tempo";
            dataGridView1.Columns["btnIniciar"].Width = 50;
        }

        private void DataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                Image img = (Image)global::Cronometro.Properties.Resources.play_azul_fundo_transparente;
                e.PaintContent(e.CellBounds);
                e.Graphics.DrawImage(img, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height);
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnIniciar"].Index)
            {

                if (this.ID == Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString())) //Se o usuário clicou para iniciar novamente NA MESMA LINHA
                {
                    if (ContadorAtivo())
                        PausarContador();
                    else
                        RetomarContador();
                }
                else
                {
                    //Caso já tenha selecionado um tempo, tenho que parar ele no datagrid
                    Tempo tempoAnterior = new TempoDAO().BuscarPorCodigo(Convert.ToInt32(dataGridView1.Rows[IndexSelected].Cells[1].Value.ToString()));
                    if (dataGridView1["Contador", IndexSelected] != null)
                        dataGridView1["Contador", IndexSelected].Value = tempoAnterior.Temporizador;

                    this.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Tempo tempo = new TempoDAO().BuscarPorCodigo(this.ID);

                    if (formCronometro == null || !formCronometro.IsAccessible)
                    {
                        formCronometro = new FormCronometro(tempo.Temporizador);

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

                        timer1 = new System.Windows.Forms.Timer();
                        timer1.Tick += new EventHandler(timer1_Tick);
                        timer1.Interval = 1000; // 1 second
                        timer1.Start();
                        dataGridView1.Columns.Remove("btnIniciar");
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        //dataGridView1.Columns.Add(btn);
                        btn.HeaderText = string.Empty;
                        btn.DefaultCellStyle.BackColor = Color.White;
                        btn.Text = "Pausar";
                        //dataGridView1.CellPainting += DataGridView1_CellPainting;
                        btn.Name = "btnIniciar";
                        btn.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Insert(dataGridView1.Columns.Count, btn);

                    }
                    else
                    {
                        formCronometro.MudaContador(tempo.Temporizador);
                        minutos = int.Parse(tempo.Temporizador.Split(':')[0]);
                        segundos = int.Parse(tempo.Temporizador.Split(':')[1]);
                        //if (dataGridView1["Contador", IndexSelected] != null)
                        //    dataGridView1["Contador", IndexSelected].Value = minutos.ToString("00") + ":" + segundos.ToString("00");
                        IndexSelected = e.RowIndex;
                    }
                }


                

            }
        }

        public void PausarContador()
        {
            timer1.Stop();
            dataGridView1.Columns.Remove("btnIniciar");
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dataGridView1.Columns.Add(btn);
            btn.HeaderText = string.Empty;
            btn.DefaultCellStyle.BackColor = Color.White;
            btn.Text = "Iniciar";
            //dataGridView1.CellPainting += DataGridView1_CellPainting;
            btn.Name = "btnIniciar";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0, btn);

            //if (dataGridView1["btnIniciar", IndexSelected] != null)
            //    dataGridView1["btnIniciar", IndexSelected].Value = "Iniciar";
            if (formCronometro != null)
                formCronometro.PausarContador();
        }

        public void RetomarContador()
        {
            timer1.Start();

            dataGridView1.Columns.Remove("btnIniciar");
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dataGridView1.Columns.Add(btn);
            btn.HeaderText = string.Empty;
            btn.DefaultCellStyle.BackColor = Color.White;
            btn.Text = "Pausar";
            //dataGridView1.CellPainting += DataGridView1_CellPainting;
            btn.Name = "btnIniciar";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0, btn);

            //if (dataGridView1["btnIniciar", IndexSelected] != null)
            //    dataGridView1.Rows[IndexSelected].Cells["btnIniciar"].Value = "Pausar";
            if (formCronometro != null)
                formCronometro.RetomarContador();
        }

        public bool ContadorAtivo()
        {
            return timer1.Enabled;
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
            if (dataGridView1["Contador", IndexSelected] != null)
                dataGridView1["Contador", IndexSelected].Value = minutos.ToString("00") + ":" + segundos.ToString("00");


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
                    MessageBox.Show("Ocorreu um erro ao excluir: " + ex.Message);
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
            if (PerfilUsuarioLogado != EnumPerfil.MONITOR)
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
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            Home2 home = new Home2(PerfilUsuarioLogado);

            //formMontarAgendaEvento.MdiParent = this;
            //formMontarAgendaEvento.ControlBox = false;

            home.StartPosition = FormStartPosition.CenterScreen;
            home.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home2 home = new Home2(PerfilUsuarioLogado);
            home.StartPosition = FormStartPosition.CenterScreen;
            home.ShowDialog();
        }
    }
}
