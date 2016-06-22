Imports System.Windows.Forms

Public Class frmCatalogoCuentas

    Private Sub btnAgregarRow_Click(sender As Object, e As EventArgs) Handles btnAgregarRow.Click
        Me.dgwCatalogo.Rows.Add()
    End Sub

    Private Sub btnAgregarRow_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAgregarRow.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.dgwCatalogo.Rows.Add()
        End If
    End Sub
End Class