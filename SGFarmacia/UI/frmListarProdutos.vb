Public Class frmListarProdutos
    Dim sql As String
    Dim ds, dst As New DataSet
    Dim tbl As New DataTable
    Dim categoriaBLL As New CategoriaBLL
    Dim produtoBLL As New ProdutoBLL
    Dim produtoDTO As New ProdutoDTO
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Sub ColorirGrid()

        Dim diasrestantes As Integer = 1
        On Error Resume Next
        Dim dt As String
        'Dim valor As Integer
        'For k As Integer = 0 To dgListaFuncionarios.Rows.Count - 1
        '    dt = dgListaFuncionarios.Rows(k).Cells("stockactual").Value.ToString
        '    If dt = "" Or dt = "0" Then
        '        dgListaFuncionarios.Rows(k).DefaultCellStyle.ForeColor = Color.Green
        '    Else
        '        dgListaFuncionarios.Rows(k).DefaultCellStyle.ForeColor = Color.Black

        '    End If
        'Next

        For Each Linha As DataGridViewRow In Me.dgListaFuncionarios.Rows

            If Linha.Cells(4).Value = "0" Or Linha.Cells(4).Value = "" Then ' Tua coluna Situação(2)
                Linha.Cells(4).Style.BackColor = Color.Yellow ' Tua coluna Status(4)
            End If

            If Linha.Cells(10).Value < 0 Then ' Tua coluna Situação(2)
                Linha.Cells(4).Style.BackColor = Color.Red  ' Tua coluna Status(4)

            End If
        Next




        'For i As Integer = 0 To dgListaFuncionarios.Rows.Count - 1
        '    diasrestantes = dgListaFuncionarios.Rows(i).Cells("diasrestantes").Value.ToString
        '    If diasrestantes <= 0 Then
        '        dgListaFuncionarios.Rows(i).DefaultCellStyle.ForeColor = Color.Black
        '    ElseIf diasrestantes > 0 And diasrestantes <= 10 Then
        '        dgListaFuncionarios.Rows(i).DefaultCellStyle.ForeColor = Color.HotPink
        '    Else
        '        dgListaFuncionarios.Rows(i).DefaultCellStyle.ForeColor = Color.Black

        '    End If
        'Next

    End Sub
    Sub calculadiferenca()
        'Static t_inicio As DateTime
        'Static t_fim As DateTime
        'Dim t_diferenca As TimeSpan

        'If btnMedir.Text = "Iniciar" Then
        '    lblDiferenca.Text = ""
        '    t_inicio = Now
        '    btnMedir.Text = "Parar"
        'Else
        '    t_fim = Now
        '    t_diferenca = t_fim.Subtract(t_inicio)
        '    lblDiferenca.Text = t_diferenca.TotalSeconds.ToString("0.000000") & " segundos"
        '    btnMedir.Text = "Iniciar"
        'End If
    End Sub
    Private Sub frmListarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarProdutos()
        ColorirGrid()
        'txtResultado2.Text += DateDiff(DateInterval.Day, dtini, dtfim).ToString + "  Dias" + vbCrLf
    End Sub
    'ListarProdutosDentroDoPrazo
    Public Sub ListarProdutosDentroDoPrazo()
        Try
            ds = produtoBLL.ListarProdutosDentroDoPrazo
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao popular a grid " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
    End Sub
    Public Sub ListarProdutos()
        Try
            ds = produtoBLL.ListarProdutos
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao popular a grid " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
    End Sub
    Public Sub ListarProdutosPorStock()
        Try
            ds = produtoBLL.ListarProdutosPorStock()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao popular a grid " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
    End Sub
    Public Sub ListarProdutosComStockMinimo()
        Try
            ds = produtoBLL.ListarProdutosComStockMinimo()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao popular a grid " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
    End Sub
    Public Sub ListarProdutosVencidos()
        Try
            ds = produtoBLL.ListarProdutosVencidos()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao popular a grid " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub dgListaFuncionarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaFuncionarios.CellContentClick
        Dim colName As String = dgListaFuncionarios.Columns(e.ColumnIndex).Name
        If colName = "colRemover" Then
            If MsgBox("Tem certeza que deseja remover o item: " & Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(1).Value.ToString & "?", MsgBoxStyle.YesNo + vbQuestion, "Remover colaborador") = MsgBoxResult.Yes Then
                produtoBLL.RemoverProduto(Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(0).Value.ToString.ToUpper)
                dgListaFuncionarios.Rows.RemoveAt(CInt(dgListaFuncionarios.CurrentRow.Index))
            End If
        ElseIf colName = "colEditar" Then
            acao = "Editar"
            produto_id = Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(0).Value.ToString
            frmCadastrarProduto.txtID.Text = Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(0).Value.ToString
            frmCadastrarProduto.txtDesignacao.Text = Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(1).Value.ToString
            frmCadastrarProduto.txtNomeGenerico.Text = Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(2).Value.ToString
            frmCadastrarProduto.cboCategoria.Text = Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(3).Value.ToString
            frmCadastrarProduto.txtPrecoCompra.Text = Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(5).Value.ToString
            frmCadastrarProduto.txtPrecoVenda.Text = Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(6).Value.ToString
            frmCadastrarProduto.txtQtdCaixa.Text = Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(7).Value.ToString
            frmCadastrarProduto.cboPaisOrigem.Text = Me.dgListaFuncionarios.Rows(e.RowIndex).Cells(9).Value.ToString

            frmCadastrarProduto.btnNovo.Visible = False
            frmCadastrarProduto.btnRegistar.Visible = True
            frmCadastrarProduto.ShowDialog()
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Me.cboFiltro.Text
            Case "Sem stock"
                ListarProdutosPorStock()
            Case "Stock minimo"
                ListarProdutosComStockMinimo()
            Case "Fora do prazo"
                ListarProdutosVencidos()
            Case "Todos"
                ListarProdutos()
            Case "Dentro do prazo"
                ListarProdutosDentroDoPrazo()
        End Select
        ColorirGrid()
    End Sub

    Private Sub cboFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFiltro.SelectedIndexChanged

    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        frmRelProdutos.CrystalReportViewer1.Enabled = True
        frmRelProdutos.CrystalReportViewer1.ReportSource = "C:\Dados\Relatorios\relProdutos.rpt"
        ' frmRelProdutos.CrystalReportViewer1.SelectionFormula = "{Command.cod_venda} =  '" & Me.txtNrVenda.Text & "'"
        frmRelProdutos.CrystalReportViewer1.Refresh()
        frmRelProdutos.CrystalReportViewer1.RefreshReport() '" & Me.txtNumFct.Text & "'"
        frmRelProdutos.ShowDialog()
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        acao = "Novo"
        frmCadastrarProduto.btnRegistar.Text = "Registar o produto"
        frmCadastrarProduto.btnNovo.Visible = False
        frmCadastrarProduto.btnRegistar.Visible = True
        frmCadastrarProduto.txtID.Text = ""
        frmCadastrarProduto.txtDesignacao.Text = ""
        frmCadastrarProduto.txtNomeGenerico.Text = ""
        frmCadastrarProduto.cboCategoria.Text = ""
        frmCadastrarProduto.txtPrecoCompra.Text = ""
        frmCadastrarProduto.txtPrecoVenda.Text = ""
        frmCadastrarProduto.txtQtdCaixa.Text = ""
        frmCadastrarProduto.dpValidade.Text = ""
        frmCadastrarProduto.cboPaisOrigem.Text = ""
        frmCadastrarProduto.txtPrecoVenda.Text = ""
        frmCadastrarProduto.txtDesignacao.Focus()
        frmCadastrarProduto.ShowDialog()

    End Sub
End Class