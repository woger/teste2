using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings
{
    public class AgendaEvento
    {
        public int Codigo;

        public Palestrante Palestrante { get; set; }

        public Sala Sala { get; set; }

        public DateTime Data { get; set; }

    }
}
