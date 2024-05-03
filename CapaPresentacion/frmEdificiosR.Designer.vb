<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdificiosR
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControlServiciosDataSet3 = New CapaPresentacion.ControlServiciosDataSet3()
        Me.EdificiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EdificiosTableAdapter = New CapaPresentacion.ControlServiciosDataSet3TableAdapters.EdificiosTableAdapter()
        Me.NumEdificioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEdificioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlServiciosDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumEdificioDataGridViewTextBoxColumn, Me.NomEdificioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EdificiosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(273, 345)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(426, 174)
        Me.DataGridView1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 157)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "EDIFICIOS"
        '
        'ControlServiciosDataSet3
        '
        Me.ControlServiciosDataSet3.DataSetName = "ControlServiciosDataSet3"
        Me.ControlServiciosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EdificiosBindingSource
        '
        Me.EdificiosBindingSource.DataMember = "Edificios"
        Me.EdificiosBindingSource.DataSource = Me.ControlServiciosDataSet3
        '
        'EdificiosTableAdapter
        '
        Me.EdificiosTableAdapter.ClearBeforeFill = True
        '
        'NumEdificioDataGridViewTextBoxColumn
        '
        Me.NumEdificioDataGridViewTextBoxColumn.DataPropertyName = "numEdificio"
        Me.NumEdificioDataGridViewTextBoxColumn.HeaderText = "numEdificio"
        Me.NumEdificioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumEdificioDataGridViewTextBoxColumn.Name = "NumEdificioDataGridViewTextBoxColumn"
        Me.NumEdificioDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumEdificioDataGridViewTextBoxColumn.Width = 125
        '
        'NomEdificioDataGridViewTextBoxColumn
        '
        Me.NomEdificioDataGridViewTextBoxColumn.DataPropertyName = "nomEdificio"
        Me.NomEdificioDataGridViewTextBoxColumn.HeaderText = "nomEdificio"
        Me.NomEdificioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NomEdificioDataGridViewTextBoxColumn.Name = "NomEdificioDataGridViewTextBoxColumn"
        Me.NomEdificioDataGridViewTextBoxColumn.Width = 125
        '
        'frmEdificiosR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 614)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEdificiosR"
        Me.Text = "frmEdificiosR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlServiciosDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ControlServiciosDataSet3 As ControlServiciosDataSet3
    Friend WithEvents EdificiosBindingSource As BindingSource
    Friend WithEvents EdificiosTableAdapter As ControlServiciosDataSet3TableAdapters.EdificiosTableAdapter
    Friend WithEvents NumEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
