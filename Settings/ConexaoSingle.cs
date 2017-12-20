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
    }
}
