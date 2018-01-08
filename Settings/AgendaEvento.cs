using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings
{
    public class AgendaEvento
    {
        public int Codigo { get; set; }


        public DateTime Data { get; set; }

        public string Hora { get; set; }

        public string NomePalestrante
        {
            get
            {
                return this.Palestrante.Nome; 
            }
            
        }

        public string NomeSala
        {
            get
            {
                return this.Sala.Nome;
            }

        }

        //public string DataToString
        //{
        //    get
        //    {
        //        return this.Data.ToString("dd/MM/yyyy");
        //    }

        //}

        

        public Sala Sala { get; set; }

        

        public Palestrante Palestrante { get; set; }

        

    }
}
