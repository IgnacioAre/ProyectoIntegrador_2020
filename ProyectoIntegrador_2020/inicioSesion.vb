Imports System.Runtime.InteropServices
Imports System.IO
Public Class inicioSesion

    Dim consultas As moduloConexion = New moduloConexion
    Dim ruta As String = "./usuario/"
    Dim archivoGuardarNombreUsr As String = "usuario.txt"
    Dim resultado As Byte
    Dim resultadoEntrada As String

    '----CLAVE PARA CREAR UN USUARIO ADMIN----'
    Dim claveAdmin As String = "7r7w7x"

    '----INICIO DEL FORMULARIO----'

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtContraseñaLogin.UseSystemPasswordChar = True
        Me.ToolTip1.SetToolTip(lblAceptable1, "La contraseña debe contenter al menos 8 caracteres.")
        Me.ToolTip2.SetToolTip(lblAceptable2, "Las contraseñas deben coincidir.")
        Me.ttpAdmin.SetToolTip(txtClaveAdminRegistro, "Consulte la clave con el creador del software.")
        leerUsuarioTxt()
        SendMessage(txtUsuarioLogin.Handle, EM_SETCUEBANNER, 0, "Nombre de usuario")
        SendMessage(txtUsuarioRegistro.Handle, EM_SETCUEBANNER, 0, "Ej: Admin")
        consultas.establecerConexion()
        If Not txtUsuarioLogin.Text.Equals("") Then
            chbGuardarUsuario.Checked = True
            txtContraseñaLogin.Select()
            txtContraseñaLogin.Focus()
        Else
            txtUsuarioLogin.Select()
            txtUsuarioLogin.Focus()
        End If

    End Sub


    '----CIERRA EL FORUMULARIO DEL MENÚ (FINALIZA SU EJECUCIÓN)----'

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        End
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
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
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

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
        limpiarRegistro()
        lblTitulo.Text = "Iniciar Sesión  |  El Cofre"
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
        Entrar()
    End Sub


    Sub Entrar()
        
        Try
            consultas.consultaReturnHide("Select usuario,contraseña from admin where usuario = '" & txtUsuarioLogin.Text.ToUpper & "' and contraseña = AES_ENCRYPT('" & txtContraseñaLogin.Text & "','2@17501896');")

            If Not consultas.valorReturn = "" Then
                If chbGuardarUsuario.Checked Then
                    guardarUsuarioTxt(txtUsuarioLogin.Text.ToUpper)
                Else
                    guardarUsuarioTxt("")
                End If


                consultas.consultaHide("UPDATE Admin set logeadoBool=0")
                consultas.consultaReturnHide("Select idAdmin from admin where usuario = '" & txtUsuarioLogin.Text & "' and contraseña = AES_ENCRYPT('" & txtContraseñaLogin.Text & "','2@17501896');")
                consultas.consultaHide("UPDATE Admin set logeadoBool=1 where idAdmin=" & consultas.valorReturn)
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
        crearUsuarioAdmin()
    End Sub

    '----LE DA EL CECK AL CLICKEAR LA ETIQUETA----'

    Private Sub lblCheckUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCheckUsuario.Click
        If chbGuardarUsuario.Checked Then
            chbGuardarUsuario.Checked = False
        Else
            chbGuardarUsuario.Checked = True
        End If
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

            If txtRepContraseñaRegistro.Text.Count >= 8 And txtRepContraseñaRegistro.Text.Equals(txtContraseñaRegistro.Text) Then
                lblAceptable2.Text = "✓"
                lblAceptable2.ForeColor = Color.Green
            Else
                lblAceptable2.Text = "X"
                lblAceptable2.ForeColor = Color.Red
            End If

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

        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True

            If e.KeyChar = ChrW(Keys.Enter) Then
                Entrar()
            End If

        End If


    End Sub




    Private Sub txtClaveAdminRegistro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClaveAdminRegistro.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            crearUsuarioAdmin()
        Else
            If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
                e.Handled = True

                If Char.IsLetter(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsSeparator(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If

            End If
        End If
        
    End Sub



    Sub crearUsuarioAdmin()
        If txtClaveAdminRegistro.Text.Equals(claveAdmin) Then
            If Not txtUsuarioRegistro.Text.Equals("") And Not txtContraseñaRegistro.Text.Equals("") And Not txtRepContraseñaRegistro.Text.Equals("") And Not txtCorreo.Text.Equals("") Then
                If Not txtContraseñaRegistro.Text.Equals(txtRepContraseñaRegistro.Text) Then
                    mostrarMensaje("Las contraseñas no coinciden." & vbCrLf & "Intente nuevamente.")
                Else

                    consultas.consultaReturnHide("Select usuario from admin where usuario= '" & txtUsuarioRegistro.Text.ToUpper & "'")
                    If Not consultas.valorReturn = "" Then
                        mostrarMensaje("Ya existe un usuario registrado con ese nombre." & vbCrLf & "Intente con otro nombre de usuario.")
                    Else

                        consultas.consultaHide("Insert into admin (usuario,contraseña,correo,logeadoBool) values ('" & txtUsuarioRegistro.Text.ToUpper & "', AES_ENCRYPT('" & txtContraseñaRegistro.Text & "','2@17501896'),'" & txtCorreo.Text & "',0);")
                        If consultas.resultado = 1 Then
                            mostrarMensaje("Usuario creado exitosamente!")
                            txtUsuarioLogin.Text = txtUsuarioRegistro.Text
                            limpiarRegistro()
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
    End Sub



    Sub limpiarRegistro()
        txtUsuarioRegistro.Text = ""
        txtContraseñaRegistro.Text = ""
        txtRepContraseñaRegistro.Text = ""
        txtClaveAdminRegistro.Text = ""
        txtCorreo.Text = ""
        panelLogin.Visible = True
        panelRegistro.Visible = False
        txtContraseñaLogin.Select()
        txtContraseñaLogin.Focus()
    End Sub


    '----MENSAJE PERSONALIZADO----'

    Private Sub mostrarMensaje(ByVal mensajeObtenido As String)
        Dim mensaje As New Mensaje(mensajeObtenido)
    End Sub

    Private Sub pbMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbMostrar.Click
        pbEsconder.Visible = True
        pbMostrar.Visible = False
        panelOjo.BackColor = Color.LightGray
        txtContraseñaLogin.UseSystemPasswordChar = False
    End Sub

    Private Sub pbEsconder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbEsconder.Click
        pbEsconder.Visible = False
        pbMostrar.Visible = True
        panelOjo.BackColor = Color.White
        txtContraseñaLogin.UseSystemPasswordChar = True
    End Sub

    Private Sub txtUsuarioRegistro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuarioRegistro.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub


    Private Sub txtContraseñaRegistro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseñaRegistro.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtRepContraseñaRegistro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRepContraseñaRegistro.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True

            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub linkRecuperarContraseña_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkRecuperarContraseña.LinkClicked
        Dim usuario As String = ""

        ConfirmacionMensaje.btnAceptar.Text = "Si"
        ConfirmacionMensaje.btnCancelar.Text = "No"
        resultado = ConfirmacionMensaje.confirmacion("  ¿Quiere que le envien su contraseña" & vbCrLf & "    al correo asociado a su cuenta?")

        If resultado = 1 Then
            Do
                ConfirmacionMensaje.btnAceptar.Text = "Aceptar"
                ConfirmacionMensaje.btnCancelar.Text = "Cancelar"
                ConfirmacionMensaje.entradaDatos("Ingrese su nombre de usuario:")
                resultadoEntrada = ConfirmacionMensaje.resultadoTxt
            Loop While resultadoEntrada = "" And ConfirmacionMensaje.resultado = 1

            If ConfirmacionMensaje.resultado = 1 Then
                If Not resultadoEntrada = "" Then
                    usuario = resultadoEntrada
                    ConfirmacionMensaje.resultadoTxt = ""
                    Do
                        ConfirmacionMensaje.txtEntrada.PasswordChar = "*"
                        ConfirmacionMensaje.btnAceptar.Text = "Aceptar"
                        ConfirmacionMensaje.btnCancelar.Text = "Cancelar"
                        ConfirmacionMensaje.entradaDatos("Ingrese la clave de administrador:")
                        resultadoEntrada = ConfirmacionMensaje.resultadoTxt
                    Loop While resultadoEntrada = "" And ConfirmacionMensaje.resultado = 1

                    If ConfirmacionMensaje.resultado = 1 Then
                        If resultadoEntrada = "7r7w7x" Then
                            ConfirmacionMensaje.resultadoTxt = ""
                            consultas.consultaReturnHide("SELECT CAST(aes_decrypt(contraseña,'2@17501896') as char) FROM Admin where usuario='" & usuario & "';")
                            If Not consultas.valorReturn = "" Then
                                Dim contraseña As String = consultas.valorReturn
                                consultas.consultaReturnHide("SELECT correo FROM Admin where usuario='" & usuario & "';")
                                Dim correo As String = consultas.valorReturn
                                mostrarMensaje("Espere por favor, en un momento le llegará la confirmación.")
                                enviarCorreo("new.visual@edusalto.uy", "newvisual@2020", usuario & " su contraseña es: " & contraseña, "Contraseña de ingreso", correo)
                            Else
                                mostrarMensaje("No existe un usuario con ese nombre.")
                            End If
                        Else
                            mostrarMensaje("  La clave de admin es erronea." & vbCrLf & "  Intente nuevamente.")
                        End If
                    End If

                Else
                    mostrarMensaje("  No existe un usuario con ese nombre." & vbCrLf & "  Asegurese que este bien escrito.")
                End If
            End If
            
        End If

        ConfirmacionMensaje.txtEntrada.PasswordChar = ""
    End Sub

    Private Sub txtCorreo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCorreo.KeyPress
        If Not (IsNumeric(e.KeyChar)) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 64 And Asc(e.KeyChar) <> 46 Then
            e.Handled = True

            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub
End Class