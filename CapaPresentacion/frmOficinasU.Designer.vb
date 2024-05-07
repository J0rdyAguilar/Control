<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOficinasU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOficinasU))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnActualizarO = New System.Windows.Forms.Button()
        Me.txtActualizarO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(271, 296)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 14
        '
        'btnActualizarO
        '
        Me.btnActualizarO.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarO.Image = CType(resources.GetObject("btnActualizarO.Image"), System.Drawing.Image)
        Me.btnActualizarO.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnActualizarO.Location = New System.Drawing.Point(738, 465)
        Me.btnActualizarO.Name = "btnActualizarO"
        Me.btnActualizarO.Size = New System.Drawing.Size(131, 93)
        Me.btnActualizarO.TabIndex = 13
        Me.btnActualizarO.Text = "Actualizar"
        Me.btnActualizarO.UseVisualStyleBackColor = True
        '
        'txtActualizarO
        '
        Me.txtActualizarO.Location = New System.Drawing.Point(320, 216)
        Me.txtActualizarO.Name = "txtActualizarO"
        Me.txtActualizarO.Size = New System.Drawing.Size(285, 22)
        Me.txtActualizarO.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 37)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Actualizar Oficina"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 157)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "OFICINAS"
        '
        'frmOficinasU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 586)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnActualizarO)
        Me.Controls.Add(Me.txtActualizarO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOficinasU"
        Me.Text = "frmOficinasU"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnActualizarO As Button
    Friend WithEvents txtActualizarO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
