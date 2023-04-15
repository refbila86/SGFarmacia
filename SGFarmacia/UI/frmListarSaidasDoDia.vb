Public Class frmListarSaidasDoDia
    Dim sql As String
    Dim ds, dst As New DataSet
    Dim tbl As New DataTable
    'Dim mesBLL As New MesBLL
    'Dim anoBLL As New AnoBLL
    Dim produtoBLL As New ProdutoBLL
    Dim produtoDTO As New ProdutoDTO
    Dim produtoStockBLL As New ProdutoStockBLL
    Dim produtoStockDTO As New ProdutoStockDTO
    Dim produtoEntradaDTO As New Produto_EntradaDTO
    Dim produtoEntradaBLL As New Produto_EntradaBLL
    Dim entradaDTO As New EntradaDTO
    Dim entradaBLL As New EntradaBLL
    Dim vendaBLL As New VendaBLL
    Private Sub frmListarSaidasDoDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgListaVendas.Rows.Clear()
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        ListarSaidaDeProdutos()
        saida_id = Nothing
    End Sub

    Private Sub dgListaVendas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaVendas.CellContentClick
        Dim colName As String = dgListaVendas.Columns(e.ColumnIndex).Name

        Try
            If colName = "colRemover" Then
                If MsgBox("Tem certeza que deseja remover a venda: " & Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString & "?", MsgBoxStyle.YesNo + vbQuestion, "Remover colaborador") = MsgBoxResult.Yes Then
                    dgListaVendas.Rows.RemoveAt(CInt(dgListaVendas.CurrentRow.Index))
                    'produtoStockBLL.AumentarStock(Me.dgVendaItens.Rows(e.RowIndex).Cells(4).Value.ToString, Me.dgVendaItens.Rows(e.RowIndex).Cells(1).Value.ToString)
                    'SomaTotais()
                End If
            ElseIf colName = "colEditar" Then
                acao = "Editar"
                frmSaidaProdutos.txtNrVD.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString
                frmSaidaProdutos.txtNrVenda.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString
                frmSaidaProdutos.txtCliente.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(1).Value.ToString
                frmSaidaProdutos.txtNuit.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(2).Value.ToString
                frmSaidaProdutos.txtContacto.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(3).Value.ToString
                frmSaidaProdutos.chkIncluirCliente.Enabled = False
                frmSaidaProdutos.ShowDialog()
                ' SomaTotais()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        acao = "Novo"
        frmSaidaProdutos.ShowDialog()
    End Sub

    Public Sub ListarSaidaDeProdutos()
        dgListaVendas.Rows.Clear()
        Try
            ds = vendaBLL.ListarSaidaProduto(mskData.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao trazer as vendas do dia: " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing

        End Try
    End Sub
End Class