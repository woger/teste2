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

            string[] datas = Directory.GetFiles(path + @"\PALESTRAS\");
            if (datas.Length > 0)
            {
                for (int i = 0; i < datas.Length; i++)
                {
                    LinkLabel lblData = new LinkLabel();
                    lblData.Name = "lblData" + datas[i];
                    lblData.Text = datas[i];
                    lblData.Location = new Point(1, i * 2);
                    Button botaoBaixar = new Button();
                    botaoBaixar.Text = "Baixar";
                    botaoBaixar.Name = "botaoBaixar" + i;
                    botaoBaixar.Location = new Point(7, i * 2);
                    botaoBaixar.Click += botaoBaixar_Click;
                    Label labelBreakLine = new Label();
                    labelBreakLine.Text = "\r\n";
                    labelBreakLine.Location = new Point(1, i * 2);

                    panelDiretorio.Controls.Add(lblData);
                    panelDiretorio.Controls.Add(botaoBaixar);
                    panelDiretorio.Controls.Add(labelBreakLine);
                }
            }


            //if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) // if user clicked OK
            //{

            //}
        }

        public void botaoBaixar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
