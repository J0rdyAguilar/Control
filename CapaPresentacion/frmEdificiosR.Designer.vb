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
        Me.EdificiosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DgvVerE = New CapaPresentacion.dgvVerE()
        Me.EdificiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EdificiosTableAdapter = New CapaPresentacion.dgvVerETableAdapters.EdificiosTableAdapter()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.EdificiosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVerE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EdificiosBindingSource1
        '
        Me.EdificiosBindingSource1.DataMember = "Edificios"
        Me.EdificiosBindingSource1.DataSource = Me.DgvVerE
        '
        'DgvVerE
        '
        Me.DgvVerE.DataSetName = "dgvVerE"
        Me.DgvVerE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EdificiosBindingSource
        '
        Me.EdificiosBindingSource.DataMember = "Edificios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(504, 125)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "EDIFICIOS"
        '
        'EdificiosTableAdapter
        '
        Me.EdificiosTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nomEdificio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nomEdificio"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "numEdificio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "numEdificio"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView1.DataSource = Me.EdificiosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(205, 280)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(320, 141)
        Me.DataGridView1.TabIndex = 17
        '
        'frmEdificiosR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 499)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEdificiosR"
        Me.Text = "frmEdificiosR"
        CType(Me.EdificiosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVerE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label

    Friend WithEvents EdificiosBindingSource As BindingSource

    Friend WithEvents NumEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DgvVerE As dgvVerE
    Friend WithEvents EdificiosBindingSource1 As BindingSource
    Friend WithEvents EdificiosTableAdapter As dgvVerETableAdapters.EdificiosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
End Class
