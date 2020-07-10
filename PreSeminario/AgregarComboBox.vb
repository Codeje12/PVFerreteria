Public Class FrmAgregarComboBox

    Private Sub btnAgregarCheck_Click_1(sender As Object, e As EventArgs) Handles btnAgregarCheck.Click
        Dim Frm As New FrmProductos
        If Me.Text = "Agregar Rubro" Then
            AgregarComboBox("Rubro", "DescripcionR")
            ComboBox_Load(Frm.cbxRubro, "R")
        ElseIf Me.Text = "Agregar Marca" Then
            AgregarComboBox("Marca", "DescripcionM")
            ComboBox_Load(Frm.cbxMarcas, "M")
        ElseIf Me.Text = "Agregar Unidad" Then
            AgregarComboBox("UnidadMedida", "DescripcionU")
            ComboBox_Load(Frm.cbxUnidad, "U")
        End If

        ComboBox_Load(Frm.cbxRubro, "R")
        ComboBox_Load(Frm.cbxMarcas, "M")
        ComboBox_Load(Frm.cbxUnidad, "U")
        Me.txtComboBoxAgregar.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class