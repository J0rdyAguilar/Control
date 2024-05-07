<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiciosU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiciosU))
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtEstServAc = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnActualizarS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodSerAct = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(196, 290)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(51, 16)
        Me.label4.TabIndex = 42
        Me.label4.Text = "Estatus"
        '
        'txtEstServAc
        '
        Me.txtEstServAc.Location = New System.Drawing.Point(260, 290)
        Me.txtEstServAc.Name = "txtEstServAc"
        Me.txtEstServAc.Size = New System.Drawing.Size(285, 22)
        Me.txtEstServAc.TabIndex = 41
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(160, 337)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(414, 152)
        Me.DataGridView1.TabIndex = 39
        '
        'btnActualizarS
        '
        Me.btnActualizarS.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarS.Image = CType(resources.GetObject("btnActualizarS.Image"), System.Drawing.Image)
        Me.btnActualizarS.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnActualizarS.Location = New System.Drawing.Point(673, 460)
        Me.btnActualizarS.Name = "btnActualizarS"
        Me.btnActualizarS.Size = New System.Drawing.Size(131, 93)
        Me.btnActualizarS.TabIndex = 38
        Me.btnActualizarS.Text = "Actualizar"
        Me.btnActualizarS.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(276, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 37)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Actualizar Servicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(674, 157)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "SERVICIOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Codigo"
        '
        'txtCodSerAct
        '
        Me.txtCodSerAct.Location = New System.Drawing.Point(260, 246)
        Me.txtCodSerAct.Name = "txtCodSerAct"
        Me.txtCodSerAct.Size = New System.Drawing.Size(285, 22)
        Me.txtCodSerAct.TabIndex = 45
        '
        'frmServiciosU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 599)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodSerAct)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtEstServAc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnActualizarS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmServiciosU"
        Me.Text = "frmServiciosU"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label4 As Label
    Friend WithEvents txtEstServAc As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnActualizarS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodSerAct As TextBox
End Class
