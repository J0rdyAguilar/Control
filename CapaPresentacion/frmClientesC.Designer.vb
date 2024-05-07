<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientesC))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAgregarC = New System.Windows.Forms.Button()
        Me.txtNomAC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtApeAC = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(206, 313)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 9
        '
        'btnAgregarC
        '
        Me.btnAgregarC.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarC.Image = CType(resources.GetObject("btnAgregarC.Image"), System.Drawing.Image)
        Me.btnAgregarC.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregarC.Location = New System.Drawing.Point(714, 477)
        Me.btnAgregarC.Name = "btnAgregarC"
        Me.btnAgregarC.Size = New System.Drawing.Size(131, 93)
        Me.btnAgregarC.TabIndex = 8
        Me.btnAgregarC.Text = "Agregar"
        Me.btnAgregarC.UseVisualStyleBackColor = True
        '
        'txtNomAC
        '
        Me.txtNomAC.Location = New System.Drawing.Point(296, 228)
        Me.txtNomAC.Name = "txtNomAC"
        Me.txtNomAC.Size = New System.Drawing.Size(285, 22)
        Me.txtNomAC.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Agregar Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(634, 157)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CLIENTES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Nombre"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(232, 266)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(57, 16)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Apellido"
        '
        'txtApeAC
        '
        Me.txtApeAC.Location = New System.Drawing.Point(296, 266)
        Me.txtApeAC.Name = "txtApeAC"
        Me.txtApeAC.Size = New System.Drawing.Size(285, 22)
        Me.txtApeAC.TabIndex = 11
        '
        'frmClientesC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 594)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtApeAC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregarC)
        Me.Controls.Add(Me.txtNomAC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClientesC"
        Me.Text = "frmClientesC"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregarC As Button
    Friend WithEvents txtNomAC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents txtApeAC As TextBox
End Class
