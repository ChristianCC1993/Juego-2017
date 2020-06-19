Public Class Snake
    Dim velocidad As Integer
    Dim MovDerecha As Boolean
    Dim MovIzquierda As Boolean
    Dim MovArriba As Boolean
    Dim MovAbajo As Boolean
    Dim Alimento As New PictureBox
    Dim CuerpoSerpiente(1800) As PictureBox
    Dim PartesExtras As Integer
    Dim ObstaculosExtra As Integer
    Dim sw As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        velocidad = 14
        PartesExtras = 0
        ObstaculosExtra = 0
        Cabeza.Height = 14
        Cabeza.Width = 14
        Cabeza.Left = 308
        Cabeza.Top = 307
        Score.Text = 0
        GenerarAlimento()
        Cabeza.Parent = Fondo
        Alimento.Parent = Fondo
        marco.Parent = Fondo
        Fondo.Dock = DockStyle.Fill
        GroupBox1.Parent = Fondo
        marco.Visible = True
        marco.Top = 0
        marco.Left = 0
        marco.Width = Me.Width - 14
        marco.Height = 570
        GenerarNuevaParte()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If sw = 0 Then
            MoverSerpiente()
        End If
        If Cabeza.Bounds.IntersectsWith(Alimento.Bounds) Then
            GenerarAlimento()
            GenerarNuevaParte()
        End If
        Label2.Text = "DERECHO: " & Cabeza.Top & ".      IZQUIERDA: " & Cabeza.Left
        '**************************************************************************************

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Or e.KeyValue = Keys.D And MovIzquierda = False Then
            MovDerecha = True
            MovIzquierda = False
            MovArriba = False
            MovAbajo = False
        End If
        If e.KeyValue = Keys.Left Or e.KeyValue = Keys.A And MovDerecha = False Then
            MovIzquierda = True
            MovDerecha = False
            MovArriba = False
            MovAbajo = False
        End If
        If e.KeyValue = Keys.Up Or e.KeyValue = Keys.W And MovAbajo = False Then
            MovIzquierda = False
            MovDerecha = False
            MovArriba = True
            MovAbajo = False
        End If
        If e.KeyValue = Keys.Down Or e.KeyValue = Keys.S And MovArriba = False Then
            MovIzquierda = False
            MovDerecha = False
            MovArriba = False
            MovAbajo = True
        End If
    End Sub
    Private Sub MoverSerpiente()
        Dim x As Integer
        If PartesExtras <> 0 Then
            x = PartesExtras
            If PartesExtras > 1 Then
                Do Until CuerpoSerpiente(2).Location = CuerpoSerpiente(1).Location
                    CuerpoSerpiente(x).Location = CuerpoSerpiente(x - 1).Location
                    x -= 1
                Loop
            End If
            CuerpoSerpiente(1).Location = Cabeza.Location
            CuerpoSerpiente(PartesExtras).Visible = True
            CuerpoSerpiente(PartesExtras).Parent = Fondo
            CuerpoSerpiente(PartesExtras).Parent = marco

        End If

        If MovDerecha = True And Cabeza.Left + Cabeza.Width < Me.ClientRectangle.Width Then
            Cabeza.Left += velocidad
        End If
        If MovIzquierda = True And Cabeza.Left > Me.ClientRectangle.Left Then
            Cabeza.Left -= velocidad
        End If
        If MovArriba = True And Cabeza.Top > Me.ClientRectangle.Top Then
            Cabeza.Top -= velocidad
        End If
        If MovAbajo = True And Cabeza.Top + Cabeza.Width < Me.ClientRectangle.Height Then
            Cabeza.Top += velocidad
        End If
        Colisiones()
    End Sub
    Private Sub GenerarAlimento()
        Dim arriba As New Integer
        Dim izquierda As New Integer
        Dim rnd As New Random
        izquierda = (rnd.Next(10, 50)) * 14
        arriba = (rnd.Next(10, 35)) * 14
        If CuerpoSerpiente(PartesExtras) IsNot Nothing Then
            While (Alimento.Left = Cabeza.Left And Alimento.Top = Cabeza.Top) Or (Alimento.Left = CuerpoSerpiente(PartesExtras).Left And Alimento.Top = CuerpoSerpiente(PartesExtras).Top)
                izquierda = (rnd.Next(10, 50)) * 14
                arriba = (rnd.Next(10, 35)) * 14
            End While
        End If

        Alimento.SizeMode = PictureBoxSizeMode.StretchImage
        Alimento.Image = My.Resources.cur6
        Alimento.BackColor = Color.Transparent
        Alimento.Visible = True
        Alimento.Width = Cabeza.Width
        Alimento.Height = Cabeza.Height
        Alimento.Left = izquierda
        Alimento.Top = arriba
        Controls.Add(Alimento)
        Alimento.Parent = Fondo
        Alimento.Parent = marco
    End Sub

    Private Sub GenerarNuevaParte()
        GenerarAlimento()
        PartesExtras += 1
        CuerpoSerpiente(PartesExtras) = New PictureBox()
        CuerpoSerpiente(PartesExtras).BackColor = Color.Red
        CuerpoSerpiente(PartesExtras).Width = Cabeza.Width
        CuerpoSerpiente(PartesExtras).Height = Cabeza.Height
        CuerpoSerpiente(PartesExtras).Visible = False
        Controls.Add(CuerpoSerpiente(PartesExtras))
        Score.Text = Score.Text + 10
    End Sub
    Private Sub Colisiones()
        Dim x As Integer

        x = PartesExtras

        For x = 2 To PartesExtras
            If Cabeza.Bounds.IntersectsWith(CuerpoSerpiente(x).Bounds) Then
                sw = 1
                Dim result As Integer = MessageBox.Show("Game Over!", " Desea volver a jugar", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If result = DialogResult.Yes Then
                    Dim nuevo As New Snake
                    nuevo.Show()
                    Me.Dispose()

                End If
                If result = DialogResult.No Then


                    frmPrincipal.Show()
                    Me.Dispose()

                End If

            End If
        Next
        If Cabeza.Left < 14 Or Cabeza.Top < 28 Or Cabeza.Left > 742 Or Cabeza.Top > 518 Then
            sw = 1
            Dim result As Integer = MessageBox.Show("Game Over!", "Desea volver a jugar ", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = DialogResult.Yes Then
                Dim nuevo As New Snake
                nuevo.Show()
                Me.Dispose()

            End If
            If result = DialogResult.No Then
                frmPrincipal.Show()
                Me.Dispose()
            End If
        End If
    End Sub
    Private Sub LblSalir_Click(sender As Object, e As EventArgs) Handles LblSalir.Click

        frmPrincipal.Show()
        Me.Dispose()

    End Sub

    Private Sub Fondo_Click(sender As Object, e As EventArgs) Handles Fondo.Click

    End Sub

    Private Sub Cabeza_Click(sender As Object, e As EventArgs) Handles Cabeza.Click

    End Sub
End Class
