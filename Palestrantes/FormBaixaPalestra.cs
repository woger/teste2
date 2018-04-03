using Settings;
using Settings.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Palestrantes
{
    public partial class FormBaixaPalestra : Form
    {
        private string pathDiretorio = string.Empty;

        public FormBaixaPalestra()
        {
            InitializeComponent();
            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            
        }

        public FormBaixaPalestra(string path)
        {
            InitializeComponent();
            this.pathDiretorio = path;
            Evento evento = new EventoDAO().VerificaExistenciaEvento(this.pathDiretorio);
            if (evento != null) // Se for edição
            {
                panelBanner.BackgroundImage = new Bitmap(path + @"\" + evento.Arquivo);
            }
            //List<AgendaEvento> agendas = new AgendaEventoDAO().ListarTodos(null, null, null, this.pathDiretorio);
            //ddlData.DataSource = agendas.Select(p => p.Data).Distinct().ToList();
            //ddlData.SelectedIndex = -1;
            //ddlData.SelectedIndexChanged += ddlData_SelectedIndexChanged;
            List<Sala> salas = new SalaDAO().ListarTodos(this.pathDiretorio);

            Dictionary<int, string> dictionarySalas = new Dictionary<int, string>();
            for (int i = 0; i < salas.Count; i++)
                dictionarySalas.Add(salas[i].Codigo, salas[i].Nome);
            ddlSala.DataSource = new BindingSource(dictionarySalas, null);
            ddlSala.DisplayMember = "Value";
            ddlSala.ValueMember = "Key";
            ddlSala.SelectedIndex = -1;

        }

        //public void ddlData_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ddlData.SelectedIndex != -1)
        //    {
        //        List<AgendaEvento> agendasSala = new AgendaEventoDAO().ListarTodos(null, null, DateTime.Parse(ddlData.SelectedItem.ToString()), this.pathDiretorio);
        //        List<Sala> salas = agendasSala.Where(a => a.Data == DateTime.Parse(ddlData.SelectedItem.ToString())).Select(p => p.Sala).ToList();

        //        Dictionary<int, string> dictionarySalas = new Dictionary<int, string>();
        //        for (int i = 0; i < salas.Count; i++)
        //            dictionarySalas.Add(salas[i].Codigo, salas[i].Nome);
        //        ddlSala.DataSource = new BindingSource(dictionarySalas, null);
        //        ddlSala.DisplayMember = "Value";
        //        ddlSala.ValueMember = "Key";
        //        ddlSala.SelectedIndex = -1;
        //        ddlSala.SelectedIndexChanged += ddlSala_SelectedIndexChanged;
        //    }
        //}

        //public void ddlSala_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ddlSala.SelectedIndex != -1)
        //    {
        //        int keySala = ((KeyValuePair<int, string>)ddlSala.SelectedItem).Key;
        //        List<AgendaEvento> agendasSala = new AgendaEventoDAO().ListarTodos(null, keySala, DateTime.Parse(ddlData.SelectedItem.ToString()), this.pathDiretorio);

        //        Dictionary<int, string> dictionaryPalestrantes = new Dictionary<int, string>();
        //        for (int i = 0; i < agendasSala.Count; i++)
        //            dictionaryPalestrantes.Add(agendasSala[i].Palestrante.Codigo, agendasSala[i].TemaFormatado);
        //        ddlPalestrante.DataSource = new BindingSource(dictionaryPalestrantes, null);
        //        ddlPalestrante.DisplayMember = "Value";
        //        ddlPalestrante.ValueMember = "Key";
        //        ddlPalestrante.SelectedIndex = -1;
        //    }
        //}

        //private void btnBaixarPorData_Click(object sender, EventArgs e)
        //{
        //    if (ddlData.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Selecione uma data ao menos");
        //        return;
        //    }

        //    //if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    //{
        //    List<AgendaEvento> agendasData = new AgendaEventoDAO().ListarTodos(null, null, DateTime.Parse(ddlData.SelectedItem.ToString()), this.pathDiretorio);

        //    for (int i = 0; i < agendasData.Count; i++)
        //    {
        //        string[] arquivosPalestra = Directory.GetFiles(agendasData[i].PathPalestra(this.pathDiretorio));
        //        for (int j = 0; j < arquivosPalestra.Length; j++)
        //        {
        //            new AgendaEventoDAO().CriarPastasRemoto(this.pathDiretorio, agendasData[i].Data, agendasData[i].Sala.Codigo, agendasData[i].Palestrante.Codigo, agendasData[i].Hora, @"C:\", File.OpenRead(arquivosPalestra[j]), Path.GetFileName(arquivosPalestra[j]));
        //        }
        //    }

        //    MessageBox.Show("Dados Salvos com sucesso");
        //    //}
        //}

        private void btnBaixarPorSala_Click(object sender, EventArgs e)
        {
            if (ddlSala.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma sala ao menos");
                return;
            }

            //if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
                int keySala = ((KeyValuePair<int, string>)ddlSala.SelectedItem).Key;
                List<AgendaEvento> agendasData = new AgendaEventoDAO().BuscaAgendaPorSala(keySala, this.pathDiretorio);

                for (int i = 0; i < agendasData.Count; i++)
                {
                    string[] arquivosPalestra = Directory.GetFiles(agendasData[i].PathPalestra(this.pathDiretorio));
                    for (int j = 0; j < arquivosPalestra.Length; j++)
                        new AgendaEventoDAO().CriarPastasRemoto(this.pathDiretorio, agendasData[i].Data, agendasData[i].Sala.Codigo, agendasData[i].Palestrante.Codigo, agendasData[i].Hora, @"C:\PALESTRA\", File.OpenRead(arquivosPalestra[j]), Path.GetFileName(arquivosPalestra[j]));
                }
                MessageBox.Show(@"Dados Salvos com sucesso em C:\PALESTRA");
            //}
        }

        //private void btnBaixarPorHorario_Click(object sender, EventArgs e)
        //{
        //    if (ddlPalestrante.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Selecione um horário ao menos");
        //        return;
        //    }

        //    if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        int keyPalestrante = ((KeyValuePair<int, string>)ddlPalestrante.SelectedItem).Key;
        //        int keySala = ((KeyValuePair<int, string>)ddlSala.SelectedItem).Key;
        //        List<AgendaEvento> agendasData = new AgendaEventoDAO().ListarTodos(keyPalestrante, keySala, DateTime.Parse(ddlData.SelectedItem.ToString()), this.pathDiretorio);

        //        for (int i = 0; i < agendasData.Count; i++)
        //        {
        //            string[] arquivosPalestra = Directory.GetFiles(agendasData[i].PathPalestra(this.pathDiretorio));
        //            for (int j = 0; j < arquivosPalestra.Length; j++)
        //                new AgendaEventoDAO().CriarPastasRemoto(this.pathDiretorio, agendasData[i].Data, agendasData[i].Sala.Codigo, agendasData[i].Palestrante.Codigo, agendasData[i].Hora, folderBrowserDialog1.SelectedPath, File.OpenRead(arquivosPalestra[j]), Path.GetFileName(arquivosPalestra[j]));
        //        }
        //        MessageBox.Show("Dados Salvos com sucesso no diretório informado!");
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //ddlData.SelectedIndex = -1;
            ddlSala.SelectedIndex = -1;
            //ddlPalestrante.SelectedIndex = -1;
        }
    }
}
