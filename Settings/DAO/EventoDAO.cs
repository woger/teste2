﻿using Settings.Configuracoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Settings.DAO
{
    public class EventoDAO
    {
        public void SalvarEvento(String pNomeEvento, List<DateTime> pDatas)
        {
            //DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                //if(pFileName.Length > 140)
                //    pFileName = pFileName.Remove(140);
                //Salva a imagem no diretório da app
                //if (System.IO.File.Exists(ArquivoBD.DIRETORIO_INSTALACAO + @"\" + pFileName))
                //{
                //    string nomeArquivo = Path.GetFileNameWithoutExtension(pFileName);
                //    string extensao = Path.GetExtension(pFileName);
                //    pFileName = nomeArquivo + new Random(5).Next(0, 10).ToString() + extensao;
                //    pImagem.Save(ArquivoBD.DIRETORIO_INSTALACAO + @"\" + pFileName);
                //}
                //else
                //    pImagem.Save(ArquivoBD.DIRETORIO_INSTALACAO + @"\" + pFileName);


                if (VerificaExistenciaEvento() == null)// Se não existe                
                    cmd.CommandText = @" INSERT INTO EVENTO.DBF (ID, NOME) 
                                                            VALUES (1, '" + pNomeEvento + "');";
                else
                    cmd.CommandText = @" UPDATE EVENTO.DBF SET NOME = '" + pNomeEvento + "'";

                cmd.Connection = oConn;
                cmd.ExecuteNonQuery();

                using (cmd = new OleDbCommand("  DELETE FROM DATAS.DBF"))
                {
                    cmd.Connection = oConn;
                    cmd.ExecuteNonQuery();
                }

                for (int i = 0; i < pDatas.Count; i++)
                {
                    using (cmd = new OleDbCommand(@" INSERT INTO DATAS.DBF (DATA_EVENTO) 
                                                            VALUES (@data);"))
                    {
                        cmd.Connection = oConn;
                        cmd.Parameters.Add("@data", OleDbType.Date).Value = pDatas[i];
                        cmd.ExecuteNonQuery();
                        if(!System.IO.Directory.Exists(ArquivoBD.DIRETORIO_INSTALACAO + @"\PALESTRAS\")) //Se não existe a pasta 
                            System.IO.Directory.CreateDirectory(ArquivoBD.DIRETORIO_INSTALACAO + @"\PALESTRAS\");//Cria
                    }
                }

                
            }
        }

        public Evento VerificaExistenciaEvento()
        {
            Evento evento = null;
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();
                DataTable resultado = new DataTable();
                using (OleDbCommand cmd = new OleDbCommand(@" SELECT * FROM EVENTO.DBF"))//this works and creates an empty .dbf file
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        evento = new Evento();
                        evento.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        evento.Nome = resultado.Rows[0]["NOME"].ToString();
                        evento.Arquivo = resultado.Rows[0]["FILE_NAME"].ToString();
                        evento.Datas = this.DatasEvento(null);
                        return evento;
                    }
                }
                return evento;
            }
        }

        public Evento VerificaExistenciaEvento(String path)
        {
            Evento evento = null;
            using (OleDbConnection oConn = new OleDbConnection(String.IsNullOrEmpty(path) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(path)))
            {
                oConn.Open();
                DataTable resultado = new DataTable();
                using (OleDbCommand cmd = new OleDbCommand(@" SELECT * FROM EVENTO.DBF"))//this works and creates an empty .dbf file
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        evento = new Evento();
                        evento.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        evento.Nome = resultado.Rows[0]["NOME"].ToString();
                        evento.Arquivo = resultado.Rows[0]["FILE_NAME"].ToString();
                        evento.Datas = this.DatasEvento(path);
                        return evento;
                    }
                }
                return evento;
            }
        }

        public List<DateTime> DatasEvento(string path)
        {
            List<DateTime> datas = new List<DateTime>();
            using (OleDbConnection oConn = new OleDbConnection(String.IsNullOrEmpty(path) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(path)))
            {
                oConn.Open();
                DataTable resultado = new DataTable();
                using (OleDbCommand cmd = new OleDbCommand(@" SELECT * FROM DATAS.DBF ORDER BY DATA_EVENT"))//this works and creates an empty .dbf file
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                        for (int i = 0; i < resultado.Rows.Count; i++)
                            datas.Add(DateTime.Parse(resultado.Rows[i][0].ToString()));
                }
                return datas;
            }
        }
    }
}
