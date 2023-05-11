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
    Dim nota_creditoBLL As New Nota_CreditoBLL
    Dim nota_creditoDTO As New Nota_CreditoDTO
    Private Sub frmListarSaidasDoDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgListaVendas.Rows.Clear()
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        ListarSaidaDeProdutos()
        ColorirGrid()
        saida_id = Nothing
    End Sub
    Private Sub BuscaVDReferencia(ByRef nvVenda As String)
        Try
            tbl = nota_creditoBLL.BuscaVDReferencia_Nota(nvVenda)
            If tbl.Rows.Count > 0 Then
                nr_venda = tbl.Rows(0)(0).ToString()
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o id do dia - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Private Sub dgListaVendas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaVendas.CellContentClick
        Dim colName As String = dgListaVendas.Columns(e.ColumnIndex).Name

        Try
            If colName = "colRemover" Then
                If MsgBox("Tem certeza que deseja remover a venda: " & Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString & "?", MsgBoxStyle.YesNo + vbQuestion, "Remover colaborador") = MsgBoxResult.Yes Then
                    dgListaVendas.Rows.RemoveAt(CInt(dgListaVendas.CurrentRow.Index))
                End If
            ElseIf colName = "colVisualizar" Then
                acao = "Visualizar"

                frmSaidaProdutos.txtNrVD.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString
                frmSaidaProdutos.txtNrVenda.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString
                frmSaidaProdutos.txtCliente.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(1).Value.ToString
                frmSaidaProdutos.txtNuit.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(2).Value.ToString
                frmSaidaProdutos.txtContacto.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(3).Value.ToString

                If Me.dgListaVendas.Rows(e.RowIndex).Cells(5).Value.ToString = "Sim" Then
                    BuscaVDReferencia(Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString)
                    frmSaidaProdutos.DesabilitaComponentes()
                    frmSaidaProdutos.btnCancelarVenda.Visible = True
                    frmSaidaProdutos.txtCodigoNotaCredito.Visible = True
                    frmSaidaProdutos.lblNotaCredito.Visible = True
                    frmSaidaProdutos.txtNrVenda.Visible = True
                    frmSaidaProdutos.lblNrVenda.Visible = True
                    frmSaidaProdutos.btnRegistar.Visible = False
                    frmSaidaProdutos.btnCancelarVenda.Visible = False
                    frmSaidaProdutos.txtCodigoNotaCredito.Text = nr_venda
                Else
                    frmSaidaProdutos.DesabilitaComponentes()
                    frmSaidaProdutos.txtNrVenda.Visible = True
                    frmSaidaProdutos.lblNrVenda.Visible = True
                    frmSaidaProdutos.txtCodigoNotaCredito.Visible = False
                    frmSaidaProdutos.lblNotaCredito.Visible = False
                    frmSaidaProdutos.btnRegistar.Visible = False
                    frmSaidaProdutos.btnCancelarVenda.Visible = False
                End If
                '  frmSaidaProdutos.IncrementaCodigoNotaCredito()
                frmSaidaProdutos.ShowDialog()
                ' SomaTotais()
            ElseIf colName = "colCancelar" Then
                acao = "Cancelar"
                frmSaidaProdutos.txtNrVD.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString
                frmSaidaProdutos.txtNrVenda.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString
                frmSaidaProdutos.txtCliente.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(1).Value.ToString
                frmSaidaProdutos.txtNuit.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(2).Value.ToString
                frmSaidaProdutos.txtContacto.Text = Me.dgListaVendas.Rows(e.RowIndex).Cells(3).Value.ToString
                If Me.dgListaVendas.Rows(e.RowIndex).Cells(5).Value.ToString = "Não" Then
                    frmSaidaProdutos.DesabilitaComponentes()
                    frmSaidaProdutos.txtNrVenda.Visible = True
                    frmSaidaProdutos.lblNrVenda.Visible = True
                    frmSaidaProdutos.mskData.Text = Me.mskData.Text
                    frmSaidaProdutos.txtCodigoNotaCredito.Visible = False
                    frmSaidaProdutos.lblNotaCredito.Visible = False
                    frmSaidaProdutos.btnCancelarVenda.Visible = True
                    frmSaidaProdutos.btnRegistar.Visible = False
                Else
                    BuscaVDReferencia(Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString)
                    MsgBox("A VD: << " & Me.dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString & " >> ja foi cancelada, a sua nota de credito é: " & nr_venda)
                    Exit Sub
                End If
                frmSaidaProdutos.IncrementaCodigoNotaCredito()
                frmSaidaProdutos.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        acao = "Novo"
        'frmSaidaProdutos.txtCliente.Text = "N/A"
        frmSaidaProdutos.mskData.Text = ""
        frmSaidaProdutos.mskData.Enabled = False
        frmSaidaProdutos.txtTotal.Clear()
        frmSaidaProdutos.txtTotalGeral.Clear()
        frmSaidaProdutos.txtTotalDesconto.Clear()
        frmSaidaProdutos.txtCliente.Clear()
        frmSaidaProdutos.txtContacto.Clear()
        frmSaidaProdutos.txtNuit.Clear()
        frmSaidaProdutos.dgVendaItens.Rows.Clear()
        frmSaidaProdutos.HabilitaComponentes()
        frmSaidaProdutos.btnCancelarVenda.Visible = False
        frmSaidaProdutos.btnRegistar.Visible = True
        frmSaidaProdutos.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgListaVendas.Rows.Clear()
        ListarSaidaDeProdutos()
        ColorirGrid()
        saida_id = Nothing
        frmSaidaProdutos.mskData.Text = Me.mskData.Text
        frmSaidaProdutos.mskData.Enabled = False
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
    Sub ColorirGrid()
        Dim dt As String
        For i As Integer = 0 To dgListaVendas.Rows.Count - 1
            dt = dgListaVendas.Rows(i).Cells("cancelado").Value.ToString
            If dt = "Sim" Then
                dgListaVendas.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                'dgListaVendas.Rows(i).
            End If
        Next
    End Sub
    Sub VerificarEstadoVD()
        'Dim dt As String
        'Dim colName As String = dgListaVendas.Columns(e.ColumnIndex).Name
        'For i As Integer = 0 To dgListaVendas.Rows.Count - 1
        '    dt = dgListaVendas.Rows(i).Cells("cancelado").Value.ToString
        '    If dt = "Sim" Then
        '        MsgBox("A vd: " & dgListaVendas.Rows(e.RowIndex).Cells(0).Value.ToString() & "ja foi cancelada"
        '    End If
        'Next
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub mskData_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskData.MaskInputRejected

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dgListaVendas.Rows.Clear()
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        ListarSaidaDeProdutos()
        ColorirGrid()
        saida_id = Nothing
    End Sub

    Private Sub GetIdByDate(ByRef data As String)
        Try
            tbl = vendaBLL.BuscaIDSaida(mskData.Text)
            If tbl.Rows.Count > 0 Then
                entrada_id = tbl.Rows(0)(0).ToString()
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o id do dia - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
End Class