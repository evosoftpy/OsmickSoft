﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crearClientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clienteApTxt = New System.Windows.Forms.TextBox()
        Me.clienteBorBtn = New System.Windows.Forms.Button()
        Me.clienteNomLb = New System.Windows.Forms.Label()
        Me.clienteNomTxt = New System.Windows.Forms.TextBox()
        Me.clienteApLb = New System.Windows.Forms.Label()
        Me.clienteRucLb = New System.Windows.Forms.Label()
        Me.clienteCargarBtn = New System.Windows.Forms.Button()
        Me.clienteNcTxt = New System.Windows.Forms.TextBox()
        Me.clienteRucTxt = New System.Windows.Forms.TextBox()
        Me.DataSet1 = New nuevo_repuestos.DataSet1()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.clienteTableAdapter()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clienteAgreGroup.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clienteAgreGroup
        '
        Me.clienteAgreGroup.Controls.Add(Me.Label1)
        Me.clienteAgreGroup.Controls.Add(Me.clienteApTxt)
        Me.clienteAgreGroup.Controls.Add(Me.clienteBorBtn)
        Me.clienteAgreGroup.Controls.Add(Me.clienteNomLb)
        Me.clienteAgreGroup.Controls.Add(Me.clienteNomTxt)
        Me.clienteAgreGroup.Controls.Add(Me.clienteApLb)
        Me.clienteAgreGroup.Controls.Add(Me.clienteRucLb)
        Me.clienteAgreGroup.Controls.Add(Me.clienteCargarBtn)
        Me.clienteAgreGroup.Controls.Add(Me.clienteNcTxt)
        Me.clienteAgreGroup.Controls.Add(Me.clienteRucTxt)
        Me.clienteAgreGroup.Location = New System.Drawing.Point(10, 11)
        Me.clienteAgreGroup.Name = "clienteAgreGroup"
        Me.clienteAgreGroup.Size = New System.Drawing.Size(407, 184)
        Me.clienteAgreGroup.TabIndex = 20
        Me.clienteAgreGroup.TabStop = False
        Me.clienteAgreGroup.Text = "Agregar Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Apellido:"
        '
        'clienteApTxt
        '
        Me.clienteApTxt.Location = New System.Drawing.Point(119, 50)
        Me.clienteApTxt.Name = "clienteApTxt"
        Me.clienteApTxt.Size = New System.Drawing.Size(272, 20)
        Me.clienteApTxt.TabIndex = 1
        '
        'clienteBorBtn
        '
        Me.clienteBorBtn.Location = New System.Drawing.Point(283, 143)
        Me.clienteBorBtn.Name = "clienteBorBtn"
        Me.clienteBorBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteBorBtn.TabIndex = 5
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
        Me.clienteApLb.Location = New System.Drawing.Point(17, 83)
        Me.clienteApLb.Name = "clienteApLb"
        Me.clienteApLb.Size = New System.Drawing.Size(47, 13)
        Me.clienteApLb.TabIndex = 5
        Me.clienteApLb.Text = "Numero:"
        '
        'clienteRucLb
        '
        Me.clienteRucLb.AutoSize = True
        Me.clienteRucLb.Location = New System.Drawing.Point(17, 110)
        Me.clienteRucLb.Name = "clienteRucLb"
        Me.clienteRucLb.Size = New System.Drawing.Size(39, 13)
        Me.clienteRucLb.TabIndex = 7
        Me.clienteRucLb.Text = "R.U.C:"
        '
        'clienteCargarBtn
        '
        Me.clienteCargarBtn.Location = New System.Drawing.Point(201, 144)
        Me.clienteCargarBtn.Name = "clienteCargarBtn"
        Me.clienteCargarBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteCargarBtn.TabIndex = 4
        Me.clienteCargarBtn.Text = "Agregar"
        Me.clienteCargarBtn.UseVisualStyleBackColor = True
        '
        'clienteNcTxt
        '
        Me.clienteNcTxt.Location = New System.Drawing.Point(119, 76)
        Me.clienteNcTxt.Name = "clienteNcTxt"
        Me.clienteNcTxt.Size = New System.Drawing.Size(108, 20)
        Me.clienteNcTxt.TabIndex = 2
        '
        'clienteRucTxt
        '
        Me.clienteRucTxt.Location = New System.Drawing.Point(119, 107)
        Me.clienteRucTxt.Name = "clienteRucTxt"
        Me.clienteRucTxt.Size = New System.Drawing.Size(108, 20)
        Me.clienteRucTxt.TabIndex = 3
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.DataSet1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ingreso_proveedorTableAdapter = Nothing
        Me.TableAdapterManager.ingresoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(451, 11)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ClienteDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre_cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre_cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellido_cliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellido_cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "numero_cliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "numero_cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ruc_cliente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ruc_cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'crearClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 221)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.clienteAgreGroup)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "crearClientes"
        Me.ShowIcon = False
        Me.Text = "Agregar Cliente"
        Me.clienteAgreGroup.ResumeLayout(False)
        Me.clienteAgreGroup.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents clienteAgreGroup As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clienteApTxt As TextBox
    Friend WithEvents clienteBorBtn As Button
    Friend WithEvents clienteNomLb As Label
    Friend WithEvents clienteNomTxt As TextBox
    Friend WithEvents clienteApLb As Label
    Friend WithEvents clienteRucLb As Label
    Friend WithEvents clienteCargarBtn As Button
    Friend WithEvents clienteNcTxt As TextBox
    Friend WithEvents clienteRucTxt As TextBox
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ClienteTableAdapter As DataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
