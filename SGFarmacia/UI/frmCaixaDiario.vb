Public Class frmCaixaDiario
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
    Dim vendas_itensBLL As New VendaItensBLL
    Dim vendas_itensDTO As New VendaItensDTO
    Dim nota_creditoBLL As New Nota_CreditoBLL
    Dim nota_creditoDTO As New Nota_CreditoDTO
    Private Sub frmCaixaDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgListaVendas.Rows.Clear()
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        ListarVendasDoDia()
        SomaTotais()
        'ColorirGrid()
        saida_id = Nothing
    End Sub

    Public Sub SomaTotais()
        On Error Resume Next
        Dim Total As Double = 0 'Uma variavel para cada coluna a ser calculada
        Dim TotalGeral As Double = 0
        Dim desconto As Double = 0

        Dim Multa As Double = 0
        For I As Integer = 0 To Me.dgListaVendas.Rows.Count - 1
            Total += CDbl(dgListaVendas.Rows(I).Cells(4).Value) 'Cells() indica qual célula o valor vai ser pego
        Next
        Me.txtTotalGeral.Text = Total.ToString("C")

    End Sub
    Public Sub ListarVendasDoDia()
        dgListaVendas.Rows.Clear()
        Try
            ds = vendaBLL.ListarVendasProdutoCaixa(mskData.Text)
            'For i = 0 To Me.dgListaVendas.Rows.Count - 1
            '    nr_venda = Me.dgListaVendas.Item("nrvenda", i).Value
            '    ds = vendaBLL.ListarVendasProdutoCaixaLucro(mskData.Text, nr_venda)
            'Next
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao trazer as vendas do dia: " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
        SomaTotais()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        dgListaVendas.Rows.Clear()
        'mskData.Text = Format(Now(), "yyyy-MM-dd")
        ListarVendasDoDia()
        SomaTotais()
        Me.pnLucro.Visible = True
        GetLucroDia()

    End Sub

    Private Sub dgListaVendas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaVendas.CellContentClick
        Dim colName As String = dgListaVendas.Columns(e.ColumnIndex).Name

        Try
            If colName = "colDetalhes" Then
                acao = "Detalhes"

                frmDetalhesCaixaDiario.txtNVenda.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString
                frmDetalhesCaixaDiario.txtNrVenda.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString
                frmDetalhesCaixaDiario.txtCliente.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(1).Value.ToString
                frmDetalhesCaixaDiario.txtNuit.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(2).Value.ToString
                frmDetalhesCaixaDiario.txtContacto.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(3).Value.ToString
                frmDetalhesCaixaDiario.txtNrVenda.Visible = True
                '  frmDetalhesCaixaDiario.txtNVenda = 

            Else
                frmDetalhesCaixaDiario.DesabilitaComponentes()
                frmDetalhesCaixaDiario.txtNrVenda.Visible = True
                frmDetalhesCaixaDiario.lblNrVenda.Visible = True
                frmDetalhesCaixaDiario.txtCodigoNotaCredito.Visible = False
                frmDetalhesCaixaDiario.lblNotaCredito.Visible = False
                frmDetalhesCaixaDiario.btnRegistar.Visible = False
                frmDetalhesCaixaDiario.btnCancelarVenda.Visible = False
            End If
            frmDetalhesCaixaDiario.ShowDialog()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub GetLucroDia()
        Try
            tbl = vendas_itensBLL.CalculaLucroDia(Me.mskData.Text)
            If tbl.Rows.Count > 0 Then
                lucro_dia = tbl.Rows(0)(1).ToString()
                lblLucro.Text = Str(lucro_dia).ToString()
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o codigo da categoria - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, btnLucroDoDia.Click
        Me.pnLucro.Visible = True
        GetLucroDia()
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dgListaVendas.Rows.Clear()
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        ListarVendasDoDia()
        SomaTotais()
    End Sub
    Sub ObterNumeroVD()
        Dim dt As String
        For i As Integer = 0 To dgListaVendas.Rows.Count - 1
            dt = dgListaVendas.Rows(i).Cells("cancelado").Value.ToString
            If dt = "Sim" Then
                dgListaVendas.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub
    Sub teste()
        For i = 0 To Me.dgListaVendas.Rows.Count - 1
            nr_venda = Me.dgListaVendas.Item("cod_venda", i).Value

        Next
    End Sub
    Sub ColorirGrid()
        Dim dt As String
        For i As Integer = 0 To dgListaVendas.Rows.Count - 1
            dt = dgListaVendas.Rows(i).Cells("cancelado").Value.ToString
            If dt = "Sim" Then
                dgListaVendas.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub
End Class