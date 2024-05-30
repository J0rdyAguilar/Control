<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiciosU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiciosU))
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtEstServAc = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodigoServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoSolicitanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiciosSolicitadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DgvActualizarSS = New CapaPresentacion.dgvActualizarSS()
        Me.btnActualizarS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodSerAct = New System.Windows.Forms.TextBox()
        Me.ServiciosSolicitadosTableAdapter = New CapaPresentacion.dgvActualizarSSTableAdapters.ServiciosSolicitadosTableAdapter()
        Me.dtpFechaSolucion = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSolucion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtidCliente = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosSolicitadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvActualizarSS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(311, 301)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(51, 16)
        Me.label4.TabIndex = 42
        Me.label4.Text = "Estatus"
        '
        'txtEstServAc
        '
        Me.txtEstServAc.Location = New System.Drawing.Point(375, 298)
        Me.txtEstServAc.Name = "txtEstServAc"
        Me.txtEstServAc.Size = New System.Drawing.Size(285, 22)
        Me.txtEstServAc.TabIndex = 41
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoServicioDataGridViewTextBoxColumn, Me.FechaSolicitudDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CodigoSolicitanteDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ServiciosSolicitadosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(74, 336)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(881, 152)
        Me.DataGridView1.TabIndex = 39
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
        Me.ServiciosSolicitadosBindingSource.DataSource = Me.DgvActualizarSS
        '
        'DgvActualizarSS
        '
        Me.DgvActualizarSS.DataSetName = "dgvActualizarSS"
        Me.DgvActualizarSS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnActualizarS
        '
        Me.btnActualizarS.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarS.Image = CType(resources.GetObject("btnActualizarS.Image"), System.Drawing.Image)
        Me.btnActualizarS.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnActualizarS.Location = New System.Drawing.Point(880, 494)
        Me.btnActualizarS.Name = "btnActualizarS"
        Me.btnActualizarS.Size = New System.Drawing.Size(131, 93)
        Me.btnActualizarS.TabIndex = 38
        Me.btnActualizarS.Text = "Actualizar"
        Me.btnActualizarS.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(377, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 37)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Actualizar Servicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 105)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "SERVICIOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Codigo"
        '
        'txtCodSerAct
        '
        Me.txtCodSerAct.Location = New System.Drawing.Point(375, 144)
        Me.txtCodSerAct.Name = "txtCodSerAct"
        Me.txtCodSerAct.Size = New System.Drawing.Size(285, 22)
        Me.txtCodSerAct.TabIndex = 45
        '
        'ServiciosSolicitadosTableAdapter
        '
        Me.ServiciosSolicitadosTableAdapter.ClearBeforeFill = True
        '
        'dtpFechaSolucion
        '
        Me.dtpFechaSolucion.Location = New System.Drawing.Point(415, 183)
        Me.dtpFechaSolucion.Name = "dtpFechaSolucion"
        Me.dtpFechaSolucion.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaSolucion.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Fecha Solucion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(303, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Solucion"
        '
        'txtSolucion
        '
        Me.txtSolucion.Location = New System.Drawing.Point(375, 220)
        Me.txtSolucion.Name = "txtSolucion"
        Me.txtSolucion.Size = New System.Drawing.Size(285, 22)
        Me.txtSolucion.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 16)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Número de Cliente"
        '
        'txtidCliente
        '
        Me.txtidCliente.Location = New System.Drawing.Point(375, 261)
        Me.txtidCliente.Name = "txtidCliente"
        Me.txtidCliente.Size = New System.Drawing.Size(285, 22)
        Me.txtidCliente.TabIndex = 51
        '
        'frmServiciosU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 599)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtidCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSolucion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaSolucion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodSerAct)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtEstServAc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnActualizarS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmServiciosU"
        Me.Text = "frmServiciosU"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosSolicitadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvActualizarSS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label4 As Label
    Friend WithEvents txtEstServAc As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnActualizarS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodSerAct As TextBox
    Friend WithEvents DgvActualizarSS As dgvActualizarSS
    Friend WithEvents ServiciosSolicitadosBindingSource As BindingSource
    Friend WithEvents ServiciosSolicitadosTableAdapter As dgvActualizarSSTableAdapters.ServiciosSolicitadosTableAdapter
    Friend WithEvents CodigoServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoSolicitanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dtpFechaSolucion As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSolucion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtidCliente As TextBox
End Class
