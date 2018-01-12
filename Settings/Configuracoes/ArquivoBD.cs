using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Settings.Configuracoes
{
    public class ArquivoBD
    {
        public static string DIRETORIO_INSTALACAO = AppDomain.CurrentDomain.BaseDirectory;

        public static string DIRETORIO_INSTALACAO_PALESTRAS = AppDomain.CurrentDomain.BaseDirectory + @"\PALESTRAS\";
        public static string FORMATARDATA_DIRETORIO(DateTime pData)
        {
            return pData.ToString("dd-MM-yyyy");
        }

        //public static string TABLE_USUARIO = 

        public static void CriarArquivosBD()
        {
            //string dbfDirectory = @"C:\the_path_to_my_dbf_file_or_files";

            using (OleDbConnection oConn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + ArquivoBD.DIRETORIO_INSTALACAO + ";Extended Properties=dBase III"))
            {
                oConn.Open();

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(" CREATE TABLE USUARIO.DBF ([ID] NUMERIC (18,0), [CO_PERFIL] NUMERIC(1,0), [NOME] CHAR(100), [LOGIN] CHAR(100), [SENHA] CHAR(10));"))//this works and creates an empty .dbf file
                    {
                        cmd.Connection = oConn;
                        cmd.ExecuteNonQuery();

                        //Cria um usuário ADMIN
                        using (OleDbCommand cmd2 = new OleDbCommand(@" INSERT INTO USUARIO.DBF ([ID], [NOME], [LOGIN], [SENHA], [CO_PERFIL]) 
                                                            VALUES(1, 'ADMINISTRADOR', 'ADMIN', 'ADMIN', 1)"))
                        //VALUES (1, 'ADMINISTRADOR', 'ADMIN', 'ADMIN', 1, " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ");"))
                        {
                            cmd2.Connection = oConn;
                            cmd2.ExecuteNonQuery();
                        }

                        //Cria um usuário Monitor
                        using (OleDbCommand cmd2 = new OleDbCommand(@" INSERT INTO USUARIO.DBF ([ID], [NOME], [LOGIN], [SENHA], [CO_PERFIL]) 
                                                            VALUES(2, 'MONITOR', 'MONITOR', '" + Settings.DAO.PassWord.ObterSenhaMonitor() + "', 3)"))
                        //VALUES (1, 'ADMINISTRADOR', 'ADMIN', 'ADMIN', 1, " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ");"))
                        {
                            cmd2.Connection = oConn;
                            cmd2.ExecuteNonQuery();
                        }


                        //Cria um usuário Palestrante
                        using (OleDbCommand cmd2 = new OleDbCommand(@" INSERT INTO USUARIO.DBF ([ID], [NOME], [LOGIN], [SENHA], [CO_PERFIL]) 
                                                            VALUES(2, 'PALESTRANTE', 'PALESTRANTE', '" + Settings.DAO.PassWord.ObterSenhaPalestrante() + "', 2)"))
                        //VALUES (1, 'ADMINISTRADOR', 'ADMIN', 'ADMIN', 1, " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ");"))
                        {
                            cmd2.Connection = oConn;
                            cmd2.ExecuteNonQuery();
                        }

                    }
                }
                catch { }

                //try
                //{
                    
                //}
                //catch { }

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand("  CREATE TABLE EVENTO.DBF ([ID] NUMERIC (18,0), [NOME] CHAR(50), FILE_NAME CHAR(40));"))//this works and creates an empty .dbf file
                    {
                        cmd.Connection = oConn;
                        cmd.ExecuteNonQuery();
                    }
                }


                catch { }

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand("  CREATE TABLE DATAS.DBF ([DATA_EVENTO] DATETIME);"))//this works and creates an empty .dbf file
                    {
                        cmd.Connection = oConn;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch { }
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand("  CREATE TABLE SALAS.DBF ([ID] NUMERIC(2,0), [NOME] CHAR(30));"))//this works and creates an empty .dbf file
                    {
                        cmd.Connection = oConn;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch { }

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand("  CREATE TABLE PALESTRANTES.DBF ([ID] NUMERIC(2,0), [NOME] CHAR(60));"))//this works and creates an empty .dbf file
                    {
                        cmd.Connection = oConn;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch { }

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand("  CREATE TABLE SALA_PAL.DBF ([ID] numeric(2,0), [ID_SALA] NUMERIC(2,0), [ID_PALESTRANTE] NUMERIC(2,0), [DATA] DATETIME, [HORA] CHAR(10));"))//this works and creates an empty .dbf file
                    {
                        cmd.Connection = oConn;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch { }


                oConn.Close();
            }
        }
    }
}