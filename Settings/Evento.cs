using Settings.Configuracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings
{
    public class Evento
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        //Caminho do arquivo de imagem do Banner
        public string Arquivo { get; set; }

        public string PathFile
        {
            get
            {
                return ArquivoBD.DIRETORIO_INSTALACAO + @"\" + this.Arquivo;
            }
        }

        
        public List<DateTime> Datas { get; set; }
    }
}
