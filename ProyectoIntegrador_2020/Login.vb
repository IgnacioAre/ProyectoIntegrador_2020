Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class Login

    Public resultado As Byte = 0
    Dim drRes As MySqlDataReader

    '----CLAVE PARA CREAR UN USUARIO ADMIN----'
    Dim claveAdmin As String = "7r7w7x"

    '----INICIO DEL FORMULARIO----'

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conectar = New Conexion
        conectar.establecerConexion()
        SendMessage(txtUsuarioLogin.Handle, EM_SETCUEBANNER, 0, "Nombre de usuario")
        SendMessage(txtContraseñaLogin.Handle, EM_SETCUEBANNER, 0, "*******************")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '----MÉTODOS PARA MOVER EL FORMULARIO----'

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelTitulo_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub lblTitulo_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    '----PLACEHOLDERS----'

    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function


    '----CAMBIAR FOCO A LA CONTRASEÑA----'

    Private Sub txtUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuarioLogin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtContraseñaLogin.Focus()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkCrearUsuario.LinkClicked
        panelLogin.Visible = False
        panelRegistro.Visible = True
        lblTitulo.Text = "Registrarse  |  El Cofre"
        txtUsuarioRegistro.Focus()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        panelLogin.Visible = True
        panelRegistro.Visible = False
        lblTitulo.Text = "Login  |  El Cofre"
        txtUsuarioLogin.Focus()
    End Sub

    '----CAMBIAR TAMAÑO DEL pbRegresar----'

    Private Sub pbRegresar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.MouseHover
        pbRegresar.Size = New Size(34, 36)
    End Sub

    Private Sub pbRegresar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.MouseLeave
        pbRegresar.Size = New Size(31, 32)
    End Sub

    '----ENTRA AL MENÚ PRINCIPAL----'

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Try
            consultaReturnHide("Select usuario,contraseña from admin where usuario = '" & txtUsuarioLogin.Text.ToUpper & "' and contraseña = sha2('" & txtContraseñaLogin.Text & "',256);")
            MsgBox(drRes(0))
            If drRes.HasRows() Then
                MenuPrincipal.Show()
                Me.Close()
            Else
                mostrarMensaje("No se encuentra un usuario con esos datos." & vbCrLf & "Intentelo nuevamente.")
            End If
            
        Catch ex As Exception
            mostrarMensaje("Error: " & ex.Message)
        End Try
    End Sub

    '----LE DA EL CECK AL CLICKEAR LA ETIQUETA----'

    Private Sub lblCheckUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCheckUsuario.Click
        If chbGuardarUsuario.Checked Then
            chbGuardarUsuario.Checked = False
        Else
            chbGuardarUsuario.Checked = True
        End If
    End Sub

    '----CREA UN USUARIO ADMINISTRADOR----'

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If txtClaveAdminRegistro.Text.Equals(claveAdmin) Then
            If Not txtUsuarioRegistro.Text.Equals("") And Not txtContraseñaRegistro.Text.Equals("") And Not txtRepContraseñaRegistro.Text.Equals("") Then
                consultaHide("Insert into admin (usuario,contraseña) values ('" & txtUsuarioRegistro.Text.ToUpper & "',sha2('" & txtContraseñaRegistro.Text & "',256));")
                If resultado = 1 Then
                    mostrarMensaje("Usuario creado exitosamente!")
                    txtUsuarioRegistro.Text = ""
                    txtContraseñaRegistro.Text = ""
                    txtRepContraseñaRegistro.Text = ""
                    txtClaveAdminRegistro.Text = ""
                Else
                    mostrarMensaje("Error al intentar crear usuario.")
                End If

            Else
                mostrarMensaje("Error. Debe completar todos los campos vacios.")
            End If
        Else
            mostrarMensaje("La clave de administrador es incorrecta." & vbCrLf & "Intentelo nuevamente.")
        End If

        resultado = 0
    End Sub

    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
        mensaje.Show()
    End Sub

    '----REALIZAR CONSULTA----'

    Private Sub consultaHide(ByVal consultaSQL As String)
        Try
            Dim conectar = New Conexion
            conectar.consultaHide(consultaSQL)
        Catch ex As Exception
            mostrarMensaje("Error al realizar consulta: " & ex.Message)
        End Try
    End Sub

    Private Sub consultaReturnHide(ByVal consultaSQL As String)
        Try
            Dim conectar = New Conexion
            drRes = conectar.consultaReturnHide(consultaSQL)
        Catch ex As Exception
            mostrarMensaje("Error al realizar consulta: " & ex.Message)
        End Try
    End Sub



End Class