using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class FormIniciarCronometro : Form
    {
        private System.Windows.Forms.Timer timer1;
        int minutos = 0;
        int segundos = 0;

        public FormIniciarCronometro(string pContador)
        {
            InitializeComponent();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            lblContador.Text = pContador;
            minutos = int.Parse(pContador.Split(':')[0]);
            segundos = int.Parse(pContador.Split(':')[1]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (segundos == 0)
            {
                if (minutos == 0)
                    timer1.Stop();
                else
                {
                    segundos = 59;
                    minutos--;
                }
            }
            else
                segundos--;

            lblContador.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
        }
    }
}
