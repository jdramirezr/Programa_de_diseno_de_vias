<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class curvaespiralizada
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.data = New System.Windows.Forms.DataGridView
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnimportar = New System.Windows.Forms.Button
        Me.txtexportar2 = New System.Windows.Forms.Button
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(772, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PROYECCIONES"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(961, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "COORDENADAS "
        '
        'data
        '
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column14, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13})
        Me.data.Location = New System.Drawing.Point(35, 190)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(1073, 296)
        Me.data.TabIndex = 14
        '
        'Column14
        '
        Me.Column14.HeaderText = "#"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 20
        '
        'Column1
        '
        Me.Column1.HeaderText = "Punto"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "ABS"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.HeaderText = "Ln/CU"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "θ decimal"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "Xe"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 70
        '
        'Column6
        '
        Me.Column6.HeaderText = "Ye"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 70
        '
        'Column7
        '
        Me.Column7.HeaderText = "Φ decimal"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "CL"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 60
        '
        'Column9
        '
        Me.Column9.HeaderText = "Azimut"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 90
        '
        'Column10
        '
        Me.Column10.HeaderText = "            N "
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 97
        '
        'Column11
        '
        Me.Column11.HeaderText = "            E"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 97
        '
        'Column12
        '
        Me.Column12.HeaderText = "            N"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 97
        '
        'Column13
        '
        Me.Column13.HeaderText = "           E"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 97
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(283, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 51)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Calcular "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnimportar
        '
        Me.btnimportar.Location = New System.Drawing.Point(633, 75)
        Me.btnimportar.Name = "btnimportar"
        Me.btnimportar.Size = New System.Drawing.Size(111, 58)
        Me.btnimportar.TabIndex = 42
        Me.btnimportar.Text = "Exporta todos los datos"
        Me.btnimportar.UseVisualStyleBackColor = True
        '
        'txtexportar2
        '
        Me.txtexportar2.Location = New System.Drawing.Point(775, 75)
        Me.txtexportar2.Name = "txtexportar2"
        Me.txtexportar2.Size = New System.Drawing.Size(111, 58)
        Me.txtexportar2.TabIndex = 44
        Me.txtexportar2.Text = "exportar datos para graficar"
        Me.txtexportar2.UseVisualStyleBackColor = True
        '
        'curvaespiralizada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 559)
        Me.Controls.Add(Me.txtexportar2)
        Me.Controls.Add(Me.btnimportar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.data)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Name = "curvaespiralizada"
        Me.Text = "curvaespiralizada"
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents data As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnimportar As System.Windows.Forms.Button
    Friend WithEvents txtexportar2 As System.Windows.Forms.Button
End Class
