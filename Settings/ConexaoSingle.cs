using Settings.Configuracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings
{
    public static class ConexaoSingle
    {

        public static string conexao = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + ArquivoBD.DIRETORIO_INSTALACAO + ";Extended Properties=dBase III";
        //public static string conexao = "Provider=Microsoft.Jet.OLEDB.4.0; Driver={Microsoft dBase Driver(*.dbf)}; SourceType=DBF;SourceDB=" + ArquivoBD.DIRETORIO_INSTALACAO + ";Exclusive=No; Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";

        public static string conexaoRemota(string path)
        {
            return "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + path + ";Extended Properties=dBase III";
            //return "Provider=Microsoft.Jet.OLEDB.4.0; Driver={Microsoft dBase Driver(*.dbf)}; SourceType=DBF;SourceDB=" + path + ";Exclusive=No; Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
        }

    }
}
