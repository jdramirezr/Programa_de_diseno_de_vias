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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtazisalida = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtazient = New System.Windows.Forms.TextBox
        Me.combovelocidad = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtpin = New System.Windows.Forms.TextBox
        Me.txtpie = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.longbop = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.combocuerda = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Azimut de salida"
        '
        'txtazisalida
        '
        Me.txtazisalida.Location = New System.Drawing.Point(154, 74)
        Me.txtazisalida.Name = "txtazisalida"
        Me.txtazisalida.Size = New System.Drawing.Size(100, 20)
        Me.txtazisalida.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Azimut de entrada "
        '
        'txtazient
        '
        Me.txtazient.Location = New System.Drawing.Point(154, 112)
        Me.txtazient.Name = "txtazient"
        Me.txtazient.Size = New System.Drawing.Size(100, 20)
        Me.txtazient.TabIndex = 6
        '
        'combovelocidad
        '
        Me.combovelocidad.FormattingEnabled = True
        Me.combovelocidad.Items.AddRange(New Object() {"40", "50", "60", "70", "80", "90", "100", "110", "120", "130"})
        Me.combovelocidad.Location = New System.Drawing.Point(154, 47)
        Me.combovelocidad.Name = "combovelocidad"
        Me.combovelocidad.Size = New System.Drawing.Size(121, 21)
        Me.combovelocidad.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Velocidad especifica"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cordenadas:"
        '
        'txtpin
        '
        Me.txtpin.Location = New System.Drawing.Point(154, 227)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Size = New System.Drawing.Size(100, 20)
        Me.txtpin.TabIndex = 15
        '
        'txtpie
        '
        Me.txtpie.Location = New System.Drawing.Point(154, 244)
        Me.txtpie.Name = "txtpie"
        Me.txtpie.Size = New System.Drawing.Size(100, 20)
        Me.txtpie.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(130, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 26)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "N:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E:"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(315, 224)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 28
        Me.btnaceptar.Text = "aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Long Bop-Pi"
        '
        'longbop
        '
        Me.longbop.Location = New System.Drawing.Point(154, 150)
        Me.longbop.Name = "longbop"
        Me.longbop.Size = New System.Drawing.Size(100, 20)
        Me.longbop.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Pi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(79, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Cuerda"
        '
        'combocuerda
        '
        Me.combocuerda.FormattingEnabled = True
        Me.combocuerda.Items.AddRange(New Object() {"5", "10"})
        Me.combocuerda.Location = New System.Drawing.Point(154, 176)
        Me.combocuerda.Name = "combocuerda"
        Me.combocuerda.Size = New System.Drawing.Size(81, 21)
        Me.combocuerda.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "(Decimal)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "(Decimal)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 323)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.combocuerda)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.longbop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtpie)
        Me.Controls.Add(Me.txtpin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.combovelocidad)
        Me.Controls.Add(Me.txtazient)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtazisalida)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Datos de entrada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtazisalida As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtazient As System.Windows.Forms.TextBox
    Friend WithEvents combovelocidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpin As System.Windows.Forms.TextBox
    Friend WithEvents txtpie As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents longbop As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents combocuerda As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
