Public Class frmRelatorioVendas
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
    Dim caixaBLL As New CaixaBLL
    Dim caixaDTO As New CaixaDTO
    Dim vendas_itensBLL As New VendaItensBLL
    Dim vendas_itensDTO As New VendaItensDTO
    Dim nota_creditoBLL As New Nota_CreditoBLL
    Dim nota_creditoDTO As New Nota_CreditoDTO
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Public Sub ListarVendasDoDia()
        dgCaixa.Rows.Clear()
        Try
            ds = caixaBLL.ConsultarCaixa
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao trazer o saldo do caixa: " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
        'SomaTotais()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
    Public Sub SomaTotais()
        On Error Resume Next
        Dim lucro As Double = 0 'Uma variavel para cada coluna a ser calculada
        Dim total As Double = 0
        Dim desconto As Double = 0

        Dim Multa As Double = 0
        For I As Integer = 0 To Me.dgCaixa.Rows.Count - 1
            total += CDbl(dgCaixa.Rows(I).Cells(1).Value) 'Cells() indica qual célula o valor vai ser pego
            lucro += CDbl(dgCaixa.Rows(I).Cells(2).Value)
        Next
        Me.txtLucroTotal.Text = total.ToString("C")
        Me.txtSaldoTotal.Text = lucro.ToString("C")

    End Sub
    Private Sub frmRelatorioVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarVendasDoDia()
        SomaTotais()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class