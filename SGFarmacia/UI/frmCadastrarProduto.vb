Public Class frmCadastrarProduto
    Dim sql As String
    Dim ds, dst As New DataSet
    Dim tbl As New DataTable
    Dim categoriaBLL As New CategoriaBLL
    Dim produtoBLL As New ProdutoBLL
    Dim produtoDTO As New ProdutoDTO
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmCadastrarProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.txtID.Text = "" Then
            Me.btnRegistar.Text = "Registar o produto"
            Me.lblRegistar.Text = "Registar Produtos"
        Else
            Me.btnRegistar.Text = "Alterar o produto"
            Me.lblRegistar.Text = "Alterar Produtos"
        End If
        CarregaCategoria()
    End Sub
    Public Sub CarregaCategoria()
        cboCategoria.Items.Clear()
        Try
            Dim total_linhas As Integer = 0
            ds = categoriaBLL.ConsultaDesignacao
            total_linhas = ds.Tables(0).Rows.Count
            For i = 0 To total_linhas - 1
                Me.cboCategoria.Items.Add(ds.Tables(0).Rows(i)("designacao").ToString)
            Next
        Catch ex As Exception
            MsgBox("Erro ao listar a categoria", MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged
        GetIdByDescription(cboCategoria.Text)
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Me.txtDesignacao.Focus()
        Me.btnNovo.Visible = False
        Me.btnRegistar.Visible = True
    End Sub
    Sub Verifica_Campos()
        If Me.txtDesignacao.Text = "" Then
            MsgBox("Digite o nome do produto", MsgBoxStyle.Information, "Informação")
            Me.txtDesignacao.Focus()
            Exit Sub
        ElseIf Me.txtNomeGenerico.Text = "" Then
            MsgBox("Digite o nome generico", MsgBoxStyle.Information, "Informação")
            Me.txtNomeGenerico.Focus()
            Exit Sub
        ElseIf Me.txtPrecoCompra.Text = "" Then
            MsgBox("Digite o preco de compora", MsgBoxStyle.Information, "Informação")
            Me.txtPrecoCompra.Focus()
            Exit Sub
        ElseIf Me.txtPrecoVenda.Text = "" Then
            MsgBox("Digite o preco de venda", MsgBoxStyle.Information, "Informação")
            Me.txtPrecoVenda.Focus()
            Exit Sub
        ElseIf Me.txtQtdCaixa.Text = "" Then
            MsgBox("Digite a qtd por caixa", MsgBoxStyle.Information, "Informação")
            Me.txtQtdCaixa.Focus()
            Exit Sub
        ElseIf Me.cboPaisOrigem.Text = "" Then
            MsgBox("Digite o pais de origem", MsgBoxStyle.Information, "Informação")
            Me.cboPaisOrigem.Focus()
            Exit Sub
        End If
    End Sub
    Public Sub CalculaValidade()
        Dim calculo, dia, prazo As Double
        Me.txtResultado.Clear()
        Dim dtini As DateTime = dpValidade.Value
        Dim dtfim As DateTime = Now
        calculo += DateDiff(DateInterval.Day, dtini, dtfim).ToString + vbCrLf
        dia = -1 * CInt(calculo)
        prazo = dia
        txtResultado.Text = Str(prazo)
        'txtResultado.Text += DateDiff(DateInterval.Month, dtini, dtfim).ToString + vbCrLf
    End Sub
    Public Sub CalculaValidades()
        Dim dtini As DateTime = dpValidade.Value
        Dim dtfim As DateTime = Now
        Dim Dias As Double
        'TimeSpan
        'Dim dif As TimeSpan = dtfim.Subtract(dtini)
        'txtResultado.Text = dif.TotalSeconds.ToString + "  Segundos" + vbCrLf
        'txtResultado.Text += dif.TotalMinutes.ToString + "  Minutos " + vbCrLf
        'txtResultado.Text += dif.TotalHours.ToString + "  Horas " + vbCrLf
        'txtResultado.Text += dif.TotalDays.ToString + "  Dias " + vbCrLf
        ''DateDiff
        'txtResultado2.Text = DateDiff(DateInterval.Second, dtini, dtfim).ToString + "  Segundos" + vbCrLf
        'txtResultado2.Text += DateDiff(DateInterval.Minute, dtini, dtfim).ToString + "  Minutos" + vbCrLf
        txtResultado.Text += DateDiff(DateInterval.Day, dtini, dtfim).ToString + " Dias" + vbCrLf
        'Dias = (DateDiff(DateInterval.Day, dtfim, dtini).ToString)
        'MsgBox(Dias + "  Dias" + vbCrLf)

        'txtResultado2.Text += DateDiff(DateInterval.Quarter, dtini, dtfim).ToString + "  Trimestres" + vbCrLf
        'txtResultado2.Text += DateDiff(DateInterval.Month, dtini, dtfim).ToString + "  Meses" + vbCrLf
    End Sub
    Private Function calculaNumeroDiasVividos() As Integer
        Dim dataValidade As Date
        Dim horasEmFalta As TimeSpan
        Dim diasEmFalta As double
        ' obtem o valor da data de validade do controle DateTimePickerl
        dataValidade = dpValidade.Value
        ' subtrai a data de validade da data atual
        horasEmFalta = Now.Subtract(dataValidade)

        'Calcula o número de dias entre as datas
        diasEmFalta = horasEmFalta.Days
        'se o valor for menor que 1 indica que a data de nascimento é maior que a data atual
        If diasEmFalta > 1 Then
            Throw New ArgumentException("Você ainda não nasceu...")
        End If
        Return diasEmFalta
    End Function


    Public Sub CalculaDiaMesAno()
        Dim Msg As String
        Dim data As String = Me.dpValidade.Value
        Dim d1, d2, d3, d4, d5 As Single

        d1 = DateDiff("d", data, Now)
        d2 = DateDiff("m", data, Now)
        d3 = DateDiff("yyyy", data, Now)
        d4 = DateDiff("s", data, Now)

        Msg = " O prazo de validade: " & vbCrLf
        Msg = Msg & " ============================== " & vbCrLf
        Msg = Msg & " Em dias : " & d1 & " dias " & vbCrLf
        Msg = Msg & " Em meses : " & d2 & " meses " & vbCrLf
        Msg = Msg & " Em anos : " & d3 & " anos " & vbCrLf
        Msg = Msg & " Em segundos : " & d4 & " segundos " & vbCrLf

        MsgBox(Msg, vbOKOnly, " calculando intervalos de datas ")

    End Sub
    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        Dim data As String
        If Me.cboCategoria.Text = "" Then
            MsgBox("Escolha categoria", MsgBoxStyle.Information, "Informação")
            Exit Sub
        End If
        Verifica_Campos()

        If acao = "Novo" Then
            Try
                If MsgBox("Confirma o registo do produto: " & Me.txtDesignacao.Text & "?", vbQuestion + vbYesNo, "Confirmação") = MsgBoxResult.Yes Then
                    produtoDTO.Designacao = Me.txtDesignacao.Text.ToUpper
                    'produtoDTO.ID = txtID.Text
                    produtoDTO.Categoria_ID = categoria_id
                    produtoDTO.Preco_Compra = Me.txtPrecoCompra.Text
                    produtoDTO.Preco_Venda = Me.txtPrecoVenda.Text
                    produtoDTO.Pais_Origem = Me.cboPaisOrigem.Text.ToUpper
                    produtoDTO.Nome_Generico = Me.txtNomeGenerico.Text.ToUpper
                    produtoDTO.Qtd_Cx = Me.txtQtdCaixa.Text
                    produtoDTO.Unidade_Medida = Me.cboUnidadeMedida.Text.ToUpper
                    'data = Format(Me.dpValidade.Value, "yyyy-MM-dd HH:mm:ss")
                    produtoDTO.Criado = Format(Now, "yyyy-MM-dd hh:mm:ss")
                    produtoBLL.RegistarProduto(produtoDTO)
                    frmListarProdutos.ListarProdutos()
                    frmListarProdutos.ColorirGrid()
                    Me.btnRegistar.Visible = False
                    Me.btnNovo.Visible = True
                    'CalculaDiaMesAno()
                    CalculaValidade()
                End If
            Catch ex As Exception
                MsgBox("Erro ao gravar o produto - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
            End Try
        Else
            Me.btnRegistar.Text = "Alterar o produto"
            Try
                If MsgBox("Confirma o alteração do produto: " & Me.txtDesignacao.Text & "?", vbQuestion + vbYesNo, "Confirmação") = MsgBoxResult.Yes Then
                    produtoDTO.Categoria_ID = categoria_id
                    produtoDTO.ID = Me.txtID.Text
                    produtoDTO.Designacao = Me.txtDesignacao.Text.ToUpper
                    produtoDTO.Preco_Compra = Me.txtPrecoCompra.Text
                    produtoDTO.Preco_Venda = Me.txtPrecoVenda.Text
                    produtoDTO.Pais_Origem = Me.cboPaisOrigem.Text.ToUpper
                    produtoDTO.Nome_Generico = Me.txtNomeGenerico.Text.ToUpper
                    produtoDTO.Qtd_Cx = Me.txtQtdCaixa.Text
                    produtoDTO.Unidade_Medida = Me.cboUnidadeMedida.Text.ToUpper
                    data = Format(Me.dpValidade.Value, "yyyy-MM-dd HH:mm:ss")
                    produtoDTO.Validade = data
                    produtoDTO.Criado = Format(Now(), "yyyy-MM-dd HH:mm:ss")
                    produtoBLL.ActualizarProduto(produtoDTO)
                    frmListarProdutos.ListarProdutos()
                    frmListarProdutos.ColorirGrid()
                    CalculaDiaMesAno()
                    LimparForm()
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox("Erro ao gravar o produto - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
            End Try
        End If

    End Sub
    Sub LimparForm()
        Me.txtID.Text = ""
        'Me.txtDesignacao
        Me.txtDesignacao.Text = ""
        Me.txtNomeGenerico.Text = ""
        Me.txtPrecoCompra.Text = ""
        Me.txtPrecoVenda.Text = ""
        Me.txtQtdCaixa.Text = ""
        Me.cboCategoria.Items.Clear()
        CarregaCategoria()
        Me.cboPaisOrigem.Text = ""
        acao = ""
    End Sub
    Private Sub txtDesignacao_TextChanged(sender As Object, e As EventArgs) Handles txtDesignacao.TextChanged

    End Sub

    Private Sub GetIdByDescription(ByRef description As String)
        Try
            tbl = categoriaBLL.BuscaIDCategoria(cboCategoria.Text)
            If tbl.Rows.Count > 0 Then
                categoria_id = tbl.Rows(0)(0).ToString()
                txtIDCategoria.Text = categoria_id
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o codigo da categoria - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub

    Private Sub txtNomeGenerico_TextChanged(sender As Object, e As EventArgs) Handles txtNomeGenerico.TextChanged

    End Sub

    Private Sub txtDesignacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesignacao.KeyPress
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        'KeyAscii = CShort(SoLETRAS(KeyAscii))

        'If KeyAscii = 0 Then

        '    e.Handled = True

        'End If
    End Sub

    Private Sub cboPaisOrigem_TextChanged(sender As Object, e As EventArgs) Handles cboPaisOrigem.TextChanged

    End Sub

    Private Sub txtNomeGenerico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeGenerico.KeyPress
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        'KeyAscii = CShort(SoLETRAS(KeyAscii))

        'If KeyAscii = 0 Then

        '    e.Handled = True

        'End If
    End Sub

    Private Sub txtQtdCaixa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdCaixa.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub dpValidade_ValueChanged(sender As Object, e As EventArgs) Handles dpValidade.ValueChanged
        ''verifica se a data informada é valida
        'If IsDate(dpValidade.Value) Then
        '    Try
        '        'chama a função para calcular o numero de dias e exibe o resultado na label do formulário
        '        MsgBox(calculaNumeroDiasVividos())
        '    Catch exc As Exception
        '        MsgBox(exc.Message)
        '    End Try
        'Else
        '    MessageBox.Show("Informe uma data válida", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CalculaValidade()
    End Sub

    Private Sub cboPaisOrigem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPaisOrigem.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoLETRAS(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class