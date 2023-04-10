Public Class CategoriaBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable

    Public Sub RemoverCategoria(ByRef id As Integer)
        sql = "Delete from Categoria WHERE ID= " & id & ""
        con.ExecutarComandoSQL(sql)
    End Sub

    Public Sub RegistarCategoria(categoriaDTO As CategoriaDTO)
        sql = "INSERT INTO Categoria (designacao) VALUES ('" & categoriaDTO.Designacao & "')"
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Sub ActualizarCategoria(categoriaDTO As CategoriaDTO)
        sql = "UPDATE Categoria SET designacao='" & categoriaDTO.Designacao & "' WHERE id= "& categoria_id &""
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Function ConsultaDesignacao()
        sql = "SELECT designacao FROM Categoria"
        ds = con.Listar(sql)
        Return ds
    End Function
    Public Function ConsultaCategoria()
        sql = "SELECT id, designacao FROM Categoria"
        con.ListarCategoria(sql)
        Return ds
    End Function
    Public Function BuscaIDCategoria(ByRef categoria As String)
        sql = "SELECT ID FROM categoria where designacao = '" & categoria & "'"
        tbl = con.ListarEspecifico(sql)
        Return tbl
    End Function
End Class

