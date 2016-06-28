<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frAgregarNivelDos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbCodigoCuenta = New System.Windows.Forms.Label()
        Me.LbDescrip = New System.Windows.Forms.Label()
        Me.txCodigo = New System.Windows.Forms.TextBox()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbCodigoCuenta
        '
        Me.lbCodigoCuenta.AutoSize = True
        Me.lbCodigoCuenta.Location = New System.Drawing.Point(23, 16)
        Me.lbCodigoCuenta.Name = "lbCodigoCuenta"
        Me.lbCodigoCuenta.Size = New System.Drawing.Size(92, 13)
        Me.lbCodigoCuenta.TabIndex = 0
        Me.lbCodigoCuenta.Text = "Codigo de Cuenta"
        '
        'LbDescrip
        '
        Me.LbDescrip.AutoSize = True
        Me.LbDescrip.Location = New System.Drawing.Point(145, 16)
        Me.LbDescrip.Name = "LbDescrip"
        Me.LbDescrip.Size = New System.Drawing.Size(126, 13)
        Me.LbDescrip.TabIndex = 1
        Me.LbDescrip.Text = "Descripcion de la Cuenta"
        '
        'txCodigo
        '
        Me.txCodigo.Location = New System.Drawing.Point(12, 32)
        Me.txCodigo.Name = "txCodigo"
        Me.txCodigo.Size = New System.Drawing.Size(118, 20)
        Me.txCodigo.TabIndex = 3
        '
        'txtDescrip
        '
        Me.txtDescrip.Location = New System.Drawing.Point(148, 32)
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(123, 20)
        Me.txtDescrip.TabIndex = 4
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(91, 58)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frAgregarNivelDos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 93)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtDescrip)
        Me.Controls.Add(Me.txCodigo)
        Me.Controls.Add(Me.LbDescrip)
        Me.Controls.Add(Me.lbCodigoCuenta)
        Me.Name = "frAgregarNivelDos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frAgregarNivelDos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbCodigoCuenta As System.Windows.Forms.Label
    Friend WithEvents LbDescrip As System.Windows.Forms.Label
    Friend WithEvents txCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
