<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdificiosD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdificiosD))
        Me.btnEliminarE = New System.Windows.Forms.Button()
        Me.txtEliminarE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EdificiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DgvEliminarE = New CapaPresentacion.dgvEliminarE()
        Me.EdificiosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EdificiosTableAdapter = New CapaPresentacion.dgvEliminarETableAdapters.EdificiosTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEliminarE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarE
        '
        Me.btnEliminarE.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarE.Image = CType(resources.GetObject("btnEliminarE.Image"), System.Drawing.Image)
        Me.btnEliminarE.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnEliminarE.Location = New System.Drawing.Point(719, 498)
        Me.btnEliminarE.Name = "btnEliminarE"
        Me.btnEliminarE.Size = New System.Drawing.Size(131, 93)
        Me.btnEliminarE.TabIndex = 7
        Me.btnEliminarE.Text = "Eliminar"
        Me.btnEliminarE.UseVisualStyleBackColor = True
        '
        'txtEliminarE
        '
        Me.txtEliminarE.Location = New System.Drawing.Point(277, 233)
        Me.txtEliminarE.Name = "txtEliminarE"
        Me.txtEliminarE.Size = New System.Drawing.Size(285, 22)
        Me.txtEliminarE.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 37)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Eliminar Edificio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 157)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "EDIFICIOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView1.DataSource = Me.EdificiosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(213, 286)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(456, 156)
        Me.DataGridView1.TabIndex = 8
        '
        'EdificiosBindingSource
        '
        Me.EdificiosBindingSource.DataMember = "Edificios"
        '
        'DgvEliminarE
        '
        Me.DgvEliminarE.DataSetName = "dgvEliminarE"
        Me.DgvEliminarE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EdificiosBindingSource1
        '
        Me.EdificiosBindingSource1.DataMember = "Edificios"
        Me.EdificiosBindingSource1.DataSource = Me.DgvEliminarE
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
        'frmEdificiosD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 615)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEliminarE)
        Me.Controls.Add(Me.txtEliminarE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEdificiosD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Edificios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEliminarE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminarE As Button
    Friend WithEvents txtEliminarE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EdificiosBindingSource As BindingSource
    Friend WithEvents NumEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DgvEliminarE As dgvEliminarE
    Friend WithEvents EdificiosBindingSource1 As BindingSource
    Friend WithEvents EdificiosTableAdapter As dgvEliminarETableAdapters.EdificiosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
