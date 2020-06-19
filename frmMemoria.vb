Public Class frmMemoria



    Private random As New Random
    Private icons = New List(Of String) From {"A", "A", "B", "B", "C", "C", "D", "D",
                                              "E", "E", "F", "F", "G", "G", "H", "H"}


    Private primerclick As Label = Nothing
    Private segundoclick As Label = Nothing


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        asignariconos()
    End Sub

    Private Sub asignariconos()

        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber = random.Next(icons.Count)
                iconLabel.Text = icons(randomNumber)
                iconLabel.ForeColor = iconLabel.BackColor
                icons.RemoveAt(randomNumber)
            End If
        Next

    End Sub


    Private Sub label_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label16.Click, Label15.Click, Label14.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click

            If Timer1.Enabled Then Exit Sub

            Dim clickedLabel = TryCast(sender, Label)

            If clickedLabel IsNot Nothing Then


            If clickedLabel.ForeColor = Color.WhiteSmoke Then Exit Sub


            If primerclick Is Nothing Then
                primerclick = clickedLabel
                Label17.Text = ""
                primerclick.ForeColor = Color.WhiteSmoke
                Exit Sub
                End If

            segundoclick = clickedLabel
            segundoclick.ForeColor = Color.WhiteSmoke


            ganaste()


            If primerclick.Text = segundoclick.Text Then
                Label17.BackColor = Color.Green

                Label17.Text = "Acertaste"


                primerclick = Nothing
                segundoclick = Nothing
                Exit Sub
            Else
                Label17.BackColor = Color.Red
                Label17.Text = "Fallaste"


            End If

            Timer1.Start()

        End If
        End Sub


        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label17.Text = ""
        Timer1.Stop()


            primerclick.ForeColor = primerclick.BackColor
            segundoclick.ForeColor = segundoclick.BackColor


        primerclick = Nothing
        segundoclick = Nothing
        End Sub

    Private Sub ganaste()


        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing AndAlso
               iconLabel.ForeColor = iconLabel.BackColor Then Exit Sub
        Next


        Dim result As Integer = MessageBox.Show("Desea volver a jugar ?", "Ganaste", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                                                )
        If result = DialogResult.Yes Then
            Dim nuevo As New frmMemoria
            nuevo.Show()
            Me.Dispose()
        End If
        If result = DialogResult.No Then

            frmPrincipal.Show()
            Me.Dispose()

        End If



        Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmPrincipal.Show()

        Me.Dispose()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
