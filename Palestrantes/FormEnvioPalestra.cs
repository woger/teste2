using Settings;
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
            this.pathDiretorio = path;
            Evento evento = new EventoDAO().VerificaExistenciaEvento(this.pathDiretorio);
            if (evento != null) // Se for edição
            {
                panelBanner.BackgroundImage = new Bitmap(path + @"\" + evento.Arquivo);
            }

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
            //panelPalestrantes.Controls.Add()
        }

        public void ddlPalestrante_SelectedIndexChanged(object sender, EventArgs e)
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
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
                {

                    //string nomeArquivo = dialog.SafeFileName;
                    AgendaEvento agenda = new AgendaEventoDAO().BuscarPorCodigo(keyAgenda, this.pathDiretorio);
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



                        //new AgendaEventoDAO().AtualizarArquivoPalestra(agenda.Codigo, dialog.SafeFileName, this.pathDiretorio);
                        ddlTema_SelectedIndexChanged(null, null);
                        MessageBox.Show("Arquivo(s) enviado(s) com sucesso");
                    }

                    //using (var fileStream = File.Create(agenda.PathPalestra(this.pathDiretorio) + @"/ " + nomeArquivo))
                    ////using (var fileStream = new FileStream(agenda.PathPalestra(this.pathDiretorio) + @"/ " + nomeArquivo))
                    //{

                    //    StreamWriter writer = new StreamWriter(fileStream); // do anything you want, e.g. read it
                    //    //using (StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                    //    {
                    //        byte[] bytes = new byte[fileStream.Length];
                    //        fileStream.Read(bytes, 0, (int)fileStream.Length);
                    //        writer.Write(bytes, 0, bytes.Length);

                    //        //fileStream.Write(reader.)
                    //        //reader.InputStream.Seek(0, SeekOrigin.Begin);
                    //        //reader.InputStream.CopyTo(fileStream);
                    //    }
                    //}

                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Ocorreu um erro: O sistema está sem permissão de escrita no diretório informado. Por favor, tente novamente após a autorização");
                return;
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
            }
        }
    }
}
