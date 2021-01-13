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
        //Pega todos os registros menos zerados
        public DataTable GetTodosRegistros()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select base,nome_operadora,codigo_operadora,id_tipo_item_extrato,mes_venc,descricao_item_extrato,tipo_valor,(case when alarme_quantidade = 0 then '•' else '○' end) as Alarme_qtd,(case when alarme_total = 0 then '•' else '○' end) as Alarme_tot,qtd_2_meses_atras,qtd_mes_anterior,qtd_mes_atual, (case when qtd_variacao > 0 then '↑' when qtd_variacao < 0 then '↓' else '→' end) as qtd_var, qtd_variacao, cast((porcentagem_quantidade*100)as numeric (12,2)) as porc_qtd,total_2_meses_atras,total_mes_anterior,total_mes_atual,(case when total_variacao > 0 then '↑' when total_variacao < 0 then '↓' else '→' end) as tot_var, total_variacao,cast((porcentagem_total*100) as numeric(12,2)) as porc_total from smart_rules_fixa.tb_bl_r003_p1_comparacao where tipo_valor <> 'ZERADO' order by base, nome_operadora";

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
        public void AtualizarRegistro(string nbase, string ciclo, string mes, string ano, string por)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {

                    //Aumenta o time out  
                    
                    pgsqlConnection.Open();

                    //Abra a conexão com o PgSQL                  

                    string cmdAtualiza = String.Format("call smart_rules_fixa.sp_r003_p3_xls('" + nbase + "','" + ciclo + "','" + mes + "'," + ano + "," + por + ")"); 

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
                    string cmdSeleciona = "select base,nome_operadora,codigo_operadora,id_tipo_item_extrato,mes_venc,descricao_item_extrato,tipo_valor,alarme_quantidade,alarme_total,qtd_2_meses_atras,qtd_mes_anterior,qtd_mes_atual,qtd_variacao, cast((porcentagem_quantidade*100)as numeric (12,2)) as porc_quant,total_2_meses_atras,total_mes_anterior,total_mes_atual,total_variacao,cast((porcentagem_total*100) as numeric(12,2)) as porc_total from smart_rules_fixa.tb_bl_r003_p1_comp_vazia";

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
        //Atualiza registros de tudo
        public void AtualizarRegistroTudo(string ciclo, string mes, string ano, string por)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {

                    //Aumenta o time out  

                    pgsqlConnection.Open();

                    //Abra a conexão com o PgSQL                  

                    string cmdAtualiza = String.Format("call smart_rules_fixa.sp_r003_p2_xls('" + ciclo + "','" + mes + "'," + ano + "," + por + ")");

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
        //Mostra detalhe
        public DataTable GetDetalhe(string nbase, string ciclo, string mes, int ano, string nomeOper, string codOper, string idTipo, string descIt, string tipoVal, int filtro)
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSelecionaD = "select * from tb_bl_r003_p0_" + nbase +"_"+ ciclo + "_" + mes + ano + "  where ci_nome = '" + nomeOper + "' and cod_operadora = '" + codOper + "' and id_tipo_item_extrato= '" + idTipo + "' and descricao_item_extrato = '" + descIt + "' and tipo_valor = '" + tipoVal + "' and date_part('month', dt_vencto_cobranca) = '" + filtro + "'";

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
        //Pega quantidade itens
        public DataTable GetQuantidadeItens()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select descricao_item_extrato,sum(qtd_2_meses_atras) as qtd_2_meses_atras,sum(qtd_mes_anterior) as qtd_mes_anterior, sum(qtd_mes_atual) as qtd_mes_atual, (case when (sum(qtd_mes_atual) - sum(qtd_mes_anterior)) > 0 then '↑' when (sum(qtd_mes_atual) - sum(qtd_mes_anterior)) < 0 then '↓' else '→' end) as qtd_var, (sum(qtd_mes_atual) - sum(qtd_mes_anterior)) as qtd_variação  from smart_rules_fixa.tb_bl_r003_p1_comparacao group by descricao_item_extrato order by descricao_item_extrato";

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
        //Pega Valor itens
        public DataTable GetValorItens()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select descricao_item_extrato,sum(total_2_meses_atras) as total_2_meses_atras,sum(total_mes_anterior) as total_mes_anterior, sum(total_mes_atual) as total_mes_atual, (case when (sum(total_mes_atual) - sum(total_mes_anterior)) > 0 then '↑' when (sum(total_mes_atual) - sum(total_mes_anterior)) < 0 then '↓' else '→' end) as total_var, (sum(total_mes_atual) - sum(total_mes_anterior)) as total_variação  from smart_rules_fixa.tb_bl_r003_p1_comparacao group by descricao_item_extrato order by descricao_item_extrato";

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
        //Pega todos os registros
        public DataTable GetSoma()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select base, to_char(sum(qtd_2_meses_atras),'999G999G999D99') as qtd_2_meses_atras,to_char(sum(qtd_mes_anterior),'999G999G999D99') as qtd_mes_anterior,to_char(sum(qtd_mes_atual),'999G999G999D99') as qtd_mes_atual, (to_char(sum(qtd_mes_atual - qtd_mes_anterior),'999G999G999D99')) as qtd_variação  ,to_char(sum(total_2_meses_atras),'999G999G999D99') as total_2_meses_atras ,to_char(sum(total_mes_anterior),'999G999G999D99') as total_mes_anterior,to_char(sum(total_mes_atual),'999G999G999D99') as total_mes_atual, (to_char(sum(total_mes_atual - total_mes_anterior),'999G999G999D99')) as total_variação from smart_rules_fixa.tb_bl_r003_p1_comparacao group by base order by base";

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
        //Zeradas
        public DataTable GetZeradas()
        {

            DataTable dt = new DataTable();

            try
            {
                using (pgsqlConnection = new NpgsqlConnection(connString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    pgsqlConnection.Open();
                    string cmdSeleciona = "select base,nome_operadora,codigo_operadora,id_tipo_item_extrato,mes_venc,descricao_item_extrato,tipo_valor,(case when alarme_quantidade = 0 then '•' else '○' end) as Alarme_qtd,qtd_2_meses_atras,qtd_mes_anterior,qtd_mes_atual, (case when qtd_variacao > 0 then '↑' when qtd_variacao < 0 then '↓' else '→' end) as qtd_var, qtd_variacao, cast((porcentagem_quantidade*100)as numeric (12,2)) as porc_qtd from smart_rules_fixa.tb_bl_r003_p1_comparacao where tipo_valor = 'ZERADO' order by base, nome_operadora";

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
