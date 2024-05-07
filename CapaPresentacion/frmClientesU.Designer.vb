<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientesU))
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtApeCliAct = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnActualizarC = New System.Windows.Forms.Button()
        Me.txtNomCliAct = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDPICAc = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(207, 293)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(57, 16)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Apellido"
        '
        'txtApeCliAct
        '
        Me.txtApeCliAct.Location = New System.Drawing.Point(271, 293)
        Me.txtApeCliAct.Name = "txtApeCliAct"
        Me.txtApeCliAct.Size = New System.Drawing.Size(285, 22)
        Me.txtApeCliAct.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(181, 339)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 17
        '
        'btnActualizarC
        '
        Me.btnActualizarC.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarC.Image = CType(resources.GetObject("btnActualizarC.Image"), System.Drawing.Image)
        Me.btnActualizarC.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnActualizarC.Location = New System.Drawing.Point(684, 463)
        Me.btnActualizarC.Name = "btnActualizarC"
        Me.btnActualizarC.Size = New System.Drawing.Size(131, 93)
        Me.btnActualizarC.TabIndex = 16
        Me.btnActualizarC.Text = "Actualizar"
        Me.btnActualizarC.UseVisualStyleBackColor = True
        '
        'txtNomCliAct
        '
        Me.txtNomCliAct.Location = New System.Drawing.Point(271, 255)
        Me.txtNomCliAct.Name = "txtNomCliAct"
        Me.txtNomCliAct.Size = New System.Drawing.Size(285, 22)
        Me.txtNomCliAct.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(287, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 37)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Actualizar Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(634, 157)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CLIENTES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "DPI"
        '
        'txtDPICAc
        '
        Me.txtDPICAc.Location = New System.Drawing.Point(271, 216)
        Me.txtDPICAc.Name = "txtDPICAc"
        Me.txtDPICAc.Size = New System.Drawing.Size(285, 22)
        Me.txtDPICAc.TabIndex = 21
        '
        'frmClientesU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 583)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDPICAc)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtApeCliAct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnActualizarC)
        Me.Controls.Add(Me.txtNomCliAct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClientesU"
        Me.Text = "frmClientesU"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label4 As Label
    Friend WithEvents txtApeCliAct As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnActualizarC As Button
    Friend WithEvents txtNomCliAct As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDPICAc As TextBox
End Class
