Public Class ProdutoStockBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable
    Public Function VerificaExistenciaProduto(produtoStockDTO As ProdutoStockDTO) As Boolean
        sql = "SELECT COUNT(*) FROM produto_stock WHERE produto_id = " & produtoStockDTO.PRoduto_id & ""
        con.VerificaSeProduto(sql)
        If existe = 1 Then
            VerificaExistenciaProduto = True
            sql = "UPDATE produto_stock SET stock_actual  = stock_actual + " & produtoStockDTO.Stock_Actual & " WHERE produto_id= " & produtoStockDTO.PRoduto_id & ""
            con.ExecutarComandoSQL(sql)
        Else
            sql = "INSERT INTO produto_stock (produto_id, stock_actual) VALUES (" & produtoStockDTO.PRoduto_id & "," & produtoStockDTO.Stock_Actual & ")"
            con.ExecutarComandoSQL(sql)
        End If
        Return VerificaExistenciaProduto
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
    Public Function ConsultaDesignacao()
        sql = "SELECT designacao FROM Categoria"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
