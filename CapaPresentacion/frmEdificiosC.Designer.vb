﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdificiosC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdificiosC))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAgregarE = New System.Windows.Forms.TextBox()
        Me.btnAgregarE = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ControlServiciosDataSet2 = New CapaPresentacion.ControlServiciosDataSet2()
        Me.EdificiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EdificiosTableAdapter = New CapaPresentacion.ControlServiciosDataSet2TableAdapters.EdificiosTableAdapter()
        Me.NumEdificioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomEdificioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlServiciosDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 157)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EDIFICIOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(321, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Agregar Edificio"
        '
        'txtAgregarE
        '
        Me.txtAgregarE.Location = New System.Drawing.Point(300, 230)
        Me.txtAgregarE.Name = "txtAgregarE"
        Me.txtAgregarE.Size = New System.Drawing.Size(285, 22)
        Me.txtAgregarE.TabIndex = 2
        '
        'btnAgregarE
        '
        Me.btnAgregarE.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarE.Image = CType(resources.GetObject("btnAgregarE.Image"), System.Drawing.Image)
        Me.btnAgregarE.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnAgregarE.Location = New System.Drawing.Point(718, 479)
        Me.btnAgregarE.Name = "btnAgregarE"
        Me.btnAgregarE.Size = New System.Drawing.Size(131, 93)
        Me.btnAgregarE.TabIndex = 3
        Me.btnAgregarE.Text = "Agregar"
        Me.btnAgregarE.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumEdificioDataGridViewTextBoxColumn, Me.NomEdificioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EdificiosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(251, 310)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 4
        '
        'ControlServiciosDataSet2
        '
        Me.ControlServiciosDataSet2.DataSetName = "ControlServiciosDataSet2"
        Me.ControlServiciosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EdificiosBindingSource
        '
        Me.EdificiosBindingSource.DataMember = "Edificios"
        Me.EdificiosBindingSource.DataSource = Me.ControlServiciosDataSet2
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
        'frmEdificiosC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 596)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAgregarE)
        Me.Controls.Add(Me.txtAgregarE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEdificiosC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Edificios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlServiciosDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EdificiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAgregarE As TextBox
    Friend WithEvents btnAgregarE As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ControlServiciosDataSet2 As ControlServiciosDataSet2
    Friend WithEvents EdificiosBindingSource As BindingSource
    Friend WithEvents EdificiosTableAdapter As ControlServiciosDataSet2TableAdapters.EdificiosTableAdapter
    Friend WithEvents NumEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomEdificioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
