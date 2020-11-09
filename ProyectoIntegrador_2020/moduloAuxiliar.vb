Module moduloAuxiliar

    Public nuevoValor As List(Of moduloValoresFactura) = New List(Of moduloValoresFactura)

    Public nombreCliente As String
    Public headerSaldo As String
    Public headerComentario As String
    Public headerFecha As String
    Public cantidadFilas As Integer


    Sub cargarExploradorClientes()
        MenuPrincipal.mostrarExploradorClientes()
        ExploradorClientes.ultimaModificacion()
    End Sub

    Sub cargarExploradorProveedores()
        MenuPrincipal.mostrarExploradorProveedores()
        ExploradorProveedores.ultimaModificacion()
    End Sub


    Sub cargarProductos()
        MenuPrincipal.mostrarProductos()
    End Sub





End Module
