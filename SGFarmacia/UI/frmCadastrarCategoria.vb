Public Class frmCadastrarCategoria
    Dim sql As String
    Dim ds As New DataSet
    'Dim con As New conex
    Dim tbl As New DataTable
    Dim categoriaDTO As New CategoriaDTO
    Dim categoriaBLL As New CategoriaBLL
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        If Me.txtDesignacao.Text = "" Then
            MsgBox("Digite a designação", vbCritical, "ERRO")
            Exit Sub
        End If
        '

        If acao = "Novo" Then
            Try
                If MsgBox("Confirma o registo da categoria: " & Me.txtDesignacao.Text & "?", vbQuestion + vbYesNo, "Confirmação") = MsgBoxResult.Yes Then
                    categoriaDTO.Designacao = Me.txtDesignacao.Text.ToUpper
                    categoriaBLL.RegistarCategoria(categoriaDTO)
                    ListarCategoria()
                End If
            Catch ex As Exception
                MsgBox("Erro gravar a categoria - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
            End Try
        Else
            Try
                If MsgBox("Confirma o alteração da categoria: " & Me.txtDesignacao.Text & "?", vbQuestion + vbYesNo, "Confirmação") = MsgBoxResult.Yes Then
                    categoriaDTO.Designacao = Me.txtDesignacao.Text.ToUpper
                    categoriaBLL.ActualizarCategoria(categoriaDTO)
                    ListarCategoria()

                End If
            Catch ex As Exception
                MsgBox("Erro gravar a categoria - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
            End Try
        End If
        Me.txtDesignacao.Text = ""
        Me.txtDesignacao.Focus()
        Me.btnNovo.Enabled = True

    End Sub
    Public Sub ListarCategoria()
        Try
            ds = categoriaBLL.ConsultaCategoria
        Catch ex As Exception
            MsgBox("Erro ao listar as categorias", MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub
    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarCategoria()
    End Sub

    Private Sub dgListarCategoria_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListarCategoria.CellContentClick
        Dim colName As String = dgListarCategoria.Columns(e.ColumnIndex).Name
        If colName = "colRemover" Then
            If MsgBox("Tem certeza que deseja remover o item: " & Me.dgListarCategoria.Rows(e.RowIndex).Cells(1).Value.ToString & "?", MsgBoxStyle.YesNo + vbQuestion, "Remover colaborador") = MsgBoxResult.Yes Then
                categoriaBLL.RemoverCategoria(Me.dgListarCategoria.Rows(e.RowIndex).Cells(0).Value.ToString.ToUpper)
                dgListarCategoria.Rows.RemoveAt(CInt(dgListarCategoria.CurrentRow.Index))
            End If
        ElseIf colName = "colEditar" Then
            acao = "Editar"
            categoria_id = Me.dgListarCategoria.Rows(e.RowIndex).Cells(0).Value.ToString
            Me.txtDesignacao.Text = Me.dgListarCategoria.Rows(e.RowIndex).Cells(1).Value.ToString
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Me.txtDesignacao.Text = ""
        Me.txtDesignacao.Focus()
        acao = "Novo"
        Me.btnNovo.Enabled = False
    End Sub
    'Private Sub GetIdByName(ByRef nome As String)
    '    Try
    '        tbl = mesBLL.BuscaIDMes(cboMes.Text)
    '        If tbl.Rows.Count > 0 Then
    '            vMesID = tbl.Rows(0)(0).ToString()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Erro ao trazer o codigo do mes - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
    '    End Try
    '    tbl = Nothing
    'End Sub
End Class
