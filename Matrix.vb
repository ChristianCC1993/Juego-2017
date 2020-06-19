Imports System.Drawing.Drawing2D
Imports System.Drawing
Public Class Personaje
    Dim backbuffer As New Bitmap(700, 700)
    Dim gradLentBrush As New LinearGradientBrush(New Point(100, 100), New PointF(200, 200), Color.Blue, Color.Red)
    Dim ImageMatrix As New Matrix()
    Dim isMouseDown As Boolean = False
    Dim mousePoint As Point
    Dim direccion As String = "ARRIBA"
    Dim BalaMatrix As New Matrix()
    Dim sw As String = 0

    Public Sub Crear()
        Select Case sw
            Case 0
                Dim g As Graphics
                g = Graphics.FromImage(backbuffer)
                g.Clear(Color.Black)
                g.Transform = ImageMatrix

                'dibujo
                g.DrawRectangle(Pens.Blue, New Rectangle(New Point(Form1.ClientSize.Width / 2 - 50, Form1.ClientSize.Height / 2 - 50), New Size(100, 100)))
                g.FillRectangle(gradLentBrush, New Rectangle(New Point(Form1.ClientSize.Width / 2 - 50, Form1.ClientSize.Height / 2 - 50), New Size(100, 100)))


                'dibujo fin
                Form1.CreateGraphics.DrawImage(backbuffer, New Point(0, 0))
            Case 1
                Disparar()
        End Select

    End Sub

    Public Sub Mover(mov As String)
        'MessageBox.Show(mov)

        Select Case mov
            Case "A"
                ImageMatrix.Translate(-10, 0)
                direccion = "IZQUIERDA"

            Case "D"
                ImageMatrix.Translate(+10, 0)
                direccion = "DERECHA"
            Case "W"
                ImageMatrix.Translate(0, -10)
                direccion = "ARRIBA"
            Case "S"
                ImageMatrix.Translate(0, +10)
                direccion = "ABAJO"
            Case "Q"
                ImageMatrix.RotateAt(-10, New Point(Form1.ClientSize.Width / 2, Form1.ClientSize.Height / 2))
            Case "E"
                ImageMatrix.RotateAt(10, New Point(Form1.Width / 2, Form1.ClientSize.Height / 2))
            Case "delete"
                ImageMatrix.Reset()
            Case "Space"
                Disparar()
                sw = 1
            Case "R"
                ImageMatrix.Scale(1.01, 1.01)
            Case "T"
                ImageMatrix.Scale(0.98, 0.98)

        End Select
        Crear()

    End Sub
    Public Sub Disparar()
        Select Case direccion
            Case "ARRIBA"
            Case "ABAJO"
            Case "DERECHA"
            Case "IZQUIERDA"
        End Select

        Dim g As Graphics
        g = Graphics.FromImage(backbuffer)
        g.Clear(Color.Black)
        g.Transform = ImageMatrix

        'dibujo
        g.DrawRectangle(Pens.Blue, New Rectangle(New Point(Form1.ClientSize.Width / 2 - 50, Form1.ClientSize.Height / 2 - 50), New Size(100, 100)))
        g.FillRectangle(gradLentBrush, New Rectangle(New Point(Form1.ClientSize.Width / 2 - 50, Form1.ClientSize.Height / 2 - 50), New Size(100, 100)))

        g.DrawRectangle(Pens.White, New Rectangle(New Point(Form1.ClientSize.Width / 2 - 50, Form1.ClientSize.Height / 2 + 100), New Size(20, 20)))

        'dibujo fin
        Form1.CreateGraphics.DrawImage(backbuffer, New Point(0, 0))


    End Sub
    Public Sub bala()

    End Sub
End Class
