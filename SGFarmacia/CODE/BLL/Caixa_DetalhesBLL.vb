Public Class Caixa_DetalhesBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable
    Public Sub RegistarItensCaixa(caixaDetalhesDTO As Caixa_DetalhesDTO)
        sql = "INSERT INTO caixa_detalhes (nr_venda, valor_VD,caixa_id) VALUES ('" & caixaDetalhesDTO.Nr_Venda & "'," & caixaDetalhesDTO.Valor_Venda & "," & caixaDetalhesDTO.Caixa_ID & ")"
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Sub RemoverItensCaixa(caixaID As Integer)
        sql = "DELETE FROM caixa_detalhes WHERE caixa_id= " & caixaID & ""
        con.ExecutarComandoSQL(sql)
    End Sub
End Class
