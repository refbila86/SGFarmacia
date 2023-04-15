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

    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click

    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click
        'frmSaidaProdutos.MdiParent = Me
        'frmSaidaProdutos.Show()
        frmListarSaidasDoDia.MdiParent = Me
        frmListarSaidasDoDia.Show()
    End Sub
End Class