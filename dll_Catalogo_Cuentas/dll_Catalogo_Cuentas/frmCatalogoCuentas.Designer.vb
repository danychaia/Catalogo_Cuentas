<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCatalogoCuentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogoCuentas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tw_Catalogo = New System.Windows.Forms.TreeView()
        Me.dgwCatalogo = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAgregarRow = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAgregarNivel = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgwCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tw_Catalogo)
        Me.Panel1.Location = New System.Drawing.Point(12, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 371)
        Me.Panel1.TabIndex = 0
        '
        'tw_Catalogo
        '
        Me.tw_Catalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tw_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tw_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.tw_Catalogo.Name = "tw_Catalogo"
        Me.tw_Catalogo.Size = New System.Drawing.Size(309, 371)
        Me.tw_Catalogo.TabIndex = 0
        '
        'dgwCatalogo
        '
        Me.dgwCatalogo.AllowUserToAddRows = False
        Me.dgwCatalogo.AllowUserToDeleteRows = False
        Me.dgwCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwCatalogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion})
        Me.dgwCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.dgwCatalogo.MultiSelect = False
        Me.dgwCatalogo.Name = "dgwCatalogo"
        Me.dgwCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwCatalogo.Size = New System.Drawing.Size(478, 371)
        Me.dgwCatalogo.TabIndex = 1
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.dgwCatalogo)
        Me.Panel2.Location = New System.Drawing.Point(327, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 371)
        Me.Panel2.TabIndex = 1
        '
        'btnAgregarRow
        '
        Me.btnAgregarRow.Image = CType(resources.GetObject("btnAgregarRow.Image"), System.Drawing.Image)
        Me.btnAgregarRow.Location = New System.Drawing.Point(712, 32)
        Me.btnAgregarRow.Name = "btnAgregarRow"
        Me.btnAgregarRow.Size = New System.Drawing.Size(22, 23)
        Me.btnAgregarRow.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnAgregarRow, "Agregar")
        Me.btnAgregarRow.UseCompatibleTextRendering = True
        Me.btnAgregarRow.UseVisualStyleBackColor = True
        '
        'btnAgregarNivel
        '
        Me.btnAgregarNivel.Image = CType(resources.GetObject("btnAgregarNivel.Image"), System.Drawing.Image)
        Me.btnAgregarNivel.Location = New System.Drawing.Point(21, 32)
        Me.btnAgregarNivel.Name = "btnAgregarNivel"
        Me.btnAgregarNivel.Size = New System.Drawing.Size(22, 23)
        Me.btnAgregarNivel.TabIndex = 4
        Me.ToolTip3.SetToolTip(Me.btnAgregarNivel, "Agregar nivel")
        Me.ToolTip1.SetToolTip(Me.btnAgregarNivel, "Agregar")
        Me.btnAgregarNivel.UseCompatibleTextRendering = True
        Me.btnAgregarNivel.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(741, 31)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(22, 23)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmCatalogoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 446)
        Me.Controls.Add(Me.btnAgregarNivel)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregarRow)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCatalogoCuentas"
        Me.Text = "Catalogo de cuentas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgwCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tw_Catalogo As System.Windows.Forms.TreeView
    Friend WithEvents dgwCatalogo As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregarRow As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAgregarNivel As System.Windows.Forms.Button
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
End Class
