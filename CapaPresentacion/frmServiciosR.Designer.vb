<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiciosR
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvVerSS = New CapaPresentacion.dgvVerSS()
        Me.ServiciosSolicitadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosSolicitadosTableAdapter = New CapaPresentacion.dgvVerSSTableAdapters.ServiciosSolicitadosTableAdapter()
        Me.CodigoServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoSolicitanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVerSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosSolicitadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoServicioDataGridViewTextBoxColumn, Me.FechaSolicitudDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.CodigoSolicitanteDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ServiciosSolicitadosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(52, 272)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(781, 239)
        Me.DataGridView1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(324, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 37)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Ver Servicios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(674, 157)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "SERVICIOS"
        '
        'DgvVerSS
        '
        Me.DgvVerSS.DataSetName = "dgvVerSS"
        Me.DgvVerSS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServiciosSolicitadosBindingSource
        '
        Me.ServiciosSolicitadosBindingSource.DataMember = "ServiciosSolicitados"
        Me.ServiciosSolicitadosBindingSource.DataSource = Me.DgvVerSS
        '
        'ServiciosSolicitadosTableAdapter
        '
        Me.ServiciosSolicitadosTableAdapter.ClearBeforeFill = True
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
        'frmServiciosR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 553)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmServiciosR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmServiciosR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVerSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosSolicitadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvVerSS As dgvVerSS
    Friend WithEvents ServiciosSolicitadosBindingSource As BindingSource
    Friend WithEvents ServiciosSolicitadosTableAdapter As dgvVerSSTableAdapters.ServiciosSolicitadosTableAdapter
    Friend WithEvents CodigoServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoSolicitanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
