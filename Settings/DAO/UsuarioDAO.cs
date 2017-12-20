using Settings.Configuracoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Settings.DAO
{
    public class UsuarioDAO
    {
        public Usuario Login(string login, string senha)
        {
            Usuario usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM USUARIO.DBF WHERE [LOGIN] = '"+ login + "' AND [SENHA] = '" + senha+ "';"))//this works and creates an empty .dbf file
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
                    
                    DA.Fill(resultado);
                    if(resultado.Rows.Count > 0)
                    {
                        usuario = new Usuario();
                        usuario.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        usuario.Nome = resultado.Rows[0]["NOME"].ToString();
                        usuario.Login = resultado.Rows[0]["LOGIN"].ToString();
                    }
                }
                
            }

            return usuario;
        }        
    }
}
