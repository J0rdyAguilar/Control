<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.btnSoli = New System.Windows.Forms.Button()
        Me.btnVerServicios = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSoli
        '
        Me.btnSoli.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnSoli.Image = CType(resources.GetObject("btnSoli.Image"), System.Drawing.Image)
        Me.btnSoli.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSoli.Location = New System.Drawing.Point(549, 544)
        Me.btnSoli.Name = "btnSoli"
        Me.btnSoli.Size = New System.Drawing.Size(165, 127)
        Me.btnSoli.TabIndex = 0
        Me.btnSoli.Text = "Solicitar Servicio"
        Me.btnSoli.UseVisualStyleBackColor = True
        '
        'btnVerServicios
        '
        Me.btnVerServicios.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnVerServicios.Image = CType(resources.GetObject("btnVerServicios.Image"), System.Drawing.Image)
        Me.btnVerServicios.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnVerServicios.Location = New System.Drawing.Point(1327, 551)
        Me.btnVerServicios.Name = "btnVerServicios"
        Me.btnVerServicios.Size = New System.Drawing.Size(145, 112)
        Me.btnVerServicios.TabIndex = 1
        Me.btnVerServicios.Text = "Ver Servicios"
        Me.btnVerServicios.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(606, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(634, 157)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CLIENTES"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 815)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVerServicios)
        Me.Controls.Add(Me.btnSoli)
        Me.Name = "frmClientes"
        Me.Text = "Bienvenido Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSoli As Button
    Friend WithEvents btnVerServicios As Button
    Friend WithEvents Label1 As Label
End Class
