Public Class frmEntradaProdutos
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub dgListaFuncionarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEntradaProdutos.CellContentClick

    End Sub

    Private Sub dgPesquisar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub
    Private Function CalculaStock(ByRef qtd_introduzir As Integer, qtd_caixa As Integer) As Integer
        Dim totalintroduzir As Integer
        If Me.cboTipoEntrada.Text = "Retalho" Then
            totalintroduzir = qtd_introduzir
            CalculaStock = totalintroduzir
        Else
            CalculaStock = qtd_introduzir * qtd_caixa
        End If

        Return CalculaStock
    End Function
    Private Sub txtQtdIntroduzir_TextChanged(sender As Object, e As EventArgs) Handles txtQtdIntroduzir.TextChanged


        If Me.cboTipoEntrada.Text = "" Then
            MsgBox("Indique o tipo de entrada", vbInformation, "Tipo de entrada")
            txtQtdIntroduzir.Text = ""
            Exit Sub
        End If
        If Me.txtQtdIntroduzir.Text = "" Then
            Me.txtTotalIntroduzir.Text = 0
        Else
            Me.txtTotalIntroduzir.Text = CalculaStock(Me.txtQtdIntroduzir.Text, txtQtdCaixa.Text)
        End If
    End Sub
    Private Sub GetIdByDate(ByRef data As String)
        Try
            tbl = entradaBLL.BuscaIDEntrada(data)
            If tbl.Rows.Count > 0 Then
                entrada_id = tbl.Rows(0)(0).ToString()
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o codigo da categoria - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Private Sub btnAdicionaar_Click(sender As Object, e As EventArgs) Handles btnAdicionaar.Click

    End Sub
    Private Sub GetPriceByProdutID(ByRef ID As Integer)
        Try
            tbl = produtoStockBLL.PesquisarPreco(ID)
            If tbl.Rows.Count > 0 Then
                txtStockActual.Text = tbl.Rows(0)(0).ToString()
                'txtStockActual.Text = stock_actual
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o stock actual - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        If Me.txtID.Text <> "" Then
            GetPriceByProdutID(Me.txtID.Text)
        Else
            Exit Sub
        End If

    End Sub
    Public Sub ListarEntradaDeProdutos()
        dgEntradaProdutos.Rows.Clear()
        Dim dataActual As String
        dataActual = Format(Me.dpData.Value, "yyyy-MM-dd")
        Try
            ds = produtoEntradaBLL.ListarEntradaProduto(entrada_id)
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao popular a grid " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing

        End Try
    End Sub
    Private Sub frmEntradaProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim dataActual As String
        dgEntradaProdutos.Rows.Clear()
        'dataActual = Format(Now(), "yyyy-MM-dd")
        mskData.Text = Format(Now(), "yyyy-MM-dd")
        GetIdByDate(mskData.Text)
        ListarEntradaDeProdutos()
        entrada_id = Nothing
    End Sub

    Private Sub dpData_ValueChanged(sender As Object, e As EventArgs) Handles dpData.ValueChanged
        'dgEntradaProdutos.Rows.Clear()
        'Dim dataActual As String
        'dataActual = Format(Me.dpData.Value, "yyyy-MM-dd")
        'GetIdByDate(dataActual)
        'ListarEntradaDeProdutos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgEntradaProdutos.Rows.Clear()
        GetIdByDate(mskData.Text)
        ListarEntradaDeProdutos()
        entrada_id = Nothing
    End Sub

    Private Sub mskData_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskData.MaskInputRejected
        'Dim dataActual As String
        'dgEntradaProdutos.Rows.Clear()
        'dataActual = Format(Now(), "yyyy-MM-dd")
        'mskData.Text = dataActual
        'GetIdByDate(dataActual)
        'ListarEntradaDeProdutos()
    End Sub

    Private Sub txtDesignacao_TextChanged(sender As Object, e As EventArgs) Handles txtDesignacao.TextChanged
        'Me.txtID.Clear()
        'Me.txtStockActual.Clear()

        If Me.txtDesignacao.Text <> "" Then

            Try
                Me.pnPesquisar.Visible = True
                ds = produtoBLL.PesquisarProduto(Me.txtDesignacao.Text)
            Catch ex As Exception
                MsgBox("Não foi possivel os dados do funcionario", MsgBoxStyle.Critical, "ERRO")
            End Try

        Else
            Me.pnPesquisar.Visible = False
            Me.txtID.Text = ""
            Me.txtDesignacao.Text = ""
            Me.txtPaisOrigem.Text = ""
            Me.txtPrecoVenda.Text = ""
            Me.txtPrecoCompra.Text = ""
            Me.txtQtdCaixa.Text = ""
        End If



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        Dim data As String
        frmListarEntradasDoDia.SomaTotais()
        data = Format(Me.dpData.Value, "yyyy-MM-dd ")
        Try
            If MsgBox("Confirma a entrada do produto: " & Me.txtDesignacao.Text & "?", vbQuestion + vbYesNo, "Confirmação") = MsgBoxResult.Yes Then

                If Format(dpValidade.Value, "yyyy-MM-dd") = Format(Now, "yyyy-MM-dd") Then
                    MsgBox("Verifique o prazo de validade!!", vbCritical, "Validade")
                    Exit Sub
                Else
                    produtoEntradaDTO.Validade = Format(dpValidade.Value, "yyyy-MM-dd")
                End If

                produtoStockDTO.Stock_Actual = Me.txtTotalIntroduzir.Text
                produtoStockDTO.PRoduto_id = Me.txtID.Text
                produtoStockBLL.VerificaExistenciaProduto(produtoStockDTO)

                entradaDTO.Data = Me.mskData.Text
                entradaDTO.Total_Esperado = frmListarEntradasDoDia.txtTotalVenda.Text
                entradaDTO.Total_Gasto = frmListarEntradasDoDia.txtTotalCompra.Text
                GetIdByDate(Me.mskData.Text)
                entradaDTO.ID = entrada_id
                entradaBLL.VerificaEntrada(entradaDTO)

                If Me.cboTipoEntrada.Text = "Grosso" Then
                    produtoEntradaDTO.Tipo_Entrada = Me.cboTipoEntrada.Text
                    produtoEntradaDTO.Qtd_Introduzir = Me.txtQtdIntroduzir.Text
                    produtoEntradaDTO.Total_Introduzir = Me.txtTotalIntroduzir.Text
                Else
                    produtoEntradaDTO.Tipo_Entrada = Me.cboTipoEntrada.Text
                    produtoEntradaDTO.Qtd_Introduzir = 0
                    produtoEntradaDTO.Total_Introduzir = Me.txtTotalIntroduzir.Text
                End If
                produtoEntradaDTO.Produto_ID = Me.txtID.Text

                produtoEntradaDTO.Qtd_Por_Caixa = Me.txtQtdCaixa.Text
                produtoEntradaDTO.Preco_Compra = Me.txtPrecoCompra.Text



                produtoEntradaDTO.Origem = Me.txtPaisOrigem.Text
                produtoEntradaDTO.Preco_Venda = Me.txtPrecoVenda.Text
                produtoEntradaDTO.Entrada_ID = entrada_id
                produtoEntradaDTO.Criado = Format(Now, "yyyy-MM-dd")

                produtoDTO.Criado = Format(Now, "yyyy-MM-dd")

                produtoEntradaBLL.VerificaEntradaProduto(produtoEntradaDTO)
                produtoDTO.ID = Me.txtID.Text
                produtoDTO.Validade = Format(dpValidade.Value, "yyyy-MM-dd")
                produtoBLL.ActualizarValidade(produtoDTO)
                frmListarEntradasDoDia.ListarEntradaDeProdutos()
                'entradaBLL.VerificaEntrada(entradaDTO)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub dgPesquisar_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgPesquisar.CellContentClick
        Dim pais As String
        Dim x As Integer
        Dim colName As String = dgPesquisar.Columns(e.ColumnIndex).Name
        Try
            If colName = "colSelecionar" Then
                x = dgPesquisar.Rows.IndexOf(dgPesquisar.CurrentRow)
                If x >= 0 And x <= dgPesquisar.Rows.Count - 1 Then
                    Me.txtID.Text = Me.dgPesquisar.Rows(e.RowIndex).Cells(0).Value.ToString
                    Me.txtDesignacao.Text = Me.dgPesquisar.Rows(e.RowIndex).Cells(1).Value.ToString
                    pais = Me.dgPesquisar.Rows(e.RowIndex).Cells(2).Value.ToString
                    txtPaisOrigem.Text = pais
                    Me.txtPrecoVenda.Text = Me.dgPesquisar.Rows(e.RowIndex).Cells(3).Value
                    Me.txtPrecoCompra.Text = Me.dgPesquisar.Rows(e.RowIndex).Cells(4).Value
                    Me.txtQtdCaixa.Text = Me.dgPesquisar.Rows(e.RowIndex).Cells(5).Value
                    Me.pnPesquisar.Visible = False
                    'GetPriceByProdutName(Me.txtDesignacao.Text)
                End If

            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub mskData_MaskChanged(sender As Object, e As EventArgs) Handles mskData.MaskChanged

    End Sub

    Private Sub dgPesquisar_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgPesquisar.CellValueChanged
        If (e.RowIndex <> -1) Then
            dgPesquisar(e.ColumnIndex, e.RowIndex).Value = dgPesquisar(e.ColumnIndex, e.RowIndex).Value.ToString().ToUpper()
        End If
    End Sub
End Class