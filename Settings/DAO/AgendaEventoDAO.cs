using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Settings.DAO
{
    public class AgendaEventoDAO
    {
        public void SalvarAgendaEvento(int pPalestrante, int pSala, DateTime Data, int? pCodigo)
        {
            //DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {

                if (this.VerificaExistenciaEvento(pPalestrante, pSala, Data, pCodigo) != null)                
                    throw new Exception("Já existe um cadastro com os mesmos dados. Por favor verifique na lista existente.");                

                oConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                if (!pCodigo.HasValue)// Se não existe                
                {
                    cmd.CommandText = @" INSERT INTO SALA_PALESTRANTE_DATA.DBF (ID, ID_SALA, ID_PALESTRANTE, DATA) 
                                                            VALUES (@ID, @SALA, @PALESTRANTE, @DATA);";
                    cmd.Parameters.Add("@ID", OleDbType.Numeric).Value = this.UltimoIdIncluido() + 1;
                    cmd.Parameters.Add("@SALA", OleDbType.Numeric).Value = pSala;
                    cmd.Parameters.Add("@palestrante", OleDbType.Numeric).Value = pPalestrante;
                    cmd.Parameters.Add("@DATA", OleDbType.Date).Value = Data;
                }
                else
                {
                    cmd.CommandText = @" UPDATE SALA_PALESTRANTE_DATA.DBF SET ID_SALA = @SALA, ID_PALESTRANTE = @PALESTRANTE, DATA = @DATA WHERE ID = @ID";
                    cmd.Parameters.Add("@ID", OleDbType.Numeric).Value = pCodigo;
                    cmd.Parameters.Add("@SALA", OleDbType.Numeric).Value = pSala;
                    cmd.Parameters.Add("@palestrante", OleDbType.Numeric).Value = pPalestrante;
                    cmd.Parameters.Add("@DATA", OleDbType.Date).Value = Data;
                }

                cmd.Connection = oConn;
                cmd.ExecuteNonQuery();

            }
        }

        public AgendaEvento VerificaExistenciaEvento(int pPalestrante, int pSala, DateTime Data, int? pCodigo)
        {
            AgendaEvento agendaEvento = null;
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();
                DataTable resultado = new DataTable();
                using (OleDbCommand cmd = new OleDbCommand(@" SELECT * FROM SALA_PALESTRANTE_DATA.DBF WHERE ID_SALA = @SALA AND ID_PALESTRANTE = @PALESTRANTE AND DATA = @DATA"))//this works and creates an empty .dbf file
                {
                    if (pCodigo.HasValue)
                        cmd.CommandText += " AND ID <> @ID";
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        agendaEvento = new AgendaEvento();
                        agendaEvento.Palestrante = new PalestranteDAO().BuscarPorCodigo(pPalestrante);
                        agendaEvento.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        agendaEvento.Sala = new SalaDAO().BuscarPorCodigo(pSala);
                        agendaEvento.Data = DateTime.Parse(resultado.Rows[0]["DATA"].ToString());
                        //evento.Datas = this.DatasEvento();
                        return agendaEvento;
                    }
                }
                return agendaEvento;
            }
        }

        public List<AgendaEvento> ListarTodos()
        {
            List<AgendaEvento> agendas = new List<AgendaEvento>();
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALA_PALESTRANTE_DATA.DBF"))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultado.Rows.Count; i++)
                        {
                            AgendaEvento agendaEvento = new AgendaEvento();
                            agendaEvento.Palestrante = new PalestranteDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_PALESTRANTE"].ToString()));
                            agendaEvento.Codigo = int.Parse(resultado.Rows[i]["ID"].ToString());
                            agendaEvento.Sala = new SalaDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_SALA"].ToString()));
                            agendaEvento.Data = DateTime.Parse(resultado.Rows[i]["DATA"].ToString());
                            agendas.Add(agendaEvento);
                        }
                    }
                }
            }
            return agendas;
        }

        public int UltimoIdIncluido()
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT max(ID) FROM SALA_PALESTRANTE_DATA.DBF"))
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
