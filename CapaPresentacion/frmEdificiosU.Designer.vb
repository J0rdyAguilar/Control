<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdificiosU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdificiosU))
        Me.btnActualizarE = New System.Windows.Forms.Button()
        Me.txtActualizarE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ControlServiciosDataSet = New CapaPresentacion.ControlServiciosDataSet()
        Me.EdificiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EdificiosTableAdapter = New CapaPresentacion.ControlServiciosDataSetTableAdapters.EdificiosTableAdapter()
        Me.NumEdificioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEdificioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlServiciosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnActualizarE
        '
        Me.btnActualizarE.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarE.Image = CType(resources.GetObject("btnActualizarE.Image"), System.Drawing.Image)
        Me.btnActualizarE.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnActualizarE.Location = New System.Drawing.Point(767, 518)
        Me.btnActualizarE.Name = "btnActualizarE"
        Me.btnActualizarE.Size = New System.Drawing.Size(131, 93)
        Me.btnActualizarE.TabIndex = 11
        Me.btnActualizarE.Text = "Actualizar"
        Me.btnActualizarE.UseVisualStyleBackColor = True
        '
        'txtActualizarE
        '
        Me.txtActualizarE.Location = New System.Drawing.Point(327, 232)
        Me.txtActualizarE.Name = "txtActualizarE"
        Me.txtActualizarE.Size = New System.Drawing.Size(285, 22)
        Me.txtActualizarE.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 37)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Actualizar Edificio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 157)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "EDIFICIOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumEdificioDataGridViewTextBoxColumn, Me.NomEdificioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EdificiosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(306, 333)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(385, 121)
        Me.DataGridView1.TabIndex = 12
        '
        'ControlServiciosDataSet
        '
        Me.ControlServiciosDataSet.DataSetName = "ControlServiciosDataSet"
        Me.ControlServiciosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EdificiosBindingSource
        '
        Me.EdificiosBindingSource.DataMember = "Edificios"
        Me.EdificiosBindingSource.DataSource = Me.ControlServiciosDataSet
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
        'frmEdificiosU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 634)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnActualizarE)
        Me.Controls.Add(Me.txtActualizarE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEdificiosU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEdificiosU"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlServiciosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActualizarE As Button
    Friend WithEvents txtActualizarE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ControlServiciosDataSet As ControlServiciosDataSet
    Friend WithEvents EdificiosBindingSource As BindingSource
    Friend WithEvents EdificiosTableAdapter As ControlServiciosDataSetTableAdapters.EdificiosTableAdapter
    Friend WithEvents NumEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
