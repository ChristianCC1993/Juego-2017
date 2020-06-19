<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpaceInvaders
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.DisparoEnemigo5 = New System.Windows.Forms.PictureBox()
        Me.DisparoEnemigo4 = New System.Windows.Forms.PictureBox()
        Me.DisparoEnemigo3 = New System.Windows.Forms.PictureBox()
        Me.DisparoEnemigo2 = New System.Windows.Forms.PictureBox()
        Me.DisparoEnemigo1 = New System.Windows.Forms.PictureBox()
        Me.Disparo = New System.Windows.Forms.PictureBox()
        Me.Nave = New System.Windows.Forms.PictureBox()
        Me.Fondo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblSalir = New System.Windows.Forms.Label()
        Me.Score = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DisparoEnemigo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisparoEnemigo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisparoEnemigo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisparoEnemigo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisparoEnemigo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Disparo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 40
        '
        'DisparoEnemigo5
        '
        Me.DisparoEnemigo5.BackColor = System.Drawing.Color.SeaGreen
        Me.DisparoEnemigo5.Location = New System.Drawing.Point(770, 8)
        Me.DisparoEnemigo5.Name = "DisparoEnemigo5"
        Me.DisparoEnemigo5.Size = New System.Drawing.Size(10, 15)
        Me.DisparoEnemigo5.TabIndex = 7
        Me.DisparoEnemigo5.TabStop = False
        '
        'DisparoEnemigo4
        '
        Me.DisparoEnemigo4.BackColor = System.Drawing.Color.SeaGreen
        Me.DisparoEnemigo4.Location = New System.Drawing.Point(600, 8)
        Me.DisparoEnemigo4.Name = "DisparoEnemigo4"
        Me.DisparoEnemigo4.Size = New System.Drawing.Size(10, 15)
        Me.DisparoEnemigo4.TabIndex = 6
        Me.DisparoEnemigo4.TabStop = False
        '
        'DisparoEnemigo3
        '
        Me.DisparoEnemigo3.BackColor = System.Drawing.Color.SeaGreen
        Me.DisparoEnemigo3.Location = New System.Drawing.Point(400, 8)
        Me.DisparoEnemigo3.Name = "DisparoEnemigo3"
        Me.DisparoEnemigo3.Size = New System.Drawing.Size(10, 15)
        Me.DisparoEnemigo3.TabIndex = 5
        Me.DisparoEnemigo3.TabStop = False
        '
        'DisparoEnemigo2
        '
        Me.DisparoEnemigo2.BackColor = System.Drawing.Color.SeaGreen
        Me.DisparoEnemigo2.Location = New System.Drawing.Point(200, 8)
        Me.DisparoEnemigo2.Name = "DisparoEnemigo2"
        Me.DisparoEnemigo2.Size = New System.Drawing.Size(10, 15)
        Me.DisparoEnemigo2.TabIndex = 4
        Me.DisparoEnemigo2.TabStop = False
        '
        'DisparoEnemigo1
        '
        Me.DisparoEnemigo1.BackColor = System.Drawing.Color.SeaGreen
        Me.DisparoEnemigo1.Location = New System.Drawing.Point(30, 8)
        Me.DisparoEnemigo1.Name = "DisparoEnemigo1"
        Me.DisparoEnemigo1.Size = New System.Drawing.Size(10, 15)
        Me.DisparoEnemigo1.TabIndex = 3
        Me.DisparoEnemigo1.TabStop = False
        '
        'Disparo
        '
        Me.Disparo.BackColor = System.Drawing.Color.Red
        Me.Disparo.Location = New System.Drawing.Point(400, 399)
        Me.Disparo.Name = "Disparo"
        Me.Disparo.Size = New System.Drawing.Size(10, 13)
        Me.Disparo.TabIndex = 2
        Me.Disparo.TabStop = False
        '
        'Nave
        '
        Me.Nave.BackColor = System.Drawing.Color.Transparent
        Me.Nave.Image = Global.presentación.My.Resources.Resources.spaceship_gif
        Me.Nave.Location = New System.Drawing.Point(376, 418)
        Me.Nave.Name = "Nave"
        Me.Nave.Size = New System.Drawing.Size(53, 57)
        Me.Nave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Nave.TabIndex = 1
        Me.Nave.TabStop = False
        '
        'Fondo
        '
        Me.Fondo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Fondo.Image = Global.presentación.My.Resources.Resources.fondo
        Me.Fondo.Location = New System.Drawing.Point(-1, 0)
        Me.Fondo.Name = "Fondo"
        Me.Fondo.Size = New System.Drawing.Size(822, 520)
        Me.Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Fondo.TabIndex = 0
        Me.Fondo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.LblSalir)
        Me.GroupBox1.Controls.Add(Me.Score)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 473)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(828, 53)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'LblSalir
        '
        Me.LblSalir.AutoSize = True
        Me.LblSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSalir.ForeColor = System.Drawing.Color.Red
        Me.LblSalir.Location = New System.Drawing.Point(695, 16)
        Me.LblSalir.Name = "LblSalir"
        Me.LblSalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblSalir.Size = New System.Drawing.Size(77, 25)
        Me.LblSalir.TabIndex = 7
        Me.LblSalir.Text = "SALIR"
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.BackColor = System.Drawing.Color.Transparent
        Me.Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.ForeColor = System.Drawing.Color.Red
        Me.Score.Location = New System.Drawing.Point(115, 17)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(130, 24)
        Me.Score.TabIndex = 6
        Me.Score.Text = "...................."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SCORE"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Red
        Me.lbl1.Location = New System.Drawing.Point(711, 326)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl1.Size = New System.Drawing.Size(0, 25)
        Me.lbl1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(711, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(91, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SCORE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(711, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "SCORE"
        '
        'SpaceInvaders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 521)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DisparoEnemigo5)
        Me.Controls.Add(Me.DisparoEnemigo4)
        Me.Controls.Add(Me.DisparoEnemigo3)
        Me.Controls.Add(Me.DisparoEnemigo2)
        Me.Controls.Add(Me.DisparoEnemigo1)
        Me.Controls.Add(Me.Disparo)
        Me.Controls.Add(Me.Nave)
        Me.Controls.Add(Me.Fondo)
        Me.Name = "SpaceInvaders"
        Me.Text = "SpaceInvaders"
        CType(Me.DisparoEnemigo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisparoEnemigo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisparoEnemigo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisparoEnemigo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisparoEnemigo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Disparo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Fondo As PictureBox
    Friend WithEvents Nave As PictureBox
    Friend WithEvents Disparo As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DisparoEnemigo1 As PictureBox
    Friend WithEvents DisparoEnemigo2 As PictureBox
    Friend WithEvents DisparoEnemigo3 As PictureBox
    Friend WithEvents DisparoEnemigo4 As PictureBox
    Friend WithEvents DisparoEnemigo5 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Score As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblSalir As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
