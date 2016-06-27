Imports System.Windows.Forms

Public Class frmAgregarNivel
    Public nodeSelected As New TreeNode

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Using context As New contaEntities
            Dim catalogo As New tbl_mf_catalogo
            catalogo.id_catalogo = txtCodigoCuenta.Text
            catalogo.ctl_descripcion = txtDescrip.Text

        End Using
    End Sub
End Class