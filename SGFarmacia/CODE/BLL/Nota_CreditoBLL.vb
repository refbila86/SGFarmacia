Public Class Nota_CreditoBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable

    Public Sub RegistarNotaCredito(nota_creditoDTO As Nota_CreditoDTO)
        sql = "INSERT INTO nota_credito (cod_venda,nome_cliente, nuit,contacto, total_geral, vd_referencia, motivo, criado, utilizador) VALUES ('" & nota_creditoDTO.Codigo_Venda & "','" & nota_creditoDTO.Nome_Cliente & "', '" & nota_creditoDTO.Nuit & "','" & nota_creditoDTO.Contacto & "', " & nota_creditoDTO.Total_Geral & ", '" & nota_creditoDTO.VD_Referencia & "', '" & nota_creditoDTO.Motivo & "','" & nota_creditoDTO.Data & "', 'admin')"
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Sub ActualizarNotaCredito(nota_creditoDTO As Nota_CreditoDTO)
        sql = "UPDATE nota_credito SET nome_cliente = '" & nota_creditoDTO.Nome_Cliente & "', nuit = '" & nota_creditoDTO.Nuit & "',contacto = '" & nota_creditoDTO.Contacto & "', total_geral = '" & nota_creditoDTO.Total_Geral & "',  criado = '" & nota_creditoDTO.Data & "', utilizador = 'admin' WHERE cod_venda = '" & nota_creditoDTO.Codigo_Venda & "'"
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Function BuscaVDReferencia_Nota(ByRef nrVenda As String)
        sql = "SELECT cod_venda FROM nota_credito where vd_referencia like '" & nrVenda & "'"
        tbl = con.ListarEspecifico(sql)
        Return tbl
    End Function
    Public Function BuscaIDNota(ByRef data As String)
        sql = "SELECT ID FROM nota_credito where criado like '%" & data & "%'"
        tbl = con.ListarEspecifico(sql)
        Return tbl
    End Function
    Public Function ListarNota_CreditoProduto(data As String)
        sql = "SELECT COUNT(*) FROM nota_credito WHERE criado LIKE '%" & data & "%'"
        con.VerificaSeProduto(sql)
        If existe >= 1 Then
            sql = "SELECT v.cod_venda AS nrNota, v.nome_cliente cliente, v.nuit nuit, v.contacto contacto, v.total_geral totalgeral, v.vd_referencia, v.motivo FROM nota_credito v WHERE v.criado LIKE '%" & data & "%'"
            con.ListarNotaCreditoSaidaProduto(sql)
        Else
            'frmSaidaProdutos.dgVendaItens.Rows.Clear()
        End If
        Return ds
    End Function
    Public Function SelecionaUltimoRegistoNotaCredito()
        sql = "SELECT cod_venda FROM nota_credito order by id desc limit 1"
        ds = con.Listar(sql)
        Return ds
    End Function
End Class
