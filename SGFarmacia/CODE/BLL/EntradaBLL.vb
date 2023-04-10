Public Class EntradaBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable
    Public Function VerificaEntrada(entradaDTO As EntradaDTO) As Boolean
        sql = "SELECT COUNT(*) FROM entrada WHERE id = " & entradaDTO.ID & ""
        con.VerificaSeProduto(sql)
        If existe = 1 Then
            VerificaEntrada = True
            sql = "UPDATE entrada SET data = '" & entradaDTO.Data & "', total_gasto  = " & entradaDTO.Total_Gasto & ", total_esperado  = " & entradaDTO.Total_Esperado & " WHERE id= " & entradaDTO.ID & ""
            con.ExecutarComandoSQL(sql)
        Else
            sql = "INSERT INTO entrada (data, total_gasto, total_esperado) VALUES ('" & entradaDTO.Data & "','" & entradaDTO.Total_Gasto & "','" & entradaDTO.Total_Esperado & "')"
            con.ExecutarComandoSQL(sql)
        End If
        Return VerificaEntrada
    End Function
    Public Function BuscaIDEntrada(ByRef data As String)
        sql = "SELECT ID FROM entrada where data like '%" & data & "%'"
        tbl = con.ListarEspecifico(sql)
        Return tbl
    End Function
End Class
