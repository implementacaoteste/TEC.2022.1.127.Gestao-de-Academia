CREATE TRIGGER ATUALIZAR_ESTOQUE
ON ItensCompra
AFTER INSERT
AS
BEGIN
DECLARE @QUANTIDADE INT
DECLARE	@PRODUTOID INT

    SELECT @PRODUTOID = PRODUTOID, @QUANTIDADE = QUANTIDADE FROM inserted

    UPDATE Produto SET QuantidadeEstoque = QuantidadeEstoque + @QUANTIDADE WHERE Id = @PRODUTOID
END

select * from Produto
select * from CompraProduto
select * from ItensCompra

