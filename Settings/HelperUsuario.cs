using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Settings
{
    public static class HelperUsuario
    {
        private static Usuario usuario;

        /// <summary>
        /// Registra o usuário que fez login no sistema
        /// </summary>
        /// <param name="usuario"></param>
        public static void RegistrarLogin(Usuario usuario)
        {
            HelperUsuario.usuario = usuario;
        }

        /// <summary>
        /// Retorna o usuário logado
        /// </summary>
        /// <returns></returns>
        public static Usuario UsuarioLogado()
        {
            return HelperUsuario.usuario;
        }
    }
}
