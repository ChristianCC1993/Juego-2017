Public Class SpaceInvaders
    Dim MovDerecha As Boolean
    Dim MovIzquierda As Boolean
    Dim VelocidadNave As Integer
    Dim VelocidadDisparo As Integer
    Dim Invasores(20) As PictureBox
    Dim NumeroInvasores As Integer
    Dim direccion As Integer = 1
    Dim izq As Integer
    Dim alt As Integer
    Dim comodin As Integer

    Private Sub SpaceInvaders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VelocidadNave = 4
        VelocidadDisparo = 4
        Fondo.Dock = DockStyle.Fill
        Nave.Parent = Fondo
        Disparo.Parent = Fondo
        DisparoEnemigo1.Visible = True
        NumeroInvasores = 0
        Nave.Width = 40
        Nave.Height = 40
        izq = Nave.Width
        alt = Nave.Height
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        MoverNave()
        If NumeroInvasores = 0 Then
            Invasor()
        End If

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        DispararEnemigo()
        Disparar()
        If NumeroInvasores > 0 Then
            MoverInvasor()
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If NumeroInvasores = 0 Then
            Invasor()
        End If

    End Sub

    Private Sub SpaceInvaders_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Or e.KeyValue = Keys.D Then
            MovDerecha = True
            MovIzquierda = False
        End If
        If e.KeyValue = Keys.Left Or e.KeyValue = Keys.A Then
            MovIzquierda = True
            MovDerecha = False
        End If
        If e.KeyValue = Keys.Space And Disparo.Visible = False Then
            Disparo.Visible = True
            Disparo.Top = Nave.Top
            Disparo.Left = Nave.Left + (Nave.Width / 2)
        End If
    End Sub

    Private Sub MoverNave()
        If MovDerecha = True And Nave.Left + Nave.Width < Me.ClientRectangle.Width Then
            Nave.Left += VelocidadNave
        End If
        If MovIzquierda = True And Nave.Left > Me.ClientRectangle.Left Then
            Nave.Left -= VelocidadNave
        End If
    End Sub
    Private Sub MoverInvasor()
        lbl1.Text = alt
        Label2.Text = comodin + Nave.Height
        '********************************** derecha *****************************
        If izq < Me.ClientRectangle.Width And direccion = 1 Then
            Invasores(NumeroInvasores).Left += VelocidadNave
            izq += VelocidadNave
        ElseIf izq = Me.ClientRectangle.Width And direccion = 1 Then
            direccion = 2
            comodin = alt
        End If
        '********************************** abajo *****************************
        If izq >= Me.ClientRectangle.Width And direccion = 2 Then
            Invasores(NumeroInvasores).Top += VelocidadNave
            alt += VelocidadNave
        ElseIf alt = comodin + Nave.Height And direccion = 2 Then
            direccion = 3
        End If
        '********************************** izquierda *****************************
        If direccion = 3 Then
            Invasores(NumeroInvasores).Left -= VelocidadNave
        End If
    End Sub
    Private Sub Disparar()
        If Disparo.Visible = True Then
            Disparo.Top -= VelocidadDisparo
        End If
        If Disparo.Top < Me.ClientRectangle.Top Then
            Disparo.Visible = False
        End If
    End Sub

    Private Sub DispararEnemigo()
        If DisparoEnemigo1.Visible = True Then
            DisparoEnemigo1.Top += VelocidadDisparo
            DisparoEnemigo2.Top += VelocidadDisparo
            DisparoEnemigo3.Top += VelocidadDisparo
            DisparoEnemigo4.Top += VelocidadDisparo
            DisparoEnemigo5.Top += VelocidadDisparo
        End If
        If DisparoEnemigo1.Top > Me.ClientRectangle.Bottom Then
            DisparoEnemigo1.Top = 8
            DisparoEnemigo2.Top = 8
            DisparoEnemigo3.Top = 8
            DisparoEnemigo4.Top = 8
            DisparoEnemigo5.Top = 8
        End If
    End Sub

    Private Sub Invasor()
        NumeroInvasores += 1
        Invasores(NumeroInvasores) = New PictureBox()
        Invasores(NumeroInvasores).BackColor = Color.Azure
        'Invasores(NumeroInvasores).Image = My.Resources.ufo
        Invasores(NumeroInvasores).Width = Nave.Width
        Invasores(NumeroInvasores).Height = Nave.Height
        Invasores(NumeroInvasores).Top = 0
        Invasores(NumeroInvasores).Left = 0
        Invasores(NumeroInvasores).Parent = Fondo
    End Sub

    Private Sub LblSalir_Click(sender As Object, e As EventArgs) Handles LblSalir.Click
        Application.Restart()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Fondo_Click(sender As Object, e As EventArgs) Handles Fondo.Click

    End Sub
End Class