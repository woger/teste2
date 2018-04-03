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
    public partial class FormEvento : Form
    {
        public int ID = 0;
        public FormEvento()
        {
            InitializeComponent();
            panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            //Verifica se já existe evento
            Evento evento = new EventoDAO().VerificaExistenciaEvento();
            if(evento != null) // Se for edição
            {
                tbxNomeEvento.Text = evento.Nome;
                tbxFileName.Text = evento.PathFile;
                if(!String.IsNullOrEmpty(evento.PathFile))
                    pictureBox1.Image = new Bitmap(evento.PathFile);
                this.ID = evento.Codigo;
                foreach (DateTime data in evento.Datas)
                    listBox1.Items.Add(data.ToString("dd/MM/yyyy"));
            }
        }

        private void btnBuscarBanner_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Arquivos Imagem | *.jpeg; *.jpg; *.png";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                tbxFileName.Text = openFileDialog1.FileName;
            }
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.MinValue;

            if (!DateTime.TryParse(tbxDataEvento.Text, out data) )
            {
                MessageBox.Show("A data informada é inválida");
                return;
            }
            else
            {
                if (data.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Informe uma data igual ou superior a data atual.");
                    return;
                }

                if (!listBox1.Items.Contains(tbxDataEvento.Text))
                {
                    listBox1.Items.Add(tbxDataEvento.Text);
                    tbxDataEvento.Text = string.Empty;
                }
                else
                    MessageBox.Show("Data já incluída");
            }
            tbxDataEvento.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxNomeEvento.Text))
            {
                MessageBox.Show("Nome do evento é obrigatório");
                return;
            }

            if (String.IsNullOrEmpty(tbxFileName.Text))
            {
                MessageBox.Show("Banner é obrigatório");
                return;
            }

            if(this.RetornaDatasInformadas().Count == 0)
            {
                MessageBox.Show("Informe uma data para o evento");
                return;
            }

            Evento evento = new EventoDAO().VerificaExistenciaEvento();
            if (evento == null)
                evento = new Evento();
            evento.Nome = tbxNomeEvento.Text;
            evento.Arquivo = openFileDialog1.SafeFileName;
            evento.Datas = RetornaDatasInformadas();
            new EventoDAO().SalvarEvento(evento.Nome, evento.Arquivo, evento.Datas, new Bitmap(tbxFileName.Text));
            MessageBox.Show("Dados Salvos com sucesso");
        }

        protected List<DateTime> RetornaDatasInformadas()
        {
            List<DateTime> datas = new List<DateTime>();
            for(int i=0; i< listBox1.Items.Count; i++)            
                datas.Add(DateTime.Parse(listBox1.Items[i].ToString()));
            return datas;
        }

        private void btnExcluirData_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
