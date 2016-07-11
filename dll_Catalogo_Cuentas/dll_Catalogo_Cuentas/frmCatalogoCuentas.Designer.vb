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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAgregarNivel = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregarRow = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgwCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tw_Catalogo)
        Me.Panel1.Location = New System.Drawing.Point(5, 12)
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
        Me.dgwCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.dgwCatalogo.MultiSelect = False
        Me.dgwCatalogo.Name = "dgwCatalogo"
        Me.dgwCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwCatalogo.Size = New System.Drawing.Size(478, 371)
        Me.dgwCatalogo.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.dgwCatalogo)
        Me.Panel2.Location = New System.Drawing.Point(327, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 371)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnAgregarNivel)
        Me.Panel3.Controls.Add(Me.btnModificar)
        Me.Panel3.Controls.Add(Me.btnAgregarRow)
        Me.Panel3.Location = New System.Drawing.Point(5, 389)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 73)
        Me.Panel3.TabIndex = 5
        '
        'btnAgregarNivel
        '
        Me.btnAgregarNivel.BackgroundImage = CType(resources.GetObject("btnAgregarNivel.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarNivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarNivel.Location = New System.Drawing.Point(14, 3)
        Me.btnAgregarNivel.Name = "btnAgregarNivel"
        Me.btnAgregarNivel.Size = New System.Drawing.Size(69, 63)
        Me.btnAgregarNivel.TabIndex = 4
        Me.ToolTip3.SetToolTip(Me.btnAgregarNivel, "Agregar nivel")
        Me.ToolTip1.SetToolTip(Me.btnAgregarNivel, "Agregar")
        Me.btnAgregarNivel.UseCompatibleTextRendering = True
        Me.btnAgregarNivel.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.BackgroundImage = Global.dll_Catalogo_Cuentas.My.Resources.Resources.pen
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Location = New System.Drawing.Point(706, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(69, 63)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregarRow
        '
        Me.btnAgregarRow.BackgroundImage = Global.dll_Catalogo_Cuentas.My.Resources.Resources.Floppy_disk_512
        Me.btnAgregarRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarRow.CausesValidation = False
        Me.btnAgregarRow.Location = New System.Drawing.Point(631, 3)
        Me.btnAgregarRow.Name = "btnAgregarRow"
        Me.btnAgregarRow.Size = New System.Drawing.Size(69, 63)
        Me.btnAgregarRow.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnAgregarRow, "Agregar")
        Me.btnAgregarRow.UseCompatibleTextRendering = True
        Me.btnAgregarRow.UseVisualStyleBackColor = True
        '
        'frmCatalogoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(815, 467)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCatalogoCuentas"
        Me.Text = "Catalogo de cuentas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgwCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tw_Catalogo As System.Windows.Forms.TreeView
    Friend WithEvents dgwCatalogo As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregarRow As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregarNivel As System.Windows.Forms.Button
End Class
