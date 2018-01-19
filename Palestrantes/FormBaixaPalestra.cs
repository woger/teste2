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

        //private string DiretorioAtual =  
        public FormBaixaPalestra()
        {
            InitializeComponent();
        }

        public FormBaixaPalestra(string path)
        {
            InitializeComponent();
            this.pathDiretorio = path;

            ddlData.DataSource = new EventoDAO().DatasEvento(this.pathDiretorio);
            ddlData.SelectedIndexChanged += ddlData_SelectedIndexChanged;
        }

        public void ddlData_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<AgendaEvento> agendasSala = new AgendaEventoDAO().ListarTodos(null, null, DateTime.Parse(ddlData.SelectedItem.ToString()), this.pathDiretorio);
            List<Sala> salas = agendasSala.Where(a => a.Data == DateTime.Parse(ddlData.SelectedItem.ToString())).Select(p=>p.Sala).ToList();

            Dictionary<int, string> dictionarySalas = new Dictionary<int, string>();
            for (int i = 0; i < salas.Count; i++)
                dictionarySalas.Add(salas[i].Codigo, salas[i].Nome);
            ddlSala.DataSource = new BindingSource(dictionarySalas, null);
            ddlSala.DisplayMember = "Value";
            ddlSala.ValueMember = "Key";
            ddlSala.SelectedIndex = -1;
            ddlSala.SelectedIndexChanged += ddlSala_SelectedIndexChanged; ;

        }

        void ddlSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void botaoBaixar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBaixarPorData_Click(object sender, EventArgs e)
        {
            if (ddlData.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma data ao menos");
                return;
            }

            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //folderBrowserDialog1.SelectedPath;
                //FileStream arquivoUsuario = File.OpenRead(arquivosSelecionados[i]);
                List<AgendaEvento> agendasData = new AgendaEventoDAO().ListarTodos(null, null, DateTime.Parse(ddlData.SelectedItem.ToString()), this.pathDiretorio);
                //List<Sala> salas = agendasData.Where(a => a.Data == DateTime.Parse(ddlData.SelectedItem.ToString())).Select(p => p.Sala).ToList();

                for (int i = 0; i < agendasData.Count; i++)
                {
                    string[] arquivosPalestra = Directory.GetFiles(agendasData[i].PathPalestra(this.pathDiretorio));
                    for(int j=0; j<arquivosPalestra.Length; j++)
                    {
                        new AgendaEventoDAO().CriarPastasRemoto(this.pathDiretorio, agendasData[i].Data, agendasData[i].Sala.Codigo, agendasData[i].Palestrante.Codigo, agendasData[i].Hora, folderBrowserDialog1.SelectedPath, File.OpenRead(arquivosPalestra[j]), Path.GetFileName(arquivosPalestra[j]));
                    }
                    
                    //string[] files = Directory.GetFiles(agendasData.Where(p=>p.Sala == salas[i]).FirstOrDefault().PathPalestra(this.pathDiretorio));
                    //if(files.Length > 0)
                    //  FileStream arquivoUsuario = File.OpenRead(sa);
                    //    FileStream arquivoSaida = File.Create(agenda.PathPalestra(this.pathDiretorio) + @"/ " + Path.GetFileName(arquivosSelecionados[i]));
                }

                MessageBox.Show("Dados Salvos com sucesso");
            }
        }

        private void btnBaixarPorSala_Click(object sender, EventArgs e)
        {
            if (ddlSala.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma sala ao menos");
                return;
            }
        }

        private void btnBaixarPorHorario_Click(object sender, EventArgs e)
        {
            if (ddlPalestrante.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um horário ao menos");
                return;
            }
        }
    }
}
