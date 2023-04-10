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

    End Sub
End Class