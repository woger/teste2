using Settings;
using Settings.Configuracoes;
using Settings.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Palestrantes
{
    public partial class FormEnvioPalestra : Form
    {
        private string pathDiretorio = string.Empty;

        public FormEnvioPalestra()
        {
            InitializeComponent();
            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
        }

        public FormEnvioPalestra(string path)
        {
            InitializeComponent();
            btnSair.TabStop = false;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            this.pathDiretorio = path;
            //Evento evento = new EventoDAO().VerificaExistenciaEvento(this.pathDiretorio);
            //if (evento != null) // Se for edição
            //{
            //    panelBanner.BackgroundImage = new Bitmap(path + @"\" + evento.Arquivo);
            //}
            if (System.IO.File.Exists(Evento.DIRETORIO_INSTALACAO_BANNER(pathDiretorio)))
            {
                //pictureBox1.Image = Resize(new Bitmap(evento.PathFile), pictureBox1.Width, pictureBox1.Height);
                panelBanner.BackgroundImage = Helper.Resize(new Bitmap(Evento.DIRETORIO_INSTALACAO_BANNER(pathDiretorio)), panelBanner.Width, panelBanner.Height);
            }

            CarregarPalestrante();
        }
        //panelPalestrantes.Controls.Add()


        public void CarregarPalestrante()
        {
            ddlPalestrante.DataSource = null;//.Items.Clear();
            List<Palestrante> palestrantes = new AgendaEventoDAO().ListarPalestrantesEvento(this.pathDiretorio);
            if (palestrantes.Count > 0)
            {
                Dictionary<int, string> dictionary = new Dictionary<int, string>();
                for (int i = 0; i < palestrantes.Count; i++)
                    dictionary.Add(palestrantes[i].Codigo, palestrantes[i].Nome);
                ddlPalestrante.DataSource = new BindingSource(dictionary, null);
                ddlPalestrante.DisplayMember = "Value";
                ddlPalestrante.ValueMember = "Key";
                ddlPalestrante.SelectedIndex = -1;
                ddlPalestrante.SelectedIndexChanged += ddlPalestrante_SelectedIndexChanged;
            }
        }

        public void ddlPalestrante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPalestrante.SelectedItem != null)
            {
                //Carrego os temas para o palestrante selecionado
                int keyPalestrante = ((KeyValuePair<int, string>)ddlPalestrante.SelectedItem).Key;

                List<AgendaEvento> eventosDoProfissional = new AgendaEventoDAO().BuscaAgendaPorPalestrante(keyPalestrante, this.pathDiretorio);
                if (eventosDoProfissional.Count > 0)
                {
                    Dictionary<int, string> dictionaryAgendas = new Dictionary<int, string>();
                    for (int i = 0; i < eventosDoProfissional.Count; i++)
                        dictionaryAgendas.Add(eventosDoProfissional[i].Codigo, eventosDoProfissional[i].TemaFormatado);
                    ddlTema.DataSource = new BindingSource(dictionaryAgendas, null);
                    ddlTema.DisplayMember = "Value";
                    ddlTema.ValueMember = "Key";
                    ddlTema.SelectedIndex = -1;

                    ddlTema.SelectedIndexChanged += ddlTema_SelectedIndexChanged;
                }
            }
        }

        public void ddlTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Vou buscar o arquivo enviado para palestra e coloco no link para ele verificar o arquivo existente
            lblNomeArquivo.Text = string.Empty;
            if (ddlTema.SelectedItem != null)
            {
                int keyAgenda = ((KeyValuePair<int, string>)ddlTema.SelectedItem).Key;
                AgendaEvento agendaSelecionada = new AgendaEventoDAO().BuscarPorCodigo(keyAgenda, this.pathDiretorio);
                if (agendaSelecionada != null)
                {

                    string[] files = Directory.GetFiles(agendaSelecionada.PathPalestra(this.pathDiretorio));
                    if (files.Length > 0)

                    {
                        for (int i = 0; i < files.Length; i++)
                        {
                            string nome = Path.GetFileName(files[i]);
                            if (i == 0)
                                lblNomeArquivo.Text = "* " + nome;
                            else
                                lblNomeArquivo.Text += "\r\n* " + nome;
                        }
                        //lblNomeArquivo.Text = agendaSelecionada.ArquivoPalestra;
                        //lnkFile.Links.Clear();
                        //lnkFile.Links.Add(0, agendaSelecionada.ArquivoPalestra.Length, @"\" + agendaSelecionada.PathPalestra(this.pathDiretorio) + @"\" + agendaSelecionada.ArquivoPalestra + @"\");
                        //lnkFile.LinkClicked += lnkFile_LinkClicked;
                    }
                    else
                        lblNomeArquivo.Text = "Arquivo ainda não enviado";
                }
            }
        }

        //public void lnkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    LinkLabel lnk = new LinkLabel();
        //    lnk = (LinkLabel)sender;
        //    lnk.Links[lnk.Links.IndexOf(e.Link)].Visited = true;

        //    ProcessStartInfo psi = new ProcessStartInfo();
        //    psi.FileName = e.Link.LinkData.ToString().Split('\\')[e.Link.LinkData.ToString().Split('\\').Count() -1].ToString();
        //    psi.WorkingDirectory = Path.GetDirectoryName(e.Link.LinkData.ToString());
        //    psi.Arguments = "p1=hardCodedv1 p2=v2";
        //    Process.Start(psi);
        //}

        private void btnEnviarArquivo_Click(object sender, EventArgs e)
        {
            //Para enviar o arquivo, é necessário selecionar um tema
            if (ddlTema.SelectedIndex == -1)
            {
                MessageBox.Show("Para enviar o arquivo de palestra, você deve informar o tema.");
                return;
            }

            int keyAgenda = ((KeyValuePair<int, string>)ddlTema.SelectedItem).Key;
            AgendaEvento agenda = null;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
                {

                    //string nomeArquivo = dialog.SafeFileName;
                    agenda = new AgendaEventoDAO().BuscarPorCodigo(keyAgenda, this.pathDiretorio);
                    if (agenda != null)
                    {
                        string[] arquivosSelecionados = dialog.FileNames;
                        for (int i = 0; i < arquivosSelecionados.Length; i++)
                        {
                            FileStream arquivoUsuario = File.OpenRead(arquivosSelecionados[i]);
                            FileStream arquivoSaida = File.Create(agenda.PathPalestra(this.pathDiretorio) + @"/ " + Path.GetFileName(arquivosSelecionados[i]));
                            int b;

                            while ((b = arquivoUsuario.ReadByte()) > -1)
                                arquivoSaida.WriteByte((byte)b);

                            arquivoSaida.Flush();
                            arquivoSaida.Close();
                            arquivoUsuario.Close();
                        }

                        ddlTema_SelectedIndexChanged(null, null);
                        MessageBox.Show("Arquivo(s) enviado(s) para o servidor com sucesso. Será realizada uma cópia dos arquivos para a sala da palestra.");
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Ocorreu um erro: O sistema está sem permissão de escrita no diretório informado. Por favor, tente novamente após a autorização");
                return;
            }

            try
            {
                CopiarArquivosParaSala(agenda);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Ocorreu um erro ao copiar o(s) arquivo(s) para a sala da palestra: O IP " + agenda.Sala.IP + " está sem permissão de escrita no diretório informado.");
                return;
            }

        }

        void CopiarArquivosParaSala(AgendaEvento agenda)
        {

            string[] files = Directory.GetFiles(agenda.PathPalestra(this.pathDiretorio));
            if (files.Length > 0)
            {

                for (int i = 0; i < files.Length; i++)
                {

                    FileStream arquivoSala = File.OpenRead(files[i]);
                    new AgendaEventoDAO().CriarDiretorios(@"\\" + agenda.Sala.IP + @"\PALESTRAS", agenda.Palestrante.Codigo, agenda.Sala.Codigo, agenda.Data, agenda.Hora, agenda.TemaFormatado, this.pathDiretorio);
                    FileStream arquivoSaida = File.Create(@"\\" + agenda.PathPalestra(agenda.Sala.IP) + @"/ " + Path.GetFileName(files[i]));
                    int b;

                    while ((b = arquivoSala.ReadByte()) > -1)
                        arquivoSaida.WriteByte((byte)b);

                    arquivoSaida.Flush();
                    arquivoSaida.Close();
                    arquivoSala.Close();
                    //if (i == 0)
                    //    lblNomeArquivo.Text = "* " + nome;
                    //else
                    //    lblNomeArquivo.Text += "\r\n* " + nome;

                }
            }

        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            if (ddlTema.SelectedIndex == -1)
            {
                MessageBox.Show("Para enviar o arquivo de palestra, você deve informar o tema.");
                return;
            }

            int keyAgenda = ((KeyValuePair<int, string>)ddlTema.SelectedItem).Key;
            AgendaEvento agenda = new AgendaEventoDAO().BuscarPorCodigo(keyAgenda, this.pathDiretorio);
            if (agenda != null)
            {
                Process.Start(agenda.PathPalestra(this.pathDiretorio));
                if (MessageBox.Show("Deseja atualizar os arquivos para na sala informada?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes) // if user clicked OK
                {
                    CopiarArquivosParaSala(agenda);
                }

            }






        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLimparFiltroPalestrante_Click(object sender, EventArgs e)
        {
            ddlTema.SelectedIndex = -1;
            CarregarPalestrante();
        }
    }
}
