using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Settings.DAO
{
    public class TempoDAO
    {
        public List<Tempo> ListarTodos()
        {
            List<Tempo> tempos = new List<Tempo>();
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM HORARIO.DBF ORDER BY NOME"))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultado.Rows.Count; i++)
                        {
                            Tempo tempo = new Tempo();
                            tempo.Codigo = int.Parse(resultado.Rows[i]["ID"].ToString());
                            tempo.Nome = resultado.Rows[i]["NOME"].ToString();
                            tempo.Temporizador = resultado.Rows[i]["TEMPO"].ToString();
                            tempos.Add(tempo);
                        }
                    }
                }
            }
            return tempos;
        }

        public Tempo BuscarPorCodigo(int pCodigo)
        {
            Tempo tempo = null;
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM HORARIO.DBF where ID = " + pCodigo))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        tempo = new Tempo();
                        tempo.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        tempo.Nome = resultado.Rows[0]["NOME"].ToString();
                        tempo.Temporizador = resultado.Rows[0]["TEMPO"].ToString();
                    }
                }
            }
            return tempo;
        }

        public Tempo BuscarPorNome(string pNome)
        {
            Tempo tempo = null;
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM HORARIO.DBF where NOME = '" + pNome + "'"))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        tempo = new Tempo();
                        tempo.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        tempo.Nome = resultado.Rows[0]["NOME"].ToString();
                        tempo.Temporizador = resultado.Rows[0]["TEMPO"].ToString();
                    }
                }
            }
            return tempo;
        }

        public void Inserir(string pNome, string pTempo)
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(@" INSERT INTO HORARIO.DBF ([ID], [NOME], [TEMPO]) 
                                                            VALUES(" + (this.UltimoIdIncluido() + 1) + ", '" + pNome + "', '" + pTempo + "');"))
                {
                    cmd.Connection = oConn;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(int pID, string pNome, string pTempo)
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(@" UPDATE HORARIO.DBF set [NOME] = '" + pNome + "', [TEMPO] = '" + pTempo + "' where ID = " + pID))
                {
                    cmd.Connection = oConn;
                    //cmd.Parameters.AddWithValue("nome", pNome);
                    //cmd.Parameters.AddWithValue("id", pID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int pID)
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(@" DELETE FROM HORARIO.DBF WHERE [ID] = " + pID))
                {
                    cmd.Connection = oConn;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int UltimoIdIncluido()
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT max(ID) FROM HORARIO.DBF"))
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
