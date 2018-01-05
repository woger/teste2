using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Settings.DAO
{
    public class PalestranteDAO
    {
        public List<Palestrante> ListarTodos()
        {
            List<Palestrante> palestrantes = new List<Palestrante>();
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM PALESTRANTES.DBF"))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultado.Rows.Count; i++)
                        {
                            Palestrante palestrante = new Palestrante();
                            palestrante.Codigo = int.Parse(resultado.Rows[i]["ID"].ToString());
                            palestrante.Nome = resultado.Rows[i]["NOME"].ToString();
                            palestrantes.Add(palestrante);
                        }
                    }
                }
            }
            return palestrantes;
        }

        public Palestrante BuscarPorCodigo(int pCodigo)
        {
            Palestrante palestrante = null;
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM PALESTRANTES.DBF where ID = " + pCodigo))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        palestrante = new Palestrante();
                        palestrante.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        palestrante.Nome = resultado.Rows[0]["NOME"].ToString();
                    }
                }
            }
            return palestrante;
        }



        public void Inserir(string pNome)
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(@" INSERT INTO PALESTRANTES.DBF ([ID], [NOME]) 
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

                using (OleDbCommand cmd = new OleDbCommand(@" UPDATE PALESTRANTES.DBF set [NOME] = '" + pNome + "' where ID = " + pID))
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

                using (OleDbCommand cmd = new OleDbCommand(@" DELETE FROM PALESTRANTES.DBF WHERE [ID] = " + pID))
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

                using (OleDbCommand cmd = new OleDbCommand(" SELECT max(ID) FROM PALESTRANTES.DBF"))
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
