<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOficinasC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOficinasC))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAgregarO = New System.Windows.Forms.Button()
        Me.txtAgregarO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEdiOfA = New System.Windows.Forms.TextBox()
        Me.DgvInsertarO = New CapaPresentacion.dgvInsertarO()
        Me.OficinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OficinaTableAdapter = New CapaPresentacion.dgvInsertarOTableAdapters.OficinaTableAdapter()
        Me.NumeroOficinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomOficinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroEdiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvInsertarO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OficinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroOficinaDataGridViewTextBoxColumn, Me.NomOficinaDataGridViewTextBoxColumn, Me.NumeroEdiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OficinaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(289, 328)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 9
        '
        'btnAgregarO
        '
        Me.btnAgregarO.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarO.Image = CType(resources.GetObject("btnAgregarO.Image"), System.Drawing.Image)
        Me.btnAgregarO.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregarO.Location = New System.Drawing.Point(762, 482)
        Me.btnAgregarO.Name = "btnAgregarO"
        Me.btnAgregarO.Size = New System.Drawing.Size(131, 93)
        Me.btnAgregarO.TabIndex = 8
        Me.btnAgregarO.Text = "Agregar"
        Me.btnAgregarO.UseVisualStyleBackColor = True
        '
        'txtAgregarO
        '
        Me.txtAgregarO.Location = New System.Drawing.Point(372, 253)
        Me.txtAgregarO.Name = "txtAgregarO"
        Me.txtAgregarO.Size = New System.Drawing.Size(285, 22)
        Me.txtAgregarO.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(365, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Agregar Oficina"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 157)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "OFICINAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Oficina"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Edificio"
        '
        'txtEdiOfA
        '
        Me.txtEdiOfA.Location = New System.Drawing.Point(372, 281)
        Me.txtEdiOfA.Name = "txtEdiOfA"
        Me.txtEdiOfA.Size = New System.Drawing.Size(285, 22)
        Me.txtEdiOfA.TabIndex = 13
        '
        'DgvInsertarO
        '
        Me.DgvInsertarO.DataSetName = "dgvInsertarO"
        Me.DgvInsertarO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OficinaBindingSource
        '
        Me.OficinaBindingSource.DataMember = "Oficina"
        Me.OficinaBindingSource.DataSource = Me.DgvInsertarO
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
        'frmOficinasC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 599)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEdiOfA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregarO)
        Me.Controls.Add(Me.txtAgregarO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOficinasC"
        Me.Text = "frmOficinasC"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvInsertarO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OficinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAgregarO As Button
    Friend WithEvents txtAgregarO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEdiOfA As TextBox
    Friend WithEvents DgvInsertarO As dgvInsertarO
    Friend WithEvents OficinaBindingSource As BindingSource
    Friend WithEvents OficinaTableAdapter As dgvInsertarOTableAdapters.OficinaTableAdapter
    Friend WithEvents NumeroOficinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomOficinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroEdiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
