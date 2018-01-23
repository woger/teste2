using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings.DAO
{
    public class PassWord
    {

        public static string[] POSSIVEIS_SENHAS_PALESTRANTE = new string[] { "123456", "PALESTRANTE", "1QAZ2WSX", "PALESTRA123", "123PALESTRA", "ASDZXC" };

        public static string[] POSSIVEIS_SENHAS_MONITOR = new string[] { "123456", "MONITOR", "1QAZ2WSX", "MONITOR123", "123MONITOR", "ASDZXC" };

        public static string ObterSenhaPalestrante()
        {
            return POSSIVEIS_SENHAS_PALESTRANTE.ElementAt(new Random().Next(0, POSSIVEIS_SENHAS_PALESTRANTE.Length -1));
        }

        public static string ObterSenhaMonitor()
        {
            return POSSIVEIS_SENHAS_MONITOR.ElementAt(new Random().Next(0, POSSIVEIS_SENHAS_PALESTRANTE.Length -1));
        }
    }
}
