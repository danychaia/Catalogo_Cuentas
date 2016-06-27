Imports System.Windows.Forms

Public Class frmCatalogoCuentas
    Private selectNode = Nothing
    Private isselect As Integer = 0

    Private Sub btnAgregarRow_Click(sender As Object, e As EventArgs) Handles btnAgregarRow.Click
        Me.dgwCatalogo.Rows.Add()
    End Sub

    Private Sub btnAgregarRow_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAgregarRow.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.dgwCatalogo.Rows.Add()
        End If
    End Sub

    Private Sub frmCatalogoCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCatalogoCuentas()
    End Sub

    Private Sub cargarCatalogoCuentas()
        Dim cuentas As New List(Of tbl_mf_catalogo)
        Using context As New contaEntities()
            cuentas = context.tbl_mf_catalogo.ToList
        End Using
        Dim nodo As New TreeNode("CATALOGO CONTABLE")
        nodo.Tag = "raiz"
        nodo.ToolTipText = "raiz"
        llenarArbolCuentas(cuentas, "-1", nodo)
    End Sub
    Private Sub llenarArbolCuentas(cuentas As List(Of tbl_mf_catalogo), cuentaPadre As String, nodoPadre As TreeNode)
        Dim nuevasCuentas = From c In cuentas
                        Where c.ctl_id_padre = cuentaPadre And c.ctl_nivel = 1 And c.id_estado = 1
                        Select c
        For Each item As tbl_mf_catalogo In nuevasCuentas
            Dim tnNodo As New TreeNode(item.id_catalogo & "-" & item.ctl_descripcion)
            tnNodo.Tag = item.id_catalogo
            tnNodo.ToolTipText = item.ctl_id_padre
            If cuentaPadre = "-1" Then
                If (nodoPadre.Text = "CATALOGO CONTABLE") Then
                    tw_Catalogo.Nodes.Add(nodoPadre)
                End If
                tw_Catalogo.Nodes.Add(tnNodo)
                tw_Catalogo.ExpandAll()
            Else
                nodoPadre.Nodes.Add(tnNodo)
            End If
            llenarArbolCuentas(cuentas, item.id_catalogo, tnNodo)
        Next
    End Sub

    Private Sub btnAgregarNivel_Click(sender As Object, e As EventArgs) Handles btnAgregarNivel.Click
        If isselect = 0 Then
            MessageBox.Show("Debe de seleccionar una clasificacion")

        Else
            Dim agregar_nivel As New frmAgregarNivel()
            agregar_nivel.ShowDialog()
        End If

    End Sub

    Private Sub tw_Catalogo_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tw_Catalogo.AfterSelect
        Dim esnselect As New TreeNode()
        esnselect = e.Node
        Me.selectNode = New tbl_mf_catalogo
        Me.selectNode.id_catalogo = esnselect.Tag.ToString
        Me.selectNode.ctl_id_padre = esnselect.ToolTipText.ToString
        Me.isselect = 1
        '' MessageBox.Show("codigo  " & selectNode.id_catalogo & "  idPadre  " & selectNode.ctl_id_padre)
    End Sub
End Class