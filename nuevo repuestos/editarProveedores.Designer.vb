<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editarProveedores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.clienteAgreGroup = New System.Windows.Forms.GroupBox()
        Me.clienteBorBtn = New System.Windows.Forms.Button()
        Me.clienteNomLb = New System.Windows.Forms.Label()
        Me.clienteNomTxt = New System.Windows.Forms.TextBox()
        Me.clienteApLb = New System.Windows.Forms.Label()
        Me.clienteRucLb = New System.Windows.Forms.Label()
        Me.clienteEditarBtn = New System.Windows.Forms.Button()
        Me.clienteApTxt = New System.Windows.Forms.TextBox()
        Me.clienteRucTxt = New System.Windows.Forms.TextBox()
        Me.DataSet1 = New nuevo_repuestos.DataSet1()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.proveedorTableAdapter()
        Me.TableAdapterManager = New nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clienteAgreGroup.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clienteAgreGroup
        '
        Me.clienteAgreGroup.Controls.Add(Me.clienteBorBtn)
        Me.clienteAgreGroup.Controls.Add(Me.clienteNomLb)
        Me.clienteAgreGroup.Controls.Add(Me.clienteNomTxt)
        Me.clienteAgreGroup.Controls.Add(Me.clienteApLb)
        Me.clienteAgreGroup.Controls.Add(Me.clienteRucLb)
        Me.clienteAgreGroup.Controls.Add(Me.clienteEditarBtn)
        Me.clienteAgreGroup.Controls.Add(Me.clienteApTxt)
        Me.clienteAgreGroup.Controls.Add(Me.clienteRucTxt)
        Me.clienteAgreGroup.Location = New System.Drawing.Point(10, 11)
        Me.clienteAgreGroup.Name = "clienteAgreGroup"
        Me.clienteAgreGroup.Size = New System.Drawing.Size(407, 184)
        Me.clienteAgreGroup.TabIndex = 21
        Me.clienteAgreGroup.TabStop = False
        Me.clienteAgreGroup.Text = "Editar Proveedor"
        '
        'clienteBorBtn
        '
        Me.clienteBorBtn.Location = New System.Drawing.Point(283, 143)
        Me.clienteBorBtn.Name = "clienteBorBtn"
        Me.clienteBorBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteBorBtn.TabIndex = 12
        Me.clienteBorBtn.Text = "Borrar"
        Me.clienteBorBtn.UseVisualStyleBackColor = True
        '
        'clienteNomLb
        '
        Me.clienteNomLb.AutoSize = True
        Me.clienteNomLb.Location = New System.Drawing.Point(17, 30)
        Me.clienteNomLb.Name = "clienteNomLb"
        Me.clienteNomLb.Size = New System.Drawing.Size(47, 13)
        Me.clienteNomLb.TabIndex = 4
        Me.clienteNomLb.Text = "Nombre:"
        '
        'clienteNomTxt
        '
        Me.clienteNomTxt.Location = New System.Drawing.Point(119, 23)
        Me.clienteNomTxt.Name = "clienteNomTxt"
        Me.clienteNomTxt.Size = New System.Drawing.Size(272, 20)
        Me.clienteNomTxt.TabIndex = 0
        '
        'clienteApLb
        '
        Me.clienteApLb.AutoSize = True
        Me.clienteApLb.Location = New System.Drawing.Point(17, 57)
        Me.clienteApLb.Name = "clienteApLb"
        Me.clienteApLb.Size = New System.Drawing.Size(47, 13)
        Me.clienteApLb.TabIndex = 5
        Me.clienteApLb.Text = "Numero:"
        '
        'clienteRucLb
        '
        Me.clienteRucLb.AutoSize = True
        Me.clienteRucLb.Location = New System.Drawing.Point(17, 84)
        Me.clienteRucLb.Name = "clienteRucLb"
        Me.clienteRucLb.Size = New System.Drawing.Size(39, 13)
        Me.clienteRucLb.TabIndex = 7
        Me.clienteRucLb.Text = "R.U.C:"
        '
        'clienteEditarBtn
        '
        Me.clienteEditarBtn.Location = New System.Drawing.Point(201, 144)
        Me.clienteEditarBtn.Name = "clienteEditarBtn"
        Me.clienteEditarBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteEditarBtn.TabIndex = 11
        Me.clienteEditarBtn.Text = "Editar"
        Me.clienteEditarBtn.UseVisualStyleBackColor = True
        '
        'clienteApTxt
        '
        Me.clienteApTxt.Location = New System.Drawing.Point(119, 50)
        Me.clienteApTxt.Name = "clienteApTxt"
        Me.clienteApTxt.Size = New System.Drawing.Size(108, 20)
        Me.clienteApTxt.TabIndex = 8
        '
        'clienteRucTxt
        '
        Me.clienteRucTxt.Location = New System.Drawing.Point(119, 81)
        Me.clienteRucTxt.Name = "clienteRucTxt"
        Me.clienteRucTxt.Size = New System.Drawing.Size(108, 20)
        Me.clienteRucTxt.TabIndex = 10
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.DataSet1
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.ingresoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(480, 15)
        Me.ProveedorDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.RowTemplate.Height = 24
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(225, 179)
        Me.ProveedorDataGridView.TabIndex = 22
        Me.ProveedorDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ruc_proveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ruc_proveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre_proveedor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre_proveedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "numero_proveedor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "numero_proveedor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'editarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 211)
        Me.Controls.Add(Me.ProveedorDataGridView)
        Me.Controls.Add(Me.clienteAgreGroup)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "editarProveedores"
        Me.Text = "editarProveedores"
        Me.clienteAgreGroup.ResumeLayout(False)
        Me.clienteAgreGroup.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents clienteAgreGroup As GroupBox
    Friend WithEvents clienteBorBtn As Button
    Friend WithEvents clienteNomLb As Label
    Friend WithEvents clienteNomTxt As TextBox
    Friend WithEvents clienteApLb As Label
    Friend WithEvents clienteRucLb As Label
    Friend WithEvents clienteEditarBtn As Button
    Friend WithEvents clienteApTxt As TextBox
    Friend WithEvents clienteRucTxt As TextBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As DataSet1TableAdapters.proveedorTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
