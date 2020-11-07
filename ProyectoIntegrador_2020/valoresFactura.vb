Public Class valoresFactura

    Public valueSaldo As Integer
    Public valueComentario As String
    Public valueFecha As String

    Public Sub New(ByVal valueSaldo As Integer, ByVal valueComentario As String, ByVal valueFecha As String)
        Me.valueSaldo = valueSaldo
        Me.valueComentario = valueComentario
        Me.valueFecha = valueFecha
    End Sub


    Public Property FuncionValueSaldo() As Integer
        Get
            Return valueSaldo
        End Get
        Set(ByVal valueSaldo As Integer)
            Me.valueSaldo = valueSaldo
        End Set
    End Property

    Public Property FuncionValueComentario() As String
        Get
            Return valueComentario
        End Get
        Set(ByVal valuesComentario As String)
            Me.valueComentario = valueComentario
        End Set
    End Property

    Public Property FuncionValueFecha() As String
        Get
            Return valueFecha
        End Get
        Set(ByVal valueFecha As String)
            Me.valueFecha = valueFecha
        End Set
    End Property


End Class
