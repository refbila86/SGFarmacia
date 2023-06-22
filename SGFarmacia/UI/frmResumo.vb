Public Class frmResumo
    Dim sql As String
    Dim ds, dst As New DataSet
    Dim tbl As New DataTable
    Dim categoriaBLL As New CategoriaBLL
    Dim produtoBLL As New ProdutoBLL
    Dim produtoDTO As New ProdutoDTO

    Dim vendaBLL As New VendaBLL
    Private Sub lblTotalProdutos_Click(sender As Object, e As EventArgs) Handles lblTotalProdutos.Click

    End Sub
    Public Sub GetCountProducts()
        Dim produto_total As Integer
        Try
            tbl = produtoBLL.BuscaNumeroTotalProdutos()
            If tbl.Rows.Count > 0 Then
                produto_total = tbl.Rows(0)(0).ToString()
                lblTotalProdutos.Text = produto_total
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o id do dia - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Public Sub GetCountOfCells()
        Dim nr_vendas As Integer
        Try
            tbl = vendaBLL.BuscaNumeroVendasDoDia(Format(Now(), "yyyy-MM-dd"))
            If tbl.Rows.Count > 0 Then
                nr_vendas = tbl.Rows(0)(0).ToString()
                lblNrVendasDia.Text = nr_vendas
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o id do dia - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Public Sub GetCountOfNoStock()
        Dim sem_stock As Integer
        Try
            tbl = produtoBLL.BuscaNumeroProdutosSemStock()
            If tbl.Rows.Count > 0 Then
                sem_stock = tbl.Rows(0)(0).ToString()
                lblTotalSemStock.Text = sem_stock
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o id do dia - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Public Sub GetSelesSum()
        Dim total_vendido As Double
        Try
            tbl = vendaBLL.BuscaSomaVendasDoDia(Format(Now(), "yyyy-MM-dd"))
            If tbl.Rows.Count > 0 Then
                total_vendido = tbl.Rows(0)(0).ToString()
                lblTotalSemStock.Text = total_vendido
            End If
        Catch ex As Exception
            MsgBox("Erro ao trazer o somatorio do dia - " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
        tbl = Nothing
    End Sub
    Private Sub pnProdutos_Paint(sender As Object, e As PaintEventArgs) Handles pnProdutos.Paint

        '        Select Case count(ps.id) from produto_stock ps
        'inner Join produto p on p.id= ps.produto_id;
    End Sub
    Public Sub ListaProdutosComprados()
        'dgCaixa.Rows.Clear()
        Try
            ds = produtoBLL.ListarProdutosComprados
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao listar os produtos: " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
        'SomaTotais()
    End Sub
    Public Sub ListarProdutosNuncaComprados()
        'dgCaixa.Rows.Clear()
        Try
            ds = produtoBLL.ListarProdutosNuncaComprados
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao listar os produtos: " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
        'SomaTotais()
    End Sub
    Public Sub ListaProdutosMenosComprados()
        'dgCaixa.Rows.Clear()
        Try
            ds = produtoBLL.ListarProdutosMenosComprados
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao listar os produtos: " + ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            ds = Nothing
        End Try
        'SomaTotais()
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub frmResumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCountProducts()
        GetCountOfCells()
        GetCountOfNoStock()
        ListaProdutosMenosComprados()
        ListaProdutosComprados()
        ListarProdutosNuncaComprados()
    End Sub
End Class