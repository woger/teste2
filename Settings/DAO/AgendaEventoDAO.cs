using Settings.Configuracoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace Settings.DAO
{
    public class AgendaEventoDAO
    {
        public void SalvarAgendaEvento(int pPalestrante, int pSala, DateTime Data, string pHora, int? pCodigo, string pTema)
        {
            //DataTable resultado = new DataTable();

            if (this.VerificaExistenciaEvento(pSala, Data, pHora, pCodigo) != null)
                throw new Exception("Já existe uma palestra para a mesma sala, data e horario. Por favor verifique na lista existente.");

            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                if (!pCodigo.HasValue)// Se não existe                
                {
                    cmd.CommandText = @" INSERT INTO SALA_PAL.DBF (ID, ID_SALA, ID_PALESTR, DATA, HORA, TEMA) 
                                                            VALUES (@ID, @SALA, @PALESTRANTE, @DATA, @HORA, @TEMA);";
                    cmd.Parameters.Add("@ID", OleDbType.Numeric).Value = this.UltimoIdIncluido() + 1;
                    cmd.Parameters.Add("@SALA", OleDbType.Numeric).Value = pSala;
                    cmd.Parameters.Add("@PALESTRANTE", OleDbType.Numeric).Value = pPalestrante;
                    cmd.Parameters.Add("@DATA", OleDbType.Date).Value = Data;
                    cmd.Parameters.Add("@HORA", OleDbType.VarChar).Value = pHora;
                    cmd.Parameters.Add("@TEMA", OleDbType.VarChar).Value = pTema;
                }
                else
                {
                    cmd.CommandText = @" UPDATE SALA_PAL.DBF SET ID_SALA = @SALA, ID_PALESTR = @PALESTRANTE, DATA = @DATA, HORA = @HORA, TEMA = @TEMA WHERE ID = @ID";

                    cmd.Parameters.Add("@SALA", OleDbType.Numeric).Value = pSala;
                    cmd.Parameters.Add("@PALESTRANTE", OleDbType.Numeric).Value = pPalestrante;
                    cmd.Parameters.Add("@DATA", OleDbType.Date).Value = Data;
                    cmd.Parameters.Add("@HORA", OleDbType.VarChar).Value = pHora;
                    cmd.Parameters.Add("@ID", OleDbType.Numeric).Value = pCodigo.Value;
                    cmd.Parameters.Add("@TEMA", OleDbType.VarChar).Value = pTema;
                }

                cmd.Connection = oConn;
                cmd.ExecuteNonQuery();

                //cria o diretório para a data informada, cria a sala, horário
                try
                {
                    System.IO.DirectoryInfo infoDiretorio = null;
                    Sala sala = new SalaDAO().BuscarPorCodigo(pSala, null);
                    if (sala != null)
                    {
                        if (!System.IO.Directory.Exists(ArquivoBD.DIRETORIO_INSTALACAO_PALESTRAS + @"\" + sala.Nome)) //Se não existe a pasta da sala para a data
                            infoDiretorio = System.IO.Directory.CreateDirectory(ArquivoBD.DIRETORIO_INSTALACAO_PALESTRAS + @"\" + sala.Nome);//Cria
                    }


                    if (!System.IO.Directory.Exists(ArquivoBD.DIRETORIO_INSTALACAO_PALESTRAS + @"\" + sala.Nome + @"\"+ ArquivoBD.FORMATARDATA_DIRETORIO(Data))) //Se não existe a pasta da data
                        infoDiretorio = System.IO.Directory.CreateDirectory(ArquivoBD.DIRETORIO_INSTALACAO_PALESTRAS + @"\" + sala.Nome + @"\" + ArquivoBD.FORMATARDATA_DIRETORIO(Data));//Cria

                    

                    Palestrante palestrante = new PalestranteDAO().BuscarPorCodigo(pPalestrante, null);
                    if (palestrante != null)
                    {
                        //Verifico se já existe a pasta para o horário
                        if (!System.IO.Directory.Exists(ArquivoBD.DIRETORIO_INSTALACAO_PALESTRAS  + @"\" + sala.Nome + @"\" + ArquivoBD.FORMATARDATA_DIRETORIO(Data) + @"\" + pHora.Replace(":", "-") + @" - " + palestrante.NomeSobreNome())) //Se não existe a pasta do horário para a sala e para a data
                            infoDiretorio = System.IO.Directory.CreateDirectory(ArquivoBD.DIRETORIO_INSTALACAO_PALESTRAS + @"\" + sala.Nome + @"\" + ArquivoBD.FORMATARDATA_DIRETORIO(Data) + @"\" + pHora.Replace(":", "-") + @" - " + palestrante.NomeSobreNome());//Cria
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Ocorreu um erro ao criar as pastas no diretório de instalação " + ArquivoBD.DIRETORIO_INSTALACAO_PALESTRAS + ": " + e.Message);
                }
            }
        }


        public void CriarPastasRemoto(string pPath, DateTime pData, int pSala, int pPalestrante, string pHora, string pDestinoArquivo, System.IO.FileStream pArquivo, string pNomeArquivo)
        {
            string pathFinal = string.Empty;

            Sala sala = new SalaDAO().BuscarPorCodigo(pSala, pPath);
            if (sala != null)
            {
                if (!System.IO.Directory.Exists(pDestinoArquivo + @"\" + sala.Nome)) //Se não existe a pasta da sala para a data
                    System.IO.Directory.CreateDirectory(pDestinoArquivo + @"\" + sala.Nome);//Cria
            }

            //System.IO.Directory.CreateDirectory(pDestinoArquivo + @"\"  + @"\" + sala.Nome + ArquivoBD.FORMATARDATA_DIRETORIO(pData));//Cria

            if (!System.IO.Directory.Exists(pDestinoArquivo + @"\" + sala.Nome + @"\" + ArquivoBD.FORMATARDATA_DIRETORIO(pData))) //Se não existe a pasta da data
                System.IO.Directory.CreateDirectory(pDestinoArquivo + @"\" + sala.Nome + @"\" + ArquivoBD.FORMATARDATA_DIRETORIO(pData));//Cria

            

            Palestrante palestrante = new PalestranteDAO().BuscarPorCodigo(pPalestrante, pPath);
            if (palestrante != null)
            {
                //Verifico se já existe a pasta para o horário
                if (!System.IO.Directory.Exists(pDestinoArquivo + @"\" +  @"\" + sala.Nome + @"\" + ArquivoBD.FORMATARDATA_DIRETORIO(pData) + @"\" + pHora.Replace(":", "-") + @" - " + palestrante.NomeSobreNome())) //Se não existe a pasta do horário para a sala e para a data
                    pathFinal = System.IO.Directory.CreateDirectory(pDestinoArquivo +  @"\" + sala.Nome + @"\" + ArquivoBD.FORMATARDATA_DIRETORIO(pData) + @"\" + pHora.Replace(":", "-") + @" - " + palestrante.NomeSobreNome()).FullName;//Cria
                else
                    pathFinal = pDestinoArquivo + @"\" +  @"\" + sala.Nome + @"\" + ArquivoBD.FORMATARDATA_DIRETORIO(pData) + @"\" + pHora.Replace(":", "-") + @" - " + palestrante.NomeSobreNome();//Cria
            }




            System.IO.FileStream arquivoSaida = System.IO.File.Create(pathFinal + @"\ " + pNomeArquivo); 
            int b;

            while ((b = pArquivo.ReadByte()) > -1)
                arquivoSaida.WriteByte((byte)b);

            arquivoSaida.Flush();
            arquivoSaida.Close();
            pArquivo.Close();
        }

        public AgendaEvento VerificaExistenciaEvento(int pSala, DateTime Data, string pHora, int? pCodigo)
        {
            AgendaEvento agendaEvento = null;
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();
                DataTable resultado = new DataTable();
                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALA_PAL.DBF WHERE ID_SALA = @SALA AND DATA = @DATA_EVENTO AND HORA = @HORA"))//this works and creates an empty .dbf file
                {
                    if (pCodigo.HasValue)
                    {
                        cmd.CommandText += " AND ID <> @ID";
                        cmd.Parameters.Add("@ID", OleDbType.Numeric).Value = pCodigo.Value;
                    }

                    cmd.Parameters.Add("@SALA", OleDbType.Numeric).Value = pSala;
                    cmd.Parameters.Add("@DATA_EVENTO", OleDbType.Date).Value = Data;
                    cmd.Parameters.Add("@HORA", OleDbType.VarChar).Value = pHora;
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        agendaEvento = new AgendaEvento();
                        agendaEvento.Palestrante = new PalestranteDAO().BuscarPorCodigo(int.Parse(resultado.Rows[0]["ID_PALESTR"].ToString()), null);
                        agendaEvento.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        agendaEvento.Sala = new SalaDAO().BuscarPorCodigo(pSala, null);
                        agendaEvento.Data = DateTime.Parse(resultado.Rows[0]["DATA"].ToString());
                        agendaEvento.Hora = pHora;
                        agendaEvento.ArquivoPalestra = resultado.Rows[0]["FILENAME"].ToString();
                        //evento.Datas = this.DatasEvento();
                        return agendaEvento;
                    }
                }
                return agendaEvento;
            }
        }

        public AgendaEvento BuscarPorCodigo(int pCodigo, string pPath)
        {
            AgendaEvento agendaEvento = null;
            using (OleDbConnection oConn = new OleDbConnection(String.IsNullOrEmpty(pPath) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(pPath)))
            {
                oConn.Open();
                DataTable resultado = new DataTable();
                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALA_PAL.DBF WHERE ID = @ID"))//this works and creates an empty .dbf file
                {

                    cmd.Parameters.Add("@ID", OleDbType.Numeric).Value = pCodigo;
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        agendaEvento = new AgendaEvento();
                        agendaEvento.Palestrante = new PalestranteDAO().BuscarPorCodigo(int.Parse(resultado.Rows[0]["ID_PALESTR"].ToString()), pPath);
                        agendaEvento.Codigo = int.Parse(resultado.Rows[0]["ID"].ToString());
                        agendaEvento.Sala = new SalaDAO().BuscarPorCodigo(int.Parse(resultado.Rows[0]["ID_SALA"].ToString()), pPath);
                        agendaEvento.Data = DateTime.Parse(resultado.Rows[0]["DATA"].ToString());
                        agendaEvento.Hora = resultado.Rows[0]["HORA"].ToString();
                        agendaEvento.ArquivoPalestra = resultado.Rows[0]["FILENAME"].ToString();
                        //evento.Datas = this.DatasEvento();
                        return agendaEvento;
                    }
                }
                return agendaEvento;
            }
        }

        public List<AgendaEvento> BuscaAgendaPorPalestrante(int pPalestrante, string path)
        {
            List<AgendaEvento> agendas = new List<AgendaEvento>();
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(string.IsNullOrEmpty(path) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(path)))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALA_PAL.DBF "))
                {
                    cmd.CommandText += " where ID_PALESTR = @ID_PALESTR";
                    cmd.Parameters.Add("@ID_PALESTR", OleDbType.Numeric).Value = pPalestrante;
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultado.Rows.Count; i++)
                        {
                            AgendaEvento agendaEvento = new AgendaEvento();
                            agendaEvento.Palestrante = new PalestranteDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_PALESTR"].ToString()), path);
                            agendaEvento.Codigo = int.Parse(resultado.Rows[i]["ID"].ToString());
                            agendaEvento.Sala = new SalaDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_SALA"].ToString()), path);
                            agendaEvento.Data = DateTime.Parse(resultado.Rows[i]["DATA"].ToString());
                            agendaEvento.Hora = resultado.Rows[i]["HORA"].ToString();
                            agendaEvento.Tema = resultado.Rows[i]["TEMA"].ToString();
                            agendaEvento.ArquivoPalestra = resultado.Rows[i]["FILENAME"].ToString();
                            agendas.Add(agendaEvento);
                        }
                    }
                }
            }
            return agendas;
        }

        public List<AgendaEvento> BuscaAgendaPorSala(int pSala, string pPath)
        {
            List<AgendaEvento> agendas = new List<AgendaEvento>();
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(String.IsNullOrEmpty(pPath) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(pPath)))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALA_PAL.DBF "))
                {
                    cmd.CommandText += " where ID_SALA = @SALA";
                    cmd.Parameters.Add("@SALA", OleDbType.Numeric).Value = pSala;
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultado.Rows.Count; i++)
                        {
                            AgendaEvento agendaEvento = new AgendaEvento();
                            agendaEvento.Palestrante = new PalestranteDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_PALESTR"].ToString()), String.IsNullOrEmpty(pPath) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(pPath));
                            agendaEvento.Codigo = int.Parse(resultado.Rows[i]["ID"].ToString());
                            agendaEvento.Sala = new SalaDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_SALA"].ToString()), String.IsNullOrEmpty(pPath) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(pPath));
                            agendaEvento.Data = DateTime.Parse(resultado.Rows[i]["DATA"].ToString());
                            agendaEvento.Hora = resultado.Rows[i]["HORA"].ToString();
                            agendaEvento.Tema = resultado.Rows[i]["TEMA"].ToString();
                            agendaEvento.ArquivoPalestra = resultado.Rows[i]["FILENAME"].ToString();
                            agendas.Add(agendaEvento);
                        }
                    }
                }
            }
            return agendas;
        }

        public List<AgendaEvento> ListarTodos()
        {
            List<AgendaEvento> agendas = new List<AgendaEvento>();
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALA_PAL.DBF ORDER BY DATA, HORA"))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultado.Rows.Count; i++)
                        {
                            AgendaEvento agendaEvento = new AgendaEvento();
                            agendaEvento.Palestrante = new PalestranteDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_PALESTR"].ToString()), null);
                            agendaEvento.Codigo = int.Parse(resultado.Rows[i]["ID"].ToString());
                            agendaEvento.Sala = new SalaDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_SALA"].ToString()), null);
                            agendaEvento.Data = DateTime.Parse(resultado.Rows[i]["DATA"].ToString());
                            agendaEvento.Hora = resultado.Rows[i]["HORA"].ToString();
                            agendaEvento.Tema = resultado.Rows[i]["TEMA"].ToString();
                            agendaEvento.ArquivoPalestra = resultado.Rows[i]["FILENAME"].ToString();
                            agendas.Add(agendaEvento);
                        }
                    }
                }
            }
            return agendas;
        }

        public List<AgendaEvento> ListarTodos(int? pCodigoPalestrante, int? pCodigoSala, DateTime? data, string pPath)
        {
            List<AgendaEvento> agendas = new List<AgendaEvento>();
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(String.IsNullOrEmpty(pPath) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(pPath)))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT * FROM SALA_PAL.DBF "))
                {
                    cmd.CommandText += " where 1=1";

                    if (pCodigoPalestrante.HasValue)
                    {
                        cmd.CommandText += " AND ID_PALESTR = @PALEST";
                        cmd.Parameters.Add("@PALEST", OleDbType.Numeric).Value = pCodigoPalestrante;
                    }

                    if (pCodigoSala.HasValue)
                    {
                        cmd.CommandText += " AND ID_SALA = @SALA";
                        cmd.Parameters.Add("@SALA", OleDbType.Numeric).Value = pCodigoSala;
                    }

                    if (data.HasValue)
                    {
                        cmd.CommandText += " AND DATA = @DATA";
                        cmd.Parameters.Add("@DATA", OleDbType.Date).Value = data;
                    }

                    cmd.CommandText += " ORDER BY DATA, HORA";
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultado.Rows.Count; i++)
                        {
                            AgendaEvento agendaEvento = new AgendaEvento();
                            agendaEvento.Palestrante = new PalestranteDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_PALESTR"].ToString()), pPath);
                            agendaEvento.Codigo = int.Parse(resultado.Rows[i]["ID"].ToString());
                            agendaEvento.Sala = new SalaDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_SALA"].ToString()), pPath);
                            agendaEvento.Data = DateTime.Parse(resultado.Rows[i]["DATA"].ToString());
                            agendaEvento.Hora = resultado.Rows[i]["HORA"].ToString();
                            agendaEvento.Tema = resultado.Rows[i]["TEMA"].ToString();
                            agendaEvento.ArquivoPalestra = resultado.Rows[i]["FILENAME"].ToString();
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

                using (OleDbCommand cmd = new OleDbCommand(" SELECT max(ID) FROM SALA_PAL.DBF"))
                {
                    cmd.Connection = oConn;

                    OleDbDataReader r = cmd.ExecuteReader();
                    r.Read();
                    if (!String.IsNullOrEmpty(r[0].ToString()))
                        return int.Parse(r[0].ToString());
                }

                return 0;
            }
        }

        public void Excluir(int pID)
        {
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexao))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(@" DELETE FROM SALA_PAL.DBF WHERE [ID] = " + pID))
                {
                    cmd.Connection = oConn;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Palestrante> ListarPalestrantesEvento(string pathDB)
        {
            List<Palestrante> palestrantes = new List<Palestrante>();
            //Sala usuario = null;
            DataTable resultado = new DataTable();
            using (OleDbConnection oConn = new OleDbConnection(ConexaoSingle.conexaoRemota(pathDB)))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(" SELECT DISTINCT ID_PALESTR FROM SALA_PAL.DBF "))
                {
                    cmd.Connection = oConn;
                    OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

                    DA.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        for (int i = 0; i < resultado.Rows.Count; i++)
                        {
                            Palestrante palestrante = new PalestranteDAO().BuscarPorCodigo(int.Parse(resultado.Rows[i]["ID_PALESTR"].ToString()), pathDB);
                            palestrantes.Add(palestrante);
                        }
                    }
                }
            }
            return palestrantes;
        }

        public void AtualizarArquivoPalestra(int pIDPalestra, string pFileName, string pathDB)
        {
            using (OleDbConnection oConn = new OleDbConnection(String.IsNullOrEmpty(pathDB) ? ConexaoSingle.conexao : ConexaoSingle.conexaoRemota(pathDB)))
            {
                oConn.Open();

                using (OleDbCommand cmd = new OleDbCommand(@" UPDATE SALA_PAL.DBF SET FILENAME = '" + pFileName + "' WHERE [ID] = " + pIDPalestra))
                {
                    cmd.Connection = oConn;
                    cmd.ExecuteNonQuery();
                }
            }
        }

       
    }
}
