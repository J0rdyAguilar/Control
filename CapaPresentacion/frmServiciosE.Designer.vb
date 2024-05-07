<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiciosE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiciosE))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodSerE = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEliminarS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Codigo"
        '
        'txtCodSerE
        '
        Me.txtCodSerE.Location = New System.Drawing.Point(253, 239)
        Me.txtCodSerE.Name = "txtCodSerE"
        Me.txtCodSerE.Size = New System.Drawing.Size(285, 22)
        Me.txtCodSerE.TabIndex = 43
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(174, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 39
        '
        'btnEliminarS
        '
        Me.btnEliminarS.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarS.Image = CType(resources.GetObject("btnEliminarS.Image"), System.Drawing.Image)
        Me.btnEliminarS.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnEliminarS.Location = New System.Drawing.Point(666, 486)
        Me.btnEliminarS.Name = "btnEliminarS"
        Me.btnEliminarS.Size = New System.Drawing.Size(131, 93)
        Me.btnEliminarS.TabIndex = 38
        Me.btnEliminarS.Text = "Eliminar"
        Me.btnEliminarS.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(269, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 37)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Eliminar Servicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(674, 157)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "SERVICIOS"
        '
        'frmServiciosE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 607)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodSerE)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEliminarS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmServiciosE"
        Me.Text = "frmServiciosE"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodSerE As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEliminarS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
