using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings
{
    public class Sala
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string IP { get; set; }

        public override string ToString()
        {
            return this.Nome.ToUpper();
        }
    }
}
