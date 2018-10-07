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
        //public System.Threading.Timer timer2;
        int minutos = 0;
        int segundos = 0;
        bool estaDecrescente = true;
        bool contadorImpar = true;
        //private Label lblContador2;

        bool telaMaximixada = false;


        public FormCronometro(string pContador)
        {
            InitializeComponent();
            MudaContador(pContador, false);
            //lblContador.BackColor = 
            this.BackColor = Color.Black;
            this.lblContador.ForeColor = Color.White;
            lblContador.BackColor = Color.Transparent;
            
            //        this.SetStyle(
            //ControlStyles.AllPaintingInWmPaint |
            //ControlStyles.UserPaint |
            //ControlStyles.DoubleBuffer,
            //true);
            //lblContador2 = lblContador;
            //lblContador.FlatStyle = FlatStyle.Popup;
            //lblContador.TabStop = false;
            //lblContador.FlatStyle = FlatStyle.Flat;

        }

        public void MudaContador(string pContador, bool startAutomatico)
        {

            if (timer1 != null)
                timer1.Stop();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second

            lblContador.Width = this.Width;
            lblContador.Height = this.Height;
            //lblContador.Size = this.ClientSize;
            lblContador.Text = pContador;
            minutos = int.Parse(pContador.Split(':')[0]);
            segundos = int.Parse(pContador.Split(':')[1]);
            //this.BackColor = Color.Black;
            //this.lblContador.ForeColor = Color.White;
            estaDecrescente = true;

            if (startAutomatico)
            {
                timer1.Start();
                
            }

            //if (minutos == 0)
            //    //lblContador.ForeColor = Color.FromArgb(170,103,8);
            //    lblContador.ForeColor = Color.FromArgb(238, 162, 54);
            //else
            //    lblContador.ForeColor = Color.Black;
        }

        //private void Timer2_Tick(object sender, EventArgs e)
        //{
        //    if (!this.estaDecrescente)
        //        lblContador.BackColor = Color.Transparent;// == Color.Black ? Color.White : Color.Black;
        //}

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

            //if (this.InvokeRequired)
            //{
            //    /* Not on UI thread, reenter there... */
            //    this.BeginInvoke(new EventHandler(timer1_Tick), sender, e);
            //}

            // lblContador.Visible = !lblContador.Visible;
            //lblContador.BackColor = Color.Transparent;
            if (estaDecrescente)
            {
                if (segundos == 0)
                {
                    if (minutos == 0)
                    {
                        estaDecrescente = false;
                        //this.piscarLabel();
                    }
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


                if (segundos == 59)
                {
                    segundos = 0;
                    minutos++;
                }
                else
                    segundos++;
                contadorImpar = !contadorImpar;
                //if (contadorImpar)
                //{
                //    //Bota as cores
                //    this.BackColor = Color.White;
                //    lblContador.BackColor = Color.Black;
                //    lblContador.ForeColor = Color.White;


                //}
                //else
                //{
                //    //Bota outras cores
                //    this.BackColor = Color.Black;
                //    lblContador.BackColor = Color.White;
                //    lblContador.ForeColor = Color.Black;
                //}

                if (contadorImpar)
                {
                    //Bota as cores                    
                    this.BackColor = Color.White;
                    lblFechar.ForeColor = Color.LightGray;
                    
                    lblContador.BorderStyle = BorderStyle.None;
                    lblContador.ForeColor = Color.Black;
                    lblContador.Update();
                    this.Refresh();
                    


                    
                }
                else
                {
                    //Bota outras cores
                    lblContador.BackColor = Color.Transparent;
                    lblFechar.ForeColor = Color.LightGray;
                    this.BackColor = Color.Black;
                    lblContador.BorderStyle = BorderStyle.None;
                    
                    lblContador.ForeColor = Color.White;
                    lblContador.Update();
                    this.Refresh();
                    
                    
                }
                //Thread.Sleep(50);


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

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCronometro_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == (char)Keys.Escape)
            {
                if (!telaMaximixada)
                {
                    this.MaximizeBox = true;
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                    
                }
                else
                {
                    this.MaximizeBox = false;
                    this.FormBorderStyle = FormBorderStyle.Fixed3D;
                }

                telaMaximixada = !telaMaximixada;
            }

            
        }
    }
}
