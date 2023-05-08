Public Class Produto_EntradaBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable
    Public Function VerificaDataEntradaProduto(produtoEntradaDTO As Produto_EntradaDTO) As Boolean
        sql = "SELECT COUNT(*) FROM entrada WHERE data = " & produtoEntradaDTO.Data_Entrada & ""
        con.VerificaSeProduto(sql)
        Return VerificaDataEntradaProduto
    End Function


    Public Function VerificaEntradaProduto(produtoEntradaDTO As Produto_EntradaDTO) As Boolean
        sql = "SELECT COUNT(*) FROM entrada_produto WHERE produto_id = " & produtoEntradaDTO.Produto_ID & " and criado like '" & produtoEntradaDTO.Criado & "'"
        con.VerificaSeProduto(sql)
        If existe = 1 Then
            VerificaEntradaProduto = True
            sql = "UPDATE produto_entrada SET qtd_introduzir  = qtd_introduzir + " & produtoEntradaDTO.Qtd_Introduzir & ", total_introduzir = total_introduzir + " & produtoEntradaDTO.Total_Introduzir & ", validade = '" & produtoEntradaDTO.Validade & "'  WHERE entrada_id= " & produtoEntradaDTO.Entrada_ID & ""
            con.ExecutarComandoSQL(sql)
        Else
            sql = "INSERT INTO entrada_produto (produto_id, tipo_entrada, origem, qtd_introduzir, total_introduzir, qtd_por_cx, preco_compra, preco_venda, entrada_id, criado) VALUES (" & produtoEntradaDTO.Produto_ID & ",'" & produtoEntradaDTO.Tipo_Entrada & "','" & produtoEntradaDTO.Origem & "'," & produtoEntradaDTO.Qtd_Introduzir & ", " & produtoEntradaDTO.Total_Introduzir & ", " & produtoEntradaDTO.Qtd_Por_Caixa & ", " & produtoEntradaDTO.Preco_Compra & ", " & produtoEntradaDTO.Preco_Venda & ", " & produtoEntradaDTO.Entrada_ID & ", '" & produtoEntradaDTO.Criado & "')"
            con.ExecutarComandoSQL(sql)
        End If
        Return VerificaEntradaProduto
    End Function
    Public Function PesquisarPreco(ByRef produto_id As Integer)
        con.ConnectarMySql()
        sql = "SELECT s.stock_actual FROM produto_stock s INNER JOIN produto p ON p.id=s.produto_id WHERE p.id = " & produto_id & ""
        tbl = con.ListarEspecifico(sql)
        Return tbl

    End Function
    Public Sub ActualizarProduto(produtoStockDTO As ProdutoStockDTO)
        sql = "UPDATE produto_stock SET stock_actual  = stock_actual + " & produtoStockDTO.Stock_Actual & " WHERE produto_id= " & produtoStockDTO.PRoduto_id & ""
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Function ListarEntradaProduto(ByRef entrada_id As Integer)
        sql = "SELECT COUNT(*) FROM entrada WHERE id = " & entrada_id & ""
        con.VerificaSeProduto(sql)
        If existe = 1 Then
            sql = "select e.id, p.designacao, e.tipo_entrada, e.qtd_introduzir, e.total_introduzir, e.qtd_por_cx, e.preco_compra, e.preco_venda from entrada_produto e inner join produto p on p.id=e.produto_id where e.entrada_id = " & entrada_id & ""
            con.ListarEntradaProduto(sql)
        Else
            frmEntradaProdutos.dgEntradaProdutos.Rows.Clear()
        End If
        Return ds
    End Function
End Class
