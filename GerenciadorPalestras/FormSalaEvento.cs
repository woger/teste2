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
    public partial class FormSalaEvento : Form
    {
        int ID = 0;
        public FormSalaEvento()
        {
            InitializeComponent();
            MostrarDados();
        }

        public void MostrarDados()
        {
            dataGridView1.DataSource = new SalaDAO().ListarTodos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxNomeSala.Text))
            {
                new SalaDAO().Inserir(tbxNomeSala.Text.Trim());
                MessageBox.Show("Sala incluída com sucesso");
                this.MostrarDados();
                ClearData();
            }
            else
            {
                MessageBox.Show("Informe o nome da sala");
                return;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (ID != 0 && !String.IsNullOrEmpty(tbxNomeSala.Text))
            {
                new SalaDAO().Atualizar(this.ID, tbxNomeSala.Text);
                MessageBox.Show("Sala atualizada com sucesso");
                ClearData();
                this.MostrarDados();
            }
            else
            {
                MessageBox.Show("Selecione uma sala para atualizar");
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                new SalaDAO().Excluir(this.ID);
                MessageBox.Show("Sala excluída com sucesso");
                ClearData();
                this.MostrarDados();
            }
            else
            {
                MessageBox.Show("Selecione uma sala para deletar");
                return;
            }
        }

        private void ClearData()
        {
            tbxNomeSala.Text = string.Empty;
            ID = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbxNomeSala.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
