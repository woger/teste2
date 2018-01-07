using Settings.Configuracoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Settings.DAO
{
    public class EventoDAO
    {
        public void SalvarEvento(String pNomeEvento, String pFileName, List<DateTime> pDatas, Bitmap pImagem )
        {
            //DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                if (VerificaExistenciaEvento() == null)// Se não existe                
                    cmd.CommandText = @" INSERT INTO EVENTO.DBF (ID, NOME, FILE_NAME) 
                                                            VALUES (1, '" + pNomeEvento + "', '" + pFileName + "');";
                else
                    cmd.CommandText = @" UPDATE EVENTO.DBF SET NOME = '" + pNomeEvento + "', FILE_NAME = '" + pFileName + "'";

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
                    }
                }

                //Salva a imagem no diretório da app
                pImagem.Save(ArquivoBD.DIRETORIO_INSTALACAO + @"\" + pFileName);                
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
                        evento.Datas = this.DatasEvento();
                        return evento;
                    }
                }
                return evento;
            }
        }

        public List<DateTime> DatasEvento()
        {
            List<DateTime> datas = new List<DateTime>();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
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
