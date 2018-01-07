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
    public partial class FormMontarAgendaEvento : Form
    {
        int? ID = null;

        public FormMontarAgendaEvento()
        {
            InitializeComponent();

            CarregaDadosIniciais();
        }

        void CarregaDadosIniciais()
        {
            ddlData.DataSource = ddlDataFiltro.DataSource = new EventoDAO().DatasEvento();

            ddlSala.DataSource = ddlSalaFiltro.DataSource = new SalaDAO().ListarTodos();

            ddlPalestrante.DataSource = ddlPalestranteFiltro.DataSource = new PalestranteDAO().ListarTodos();
            ddlData.SelectedIndex = ddlDataFiltro.SelectedIndex = ddlSala.SelectedIndex = ddlSalaFiltro.SelectedIndex = ddlPalestrante.SelectedIndex = ddlPalestranteFiltro.SelectedIndex = -1;
            MostrarDados();
        }

        public void MostrarDados()
        {
            dataGridView1.DataSource = new AgendaEventoDAO().ListarTodos();
        }

        private void ClearData()
        {            
            ID = null;
        }

        private void ddlPalestranteFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddlSalaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddlDataFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ddlData.SelectedIndex == -1)
            {
                MessageBox.Show("Informe uma data");
                return;
            }

            if (ddlSala.SelectedIndex == -1)
            {
                MessageBox.Show("Informe uma Sala");
                return;
            }

            if (ddlPalestrante.SelectedIndex == -1)
            {
                MessageBox.Show("Informe um Palestrante");
                return; 
            }

            DateTime data = DateTime.MinValue;
            if (String.IsNullOrEmpty(tbxHorario.Text) || !DateTime.TryParse(tbxHorario.Text, out data))
            {
                MessageBox.Show("Informe um Horário Válido");
                return;
            }

            try
            {
                new AgendaEventoDAO().SalvarAgendaEvento(int.Parse(ddlPalestrante.SelectedItem.ToString().Split('-')[0].ToString().Trim()), int.Parse(ddlSala.SelectedItem.ToString().Split('-')[0].ToString().Trim()), RetornaDataHorarioEvento(), tbxHorario.Text, this.ID);
                MessageBox.Show("Cadastro salvo com sucesso");
                this.MostrarDados();
                ClearData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar: " + ex.Message);
                return;
            }

        }

        public DateTime RetornaDataHorarioEvento()
        {
            return DateTime.Parse(ddlData.SelectedItem.ToString()).AddHours(int.Parse(tbxHorario.Text.Split(':')[0].Trim())).AddMinutes(int.Parse(tbxHorario.Text.Split(':')[1].Trim()));
        }
    }
}
