
Module Funciones
    Public Imagen As String
    Public Sql As String
    Public Descripcion As String

    '**************FUNCION PARA MOSTRAR LOS REGISTROS DE LA DATA BASE*********************
    Public Sub MostrarDataGrid(ByVal Table As DataGridView, Sqlx As String)
        Try
            If ConectarMySql() = True Then 'Pregunto si se conecto a la base de Datos
                Comando.CommandText = Sqlx
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
    Public Function AgregarClientes(ByVal Frm As FrmCliente) As Boolean
        Dim SQL As String = " INSERT INTO cliente ( Nombre, Apellido, Dni, Telefono, Correo,Direccion,Localidad) Values ('" & Frm.TxtNombre.Text & "','" & Frm.TxtApelido.Text & "','" & Frm.TxtDni.Text & "','" & Frm.TxtTelefono.Text & "','" & Frm.TxtCorreo.Text & "','" & Frm.TxtDireccion.Text & "','" & Frm.TxtLocalidad.Text & "')"
        Try
            EjecutarSql(SQL)
            MsgBox("Exito ", MsgBoxStyle.Information, "Registro Cargado")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function AgregarProducto(ByRef Frm As FrmProductos) As Boolean
        '*******CALCULO IVA****************
        Dim Total As Double
        If Frm.cbxIva.SelectedIndex = 0 Then
            Total = (Frm.txtCosto.Text * 0.21) + Frm.txtCosto.Text
        ElseIf Frm.cbxIva.SelectedIndex = 1 Then
            Total = (Frm.txtCosto.Text * 0.4) + Frm.txtCosto.Text
        End If
        '**********************************
        Sql = "INSERT INTO producto(Id_Iva,Id_Unidad,Id_Marca,Id_Rubro,Stock,Fecha_Vencimiento,Nombre,codigo_producto,Precio_Costo,Precio_Venta,Descripcion,Ruta_Imagen) VALUES (" & Replace(Frm.cbxIva.SelectedValue, ",", ".") & "," & Frm.cbxUnidad.SelectedValue & ",'" & Frm.cbxMarcas.SelectedValue & "','" & Frm.cbxRubro.SelectedValue & "','" & Frm.txtCantidad.Text & "','" & Replace(Frm.DateTimeProducto.Value, "/", "\\") & "', '" & Frm.txtNombre.Text & "','" & Frm.txtCodProducto.Text & "'," & Replace(Frm.txtCosto.Text, ",", ".") & "," & Replace(Total, ",", ".") & ",'" & Frm.txtDescripcion.Text & "','" & Replace(Imagen, "\", "\\") & "')"
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

    Public Function ActualizarCliente(ByVal Frm As FrmCliente)
        Sql = "UPDATE Cliente SET Nombre = '" & Frm.TxtNombre.Text & "',Apellido = '" & Frm.TxtApelido.Text & "',telefono='" & Frm.TxtTelefono.Text & "',correo ='" & Frm.TxtCorreo.Text & "',direccion='" & Frm.TxtDireccion.Text & "',localidad = '" & Frm.TxtLocalidad.Text & "' WHERE dni = " & Frm.TxtDni.Text

        Try
            EjecutarSql(Sql)
            MsgBox("Exito", MsgBoxStyle.Information)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return False

    End Function

    Public Function ActualizarProductos(ByVal Frm As FrmProductos)
        '*******CALCULO IVA****************
        Dim Bandera As Integer = Frm.cbxIva.SelectedValue
        Dim Iva As Double
        If Bandera = 1 Then
            Iva = 0.21
        ElseIf Bandera = 2 Then
            Iva = 0.4
        Else
            MsgBox("Iva Incorrecto!")
        End If
        Dim Total As Double
        Dim SubTotal As Double
        Dim Costo As Double = Frm.txtCosto.Text
        SubTotal = Iva * Costo
        Total = Costo + SubTotal
        '**********************************

        Sql = "UPDATE Producto Set Nombre = '" & Frm.txtNombre.Text & "',Id_Marca = " & Frm.cbxMarcas.SelectedValue & " , Id_Rubro = " & Frm.cbxRubro.SelectedValue & ", Ruta_Imagen = '" & Replace(Imagen, "\", "\\") & "', Fecha_Vencimiento= '" & Frm.DateTimeProducto.Value & "', Id_Iva = " & Frm.cbxIva.SelectedValue & " , Precio_Costo = " & Replace(Frm.txtCosto.Text, ",", ".") & " , Precio_Venta = " & Replace(Total, ",", ".") & " , Id_Unidad = " & Frm.cbxUnidad.SelectedValue & ", Descripcion = '" & Frm.txtDescripcion.Text & "' , Stock = " & Frm.txtCantidad.Text & " Where Codigo_Producto = '" & Frm.txtCodProducto.Text & "' "
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
            Sql = "Delete from Producto where codigo_producto = '" & id & "'"

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
    Public Function BuscarProducto(ByVal busqueda As String, Frm As FrmProductos) As DataTable

        If Frm.CbxDescripcion.Checked = True Then
            Sql = "select * from mostrartabla where descripcion like '" & busqueda & "%' order by Nombre"
        ElseIf Frm.CbxMarca.Checked = True Then
            Sql = "SELECT * FROM mostrartabla WHERE DescripcionM LIKE '" & busqueda & "%' ORDER BY nombre"
        ElseIf Frm.CbxNombre.Checked = True Then
            Sql = "select * from mostrartabla where Nombre like '" & busqueda & "%' order by nombre"
        ElseIf Frm.CbxDescripcion.Checked = False And Frm.CbxMarca.Checked = False And Frm.CbxNombre.Checked = False Then
            Sql = "select * from Mostrartabla where Nombre like '" & busqueda & "%' or Descripcion like '" & busqueda &
                   "%' or  DescripcionM LIKE '%" & busqueda & "%' order by Nombre"
        End If
        If ConectarMySql() Then
            Dim dt As New DataTable
            Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter(Sql, ConexionMysql)
            da.Fill(dt)
            ConexionMysql.Close()
            Return dt
        End If
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
    Public Sub BuscarImagen(ByVal Frm As FrmProductos)
        Dim img As String = Application.StartupPath & "\imagenes"
        Frm.OpenFileDialogProducto.Title = "Seleccione una imagen"
        Frm.OpenFileDialogProducto.InitialDirectory = img
        Frm.OpenFileDialogProducto.Filter = "Imagenes|*.jpg;*.png;*.bmp"

        If Frm.OpenFileDialogProducto.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Imagen = Frm.OpenFileDialogProducto.FileName
            Frm.FotoProducto.Image = Image.FromFile(Imagen)

        End If

    End Sub
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

