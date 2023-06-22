Public Class frmSaidaProdutos

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
    Dim vendaBLL As New VendaBLL
    Dim vendaDTO As New VendaDTO
    Dim vendaItensBLL As New VendaItensBLL
    Dim vendaItensDTO As New VendaItensDTO
    Dim nota_creditoBLL As New Nota_CreditoBLL
    Dim nota_creditoDTO As New Nota_CreditoDTO
    Dim nota_credito_itensBLL As New Nota_CreditoItensBLL
    Dim nota_credito_itensDTO As New Nota_CreditoItensDTO
    Dim data, motivo As String

    Private Sub frmSaidaProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btnCancelarVenda.Visible = False

        If acao = "Novo" Then
            IncrementaCodigo()
            Me.chkIncluirCliente.Enabled = True
        Else
            Me.txtNrVenda.Text = Me.txtNrVD.Text
            ListarDetalhesVenda()
            SomaTotais()
        End If

    End Sub
    Private Sub IncrementaCodigo()
        Try
            ds = vendaBLL.SelecionaUltimoRegisto()

            If (ds.Tables(0).Rows.Count > 0) Then

                Dim tmp_id = ds.Tables(0).Rows(0)("cod_venda").ToString()
                Dim new_id As Integer = CInt(tmp_id) + 1
                txtNrVenda.Text = new_id.ToString("00000")

            Else
                txtNrVenda.Text = "00001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub IncrementaCodigoNotaCredito()
        Try
            ds = nota_creditoBLL.SelecionaUltimoRegistoNotaCredito()

            If (ds.Tables(0).Rows.Count > 0) Then

                Dim tmp_id = ds.Tables(0).Rows(0)("cod_venda").ToString()
                Dim new_id As Integer = CInt(tmp_id) + 1
                txtCodigoNotaCredito.Text = new_id.ToString("00000")
            Else
                txtCodigoNotaCredito.Text = "00001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LimparFormulario()
        ' Me.Close()
        Me.dgVendaItens.Rows.Clear()
        Me.txtCliente.Enabled = False
        Me.txtNuit.Enabled = False
        Me.txtContacto.Enabled = False
        Me.lblCliente.Enabled = False
        Me.lblContacto.Enabled = False
        Me.lblEndereco.Enabled = False
        Me.txtCliente.Text = ""
        Me.txtNuit.Text = ""
        Me.txtContacto.Text = ""
        Me.txtTotal.Text = ""
        Me.txtTotalDesconto.Text = ""
        Me.txtTotalGeral.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ' LimparFormulario()
    End Sub


    Private Sub chkIncluirCliente_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncluirCliente.CheckedChanged
        If Me.chkIncluirCliente.Checked Then
            Me.txtCliente.Enabled = True
            Me.txtNuit.Enabled = True
            Me.txtContacto.Enabled = True
            Me.lblCliente.Enabled = True
            Me.lblContacto.Enabled = True
            Me.lblEndereco.Enabled = True
            txtCliente.Focus()
        Else
            Me.txtCliente.Enabled = False
            Me.txtNuit.Enabled = False
            Me.txtContacto.Enabled = False
            Me.lblCliente.Enabled = False
            Me.lblContacto.Enabled = False
            Me.lblEndereco.Enabled = False
            Me.txtCliente.Text = ""
            Me.txtNuit.Text = ""
            Me.txtContacto.Text = ""

        End If
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        data = Format(Now, "yyyy-MM-dd HH:mm:ss")
        If chkIncluirCliente.Checked = False Then
            Me.txtCliente.Text = "N/A"
            Me.txtNuit.Text = "N/A"
            Me.txtContacto.Text = "N/A"
        End If

        If acao = "Novo" Then

            Try
                If MsgBox("Confirma a venda nº: " & Me.txtNrVenda.Text & "?", vbQuestion + vbYesNo, "Confirmação") = MsgBoxResult.Yes Then
                    vendaDTO.Codigo_Venda = Me.txtNrVenda.Text
                    vendaDTO.Nome_Cliente = Me.txtCliente.Text.ToUpper
                    vendaDTO.Nuit = Me.txtNuit.Text
                    vendaDTO.Contacto = Me.txtContacto.Text
                    vendaDTO.Total_Geral = CDbl(Me.txtTotalGeral.Text)
                    vendaDTO.Cancelado = "Não"
                    vendaDTO.Data = data
                    vendaDTO.Utilizador = "admin"
                    vendaBLL.RegistarVenda(vendaDTO)
                    GravaItensFacturaClasse()
                    LimparFormulario()
                    Me.Close()
                    frmListarSaidasDoDia.ListarSaidaDeProdutos()
                    frmListarSaidasDoDia.ColorirGrid()
                    frmResumo.GetCountOfCells()
                    frmResumo.ListaProdutosComprados()
                    frmResumo.ListaProdutosMenosComprados()
                    frmResumo.ListarProdutosNuncaComprados()

                End If
            Catch ex As Exception
                MsgBox("Erro gravar a VD - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
            End Try
        Else
            MsgBox("O VD: " & Me.txtNrVenda.Text & " ja foi emitido" & vbCrLf & "Não pode ser alterado", vbCritical, "Proibição")
            'If MsgBox("Confirma o cancelamento da VD nº: " & Me.txtNrVenda.Text & "?" & vbCrLf & "Será criada a Nota de Credito nº: " & Me.txtCodigoNotaCredito.Text & "!", vbQuestion + vbYesNo, "Confirmação") = MsgBoxResult.Yes Then
            '    vendaBLL.CancelarVD(vendaDTO)
            '    frmListarSaidasDoDia.ColorirGrid()
            '    RetornaStock()
            '    'Me.dgVendaItens.Rows.Clear()
            '    HabilitaComponentes()
            'End If
            'motivo = InputBox("Escreva o motivo do cancelamento em poucas palavras", "Motivo do cancelamento")

            'nota_creditoDTO.Codigo_Venda = Me.txtNrVenda.Text
            'nota_creditoDTO.Nome_Cliente = Me.txtCliente.Text.ToUpper
            'nota_creditoDTO.Nuit = Me.txtNuit.Text
            'nota_creditoDTO.Contacto = Me.txtContacto.Text
            'nota_creditoDTO.Total_Geral = CDbl(Me.txtTotalGeral.Text)
            'nota_creditoDTO.Data = mskData.Text
            'nota_creditoDTO.Utilizador = "admin"
            'nota_creditoBLL.RegistarNotaCredito(nota_creditoDTO)
            ''vendaItensBLL.RemoverItensVenda(Me.txtNrVenda.Text)
            'GravaItensNotaCredito()
            'LimparFormulario()
            'Me.Close()
            'frmListarSaidasDoDia.ListarSaidaDeProdutos()
            'End If
            'Catch ex As Exception
            '    MsgBox("Erro gravar a categoria - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
            'End Try
        End If

    End Sub
    Public Sub GravaItensNotaCredito()
        data = Format(Now, "yyyy-MM-dd HH:mm:ss")
        For i = 0 To Me.dgVendaItens.Rows.Count - 1
            nota_credito_itensDTO.Artigo = Me.dgVendaItens.Item("artigo", i).Value
            nota_credito_itensDTO.Produto_ID = Me.dgVendaItens.Item("produto_id", i).Value.ToString

            produtoStockDTO.PRoduto_id = Me.dgVendaItens.Item("produto_id", i).Value.ToString

            nota_credito_itensDTO.Qtd = Me.dgVendaItens.Item("qtd", i).Value
            nota_credito_itensDTO.Preco_Unitario = Me.dgVendaItens.Item("precounitario", i).Value
            nota_credito_itensDTO.Desconto = Me.dgVendaItens.Item("desconto", i).Value
            nota_credito_itensDTO.Total_Unitario = Me.dgVendaItens.Item("totalUnitario", i).Value
            nota_credito_itensDTO.Cod_Venda = Me.txtCodigoNotaCredito.Text
            nota_credito_itensDTO.Data = vendaDTO.Data

            qtd_retirar = Me.dgVendaItens.Item("qtd", i).Value

            produtoStockBLL.AumentarStock(qtd_retirar, produtoStockDTO.PRoduto_id)
            nota_credito_itensBLL.RegistarItensNotaCredito(nota_credito_itensDTO)
        Next
    End Sub
    Public Sub RetornaStock()
        data = Format(Now, "yyyy-MM-dd HH:mm:ss")
        For i = 0 To Me.dgVendaItens.Rows.Count - 1
            nota_credito_itensDTO.Artigo = Me.dgVendaItens.Item("artigo", i).Value
            nota_credito_itensDTO.Produto_ID = Me.dgVendaItens.Item("produto_id", i).Value.ToString

            produtoStockDTO.PRoduto_id = Me.dgVendaItens.Item("produto_id", i).Value.ToString

            nota_credito_itensDTO.Qtd = Me.dgVendaItens.Item("qtd", i).Value
            nota_credito_itensDTO.Preco_Unitario = Me.dgVendaItens.Item("precounitario", i).Value
            nota_credito_itensDTO.Desconto = Me.dgVendaItens.Item("desconto", i).Value
            nota_credito_itensDTO.Total_Unitario = Me.dgVendaItens.Item("totalUnitario", i).Value
            nota_credito_itensDTO.Cod_Venda = Me.txtNrVenda.Text
            nota_credito_itensDTO.Data = vendaDTO.Data

            qtd_retirar = Me.dgVendaItens.Item("qtd", i).Value

            produtoStockBLL.AumentarStock(qtd_retirar, produtoStockDTO.PRoduto_id)
            'nota_credito_itensBLL.RegistarItensNotaCredito(nota_credito_itensDTO)
        Next
    End Sub
    Public Sub GravaItensFacturaClasse()

        For i = 0 To Me.dgVendaItens.Rows.Count - 1
            vendaItensDTO.Artigo = Me.dgVendaItens.Item("artigo", i).Value
            vendaItensDTO.Produto_ID = Me.dgVendaItens.Item("produto_id", i).Value.ToString

            produtoStockDTO.PRoduto_id = Me.dgVendaItens.Item("produto_id", i).Value.ToString

            vendaItensDTO.Qtd = Me.dgVendaItens.Item("qtd", i).Value
            vendaItensDTO.Preco_Unitario = Me.dgVendaItens.Item("precounitario", i).Value
            vendaItensDTO.Desconto = Me.dgVendaItens.Item("desconto", i).Value
            vendaItensDTO.Total_Unitario = Me.dgVendaItens.Item("totalUnitario", i).Value
            vendaItensDTO.Cod_Venda = Me.txtNrVenda.Text
            vendaItensDTO.Data = vendaDTO.Data
            qtd_retirar = Me.dgVendaItens.Item("qtd", i).Value

            produtoStockBLL.DiminuirStock(qtd_retirar, produtoStockDTO.PRoduto_id)
            vendaItensBLL.RegistarItensVenda(vendaItensDTO)
        Next
    End Sub


    Private Sub btnNovaVenda_Click(sender As Object, e As EventArgs) Handles btnNovaVenda.Click
        frmVendaDinheiro.CrystalReportViewer1.Enabled = True
        frmVendaDinheiro.CrystalReportViewer1.ReportSource = "C:\Dados\Relatorios\relVendaDinheiro.rpt"
        frmVendaDinheiro.CrystalReportViewer1.SelectionFormula = "{Command.cod_venda} =  '" & Me.txtNrVenda.Text & "'"
        frmVendaDinheiro.CrystalReportViewer1.Refresh()
        frmVendaDinheiro.CrystalReportViewer1.RefreshReport() '" & Me.txtNumFct.Text & "'"
        frmVendaDinheiro.ShowDialog()
    End Sub
    Public Sub VerificaStock()
        On Error Resume Next
        Dim stock As Integer
        Dim data As String
        data = Format(Now, "ss")
        stock = Me.TextBox1.Text

        If stock <= 5 Then
            If (txtQtd.Text > stock) Or (stock = 0) Then
                MsgBox("A quantidade digitada, é superior que a quantidade existente no stock!" & vbCrLf & " Por favor, verifique", vbCritical, "Produto")
                Exit Sub
            End If

            If MsgBox("Após esta venda, o produto: " & Me.txtProduto.Text & " estará no stock minimo!" & vbCrLf & " Deseja continuar a venda?", vbQuestion + vbYesNo, "Confirmação") = MsgBoxResult.Yes Then
                For Each items As DataGridViewRow In dgVendaItens.Rows
                    If items.Cells(1).Value = txtID.Text Then
                        items.Cells(4).Value = CInt(items.Cells(4).Value) + CInt(txtQtd.Text)
                        items.Cells(6).Value = CInt(items.Cells(3).Value) * CInt(items.Cells(4).Value)
                        SomaTotais()
                        Exit Sub
                    End If
                Next

                If Me.txtProduto.Text = "" Then
                    MsgBox("Digite o produto", vbCritical, "Produto")
                    Me.txtProduto.Focus()
                    Exit Sub
                Else
                    Me.dgVendaItens.Rows.Add("Art- " & data, txtID.Text, Me.txtProduto.Text, Me.txtPrecoUnitario.Text, Me.txtQtd.Text, Me.txtDesconto.Text, Me.txtTotalUnitario.Text, "Editar", "Remover")
                    SomaTotais()
                    Me.txtProduto.Text = ""
                    Me.txtPrecoUnitario.Text = ""
                    Me.txtQtd.Text = ""
                    Me.TextBox1.Text = ""
                    Me.txtTotalUnitario.Text = ""
                    Me.txtProduto.Focus()
                End If
            Else
                Exit Sub
            End If


            'ElseIf stock <= 0 Then
            '    MsgBox("O produto: " & Me.txtProduto.Text & "ja não existe no stock! ", vbCritical, "Stock")
            '    Exit Sub
        Else
            For Each items As DataGridViewRow In dgVendaItens.Rows

                If items.Cells(1).Value = txtID.Text Then
                    'MsgBox(" O produto: " & Me.txtProduto.Text & " ja foi incluido na lista!", vbCritical, "Duplicação")
                    items.Cells(4).Value = CInt(items.Cells(4).Value) + CInt(txtQtd.Text)
                    items.Cells(6).Value = CInt(items.Cells(3).Value) * CInt(items.Cells(4).Value)
                    SomaTotais()
                    Exit Sub
                End If
            Next

            If Me.txtProduto.Text = "" Then
                MsgBox("Digite o produto", vbCritical, "Produto")
                Me.txtProduto.Focus()
                Exit Sub
            Else
                Me.dgVendaItens.Rows.Add("Art- " & data, txtID.Text, Me.txtProduto.Text, Me.txtPrecoUnitario.Text, Me.txtQtd.Text, Me.txtDesconto.Text, Me.txtTotalUnitario.Text, "Editar", "Remover")
                SomaTotais()
                Me.txtProduto.Text = ""
                Me.txtPrecoUnitario.Text = ""
                Me.txtQtd.Text = ""
                Me.TextBox1.Text = ""
                Me.txtTotalUnitario.Text = ""
                Me.txtProduto.Focus()
            End If
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        VerificaStock()
    End Sub

    Private Sub txtProduto_TextChanged(sender As Object, e As EventArgs) Handles txtProduto.TextChanged

        If Me.txtProduto.Text <> "" Then
            Try
                Me.pnPesquisar.Visible = True
                ds = produtoBLL.PesquisarProdutoSaida(Me.txtProduto.Text)
            Catch ex As Exception
                MsgBox("Não foi possivel trazer o detalhes do produto", MsgBoxStyle.Critical, "ERRO")
            End Try

        Else
            Me.pnPesquisar.Visible = False
            Me.txtProduto.Text = ""
            Me.txtPrecoUnitario.Text = ""
            Me.txtQtd.Text = ""
            Me.txtStockActual.Text = ""
        End If

    End Sub

    Private Sub dgPesquisar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPesquisar.CellContentClick
        Dim pais As String
        Dim x As Integer
        Dim colName As String = dgPesquisar.Columns(e.ColumnIndex).Name
        Try
            If colName = "colSelecionar" Then
                x = dgPesquisar.Rows.IndexOf(dgPesquisar.CurrentRow)
                If x >= 0 And x <= dgPesquisar.Rows.Count - 1 Then
                    Me.txtID.Text = Me.dgPesquisar.Rows(e.RowIndex).Cells(0).Value.ToString
                    Me.txtProduto.Text = Me.dgPesquisar.Rows(e.RowIndex).Cells(1).Value.ToString
                    Me.txtPrecoUnitario.Text = Me.dgPesquisar.Rows(e.RowIndex).Cells(3).Value.ToString
                    Me.txtQtd.Text = 1
                    txtQtd.Focus()
                    pais = Me.dgPesquisar.Rows(e.RowIndex).Cells(2).Value.ToString
                    'Me.txtStockActual.Text = ""
                    Me.pnPesquisar.Visible = False
                End If

            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub
    Private Sub GetPriceByProdutID(ByRef ID As Integer)
        Try
            tbl = produtoStockBLL.PesquisarPreco(ID)
            If tbl.Rows.Count > 0 Then
                txtStockActual.Text = tbl.Rows(0)(0).ToString()
                TextBox1.Text = tbl.Rows(0)(0).ToString()
                'txtStockActual.Text = stock_actual
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o stock actual - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        GetPriceByProdutID(Me.txtID.Text)
    End Sub
    Private Function CTotalUnitario(qtd As Integer, preco As Double) As Integer

        qtd = Convert.ToInt32(Me.txtQtd.Text)
        preco = Convert.ToDouble(Me.txtPrecoUnitario.Text)
        Try
            If Me.txtQtd.Text = "" Then
                Me.txtQtd.Text = 1
                Me.txtDesconto.Text = ""
                Me.txtTotalUnitario.Text = ""
                Exit Function
            Else
                CTotalUnitario = qtd * preco
            End If
        Catch ex As Exception
            MsgBox("Erro ao fazer o calculo: - " & ex.Message, MsgBoxStyle.Critical, "ERRO")

        End Try

        Return CTotalUnitario
    End Function

    Private Sub txtQtd_TextChanged(sender As Object, e As EventArgs) Handles txtQtd.TextChanged
        On Error Resume Next
        If Me.txtQtd.Text = "" Then
            Me.txtQtd.Text = 1
            Me.txtTotalUnitario.Text = CTotalUnitario(Me.txtQtd.Text, txtPrecoUnitario.Text).ToString("C")
        Else
            Me.txtTotalUnitario.Text = CTotalUnitario(Me.txtQtd.Text, txtPrecoUnitario.Text).ToString("C")
        End If
    End Sub
    Public Sub SomaTotais()
        On Error Resume Next
        Dim Total As Double = 0 'Uma variavel para cada coluna a ser calculada
        Dim TotalGeral As Double = 0
        Dim desconto As Double = 0

        Dim Multa As Double = 0
        For I As Integer = 0 To Me.dgVendaItens.Rows.Count - 1
            Total += CDbl(dgVendaItens.Rows(I).Cells(6).Value) 'Cells() indica qual célula o valor vai ser pego
            desconto += CDbl(dgVendaItens.Rows(I).Cells(5).Value)
        Next
        Me.txtTotal.Text = Total.ToString("C")
        Me.txtTotalDesconto.Text = desconto.ToString("C")
        Me.txtTotalGeral.Text = (Total + desconto).ToString("C")
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub dgVendaItens_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVendaItens.CellContentClick
        Dim colName As String = dgVendaItens.Columns(e.ColumnIndex).Name
        Try
            If colName = "colRemover" Then
                If MsgBox("Tem certeza que deseja remover o produto: " & Me.dgVendaItens.Rows(e.RowIndex).Cells(2).Value.ToString & "?", MsgBoxStyle.YesNo + vbQuestion, "Remover colaborador") = MsgBoxResult.Yes Then
                    dgVendaItens.Rows.RemoveAt(CInt(dgVendaItens.CurrentRow.Index))
                    '  produtoStockBLL.AumentarStock(Me.dgVendaItens.Rows(e.RowIndex).Cells(4).Value.ToString, Me.dgVendaItens.Rows(e.RowIndex).Cells(1).Value.ToString)
                    SomaTotais()
                End If
            ElseIf colName = "colEditar" Then
                Me.txtID.Text = Me.dgVendaItens.Rows(e.RowIndex).Cells(1).Value.ToString
                GetPriceByProdutID(Me.txtID.Text)
                Me.txtProduto.Text = Me.dgVendaItens.Rows(e.RowIndex).Cells(2).Value.ToString
                Me.txtPrecoUnitario.Text = Me.dgVendaItens.Rows(e.RowIndex).Cells(3).Value.ToString
                Me.txtQtd.Text = Me.dgVendaItens.Rows(e.RowIndex).Cells(4).Value.ToString
                Me.txtDesconto.Text = Me.dgVendaItens.Rows(e.RowIndex).Cells(5).Value.ToString
                Me.txtTotalUnitario.Text = Me.dgVendaItens.Rows(e.RowIndex).Cells(6).Value.ToString
                dgVendaItens.Rows.RemoveAt(CInt(dgVendaItens.CurrentRow.Index))
                Me.pnPesquisar.Visible = False
                SomaTotais()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtPrecoUnitario_TextChanged(sender As Object, e As EventArgs) Handles txtPrecoUnitario.TextChanged
        On Error Resume Next
        If Me.txtQtd.Text = "" Then
            Me.txtQtd.Text = 1
            Me.txtTotalUnitario.Text = CTotalUnitario(Me.txtQtd.Text, txtPrecoUnitario.Text).ToString("C")
        Else
            Me.txtTotalUnitario.Text = CTotalUnitario(Me.txtQtd.Text, txtPrecoUnitario.Text).ToString("C")
        End If
    End Sub
    'Private Sub ListarFolhaSalarioMes()
    '    Try
    '        ds = vendaItensBLL.ConsultarVenda(Me.txtNrVenda.Text)
    '    Catch ex As Exception
    '        MsgBox("Ocorreu um erro ao trazer o codigo do contrato: " & ex.Message, MsgBoxStyle.Critical, "ERROR")
    '    Finally
    '        ds = Nothing
    '    End Try
    'End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged

    End Sub

    Private Sub txtNrVenda_TextChanged(sender As Object, e As EventArgs) Handles txtNrVenda.TextChanged, txtCodigoNotaCredito.TextChanged
        'ListarFolhaSalarioMes()
    End Sub

    Private Sub txtDesconto_DoubleClick(sender As Object, e As EventArgs) Handles txtDesconto.DoubleClick
        Me.txtDesconto.Enabled = False
    End Sub
    Private Sub ListarDetalhesVenda()
        Try
            dst = vendaItensBLL.ConsultarDetalhesVenda(Me.txtNrVD.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao trazer detalhes da venda: " & ex.Message, MsgBoxStyle.Critical, "ERROR")
        Finally
            dst = Nothing
        End Try
    End Sub
    Private Sub txtNrVD_TextChanged(sender As Object, e As EventArgs) Handles txtNrVD.TextChanged
        ' LimparFormulario()
        ListarDetalhesVenda()
    End Sub

    Private Sub btnCancelarVenda_Click(sender As Object, e As EventArgs) Handles btnCancelarVenda.Click

        IncrementaCodigoNotaCredito()
        vendaDTO.Codigo_Venda = txtNrVenda.Text
        vendaDTO.Data = mskData.Text
        vendaDTO.Nr_Nota_Debido = txtCodigoNotaCredito.Text

        If MsgBox("Confirma o cancelamento da VD nº: " & Me.txtNrVenda.Text & "?" & vbCrLf & "Será criada a Nota de Credito nº: " & Me.txtCodigoNotaCredito.Text & "!", vbQuestion + vbYesNo, "Confirmação") = MsgBoxResult.Yes Then
            vendaBLL.CancelarVD(vendaDTO)
            frmListarSaidasDoDia.ColorirGrid()
            RetornaStock()
            HabilitaComponentes()
        Else
            Exit Sub
        End If

        motivo = InputBox("Escreva o motivo do cancelamento em poucas palavras", "Motivo do cancelamento")

        nota_creditoDTO.Codigo_Venda = Me.txtCodigoNotaCredito.Text
        nota_creditoDTO.Nome_Cliente = Me.txtCliente.Text.ToUpper
        nota_creditoDTO.Nuit = Me.txtNuit.Text
        nota_creditoDTO.Contacto = Me.txtContacto.Text
        nota_creditoDTO.Total_Geral = CDbl(Me.txtTotalGeral.Text)
        nota_creditoDTO.Data = Format(Now, "yyyy-MM-dd hh:mm:ss")
        nota_creditoDTO.Utilizador = "admin"
        nota_creditoDTO.Motivo = motivo
        nota_creditoDTO.VD_Referencia = Me.txtNrVenda.Text
        nota_creditoBLL.RegistarNotaCredito(nota_creditoDTO)
        vendaItensBLL.RemoverItensVenda(Me.txtNrVenda.Text)
        GravaItensNotaCredito()
        LimparFormulario()
        Me.Close()
        frmListarSaidasDoDia.ListarSaidaDeProdutos()
    End Sub
    Public Sub GravarItensNotaCredito()
        Try
            GravaNotaCredito()
            GravaItensNotaCredito()
            LimparFormulario()
            Me.Close()
            frmListarSaidasDoDia.ListarSaidaDeProdutos()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao gravar a nota de credito: " & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    Public Sub DesabilitaComponentes()
        Me.mskData.Text = Me.mskData.Text
        Me.mskData.Enabled = False
        Me.txtTotal.Enabled = False
        Me.txtTotalGeral.Enabled = False
        Me.txtTotalDesconto.Enabled = False
        Me.dgVendaItens.Enabled = False
        Me.dgVendaItens.Enabled = False
        Me.btnAdicionar.Enabled = False
        Me.txtProduto.Enabled = False
        Me.txtPrecoUnitario.Enabled = False
        Me.txtQtd.Enabled = False
        Me.txtTotalUnitario.Enabled = False
        'Me.btnRegistar.Visible = False
        'Me.btnCancelarVenda.Visible = False
        Me.txtNrVD.Visible = False
        'Me.txtNrVenda.Visible = False
        'lblNrVenda.Visible = False
        chkIncluirCliente.Enabled = False
        'Me.txtCodigoNotaCredito.Visible = True
        'Me.lblNotaCredito.Visible = True
        chkIncluirCliente.Enabled = False
        txtNrVD.Visible = False

    End Sub
    Public Sub HabilitaComponentes()
        Me.mskData.Text = Me.mskData.Text
        Me.mskData.Enabled = True
        Me.txtTotal.Enabled = True
        Me.txtTotalGeral.Enabled = True
        Me.txtTotalDesconto.Enabled = True
        Me.dgVendaItens.Enabled = True
        Me.dgVendaItens.Enabled = True
        Me.btnAdicionar.Enabled = True
        Me.txtProduto.Enabled = True
        Me.txtPrecoUnitario.Enabled = True
        Me.txtQtd.Enabled = True
        Me.txtTotalUnitario.Enabled = True
        'Me.btnRegistar.Visible = True
        'Me.btnCancelarVenda.Visible = True
        Me.txtNrVD.Visible = True
        Me.txtNrVenda.Visible = True
        lblNrVenda.Visible = True
        txtNrVD.Visible = False
        Me.txtCodigoNotaCredito.Visible = False
        Me.lblNotaCredito.Visible = False
        chkIncluirCliente.Enabled = True
    End Sub
    Public Sub GravaNotaCredito()
        Dim motivo As String
        data = Format(Now, "yyyy-MM-dd HH:mm:ss")
        motivo = InputBox("Escreva o motivo do cancelamento em poucas palavras", "Motivo do cancelamento")
        Try
            nota_creditoDTO.Codigo_Venda = Me.txtNrVenda.Text
            nota_creditoDTO.Nome_Cliente = Me.txtCliente.Text.ToUpper
            nota_creditoDTO.Nuit = Me.txtNuit.Text
            nota_creditoDTO.Contacto = Me.txtContacto.Text
            nota_creditoDTO.Total_Geral = CDbl(Me.txtTotalGeral.Text)
            nota_creditoDTO.Cancelado = "Não"
            nota_creditoDTO.Data = data
            nota_creditoDTO.Utilizador = "admin"
            nota_creditoDTO.Motivo = motivo
            nota_creditoDTO.VD_Referencia = Me.txtNrVenda.Text
            nota_creditoBLL.RegistarNotaCredito(nota_creditoDTO)
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao gravar a nota de credito: " & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub btnGravaNota_Click(sender As Object, e As EventArgs) Handles btnGravaNota.Click
        GravarItensNotaCredito()
    End Sub

    Private Sub txtDesconto_MouseMove(sender As Object, e As MouseEventArgs) Handles txtDesconto.MouseMove
        Me.txtDesconto.Enabled = True
    End Sub
End Class