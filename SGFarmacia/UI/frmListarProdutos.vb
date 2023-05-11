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
        ' On Error Resume Next
        Dim dt As String
        'Dim valor As Integer
        For i As Integer = 0 To dgListaFuncionarios.Rows.Count - 1
            dt = dgListaFuncionarios.Rows(i).Cells("stockactual").Value.ToString
            If dt = "" Or dt = "0" Then
                dgListaFuncionarios.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            Else
                dgListaFuncionarios.Rows(i).DefaultCellStyle.ForeColor = Color.DarkGreen
            End If
        Next

        For i As Integer = 0 To dgListaFuncionarios.Rows.Count - 1
            diasrestantes = dgListaFuncionarios.Rows(i).Cells("diasrestantes").Value.ToString
            If diasrestantes <= 0 Then
                dgListaFuncionarios.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            ElseIf diasrestantes > 0 And diasrestantes <= 10 Then
                dgListaFuncionarios.Rows(i).DefaultCellStyle.ForeColor = Color.HotPink
            Else
                dgListaFuncionarios.Rows(i).DefaultCellStyle.ForeColor = Color.Black

            End If
        Next

    End Sub
    Sub calculadiferenca()
        Static t_inicio As DateTime
        Static t_fim As DateTime
        Dim t_diferenca As TimeSpan

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
    Public Sub ListarProdutos()
        Try
            ds = produtoBLL.ListarProdutos
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