﻿using System;
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

        public List<Sala> ListarTodos(string pPath)
        {
            List<Sala> salas = new List<Sala>();
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(String.IsNullOrEmpty(pPath) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(pPath)))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALAS.DBF ORDER BY NOME"))
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
                            sala.IP = resultado.Rows[i]["IP"].ToString();
                            salas.Add(sala);
                        }
                    }
                }
            }
            return salas;
        }

        public Sala BuscarPorCodigo(int pCodigo, string pPath)
        {
            Sala sala = null;
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(String.IsNullOrEmpty(pPath) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(pPath)))
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
                        sala.IP = resultado.Rows[0]["IP"].ToString();
                    }
                }
            }
            return sala;
        }

        public Sala BuscarPorNome(string pNome, string pPath)
        {
            Sala sala = null;
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(String.IsNullOrEmpty(pPath) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(pPath)))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALAS.DBF where NOME = '" + pNome + "'"))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        sala = new Sala();
                        sala.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        sala.Nome = resultado.Rows[0]["NOME"].ToString();
                        sala.IP = resultado.Rows[0]["IP"].ToString();
                    }
                }
            }
            return sala;
        }

        public void Inserir(string pNome, string pIP)
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(@" INSERT INTO SALAS.DBF ([ID], [NOME], [IP]) 
                                                            VALUES(" + (this.UltimoIdIncluido() + 1) + ", '" + pNome + "', '"+ pIP + "');"))
                {
                    cmd.Connection = oConn;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(int pID, string pNome, string pIP)
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(@" UPDATE SALAS.DBF set [NOME] = '" + pNome + "', [IP] = '"+ pIP + "' where ID = " + pID))
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
            if (new AgendaEventoDAO().BuscaAgendaPorSala(pID, null).Count > 0)//Se existe palestra associada a esta sala
                throw new Exception("Existe uma palestra cadastrada para esta sala. Para deletar esta sala, exclua a palestra associada a ela.");

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
