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
        Me.EdificiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNumEdi = New System.Windows.Forms.TextBox()
        Me.DgvActualizarE = New CapaPresentacion.dgvActualizarE()
        Me.EdificiosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EdificiosTableAdapter = New CapaPresentacion.dgvActualizarETableAdapters.EdificiosTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvActualizarE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView1.DataSource = Me.EdificiosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(235, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(456, 167)
        Me.DataGridView1.TabIndex = 12
        '
        'EdificiosBindingSource
        '
        Me.EdificiosBindingSource.DataMember = "Edificios"
        '
        'txtNumEdi
        '
        Me.txtNumEdi.Location = New System.Drawing.Point(128, 232)
        Me.txtNumEdi.Name = "txtNumEdi"
        Me.txtNumEdi.Size = New System.Drawing.Size(114, 22)
        Me.txtNumEdi.TabIndex = 13
        '
        'DgvActualizarE
        '
        Me.DgvActualizarE.DataSetName = "dgvActualizarE"
        Me.DgvActualizarE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EdificiosBindingSource1
        '
        Me.EdificiosBindingSource1.DataMember = "Edificios"
        Me.EdificiosBindingSource1.DataSource = Me.DgvActualizarE
        '
        'EdificiosTableAdapter
        '
        Me.EdificiosTableAdapter.ClearBeforeFill = True
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nomEdificio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nomEdificio"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'frmEdificiosU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 634)
        Me.Controls.Add(Me.txtNumEdi)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnActualizarE)
        Me.Controls.Add(Me.txtActualizarE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEdificiosU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEdificiosU"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvActualizarE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActualizarE As Button
    Friend WithEvents txtActualizarE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EdificiosBindingSource As BindingSource
    Friend WithEvents NumEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtNumEdi As TextBox
    Friend WithEvents DgvActualizarE As dgvActualizarE
    Friend WithEvents EdificiosBindingSource1 As BindingSource
    Friend WithEvents EdificiosTableAdapter As dgvActualizarETableAdapters.EdificiosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
