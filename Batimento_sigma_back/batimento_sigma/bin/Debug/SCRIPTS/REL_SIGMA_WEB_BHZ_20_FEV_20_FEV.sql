\copy tb_bl_r006_p0_extracao_temp from ./INTER/REL_SIGMA_WEB_BHZ_20_FEV_20_FEV.csv with  delimiter ';' csv header encoding 'windows-1250';


   	DELETE FROM TB_BL_R006_P0_EXTRACAO_TEMP WHERE VALOR_TOTAL IS NULL;

	INSERT INTO TB_bl_R006_P0_EXTRACAO (COD_OPERADORA,
	NOME_CIDADE,
	TIPO,
	ID_REGISTRO_EMISSAO,
	EMISSAO,
	VENCTO,
	ORIGEM,
	ARQUIVO,
	NOME_PARCEIRO,
	QTDE_PAGE_TOTAL,
	QTDE_COB_TOTAL,
	VALOR_TOTAL,
    	BASE)
   	SELECT COD_OPERADORA,
	NOME_CIDADE,
	TIPO,
	ID_REGISTRO_EMISSAO,
	TO_DATE (EMISSAO,'DD MM YY'),
	TO_DATE (VENCTO,'DD MM YY'),
	ORIGEM,
	ARQUIVO,
	NOME_PARCEIRO,
	QTDE_PAGE_TOTAL,
	TO_NUMBER(REPLACE(REPLACE(QTDE_COB_TOTAL,'.',''), ',', '.'),'99999999'),
	TO_NUMBER(REPLACE(REPLACE(VALOR_TOTAL,'.',''), ',', '.'),'9999999999.99'),	
    	'BHZ'
	FROM TB_bl_R006_P0_EXTRACAO_TEMP a;




--b INSERT INTO TB_BL_R006_P0_EXTRACAO_E (PADRAO,
--b	NOME_CIDADE,
--b	COD_OPERADORA,
--b	ID_REGISTRO_EMISSAO,
--b	ORIGEM,
--b	TIPO,
--b	VENCTO,
--b	EMISSAO,
--b	ARQUIVO,
--b	QTD_PAGE_NET,
--b	QTDE_PAGE_EMBRATEL,
--b	QTDE_PAGE_CLARO,
--b	QTDE_PAGE_TOTAL,
--b	QTD_COB_NET,
--b	QTDE_COB_EMBRATEL,
--b	QTDE_COB_CLARO,
--b	QTDE_COB_TOTAL,
--b	VALOR_NET,
--b	VALOR_EMBRATEL,
--b	VALOR_CLARO,
--b	VALOR_TOTAL,
--b	BASE)
--b   SELECT PADRAO,
--b	NOME_CIDADE,
--b	COD_OPERADORA,
--b	ID_REGISTRO_EMISSAO,
--b	ORIGEM,
--b	TIPO,
--b	VENCTO,
--b	EMISSAO,
--b	ARQUIVO,
--b	QTD_PAGE_NET,
--b	QTDE_PAGE_EMBRATEL,
--b	QTDE_PAGE_CLARO,
--b	QTDE_PAGE_TOTAL,
--b	TO_NUMBER(REPLACE(REPLACE(QTD_COB_NET,'.',''), ',', '.'),'99999999'),
--b	QTDE_COB_EMBRATEL,
--b	QTDE_COB_CLARO,
--b	TO_NUMBER(REPLACE(REPLACE(QTDE_COB_TOTAL,'.',''), ',', '.'),'99999999'),
--b	VALOR_NET,
--b	VALOR_EMBRATEL,
--b	VALOR_CLARO,
--b	TO_NUMBER(REPLACE(REPLACE(VALOR_TOTAL,'.',''), ',', '.'),'99999999999.99'),	
--b	'BHZ'
--b    FROM TB_BL_R006_P0_EXTRACAO_E_TEMP;


 truncate table smart_rules_fixa.TB_BL_R006_P0_EXTRACAO_TEMP;

--b truncate table smart_rules_fixa.TB_BL_R006_P0_EXTRACAO_E_TEMP;
