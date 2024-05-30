<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOficinasR
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
        Me.DgvVerO = New CapaPresentacion.dgvVerO()
        Me.OficinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OficinaTableAdapter = New CapaPresentacion.dgvVerOTableAdapters.OficinaTableAdapter()
        Me.NumeroOficinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomOficinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroEdiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVerO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroOficinaDataGridViewTextBoxColumn, Me.NomOficinaDataGridViewTextBoxColumn, Me.NumeroEdiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OficinaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(286, 246)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(443, 173)
        Me.DataGridView1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 37)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ver Oficinas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 157)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "OFICINAS"
        '
        'DgvVerO
        '
        Me.DgvVerO.DataSetName = "dgvVerO"
        Me.DgvVerO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OficinaBindingSource
        '
        Me.OficinaBindingSource.DataMember = "Oficina"
        Me.OficinaBindingSource.DataSource = Me.DgvVerO
        '
        'OficinaTableAdapter
        '
        Me.OficinaTableAdapter.ClearBeforeFill = True
        '
        'NumeroOficinaDataGridViewTextBoxColumn
        '
        Me.NumeroOficinaDataGridViewTextBoxColumn.DataPropertyName = "numeroOficina"
        Me.NumeroOficinaDataGridViewTextBoxColumn.HeaderText = "numeroOficina"
        Me.NumeroOficinaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroOficinaDataGridViewTextBoxColumn.Name = "NumeroOficinaDataGridViewTextBoxColumn"
        Me.NumeroOficinaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroOficinaDataGridViewTextBoxColumn.Width = 125
        '
        'NomOficinaDataGridViewTextBoxColumn
        '
        Me.NomOficinaDataGridViewTextBoxColumn.DataPropertyName = "nomOficina"
        Me.NomOficinaDataGridViewTextBoxColumn.HeaderText = "nomOficina"
        Me.NomOficinaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NomOficinaDataGridViewTextBoxColumn.Name = "NomOficinaDataGridViewTextBoxColumn"
        Me.NomOficinaDataGridViewTextBoxColumn.Width = 125
        '
        'NumeroEdiDataGridViewTextBoxColumn
        '
        Me.NumeroEdiDataGridViewTextBoxColumn.DataPropertyName = "numeroEdi"
        Me.NumeroEdiDataGridViewTextBoxColumn.HeaderText = "numeroEdi"
        Me.NumeroEdiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumeroEdiDataGridViewTextBoxColumn.Name = "NumeroEdiDataGridViewTextBoxColumn"
        Me.NumeroEdiDataGridViewTextBoxColumn.Width = 125
        '
        'frmOficinasR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 599)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOficinasR"
        Me.Text = "frmOficinasR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVerO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvVerO As dgvVerO
    Friend WithEvents OficinaBindingSource As BindingSource
    Friend WithEvents OficinaTableAdapter As dgvVerOTableAdapters.OficinaTableAdapter
    Friend WithEvents NumeroOficinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomOficinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroEdiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
