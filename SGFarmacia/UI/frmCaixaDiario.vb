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
    Dim caixaDTO As New CaixaDTO
    Dim caixaBLL As New CaixaBLL
    Dim caixa_detalhesBLL As New Caixa_DetalhesBLL
    Dim caixa_detalhesDTO As New Caixa_DetalhesDTO
    Private Sub frmCaixaDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgListaVendas.Rows.Clear()
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        ListarVendasDoDia()
        GetEstadoCaixa()
        SomaTotais()
        'ColorirGrid()
        saida_id = Nothing
        dataInicial = Format(dtpDateFrom.Value, "yyyy-MM-dd")
        dataFinal = Format(dtpDateTo.Value, "yyyy-MM-dd")
    End Sub
    Private Sub GetIdByDate(ByRef data As String)
        Try
            tbl = caixaBLL.BuscaIDData(mskData.Text)
            If tbl.Rows.Count > 0 Then
                data_id = tbl.Rows(0)(0).ToString()
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o codigo da caixa - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Public Sub ListarCaixaEntreDatas()
        dgListaVendas.Rows.Clear()
        Try
            ds = vendaBLL.ListarCaixaEntreDatas(dataInicial, dataFinal)
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao trazer as vendas do dia: " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
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
        Dim linhas As Integer

        dgListaVendas.Rows.Clear()

        Try
            ds = vendaBLL.ListarVendasProdutoCaixa(mskData.Text)
            linhas = Me.dgListaVendas.Rows.Count
            If linhas >= 1 Then
                pnLucro.Visible = True
            Else
                pnLucro.Visible = False
            End If
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
        GetEstadoCaixa()
        GetLucroDia()
        'pnLucro.Visible = False
        ListarVendasDoDia()
        SomaTotais()
        'Me.pnLucro.Visible = True
        ' GetLucroDia()

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
    'CalculaLucroEntreDatas
    Private Sub GetLucroEntreDatas()
        Try
            tbl = vendas_itensBLL.CalculaLucrosEntreDatas(dataInicial, dataFinal)
            If tbl.Rows.Count > 0 Then
                lucro_dia = tbl.Rows(0)(1).ToString()
                lblLucro.Text = Str(lucro_dia).ToString()
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o codigo da categoria - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Private Sub GetLucroDia()

        Try
            tbl = vendas_itensBLL.CalculaLucroDia(Me.mskData.Text)
            If tbl.Rows.Count > 0 Then
                lucro_dia = tbl.Rows(0)(1).ToString()
                lblLucro.Text = Str(lucro_dia).ToString()
                pnLucro.Visible = True
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o codigo da categoria - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub


    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dgListaVendas.Rows.Clear()
        pnLucro.Visible = False
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        ListarVendasDoDia()
        GetEstadoCaixa()
        SomaTotais()
        'ColorirGrid()
        saida_id = Nothing
        dataInicial = Format(dtpDateFrom.Value, "yyyy-MM-dd")
        dataFinal = Format(dtpDateTo.Value, "yyyy-MM-dd")
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

    Private Sub btnLucroDoDia_Click(sender As Object, e As EventArgs) Handles btnLucroDoDia.Click
        Me.pnLucro.Visible = True
        GetLucroDia()
    End Sub
    Private Sub GetEstadoCaixa()
        lblEstadoCaixa.Text = "Aberto"
        Try
            tbl = caixaBLL.BuscaEstadoCaixa(Me.mskData.Text)
            If tbl.Rows.Count > 0 Then
                estado_caixa = tbl.Rows(0)(4).ToString()
                If estado_caixa = "Sim" Then
                    Me.lblEstadoCaixa.Text = "Fechado"
                Else
                    Me.lblEstadoCaixa.Text = "Aberto"
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o codigo da categoria - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Public Sub GravaItensCaixa()

        For i = 0 To Me.dgListaVendas.Rows.Count - 1
            caixa_detalhesDTO.Nr_Venda = Me.dgListaVendas.Item("nrvenda", i).Value
            caixa_detalhesDTO.Valor_Venda = Me.dgListaVendas.Item("valortotal", i).Value.ToString
            caixa_detalhesDTO.Caixa_ID = data_id
            'caixa_detalhesDTO.Cliente_ID = Me.dgListaVendas.Item("cliente", i).Value.ToString
            caixa_detalhesBLL.RegistarItensCaixa(caixa_detalhesDTO)
        Next
    End Sub
    Private Sub btnFecharCaixa_Click(sender As Object, e As EventArgs) Handles btnFecharCaixa.Click
        If MsgBox("Confirma o fecho para o dia: " & Me.mskData.Text & "?", vbQuestion + vbYesNo, "Confirmação") = MsgBoxResult.Yes Then
            GetLucroDia()
            pnLucro.Visible = False
            Try
                caixaDTO.Valor_dia = Me.txtTotalGeral.Text
                caixaDTO.Lucro_Dia = Me.lblLucro.Text
                caixaDTO.Fechado = "Sim"
                caixaDTO.Nr_Vendas = Me.dgListaVendas.Rows.Count
                caixaDTO.Criado = Me.mskData.Text
                caixaDTO.Utilizador = "admin"
                caixaBLL.GravarSaldosCaixa(caixaDTO)

                GetIdByDate(Me.mskData.Text)

                GravaItensCaixa()
                GetEstadoCaixa()
            Catch ex As Exception
                MsgBox("Ocorreu um erro ao gravar. " & ex.Message, vbCritical, "Erro")
            End Try
        End If



    End Sub

    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        dataInicial = Format(dtpDateFrom.Value, "yyyy-MM-dd")
    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        dataFinal = Format(dtpDateTo.Value, "yyyy-MM-dd")
    End Sub

    Private Sub btnPesquisaEntreDatas_Click(sender As Object, e As EventArgs) Handles btnPesquisaEntreDatas.Click
        lblEstadoCaixa.Text = ""
        dgListaVendas.Rows.Clear()
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        GetLucroEntreDatas()
        ListarCaixaEntreDatas()
        SomaTotais()
    End Sub

    Private Sub mskData_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskData.MaskInputRejected

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        frmrelCaixaDiario.CrystalReportViewer1.Enabled = True
        frmrelCaixaDiario.CrystalReportViewer1.ReportSource = "C:\Dados\Relatorios\relCaixaDiario.rpt"
        frmrelCaixaDiario.CrystalReportViewer1.SelectionFormula = "{Command.criado} =  #" & Me.mskData.Text & "#"
        frmrelCaixaDiario.CrystalReportViewer1.Refresh()
        frmrelCaixaDiario.CrystalReportViewer1.RefreshReport() '" & Me.txtNumFct.Text & "'"
        frmrelCaixaDiario.ShowDialog()
    End Sub

    Private Sub lblLucro_TextChanged(sender As Object, e As EventArgs) Handles lblLucro.TextChanged

    End Sub

    Private Sub mskData_ModifiedChanged(sender As Object, e As EventArgs) Handles mskData.ModifiedChanged

    End Sub
End Class