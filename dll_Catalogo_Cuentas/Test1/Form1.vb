Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New dll_Catalogo_Cuentas.frmCatalogoCuentas()
        frm.idEmpresa = 1
        frm.ShowDialog()
    End Sub
End Class
