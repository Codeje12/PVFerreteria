Public Class FrmCliente
    Private Sql As String = "Select * From Cliente Order By Nombre"

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDataGrid(Me.DataGridViewCliente, Sql)
    End Sub

    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Text = "Clientes"
        limpiarCliente()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MostrarDataGrid(Me.DataGridViewCliente, Sql)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar(Me.TxtDni.Text, 1)
        MostrarDataGrid(Me.DataGridViewCliente, Sql)
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CbxNombre_CheckedChanged_1(sender As Object, e As EventArgs) Handles CbxNombre.CheckedChanged
        CheckBox_Valor(CbxNombre, CbxDni)
        If Me.CbxNombre.Checked = False Then
            MostrarDataGrid(Me.DataGridViewCliente, Sql)
        End If
    End Sub

    Private Sub CbxDni_CheckedChanged(sender As Object, e As EventArgs) Handles CbxDni.CheckedChanged
        CheckBox_Valor(CbxDni, CbxNombre)
        If Me.CbxDni.Checked = False Then
            MostrarDataGrid(Me.DataGridViewCliente, Sql)
        End If
    End Sub

    Private Sub txtBuscarClientes_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarClientes.TextChanged
        If BuscarCliente(Me.txtBuscarClientes.Text).Rows.Count > 0 Then
            Me.DataGridViewCliente.DataSource = BuscarCliente(Me.txtBuscarClientes.Text)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.Text = "Modificar" Then
            Actualizar(Me.TxtNombre.Text, Me.TxtApelido.Text, Me.TxtDni.Text, Me.TxtTelefono.Text, Me.TxtCorreo.Text, Me.TxtDireccion.Text, Me.TxtLocalidad.Text)
        ElseIf Me.Text = "Clientes" Then

            If TxtNombre.Text <> "" And TxtApelido.Text <> "" Then
                AgregarClientes(Me.TxtNombre.Text, Me.TxtApelido.Text, Me.TxtDni.Text, Me.TxtTelefono.Text, Me.TxtCorreo.Text, Me.TxtDireccion.Text, Me.TxtLocalidad.Text)
                MostrarDataGrid(Me.DataGridViewCliente, Sql)
            Else
                MsgBox("Hay campos que no pueden quedar vacios! (NOMBRE, APELLIDO, DNI)", MsgBoxStyle.Critical, "AVISO!")
            End If
        End If


    End Sub
    '******FUNCIONES PARA LIMPIAR LOS TEXTBOX*********
    Public Sub limpiarCliente()
        Me.TxtNombre.Text = ""
        Me.TxtApelido.Text = ""
        Me.TxtDni.Text = ""
        Me.TxtDni.Enabled = True
        Me.TxtCorreo.Text = ""
        Me.TxtTelefono.Text = ""
        Me.TxtDireccion.Text = ""
        Me.TxtLocalidad.Text = ""
    End Sub

    Private Sub DataGridViewCliente_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridViewCliente.MouseDoubleClick
        Me.TxtDni.Enabled = False

        Try
            Me.TxtNombre.Text = Me.DataGridViewCliente.Rows(Me.DataGridViewCliente.CurrentRow.Index).Cells(1).Value
            Me.TxtApelido.Text = Me.DataGridViewCliente.Rows(Me.DataGridViewCliente.CurrentRow.Index).Cells(2).Value
            Me.TxtDni.Text = Me.DataGridViewCliente.Rows(Me.DataGridViewCliente.CurrentRow.Index).Cells(3).Value
            Me.TxtCorreo.Text = Me.DataGridViewCliente.Rows(Me.DataGridViewCliente.CurrentRow.Index).Cells(4).Value
            Me.TxtTelefono.Text = Me.DataGridViewCliente.Rows(Me.DataGridViewCliente.CurrentRow.Index).Cells(5).Value
            Me.TxtDireccion.Text = Me.DataGridViewCliente.Rows(Me.DataGridViewCliente.CurrentRow.Index).Cells(6).Value
            Me.TxtLocalidad.Text = Me.DataGridViewCliente.Rows(Me.DataGridViewCliente.CurrentRow.Index).Cells(7).Value
            Me.Text = "Modificar"
        Catch ex As Exception

        End Try
    End Sub


End Class