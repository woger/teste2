using Server;
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

namespace GerenciadorPalestras
{
    public partial class FormEvento : Form
    {
        public int ID = 0;
        public static System.Timers.Timer aTimer = new System.Timers.Timer();
        

        public FormEvento()
        {
            InitializeComponent();
            //var form = (Home2)Tag;
            //form.Show();
            //Close();
            panelBanner.Width = this.Width;

            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            //Verifica se já existe evento
            if (System.IO.File.Exists(Evento.DIRETORIO_INSTALACAO_BANNER(string.Empty)))
            {
                //pictureBox1.Image = Resize(new Bitmap(evento.PathFile), pictureBox1.Width, pictureBox1.Height);
                panelBanner.BackgroundImage = Helper.Resize(new Bitmap(Evento.DIRETORIO_INSTALACAO_BANNER(string.Empty)), panelBanner.Width, panelBanner.Height);
            }

            Evento evento = new EventoDAO().VerificaExistenciaEvento();
            if(evento != null) // Se for edição
            {
                tbxNomeEvento.Text = evento.Nome;
                //tbxFileName.Text = evento.PathFile;
               
                this.ID = evento.Codigo;
                foreach (DateTime data in evento.Datas)
                    listBox1.Items.Add(data.ToString("dd/MM/yyyy"));
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

        //private void btnBuscarBanner_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.Filter = "Arquivos Imagem | *.jpeg; *.jpg; *.png";
        //    if(openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        pictureBox1.Image = Resize(Image.FromFile(openFileDialog1.FileName), pictureBox1.Width, pictureBox1.Height);
        //        //pictureBox1.Image = Resize(Image.FromFile(openFileDialog1.FileName), 550, 158);
        //        tbxFileName.Text = openFileDialog1.FileName;
        //    }
        //}

        


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

            //if (String.IsNullOrEmpty(tbxFileName.Text))
            //{
            //    MessageBox.Show("Banner é obrigatório");
            //    return;
            //}

            if(this.RetornaDatasInformadas().Count == 0)
            {
                MessageBox.Show("Informe uma data para o evento");
                return;
            }

            Evento evento = new EventoDAO().VerificaExistenciaEvento();
            if (evento == null)
                evento = new Evento();
            evento.Nome = tbxNomeEvento.Text;
            //evento.Arquivo = openFileDialog1.SafeFileName;
            evento.Datas = RetornaDatasInformadas();
            new EventoDAO().SalvarEvento(evento.Nome,  evento.Datas);
            MensagemSucesso("Dados Salvos com sucesso");
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

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
           
        //}

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    btnBuscarBanner_Click(null, null);
        //}

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
