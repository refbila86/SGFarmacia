Public Class Produto_EntradaDTO
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
    Public Property Produto_ID() As Integer
        Get
            Return produto_id_
        End Get
        Set(ByVal value As Integer)
            produto_id_ = value
        End Set
    End Property
    Private qtd_stock_ As Integer
    Public Property Qtd_Stock() As Integer
        Get
            Return qtd_stock_
        End Get
        Set(ByVal value As Integer)
            qtd_stock_ = value
        End Set
    End Property
    Private tipo_entrada_ As String
    Public Property Tipo_Entrada() As String
        Get
            Return tipo_entrada_
        End Get
        Set(ByVal value As String)
            tipo_entrada_ = value
        End Set
    End Property
    Private qtd_por_caixa_ As Integer
    Public Property Qtd_Por_Caixa() As Integer
        Get
            Return qtd_por_caixa_
        End Get
        Set(ByVal value As Integer)
            qtd_por_caixa_ = value
        End Set
    End Property
    Private numero_caixa_ As Integer
    Public Property Numero_Caixa() As Integer
        Get
            Return numero_caixa_
        End Get
        Set(ByVal value As Integer)
            numero_caixa_ = value
        End Set
    End Property
    Private preco_compra_ As Double
    Public Property Preco_Compra() As Double
        Get
            Return preco_compra_
        End Get
        Set(ByVal value As Double)
            preco_compra_ = value
        End Set
    End Property
    Private preco_venda_ As Double
    Public Property Preco_Venda() As Double
        Get
            Return preco_venda_
        End Get
        Set(ByVal value As Double)
            preco_venda_ = value
        End Set
    End Property
    Private data_entrada_ As String
    Public Property Data_Entrada() As String
        Get
            Return data_entrada_
        End Get
        Set(ByVal value As String)
            data_entrada_ = value
        End Set
    End Property
    Private qtd_introduzir_ As Integer
    Public Property Qtd_Introduzir() As Integer
        Get
            Return qtd_introduzir_
        End Get
        Set(ByVal value As Integer)
            qtd_introduzir_ = value
        End Set
    End Property
    Private total_introduzir_ As Integer
    Public Property Total_Introduzir() As Integer
        Get
            Return total_introduzir_
        End Get
        Set(ByVal value As Integer)
            total_introduzir_ = value
        End Set
    End Property
    Private entrada_id_ As Integer
    Public Property Entrada_ID() As Integer
        Get
            Return entrada_id_
        End Get
        Set(ByVal value As Integer)
            entrada_id_ = value
        End Set
    End Property
    Private origem_ As String
    Public Property Origem() As String
        Get
            Return origem_
        End Get
        Set(ByVal value As String)
            origem_ = value
        End Set
    End Property
    Private criado_ As String
    Public Property Criado() As String
        Get
            Return criado_
        End Get
        Set(ByVal value As String)
            criado_ = value
        End Set
    End Property
End Class
