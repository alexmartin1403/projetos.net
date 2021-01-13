\copy tb_bl_r006_p0_extracao_e_temp from ./INTER/REL_EMISSAO_DIGITALPOST_CTV_15_FEV_15_FEV.csv with  delimiter ';' csv header encoding 'windows-1250';


--a   	DELETE FROM TB_BL_R006_P0_EXTRACAO_TEMP WHERE VALOR_TOTAL IS NULL;

--a	INSERT INTO TB_bl_R006_P0_EXTRACAO (COD_OPERADORA,
--a	NOME_CIDADE,
--a	TIPO,
--a	ID_REGISTRO_EMISSAO,
--a	EMISSAO,
--a	VENCTO,
--a	ORIGEM,
--a	ARQUIVO,
--a	NOME_PARCEIRO,
--a	QTDE_PAGE_TOTAL,
--a	QTDE_COB_TOTAL,
--a	VALOR_TOTAL,
--a    	BASE)
--a   	SELECT COD_OPERADORA,
--a	NOME_CIDADE,
--a	TIPO,
--a	ID_REGISTRO_EMISSAO,
--a	TO_DATE (EMISSAO,'DD MM YY'),
--a	TO_DATE (VENCTO,'DD MM YY'),
--a	ORIGEM,
--a	ARQUIVO,
--a	NOME_PARCEIRO,
--a	QTDE_PAGE_TOTAL,
--a	TO_NUMBER(REPLACE(REPLACE(QTDE_COB_TOTAL,'.',''), ',', '.'),'99999999'),
--a	TO_NUMBER(REPLACE(REPLACE(VALOR_TOTAL,'.',''), ',', '.'),'9999999999.99'),	
--a    	'CTV'
--a	FROM TB_bl_R006_P0_EXTRACAO_TEMP a;




 INSERT INTO TB_BL_R006_P0_EXTRACAO_E (PADRAO,
	NOME_CIDADE,
	COD_OPERADORA,
	ID_REGISTRO_EMISSAO,
	ORIGEM,
	TIPO,
	VENCTO,
	EMISSAO,
	ARQUIVO,
	QTD_PAGE_NET,
	QTDE_PAGE_EMBRATEL,
	QTDE_PAGE_CLARO,
	QTDE_PAGE_TOTAL,
	QTD_COB_NET,
	QTDE_COB_EMBRATEL,
	QTDE_COB_CLARO,
	QTDE_COB_TOTAL,
	VALOR_NET,
	VALOR_EMBRATEL,
	VALOR_CLARO,
	VALOR_TOTAL,
	BASE)
   SELECT PADRAO,
	NOME_CIDADE,
	COD_OPERADORA,
	ID_REGISTRO_EMISSAO,
	ORIGEM,
	TIPO,
	VENCTO,
	EMISSAO,
	ARQUIVO,
	QTD_PAGE_NET,
	QTDE_PAGE_EMBRATEL,
	QTDE_PAGE_CLARO,
	QTDE_PAGE_TOTAL,
	TO_NUMBER(REPLACE(REPLACE(QTD_COB_NET,'.',''), ',', '.'),'99999999'),
	QTDE_COB_EMBRATEL,
	QTDE_COB_CLARO,
	TO_NUMBER(REPLACE(REPLACE(QTDE_COB_TOTAL,'.',''), ',', '.'),'99999999'),
	VALOR_NET,
	VALOR_EMBRATEL,
	VALOR_CLARO,
	TO_NUMBER(REPLACE(REPLACE(VALOR_TOTAL,'.',''), ',', '.'),'99999999999.99'),	
	'CTV'
    FROM TB_BL_R006_P0_EXTRACAO_E_TEMP;


--a truncate table smart_rules_fixa.TB_BL_R006_P0_EXTRACAO_TEMP;

 truncate table smart_rules_fixa.TB_BL_R006_P0_EXTRACAO_E_TEMP;
