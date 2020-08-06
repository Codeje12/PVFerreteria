<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedores
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
        Me.PnlUpProveedores = New System.Windows.Forms.Panel()
        Me.GpbClientes = New System.Windows.Forms.GroupBox()
        Me.CbxDni = New System.Windows.Forms.CheckBox()
        Me.CbxNombre = New System.Windows.Forms.CheckBox()
        Me.txtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.lblListaCliente = New System.Windows.Forms.Label()
        Me.PnlAbm = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GpbDatosClientes = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.lblEmpresa = New System.Windows.Forms.Label()
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
        Me.lblProveedores = New System.Windows.Forms.Label()
        Me.DataGridViewProveedor = New System.Windows.Forms.DataGridView()
        Me.PnlUpProveedores.SuspendLayout()
        Me.GpbClientes.SuspendLayout()
        Me.PnlAbm.SuspendLayout()
        Me.GpbDatosClientes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlUpProveedores
        '
        Me.PnlUpProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlUpProveedores.Controls.Add(Me.GpbClientes)
        Me.PnlUpProveedores.Controls.Add(Me.lblListaCliente)
        Me.PnlUpProveedores.Controls.Add(Me.PnlAbm)
        Me.PnlUpProveedores.Location = New System.Drawing.Point(2, 1)
        Me.PnlUpProveedores.Name = "PnlUpProveedores"
        Me.PnlUpProveedores.Size = New System.Drawing.Size(944, 243)
        Me.PnlUpProveedores.TabIndex = 35
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
        Me.GpbClientes.Text = "Busqueda Proveedores"
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
        Me.lblListaCliente.Font = New System.Drawing.Font("Ink Free", 12.0!)
        Me.lblListaCliente.Location = New System.Drawing.Point(0, 217)
        Me.lblListaCliente.Name = "lblListaCliente"
        Me.lblListaCliente.Size = New System.Drawing.Size(322, 22)
        Me.lblListaCliente.TabIndex = 30
        Me.lblListaCliente.Text = "L I S T A D O   D E  P R O V E E D O R E S "
        Me.lblListaCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.PnlAbm.Size = New System.Drawing.Size(577, 65)
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
        'GpbDatosClientes
        '
        Me.GpbDatosClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpbDatosClientes.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GpbDatosClientes.Controls.Add(Me.GroupBox1)
        Me.GpbDatosClientes.Controls.Add(Me.lblProveedores)
        Me.GpbDatosClientes.Location = New System.Drawing.Point(2, 1)
        Me.GpbDatosClientes.Name = "GpbDatosClientes"
        Me.GpbDatosClientes.Size = New System.Drawing.Size(946, 161)
        Me.GpbDatosClientes.TabIndex = 34
        Me.GpbDatosClientes.TabStop = False
        Me.GpbDatosClientes.Text = " "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Controls.Add(Me.txtEmpresa)
        Me.GroupBox1.Controls.Add(Me.lblEmpresa)
        Me.GroupBox1.Controls.Add(Me.TxtLocalidad)
        Me.GroupBox1.Controls.Add(Me.lblLocalidad)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Controls.Add(Me.lblDireccion)
        Me.GroupBox1.Controls.Add(Me.TxtCorreo)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono)
        Me.GroupBox1.Controls.Add(Me.lblCorreo)
        Me.GroupBox1.Controls.Add(Me.lblTelefono)
        Me.GroupBox1.Controls.Add(Me.TxtDni)
        Me.GroupBox1.Controls.Add(Me.lblDni)
        Me.GroupBox1.Controls.Add(Me.TxtApelido)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(946, 161)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Proveedor"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(741, 122)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpresa.TabIndex = 32
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(646, 129)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(48, 13)
        Me.lblEmpresa.TabIndex = 33
        Me.lblEmpresa.Text = "Empresa"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(741, 80)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtLocalidad.TabIndex = 7
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(646, 87)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.lblLocalidad.TabIndex = 14
        Me.lblLocalidad.Text = "Localidad"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(741, 39)
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
        Me.lblCliente.Size = New System.Drawing.Size(216, 27)
        Me.lblCliente.TabIndex = 31
        Me.lblCliente.Text = "P R O V E E D O R E S "
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(646, 46)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 12
        Me.lblDireccion.Text = "Direccion"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(398, 103)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCorreo.TabIndex = 5
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(398, 59)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelefono.TabIndex = 4
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(303, 102)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 8
        Me.lblCorreo.Text = "Correo"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(303, 66)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "Telefono"
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(102, 122)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 20)
        Me.TxtDni.TabIndex = 3
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(5, 129)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(23, 13)
        Me.lblDni.TabIndex = 4
        Me.lblDni.Text = "Dni"
        '
        'TxtApelido
        '
        Me.TxtApelido.Location = New System.Drawing.Point(102, 80)
        Me.TxtApelido.Name = "TxtApelido"
        Me.TxtApelido.Size = New System.Drawing.Size(100, 20)
        Me.TxtApelido.TabIndex = 2
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(5, 87)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 2
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(5, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(102, 39)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'lblProveedores
        '
        Me.lblProveedores.AutoSize = True
        Me.lblProveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProveedores.Font = New System.Drawing.Font("Ink Free", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedores.ForeColor = System.Drawing.Color.Black
        Me.lblProveedores.Location = New System.Drawing.Point(326, 8)
        Me.lblProveedores.Name = "lblProveedores"
        Me.lblProveedores.Size = New System.Drawing.Size(210, 27)
        Me.lblProveedores.TabIndex = 31
        Me.lblProveedores.Text = "P R O V E E D O R E S"
        Me.lblProveedores.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridViewProveedor
        '
        Me.DataGridViewProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProveedor.Location = New System.Drawing.Point(5, 248)
        Me.DataGridViewProveedor.Name = "DataGridViewProveedor"
        Me.DataGridViewProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewProveedor.Size = New System.Drawing.Size(943, 308)
        Me.DataGridViewProveedor.TabIndex = 36
        '
        'FrmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(950, 560)
        Me.Controls.Add(Me.DataGridViewProveedor)
        Me.Controls.Add(Me.GpbDatosClientes)
        Me.Controls.Add(Me.PnlUpProveedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProveedores"
        Me.Text = "FrmProveedores"
        Me.PnlUpProveedores.ResumeLayout(False)
        Me.PnlUpProveedores.PerformLayout()
        Me.GpbClientes.ResumeLayout(False)
        Me.GpbClientes.PerformLayout()
        Me.PnlAbm.ResumeLayout(False)
        Me.GpbDatosClientes.ResumeLayout(False)
        Me.GpbDatosClientes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlUpProveedores As Panel
    Friend WithEvents GpbClientes As GroupBox
    Friend WithEvents CbxDni As CheckBox
    Friend WithEvents CbxNombre As CheckBox
    Friend WithEvents txtBuscarClientes As TextBox
    Friend WithEvents GpbDatosClientes As GroupBox
    Friend WithEvents lblProveedores As Label
    Friend WithEvents lblListaCliente As Label
    Friend WithEvents PnlAbm As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents lblEmpresa As Label
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
    Friend WithEvents DataGridViewProveedor As DataGridView
End Class
