using System;
using System.Data;
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
                    string cmdSeleciona = "SELECT operadora, tipo_cobranca,  (case when alarme_quantidade = 0 then '▼' else '▲' end) as alm_qtd,  (case when alarme_total = 0 then '▼' else '▲' end) as alm_val, to_char(qtd_2_meses_atras,'9G999G999') as qtd_2_mes,to_char(qtd_mes_anterior,'9G999G999') as qtd_mes_ant, to_char(qtd_mes_atual,'9G999G999') as qtd_mes_sel, to_char(qtd_variacao,'9G999G999') as qtd_vari, (case when qtd_variacao > 0 then '↑' when qtd_variacao < 0 then '↓' else '→' end) as qt_vr,  cast (porcentagem_quantidade * 100 as numeric(8,2))||' %' as porc_qtd, to_char( total_2_meses_atras, 'L999G999G990D99') as tot_2_mes ,  to_char( total_mes_anterior, 'L999G999G990D99') as tot_mes_ant ,  to_char( total_mes_atual, 'L999G999G990D99') as tot_mes_sel ,  to_char( total_variacao, 'L999G999G990D99') as tot_vari, (case when total_variacao > 0 then '↑' when total_variacao < 0 then '↓' else '→' end) as tot_var, cast (porcentagem_total * 100 as numeric(8,2))||' %' as porc_tot FROM smart_rules_fixa.tb_bl_r002_p1_comparacao_fim order by operadora, tipo_cobranca;";


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
        public void AtualizarRegistro(string nbase, string ciclo, string mes, string ano, string porc)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {

                    //Aumenta o time out  
                    
                    pgsqlConnection.Open();

                    //Abra a conexão com o PgSQL                  

                    string cmdAtualiza = String.Format("call smart_rules_fixa.sp_r002_p2_xls('" + nbase + "','" + ciclo + "','" + mes + "'," + ano + "," +  porc + ")"); 

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


        //Mostrar totais
        public DataTable MostrarTotais()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "SELECT case when base ='' then 'Total Geral' else base end as base, to_char(sum(qtd_2_meses_atras),'999G999G999') as qtd_2_meses_atras,to_char(sum(qtd_mes_anterior),'999G999G999') as qtd_mes_anterior, to_char(sum(qtd_mes_atual),'999G999G999') as qtd_mes_atual, to_char( sum(total_2_meses_atras), 'L999G999G990D99') as total_2_meses_atras ,  to_char( sum(total_mes_anterior), 'L999G999G990D99') as total_mes_anterior ,  to_char( sum(total_mes_atual), 'L999G999G990D99') as total_mes_atual FROM smart_rules_fixa.tb_bl_r002_p1_comparacao_fim where tipo_cobranca like 'SubTotal%' or tipo_cobranca = '' group by base order by base;";


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



    }
}
