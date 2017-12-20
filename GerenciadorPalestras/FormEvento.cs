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
        public FormEvento()
        {
            InitializeComponent();
            //Verifica se já existe evento
            Evento evento = new EventoDAO().VerificaExistenciaEvento();
            if(evento != null) // Se for edição
            {
                tbxNomeEvento.Text = evento.Nome;
                tbxFileName.Text = evento.PathBanner;
                pictureBox1.Image = new Bitmap(evento.PathBanner);
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

            if (!listBox1.Items.Contains(tbxDataEvento.Text))
                listBox1.Items.Add(tbxDataEvento.Text);
            else
                MessageBox.Show("Data já incluída");
        }
    }
}
