<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTecnicosD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTecnicosD))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDPIET = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEliminarT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "DPI"
        '
        'txtDPIET
        '
        Me.txtDPIET.Location = New System.Drawing.Point(275, 222)
        Me.txtDPIET.Name = "txtDPIET"
        Me.txtDPIET.Size = New System.Drawing.Size(285, 22)
        Me.txtDPIET.TabIndex = 31
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(179, 282)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 27
        '
        'btnEliminarT
        '
        Me.btnEliminarT.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarT.Image = CType(resources.GetObject("btnEliminarT.Image"), System.Drawing.Image)
        Me.btnEliminarT.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnEliminarT.Location = New System.Drawing.Point(695, 461)
        Me.btnEliminarT.Name = "btnEliminarT"
        Me.btnEliminarT.Size = New System.Drawing.Size(131, 93)
        Me.btnEliminarT.TabIndex = 26
        Me.btnEliminarT.Text = "Eliminar"
        Me.btnEliminarT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(298, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 37)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Eliminar Tecnico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(646, 157)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "TECNICOS"
        '
        'frmTecnicosD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 558)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDPIET)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEliminarT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTecnicosD"
        Me.Text = "frmTecnicosD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtDPIET As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEliminarT As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
