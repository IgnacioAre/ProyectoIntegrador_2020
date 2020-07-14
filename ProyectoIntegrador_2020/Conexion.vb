﻿Imports MySql.Data.MySqlClient
Public Class Conexion


    Private conexion As New MySqlConnection("data source=localhost;user id=proyecto;password='proyecto2020';database=elcofre;port=3306")
    Private adaptador As MySqlDataAdapter
    Private comando As MySqlCommand
    Private Query As Queryable
    Private dr As MySqlDataReader
    Protected ds As DataSet

    Private valorReturn As String = ""

    Private consultaSQL As String
    Private tabla As DataTable

    Public Sub establecerConexion()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos. " & ex.Message)
        Finally
            conexion.Dispose()
        End Try
    End Sub

    '----REALIZA UNA CONSULTA A LA BASE DE DATOS (Sale una excepción)----'

    Private Sub consultaHideEstructura(ByVal Sql As String)

        Try
            conexion.Open()
            comando = New MySqlCommand(Sql, conexion)
            comando.ExecuteNonQuery()
            Login.resultado = 1
            conexion.Close()
        Catch ex As Exception
            Login.resultado = 0
            MsgBox("Error al conectar con la base de datos " & ex.Message, vbOKOnly + vbDefaultButton2, "Error")
        Finally
            conexion.Close()
        End Try
    End Sub


    Public Function consultaReturnHideEstructura(ByVal Sql As String) As String
        Try
            conexion.Open()
            comando = New MySqlCommand(Sql, conexion)
            valorReturn = comando.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos " & ex.Message, vbOKOnly + vbDefaultButton2, "Error")
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
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conexion.Close()
        End Try
        Return Me.tabla
    End Function

    


    '----MOSTRAR TODO DE LA TABLA PRODUCTO EN UN DATATABLE----'

    Public Function mostrarProductosEnTabla() As DataTable

        consultaSQL = "SELECT idProducto AS ID," &
                        "nombre AS Nombre," &
                        "cantidad AS Stock," &
                        "precio AS Precio " &
                        "FROM producto"

        Return insertarEnTabla(consultaSQL)

    End Function

    '----CONSULTAS MySQL----'

    Public Sub consultaHide(ByVal consultaSQL As String)
        Try
            consultaHideEstructura(consultaSQL)
        Catch ex As Exception
            mostrarMensaje("Error al realizar consulta: " & ex.Message)
        End Try
    End Sub

    Public Sub consultaReturnHide(ByVal consultaSQL As String)
        Try
            Login.resultadoTxt = consultaReturnHideEstructura(consultaSQL)
        Catch ex As Exception
            mostrarMensaje("Error al realizar consulta: " & ex.Message)
        End Try
    End Sub

    '----MOSTRAR NOMBRE Y PRECIO DE LA TABLA PRODUCTO EN UN DATATABLE----'
    Public Function mostrarRapidoProductoEnTabla() As DataTable

        consultaSQL = "SELECT nombre AS Nombre," &
                                    "precio AS Precio " &
                                     "FROM producto where nombre like '%" & MenuPrincipal.txtPrecioProductos.Text & "%'"

        Return insertarEnTabla(consultaSQL)

    End Function

    '----MOSTRAR TODO DE LA TABLA PROVEEDORES EN UN DATATABLE----'
    Public Function mostrarProveedoresEnTabla() As DataTable

        consultaSQL = "SELECT * FROM proveedores"

        Return insertarEnTabla(consultaSQL)

    End Function

    '----MOSTRAR TODO DE LA TABLA CLIENTES EN UN DATATABLE----'
    Public Function mostrarClientesEnTabla() As DataTable

        consultaSQL = "SELECT * FROM clientes"

        Return insertarEnTabla(consultaSQL)

    End Function

    '----BUSCAR CLIENTE POR NOMBRE----'
    Public Function mostrarBusquedaClientesEnTabla(ByVal nombre As String) As DataTable

        consultaSQL = "SELECT * FROM clientes WHERE nombre LIKE '%" & nombre & "%'"

        Return insertarEnTabla(consultaSQL)
    End Function

    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
        mensaje.Show()
    End Sub

End Class
