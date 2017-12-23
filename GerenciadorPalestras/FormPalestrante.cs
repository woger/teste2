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
    public partial class FormPalestrante : Form
    {
        int ID = 0;

        public FormPalestrante()
        {
            InitializeComponent();
            MostrarDados();
        }

        public void MostrarDados()
        {
            dataGridView1.DataSource = new PalestranteDAO().ListarTodos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                new PalestranteDAO().Excluir(this.ID);
                MessageBox.Show("Palestrante excluído com sucesso");
                ClearData();
                this.MostrarDados();
            }
            else
            {
                MessageBox.Show("Selecione um palestrante para deletar");
                return;
            }
        }

        private void ClearData()
        {
            tbxPalestrante.Text = string.Empty;
            ID = 0;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ID != 0 && !String.IsNullOrEmpty(tbxPalestrante.Text))
            {
                new PalestranteDAO().Atualizar(this.ID, tbxPalestrante.Text);
                MessageBox.Show("Palestrante atualizado com sucesso");
                ClearData();
                this.MostrarDados();
            }
            else
            {
                MessageBox.Show("Selecione um palestrante para atualizar");
                return;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxPalestrante.Text))
            {
                new PalestranteDAO().Inserir(tbxPalestrante.Text.Trim());
                MessageBox.Show("Palestrante incluído com sucesso");
                this.MostrarDados();
                ClearData();
            }
            else
            {
                MessageBox.Show("Informe o nome do palestrante");
                return;
            }
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbxPalestrante.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
