Public Class frmListarNotasCredito
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
    Dim nota_creditoBLL As New Nota_CreditoBLL

    Private Sub frmListarNotasCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgListaNotasVendas.Rows.Clear()
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        ListarNotasCreditoSaidaDeProdutos()
        saida_id = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgListaNotasVendas.Rows.Clear()
        ' mskData.Text = Format(Now(), "yyyy-MM-dd")
        ListarNotasCreditoSaidaDeProdutos()
        saida_id = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Public Sub ListarNotasCreditoSaidaDeProdutos()
        dgListaNotasVendas.Rows.Clear()
        Try
            ds = nota_creditoBLL.ListarNota_CreditoProduto(mskData.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao trazer as vendas do dia: " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing

        End Try
    End Sub
End Class