--troca de tabela e formata o total
insert into smart_rules_fixa.tb_bl_r002_p0_tb_bases
(
    operadora,
    tipo_cobranca,
    dt_vencto,
    dt_geracao,
    qtd_cob,
    total_r,
    cod_operadora,
    base,
    dia_vencto
)
select  operadora,
    tipo_cobranca,
    to_date(dt_vencto, 'DD MM YY'),
    to_date(dt_geracao, 'DD MM YY'),
    to_number(qtd_cob,'99999999'),
    to_number(total_r,'999999999999.99'),
    to_number(cod_operadora,'99999999'),
    base,
    to_number(dia_vencto,'99999999')
	from smart_rules_fixa.tb_bl_r002_p0_tb_bases_temp;

truncate table smart_rules_fixa.tb_bl_r002_p0_tb_bases_temp;


--seleciona colunas e deleta linhas duplicadas
DELETE
  from smart_rules_fixa.tb_bl_r002_p0_tb_bases a
 where ctid not in (select max(ctid)
                       from smart_rules_fixa.tb_bl_r002_p0_tb_bases b
                      group by b.operadora,b.tipo_cobranca,b.dt_vencto,b.dt_geracao,b.qtd_cob,total_r,b.cod_operadora,b.base,b.dia_vencto);

drop table if exists TB_BL_R002_P1_TB_TEMP;

create table TB_BL_R002_P1_TB_TEMP as 
		select base, operadora,tipo_cobranca,
		cast( dia_vencto || '/' ||to_char(dt_geracao + INTERVAL '1 month','mm/yyyy') as date)
		as dt_vencto2,dt_geracao,qtd_cob,total_r,cod_operadora,dia_vencto
                from TB_BL_R002_P0_TB_BASES; 


drop table if exists TB_BL_R002_P1_TB_BASE_SUM;

create table TB_BL_R002_P1_TB_BASE_SUM as 
select base,operadora, tipo_cobranca, dt_vencto2 as dt_vencto, SUM(qtd_cob) as qtd, sum(total_r) as total,dia_vencto  from  TB_BL_R002_P1_TB_TEMP
group by  base,operadora, tipo_cobranca, dt_vencto2, dia_vencto  order by operadora;

truncate table smart_rules_fixa.TB_BL_R002_P1_TB_TEMP;

