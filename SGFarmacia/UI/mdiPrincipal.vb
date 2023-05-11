Imports System.ComponentModel

Public Class mdiPrincipal
    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        frmCadastrarCategoria.MdiParent = Me
        frmCadastrarCategoria.Show()
        acao = "Novo"
    End Sub

    Private Sub mnProdutos_Click(sender As Object, e As EventArgs) Handles mnProdutos.Click
        frmListarProdutos.MdiParent = Me
        frmListarProdutos.Show()
        acao = "Novo"
    End Sub

    Private Sub mnColaboradores_Click(sender As Object, e As EventArgs) Handles mnColaboradores.Click
        frmListarEntradasDoDia.MdiParent = Me
        frmListarEntradasDoDia.Show()

    End Sub

    Private Sub mdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim color As ColorDialog
        'If color.ShowDialog() = DialogResult.OK Then
        '    Me.BackColor = color.Color
        'End If
        'sBarraMenus.Visible = False
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click

    End Sub



    Private Sub mdiPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'e.Cancel = True
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Try
            If MessageBox.Show("Deseja realmente fechar a aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                End
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        frmListarEntradasDoDia.MdiParent = Me
        frmListarEntradasDoDia.Show()
    End Sub

    Private Sub btnSaida_Click(sender As Object, e As EventArgs) Handles btnSaida.Click
        frmListarSaidasDoDia.MdiParent = Me
        frmListarSaidasDoDia.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmCaixaDiario.MdiParent = Me
        frmCaixaDiario.Show()
    End Sub

    Private Sub btnRecibo_Click(sender As Object, e As EventArgs) Handles btnRecibo.Click
        frmListarNotasCredito.MdiParent = Me
        frmListarNotasCredito.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim data As String
        data = DateAndTime.Now
        lblHora.Text = data
    End Sub

    Private Sub btnGuia_Click(sender As Object, e As EventArgs) Handles btnGuia.Click
        frmListarProdutos.MdiParent = Me
        frmListarProdutos.Show()
        acao = "Novo"
    End Sub

    Private Sub btnVenda_Click(sender As Object, e As EventArgs) Handles btnVenda.Click
        frmRelatorioVendas.MdiParent = Me
        frmRelatorioVendas.Show()
    End Sub
End Class