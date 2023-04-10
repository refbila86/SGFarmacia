Public Class EntradaDTO
    Private id_ As Integer
    Public Property ID() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Private data_ As String
    Public Property Data() As String
        Get
            Return data_
        End Get
        Set(ByVal value As String)
            data_ = value
        End Set
    End Property
    Private total_gasto_ As Double
    Public Property Total_Gasto() As Double
        Get
            Return total_gasto_
        End Get
        Set(ByVal value As Double)
            total_gasto_ = value
        End Set
    End Property
    Private total_esperado_ As Double
    Public Property Total_Esperado() As Double
        Get
            Return total_esperado_
        End Get
        Set(ByVal value As Double)
            total_esperado_ = value
        End Set
    End Property
End Class
