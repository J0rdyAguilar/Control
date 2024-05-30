<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOficinasD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOficinasD))
        Me.btnEliminarO = New System.Windows.Forms.Button()
        Me.txtEliminarO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvEliminarO = New CapaPresentacion.dgvEliminarO()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DgvEliminarO1 = New CapaPresentacion.dgvEliminarO()
        Me.OficinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OficinaTableAdapter = New CapaPresentacion.dgvEliminarOTableAdapters.OficinaTableAdapter()
        Me.NumeroOficinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomOficinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroEdiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvEliminarO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEliminarO1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarO
        '
        Me.btnEliminarO.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarO.Image = CType(resources.GetObject("btnEliminarO.Image"), System.Drawing.Image)
        Me.btnEliminarO.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnEliminarO.Location = New System.Drawing.Point(687, 459)
        Me.btnEliminarO.Name = "btnEliminarO"
        Me.btnEliminarO.Size = New System.Drawing.Size(131, 93)
        Me.btnEliminarO.TabIndex = 18
        Me.btnEliminarO.Text = "Eliminar"
        Me.btnEliminarO.UseVisualStyleBackColor = True
        '
        'txtEliminarO
        '
        Me.txtEliminarO.Location = New System.Drawing.Point(269, 210)
        Me.txtEliminarO.Name = "txtEliminarO"
        Me.txtEliminarO.Size = New System.Drawing.Size(285, 22)
        Me.txtEliminarO.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 37)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Eliminar Oficina"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 157)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "OFICINAS"
        '
        'DgvEliminarO
        '
        Me.DgvEliminarO.DataSetName = "dgvEliminarO"
        Me.DgvEliminarO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroOficinaDataGridViewTextBoxColumn, Me.NomOficinaDataGridViewTextBoxColumn, Me.NumeroEdiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OficinaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(190, 255)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(543, 184)
        Me.DataGridView1.TabIndex = 19
        '
        'DgvEliminarO1
        '
        Me.DgvEliminarO1.DataSetName = "dgvEliminarO"
        Me.DgvEliminarO1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OficinaBindingSource
        '
        Me.OficinaBindingSource.DataMember = "Oficina"
        Me.OficinaBindingSource.DataSource = Me.DgvEliminarO1
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
        'frmOficinasD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 587)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEliminarO)
        Me.Controls.Add(Me.txtEliminarO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOficinasD"
        Me.Text = "frmOficinasD"
        CType(Me.DgvEliminarO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEliminarO1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEliminarO As Button
    Friend WithEvents txtEliminarO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvEliminarO As dgvEliminarO
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DgvEliminarO1 As dgvEliminarO
    Friend WithEvents OficinaBindingSource As BindingSource
    Friend WithEvents OficinaTableAdapter As dgvEliminarOTableAdapters.OficinaTableAdapter
    Friend WithEvents NumeroOficinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomOficinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroEdiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
