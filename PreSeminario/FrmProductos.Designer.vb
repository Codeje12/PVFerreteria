<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
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
        Me.GpbClientes = New System.Windows.Forms.GroupBox()
        Me.CbxDescripcion = New System.Windows.Forms.CheckBox()
        Me.CbxMarca = New System.Windows.Forms.CheckBox()
        Me.CbxNombre = New System.Windows.Forms.CheckBox()
        Me.txtBuscarProductos = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.gbpProductos = New System.Windows.Forms.GroupBox()
        Me.txtCodProducto = New System.Windows.Forms.TextBox()
        Me.lblCodigoProd = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnMasUnidad = New System.Windows.Forms.Button()
        Me.btnMasMarca = New System.Windows.Forms.Button()
        Me.btnMasRubro = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblSelctImg = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblGanancias = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.cbxIva = New System.Windows.Forms.ComboBox()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.DateTimeProducto = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaVen = New System.Windows.Forms.Label()
        Me.cbxUnidad = New System.Windows.Forms.ComboBox()
        Me.lblUnidad = New System.Windows.Forms.Label()
        Me.cbxMarcas = New System.Windows.Forms.ComboBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblRubro = New System.Windows.Forms.Label()
        Me.cbxRubro = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlGroupBox = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMensajeFoto = New System.Windows.Forms.Label()
        Me.FotoProducto = New System.Windows.Forms.PictureBox()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.pnpDescProd = New System.Windows.Forms.Panel()
        Me.lblMostrarPrecio = New System.Windows.Forms.Label()
        Me.lblMostrarStock = New System.Windows.Forms.Label()
        Me.LblMostrarNombre = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.PnlDataGrid = New System.Windows.Forms.Panel()
        Me.DataGridProducto = New System.Windows.Forms.DataGridView()
        Me.lblListaCliente = New System.Windows.Forms.Label()
        Me.OpenFileDialogProducto = New System.Windows.Forms.OpenFileDialog()
        Me.GpbClientes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbpProductos.SuspendLayout()
        Me.pnlGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FotoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnpDescProd.SuspendLayout()
        Me.PnlDataGrid.SuspendLayout()
        CType(Me.DataGridProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GpbClientes
        '
        Me.GpbClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpbClientes.Controls.Add(Me.CbxDescripcion)
        Me.GpbClientes.Controls.Add(Me.CbxMarca)
        Me.GpbClientes.Controls.Add(Me.CbxNombre)
        Me.GpbClientes.Controls.Add(Me.txtBuscarProductos)
        Me.GpbClientes.Location = New System.Drawing.Point(4, 167)
        Me.GpbClientes.Name = "GpbClientes"
        Me.GpbClientes.Size = New System.Drawing.Size(357, 39)
        Me.GpbClientes.TabIndex = 23
        Me.GpbClientes.TabStop = False
        Me.GpbClientes.Text = "Buscar Producto por :"
        '
        'CbxDescripcion
        '
        Me.CbxDescripcion.AutoSize = True
        Me.CbxDescripcion.Location = New System.Drawing.Point(113, 18)
        Me.CbxDescripcion.Name = "CbxDescripcion"
        Me.CbxDescripcion.Size = New System.Drawing.Size(82, 17)
        Me.CbxDescripcion.TabIndex = 19
        Me.CbxDescripcion.Text = "Descripcion"
        Me.CbxDescripcion.UseVisualStyleBackColor = True
        '
        'CbxMarca
        '
        Me.CbxMarca.AutoSize = True
        Me.CbxMarca.Location = New System.Drawing.Point(62, 18)
        Me.CbxMarca.Name = "CbxMarca"
        Me.CbxMarca.Size = New System.Drawing.Size(56, 17)
        Me.CbxMarca.TabIndex = 18
        Me.CbxMarca.Text = "Marca"
        Me.CbxMarca.UseVisualStyleBackColor = True
        '
        'CbxNombre
        '
        Me.CbxNombre.AutoSize = True
        Me.CbxNombre.Location = New System.Drawing.Point(2, 18)
        Me.CbxNombre.Name = "CbxNombre"
        Me.CbxNombre.Size = New System.Drawing.Size(63, 17)
        Me.CbxNombre.TabIndex = 17
        Me.CbxNombre.Text = "Nombre"
        Me.CbxNombre.UseVisualStyleBackColor = True
        '
        'txtBuscarProductos
        '
        Me.txtBuscarProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarProductos.Location = New System.Drawing.Point(201, 14)
        Me.txtBuscarProductos.Name = "txtBuscarProductos"
        Me.txtBuscarProductos.Size = New System.Drawing.Size(152, 20)
        Me.txtBuscarProductos.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Location = New System.Drawing.Point(363, 167)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 64)
        Me.Panel1.TabIndex = 34
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Dungeon", 9.0!)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(353, 10)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 48)
        Me.btnModificar.TabIndex = 27
        Me.btnModificar.Text = "Actualizar"
        Me.btnModificar.UseVisualStyleBackColor = True
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
        Me.btnSave.TabIndex = 14
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
        Me.btnEliminar.Location = New System.Drawing.Point(238, 10)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 48)
        Me.btnEliminar.TabIndex = 16
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
        Me.btnSalir.Location = New System.Drawing.Point(464, 9)
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
        Me.btnNuevo.Location = New System.Drawing.Point(125, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(97, 48)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'gbpProductos
        '
        Me.gbpProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbpProductos.Controls.Add(Me.txtCodProducto)
        Me.gbpProductos.Controls.Add(Me.lblCodigoProd)
        Me.gbpProductos.Controls.Add(Me.lblImagen)
        Me.gbpProductos.Controls.Add(Me.btnImagen)
        Me.gbpProductos.Controls.Add(Me.lblCliente)
        Me.gbpProductos.Controls.Add(Me.btnMasUnidad)
        Me.gbpProductos.Controls.Add(Me.btnMasMarca)
        Me.gbpProductos.Controls.Add(Me.btnMasRubro)
        Me.gbpProductos.Controls.Add(Me.txtDescripcion)
        Me.gbpProductos.Controls.Add(Me.lblSelctImg)
        Me.gbpProductos.Controls.Add(Me.txtCantidad)
        Me.gbpProductos.Controls.Add(Me.lblGanancias)
        Me.gbpProductos.Controls.Add(Me.lblCantidad)
        Me.gbpProductos.Controls.Add(Me.cbxIva)
        Me.gbpProductos.Controls.Add(Me.lblIva)
        Me.gbpProductos.Controls.Add(Me.txtCosto)
        Me.gbpProductos.Controls.Add(Me.lblCosto)
        Me.gbpProductos.Controls.Add(Me.DateTimeProducto)
        Me.gbpProductos.Controls.Add(Me.lblFechaVen)
        Me.gbpProductos.Controls.Add(Me.cbxUnidad)
        Me.gbpProductos.Controls.Add(Me.lblUnidad)
        Me.gbpProductos.Controls.Add(Me.cbxMarcas)
        Me.gbpProductos.Controls.Add(Me.lblMarca)
        Me.gbpProductos.Controls.Add(Me.lblRubro)
        Me.gbpProductos.Controls.Add(Me.cbxRubro)
        Me.gbpProductos.Controls.Add(Me.txtNombre)
        Me.gbpProductos.Controls.Add(Me.Label1)
        Me.gbpProductos.Location = New System.Drawing.Point(3, 1)
        Me.gbpProductos.Name = "gbpProductos"
        Me.gbpProductos.Size = New System.Drawing.Size(928, 160)
        Me.gbpProductos.TabIndex = 35
        Me.gbpProductos.TabStop = False
        Me.gbpProductos.Text = "Datos Productos"
        '
        'txtCodProducto
        '
        Me.txtCodProducto.Location = New System.Drawing.Point(116, 52)
        Me.txtCodProducto.Name = "txtCodProducto"
        Me.txtCodProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtCodProducto.TabIndex = 2
        '
        'lblCodigoProd
        '
        Me.lblCodigoProd.AutoSize = True
        Me.lblCodigoProd.Location = New System.Drawing.Point(10, 58)
        Me.lblCodigoProd.Name = "lblCodigoProd"
        Me.lblCodigoProd.Size = New System.Drawing.Size(75, 13)
        Me.lblCodigoProd.TabIndex = 33
        Me.lblCodigoProd.Text = "Cod. Producto"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCliente.Font = New System.Drawing.Font("Ink Free", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.Black
        Me.lblCliente.Location = New System.Drawing.Point(326, 8)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(176, 27)
        Me.lblCliente.TabIndex = 32
        Me.lblCliente.Text = "P R O D U C T O S"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnMasUnidad
        '
        Me.btnMasUnidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMasUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasUnidad.Location = New System.Drawing.Point(542, 49)
        Me.btnMasUnidad.Name = "btnMasUnidad"
        Me.btnMasUnidad.Size = New System.Drawing.Size(19, 21)
        Me.btnMasUnidad.TabIndex = 8
        Me.btnMasUnidad.Text = "+"
        Me.btnMasUnidad.UseVisualStyleBackColor = True
        '
        'btnMasMarca
        '
        Me.btnMasMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMasMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasMarca.Location = New System.Drawing.Point(222, 122)
        Me.btnMasMarca.Name = "btnMasMarca"
        Me.btnMasMarca.Size = New System.Drawing.Size(19, 21)
        Me.btnMasMarca.TabIndex = 6
        Me.btnMasMarca.Text = "+"
        Me.btnMasMarca.UseVisualStyleBackColor = True
        '
        'btnMasRubro
        '
        Me.btnMasRubro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMasRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasRubro.Location = New System.Drawing.Point(222, 85)
        Me.btnMasRubro.Name = "btnMasRubro"
        Me.btnMasRubro.Size = New System.Drawing.Size(19, 21)
        Me.btnMasRubro.TabIndex = 4
        Me.btnMasRubro.Text = "+"
        Me.btnMasRubro.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(782, 91)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 13
        '
        'lblSelctImg
        '
        Me.lblSelctImg.AutoSize = True
        Me.lblSelctImg.Location = New System.Drawing.Point(686, 93)
        Me.lblSelctImg.Name = "lblSelctImg"
        Me.lblSelctImg.Size = New System.Drawing.Size(63, 13)
        Me.lblSelctImg.TabIndex = 20
        Me.lblSelctImg.Text = "Descripcion"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(782, 53)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 12
        '
        'lblGanancias
        '
        Me.lblGanancias.AutoSize = True
        Me.lblGanancias.Location = New System.Drawing.Point(255, 101)
        Me.lblGanancias.Name = "lblGanancias"
        Me.lblGanancias.Size = New System.Drawing.Size(0, 13)
        Me.lblGanancias.TabIndex = 14
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(686, 58)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 18
        Me.lblCantidad.Text = "Cantidad"
        '
        'cbxIva
        '
        Me.cbxIva.FormattingEnabled = True
        Me.cbxIva.Location = New System.Drawing.Point(782, 17)
        Me.cbxIva.Name = "cbxIva"
        Me.cbxIva.Size = New System.Drawing.Size(100, 21)
        Me.cbxIva.TabIndex = 11
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(686, 25)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(30, 13)
        Me.lblIva.TabIndex = 16
        Me.lblIva.Text = "I.V.A"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(436, 126)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 10
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Location = New System.Drawing.Point(357, 129)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(34, 13)
        Me.lblCosto.TabIndex = 12
        Me.lblCosto.Text = "Costo"
        '
        'DateTimeProducto
        '
        Me.DateTimeProducto.CustomFormat = ""
        Me.DateTimeProducto.Location = New System.Drawing.Point(436, 87)
        Me.DateTimeProducto.Name = "DateTimeProducto"
        Me.DateTimeProducto.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeProducto.TabIndex = 9
        Me.DateTimeProducto.Value = New Date(2020, 7, 17, 0, 0, 0, 0)
        '
        'lblFechaVen
        '
        Me.lblFechaVen.AutoSize = True
        Me.lblFechaVen.Location = New System.Drawing.Point(357, 93)
        Me.lblFechaVen.Name = "lblFechaVen"
        Me.lblFechaVen.Size = New System.Drawing.Size(37, 13)
        Me.lblFechaVen.TabIndex = 10
        Me.lblFechaVen.Text = "Fecha"
        '
        'cbxUnidad
        '
        Me.cbxUnidad.FormattingEnabled = True
        Me.cbxUnidad.Location = New System.Drawing.Point(436, 49)
        Me.cbxUnidad.Name = "cbxUnidad"
        Me.cbxUnidad.Size = New System.Drawing.Size(100, 21)
        Me.cbxUnidad.TabIndex = 7
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Location = New System.Drawing.Point(355, 58)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(41, 13)
        Me.lblUnidad.TabIndex = 8
        Me.lblUnidad.Text = "Unidad"
        '
        'cbxMarcas
        '
        Me.cbxMarcas.FormattingEnabled = True
        Me.cbxMarcas.Location = New System.Drawing.Point(116, 121)
        Me.cbxMarcas.Name = "cbxMarcas"
        Me.cbxMarcas.Size = New System.Drawing.Size(100, 21)
        Me.cbxMarcas.TabIndex = 5
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(10, 129)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 6
        Me.lblMarca.Text = "Marca"
        '
        'lblRubro
        '
        Me.lblRubro.AutoSize = True
        Me.lblRubro.Location = New System.Drawing.Point(10, 93)
        Me.lblRubro.Name = "lblRubro"
        Me.lblRubro.Size = New System.Drawing.Size(36, 13)
        Me.lblRubro.TabIndex = 5
        Me.lblRubro.Text = "Rubro"
        '
        'cbxRubro
        '
        Me.cbxRubro.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cbxRubro.FormattingEnabled = True
        Me.cbxRubro.Location = New System.Drawing.Point(116, 85)
        Me.cbxRubro.Name = "cbxRubro"
        Me.cbxRubro.Size = New System.Drawing.Size(100, 21)
        Me.cbxRubro.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(116, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre producto"
        '
        'pnlGroupBox
        '
        Me.pnlGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGroupBox.Controls.Add(Me.GroupBox1)
        Me.pnlGroupBox.Location = New System.Drawing.Point(664, 237)
        Me.pnlGroupBox.Name = "pnlGroupBox"
        Me.pnlGroupBox.Size = New System.Drawing.Size(267, 288)
        Me.pnlGroupBox.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblMensajeFoto)
        Me.GroupBox1.Controls.Add(Me.FotoProducto)
        Me.GroupBox1.Controls.Add(Me.pnpDescProd)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 288)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Datos del producto seleccionado"
        '
        'lblMensajeFoto
        '
        Me.lblMensajeFoto.AutoSize = True
        Me.lblMensajeFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeFoto.Location = New System.Drawing.Point(84, 102)
        Me.lblMensajeFoto.Name = "lblMensajeFoto"
        Me.lblMensajeFoto.Size = New System.Drawing.Size(93, 25)
        Me.lblMensajeFoto.TabIndex = 27
        Me.lblMensajeFoto.Text = "Sin foto"
        '
        'FotoProducto
        '
        Me.FotoProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FotoProducto.Location = New System.Drawing.Point(6, 19)
        Me.FotoProducto.Name = "FotoProducto"
        Me.FotoProducto.Size = New System.Drawing.Size(255, 182)
        Me.FotoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.FotoProducto.TabIndex = 2
        Me.FotoProducto.TabStop = False
        '
        'lblImagen
        '
        Me.lblImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblImagen.AutoSize = True
        Me.lblImagen.Location = New System.Drawing.Point(686, 129)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(88, 13)
        Me.lblImagen.TabIndex = 25
        Me.lblImagen.Text = "Eliga una imagen"
        Me.lblImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnpDescProd
        '
        Me.pnpDescProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnpDescProd.Controls.Add(Me.lblMostrarPrecio)
        Me.pnpDescProd.Controls.Add(Me.lblMostrarStock)
        Me.pnpDescProd.Controls.Add(Me.LblMostrarNombre)
        Me.pnpDescProd.Controls.Add(Me.lblPrecio)
        Me.pnpDescProd.Controls.Add(Me.lblStock)
        Me.pnpDescProd.Controls.Add(Me.lblNombre)
        Me.pnpDescProd.Location = New System.Drawing.Point(9, 207)
        Me.pnpDescProd.Name = "pnpDescProd"
        Me.pnpDescProd.Size = New System.Drawing.Size(249, 78)
        Me.pnpDescProd.TabIndex = 3
        '
        'lblMostrarPrecio
        '
        Me.lblMostrarPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMostrarPrecio.AutoSize = True
        Me.lblMostrarPrecio.Location = New System.Drawing.Point(62, 63)
        Me.lblMostrarPrecio.Name = "lblMostrarPrecio"
        Me.lblMostrarPrecio.Size = New System.Drawing.Size(10, 13)
        Me.lblMostrarPrecio.TabIndex = 32
        Me.lblMostrarPrecio.Text = "-"
        '
        'lblMostrarStock
        '
        Me.lblMostrarStock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMostrarStock.AutoSize = True
        Me.lblMostrarStock.Location = New System.Drawing.Point(64, 38)
        Me.lblMostrarStock.Name = "lblMostrarStock"
        Me.lblMostrarStock.Size = New System.Drawing.Size(10, 13)
        Me.lblMostrarStock.TabIndex = 31
        Me.lblMostrarStock.Text = "-"
        '
        'LblMostrarNombre
        '
        Me.LblMostrarNombre.AutoSize = True
        Me.LblMostrarNombre.Location = New System.Drawing.Point(64, 11)
        Me.LblMostrarNombre.Name = "LblMostrarNombre"
        Me.LblMostrarNombre.Size = New System.Drawing.Size(10, 13)
        Me.LblMostrarNombre.TabIndex = 30
        Me.LblMostrarNombre.Text = "-"
        '
        'lblPrecio
        '
        Me.lblPrecio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(11, 63)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(43, 13)
        Me.lblPrecio.TabIndex = 29
        Me.lblPrecio.Text = "Precio :"
        '
        'lblStock
        '
        Me.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(13, 38)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(44, 13)
        Me.lblStock.TabIndex = 28
        Me.lblStock.Text = "Stock : "
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(4, 12)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(50, 13)
        Me.lblNombre.TabIndex = 27
        Me.lblNombre.Text = "Nombre :"
        '
        'btnImagen
        '
        Me.btnImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagen.Font = New System.Drawing.Font("Dungeon", 9.0!)
        Me.btnImagen.Location = New System.Drawing.Point(782, 126)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(100, 23)
        Me.btnImagen.TabIndex = 15
        Me.btnImagen.Text = "Examinar..."
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'PnlDataGrid
        '
        Me.PnlDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlDataGrid.Controls.Add(Me.DataGridProducto)
        Me.PnlDataGrid.Location = New System.Drawing.Point(3, 237)
        Me.PnlDataGrid.Name = "PnlDataGrid"
        Me.PnlDataGrid.Size = New System.Drawing.Size(655, 288)
        Me.PnlDataGrid.TabIndex = 37
        '
        'DataGridProducto
        '
        Me.DataGridProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridProducto.Location = New System.Drawing.Point(1, 3)
        Me.DataGridProducto.Name = "DataGridProducto"
        Me.DataGridProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridProducto.Size = New System.Drawing.Size(651, 285)
        Me.DataGridProducto.TabIndex = 1
        '
        'lblListaCliente
        '
        Me.lblListaCliente.AutoSize = True
        Me.lblListaCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblListaCliente.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaCliente.Location = New System.Drawing.Point(4, 212)
        Me.lblListaCliente.Name = "lblListaCliente"
        Me.lblListaCliente.Size = New System.Drawing.Size(249, 25)
        Me.lblListaCliente.TabIndex = 38
        Me.lblListaCliente.Text = "L I S T A D O   D E   P R O D U C T O S "
        Me.lblListaCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OpenFileDialogProducto
        '
        Me.OpenFileDialogProducto.FileName = "OpenFileDialog1"
        '
        'FrmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(934, 527)
        Me.Controls.Add(Me.lblListaCliente)
        Me.Controls.Add(Me.PnlDataGrid)
        Me.Controls.Add(Me.pnlGroupBox)
        Me.Controls.Add(Me.gbpProductos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GpbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductos"
        Me.Text = "Productos"
        Me.GpbClientes.ResumeLayout(False)
        Me.GpbClientes.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.gbpProductos.ResumeLayout(False)
        Me.gbpProductos.PerformLayout()
        Me.pnlGroupBox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FotoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnpDescProd.ResumeLayout(False)
        Me.pnpDescProd.PerformLayout()
        Me.PnlDataGrid.ResumeLayout(False)
        CType(Me.DataGridProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GpbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents CbxMarca As System.Windows.Forms.CheckBox
    Friend WithEvents CbxNombre As System.Windows.Forms.CheckBox
    Friend WithEvents txtBuscarProductos As System.Windows.Forms.TextBox
    Friend WithEvents CbxDescripcion As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents gbpProductos As GroupBox
    Friend WithEvents btnMasRubro As Button
    Friend WithEvents lblGanancias As Label
    Friend WithEvents cbxMarcas As ComboBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblRubro As Label
    Friend WithEvents cbxRubro As ComboBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlGroupBox As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pnpDescProd As Panel
    Friend WithEvents lblMostrarPrecio As Label
    Friend WithEvents lblMostrarStock As Label
    Friend WithEvents LblMostrarNombre As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents PnlDataGrid As Panel
    Friend WithEvents DataGridProducto As DataGridView
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblImagen As Label
    Friend WithEvents btnImagen As Button
    Friend WithEvents btnMasUnidad As Button
    Friend WithEvents btnMasMarca As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblSelctImg As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lblCantidad As Label
    Friend WithEvents cbxIva As ComboBox
    Friend WithEvents lblIva As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents lblCosto As Label
    Friend WithEvents lblFechaVen As Label
    Friend WithEvents cbxUnidad As ComboBox
    Friend WithEvents lblUnidad As Label
    Friend WithEvents DateTimeProducto As DateTimePicker
    Friend WithEvents txtCodProducto As TextBox
    Friend WithEvents lblCodigoProd As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblListaCliente As Label
    Friend WithEvents FotoProducto As PictureBox
    Friend WithEvents OpenFileDialogProducto As OpenFileDialog
    Friend WithEvents lblMensajeFoto As Label
End Class
