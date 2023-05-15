Public Class VendaBLL
    Dim sql As String
    Dim ds, dst As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable

    Public Sub RegistarVenda(vendaDTO As VendaDTO)
        sql = "INSERT INTO venda (cod_venda,nome_cliente, nuit,contacto, total_geral, cancelado, criado, utilizador) VALUES ('" & vendaDTO.Codigo_Venda & "','" & vendaDTO.Nome_Cliente & "', '" & vendaDTO.Nuit & "','" & vendaDTO.Contacto & "', " & vendaDTO.Total_Geral & ", '" & vendaDTO.Cancelado & "','" & vendaDTO.Data & "', 'admin')"
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Sub ActualizarVenda(vendaDTO As VendaDTO)
        sql = "UPDATE venda SET nome_cliente = '" & vendaDTO.Nome_Cliente & "', nuit = '" & vendaDTO.Nuit & "',contacto = '" & vendaDTO.Contacto & "', total_geral = '" & vendaDTO.Total_Geral & "', criado = '" & vendaDTO.Data & "', utilizador = 'admin' WHERE cod_venda = '" & vendaDTO.Codigo_Venda & "'"
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Sub CancelarVD(vendaDTO As VendaDTO)
        sql = "UPDATE venda SET cancelado = 'Sim', nr_nota_credito = '" & vendaDTO.Nr_Nota_Debido & "', criado = '" & vendaDTO.Data & "', alterado = '" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "', utilizador = 'admin' WHERE cod_venda = '" & vendaDTO.Codigo_Venda & "'"
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Function BuscaIDSaida(ByRef data As String)
        sql = "SELECT ID FROM venda where criado like '%" & data & "%'"
        tbl = con.ListarEspecifico(sql)
        Return tbl
    End Function
    Public Function ListarSaidaProduto(data As String)
        sql = "SELECT COUNT(*) FROM venda WHERE criado LIKE '%" & data & "%'"
        con.VerificaSeProduto(sql)
        If existe >= 1 Then
            sql = "SELECT v.cod_venda AS nrvenda, v.nome_cliente cliente, v.nuit nuit, v.contacto contacto, v.total_geral totalgeral, v.cancelado FROM venda v WHERE v.criado LIKE '%" & data & "%' ORDER BY v.cod_venda DESC"
            con.ListarSaidaProduto(sql)
        Else
            frmSaidaProdutos.dgVendaItens.Rows.Clear()
        End If
        Return ds
    End Function
    Public Function ListarVendasProdutoCaixa(data As String)
        sql = "SELECT COUNT(*) FROM venda WHERE criado LIKE '%" & data & "%'"
        con.VerificaSeProduto(sql)
        If existe >= 1 Then
            'sql = "SELECT v.cod_venda AS Nrvenda, v.nome_cliente Cliente, v.nuit Nuit, v.contacto Contacto, v.total_geral 'totalgeral' FROM venda v WHERE v.criado LIKE '%" & data & "%' ORDER BY v.cod_venda DESC"
            sql = "SELECT v.cod_venda AS Nrvenda, v.nome_cliente Cliente, v.nuit Nuit, v.contacto Contacto, v.total_geral 'totalgeral', (select  sum(vi.qtd *(p.preco_venda - p.preco_compra)) as 'Lucro' from venda_itens vi inner join produto p on p.id=vi.produto_id)  as lucrovd  FROM venda v WHERE v.criado LIKE '%" & data & "%' ORDER BY v.cod_venda DESC;
"
            con.ListarVendasProdutoCaixa(sql)
        Else
            frmCaixaDiario.dgListaVendas.Rows.Clear()
        End If
        Return ds
    End Function
    Public Function ListarVendasProdutoCaixaLucro(data As String, nr_vd As String)
        sql = "SELECT COUNT(*) FROM venda WHERE criado LIKE '%" & data & "%'"
        con.VerificaSeProduto(sql)
        If existe >= 1 Then
            'sql = "SELECT v.cod_venda AS Nrvenda, v.nome_cliente Cliente, v.nuit Nuit, v.contacto Contacto, v.total_geral 'totalgeral' FROM venda v WHERE v.criado LIKE '%" & data & "%' ORDER BY v.cod_venda DESC"
            sql = "SELECT v.cod_venda AS Nrvenda, v.nome_cliente Cliente, v.nuit Nuit, v.contacto Contacto, v.total_geral 'totalgeral', (select  sum(vi.qtd *(p.preco_venda - p.preco_compra)) as 'Lucro' from venda_itens vi inner join produto p on p.id=vi.produto_id where vi.cod_venda = '" & nr_vd & "')  as lucrovd  FROM venda v WHERE v.criado LIKE '%" & data & "%' ORDER BY v.cod_venda DESC;
"
            con.ListarVendasProdutoCaixa(sql)
        Else
            frmCaixaDiario.dgListaVendas.Rows.Clear()
        End If
        Return dst
    End Function
    Public Function SelecionaUltimoRegisto()
        sql = "SELECT cod_venda FROM venda order by id desc limit 1"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
