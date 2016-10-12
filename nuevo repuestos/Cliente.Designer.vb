<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.clientesBusGroup = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.clienteRucList = New System.Windows.Forms.ListBox()
        Me.clienteNumeroList = New System.Windows.Forms.ListBox()
        Me.clienteApellidoList = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clienteNombreList = New System.Windows.Forms.ListBox()
        Me.clienteAgreBtn = New System.Windows.Forms.Button()
        Me.clienteSalBtn = New System.Windows.Forms.Button()
        Me.clienteParaLb = New System.Windows.Forms.Label()
        Me.clienteParTxt = New System.Windows.Forms.TextBox()
        Me.clienteBusBtn = New System.Windows.Forms.Button()
        Me.clienteLb = New System.Windows.Forms.Label()
        Me.DataSet1 = New nuevo_repuestos.DataSet1()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clientesBusGroup.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'clientesBusGroup
        '
        Me.clientesBusGroup.Controls.Add(Me.Button1)
        Me.clientesBusGroup.Controls.Add(Me.TableLayoutPanel1)
        Me.clientesBusGroup.Controls.Add(Me.clienteAgreBtn)
        Me.clientesBusGroup.Controls.Add(Me.clienteSalBtn)
        Me.clientesBusGroup.Controls.Add(Me.clienteParaLb)
        Me.clientesBusGroup.Controls.Add(Me.clienteParTxt)
        Me.clientesBusGroup.Controls.Add(Me.clienteBusBtn)
        Me.clientesBusGroup.Location = New System.Drawing.Point(46, 50)
        Me.clientesBusGroup.Name = "clientesBusGroup"
        Me.clientesBusGroup.Size = New System.Drawing.Size(626, 388)
        Me.clientesBusGroup.TabIndex = 19
        Me.clientesBusGroup.TabStop = False
        Me.clientesBusGroup.Text = "Buscar Cliente"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(337, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Mostrar todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.92746!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.07254!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.clienteRucList, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.clienteNumeroList, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.clienteApellidoList, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.clienteNombreList, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 102)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(614, 280)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'clienteRucList
        '
        Me.clienteRucList.FormattingEnabled = True
        Me.clienteRucList.Location = New System.Drawing.Point(498, 23)
        Me.clienteRucList.Name = "clienteRucList"
        Me.clienteRucList.Size = New System.Drawing.Size(106, 251)
        Me.clienteRucList.TabIndex = 7
        '
        'clienteNumeroList
        '
        Me.clienteNumeroList.FormattingEnabled = True
        Me.clienteNumeroList.Location = New System.Drawing.Point(380, 23)
        Me.clienteNumeroList.Name = "clienteNumeroList"
        Me.clienteNumeroList.Size = New System.Drawing.Size(112, 251)
        Me.clienteNumeroList.TabIndex = 6
        '
        'clienteApellidoList
        '
        Me.clienteApellidoList.FormattingEnabled = True
        Me.clienteApellidoList.Location = New System.Drawing.Point(184, 23)
        Me.clienteApellidoList.Name = "clienteApellidoList"
        Me.clienteApellidoList.Size = New System.Drawing.Size(190, 251)
        Me.clienteApellidoList.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(498, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ruc:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(380, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'clienteNombreList
        '
        Me.clienteNombreList.FormattingEnabled = True
        Me.clienteNombreList.Location = New System.Drawing.Point(3, 23)
        Me.clienteNombreList.Name = "clienteNombreList"
        Me.clienteNombreList.Size = New System.Drawing.Size(175, 251)
        Me.clienteNombreList.TabIndex = 4
        '
        'clienteAgreBtn
        '
        Me.clienteAgreBtn.Location = New System.Drawing.Point(434, 57)
        Me.clienteAgreBtn.Name = "clienteAgreBtn"
        Me.clienteAgreBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteAgreBtn.TabIndex = 3
        Me.clienteAgreBtn.Text = "Agregar"
        Me.clienteAgreBtn.UseVisualStyleBackColor = True
        '
        'clienteSalBtn
        '
        Me.clienteSalBtn.Location = New System.Drawing.Point(515, 57)
        Me.clienteSalBtn.Name = "clienteSalBtn"
        Me.clienteSalBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteSalBtn.TabIndex = 4
        Me.clienteSalBtn.Text = "Salir"
        Me.clienteSalBtn.UseVisualStyleBackColor = True
        '
        'clienteParaLb
        '
        Me.clienteParaLb.AutoSize = True
        Me.clienteParaLb.Location = New System.Drawing.Point(17, 30)
        Me.clienteParaLb.Name = "clienteParaLb"
        Me.clienteParaLb.Size = New System.Drawing.Size(123, 13)
        Me.clienteParaLb.TabIndex = 4
        Me.clienteParaLb.Text = "Parametro de busqueda:"
        '
        'clienteParTxt
        '
        Me.clienteParTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.clienteParTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.clienteParTxt.Location = New System.Drawing.Point(146, 23)
        Me.clienteParTxt.Name = "clienteParTxt"
        Me.clienteParTxt.Size = New System.Drawing.Size(445, 20)
        Me.clienteParTxt.TabIndex = 0
        Me.clienteParTxt.Tag = "Holi"
        '
        'clienteBusBtn
        '
        Me.clienteBusBtn.Location = New System.Drawing.Point(256, 57)
        Me.clienteBusBtn.Name = "clienteBusBtn"
        Me.clienteBusBtn.Size = New System.Drawing.Size(75, 23)
        Me.clienteBusBtn.TabIndex = 1
        Me.clienteBusBtn.Text = "Buscar"
        Me.clienteBusBtn.UseVisualStyleBackColor = True
        '
        'clienteLb
        '
        Me.clienteLb.AutoSize = True
        Me.clienteLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clienteLb.Location = New System.Drawing.Point(292, 10)
        Me.clienteLb.Name = "clienteLb"
        Me.clienteLb.Size = New System.Drawing.Size(139, 37)
        Me.clienteLb.TabIndex = 18
        Me.clienteLb.Text = "Clientes"
        Me.clienteLb.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.ingreso_proveedorTableAdapter = Nothing
        Me.TableAdapterManager.ingresoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.stockTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(725, 65)
        Me.ClienteDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.RowTemplate.Height = 24
        Me.ClienteDataGridView.Size = New System.Drawing.Size(225, 179)
        Me.ClienteDataGridView.TabIndex = 20
        Me.ClienteDataGridView.Visible = False
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 457)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ControlBox = False
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.clientesBusGroup)
        Me.Controls.Add(Me.clienteLb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.clientesBusGroup.ResumeLayout(False)
        Me.clientesBusGroup.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clientesBusGroup As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents clienteRucList As ListBox
    Friend WithEvents clienteNumeroList As ListBox
    Friend WithEvents clienteApellidoList As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents clienteNombreList As ListBox
    Friend WithEvents clienteAgreBtn As Button
    Friend WithEvents clienteSalBtn As Button
    Friend WithEvents clienteParaLb As Label
    Friend WithEvents clienteParTxt As TextBox
    Friend WithEvents clienteBusBtn As Button
    Friend WithEvents clienteLb As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As DataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
