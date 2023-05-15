Public Class CaixaBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable

    Public Function GravarSaldosCaixa(caixaDTO As CaixaDTO)
        sql = "SELECT COUNT(*) FROM Caixa WHERE criado LIKE '%" & caixaDTO.Criado & "%'"
        con.VerificaSeProduto(sql)
        If existe >= 1 Then
            sql = "UPDATE caixa SET valor_dia=" & caixaDTO.Valor_dia & ", lucro_dia=" & caixaDTO.Lucro_Dia & ", nr_vendas=" & caixaDTO.Nr_Vendas & ", fechado= '" & caixaDTO.Fechado & "', criado='" & caixaDTO.Criado & "', utilizador = '" & caixaDTO.Utilizador & "' WHERE criado = '" & caixaDTO.Criado & "'"

            con.ExecutarComandoSQL(sql)
        Else
            sql = "INSERT INTO caixa (valor_dia, lucro_dia, nr_vendas, fechado, criado, utilizador) VALUES (" & caixaDTO.Valor_dia & ", " & caixaDTO.Lucro_Dia & ", '" & caixaDTO.Nr_Vendas & "','" & caixaDTO.Fechado & "', '" & caixaDTO.Criado & "', '" & caixaDTO.Utilizador & "')"
            con.ExecutarComandoSQL(sql)
        End If
        Return ds
    End Function
    Public Function BuscaEstadoCaixa(ByRef data As String)
        sql = "SELECT * FROM caixa where criado like '%" & data & "%'"
        tbl = con.ListarEspecifico(sql)
        Return tbl
    End Function

    Public Function ConsultarCaixa()
        sql = "SELECT criado, valor_dia, lucro_dia, fechado FROM Caixa order by id desc"
        con.ListarCaixa(sql)
        Return ds
    End Function
End Class
