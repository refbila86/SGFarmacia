Public Class VendaItensBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable

    Public Sub RegistarItensVenda(vendaItens As VendaItensDTO)
        sql = "INSERT INTO venda_itens (artigo, cod_venda,produto_id, qtd,preco_unitario, total_unitario, desconto) VALUES ('" & vendaItens.Artigo & "','" & vendaItens.Cod_Venda & "'," & vendaItens.Produto_ID & ", " & vendaItens.Qtd & "," & vendaItens.Preco_Unitario & ", " & vendaItens.Total_Unitario & ", " & vendaItens.Desconto & ")"
        con.ExecutarComandoSQL(sql)
    End Sub
    '    'ListarItensDaVenda
    Public Function ConsultarDetalhesVenda(ByRef nrVenda As String)
        con.ConnectarMySql()
        sql = "select vi.artigo artigo,vi.produto_id produtoid, p.designacao designacao, vi.preco_unitario precounitario, vi.qtd qtd, vi.desconto desconto, vi.total_unitario totalunitario from venda_itens vi
               inner join produto p on p.id=vi.produto_id 
               where vi.cod_venda = '" & nrVenda & "'"

        con.ListarDetalhesDaVenda(sql)
        Return ds
    End Function

    Public Function SelecionaUltimoRegisto()
        sql = "SELECT cod_venda FROM venda order by id desc limit 1"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
