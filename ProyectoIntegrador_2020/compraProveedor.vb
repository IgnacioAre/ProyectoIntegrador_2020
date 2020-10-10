Public Class compraProveedor
    Private idContador As Integer
    Private Saldo As Integer
    Private Detalle As String
    Private Stock As Integer
    Private idProveedor As Integer
    Private idProducto As Long

    Public Sub New(ByVal idCont As Integer, ByVal saldo As Integer, ByVal stock As Integer, ByVal detalle As String, ByVal idProd As Long, ByVal idProv As Integer)
        Me.idContador = idCont
        Me.Saldo = saldo
        Me.Detalle = detalle
        Me.Stock = stock
        Me.idProducto = idProd
        Me.idProveedor = idProv
    End Sub

    Public Sub New(ByVal idCont As Integer, ByVal saldo As Integer, ByVal stock As Integer, ByVal idProd As Long, ByVal idProv As Integer)
        Me.idContador = idCont
        Me.Saldo = saldo
        Me.Stock = stock
        Me.idProducto = idProd
        Me.idProveedor = idProv
    End Sub

    Public Property FuncionContador() As Integer
        Get
            Return idContador
        End Get
        Set(ByVal idCont As Integer)
            Me.idContador = idCont
        End Set
    End Property

    Public Property FuncionSaldo() As Integer
        Get
            Return Saldo
        End Get
        Set(ByVal Saldo As Integer)
            Me.Saldo = Saldo
        End Set
    End Property

    Public Property FuncionDetalle() As String
        Get
            Return Detalle
        End Get
        Set(ByVal Detalle As String)
            Me.Detalle = Detalle
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

    Public Property FuncionIdProveedor() As Integer
        Get
            Return idProveedor
        End Get
        Set(ByVal idProv As Integer)
            Me.idProveedor = idProv
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



End Class
