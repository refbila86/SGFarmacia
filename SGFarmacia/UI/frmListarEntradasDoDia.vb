Public Class frmListarEntradasDoDia
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
    Private Sub GetIdByDate(ByRef data As String)
        Try
            tbl = entradaBLL.BuscaIDEntrada(data)
            If tbl.Rows.Count > 0 Then
                entrada_id = tbl.Rows(0)(0).ToString()
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o id do dia - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Private Sub frmListarEntradasDoDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgEntradaProdutos.Rows.Clear()
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        GetIdByDate(mskData.Text)
        ListarEntradaDeProdutos()
        SomaTotais()


        entradaDTO.Data = Me.mskData.Text
        entradaDTO.Total_Esperado = Me.txtTotalVenda.Text
        entradaDTO.Total_Gasto = Me.txtTotalCompra.Text
        entradaDTO.ID = entrada_id
        entradaBLL.VerificaEntrada(entradaDTO)

        entrada_id = Nothing




    End Sub
    Public Sub SomaTotais()
        Dim TotalCompra As Double = 0 'Uma variavel para cada coluna a ser calculada
        Dim TotalVenda As Double = 0

        Dim Multa As Double = 0
        For I As Integer = 0 To Me.dgEntradaProdutos.Rows.Count - 1
            TotalCompra += CDbl(dgEntradaProdutos.Rows(I).Cells(7).Value) 'Cells() indica qual célula o valor vai ser pego
            ' TotalVenda += CDbl(dgEntradaProdutos.Rows(I).Cells(8).Value) 'Cells() indica qual célula o valor vai ser pego
        Next
        Me.txtTotalCompra.Text = TotalCompra.ToString("C")
        Me.txtTotalVenda.Text = TotalVenda.ToString("C")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        dgEntradaProdutos.Rows.Clear()
        GetIdByDate(mskData.Text)
        ListarEntradaDeProdutos()
        SomaTotais()
        entrada_id = Nothing
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click, btnStock.Click
        frmEntradaProdutos.txtDesignacao.Clear()
        frmEntradaProdutos.txtPaisOrigem.Clear()
        frmEntradaProdutos.txtPrecoCompra.Clear()
        frmEntradaProdutos.txtPrecoVenda.Clear()
        frmEntradaProdutos.txtQtdCaixa.Clear()
        frmEntradaProdutos.txtQtdIntroduzir.Clear()
        frmEntradaProdutos.txtTotalIntroduzir.Clear()
        frmEntradaProdutos.txtStockActual.Clear()
        frmEntradaProdutos.ShowDialog()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub dgEntradaProdutos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Public Sub ListarEntradaDeProdutos()
        dgEntradaProdutos.Rows.Clear()
        'Dim dataActual As String
        'dataActual = Format(Me.mskData.Text, "yyyy-MM-dd")
        Try
            ds = produtoEntradaBLL.ListarEntradaProduto(entrada_id)
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao popular a grid " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing

        End Try
    End Sub
End Class