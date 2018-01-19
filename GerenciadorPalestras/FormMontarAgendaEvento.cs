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
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        void CarregaDadosIniciais()
        {
            ddlData.DataSource = new EventoDAO().DatasEvento(null);
            ddlDataFiltro.DataSource = new EventoDAO().DatasEvento(null);

            ddlSala.DataSource = new SalaDAO().ListarTodos();
            ddlSalaFiltro.DataSource = new SalaDAO().ListarTodos();
            //List<Palestrante> palestrantes = 

            ddlPalestrante.DataSource = new PalestranteDAO().ListarTodos();
            ddlFiltroPalestrantes.DataSource = new PalestranteDAO().ListarTodos();

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
                CodigoPalestrante = int.Parse(ddlFiltroPalestrantes.SelectedItem.ToString().Split('-')[0]);
            int? CodigoSala = null;
            if (ddlSalaFiltro.SelectedIndex != -1)
                CodigoSala = int.Parse(ddlSalaFiltro.SelectedItem.ToString().Split('-')[0]);

            DateTime? Data = null;
            if (ddlDataFiltro.SelectedIndex != -1)
                Data = DateTime.Parse(ddlDataFiltro.SelectedItem.ToString());
            if(CodigoPalestrante.HasValue || CodigoSala.HasValue || Data.HasValue)
                dataGridView1.DataSource = new AgendaEventoDAO().ListarTodos(CodigoPalestrante, CodigoSala, Data, null);
            
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
            tbxHorario.Text = String.Empty;
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
                new AgendaEventoDAO().SalvarAgendaEvento(int.Parse(ddlPalestrante.SelectedItem.ToString().Split('-')[0].ToString().Trim()), int.Parse(ddlSala.SelectedItem.ToString().Split('-')[0].ToString().Trim()), RetornaDataHorarioEvento(), tbxHorario.Text, this.ID, tbxTema.Text);
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
