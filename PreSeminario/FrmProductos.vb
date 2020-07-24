Public Class FrmProductos
    Private Sql As String = "SELECT * FROM mostrartabla Order By nombre"


    Public Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Productos"
        Me.lblMensajeFoto.Visible = False
        MostrarDataGrid(Me.DataGridProducto, Sql)
        ComboBox_Load(Me.cbxMarcas, "M")
        ComboBox_Load(Me.cbxUnidad, "U")
        ComboBox_Load(Me.cbxRubro, "R")
        ComboBox_Load(Me.cbxIva, "I")

    End Sub
    Private Sub CbxNombre_CheckedChanged(sender As Object, e As EventArgs) Handles CbxNombre.CheckedChanged
        CheckBox_Valor(CbxNombre, CbxMarca)
        CheckBox_Valor(CbxNombre, CbxDescripcion)
        If Me.CbxNombre.Checked = False Then
            MostrarDataGrid(Me.DataGridProducto, Sql)
        End If
    End Sub

    Private Sub CbxMarca_CheckedChanged(sender As Object, e As EventArgs) Handles CbxMarca.CheckedChanged
        CheckBox_Valor(CbxMarca, CbxNombre)
        CheckBox_Valor(CbxMarca, CbxDescripcion)
        If Me.CbxMarca.Checked = False Then
            MostrarDataGrid(Me.DataGridProducto, Sql)
        End If
    End Sub

    Private Sub CbxDescripcion_CheckedChanged(sender As Object, e As EventArgs) Handles CbxDescripcion.CheckedChanged
        CheckBox_Valor(CbxDescripcion, CbxNombre)
        CheckBox_Valor(CbxDescripcion, CbxMarca)
        If Me.CbxDescripcion.Checked = False Then
            MostrarDataGrid(Me.DataGridProducto, Sql)
        End If
    End Sub

    Private Sub txtBuscarProductos_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProductos.TextChanged
        If BuscarProducto(Me.txtBuscarProductos.Text, Me).Rows.Count > 0 Then
            Me.DataGridProducto.DataSource = BuscarProducto(Me.txtBuscarProductos.Text, Me)
        End If
    End Sub

    Private Sub btnMasRubro_Click(sender As Object, e As EventArgs) Handles btnMasRubro.Click
        FrmAgregarComboBox.Text = "Agregar Rubro"
        FrmAgregarComboBox.Show()
        ComboBox_Load(Me.cbxRubro, "R")
    End Sub

    Private Sub btnMasMarca_Click(sender As Object, e As EventArgs) Handles btnMasMarca.Click
        FrmAgregarComboBox.Text = "Agregar Marca"
        FrmAgregarComboBox.Show()
        ComboBox_Load(Me.cbxMarcas, "M")
    End Sub

    Private Sub btnMasUnidad_Click(sender As Object, e As EventArgs) Handles btnMasUnidad.Click
        FrmAgregarComboBox.Text = "Agregar Unidad"
        FrmAgregarComboBox.Show()
        ComboBox_Load(Me.cbxUnidad, "U")

    End Sub

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        BuscarImagen(Me)
    End Sub

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarProducto()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Me.Text = "Productos" Then

            If Me.txtNombre.Text <> "" And Me.txtCosto.Text <> "" And Me.txtCodProducto.Text <> "" Then

                AgregarProducto(Me)
                MostrarDataGrid(Me.DataGridProducto, Sql)

            Else

                MsgBox("EL CAMPO COSTO ES UN CAMPO DECIMAL. DIGITE EL PRECIO", MsgBoxStyle.Critical, "ADVERTENCIA")

            End If

        ElseIf Me.Text = "Modificar" Then

            ActualizarProductos(Me)
            'Me.txtNombre.Text, Me.cbxRubro.SelectedValue, Me.cbxMarcas.SelectedValue, Me.cbxUnidad.SelectedValue, Me.DateTimeProducto.Value, Replace(Me.txtCosto.Text, ".", ","), cbxIva.SelectedValue, Me.txtCantidad.Text, Me.txtDescripcion.Text, Me.txtCodProducto.Text)
            MostrarDataGrid(Me.DataGridProducto, Sql)

        End If

    End Sub


    Public Sub limpiarProducto()
        Me.txtCosto.Text = ""
        Me.txtCantidad.Text = ""
        Me.txtNombre.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtCodProducto.Text = ""
        Me.txtCodProducto.Enabled = True
        Me.cbxIva.SelectedValue = 1
        Me.cbxUnidad.Text = "Seleccionar"
        Me.cbxRubro.Text = "Seleccionar"
        Me.cbxMarcas.Text = "Seleccionar"
        Me.lblMensajeFoto.Visible = False
        'Me.FotoProducto.Dispose()
        Me.FotoProducto.Image = Nothing
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar(txtCodProducto.Text, 2)
        MostrarDataGrid(Me.DataGridProducto, Sql)
    End Sub

    Private Sub txtCosto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCosto.KeyUp
        ValidarCampoDecimal(Me.txtCosto)
    End Sub



    Private Sub DataGridProducto_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridProducto.MouseClick

        Me.lblMensajeFoto.Visible = False
        Me.Text = "Modificar"
        Me.txtNombre.Text = Me.DataGridProducto.Rows(Me.DataGridProducto.CurrentRow.Index).Cells(1).Value
        Me.txtCodProducto.Text = Me.DataGridProducto.Rows(Me.DataGridProducto.CurrentRow.Index).Cells(2).Value
        Me.txtCodProducto.Enabled = False
        Me.cbxRubro.Text = Me.DataGridProducto.Rows(Me.DataGridProducto.CurrentRow.Index).Cells(4).Value
        Me.cbxMarcas.Text = Me.DataGridProducto.Rows(Me.DataGridProducto.CurrentRow.Index).Cells(3).Value
        Me.cbxUnidad.Text = Me.DataGridProducto.Rows(Me.DataGridProducto.CurrentRow.Index).Cells(11).Value
        Me.txtCosto.Text = Me.DataGridProducto.Rows(Me.DataGridProducto.CurrentRow.Index).Cells(7).Value
        Me.cbxIva.SelectedIndex = Me.DataGridProducto.Rows(Me.DataGridProducto.CurrentRow.Index).Cells(6).Value
        Me.txtCantidad.Text = Me.DataGridProducto.Rows(Me.DataGridProducto.CurrentRow.Index).Cells(10).Value
        Me.txtDescripcion.Text = Me.DataGridProducto.Rows(Me.DataGridProducto.CurrentRow.Index).Cells(9).Value

        Try
            Dim img As String = (Me.DataGridProducto.SelectedRows.Item(0).Cells(12).Value) 'Selecciono el campo donde contiene la imagen del producto y lo guardo en la variable Imagen
            Me.FotoProducto.Image = Image.FromFile(img)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Me.FotoProducto.Image = Nothing
            Me.lblMensajeFoto.Visible = True

        End Try

        Dim Nombre As String = (Me.DataGridProducto.SelectedRows.Item(0).Cells(1).Value)
        Dim Precio As Double = (Me.DataGridProducto.SelectedRows.Item(0).Cells(8).Value)
        Dim Stock As String = (Me.DataGridProducto.SelectedRows.Item(0).Cells(10).Value)

        Me.lblMostrarPrecio.Text = Precio
        Me.lblMostrarStock.Text = Stock
        Me.LblMostrarNombre.Text = Nombre
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        MostrarDataGrid(Me.DataGridProducto, Sql)

    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class