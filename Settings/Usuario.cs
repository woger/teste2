using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings
{
    public class Usuario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public bool Ativo { get; set; }

        public DateTime? DataCriacao { get; set; }

    }
}
