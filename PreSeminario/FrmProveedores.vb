Public Class FrmProveedores
    Dim sql As String = "SELECT * FROM proveedor order by Empresa"
    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MostrarDataGrid(Me.DataGridViewProveedor, Sql)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Agregar(Me)
        MostrarDataGrid(Me.DataGridViewProveedor, Sql)
    End Sub
End Class