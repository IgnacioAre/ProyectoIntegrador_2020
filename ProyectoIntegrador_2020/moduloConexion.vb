Imports MySql.Data.MySqlClient
Public Class moduloConexion


    Private conexion As New MySqlConnection("data source=localhost;user id=proyecto;password='proyecto2020';database=elcofre;port=3306;CHARSET=utf8;")
    Private adaptador As MySqlDataAdapter
    Private comando As MySqlCommand
    Private Query As Queryable
    Private dr As MySqlDataReader
    Protected ds As DataSet

    Public resultado As Byte = 0
    Public valorReturn As String = ""

    Private consultaSQL As String
    Private tabla As DataTable

    Public Sub establecerConexion()
        Try
            conexion.Open()
        Catch ex As Exception
            mostrarMensaje("Error al conectar a la base de datos. " & ex.Message)
        Finally
            conexion.Dispose()
        End Try
    End Sub

    'ESTOS METODOS NO SE PUEDEN ACCEDER DESDE OTRO FORMULARIO

    Private Sub consultaHideEstructura(ByVal Sql As String)

        Try
            conexion.Open()
            comando = New MySqlCommand(Sql, conexion)
            comando.ExecuteNonQuery()
            resultado = 1
            conexion.Close()
        Catch ex As Exception
            resultado = 0
            mostrarMensaje("Error al conectar con la base de datos " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Function consultaReturnHideEstructura(ByVal Sql As String) As String
        Try
            conexion.Open()
            comando = New MySqlCommand(Sql, conexion)
            valorReturn = ""
            valorReturn = comando.ExecuteScalar()
        Catch ex As Exception
            mostrarMensaje("Error al conectar con la base de datos " & ex.Message)
        Finally
            conexion.Close()
        End Try
        Return valorReturn
    End Function


    '----CONSULTAS MYSQL GLOBALES----'

    Public Sub consultaHide(ByVal consultaSQL As String)
        Try
            consultaHideEstructura(consultaSQL)
        Catch ex As Exception
            mostrarMensaje("Error al realizar consulta: " & ex.Message)
        End Try
    End Sub

    Public Sub consultaReturnHide(ByVal consultaSQL As String)
        Try
            consultaReturnHideEstructura(consultaSQL)
        Catch ex As Exception
            mostrarMensaje("Error al realizar consulta: " & ex.Message)
        End Try
    End Sub


    Private Function consultaReturnHideVariosValores(ByVal Sql As String) As String
        Try
            conexion.Open()
            comando = New MySqlCommand(Sql, conexion)
            dr = comando.ExecuteScalar
        Catch ex As Exception
            mostrarMensaje("Error al conectar con la base de datos " & ex.Message)
        Finally
            conexion.Close()
        End Try
        Return valorReturn
    End Function

    Private Function insertarEnTabla(ByVal consulta As String) As DataTable
        Try
            adaptador = New MySqlDataAdapter(consulta, Me.conexion)
            Me.tabla = New DataTable
            adaptador.Fill(tabla)
            resultado = 1
        Catch ex As Exception
            mostrarMensaje("Error al conectar con la base de datos " & ex.Message)
        Finally
            conexion.Close()
        End Try
        Return Me.tabla
    End Function


    '----MOSTRAR NOMBRE Y PRECIO DE LA TABLA PRODUCTO EN UN DATATABLE----'
    Public Function mostrarRapidoProductoEnTabla() As DataTable

        consultaSQL = "SELECT nombre AS Nombre," & " CONCAT_WS(' ',cantidadUnidad,unidad) as Medida, precioVenta AS 'Precio Venta' " & "FROM productos where nombre like '%" & MenuPrincipal.txtPrecioProductos.Text & "%'"

        Return insertarEnTabla(consultaSQL)

    End Function


    '----BUSCAR CLIENTE POR NOMBRE----'
    Public Function mostrarEnTabla(ByVal consulta As String) As DataTable

        Return insertarEnTabla(consulta)
    End Function


    '----CONSULTA PARA LA GRÁFICA----'

    Public Function consultarGrafica(ByVal sql As String) As DataSet
        Dim ds As New DataSet

        Try
            Dim reader As New MySqlDataAdapter(sql, Me.conexion)
            reader.Fill(ds, "Historial")
        Catch ex As Exception
            mostrarMensaje(ex.ToString)
        End Try

        Return ds
    End Function


    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub

End Class
