Public Class Nota_CreditoItensDTO
    Private id_ As Integer
    Public Property ID() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Private cod_venda_ As String
    Public Property Cod_Venda() As String
        Get
            Return cod_venda_
        End Get
        Set(ByVal value As String)
            cod_venda_ = value
        End Set
    End Property
    Private artigo_ As String
    Public Property Artigo() As String
        Get
            Return artigo_
        End Get
        Set(ByVal value As String)
            artigo_ = value
        End Set
    End Property
    Private produto_id_ As Integer
    Public Property Produto_ID() As Integer
        Get
            Return produto_id_
        End Get
        Set(ByVal value As Integer)
            produto_id_ = value
        End Set
    End Property
    Private qtd_ As Integer
    Public Property Qtd() As Integer
        Get
            Return qtd_
        End Get
        Set(ByVal value As Integer)
            qtd_ = value
        End Set
    End Property
    Private preco_unitario_ As Double
    Public Property Preco_Unitario() As Double
        Get
            Return preco_unitario_
        End Get
        Set(ByVal value As Double)
            preco_unitario_ = value
        End Set
    End Property
    Private total_unitario_ As Double
    Public Property Total_Unitario() As Double
        Get
            Return total_unitario_
        End Get
        Set(ByVal value As Double)
            total_unitario_ = value
        End Set
    End Property
    Private desconto_ As Double
    Public Property Desconto() As Double
        Get
            Return desconto_
        End Get
        Set(ByVal value As Double)
            desconto_ = value
        End Set
    End Property
    Private venda_id_ As Integer
    Public Property Venda_id() As Integer
        Get
            Return venda_id_
        End Get
        Set(ByVal value As Integer)
            venda_id_ = value
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
End Class
