Public Class Nota_CreditoDTO
    Private id_ As Integer
    Public Property ID() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Private codigo_venda_ As String
    Public Property Codigo_Venda() As String
        Get
            Return codigo_venda_
        End Get
        Set(ByVal value As String)
            codigo_venda_ = value
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
    Private nome_cliente_ As String
    Public Property Nome_Cliente() As String
        Get
            Return nome_cliente_
        End Get
        Set(ByVal value As String)
            nome_cliente_ = value
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
    Private nuit_ As String
    Public Property Nuit() As String
        Get
            Return nuit_
        End Get
        Set(ByVal value As String)
            nuit_ = value
        End Set
    End Property
    Private total_geral_ As Double
    Public Property Total_Geral() As Double
        Get
            Return total_geral_
        End Get
        Set(ByVal value As Double)
            total_geral_ = value
        End Set
    End Property
    Private contacto_ As String
    Public Property Contacto() As String
        Get
            Return contacto_
        End Get
        Set(ByVal value As String)
            contacto_ = value
        End Set
    End Property
    Private cancelado_ As String
    Public Property Cancelado() As String
        Get
            Return cancelado_
        End Get
        Set(ByVal value As String)
            cancelado_ = value
        End Set
    End Property

    Private vd_referencia_ As String
    Public Property VD_Referencia() As String
        Get
            Return vd_referencia_
        End Get
        Set(ByVal value As String)
            vd_referencia_ = value
        End Set
    End Property
    Private motivo_ As String
    Public Property Motivo() As String
        Get
            Return motivo_
        End Get
        Set(ByVal value As String)
            motivo_ = value
        End Set
    End Property
End Class
