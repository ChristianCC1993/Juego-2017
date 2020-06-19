Public Class frmAgregarUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim bsnusuario As New BsnUsuario
        Dim usuario As New Usuarios
        If txtPass1.Text.Equals(txtPass2.Text) Then
            usuario.Password = txtPass1.Text
        End If

        usuario.Nombre = txtNombre.Text
        usuario.Apellido = txtApellido.Text
        usuario.Nick = txtNick.Text

        bsnusuario.AgregarUsuario(usuario)

    End Sub
End Class