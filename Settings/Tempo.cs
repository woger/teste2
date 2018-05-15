using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings
{
    public class Tempo
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        private string temporizador;
        public string Temporizador
        {
            get
            {
                return this.temporizador;
            }
            set
            {
                this.temporizador = value;
                this.Contador = this.temporizador;
            }
        }

        private string contador;
        public string Contador
        {
            get
            {
                return this.contador;
            }
            set
            {
                this.contador = value;
            }
        }
    }
}