using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace Aplication
{
    class DAL
    {
        static string serverName = "10.90.126.134";                                          //localhost
        static string port = "5433";                                                            //porta default
        static string userName = "smart_fixa";                                               //nome do administrador
        static string password = "Sus1234!@";                                             //senha do administrador
        static string databaseName = "postgres";                                       //nome do banco de dados
        NpgsqlConnection pgsqlConnection = null;
        string connString = null;

        public DAL()
        {
            connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}; Pooling=false; Timeout = 1000; CommandTimeout = 1000",
                serverName, port, userName, password, databaseName);
        }
        //Pega todos os registros
        public DataTable GetTodosRegistros()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "SELECT descricao, to_char(qtde_ant,'999G999') as qtde_ant,to_char( valor_ant, 'L999G999G990D99') as Valor_ant , to_char(qtde_sel,'999G999') as qtde_sel, to_char( valor_sel, 'L999G999G990D99') as Valor_sel FROM smart_rules_fixa.tb_bl_r005_p1_comparacao order by descricao;";


                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        //Atualiza registros
        public void AtualizarRegistro(string ciclo, string nbase, string mes, string ano, Boolean ch)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {

                    //Aumenta o time out  

                    pgsqlConnection.Open();

                    //Abra a conexão com o PgSQL                  

                    string cmdAtualiza = String.Format("call smart_rules_fixa.sp_r005_p2_xls('" + ciclo + "','" + nbase + "','" + mes + "'," + ano + "," + ch + ")");

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdAtualiza, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }
        }
        //Limpa Registros
        public DataTable Vazio()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "SELECT * FROM smart_rules_fixa.tb_bl_r005_p1_comparacao_vazia";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }

        //Mostra detalhe tudo
        public DataTable GetDetalheTudo(string ciclo, string ciclo2, string mes, string ano, string desc, int sel)
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSelecionaD = "select * from tb_bl_r005_p0_extracao where TO_CHAR(DT_VENCTO,'mmyyyy') = to_char(cast( ('01/'||" + mes + "||'/'||" + ano + ") as date)+ INTERVAL '" + sel + " month','MMYYYY') AND JUSTIFICATIVA_AJUSTADA = '" + desc + "' AND (EXTRACT (DAY FROM DT_VENCTO) = " + ciclo + " OR EXTRACT (DAY FROM DT_VENCTO) = " + ciclo2 + ");";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSelecionaD, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        //Mostra detalhe
        public DataTable GetDetalhe(string nBase, string ciclo, string ciclo2, string mes, string ano, string desc, int sel)
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSelecionaD = "select * from tb_bl_r005_p0_extracao where base = '" + nBase + "' and TO_CHAR(DT_VENCTO,'mmyyyy') = to_char(cast( ('01/'||" + mes + "||'/'||" + ano + ") as date)+ INTERVAL '" + sel + " month','MMYYYY') AND JUSTIFICATIVA_AJUSTADA = '" + desc + "' AND (EXTRACT (DAY FROM DT_VENCTO) = " + ciclo + " OR EXTRACT (DAY FROM DT_VENCTO) = " + ciclo2 + ")";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSelecionaD, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        //Mostra detalhe Total Geral
        public DataTable GetDetalheTotal(string nBase, string ciclo, string ciclo2, string mes, string ano, string desc, int sel, Boolean ch)
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSelecionaD = "select * from tb_bl_r005_p0_extracao where (base = '" + nBase + "') and TO_CHAR(DT_VENCTO,'mmyyyy') = to_char(cast( ('01/'||" + mes + "||'/'||" + ano + ") as date)+ INTERVAL '" + sel + " month','MMYYYY') AND (EXTRACT (DAY FROM DT_VENCTO) = " + ciclo + " OR EXTRACT (DAY FROM DT_VENCTO) = " + ciclo2 + ") and justificativa_ajustada <> case when " + ch + " = False then 'AUD_PPPA' else '' END;";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSelecionaD, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        //Mostra detalhe tudo Total
        public DataTable GetDetalheTudoTotal(string ciclo, string ciclo2, string mes, string ano, int sel, Boolean ch)
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSelecionaD = "select * from tb_bl_r005_p0_extracao where TO_CHAR(DT_VENCTO,'mmyyyy') = to_char(cast( ('01/'||" + mes + "||'/'||" + ano + ") as date)+ INTERVAL '" + sel + " month','MMYYYY') AND (EXTRACT (DAY FROM DT_VENCTO) = " + ciclo + " OR EXTRACT (DAY FROM DT_VENCTO) = " + ciclo2 + ")  and justificativa_ajustada <> case when " + ch + " = False then 'AUD_PPPA' else '' END;";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSelecionaD, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        //Mostra detalhe tudo S Total
        public DataTable GetDetalheTudoSTotal(string nBase, string ciclo, string ciclo2, string mes, string ano, int sel, Boolean ch)
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSelecionaD = "select * from tb_bl_r005_p0_extracao where  (base = '" + nBase + "')  and TO_CHAR(DT_VENCTO,'mmyyyy') = to_char(cast( ('01/'||" + mes + "||'/'||" + ano + ") as date)+ INTERVAL '" + sel + " month','MMYYYY') AND (EXTRACT (DAY FROM DT_VENCTO) = " + ciclo + " OR EXTRACT (DAY FROM DT_VENCTO) = " + ciclo2 + ")  and justificativa_ajustada <> case when " + ch + " = False then 'AUD_PPPA' else '' END;";

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSelecionaD, pgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                pgsqlConnection.Close();
            }

            return dt;
        }
        //Gera arquivo saida
        public void GeraArquivo(string ciclo, string ciclo2, string nbase, string mes, string ano, Boolean ch)
        {            
            if (nbase == "TUDO_S_CTV") { nbase = "TSV"; }
            if (nbase == "TUDO") { nbase = "TUD"; }

            DateTime thisDay = DateTime.Now;
            int dseg = thisDay.Second;
            int dminuto = thisDay.Minute;
            string seg = "";
            string min = "";
            if (dminuto <= 9) { min = "0" + Convert.ToString(dminuto); } else { min = Convert.ToString(dminuto); }
            if (dseg <= 9) { seg = "0" + Convert.ToString(dseg); } else { seg = Convert.ToString(dseg); }

            StreamWriter sw = File.CreateText($"//10.90.126.134/smart_rules_claro_fixa/SMART_RULES/05_NAO_FATURADO/ENTRADA/{ciclo}{ciclo2}{nbase}{mes}{ano}{ch}{min}{seg}.temp");
            sw.Close();
            StreamWriter sz = File.CreateText($"//10.90.126.134/smart_rules_claro_fixa/SMART_RULES/05_NAO_FATURADO/ENTRADA/log.txt");
            sz.Close();
            while (!File.Exists($"//10.90.126.134/smart_rules_claro_fixa/SMART_RULES/05_NAO_FATURADO/SAIDA/finalizado.txt"))
            {

            }            
            
            MessageBox.Show($@"O arquivo está disponível na pasta de saída (\\Bcp11w123103\saida5)");
            File.Delete($"//10.90.126.134/smart_rules_claro_fixa/SMART_RULES/05_NAO_FATURADO/SAIDA/finalizado.txt");

        }
    }
}
