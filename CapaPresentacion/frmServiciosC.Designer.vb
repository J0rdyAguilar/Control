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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiciosC))
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoSolicitanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosSolicitadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DgvInsertarSS = New CapaPresentacion.dgvInsertarSS()
        Me.btnAgregarS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDPICAS = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.ServiciosSolicitadosTableAdapter = New CapaPresentacion.dgvInsertarSSTableAdapters.ServiciosSolicitadosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosSolicitadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvInsertarSS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(285, 332)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(79, 16)
        Me.label4.TabIndex = 30
        Me.label4.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 433)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Fecha Ingreso"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoServicioDataGridViewTextBoxColumn, Me.FechaSolicitudDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CodigoSolicitanteDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ServiciosSolicitadosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(81, 472)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(890, 187)
        Me.DataGridView1.TabIndex = 27
        '
        'CodigoServicioDataGridViewTextBoxColumn
        '
        Me.CodigoServicioDataGridViewTextBoxColumn.DataPropertyName = "CodigoServicio"
        Me.CodigoServicioDataGridViewTextBoxColumn.HeaderText = "CodigoServicio"
        Me.CodigoServicioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodigoServicioDataGridViewTextBoxColumn.Name = "CodigoServicioDataGridViewTextBoxColumn"
        Me.CodigoServicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoServicioDataGridViewTextBoxColumn.Width = 125
        '
        'FechaSolicitudDataGridViewTextBoxColumn
        '
        Me.FechaSolicitudDataGridViewTextBoxColumn.DataPropertyName = "fechaSolicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.HeaderText = "fechaSolicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaSolicitudDataGridViewTextBoxColumn.Name = "FechaSolicitudDataGridViewTextBoxColumn"
        Me.FechaSolicitudDataGridViewTextBoxColumn.Width = 125
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.Width = 125
        '
        'CodigoSolicitanteDataGridViewTextBoxColumn
        '
        Me.CodigoSolicitanteDataGridViewTextBoxColumn.DataPropertyName = "CodigoSolicitante"
        Me.CodigoSolicitanteDataGridViewTextBoxColumn.HeaderText = "CodigoSolicitante"
        Me.CodigoSolicitanteDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodigoSolicitanteDataGridViewTextBoxColumn.Name = "CodigoSolicitanteDataGridViewTextBoxColumn"
        Me.CodigoSolicitanteDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.Width = 125
        '
        'ServiciosSolicitadosBindingSource
        '
        Me.ServiciosSolicitadosBindingSource.DataMember = "ServiciosSolicitados"
        Me.ServiciosSolicitadosBindingSource.DataSource = Me.DgvInsertarSS
        '
        'DgvInsertarSS
        '
        Me.DgvInsertarSS.DataSetName = "dgvInsertarSS"
        Me.DgvInsertarSS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAgregarS
        '
        Me.btnAgregarS.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarS.Image = CType(resources.GetObject("btnAgregarS.Image"), System.Drawing.Image)
        Me.btnAgregarS.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregarS.Location = New System.Drawing.Point(987, 642)
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
        Me.Label2.Location = New System.Drawing.Point(386, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 37)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Agregar Servicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(674, 157)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "SERVICIOS"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(402, 433)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(285, 22)
        Me.dtpFechaIngreso.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(291, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "ID Cliente"
        '
        'txtDPICAS
        '
        Me.txtDPICAS.Location = New System.Drawing.Point(402, 248)
        Me.txtDPICAS.Name = "txtDPICAS"
        Me.txtDPICAS.Size = New System.Drawing.Size(285, 22)
        Me.txtDPICAS.TabIndex = 36
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(402, 304)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(285, 96)
        Me.txtDescripcion.TabIndex = 40
        Me.txtDescripcion.Text = ""
        '
        'ServiciosSolicitadosTableAdapter
        '
        Me.ServiciosSolicitadosTableAdapter.ClearBeforeFill = True
        '
        'frmServiciosC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 747)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDPICAS)
        Me.Controls.Add(Me.dtpFechaIngreso)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregarS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmServiciosC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmServiciosC"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosSolicitadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvInsertarSS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregarS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDPICAS As TextBox
    Friend WithEvents txtDescripcion As RichTextBox
    Friend WithEvents DgvInsertarSS As dgvInsertarSS
    Friend WithEvents ServiciosSolicitadosBindingSource As BindingSource
    Friend WithEvents ServiciosSolicitadosTableAdapter As dgvInsertarSSTableAdapters.ServiciosSolicitadosTableAdapter
    Friend WithEvents CodigoServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoSolicitanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
