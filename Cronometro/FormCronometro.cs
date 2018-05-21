using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class FormCronometro : Form
    {
        public System.Windows.Forms.Timer timer1;
        int minutos = 0;
        int segundos = 0;
        bool estaDecrescente = true;
        bool contadorImpar = true;


        public FormCronometro(string pContador)
        {
            InitializeComponent();
            MudaContador(pContador);
            this.BackColor = Color.Black;
            this.lblContador.ForeColor = Color.White;

        }

        public void MudaContador(string pContador)
        {

            if (timer1 != null)
                timer1.Stop();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            lblContador.Width = this.Width;
            lblContador.Height = this.Height;
            lblContador.Text = pContador;
            minutos = int.Parse(pContador.Split(':')[0]);
            segundos = int.Parse(pContador.Split(':')[1]);
            lblContador.ForeColor = Color.White;
            estaDecrescente = true;
            //if (minutos == 0)
            //    //lblContador.ForeColor = Color.FromArgb(170,103,8);
            //    lblContador.ForeColor = Color.FromArgb(238, 162, 54);
            //else
            //    lblContador.ForeColor = Color.Black;
        }

        public void PausarContador()
        {
            if (timer1 != null)
                timer1.Stop();
        }

        public void RetomarContador()
        {
            if (timer1 != null)
                timer1.Start();
        }

        public bool ContadorAtivo()
        {
            if (timer1 != null)
                return timer1.Enabled;
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (estaDecrescente)
            {
                if (segundos == 0)
                {
                    if (minutos == 0)
                        estaDecrescente = false;
                    else
                    {
                        segundos = 59;
                        if (estaDecrescente)
                            minutos--;
                        else
                            minutos++;
                    }
                }
                else
                    segundos--;
            }
            else
            {
                if (contadorImpar)
                {
                    //Bota as cores
                    this.BackColor = Color.White;
                    lblContador.ForeColor = Color.Red;
                }
                else
                {
                    //Bota outras cores
                    this.BackColor = Color.Black;
                    lblContador.ForeColor = Color.White;
                }

                if (segundos == 59)
                {
                    segundos = 0;
                    minutos++;
                }
                else
                    segundos++;
                contadorImpar = !contadorImpar;
            }
            

            lblContador.Text = minutos.ToString("00") + ":" + segundos.ToString("00");

            //if (minutos == 0)
            //    //lblContador.ForeColor = Color.FromArgb(170,103,8);
            //    lblContador.ForeColor = Color.FromArgb(238, 162, 54);
            //else
            //    lblContador.ForeColor = Color.Black;
        }

        private void piscarLabel()
        {
            // Se o label estiver visível, ele ficará não visível.
            if (lblContador.Visible == true)
                lblContador.Visible = false;
            // Se o label estiver não visível, ele ficará visível.
            else
                lblContador.Visible = true;

            // Cria um intervalo até a próxima execução.
            Thread.Sleep(1000);

            // Chama novamente o método.
            piscarLabel();

        }
    }
}
