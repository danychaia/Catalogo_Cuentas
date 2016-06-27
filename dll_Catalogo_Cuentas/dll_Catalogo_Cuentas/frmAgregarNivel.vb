Imports System.Windows.Forms

Public Class frmAgregarNivel
    Public nodeSelected As New tbl_mf_catalogo

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Using context As New contaEntities
            Dim catalogo As New tbl_mf_catalogo
            catalogo.id_catalogo = txtCodigoCuenta.Text
            catalogo.ctl_descripcion = txtDescrip.Text
            catalogo.ctl_id_padre = nodeSelected.id_catalogo
            catalogo.id_estado = 1
            catalogo.ctl_nivel = 1
            context.tbl_mf_catalogo.Add(catalogo)
            context.SaveChanges()
        End Using
        Me.Close()
    End Sub
End Class