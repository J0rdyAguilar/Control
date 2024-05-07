<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTecnicosU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTecnicosU))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDPIUT = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtApeUT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnActualizarT = New System.Windows.Forms.Button()
        Me.txtNomUT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(217, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "DPI"
        '
        'txtDPIUT
        '
        Me.txtDPIUT.Location = New System.Drawing.Point(281, 228)
        Me.txtDPIUT.Name = "txtDPIUT"
        Me.txtDPIUT.Size = New System.Drawing.Size(285, 22)
        Me.txtDPIUT.TabIndex = 31
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(217, 308)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(57, 16)
        Me.label4.TabIndex = 30
        Me.label4.Text = "Apellido"
        '
        'txtApeUT
        '
        Me.txtApeUT.Location = New System.Drawing.Point(281, 308)
        Me.txtApeUT.Name = "txtApeUT"
        Me.txtApeUT.Size = New System.Drawing.Size(285, 22)
        Me.txtApeUT.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(191, 355)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 27
        '
        'btnActualizarT
        '
        Me.btnActualizarT.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarT.Image = CType(resources.GetObject("btnActualizarT.Image"), System.Drawing.Image)
        Me.btnActualizarT.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnActualizarT.Location = New System.Drawing.Point(701, 467)
        Me.btnActualizarT.Name = "btnActualizarT"
        Me.btnActualizarT.Size = New System.Drawing.Size(131, 93)
        Me.btnActualizarT.TabIndex = 26
        Me.btnActualizarT.Text = "Actualizar"
        Me.btnActualizarT.UseVisualStyleBackColor = True
        '
        'txtNomUT
        '
        Me.txtNomUT.Location = New System.Drawing.Point(281, 270)
        Me.txtNomUT.Name = "txtNomUT"
        Me.txtNomUT.Size = New System.Drawing.Size(285, 22)
        Me.txtNomUT.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 37)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Actualizar Tecnico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(646, 157)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "TECNICOS"
        '
        'frmTecnicosU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 596)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDPIUT)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtApeUT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnActualizarT)
        Me.Controls.Add(Me.txtNomUT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTecnicosU"
        Me.Text = "frmTecnicosU"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtDPIUT As TextBox
    Friend WithEvents label4 As Label
    Friend WithEvents txtApeUT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnActualizarT As Button
    Friend WithEvents txtNomUT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
