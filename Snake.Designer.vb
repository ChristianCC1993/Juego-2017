<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Snake
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblSalir = New System.Windows.Forms.Label()
        Me.Score = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.marco = New System.Windows.Forms.PictureBox()
        Me.Cabeza = New System.Windows.Forms.PictureBox()
        Me.Fondo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.marco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cabeza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(396, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.LblSalir)
        Me.GroupBox1.Controls.Add(Me.Score)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 558)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 55)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'LblSalir
        '
        Me.LblSalir.AutoSize = True
        Me.LblSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSalir.ForeColor = System.Drawing.Color.Red
        Me.LblSalir.Location = New System.Drawing.Point(649, 17)
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
        'marco
        '
        Me.marco.BackColor = System.Drawing.Color.Transparent
        Me.marco.Image = Global.presentación.My.Resources.Resources.borders_png_39750
        Me.marco.Location = New System.Drawing.Point(0, 0)
        Me.marco.Name = "marco"
        Me.marco.Size = New System.Drawing.Size(29, 21)
        Me.marco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.marco.TabIndex = 6
        Me.marco.TabStop = False
        '
        'Cabeza
        '
        Me.Cabeza.BackColor = System.Drawing.Color.GhostWhite
        Me.Cabeza.InitialImage = Global.presentación.My.Resources.Resources.SnakeHead
        Me.Cabeza.Location = New System.Drawing.Point(221, 12)
        Me.Cabeza.Name = "Cabeza"
        Me.Cabeza.Size = New System.Drawing.Size(24, 19)
        Me.Cabeza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cabeza.TabIndex = 0
        Me.Cabeza.TabStop = False
        '
        'Fondo
        '
        Me.Fondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fondo.Image = Global.presentación.My.Resources.Resources.star_background
        Me.Fondo.Location = New System.Drawing.Point(0, 0)
        Me.Fondo.Name = "Fondo"
        Me.Fondo.Size = New System.Drawing.Size(764, 613)
        Me.Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Fondo.TabIndex = 3
        Me.Fondo.TabStop = False
        '
        'Snake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 613)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cabeza)
        Me.Controls.Add(Me.marco)
        Me.Controls.Add(Me.Fondo)
        Me.MaximumSize = New System.Drawing.Size(780, 700)
        Me.MinimumSize = New System.Drawing.Size(780, 540)
        Me.Name = "Snake"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.marco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cabeza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cabeza As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Fondo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Score As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents marco As PictureBox
    Friend WithEvents LblSalir As Label
End Class
