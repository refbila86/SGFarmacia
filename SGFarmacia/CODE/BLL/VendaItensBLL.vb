﻿Public Class VendaItensBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable

    Public Sub RegistarItensVenda(vendaItens As VendaItensDTO)
        sql = "INSERT INTO venda_itens (artigo, cod_venda,produto_id, qtd,preco_unitario, total_unitario, desconto, data) VALUES ('" & vendaItens.Artigo & "','" & vendaItens.Cod_Venda & "'," & vendaItens.Produto_ID & ", " & vendaItens.Qtd & "," & vendaItens.Preco_Unitario & ", " & vendaItens.Total_Unitario & ", " & vendaItens.Desconto & ", '" & vendaItens.Data & "')"
        con.ExecutarComandoSQL(sql)
    End Sub

    Public Sub RemoverItensVenda(nrVenda As String)
        sql = "DELETE FROM venda_itens WHERE cod_venda= '" & nrVenda & "'"
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
    Public Function ConsultarDetalhesVendaDiario(ByRef nrVenda As String)
        con.ConnectarMySql()
        'sql = "select vi.artigo artigo,vi.produto_id produtoid, p.designacao designacao, vi.preco_unitario precounitario, vi.qtd qtd, vi.desconto desconto, vi.total_unitario totalunitario from venda_itens vi
        '       inner join produto p on p.id=vi.produto_id 
        '       where vi.cod_venda = '" & nrVenda & "'"
        sql = "select vi.artigo artigo,vi.produto_id produtoid, p.designacao designacao, vi.preco_unitario precounitario, vi.qtd qtd, vi.total_unitario totalunitario, p.preco_compra, p.preco_venda - p.preco_compra as lucro, vi.qtd *(p.preco_venda - p.preco_compra) as 'Lucro total' 
               from venda_itens vi
               inner join produto p on p.id=vi.produto_id 
               where vi.cod_venda = '" & nrVenda & "'"
        con.ListarDetalhesDaVendaDiario(sql)
        Return ds
    End Function
    Public Function ConsultarDetalhesNota(ByRef nrVenda As String)
        con.ConnectarMySql()
        sql = "select vi.artigo artigo,vi.produto_id produtoid, p.designacao designacao, vi.preco_unitario precounitario, vi.qtd qtd, vi.desconto desconto, vi.total_unitario totalunitario from nota_credito vi
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
    Public Function CalculaLucroDia(ByRef data As String)
        sql = "SELECT vi.data AS 'data', sum((vi.qtd * (p.preco_venda - p.preco_compra))) AS lucro
                FROM
                    venda_itens vi
                        INNER JOIN
                    produto p ON p.id = vi.produto_id
                WHERE
                    vi.data LIKE '%" & data & "%'
                GROUP BY date(vi.data)"
        tbl = con.ListarEspecifico(sql)
        Return tbl
    End Function
    Public Function CalculaLucrosEntreDatas(dataInicial As String, dataFinal As String)
        sql = "SELECT vi.data AS 'data', sum((vi.qtd * (p.preco_venda - p.preco_compra))) AS 'lucro_dia'
                FROM
                    venda_itens vi
                        INNER JOIN
                    produto p ON p.id = vi.produto_id
                WHERE
                    vi.data >= '" & dataInicial & "' AND vi.data<='" & dataFinal & "'
                GROUP BY date(vi.data)"
        tbl = con.ListarEspecifico(sql)
        Return tbl
    End Function
    Public Function CalculaLucroEntreDatas(dataInicial As String, dataFinal As String)
        sql = "SELECT criado as 'data', valor_dia as 'total_unitario', lucro_dia from caixa where criado >='" & dataInicial & "' AND criado <='" & dataFinal & "'"
        con.ListarSaldosEntreData(sql)
        Return ds
    End Function
End Class
