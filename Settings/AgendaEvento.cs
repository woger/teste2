using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings
{
    public class AgendaEvento
    {
        public int Codigo { get; set; }

        public string TemaFormatado
        {
            get
            {
                return this.Data.ToString("dd/MM/yyy") + " - " + this.Hora + ": " + this.Tema.ToUpper();
            }

        }
        public DateTime Data { get; set; }

        public string Hora { get; set; }

        public string NomeSala
        {
            get
            {
                return this.Sala.Nome;
            }

        }

        public string NomePalestrante
        {
            get
            {
                return this.Palestrante.Nome; 
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

        public string Tema { get; set; }

        public string ArquivoPalestra { get; set; }

        public string PathPalestra(string path)
        {
            //ArquivoBD.DIRETORIO_INSTALACAO_PALESTRAS + ArquivoBD.FORMATARDATA_DIRETORIO(Data) + @"\" + sala.Nome + @"\" + pHora.Replace(":", "-") + @" - " + palestrante.NomeSobreNome()
            if (String.IsNullOrEmpty(path))            
                return Settings.Configuracoes.ArquivoBD.DIRETORIO_INSTALACAO_PALESTRAS +  @"\" + this.Sala.Nome + @"\" + Settings.Configuracoes.ArquivoBD.FORMATARDATA_DIRETORIO(this.Data) + @"\" + this.Hora.Replace(":", "-") + @" - " + this.Palestrante.NomeSobreNome();
            else
                return path + @"\PALESTRAS\" +  @"\" + this.Sala.Nome + @"\" + Settings.Configuracoes.ArquivoBD.FORMATARDATA_DIRETORIO(this.Data) + @"\" + this.Hora.Replace(":", "-") + @" - " + this.Palestrante.NomeSobreNome();
            
        }
    }
}
