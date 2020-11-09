Public Class moduloSurtido
    Private idContador As Integer
    Private idProducto As Long
    Private precioTotal As Integer
    Private precioVenta As Integer
    Private precioCosto As Integer
    Private Stock As Integer
    Private Nombre As String
    Private Porcentaje As Integer


    Public Sub New(ByVal idCont As Integer, ByVal idProd As Long, ByVal precioTotal As Integer, ByVal precioVenta As Integer, ByVal precioCosto As Integer, ByVal Stock As Integer, ByVal Nombre As String, ByVal Porcentaje As Integer)
        Me.idContador = idCont
        Me.idProducto = idProd
        Me.precioTotal = precioTotal
        Me.precioVenta = precioVenta
        Me.precioCosto = precioCosto
        Me.Stock = Stock
        Me.Nombre = Nombre
        Me.Porcentaje = Porcentaje
    End Sub


    Public Property FuncionContador() As Integer
        Get
            Return idContador
        End Get
        Set(ByVal idCont As Integer)
            Me.idContador = idCont
        End Set
    End Property

    Public Property FuncionIdProducto() As Long
        Get
            Return idProducto
        End Get
        Set(ByVal idProd As Long)
            Me.idProducto = idProd
        End Set
    End Property


    Public Property FuncionCostoTotal() As Integer
        Get
            Return precioTotal
        End Get
        Set(ByVal precioTotal As Integer)
            Me.precioTotal = precioTotal
        End Set
    End Property


    Public Property FuncionVenta() As Integer
        Get
            Return precioVenta
        End Get
        Set(ByVal precioVenta As Integer)
            Me.precioVenta = precioVenta
        End Set
    End Property

    Public Property FuncionCosto() As Integer
        Get
            Return precioCosto
        End Get
        Set(ByVal precioCosto As Integer)
            Me.precioCosto = precioCosto
        End Set
    End Property


    Public Property FuncionStock() As Integer
        Get
            Return Stock
        End Get
        Set(ByVal stock As Integer)
            Me.Stock = stock
        End Set
    End Property

    Public Property FuncionNombre() As String
        Get
            Return Nombre
        End Get
        Set(ByVal Nombre As String)
            Me.Nombre = Nombre
        End Set
    End Property



    Public Property FuncionPorcentaje() As Integer
        Get
            Return Porcentaje
        End Get
        Set(ByVal Porcentaje As Integer)
            Me.Porcentaje = Porcentaje
        End Set
    End Property


End Class
