Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Login

    Dim conectar = New Conexion
    Public resultado As Byte
    Public resultadoTxt As String
    Dim drRes As MySqlDataReader
    Dim ruta As String = "./usuario/"
    Dim archivoGuardarNombreUsr As String = "usuario.txt"

    '----CLAVE PARA CREAR UN USUARIO ADMIN----'
    Dim claveAdmin As String = "7r7w7x"

    '----INICIO DEL FORMULARIO----'

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtContraseñaLogin.UseSystemPasswordChar = True
        Me.ToolTip1.SetToolTip(lblAceptable1, "La contraseña debe contenter al menos 8 caracteres.")
        Me.ToolTip2.SetToolTip(lblAceptable2, "Las contraseñas deben coincidir.")
        leerUsuarioTxt()
        If Not txtUsuarioLogin.Text.Equals("") Then
            chbGuardarUsuario.Checked = True
            txtContraseñaLogin.Focus()
        Else
            txtUsuarioLogin.Focus()
        End If
        conectar.establecerConexion()
        SendMessage(txtUsuarioLogin.Handle, EM_SETCUEBANNER, 0, "Nombre de usuario")
        SendMessage(txtUsuarioRegistro.Handle, EM_SETCUEBANNER, 0, "Ej: Admin")
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
        txtContraseñaLogin.Text = ""
        panelLogin.Visible = False
        panelRegistro.Visible = True
        lblTitulo.Text = "Registrarse  |  El Cofre"
        txtUsuarioRegistro.Focus()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        txtUsuarioRegistro.Text = ""
        txtContraseñaRegistro.Text = ""
        txtRepContraseñaRegistro.Text = ""
        txtClaveAdminRegistro.Text = ""
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

    '----ENTRA AL MENÚ PRINCIPAL (VALIDACIÓN EN LOGIN)----'

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Try
            conectar.consultaReturnHide("Select usuario,contraseña from admin where usuario = '" & txtUsuarioLogin.Text.ToUpper & "' and contraseña = sha2('" & txtContraseñaLogin.Text & "',256);")

            If Not resultadoTxt = "" Then
                If chbGuardarUsuario.Checked Then
                    guardarUsuarioTxt(txtUsuarioLogin.Text.ToUpper)
                Else
                    guardarUsuarioTxt("")
                End If
                MenuPrincipal.Show()
                Me.Close()
            Else
                mostrarMensaje("No se encuentra un usuario con esos datos." & vbCrLf & "Intentelo nuevamente.")
            End If

        Catch ex As Exception
            mostrarMensaje("Error: " & ex.Message)
        End Try

    End Sub


    '----CREAR UN USUARIO ADMINISTRADOR----'

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If txtClaveAdminRegistro.Text.Equals(claveAdmin) Then
            If Not txtUsuarioRegistro.Text.Equals("") And Not txtContraseñaRegistro.Text.Equals("") And Not txtRepContraseñaRegistro.Text.Equals("") Then
                If Not txtContraseñaRegistro.Text.Equals(txtRepContraseñaRegistro.Text) Then
                    mostrarMensaje("Las contraseñas no coinciden." & vbCrLf & "Intente nuevamente.")
                Else

                    conectar.consultaReturnHide("Select usuario from admin where usuario= '" & txtUsuarioRegistro.Text.ToUpper & "'")
                    If Not resultadoTxt = "" Then
                        mostrarMensaje("Ya existe un usuario registrado con ese nombre." & vbCrLf & "Intente con otro nombre de usuario.")
                    Else

                        conectar.consultaHide("Insert into admin (usuario,contraseña) values ('" & txtUsuarioRegistro.Text.ToUpper & "',sha2('" & txtContraseñaRegistro.Text & "',256));")
                        If resultado = 1 Then
                            mostrarMensaje("Usuario creado exitosamente!")
                            txtUsuarioRegistro.Text = ""
                            txtContraseñaRegistro.Text = ""
                            txtRepContraseñaRegistro.Text = ""
                            txtClaveAdminRegistro.Text = ""
                            panelRegistro.Hide()
                            panelLogin.Show()
                        Else
                            mostrarMensaje("Error al intentar crear usuario.")
                        End If
                    End If
                End If
            Else
                mostrarMensaje("Error. Debe completar todos los campos vacios.")

            End If
        Else
            mostrarMensaje("La clave de administrador es incorrecta." & vbCrLf & "Intentelo nuevamente.")
        End If

        resultado = 0
    End Sub

    '----LE DA EL CECK AL CLICKEAR LA ETIQUETA----'

    Private Sub lblCheckUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCheckUsuario.Click
        If chbGuardarUsuario.Checked Then
            chbGuardarUsuario.Checked = False
        Else
            chbGuardarUsuario.Checked = True
        End If
    End Sub

    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
        mensaje.Show()
    End Sub


    '----SI LE MARCÓ PARA GUARDAR USUARIO, ENTONCES CREAMOS UN ARCHIVO TXT CON EL NOMBRE DE USUARIO.----'

    Private Sub guardarUsuarioTxt(ByVal nomUsuario As String)

        Dim fs As FileStream

        '----Validamos si la carpeta de ruta existe, si no existe la creamos----'
        Try
            If File.Exists(ruta) Then

                '----Si la carpeta existe creamos o sobreescribios el archivo txt----'
                fs = File.Create(ruta & archivoGuardarNombreUsr)
                fs.Close()

                '----Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT----'
                Dim escribir As New StreamWriter(ruta & archivoGuardarNombreUsr)
                Try
                    '----Escribimos una linea en nuestro archivo TXT----'
                    escribir.WriteLine(nomUsuario)
                    escribir.Close()
                Catch ex As Exception
                    mostrarMensaje("Error al intentar crear el archivo." & vbCrLf & ex.Message)
                End Try
            Else

                '----Si la carpeta no existe la creamos----'
                Directory.CreateDirectory(ruta)

                '----Una vez creada la carpeta creamos o sobreescribios el archivo txt----'
                fs = File.Create(ruta & archivoGuardarNombreUsr)
                fs.Close()

                '----Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT----'
                Dim escribir As New StreamWriter(ruta & archivoGuardarNombreUsr)
                Try
                    '----Escribimos una linea en nuestro archivo TXT----'
                    escribir.WriteLine(nomUsuario)
                    escribir.Close()
                Catch ex As Exception
                    mostrarMensaje("Se presento un problema al escribir en el archivo: " & vbCrLf & ex.Message)
                End Try

            End If

        Catch ex As Exception
            mostrarMensaje("Error al intentar crear el archivo." & vbCrLf & ex.Message)
        End Try

    End Sub


    '----LEER NOMBRE DE USUARIO DEL ARCHIVO TXT----'

    Private Sub leerUsuarioTxt()
        Dim leer As New StreamReader(ruta & archivoGuardarNombreUsr)

        Try
            ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
            While leer.Peek <> -1
                ':::Leemos cada linea del archivo TXT
                Dim linea As String = leer.ReadLine()
                ':::Validamos que la linea no este vacia
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                ':::Agregramos los registros encontrados
                txtUsuarioLogin.Text = linea
            End While

            leer.Close()
        Catch ex As Exception
            mostrarMensaje("Error al intentar leer el archivo de usuario. " & vbCrLf & ex.Message)
        End Try
    End Sub


    '----VALIDACIÓN DE CONTRASEÑAS----'

    Private Sub txtContraseñaRegistro_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContraseñaRegistro.KeyUp
        If Not lblAceptable1.Visible Then
            lblAceptable1.Visible = True
        End If

        If txtContraseñaRegistro.Text.Count >= 8 Then
            lblAceptable1.Text = "✓"
            lblAceptable1.ForeColor = Color.Green
        Else
            lblAceptable1.Text = "X"
            lblAceptable1.ForeColor = Color.Red
        End If
    End Sub


    '----EVENTO DE TECLAS----'

    Private Sub txtRepContraseñaRegistro_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRepContraseñaRegistro.KeyUp
        If Not lblAceptable2.Visible Then
            lblAceptable2.Visible = True
        End If

        If txtRepContraseñaRegistro.Text.Count >= 8 And txtRepContraseñaRegistro.Text.Equals(txtContraseñaRegistro.Text) Then
            lblAceptable2.Text = "✓"
            lblAceptable2.ForeColor = Color.Green
        Else
            lblAceptable2.Text = "X"
            lblAceptable2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtContraseñaLogin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseñaLogin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            Try
                conectar.consultaReturnHide("Select usuario,contraseña from admin where usuario = '" & txtUsuarioLogin.Text.ToUpper & "' and contraseña = sha2('" & txtContraseñaLogin.Text & "',256);")

                If Not resultadoTxt = "" Then
                    If chbGuardarUsuario.Checked Then
                        guardarUsuarioTxt(txtUsuarioLogin.Text.ToUpper)
                    Else
                        guardarUsuarioTxt("")
                    End If
                    MenuPrincipal.Show()
                    Me.Close()
                Else
                    mostrarMensaje("No se encuentra un usuario con esos datos." & vbCrLf & "Intentelo nuevamente.")
                End If

            Catch ex As Exception
                mostrarMensaje("Error: " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub txtClaveAdminRegistro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClaveAdminRegistro.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtClaveAdminRegistro.Text.Equals(claveAdmin) Then
                If Not txtUsuarioRegistro.Text.Equals("") And Not txtContraseñaRegistro.Text.Equals("") And Not txtRepContraseñaRegistro.Text.Equals("") Then
                    If Not txtContraseñaRegistro.Text.Equals(txtRepContraseñaRegistro.Text) Then
                        mostrarMensaje("Las contraseñas no coinciden." & vbCrLf & "Intente nuevamente.")
                    Else

                        conectar.consultaReturnHide("Select usuario from admin where usuario= '" & txtUsuarioRegistro.Text.ToUpper & "'")
                        If Not resultadoTxt = "" Then
                            mostrarMensaje("Ya existe un usuario registrado con ese nombre." & vbCrLf & "Intente con otro nombre de usuario.")
                        Else

                            conectar.consultaHide("Insert into admin (usuario,contraseña) values ('" & txtUsuarioRegistro.Text.ToUpper & "',sha2('" & txtContraseñaRegistro.Text & "',256));")
                            If resultado = 1 Then
                                mostrarMensaje("Usuario creado exitosamente!")
                                txtUsuarioRegistro.Text = ""
                                txtContraseñaRegistro.Text = ""
                                txtRepContraseñaRegistro.Text = ""
                                txtClaveAdminRegistro.Text = ""
                                panelRegistro.Hide()
                                panelLogin.Show()
                            Else
                                mostrarMensaje("Error al intentar crear usuario.")
                            End If
                        End If
                    End If
                Else
                    mostrarMensaje("Error. Debe completar todos los campos vacios.")

                End If
            Else
                mostrarMensaje("La clave de administrador es incorrecta." & vbCrLf & "Intentelo nuevamente.")
            End If

            resultado = 0
        End If
    End Sub

    Private Sub pbMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMostrar.Click
        pbEsconder.Visible = True
        pbMostrar.Visible = False
        txtContraseñaLogin.UseSystemPasswordChar = False
    End Sub

    Private Sub pbEsconder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEsconder.Click
        pbEsconder.Visible = False
        pbMostrar.Visible = True
        txtContraseñaLogin.UseSystemPasswordChar = True
    End Sub
End Class