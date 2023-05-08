Public Class Nota_CreditoItensBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable

    Public Sub RegistarItensNotaCredito(notaCreditoItensDTO As Nota_CreditoItensDTO)
        sql = "INSERT INTO nota_credito_itens (artigo, cod_venda,produto_id, qtd,preco_unitario, total_unitario, desconto, data) VALUES ('" & notaCreditoItensDTO.Artigo & "','" & notaCreditoItensDTO.Cod_Venda & "'," & notaCreditoItensDTO.Produto_ID & ", " & notaCreditoItensDTO.Qtd & "," & notaCreditoItensDTO.Preco_Unitario & ", " & notaCreditoItensDTO.Total_Unitario & ", " & notaCreditoItensDTO.Desconto & ", '" & notaCreditoItensDTO.Data & "')"
        con.ExecutarComandoSQL(sql)
    End Sub

    Public Sub RemoverItensVenda(nrVenda As String)
        sql = "DELETE FROM nota_credito_itens WHERE cod_venda= '" & nrVenda & "'"
        con.ExecutarComandoSQL(sql)
    End Sub
    '    'ListarItensDaVenda
    Public Function ConsultarDetalhesNota(ByRef nrNota As String)
        con.ConnectarMySql()
        sql = "select vi.artigo artigo,vi.produto_id produtoid, p.designacao designacao, vi.preco_unitario precounitario, vi.qtd qtd, vi.desconto desconto, vi.total_unitario totalunitario from nota_credito_itens vi
               inner join produto p on p.id=vi.produto_id 
               where vi.cod_venda = '" & nrNota & "'"
        con.ListarDetalhesDaVenda(sql)
        Return ds
    End Function
End Class
