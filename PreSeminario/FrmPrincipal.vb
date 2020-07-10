Imports System.Runtime.InteropServices
Public Class FmrPrincipal

    '*** Procedimientos para mover la Ventana***'
    '******CODIGO SENSIBLE A LA ESCRITURA, SE IMPORTAN LIBRERIAS DE WINDOWS*****'
    <DllImport("user32.Dll", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.Dll", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hwnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    '****************************************************************************************************
    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        AbrirFormPanel(New FrmCliente)
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormPanel(New FrmProductos)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormPanel(New FrmVenta)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.btnMaximizar.Visible = False
        Me.btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.btnRestaurar.Visible = False
        Me.btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelBarraTitulo_Paint(sender As Object, e As PaintEventArgs) Handles PanelBarraTitulo.Paint

    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub tmOcultarBarraMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarBarraMenu.Tick
        If (Me.PanelMenu.Width <= 60) Then
            Me.tmOcultarBarraMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If

    End Sub

    Private Sub tmMostrarBarraMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarBarraMenu.Tick
        If PanelMenu.Width >= 200 Then
            Me.tmMostrarBarraMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
            Me.LogoEmpresa.Width = 200
            Me.LogoEmpresa.Height = 105
        End If
    End Sub

    Private Sub btnBarraLateral_Click(sender As Object, e As EventArgs) Handles btnBarraLateral.Click
        If Me.PanelMenu.Width = 200 Then
            tmOcultarBarraMenu.Enabled = True
            Me.LogoEmpresa.Width = 52
            Me.LogoEmpresa.Height = 52
        ElseIf Me.PanelMenu.Width = 60 Then
            Me.tmMostrarBarraMenu.Enabled = True
        End If
        MostrarDataGrid(FrmCliente.DataGridViewCliente, "Select * From Cliente Order By Nombre")
    End Sub

    Private Sub AbrirFormPanel(ByVal FrmHijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(FrmHijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

End Class
