Public Class FrmProveedores
    Dim sql As String = "SELECT * FROM proveedor order by Empresa"
    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Proveedores"
        MostrarDataGrid(Me.DataGridViewProveedor, sql)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Me.Text = "Modificar" Then
            ActualizarProveedor(Me)
        ElseIf Me.Text = "Proveedores" Then
            If TxtNombre.Text <> "" And txtEmpresa.Text <> "" Then
                AgregarProveedor(Me)
                MostrarDataGrid(Me.DataGridViewProveedor, sql)
            End If
        Else
            MsgBox("Hay campos que no pueden quedar vacios! (NOMBRE Y EMPRESA)", MsgBoxStyle.Critical, "AVISO!")

        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Text = "Proveeores"
        limpiarCampos()
    End Sub

    Public Sub limpiarCampos()
        Dim obj As Control
        For Each obj In
        Me.GroupBox1.Controls
            If TypeOf (obj) Is TextBox Then
                obj.Text = ""
                CType(obj, TextBox).ReadOnly = False
            End If
        Next
        Me.TxtDni.Enabled = True
    End Sub

    Private Sub DataGridViewProveedor_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridViewProveedor.MouseClick
        Me.TxtDni.Enabled = False
        Me.Text = "Modificar"
        Try
            Me.TxtNombre.Text = Me.DataGridViewProveedor.Rows(Me.DataGridViewProveedor.CurrentRow.Index).Cells(1).Value
            Me.TxtApelido.Text = Me.DataGridViewProveedor.Rows(Me.DataGridViewProveedor.CurrentRow.Index).Cells(2).Value
            Me.TxtDni.Text = Me.DataGridViewProveedor.Rows(Me.DataGridViewProveedor.CurrentRow.Index).Cells(3).Value
            Me.TxtCorreo.Text = Me.DataGridViewProveedor.Rows(Me.DataGridViewProveedor.CurrentRow.Index).Cells(4).Value
            Me.TxtTelefono.Text = Me.DataGridViewProveedor.Rows(Me.DataGridViewProveedor.CurrentRow.Index).Cells(5).Value
            Me.TxtDireccion.Text = Me.DataGridViewProveedor.Rows(Me.DataGridViewProveedor.CurrentRow.Index).Cells(6).Value
            Me.TxtLocalidad.Text = Me.DataGridViewProveedor.Rows(Me.DataGridViewProveedor.CurrentRow.Index).Cells(7).Value
            Me.txtEmpresa.Text = Me.DataGridViewProveedor.Rows(Me.DataGridViewProveedor.CurrentRow.Index).Cells(8).Value

        Catch ex As Exception
            MsgBox("")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        MostrarDataGrid(Me.DataGridViewProveedor, sql)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar(TxtDni.Text, 3)
    End Sub
End Class