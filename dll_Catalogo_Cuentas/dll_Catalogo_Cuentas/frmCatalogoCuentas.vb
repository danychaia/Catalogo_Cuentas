'/***************************************************************
'NOMBRE:DLL CATALOGO DE CUENTAS
'FECHA: 23/06/2016
'CREADOR: DANIEL ISAIAS MORENO
'DESCRIPCIÓN CONSTRUYE EL CATALOGO DE CUENTAS CONTABLES
'DETALLE: ARBOL DE CUENTAS CONTABLES
'MODIFICACIÓN: 10/07/2016
'***************************************************************/
Imports System.Windows.Forms

Public Class frmCatalogoCuentas
    Private selectNode As New tbl_mf_catalogo
    Public cuenta_seleccionada As New tbl_mf_catalogo
    Public idEmpresa As New Integer
    Private isselect As Integer = 0

    Private Sub btnAgregarRow_Click(sender As Object, e As EventArgs) Handles btnAgregarRow.Click

        If isselect = 0 Then
            MessageBox.Show("Debe de seleccionar una clasificacion")
        Else
            Dim agregarNivel As New frAgregarNivelDos()
            agregarNivel.nodeSelected = selectNode
            agregarNivel.ShowDialog()
            tw_Catalogo.Nodes.Clear()
            cargarCatalogoCuentas()
            dgwCatalogo.DataSource = Nothing
        End If
    End Sub

    Private Sub btnAgregarRow_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAgregarRow.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnAgregarRow_Click(Me, Nothing)
        End If
    End Sub

    Private Sub frmCatalogoCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCatalogoCuentas()
    End Sub

    Private Sub cargarCatalogoCuentas()
        Dim cuentas As New List(Of tbl_mf_catalogo)
        Using context As New FinanzasG2Entities()
            cuentas = context.tbl_mf_catalogo.ToList
        End Using
        llenarArbolCuentas(cuentas, "-1", Nothing)
    End Sub
    Private Sub llenarArbolCuentas(cuentas As List(Of tbl_mf_catalogo), cuentaPadre As String, nodoPadre As TreeNode)
        Dim nuevasCuentas = From c In cuentas
                        Where c.ctl_id_padre = cuentaPadre And c.ctl_nivel = 1 And c.id_estado = 1 And c.id_empresa = idEmpresa
                        Select c
        For Each item As tbl_mf_catalogo In nuevasCuentas
            Dim tnNodo As New TreeNode(item.id_catalogo & "-" & item.ctl_descripcion)
            tnNodo.Tag = item.id_catalogo
            tnNodo.ToolTipText = item.ctl_id_padre
            If cuentaPadre = "-1" Then
                tw_Catalogo.Nodes.Add(tnNodo)
                tw_Catalogo.ExpandAll()
            Else
                nodoPadre.Nodes.Add(tnNodo)
                nodoPadre.ExpandAll()
            End If
            llenarArbolCuentas(cuentas, item.id_catalogo, tnNodo)
        Next
    End Sub

    Private Sub btnAgregarNivel_Click(sender As Object, e As EventArgs) Handles btnAgregarNivel.Click
        If isselect = 0 Then
            MessageBox.Show("Debe de seleccionar una clasificacion")
        Else
            Dim agregar_nivel As New frmAgregarNivel()
            agregar_nivel.nodeSelected = selectNode
            agregar_nivel.ShowDialog()
            tw_Catalogo.Nodes.Clear()
            cargarCatalogoCuentas()
        End If

    End Sub

    Private Sub tw_Catalogo_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tw_Catalogo.AfterSelect
        Dim esnselect As New TreeNode()
        esnselect = e.Node
        'Me.selectNode = New tbl_mf_catalogo
        Me.selectNode.id_catalogo = esnselect.Tag.ToString
        Me.selectNode.ctl_id_padre = esnselect.ToolTipText.ToString
        Me.isselect = 1
        Me.cuenta_seleccionada = Me.selectNode
        Me.cuenta_seleccionada.ctl_descripcion = esnselect.Text
        '' MessageBox.Show("Codigo de Cuenta  " & selectNode.id_catalogo & " codigo padre  " & selectNode.ctl_id_padre)
        If (esnselect.Tag.ToString = "-100" Or esnselect.ToolTipText.ToString = "-100") Then
            dgwCatalogo.DataSource = Nothing
        Else
            Dim drrow As DataRow
            Using context As New FinanzasG2Entities()
                Dim listaNiveldos = From b In context.tbl_mf_catalogo
                                      Where b.ctl_id_padre = Me.selectNode.id_catalogo
                                      Select b
                Dim dtdatos As New DataTable
                dtdatos.Columns.Add("CODIGO CUENTA")
                dtdatos.Columns.Add("DESCRIPCION")
                dtdatos.Columns.Add("CODIGO PADRE")
                For Each item As tbl_mf_catalogo In listaNiveldos
                    drrow = dtdatos.NewRow
                    drrow(0) = item.id_catalogo
                    drrow(1) = item.ctl_descripcion
                    drrow(2) = item.ctl_id_padre
                    dtdatos.Rows.Add(drrow)
                Next
                dgwCatalogo.DataSource = dtdatos
                dgwCatalogo.Columns(0).Width = 200
                dgwCatalogo.Columns(1).Width = 200
                dgwCatalogo.Columns(2).Visible = False
            End Using

        End If

      

        '' MessageBox.Show("codigo  " & selectNode.id_catalogo & "  idPadre  " & selectNode.ctl_id_padre)
    End Sub

    Private Sub dgwCatalogo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwCatalogo.CellDoubleClick
        cuenta_seleccionada.id_catalogo = dgwCatalogo.SelectedRows(e.RowIndex).Cells("CODIGO CUENTA").Value
        cuenta_seleccionada.ctl_descripcion = dgwCatalogo.SelectedRows(e.RowIndex).Cells("DESCRIPCION").Value
        cuenta_seleccionada.ctl_id_padre = dgwCatalogo.SelectedRows(e.RowIndex).Cells("CODIGO PADRE").Value
        Me.Close()
    End Sub
End Class