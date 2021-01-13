DELETE FROM TB_BL_R006_P0_EXTRACAO WHERE TO_CHAR(CURRENT_DATE,'mmyyyy')= TO_CHAR(VENCTO,'mmyyyy')
AND TO_CHAR(EMISSAO,'mmyyyy')= 
to_char(cast( VENCTO as date)+ INTERVAL '-2 month','mmyyyy')
AND (EXTRACT( DAY FROM VENCTO) = 5 OR EXTRACT( DAY FROM VENCTO) = 8 OR
	 EXTRACT( DAY FROM VENCTO) = 10 OR EXTRACT( DAY FROM VENCTO) = 15);

DELETE FROM TB_BL_R006_P0_EXTRACAO WHERE TO_CHAR(CURRENT_DATE,'mmyyyy')= TO_CHAR(VENCTO,'mmyyyy')
AND TO_CHAR(EMISSAO,'mmyyyy')= 
to_char(cast( VENCTO as date)+ INTERVAL '-1 month','mmyyyy')
AND (EXTRACT( DAY FROM VENCTO) = 20 OR EXTRACT( DAY FROM VENCTO) = 25 OR
	 EXTRACT( DAY FROM VENCTO) = 28);

INSERT INTO TB_BL_R006_P1_TOTAL (MES_GERAC,BASE, VENCTO, EMAIL_FATURAS, EMAIL_VALOR_NET,
SIGMA_FATURAS, SIGMA_VALOR_NET)SELECT TO_CHAR(current_date,'mm/yyyy'), BASE, VENCTO,0, 0,0,0
FROM TB_BL_R006_P0_EXTRACAO GROUP BY BASE,VENCTO ORDER BY EXTRACT (DAY FROM VENCTO),
EXTRACT (MONTH FROM VENCTO);
  
with cte as (select b.BASE              as vBase,
                b.vencto                as vVencto,
                SUM(b.QTDE_COB_TOTAL)   as vQtde,
                SUM(b.VALOR_TOTAL)      as vValor                
           from TB_BL_R006_P0_EXTRACAO b
           GROUP BY BASE,VENCTO)
    update TB_BL_R006_P1_TOTAL
       set SIGMA_FATURAS    = cte.vQtde,
           SIGMA_VALOR_NET  = cte.vValor
		from cte
     where base = cte.vBase
     and vencto = cte.vVencto;


with cte as (select b.BASE              as vBase,
                b.vencto                as vVencto,
                SUM(b.QTDE_COB_TOTAL)   as vQtde,
                SUM(b.VALOR_TOTAL)      as vValor                
           from TB_BL_R006_P0_EXTRACAO_E b
           GROUP BY BASE,VENCTO)
    update TB_BL_R006_P1_TOTAL
       set EMAIL_FATURAS    = cte.vQtde,
           EMAIL_VALOR_NET  = cte.vValor
		from cte
     where base = cte.vBase
     and vencto = to_date(cte.vVencto, 'dd mm yy');



update TB_BL_R006_P1_TOTAL set dif_faturas = email_faturas - sigma_faturas where dif_faturas is null ;


update TB_BL_R006_P1_TOTAL set dif_valor_net = email_valor_net - sigma_valor_net where dif_valor_net is null;   


DELETE
  from TB_BL_R006_P1_TOTAL a
 where ctid not in (select max(ctid)
                       from TB_BL_R006_P1_TOTAL b
                      group by 	b.BASE,
				b.VENCTO,
				b.EMAIL_FATURAS,
				b.EMAIL_VALOR_NET,
				b.SIGMA_FATURAS,
				b.SIGMA_VALOR_NET,
				b.DIF_FATURAS,
				b.DIF_VALOR_NET );


truncate table TB_BL_R006_P0_EXTRACAO;

truncate table TB_BL_R006_P0_EXTRACAO_E;

\COPY smart_rules_fixa.TB_BL_R006_P1_TOTAL TO '.\SAIDA\batimento_email_sigma_dtatual.csv' DELIMITER ';' CSV HEADER;

DELETE FROM TB_BL_R006_P1_TOTAL WHERE 70 = (SELECT COUNT(*) FROM TB_BL_R006_P1_TOTAL);
