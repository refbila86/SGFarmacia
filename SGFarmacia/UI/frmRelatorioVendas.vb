Imports MySql.Data.MySqlClient
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
        dataInicial = Format(dtpDateFrom.Value, "yyyy-MM-dd")
        dataFinal = Format(dtpDateTo.Value, "yyyy-MM-dd")
    End Sub
    Public Sub ListarSaidaDeProdutos()
        'dgListaVendas.Rows.Clear()
        Try
            ds = vendaBLL.ListaSaidaProduto(txtData.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao trazer as vendas do dia: " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
    End Sub

    Private Sub dgCaixa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCaixa.CellContentClick
        'Dim colName As String = dgCaixa.Columns(e.ColumnIndex).Name
        'If colName = "colDetalhes" Then
        '    txtData.Text = Me.dgCaixa.Rows(e.RowIndex).Cells(0).Value
        '    diaNaGrid = Format(Me.txtData.Text, "yyyy-MM-dd")
        'End If
        'ListarSaidaDeProdutos()

    End Sub
    Private Sub GetLucroEntreDatas()
        Try
            ds = vendas_itensBLL.CalculaLucroEntreDatas(dataInicial, dataFinal)
            SomaTotais()
        Catch ex As Exception
            MsgBox("Erro ao trazer o codigo da categoria - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        GetLucroEntreDatas()
    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        dataInicial = Format(dtpDateFrom.Value, "yyyy-MM-dd")
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        dataFinal = Format(dtpDateTo.Value, "yyyy-MM-dd")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ListarVendasDoDia()
        SomaTotais()
        dataInicial = Format(dtpDateFrom.Value, "yyyy-MM-dd")
        dataFinal = Format(dtpDateTo.Value, "yyyy-MM-dd")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rel As New relVendas

        dataInicial = Format(Me.dtpDateFrom.Value, "yyyy-MM-dd").ToString
        dataFinal = Format(Me.dtpDateTo.Value, "yyyy-MM-dd").ToString

        rel.SummaryInfo.ReportTitle = "Data inicial: " & Format(dpFrom.Value, "yyyy-MM-dd") & " - Data final: " & Format(dpTo.Value, "yyyy-MM-dd")

        Me.CrystalReportViewer1.Enabled = True
        Me.CrystalReportViewer1.ReportSource = "C:\Dados\Relatorios\relVendas.rpt"
        CrystalReportViewer1.SelectionFormula = "{Command.data} >= #" & dataInicial & "# And {Command.data}<= #" & dataFinal & "#"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class