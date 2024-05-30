<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTecnicos
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
        Me.btnRealizarSer = New System.Windows.Forms.Button()
        Me.btnVerServi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRealizarSer
        '
        Me.btnRealizarSer.Location = New System.Drawing.Point(421, 456)
        Me.btnRealizarSer.Name = "btnRealizarSer"
        Me.btnRealizarSer.Size = New System.Drawing.Size(155, 53)
        Me.btnRealizarSer.TabIndex = 0
        Me.btnRealizarSer.Text = "Realizar Servicio"
        Me.btnRealizarSer.UseVisualStyleBackColor = True
        '
        'btnVerServi
        '
        Me.btnVerServi.Location = New System.Drawing.Point(804, 456)
        Me.btnVerServi.Name = "btnVerServi"
        Me.btnVerServi.Size = New System.Drawing.Size(155, 53)
        Me.btnVerServi.TabIndex = 1
        Me.btnVerServi.Text = "Ver Servicio"
        Me.btnVerServi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(646, 157)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "TECNICOS"
        '
        'frmTecnicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 781)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVerServi)
        Me.Controls.Add(Me.btnRealizarSer)
        Me.Name = "frmTecnicos"
        Me.Text = "Bienvenido Técnico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRealizarSer As Button
    Friend WithEvents btnVerServi As Button
    Friend WithEvents Label1 As Label
End Class
