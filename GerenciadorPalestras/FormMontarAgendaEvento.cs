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
            //panelBanner.BackgroundImage = Image.FromFile("d:\\teste.jpg");
            CarregaDadosIniciais();
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            Evento evento = new EventoDAO().VerificaExistenciaEvento();
            if (evento != null) // Se for edição
            {
                panelBanner.BackgroundImage = new Bitmap(evento.PathFile);
            }
        }

        void CarregaDadosIniciais()
        {
            ddlData.DataSource = new EventoDAO().DatasEvento(null);
            ddlDataFiltro.DataSource = new EventoDAO().DatasEvento(null);

            List<Sala> salas = new SalaDAO().ListarTodos(string.Empty).OrderBy(s => s.Nome).ToList();
            if (salas.Count > 0)
            {
                Dictionary<int, string> dictionarySalas = new Dictionary<int, string>();
                for (int i = 0; i < salas.Count; i++)
                    dictionarySalas.Add(salas[i].Codigo, salas[i].Nome);
                ddlSala.DataSource = new BindingSource(dictionarySalas, null);
                ddlSala.DisplayMember = "Value";
                ddlSala.ValueMember = "Key";
                ddlSala.SelectedIndex = -1;
            }

            List<Sala> salasFiltro = new SalaDAO().ListarTodos(string.Empty).OrderBy(s => s.Nome).ToList();
            if (salasFiltro.Count > 0)
            {
                Dictionary<int, string> dictionarySalasFiltro = new Dictionary<int, string>();
                for (int i = 0; i < salasFiltro.Count; i++)
                    dictionarySalasFiltro.Add(salasFiltro[i].Codigo, salasFiltro[i].Nome);
                ddlSalaFiltro.DataSource = new BindingSource(dictionarySalasFiltro, null);
                ddlSalaFiltro.DisplayMember = "Value";
                ddlSalaFiltro.ValueMember = "Key";
                ddlSalaFiltro.SelectedIndex = -1;
            }
            //ddlSalaFiltro.DataSource = new SalaDAO().ListarTodos();
            List<Palestrante> palestrantes = new PalestranteDAO().ListarTodos();
            if (palestrantes.Count > 0)
            {
                Dictionary<int, string> dictionaryPalestrantes = new Dictionary<int, string>();
                for (int i = 0; i < palestrantes.Count; i++)
                    dictionaryPalestrantes.Add(palestrantes[i].Codigo, palestrantes[i].Nome);
                ddlPalestrante.DataSource = new BindingSource(dictionaryPalestrantes, null);
                ddlPalestrante.DisplayMember = "Value";
                ddlPalestrante.ValueMember = "Key";
                ddlPalestrante.SelectedIndex = -1;
            }

            List<Palestrante> palestrantesFiltro = new PalestranteDAO().ListarTodos();
            if (palestrantesFiltro.Count > 0)
            {
                Dictionary<int, string> dictionaryPalestrantesFiltro = new Dictionary<int, string>();
                for (int i = 0; i < palestrantesFiltro.Count; i++)
                    dictionaryPalestrantesFiltro.Add(palestrantesFiltro[i].Codigo, palestrantesFiltro[i].Nome);
                ddlFiltroPalestrantes.DataSource = new BindingSource(dictionaryPalestrantesFiltro, null);
                ddlFiltroPalestrantes.DisplayMember = "Value";
                ddlFiltroPalestrantes.ValueMember = "Key";
                ddlFiltroPalestrantes.SelectedIndex = -1;
            }
            //.DataSource =
            //ddlFiltroPalestrantes.DataSource = new PalestranteDAO().ListarTodos();

            ddlData.SelectedIndex = -1;
            ddlDataFiltro.SelectedIndex = -1;
            ddlSala.SelectedIndex = -1;
            ddlSalaFiltro.SelectedIndex = -1;
            ddlPalestrante.SelectedIndex = -1;
            ddlFiltroPalestrantes.SelectedIndex = -1;
            tbxHorario.Text = tbxTema.Text = string.Empty;
            MostrarDados();
            dataGridView1.Columns["Sala"].Visible = dataGridView1.Columns["Palestrante"].Visible = dataGridView1.Columns["Codigo"].Visible
                = dataGridView1.Columns["Data"].Visible = dataGridView1.Columns["Hora"].Visible = dataGridView1.Columns["Data"].Visible = dataGridView1.Columns["ArquivoPalestra"].Visible = dataGridView1.Columns["Tema"].Visible = false;
            dataGridView1.Columns["TemaFormatado"].HeaderText = "Tema";
        }

        public void MostrarDados()
        {
            dataGridView1.DataSource = new AgendaEventoDAO().ListarTodos();
        }

        public void MostrarDadosFilstrados()
        {
            int? CodigoPalestrante = null;
            if (ddlFiltroPalestrantes.SelectedIndex != -1)
                CodigoPalestrante =  ((KeyValuePair<int, string>)ddlFiltroPalestrantes.SelectedItem).Key;//int.Parse(ddlFiltroPalestrantes.SelectedItem.ToString().Split('-')[0]);
            int? CodigoSala = null;
            if (ddlSalaFiltro.SelectedIndex != -1)
                CodigoSala = ((KeyValuePair<int, string>)ddlSalaFiltro.SelectedItem).Key; //int.Parse(ddlSalaFiltro.SelectedItem.ToString().Split('-')[0]);

            DateTime? Data = null;
            if (ddlDataFiltro.SelectedIndex != -1)
                Data = DateTime.Parse(ddlDataFiltro.SelectedItem.ToString());
            if (CodigoPalestrante.HasValue || CodigoSala.HasValue || Data.HasValue)
                dataGridView1.DataSource = new AgendaEventoDAO().ListarTodos(CodigoPalestrante, CodigoSala, Data, null);
            else
                dataGridView1.DataSource = new AgendaEventoDAO().ListarTodos();//CodigoPalestrante, CodigoSala, Data, null);

        }

        private void ClearData()
        {
            ID = null;
            ddlData.SelectedIndex = -1;
            ddlDataFiltro.SelectedIndex = -1;
            ddlSala.SelectedIndex = -1;
            ddlSalaFiltro.SelectedIndex = -1;
            ddlPalestrante.SelectedIndex = -1;
            ddlFiltroPalestrantes.SelectedIndex = -1;
            tbxTema.Text = tbxHorario.Text = String.Empty;

        }

        private void ddlSalaFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDadosFilstrados();
        }

        private void ddlDataFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDadosFilstrados();
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

            if (String.IsNullOrEmpty(tbxTema.Text))
            {
                MessageBox.Show("Informe o tema da palestra");
                return;
            }

            try
            {
                new AgendaEventoDAO().SalvarAgendaEvento(((KeyValuePair<int, string>)ddlPalestrante.SelectedItem).Key, ((KeyValuePair<int, string>)ddlSala.SelectedItem).Key, RetornaDataHorarioEvento(), tbxHorario.Text, this.ID, tbxTema.Text);
                MessageBox.Show("Dados salvos com sucesso");
                this.MostrarDados();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar: " + ex.Message);
                return;
            }

        }

        public DateTime RetornaDataHorarioEvento()
        {
            return DateTime.Parse(ddlData.SelectedItem.ToString());
        }

        private void ddlFiltroPalestrante_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDadosFilstrados();
        }

        private void btnLimparFiltroData_Click(object sender, EventArgs e)
        {
            ddlDataFiltro.SelectedIndex = -1;
            MostrarDadosFilstrados();
        }

        private void btnLimparFiltroSala_Click(object sender, EventArgs e)
        {
            ddlSalaFiltro.SelectedIndex = -1;
            MostrarDadosFilstrados();
        }

        private void btnLimparFiltroPalestrante_Click(object sender, EventArgs e)
        {
            ddlFiltroPalestrantes.SelectedIndex = -1;
            MostrarDadosFilstrados();
        }

        private void ddlFiltroPalestrantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDadosFilstrados();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
            ddlData.SelectedItem = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["Data"].Value.ToString());
            ddlSala.SelectedItem = RetornaItem(ddlSala, dataGridView1.Rows[e.RowIndex].Cells["Sala"].Value.ToString());
            ddlPalestrante.SelectedItem = RetornaItem(ddlPalestrante, dataGridView1.Rows[e.RowIndex].Cells["Palestrante"].Value.ToString());
            tbxHorario.Text = dataGridView1.Rows[e.RowIndex].Cells["Hora"].Value.ToString();
            tbxTema.Text = dataGridView1.Rows[e.RowIndex].Cells["Tema"].Value.ToString();
            btnExcluir.Visible = true;
            //tbxNome.Text = dataGridView1.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            //tbxLogin.Text = dataGridView1.Rows[e.RowIndex].Cells["Login"].Value.ToString();
            //tbxSenha.Text = tbxConfirmaSenha.Text = dataGridView1.Rows[e.RowIndex].Cells["Senha"].Value.ToString();
            ////ddlPerfil.SelectedValue = Enum.Parse(typeof(EnumPerfil), (dataGridView1.Rows[e.RowIndex].Cells["Perfil"].Value.ToString()));
            //ddlPerfil.SelectedItem = (EnumPerfil)int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Perfil"].Value.ToString());
        }

        public object RetornaItem(ComboBox ddlControle, string texto)
        {
            for (int i = 0; i < ddlControle.Items.Count; i++)
            {
                if (ddlControle.Items[i].ToString().Contains(texto))
                    return ddlControle.Items[i];
            }
            return null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.ID.HasValue)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir esta palestra?", "Atenção", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    new AgendaEventoDAO().Excluir(this.ID.Value);
                    MessageBox.Show("Registro excluído com sucesso");
                    CarregaDadosIniciais();
                    btnExcluir.Visible = false;
                }
            }
        }
    }
}
