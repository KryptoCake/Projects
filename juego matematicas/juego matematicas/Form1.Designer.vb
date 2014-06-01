<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblX = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LblTiempo = New System.Windows.Forms.Label()
        Me.LblPuntos = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblY = New System.Windows.Forms.Label()
        Me.LblSigno = New System.Windows.Forms.Label()
        Me.LblSumaPuntos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LblTiempoAbs = New System.Windows.Forms.Label()
        Me.CmbSprint = New System.Windows.Forms.ComboBox()
        Me.TextBoxRes = New System.Windows.Forms.TextBox()
        Me.CmbNivel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblX
        '
        Me.lblX.BackColor = System.Drawing.Color.Transparent
        Me.lblX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblX.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(251, 111)
        Me.lblX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(300, 75)
        Me.lblX.TabIndex = 0
        Me.lblX.Text = "00"
        Me.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cornsilk
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Location = New System.Drawing.Point(29, 9)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 63)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Cornsilk
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(29, 84)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 63)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Cornsilk
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Location = New System.Drawing.Point(29, 153)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 63)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "*"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Cornsilk
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button4.Location = New System.Drawing.Point(29, 222)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(46, 73)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "/"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'LblTiempo
        '
        Me.LblTiempo.AutoSize = True
        Me.LblTiempo.BackColor = System.Drawing.Color.Transparent
        Me.LblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 52.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTiempo.ForeColor = System.Drawing.Color.Blue
        Me.LblTiempo.Location = New System.Drawing.Point(443, 12)
        Me.LblTiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTiempo.Name = "LblTiempo"
        Me.LblTiempo.Size = New System.Drawing.Size(73, 79)
        Me.LblTiempo.TabIndex = 6
        Me.LblTiempo.Text = "0"
        '
        'LblPuntos
        '
        Me.LblPuntos.AutoSize = True
        Me.LblPuntos.BackColor = System.Drawing.Color.Transparent
        Me.LblPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuntos.Location = New System.Drawing.Point(572, 35)
        Me.LblPuntos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPuntos.Name = "LblPuntos"
        Me.LblPuntos.Size = New System.Drawing.Size(117, 37)
        Me.LblPuntos.TabIndex = 7
        Me.LblPuntos.Text = "Puntos"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Cornsilk
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button5.Location = New System.Drawing.Point(83, 320)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 46)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "iniciar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LblY
        '
        Me.LblY.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.LblY.BackColor = System.Drawing.Color.Transparent
        Me.LblY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblY.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblY.Location = New System.Drawing.Point(267, 174)
        Me.LblY.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblY.Name = "LblY"
        Me.LblY.Size = New System.Drawing.Size(284, 71)
        Me.LblY.TabIndex = 10
        Me.LblY.Text = "00"
        Me.LblY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSigno
        '
        Me.LblSigno.AutoSize = True
        Me.LblSigno.BackColor = System.Drawing.Color.Transparent
        Me.LblSigno.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSigno.Location = New System.Drawing.Point(212, 162)
        Me.LblSigno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSigno.Name = "LblSigno"
        Me.LblSigno.Size = New System.Drawing.Size(63, 75)
        Me.LblSigno.TabIndex = 11
        Me.LblSigno.Text = "+"
        '
        'LblSumaPuntos
        '
        Me.LblSumaPuntos.AutoSize = True
        Me.LblSumaPuntos.BackColor = System.Drawing.Color.Transparent
        Me.LblSumaPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSumaPuntos.Location = New System.Drawing.Point(572, 84)
        Me.LblSumaPuntos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSumaPuntos.Name = "LblSumaPuntos"
        Me.LblSumaPuntos.Size = New System.Drawing.Size(35, 37)
        Me.LblSumaPuntos.TabIndex = 12
        Me.LblSumaPuntos.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(753, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 37)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Puntos"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Cornsilk
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Button6.Location = New System.Drawing.Point(235, 320)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(122, 46)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Parar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'LblTiempoAbs
        '
        Me.LblTiempoAbs.AutoSize = True
        Me.LblTiempoAbs.BackColor = System.Drawing.Color.Transparent
        Me.LblTiempoAbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 52.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTiempoAbs.ForeColor = System.Drawing.Color.Blue
        Me.LblTiempoAbs.Location = New System.Drawing.Point(284, 9)
        Me.LblTiempoAbs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTiempoAbs.Name = "LblTiempoAbs"
        Me.LblTiempoAbs.Size = New System.Drawing.Size(73, 79)
        Me.LblTiempoAbs.TabIndex = 15
        Me.LblTiempoAbs.Text = "0"
        '
        'CmbSprint
        '
        Me.CmbSprint.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CmbSprint.FormattingEnabled = True
        Me.CmbSprint.Items.AddRange(New Object() {"30 segundos", "1 minuto", "2 minutos", "3 minutos", "4 minutos", "5 minutos", "Sin limite"})
        Me.CmbSprint.Location = New System.Drawing.Point(83, 12)
        Me.CmbSprint.Name = "CmbSprint"
        Me.CmbSprint.Size = New System.Drawing.Size(147, 22)
        Me.CmbSprint.TabIndex = 16
        Me.CmbSprint.Text = "Sprint"
        '
        'TextBoxRes
        '
        Me.TextBoxRes.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRes.Location = New System.Drawing.Point(380, 262)
        Me.TextBoxRes.Name = "TextBoxRes"
        Me.TextBoxRes.Size = New System.Drawing.Size(154, 35)
        Me.TextBoxRes.TabIndex = 17
        Me.TextBoxRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbNivel
        '
        Me.CmbNivel.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CmbNivel.FormattingEnabled = True
        Me.CmbNivel.Items.AddRange(New Object() {"1-básico: 1-5", "2-fácil: 1-10", "3-intermedio facil:1-15", "4-intermedio regular:1-20", "5-intermedio fuerte:1-25", "6-complejo sencillo:1-30", "7-complejo regular:10-35", "8-complejo complejo:10-50", "9-complejo extendido:10-70", "10-ligas mayores: 10-1000", "11-extremo:100-5000", "12-Elegir intervalo"})
        Me.CmbNivel.Location = New System.Drawing.Point(83, 84)
        Me.CmbNivel.Name = "CmbNivel"
        Me.CmbNivel.Size = New System.Drawing.Size(147, 22)
        Me.CmbNivel.TabIndex = 18
        Me.CmbNivel.Text = "Nivel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(327, 222)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 37)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "____________"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1156, 411)
        Me.Controls.Add(Me.LblY)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbNivel)
        Me.Controls.Add(Me.TextBoxRes)
        Me.Controls.Add(Me.CmbSprint)
        Me.Controls.Add(Me.LblTiempoAbs)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblSumaPuntos)
        Me.Controls.Add(Me.LblSigno)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.LblPuntos)
        Me.Controls.Add(Me.LblTiempo)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblX)
        Me.Font = New System.Drawing.Font("Wingdings 2", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LblTiempo As System.Windows.Forms.Label
    Friend WithEvents LblPuntos As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblY As System.Windows.Forms.Label
    Friend WithEvents LblSigno As System.Windows.Forms.Label
    Friend WithEvents LblSumaPuntos As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents LblTiempoAbs As System.Windows.Forms.Label
    Friend WithEvents CmbSprint As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxRes As System.Windows.Forms.TextBox
    Friend WithEvents CmbNivel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
