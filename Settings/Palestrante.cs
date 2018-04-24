using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings
{
    public class Palestrante
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string NomeSobreNome()
        {
            string[] nome = this.Nome.Split(' ');
            if (nome.Length > 1)
            {
                return nome[0] + " " + nome[nome.Length - 1];
            }
            return this.Nome;
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
