Imports WindowsApplication1.FrmProductos
Module Procedimietnos
    Public Imagen As String
    Public FrmPrincipal As New WindowsApplication1.FmrPrincipal
    Public Sql As String

    '**************FUNCION PARA MOSTRAR LOS REGISTROS DE LA DATA BASE*********************
    Public Sub MostrarDataGrid(ByVal Table As DataGridView, Sql As String)
        Try
            If ConectarMySql() = True Then 'Pregunto si se conecto a la base de Datos
                Comando.CommandText = Sql
                Comando.CommandType = CommandType.Text
                Comando.Connection = ConexionMysql
                DataReader = Comando.ExecuteReader 'Ejecuto el comando y lo guardo en el DataReader
                Dim dt As New DataTable 'Creo el objeto DataTable
                dt.Load(DataReader) 'cargo la tabla a la variable
                Table.DataSource = dt
                GrillasDefault(Table)
                DataReader.Close()
                ConexionMysql.Close()
            Else
                MsgBox("Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            ConexionMysql.Close()
        End Try

    End Sub

    '******************  FORMATOS DE GRILLAS DEL DATAGRIDVIEW **********************
    Public Sub GrillasDefault(ByVal Table As DataGridView)

        If Table.Columns(0).HeaderText = "Id_Cliente" Then

            Table.Columns(0).Visible = False
            Table.Columns(1).Width = 165
            Table.Columns(2).Width = 165
            Table.Columns(3).Width = 165
            Table.Columns(4).Width = 165
            Table.Columns(5).Width = 165
            Table.Columns(6).Width = 165
            Table.Columns(6).HeaderText = "Zona"
            Table.Columns(7).Width = 165
            Table.Columns(7).HeaderText = "Ciudad"

        ElseIf Table.Columns(0).HeaderText = "Id_Producto" Then

            Table.Columns(0).Visible = False
            Table.Columns(12).Visible = False
            Table.Columns(1).HeaderText = "Nombre"
            Table.Columns(3).HeaderText = "Marca"
            Table.Columns(4).HeaderText = "Rubro"
            Table.Columns(6).HeaderText = "Iva Aplicado"
            Table.Columns(7).HeaderText = "Costo $"
            Table.Columns(8).HeaderText = "Venta $"
            Table.Columns(11).HeaderText = "Unidad de Medida"
        End If
    End Sub
    '****************FUNCIONES PARA INSERTAR***********************************************
    Public Function AgregarClientes(ByVal nombre As String, ByVal apellido As String, ByVal dni As String, ByVal telefono As String, ByVal Correo As String, ByVal direccion As String, ByVal localidad As String) As Boolean
        Dim SQL As String = " INSERT INTO cliente ( Nombre, Apellido, Dni, Telefono, Correo,Direccion,Localidad) Values ('" & nombre & "','" & apellido & "','" & dni & "','" & telefono & "','" & Correo & "','" & direccion & "','" & localidad & "')"
        Try
            EjecutarSql(SQL)
            MsgBox("Exito ", MsgBoxStyle.Information, "Registro Cargado")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function AgregarProducto(Nombre As String, codProd As String, Rubro As String, Marcas As String, Unidad As String, fecha As String, costo As Double, Iva As Integer, cantidad As Integer, Descripcion As String) As Boolean
        '*******CALCULO IVA****************
        Dim Total As Double
        If Iva = 1 Then
            Total = (costo * 0.21) + costo
        ElseIf Iva = 2 Then
            Total = (costo * 0.4) + costo
        End If
        '**********************************
        Sql = "INSERT INTO producto(Id_Iva,Id_Unidad,Id_Marca,Id_Rubro,Stock,Fecha_Vencimiento,Nombre,codigo_producto,Precio_Costo,Precio_Venta,Descripcion,Ruta_Imagen)
               VALUES (" & Replace(Iva, ",", ".") & ",
                " & Unidad & ",'" & Marcas & "','" & Rubro & "','" & cantidad & "','" & Replace(fecha, "/", "\\") & "',
               '" & Nombre & "','" & codProd & "'," & Replace(costo, ",", ".") & "," & Replace(Total, ",", ".") & ",'" & Descripcion & "',
                '" & Replace(Imagen, "\", "\\") & "')"
        Try
            EjecutarSql(Sql)
            MsgBox("Exito", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False


    End Function
    '*******************FUNCIONES PARA MODIFICAR **************************

    Public Function Actualizar(ByVal nombre As String, ByVal apellido As String, ByVal dni As Integer, ByVal telefono As String, ByVal Correo As String, ByVal direccion As String, ByVal localidad As String)
        Sql = "UPDATE Cliente SET Nombre = '" & nombre & "',Apellido = '" & apellido & "',telefono='" & telefono & "',correo ='" & Correo & "',direccion='" & direccion & "',localidad = '" & localidad & "' WHERE dni = " & dni
        Try
            EjecutarSql(Sql)
            MsgBox("Exito", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function ActualizarProductos(Nombre As String, Rubro As String, Marcas As String, Unidad As String, fecha As String, costo As Double, Iva As Integer, cantidad As Double, Descripcion As String, CodProducto As String)
        Sql = "Update Producto Set Nombre = '" & Nombre & "', Id_Rubro = " & Rubro & " , Id_Marca = " & Marcas & ", Id_Unidad = " & Unidad & ", Fecha_Vencimiento = '" & fecha & "', Precio_Costo = " & Replace(costo, ",", ".") & ", Id_Iva = " & Iva & ", Descripcion = '" & Descripcion & "', '" & Replace(Imagen, "\", "\\") & "' where Codigo_Producto = '" & CodProducto & "' "
        Try
            EjecutarSql(Sql)
            MsgBox("Exito", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    '******Eliminar *******

    Public Function Eliminar(id As String, num As Integer)
        If num = 1 Then
            Sql = "Delete from cliente where dni = " & id
        ElseIf num = 2 Then
            Sql = "Delete Form Producto where cod_producto = " & id

        End If

        Try
            EjecutarSql(Sql)
            MsgBox("Exito", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    '******FUNCION PARA QUE NO SE SELECCIONEN DOS CHECKBOX*******
    Public Sub CheckBox_Valor(ByVal chb1 As CheckBox, ByVal chb2 As CheckBox)
        If chb1.Checked = True Then
            chb2.Checked = False
        End If
    End Sub

    '*************************FUNCION PARA AGREGAR MAS MARCAS,RUBROS Y UNIDADES DE MEDIDAS A LA BASE DE DATOS*******************
    Public Function AgregarComboBox(ByVal campo As String, Description As String) As Boolean
        Dim Sql As String = "INSERT INTO " & campo & "  (" & Description & ")
                            values ('" & FrmAgregarComboBox.txtComboBoxAgregar.Text & "')"
        Try
            EjecutarSql(Sql)
            MsgBox("Listo", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
    '******************** FUNCION PARA CARGAR LOS COMBOBOX EN LA VENTANA PRODUCTO *****************************************
    Public Descripcion As String
    Public Sub ComboBox_Load(cbx As ComboBox, bandera As Char)
        Dim dataTable As New DataTable

        Select Case bandera
            Case "R"
                Sql = "select Id,descripcionR from rubro order by descripcionR"
                Descripcion = "DescripcionR"
            Case "U"
                Sql = "select Id,descripcionU from UnidadMedida order by descripcionU"
                Descripcion = "DescripcionU"
            Case "M"
                Sql = "select Id,descripcionM from Marca order by descripcionM"
                Descripcion = "DescripcionM"
            Case "I"
                Sql = "select Id,descripcionI from Iva order by descripcionI"
                Descripcion = "DescripcionI"
            Case Else
                MsgBox("Fallo")
        End Select

        Try
            If ConectarMySql() Then
                Comando.CommandText = Sql
                Comando.CommandType = CommandType.Text
                Comando.Connection = ConexionMysql
                DataReader = Comando.ExecuteReader
                dataTable.Load(DataReader)
                cbx.DataSource = dataTable
                cbx.DisplayMember = Descripcion
                cbx.ValueMember = "Id"
                If bandera = "I" Then
                    cbx.SelectedValue = 1
                Else
                    cbx.SelectedIndex = -1
                    cbx.Text = "Seleccionar "
                End If

                DataReader.Close()
                ConexionMysql.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    '******************** FUNCIONES DE BUSQUEDAS ***********************************
    Public Function BuscarProducto(ByVal busqueda As String) As DataTable
        ' Dim Sql As String
        ' If FrmProductos.CbxDescripcion.Checked = True Then
        ' Sql = "select Nombre,Descripcion,Precio_Venta from producto where descripcion like '" & busqueda & "%' order by Id_Producto"
        'ElseIf FrmProductos.CbxMarca.Checked = True Then
        'Sql = "SELECT Nombre,Id_Marca,Precio_Venta FROM producto WHERE Id_Marca IN (SELECT Id_Marca FROM marca WHERE descripcion LIKE '%" & busqueda & "%') ORDER BY Id_Producto "
        'ElseIf FrmProductos.CbxNombre.Checked = True Then
        'Sql = "select Nombre,Id_Marca,Precio_Venta from producto where Nombre like '" & busqueda & "%' order by Id_Producto"
        'ElseIf FrmProductos.CbxDescripcion.Checked = False And FrmProductos.CbxMarca.Checked = False And FrmProductos.CbxNombre.Checked = False Then
        'Sql = "select * from producto where Nombre like '" & busqueda & "%' or Descripcion like '" & busqueda &
        '       "%' or  Id_Marca IN (SELECT Id_Marca FROM marca WHERE descripcion LIKE '%" & busqueda & "%') order by Id_Producto"
        'End If
        'If ConectarMySql() Then
        'Dim dt As New DataTable
        'Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter(Sql, ConexionMysql)
        'da.Fill(dt)
        'ConexionMysql.Close()
        'Return dt

        'End If
        Return Nothing
    End Function

    Public Function BuscarCliente(ByVal busqueda As String) As DataTable
        Dim Sql As String = ""
        If ConectarMySql() Then
            If FrmCliente.CbxDni.Checked = True Then
                Sql = "select Nombre,Apellido,Dni from cliente where dni like '" & busqueda & "%' order by Id_Cliente"
            ElseIf FrmCliente.CbxNombre.Checked = True Then
                Sql = "select Nombre,Apellido,Dni from Cliente where Nombre like '" & busqueda & "%' order by Id_Cliente"
            ElseIf FrmCliente.CbxNombre.Checked = False And FrmCliente.CbxDni.Checked = False Then
                Sql = "select * from cliente where dni like '" & busqueda & "%' or nombre like '" & busqueda & "%' order by Id_Cliente "
            End If
            Dim dt As New DataTable
            Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter(Sql, ConexionMysql)
            da.Fill(dt)
            ConexionMysql.Close()
            Return dt

        End If
        Return Nothing
    End Function

    '************************BUSCAR IMAGEN DEL PRODUCTO PARA AGREGAR***************
    'Public Sub BuscarImagen(form As FrmProductos)
    '    Dim img As String = Application.StartupPath & "\imagenes"
    '    FrmProductos.OpenFileDialog1.Title = "Seleccione una imagen"
    '    FrmProductos.OpenFileDialog1.InitialDirectory = img
    '    FrmProductos.OpenFileDialog1.Filter = "Imagenes|*.jpg;*.png;*.bmp"
    '    If FrmProductos.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        Imagen = FrmProductos.OpenFileDialog1.FileName
    '        FrmProductos.FotoProducto.Image = Image.FromFile(Imagen)
    '    End If
    'End Sub
    '***************************************************************************

    '****************VALIDAR LOS CAMPOS QUE SEAN TIPO DOUBLE*****************************
    Public Function ValidarCampoDecimal(CajaDeTexto As TextBox)
        Try
            Dim d As Double = Convert.ToDouble(CajaDeTexto.Text)
            Return True
        Catch ex As Exception
            CajaDeTexto.Text = "0.00"
            CajaDeTexto.Select(0, CajaDeTexto.Text.Length)
            Return False
        End Try
    End Function

    '***************************************************************************
End Module