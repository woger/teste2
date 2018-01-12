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

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM USUARIO.DBF WHERE [LOGIN] = '" + login + "' AND [SENHA] = '" + senha + "';"))//this works and creates an empty .dbf file
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        usuario = new Usuario();
                        usuario.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        usuario.Nome = resultado.Rows[0]["NOME"].ToString();
                        usuario.Login = resultado.Rows[0]["LOGIN"].ToString();
                        usuario.Perfil = int.Parse(resultado.Rows[0]["CO_PERFIL"].ToString());
                    }
                }
            }
            return usuario;
        }

        public string RetornaSenhaPalestrante()
        {

            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM USUARIO.DBF WHERE [LOGIN] = 'PALESTRANTE';"))//this works and creates an empty .dbf file
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                        return resultado.Rows[0]["SENHA"].ToString();
                }
            }
            return null;
        }

        public string RetornaSenhaMonitor()
        {

            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM USUARIO.DBF WHERE [LOGIN] = 'MONITOR';"))//this works and creates an empty .dbf file
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                        return resultado.Rows[0]["SENHA"].ToString();
                }
            }
            return null;
        }

        public Usuario LoginRemoto(string login, string senha, string path)
        {
            Usuario usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexaoRemota(path)))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM USUARIO.DBF WHERE [LOGIN] = '" + login + "' AND [SENHA] = '" + senha + "';"))//this works and creates an empty .dbf file
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        usuario = new Usuario();
                        usuario.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        usuario.Nome = resultado.Rows[0]["NOME"].ToString();
                        usuario.Login = resultado.Rows[0]["LOGIN"].ToString();
                        usuario.Perfil = int.Parse(resultado.Rows[0]["CO_PERFIL"].ToString());
                    }
                }
            }
            return usuario;
        }

        public Usuario BuscarPorID(int pID)
        {
            Usuario usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM USUARIO.DBF WHERE [ID] = " + pID))//this works and creates an empty .dbf file
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        usuario = new Usuario();
                        usuario.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        usuario.Nome = resultado.Rows[0]["NOME"].ToString();
                        usuario.Login = resultado.Rows[0]["LOGIN"].ToString();
                        usuario.Perfil = int.Parse(resultado.Rows[0]["CO_PERFIL"].ToString());
                    }
                }
            }
            return usuario;
        }

        public List<Usuario> ListarTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();
                DataTable resultado = new DataTable();
                using (OleDbCommand cmd = new OleDbCommand(@" SELECT * FROM USUARIO.DBF"))//this works and creates an empty .dbf file
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                        for (int i = 0; i < resultado.Rows.Count; i++)
                        {
                            Usuario usuario = new Usuario();
                            usuario.Codigo = int.Parse(resultado.Rows[i]["ID"].ToString());
                            usuario.Nome = resultado.Rows[i]["NOME"].ToString();
                            usuario.Perfil = int.Parse(resultado.Rows[i]["CO_PERFIL"].ToString());
                            usuario.Login = resultado.Rows[i]["LOGIN"].ToString();
                            usuario.Senha = resultado.Rows[i]["SENHA"].ToString();
                            usuarios.Add(usuario);
                        }
                }
                return usuarios;
            }
        }

        public void SalvarUsuario(Usuario usuario)
        {
            //DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                if (usuario.Codigo == 0)// Se não existe                
                    cmd.CommandText = @" INSERT INTO USUARIO.DBF ([ID], [NOME], [LOGIN], [SENHA], [CO_PERFIL]) 
                                                            VALUES(" + (this.UltimoIdIncluido() + 1) + ", '" + usuario.Nome + "', '" + usuario.Login + "', '" + usuario.Senha + "', " + usuario.Perfil + ")";
                else
                    cmd.CommandText = @" UPDATE USUARIO.DBF SET NOME = '" + usuario.Nome + "', LOGIN = '" + usuario.Login + "', SENHA = '" + usuario.Senha + "', CO_PERFIL = " + usuario.Perfil + " WHERE ID = " + usuario.Codigo;


                cmd.Connection = oConn;
                cmd.ExecuteNonQuery();
            }
        }

        public int UltimoIdIncluido()
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT max(ID) FROM USUARIO.DBF"))
                {
                    cmd.Connection = oConn;

                    OleDbDataReader r = cmd.ExecuteReader();
                    r.Read();
                    if (!String.IsNullOrEmpty(r[0].ToString()))
                        //OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
                        //DataTable resultado = new DataTable();

                        //DA.Fill(resultado);
                        //if (resultado.Rows.Count > 0)                    
                        return int.Parse(r[0].ToString());
                }

                return 0;
            }
        }
    }
}
