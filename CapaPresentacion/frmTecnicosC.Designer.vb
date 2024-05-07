<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTecnicosC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTecnicosC))
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtApeAT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAgregarT = New System.Windows.Forms.Button()
        Me.txtNomAT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDPIAT = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(256, 309)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(57, 16)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Apellido"
        '
        'txtApeAT
        '
        Me.txtApeAT.Location = New System.Drawing.Point(320, 309)
        Me.txtApeAT.Name = "txtApeAT"
        Me.txtApeAT.Size = New System.Drawing.Size(285, 22)
        Me.txtApeAT.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(230, 356)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 17
        '
        'btnAgregarT
        '
        Me.btnAgregarT.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarT.Image = CType(resources.GetObject("btnAgregarT.Image"), System.Drawing.Image)
        Me.btnAgregarT.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregarT.Location = New System.Drawing.Point(740, 468)
        Me.btnAgregarT.Name = "btnAgregarT"
        Me.btnAgregarT.Size = New System.Drawing.Size(131, 93)
        Me.btnAgregarT.TabIndex = 16
        Me.btnAgregarT.Text = "Agregar"
        Me.btnAgregarT.UseVisualStyleBackColor = True
        '
        'txtNomAT
        '
        Me.txtNomAT.Location = New System.Drawing.Point(320, 271)
        Me.txtNomAT.Name = "txtNomAT"
        Me.txtNomAT.Size = New System.Drawing.Size(285, 22)
        Me.txtNomAT.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(343, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 37)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Agregar Tecnico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(646, 157)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "TECNICOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "DPI"
        '
        'txtDPIAT
        '
        Me.txtDPIAT.Location = New System.Drawing.Point(320, 229)
        Me.txtDPIAT.Name = "txtDPIAT"
        Me.txtDPIAT.Size = New System.Drawing.Size(285, 22)
        Me.txtDPIAT.TabIndex = 21
        '
        'frmTecnicosC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 573)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDPIAT)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtApeAT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregarT)
        Me.Controls.Add(Me.txtNomAT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTecnicosC"
        Me.Text = "frmTecnicosC"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label4 As Label
    Friend WithEvents txtApeAT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregarT As Button
    Friend WithEvents txtNomAT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDPIAT As TextBox
End Class
