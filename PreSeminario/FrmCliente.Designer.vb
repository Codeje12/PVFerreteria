<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCliente
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.PnlAbm = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GpbClientes = New System.Windows.Forms.GroupBox()
        Me.CbxDni = New System.Windows.Forms.CheckBox()
        Me.CbxNombre = New System.Windows.Forms.CheckBox()
        Me.txtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.lblListaCliente = New System.Windows.Forms.Label()
        Me.PnlUpClientes = New System.Windows.Forms.Panel()
        Me.GpbDatosClientes = New System.Windows.Forms.GroupBox()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.TxtApelido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.DataGridViewCliente = New System.Windows.Forms.DataGridView()
        Me.pnlCliente = New System.Windows.Forms.Panel()
        Me.PnlAbm.SuspendLayout()
        Me.GpbClientes.SuspendLayout()
        Me.PnlUpClientes.SuspendLayout()
        Me.GpbDatosClientes.SuspendLayout()
        CType(Me.DataGridViewCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Dungeon", 9.0!)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(230, 10)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 48)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Actualizar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Dungeon", 9.0!)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(344, 10)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 48)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(458, 10)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 48)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "X"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Dungeon", 9.0!)
        Me.btnNuevo.Location = New System.Drawing.Point(122, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(97, 48)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'PnlAbm
        '
        Me.PnlAbm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlAbm.Controls.Add(Me.btnSave)
        Me.PnlAbm.Controls.Add(Me.btnEliminar)
        Me.PnlAbm.Controls.Add(Me.btnSalir)
        Me.PnlAbm.Controls.Add(Me.btnNuevo)
        Me.PnlAbm.Controls.Add(Me.btnModificar)
        Me.PnlAbm.Location = New System.Drawing.Point(364, 168)
        Me.PnlAbm.Name = "PnlAbm"
        Me.PnlAbm.Size = New System.Drawing.Size(577, 64)
        Me.PnlAbm.TabIndex = 33
        '
        'btnSave
        '
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Dungeon", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(8, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 48)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GpbClientes
        '
        Me.GpbClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpbClientes.Controls.Add(Me.CbxDni)
        Me.GpbClientes.Controls.Add(Me.CbxNombre)
        Me.GpbClientes.Controls.Add(Me.txtBuscarClientes)
        Me.GpbClientes.Location = New System.Drawing.Point(0, 167)
        Me.GpbClientes.Name = "GpbClientes"
        Me.GpbClientes.Size = New System.Drawing.Size(358, 47)
        Me.GpbClientes.TabIndex = 29
        Me.GpbClientes.TabStop = False
        Me.GpbClientes.Text = "Busqueda Clientes"
        '
        'CbxDni
        '
        Me.CbxDni.AutoSize = True
        Me.CbxDni.Location = New System.Drawing.Point(104, 22)
        Me.CbxDni.Name = "CbxDni"
        Me.CbxDni.Size = New System.Drawing.Size(42, 17)
        Me.CbxDni.TabIndex = 18
        Me.CbxDni.Text = "Dni"
        Me.CbxDni.UseVisualStyleBackColor = True
        '
        'CbxNombre
        '
        Me.CbxNombre.AutoSize = True
        Me.CbxNombre.Location = New System.Drawing.Point(3, 22)
        Me.CbxNombre.Name = "CbxNombre"
        Me.CbxNombre.Size = New System.Drawing.Size(63, 17)
        Me.CbxNombre.TabIndex = 17
        Me.CbxNombre.Text = "Nombre"
        Me.CbxNombre.UseVisualStyleBackColor = True
        '
        'txtBuscarClientes
        '
        Me.txtBuscarClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarClientes.Location = New System.Drawing.Point(173, 19)
        Me.txtBuscarClientes.Name = "txtBuscarClientes"
        Me.txtBuscarClientes.Size = New System.Drawing.Size(179, 20)
        Me.txtBuscarClientes.TabIndex = 16
        '
        'lblListaCliente
        '
        Me.lblListaCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblListaCliente.AutoSize = True
        Me.lblListaCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblListaCliente.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaCliente.Location = New System.Drawing.Point(0, 217)
        Me.lblListaCliente.Name = "lblListaCliente"
        Me.lblListaCliente.Size = New System.Drawing.Size(220, 25)
        Me.lblListaCliente.TabIndex = 30
        Me.lblListaCliente.Text = "L I S T A D O   D E   C L I E N T E S"
        Me.lblListaCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PnlUpClientes
        '
        Me.PnlUpClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlUpClientes.Controls.Add(Me.GpbClientes)
        Me.PnlUpClientes.Controls.Add(Me.GpbDatosClientes)
        Me.PnlUpClientes.Controls.Add(Me.lblListaCliente)
        Me.PnlUpClientes.Controls.Add(Me.PnlAbm)
        Me.PnlUpClientes.Location = New System.Drawing.Point(2, 1)
        Me.PnlUpClientes.Name = "PnlUpClientes"
        Me.PnlUpClientes.Size = New System.Drawing.Size(944, 242)
        Me.PnlUpClientes.TabIndex = 34
        '
        'GpbDatosClientes
        '
        Me.GpbDatosClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpbDatosClientes.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GpbDatosClientes.Controls.Add(Me.TxtLocalidad)
        Me.GpbDatosClientes.Controls.Add(Me.lblLocalidad)
        Me.GpbDatosClientes.Controls.Add(Me.TxtDireccion)
        Me.GpbDatosClientes.Controls.Add(Me.lblCliente)
        Me.GpbDatosClientes.Controls.Add(Me.lblDireccion)
        Me.GpbDatosClientes.Controls.Add(Me.TxtCorreo)
        Me.GpbDatosClientes.Controls.Add(Me.TxtTelefono)
        Me.GpbDatosClientes.Controls.Add(Me.lblCorreo)
        Me.GpbDatosClientes.Controls.Add(Me.lblTelefono)
        Me.GpbDatosClientes.Controls.Add(Me.TxtDni)
        Me.GpbDatosClientes.Controls.Add(Me.lblDni)
        Me.GpbDatosClientes.Controls.Add(Me.TxtApelido)
        Me.GpbDatosClientes.Controls.Add(Me.lblApellido)
        Me.GpbDatosClientes.Controls.Add(Me.lblNombre)
        Me.GpbDatosClientes.Controls.Add(Me.TxtNombre)
        Me.GpbDatosClientes.Location = New System.Drawing.Point(0, 0)
        Me.GpbDatosClientes.Name = "GpbDatosClientes"
        Me.GpbDatosClientes.Size = New System.Drawing.Size(941, 161)
        Me.GpbDatosClientes.TabIndex = 34
        Me.GpbDatosClientes.TabStop = False
        Me.GpbDatosClientes.Text = "Datos Cientes"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(589, 43)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtLocalidad.TabIndex = 7
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(522, 52)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 14
        Me.lblLocalidad.Text = "Localidad"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(403, 131)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.TxtDireccion.TabIndex = 6
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCliente.Font = New System.Drawing.Font("Ink Free", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Black
        Me.lblCliente.Location = New System.Drawing.Point(326, 8)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(155, 27)
        Me.lblCliente.TabIndex = 31
        Me.lblCliente.Text = "C L I E N T E S"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(312, 127)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 12
        Me.lblDireccion.Text = "Direccion"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(403, 87)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCorreo.TabIndex = 5
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(403, 46)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelefono.TabIndex = 4
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(325, 86)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 8
        Me.lblCorreo.Text = "Correo"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(308, 53)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "Telefono"
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(182, 124)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 20)
        Me.TxtDni.TabIndex = 3
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(106, 131)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(23, 13)
        Me.lblDni.TabIndex = 4
        Me.lblDni.Text = "Dni"
        '
        'TxtApelido
        '
        Me.TxtApelido.Location = New System.Drawing.Point(182, 80)
        Me.TxtApelido.Name = "TxtApelido"
        Me.TxtApelido.Size = New System.Drawing.Size(100, 20)
        Me.TxtApelido.TabIndex = 2
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(85, 87)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(85, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(182, 39)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'DataGridViewCliente
        '
        Me.DataGridViewCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCliente.Location = New System.Drawing.Point(1, 246)
        Me.DataGridViewCliente.Name = "DataGridViewCliente"
        Me.DataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewCliente.Size = New System.Drawing.Size(941, 310)
        Me.DataGridViewCliente.TabIndex = 35
        '
        'pnlCliente
        '
        Me.pnlCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCliente.Controls.Add(Me.DataGridViewCliente)
        Me.pnlCliente.Location = New System.Drawing.Point(4, 1)
        Me.pnlCliente.Name = "pnlCliente"
        Me.pnlCliente.Size = New System.Drawing.Size(944, 559)
        Me.pnlCliente.TabIndex = 32
        '
        'FrmCliente
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(950, 560)
        Me.Controls.Add(Me.PnlUpClientes)
        Me.Controls.Add(Me.pnlCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCliente"
        Me.Text = "Clientes"
        Me.PnlAbm.ResumeLayout(False)
        Me.GpbClientes.ResumeLayout(False)
        Me.GpbClientes.PerformLayout()
        Me.PnlUpClientes.ResumeLayout(False)
        Me.PnlUpClientes.PerformLayout()
        Me.GpbDatosClientes.ResumeLayout(False)
        Me.GpbDatosClientes.PerformLayout()
        CType(Me.DataGridViewCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCliente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents PnlAbm As Panel
    Friend WithEvents GpbClientes As GroupBox
    Friend WithEvents CbxDni As CheckBox
    Friend WithEvents CbxNombre As CheckBox
    Friend WithEvents txtBuscarClientes As TextBox
    Friend WithEvents lblListaCliente As Label
    Friend WithEvents PnlUpClientes As Panel
    Friend WithEvents DataGridViewCliente As DataGridView
    Friend WithEvents pnlCliente As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents GpbDatosClientes As GroupBox
    Friend WithEvents TxtLocalidad As TextBox
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents TxtApelido As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents TxtNombre As TextBox
End Class
