<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiciosC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiciosC))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSoliSerA = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtEstServA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAgregarS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDPICAS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDPITAS = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(181, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Solicitud"
        '
        'txtSoliSerA
        '
        Me.txtSoliSerA.Location = New System.Drawing.Point(245, 237)
        Me.txtSoliSerA.Name = "txtSoliSerA"
        Me.txtSoliSerA.Size = New System.Drawing.Size(285, 22)
        Me.txtSoliSerA.TabIndex = 31
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(181, 314)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(51, 16)
        Me.label4.TabIndex = 30
        Me.label4.Text = "Estatus"
        '
        'txtEstServA
        '
        Me.txtEstServA.Location = New System.Drawing.Point(245, 314)
        Me.txtEstServA.Name = "txtEstServA"
        Me.txtEstServA.Size = New System.Drawing.Size(285, 22)
        Me.txtEstServA.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Fecha Ingreso"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(148, 484)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 27
        '
        'btnAgregarS
        '
        Me.btnAgregarS.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarS.Image = CType(resources.GetObject("btnAgregarS.Image"), System.Drawing.Image)
        Me.btnAgregarS.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregarS.Location = New System.Drawing.Point(689, 543)
        Me.btnAgregarS.Name = "btnAgregarS"
        Me.btnAgregarS.Size = New System.Drawing.Size(131, 93)
        Me.btnAgregarS.TabIndex = 26
        Me.btnAgregarS.Text = "Agregar"
        Me.btnAgregarS.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 37)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Agregar Servicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(674, 157)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "SERVICIOS"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(280, 279)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaIngreso.TabIndex = 33
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(280, 355)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaFin.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Fecha Finalizacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 399)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "DPI Cliente"
        '
        'txtDPICAS
        '
        Me.txtDPICAS.Location = New System.Drawing.Point(245, 396)
        Me.txtDPICAS.Name = "txtDPICAS"
        Me.txtDPICAS.Size = New System.Drawing.Size(285, 22)
        Me.txtDPICAS.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(158, 445)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "DPI Tecnico"
        '
        'txtDPITAS
        '
        Me.txtDPITAS.Location = New System.Drawing.Point(245, 442)
        Me.txtDPITAS.Name = "txtDPITAS"
        Me.txtDPITAS.Size = New System.Drawing.Size(285, 22)
        Me.txtDPITAS.TabIndex = 38
        '
        'frmServiciosC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 663)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDPITAS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDPICAS)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFechaIngreso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSoliSerA)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtEstServA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregarS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmServiciosC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmServiciosC"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtSoliSerA As TextBox
    Friend WithEvents label4 As Label
    Friend WithEvents txtEstServA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregarS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDPICAS As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDPITAS As TextBox
End Class
