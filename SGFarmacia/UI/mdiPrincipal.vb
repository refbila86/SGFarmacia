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
        Application.Exit()
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
End Class