using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Settings.DAO
{
    public class SalaDAO
    {
        public SalaDAO() { }

        public List<Sala> ListarTodos()
        {
            List<Sala> salas = new List<Sala>();
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALAS.DBF"))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultado.Rows.Count; i++)
                        {
                            Sala sala = new Sala();
                            sala.Codigo = int.Parse(resultado.Rows[i]["ID"].ToString());
                            sala.Nome = resultado.Rows[i]["NOME"].ToString();
                            salas.Add(sala);
                        }
                    }
                }
            }
            return salas;
        }

        public Sala BuscarPorCodigo(int pCodigo)
        {
            Sala sala = null;
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALAS.DBF where ID = " + pCodigo))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        sala = new Sala();
                        sala.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        sala.Nome = resultado.Rows[0]["NOME"].ToString();
                    }
                }
            }
            return sala;
        }

        public void Inserir(string pNome)
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(@" INSERT INTO SALAS.DBF ([ID], [NOME]) 
                                                            VALUES(" + (this.UltimoIdIncluido() + 1) + ", '" + pNome + "');"))
                {
                    cmd.Connection = oConn;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(int pID, string pNome)
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(@" UPDATE SALAS.DBF set [NOME] = '" + pNome + "' where ID = " + pID))
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

                using (OleDbCommand cmd = new OleDbCommand(@" DELETE FROM SALAS.DBF WHERE [ID] = " + pID))
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

                using (OleDbCommand cmd = new OleDbCommand(" SELECT max(ID) FROM SALAS.DBF"))
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
