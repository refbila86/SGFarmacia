Public Class Caixa_DetalhesDTO
    Private nr_venda_ As String
    Public Property Nr_Venda() As String
        Get
            Return nr_venda_
        End Get
        Set(ByVal value As String)
            nr_venda_ = value
        End Set
    End Property
    Private valor_vd_ As Double
    Public Property Valor_Venda() As Double
        Get
            Return valor_vd_
        End Get
        Set(ByVal value As Double)
            valor_vd_ = value
        End Set
    End Property
    Private caixa_id_ As Integer
    Public Property Caixa_ID() As Integer
        Get
            Return caixa_id_
        End Get
        Set(ByVal value As Integer)
            caixa_id_ = value
        End Set
    End Property
    Private cliente_id_ As Integer
    Public Property Cliente_ID() As Integer
        Get
            Return cliente_id_
        End Get
        Set(ByVal value As Integer)
            cliente_id_ = value
        End Set
    End Property
End Class
