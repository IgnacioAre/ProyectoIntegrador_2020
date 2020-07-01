﻿Imports MySql.Data.MySqlClient
Public Class Conexion


    Private conexion As New MySqlConnection("data source=localhost;user id=proyecto;password='proyecto2020';database=original_el_cofre")
    Private adaptador As MySqlDataAdapter
    Private comando As MySqlCommand
    Private dataReader As MySqlDataReader

    Private consultaSQL As String
    Private tabla As DataTable

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

        consultaSQL = "SELECT idProducto AS id," &
                        "nombre AS Nombre," &
                        "cantidad AS Stock," &
                        "precio AS Precio " &
                        "FROM producto"

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

    '----BUSCAR CLIENTE POR NOMBRE----
    Public Function mostrarBusquedaClientesEnTabla(ByVal nombre As String) As DataTable

        consultaSQL = "SELECT * FROM clientes WHERE nombre LIKE '%" & nombre & "%'"

        Return insertarEnTabla(consultaSQL)

    End Function
End Class
