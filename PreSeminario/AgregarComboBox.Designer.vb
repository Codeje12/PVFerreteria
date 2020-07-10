<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarComboBox
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
        Me.txtComboBoxAgregar = New System.Windows.Forms.TextBox()
        Me.lblCheckBoxagregar = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregarCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtComboBoxAgregar
        '
        Me.txtComboBoxAgregar.Location = New System.Drawing.Point(75, 29)
        Me.txtComboBoxAgregar.Name = "txtComboBoxAgregar"
        Me.txtComboBoxAgregar.Size = New System.Drawing.Size(117, 20)
        Me.txtComboBoxAgregar.TabIndex = 1
        '
        'lblCheckBoxagregar
        '
        Me.lblCheckBoxagregar.AutoSize = True
        Me.lblCheckBoxagregar.Font = New System.Drawing.Font("Dungeon", 9.0!)
        Me.lblCheckBoxagregar.Location = New System.Drawing.Point(72, 13)
        Me.lblCheckBoxagregar.Name = "lblCheckBoxagregar"
        Me.lblCheckBoxagregar.Size = New System.Drawing.Size(148, 13)
        Me.lblCheckBoxagregar.TabIndex = 2
        Me.lblCheckBoxagregar.Text = "NOMBRE DESCRIPCION"
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Dungeon", 9.0!)
        Me.btnSalir.Location = New System.Drawing.Point(143, 55)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregarCheck
        '
        Me.btnAgregarCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCheck.Font = New System.Drawing.Font("Dungeon", 9.0!)
        Me.btnAgregarCheck.Location = New System.Drawing.Point(62, 55)
        Me.btnAgregarCheck.Name = "btnAgregarCheck"
        Me.btnAgregarCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarCheck.TabIndex = 4
        Me.btnAgregarCheck.Text = "Agregar"
        Me.btnAgregarCheck.UseVisualStyleBackColor = True
        '
        'FrmAgregarComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(284, 94)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregarCheck)
        Me.Controls.Add(Me.lblCheckBoxagregar)
        Me.Controls.Add(Me.txtComboBoxAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAgregarComboBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtComboBoxAgregar As System.Windows.Forms.TextBox
    Friend WithEvents lblCheckBoxagregar As System.Windows.Forms.Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAgregarCheck As Button
End Class
