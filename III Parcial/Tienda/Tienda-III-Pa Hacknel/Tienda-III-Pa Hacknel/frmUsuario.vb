﻿Imports System.Text.RegularExpressions
Imports System.Globalization.CultureInfo
Imports System
Public Class frmUsuario
    Dim conexion As New conexion()
    Dim cultureInfo As New System.Globalization.CultureInfo("es-MX")

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    'username@midominio.com
    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function


    Private Sub limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtUserName.Clear()
        txtPsw.Clear()
        txtCorreo.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCorreo(LCase(txtCorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreo.Focus()
            txtCorreo.SelectAll()
        Else
            insertarUsuaurio()
            MessageBox.Show("Correo valido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub
    Private Sub insertarUsuaurio()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol, estado As String
        idUsuario = txtCodigo.Text
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        userName = txtUserName.Text
        psw = txtPsw.Text
        correo = txtCorreo.Text
        estado = "activo"
        rol = cmbRol.Text
        Try
            If conexion.insertarUsuario(idUsuario, fTCase(nombre), fTCase(apellido), userName, psw, fTCase(rol), fTCase(estado), LCase(correo)) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        decri.Text = conexion.Encriptar(encri.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        decri.Text = conexion.Desencriptar(encri.Text)
    End Sub

    Function fTCase(str As String) As String
        'Return cultureInfo.TextInfo.ToTitleCase(str)
        Return StrConv(str, VbStrConv.ProperCase)
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        conexion.eliminarUsuario(Val(txtCodigo.Text), cmbRol.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conexion.buscarYLlenarDGV(dgv1, txtUsuarioB.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If conexion.comprobarExistencias("select idUsuario from usuario where idUsuario = '" & txtCodigo.Text & "'") = 1 Then
            txtNombre.Text = conexion.llenarObj("select * from usuario where idUsuario = '" & txtCodigo.Text & "'", "nombre")
            txtApellido.Text = conexion.llenarObj("select * from usuario where idUsuario = '" & txtCodigo.Text & "'", "apellido")
            txtUserName.Text = conexion.llenarObj("select * from usuario where idUsuario = '" & txtCodigo.Text & "'", "nombreUsuario")
            txtPsw.Text = conexion.Desencriptar(conexion.llenarObj("select * from usuario where idUsuario = '" & txtCodigo.Text & "'", "psw"))
            cmbRol.Text = conexion.llenarObj("select * from usuario where idUsuario = '" & txtCodigo.Text & "'", "rol")
            txtCorreo.Text = conexion.llenarObj("select * from usuario where idUsuario = '" & txtCodigo.Text & "'", "correo")
        Else
            MessageBox.Show("El usuario con codigo " + txtCodigo.Text + " no existe", "Error de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If conexion.modificar(Val(txtCodigo.Text), fTCase(txtNombre.Text), fTCase(txtApellido.Text), txtUserName.Text, txtPsw.Text, fTCase(cmbRol.Text), LCase(txtCorreo.Text)) Then
                MessageBox.Show("Modificado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
