Public Class ProdutoStockDTO
    Private id_ As Integer
    Public Property ID() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Private produto_id_ As Integer
    Public Property PRoduto_id() As Integer
        Get
            Return produto_id_
        End Get
        Set(ByVal value As Integer)
            produto_id_ = value
        End Set
    End Property

    Private stock_actual_ As Integer
    Public Property Stock_Actual() As Integer
        Get
            Return stock_actual_
        End Get
        Set(ByVal value As Integer)
            stock_actual_ = value
        End Set
    End Property
End Class
