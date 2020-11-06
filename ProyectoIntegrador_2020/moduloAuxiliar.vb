Module moduloAuxiliar



    Public headerSaldo As String
    Public headerComentario As String
    Public headerFecha As String

    Public valueSaldo As String
    Public valuesComentario As String
    Public valuesFecha As String

    Public cantidadRegistroInforme As Integer

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


    Function cantidadRegistro() As Integer
        cantidadRegistroInforme = buscarInforme.obtenerCantidadRegistro()
        Return cantidadRegistroInforme
    End Function

    



End Module
