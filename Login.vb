Imports System.ComponentModel

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Parent = PictureBox1
        TxtNombre.Text = "admin"
        TxtPass.Text = "admin"
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Visible = True
        My.Computer.Audio.Play(My.Resources.TakeOnMe, AudioPlayMode.Background)
    End Sub
    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Enter Then

            PictureBox2.Visible = False
            PictureBox2.Visible = True
            GroupBox1.Visible = True
            GroupBox1.Enabled = True
            GroupBox3.Visible = True
            GroupBox3.Enabled = True
            GroupBox1.Parent = PictureBox1
            My.Computer.Audio.Stop()


        End If


    End Sub


    Dim bsnUsuario As New BsnUsuario()
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BtnAceptar.Click

        Dim usuario As New Usuarios()
        usuario.Nick = TxtNombre.Text
        usuario.Password = TxtPass.Text


        'If bsnUsuario.ValidarUsuario(usuario) Then

        frmPrincipal.Visible = True
            Me.Hide()



        'Else
        'MsgBox("Usuario incorrecto", MsgBoxStyle.Information, "Alerta")
        'End If


    End Sub

    Private Sub Login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Snake.Visible = True
        Me.Visible = False

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmAgregarUsuario.Show()

    End Sub

    Private Sub Login_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress



        PictureBox2.Visible = False
            My.Computer.Audio.Stop()



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
