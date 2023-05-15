Public Class CaixaDTO
    Private id_ As Integer
    Public Property ID() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Private valor_dia_ As Double
    Public Property Valor_dia() As Double
        Get
            Return valor_dia_
        End Get
        Set(ByVal value As Double)
            valor_dia_ = value
        End Set
    End Property
    Private lucro_dia_ As Double
    Public Property Lucro_Dia() As Double
        Get
            Return lucro_dia_
        End Get
        Set(ByVal value As Double)
            lucro_dia_ = value
        End Set
    End Property
    Private fechado_ As String
    Public Property Fechado() As String
        Get
            Return fechado_
        End Get
        Set(ByVal value As String)
            fechado_ = value
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
    Private utilizador_ As String
    Public Property Utilizador() As String
        Get
            Return utilizador_
        End Get
        Set(ByVal value As String)
            utilizador_ = value
        End Set
    End Property
    Private nr_vendas_ As Integer
    Public Property Nr_Vendas() As Integer
        Get
            Return nr_vendas_
        End Get
        Set(ByVal value As Integer)
            nr_vendas_ = value
        End Set
    End Property
End Class















