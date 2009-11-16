/*      
 VIEW VENDAS POR REGIAO E PRODUTO      
*/      
      
CREATE view [dbo].[VW_VENDA_REGIAO_PRODUTO_FATO] as        
select c.CNPJ,c.RAZAOSOCIAL cliente,v.CPF cpf_ven, v.NOME nome_ven,  
  r.DESCRICAO regiao,po.DESCRICAO produto,g.DESCRICAO grupo,DATAEMISSAO As data,      
COUNT(*) as quant_produto, SUM(i.VALOR*QUANTIDADE)valor         
from PEDIDO p inner join ITEMPEDIDO i on p.NRPEDIDO = i.NRPEDIDO        
        inner join PRODUTO po on po.CODPRODUTO = i.CODPRODUTO        
        inner join CLIENTE c on c.CNPJ = p.CODCLIENTE        
        inner join REGIAO r on r.CODREGIAO = c.CODREGIAO        
        inner join GRUPOPRODUTO g on g.CODGRUPOPRODUTO = po.CODGRUPOPRODUTO    
        inner join VENDEDOR v on v.CPF = p.CODVENDEDOR    
              
group by c.CNPJ,c.RAZAOSOCIAL ,v.CPF , v.NOME ,  
  r.DESCRICAO,po.DESCRICAO ,g.DESCRICAO ,DATAEMISSAO      
            
            
 go
 
 CREATE view [dbo].[VW_VENDA_REGIAO_PRODUTO] as          
select  r.DESCRICAO regiao,po.DESCRICAO produto, COUNT(*) as quant_produto       
from PEDIDO p inner join ITEMPEDIDO i on p.NRPEDIDO = i.NRPEDIDO          
        inner join PRODUTO po on po.CODPRODUTO = i.CODPRODUTO          
        inner join CLIENTE c on c.CNPJ = p.CODCLIENTE          
        inner join REGIAO r on r.CODREGIAO = c.CODREGIAO          
        inner join GRUPOPRODUTO g on g.CODGRUPOPRODUTO = po.CODGRUPOPRODUTO      
        inner join VENDEDOR v on v.CPF = p.CODVENDEDOR      
                
group by r.DESCRICAO,po.DESCRICAO        


go


CREATE view dbo.vw_trimestre as      
select cast(floor(CAST(DATAEMISSAO as float)) as datetime) dia ,   COUNT(*)quant from PEDIDO      
where MONTH(DATAEMISSAO) > 9      
group by cast(floor(CAST(DATAEMISSAO as float)) as datetime)