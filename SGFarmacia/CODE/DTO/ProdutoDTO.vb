Public Class ProdutoDTO
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
    Private preco_compra_ As Double
    Private nome_generico_ As String
    Public Property Nome_Generico() As String
        Get
            Return nome_generico_
        End Get
        Set(ByVal value As String)
            nome_generico_ = value
        End Set
    End Property
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
    Private validade_ As String
    Public Property Validade() As String
        Get
            Return validade_
        End Get
        Set(ByVal value As String)
            validade_ = value
        End Set
    End Property
    Private pais_origem_ As String
    Public Property Pais_Origem() As String
        Get
            Return pais_origem_
        End Get
        Set(ByVal value As String)
            pais_origem_ = value
        End Set
    End Property
    Private qtd_cx_ As Integer
    Public Property Qtd_Cx() As Integer
        Get
            Return qtd_cx_
        End Get
        Set(ByVal value As Integer)
            qtd_cx_ = value
        End Set
    End Property
    Private unidade_medida_ As String
    Public Property Unidade_Medida() As String
        Get
            Return unidade_medida_
        End Get
        Set(ByVal value As String)
            unidade_medida_ = value
        End Set
    End Property
    Private utilizador_ As String
    Public Property Utilizador() As String
        Get
            Return utilizador_
        End Get
        Set(ByVal value As String)
            utilizador_ = value
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
    Private categoria_id_ As Integer
    Public Property Categoria_ID() As Integer
        Get
            Return categoria_id_
        End Get
        Set(ByVal value As Integer)
            categoria_id_ = value
        End Set
    End Property
End Class
