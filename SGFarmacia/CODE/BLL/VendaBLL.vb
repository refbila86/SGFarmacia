Public Class VendaBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable

    Public Sub RegistarVenda(vendaDTO As VendaDTO)
        sql = "INSERT INTO venda (cod_venda,nome_cliente, nuit,contacto, total_geral, criado, utilizador) VALUES ('" & vendaDTO.Codigo_Venda & "','" & vendaDTO.Nome_Cliente & "', '" & vendaDTO.Nuit & "','" & vendaDTO.Contacto & "', '" & vendaDTO.Total_Geral & "', '" & vendaDTO.Data & "', 'admin')"
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
            sql = "SELECT v.cod_venda AS nrvenda, v.nome_cliente cliente, v.nuit nuit, v.contacto contacto, v.total_geral totalgeral FROM venda v WHERE v.criado LIKE '%" & data & "%'"
            con.ListarSaidaProduto(sql)
        Else
            frmSaidaProdutos.dgVendaItens.Rows.Clear()
        End If
        Return ds
    End Function
    Public Function SelecionaUltimoRegisto()
        sql = "SELECT cod_venda FROM venda order by id desc limit 1"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
