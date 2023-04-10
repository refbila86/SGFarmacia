Public Class CategoriaDTO
    Private id_ As Integer
    Public Property ID() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Private designacao_ As String
    Public Property Designacao() As String
        Get
            Return designacao_
        End Get
        Set(ByVal value As String)
            designacao_ = value
        End Set
    End Property
End Class
