<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.n_factura_textbox = New System.Windows.Forms.TextBox()
        Me.label_n_factura = New System.Windows.Forms.Label()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.label_ruc_venta = New System.Windows.Forms.Label()
        Me.text_total = New System.Windows.Forms.TextBox()
        Me.label_total = New System.Windows.Forms.Label()
        Me.text_iva = New System.Windows.Forms.TextBox()
        Me.label_iva = New System.Windows.Forms.Label()
        Me.text_sub_total = New System.Windows.Forms.TextBox()
        Me.label_subtotal = New System.Windows.Forms.Label()
        Me.venta_guardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Punit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.label_fecha = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.label_venta_cliente = New System.Windows.Forms.Label()
        Me.text_ruc_venta = New System.Windows.Forms.TextBox()
        Me.label_ruc = New System.Windows.Forms.Label()
        Me.DataSet1 = New nuevo_repuestos.DataSet1()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager()
        Me.IngresoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.ventaTableAdapter()
        Me.VentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.stockTableAdapter()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresoTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.ingresoTableAdapter()
        Me.IngresoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.clienteTableAdapter()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.facturas = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(96, 376)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(75, 23)
        Me.Button20.TabIndex = 4
        Me.Button20.Text = "Modificar"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(786, 187)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(75, 23)
        Me.Button31.TabIndex = 72
        Me.Button31.Text = "Anterior"
        Me.Button31.UseVisualStyleBackColor = True
        Me.Button31.Visible = False
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(867, 187)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(75, 23)
        Me.Button30.TabIndex = 71
        Me.Button30.Text = "Siguiente"
        Me.Button30.UseVisualStyleBackColor = True
        Me.Button30.Visible = False
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(15, 438)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(156, 23)
        Me.Button29.TabIndex = 7
        Me.Button29.Text = "Buscar por factura"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'n_factura_textbox
        '
        Me.n_factura_textbox.Location = New System.Drawing.Point(502, 53)
        Me.n_factura_textbox.Name = "n_factura_textbox"
        Me.n_factura_textbox.Size = New System.Drawing.Size(109, 20)
        Me.n_factura_textbox.TabIndex = 69
        '
        'label_n_factura
        '
        Me.label_n_factura.AutoSize = True
        Me.label_n_factura.Location = New System.Drawing.Point(422, 58)
        Me.label_n_factura.Name = "label_n_factura"
        Me.label_n_factura.Size = New System.Drawing.Size(66, 13)
        Me.label_n_factura.TabIndex = 68
        Me.label_n_factura.Text = "Nro. Factura"
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(15, 376)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(75, 23)
        Me.Button24.TabIndex = 3
        Me.Button24.Text = "Nuevo"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'label_ruc_venta
        '
        Me.label_ruc_venta.AutoSize = True
        Me.label_ruc_venta.Location = New System.Drawing.Point(162, 18)
        Me.label_ruc_venta.Name = "label_ruc_venta"
        Me.label_ruc_venta.Size = New System.Drawing.Size(83, 13)
        Me.label_ruc_venta.TabIndex = 66
        Me.label_ruc_venta.Text = "label_ruc_venta"
        Me.label_ruc_venta.Visible = False
        '
        'text_total
        '
        Me.text_total.Location = New System.Drawing.Point(486, 465)
        Me.text_total.Name = "text_total"
        Me.text_total.ReadOnly = True
        Me.text_total.Size = New System.Drawing.Size(100, 20)
        Me.text_total.TabIndex = 65
        Me.text_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label_total
        '
        Me.label_total.AutoSize = True
        Me.label_total.Location = New System.Drawing.Point(385, 472)
        Me.label_total.Name = "label_total"
        Me.label_total.Size = New System.Drawing.Size(42, 13)
        Me.label_total.TabIndex = 64
        Me.label_total.Text = "TOTAL"
        '
        'text_iva
        '
        Me.text_iva.Location = New System.Drawing.Point(486, 429)
        Me.text_iva.Name = "text_iva"
        Me.text_iva.ReadOnly = True
        Me.text_iva.Size = New System.Drawing.Size(100, 20)
        Me.text_iva.TabIndex = 63
        Me.text_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label_iva
        '
        Me.label_iva.AutoSize = True
        Me.label_iva.Location = New System.Drawing.Point(385, 436)
        Me.label_iva.Name = "label_iva"
        Me.label_iva.Size = New System.Drawing.Size(24, 13)
        Me.label_iva.TabIndex = 62
        Me.label_iva.Text = "IVA"
        '
        'text_sub_total
        '
        Me.text_sub_total.Location = New System.Drawing.Point(486, 390)
        Me.text_sub_total.Name = "text_sub_total"
        Me.text_sub_total.ReadOnly = True
        Me.text_sub_total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.text_sub_total.Size = New System.Drawing.Size(100, 20)
        Me.text_sub_total.TabIndex = 61
        Me.text_sub_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label_subtotal
        '
        Me.label_subtotal.AutoSize = True
        Me.label_subtotal.Location = New System.Drawing.Point(385, 397)
        Me.label_subtotal.Name = "label_subtotal"
        Me.label_subtotal.Size = New System.Drawing.Size(67, 13)
        Me.label_subtotal.TabIndex = 60
        Me.label_subtotal.Text = "SUB TOTAL"
        '
        'venta_guardar
        '
        Me.venta_guardar.Location = New System.Drawing.Point(15, 409)
        Me.venta_guardar.Name = "venta_guardar"
        Me.venta_guardar.Size = New System.Drawing.Size(75, 23)
        Me.venta_guardar.TabIndex = 5
        Me.venta_guardar.Text = "Guardar"
        Me.venta_guardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Descripcion, Me.Punit, Me.cant, Me.Importe})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 236)
        Me.DataGridView1.TabIndex = 2
        '
        'Codigo
        '
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Producto
        '
        Me.Producto.Frozen = True
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Punit
        '
        Me.Punit.HeaderText = "P/unid"
        Me.Punit.Name = "Punit"
        Me.Punit.ReadOnly = True
        '
        'cant
        '
        Me.cant.HeaderText = "Cant"
        Me.cant.Name = "cant"
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(502, 17)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(109, 20)
        Me.TextBox17.TabIndex = 57
        '
        'label_fecha
        '
        Me.label_fecha.AutoSize = True
        Me.label_fecha.Location = New System.Drawing.Point(451, 22)
        Me.label_fecha.Name = "label_fecha"
        Me.label_fecha.Size = New System.Drawing.Size(37, 13)
        Me.label_fecha.TabIndex = 56
        Me.label_fecha.Text = "Fecha"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(54, 55)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(335, 20)
        Me.TextBox16.TabIndex = 55
        '
        'label_venta_cliente
        '
        Me.label_venta_cliente.AutoSize = True
        Me.label_venta_cliente.Location = New System.Drawing.Point(9, 60)
        Me.label_venta_cliente.Name = "label_venta_cliente"
        Me.label_venta_cliente.Size = New System.Drawing.Size(39, 13)
        Me.label_venta_cliente.TabIndex = 54
        Me.label_venta_cliente.Text = "Cliente"
        '
        'text_ruc_venta
        '
        Me.text_ruc_venta.Location = New System.Drawing.Point(45, 15)
        Me.text_ruc_venta.Name = "text_ruc_venta"
        Me.text_ruc_venta.Size = New System.Drawing.Size(100, 20)
        Me.text_ruc_venta.TabIndex = 0
        '
        'label_ruc
        '
        Me.label_ruc.AutoSize = True
        Me.label_ruc.Location = New System.Drawing.Point(9, 20)
        Me.label_ruc.Name = "label_ruc"
        Me.label_ruc.Size = New System.Drawing.Size(30, 13)
        Me.label_ruc.TabIndex = 52
        Me.label_ruc.Text = "RUC"
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
        'IngresoBindingSource
        '
        Me.IngresoBindingSource.DataMember = "ingreso"
        Me.IngresoBindingSource.DataSource = Me.DataSet1
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.DataSet1
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "venta"
        Me.VentaBindingSource.DataSource = Me.DataSet1
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AutoGenerateColumns = False
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8})
        Me.VentaDataGridView.DataSource = Me.VentaBindingSource
        Me.VentaDataGridView.Location = New System.Drawing.Point(1070, 38)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.RowTemplate.Height = 28
        Me.VentaDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.VentaDataGridView.TabIndex = 74
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_venta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_venta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad_venta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cantidad_venta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "factura_venta"
        Me.DataGridViewTextBoxColumn5.HeaderText = "factura_venta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha_venta"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fecha_venta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn8.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(1070, 270)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.RowTemplate.Height = 28
        Me.StockDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.StockDataGridView.TabIndex = 74
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn9.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "codigo_barras"
        Me.DataGridViewTextBoxColumn11.HeaderText = "codigo_barras"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn12.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn13.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn14.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'IngresoTableAdapter
        '
        Me.IngresoTableAdapter.ClearBeforeFill = True
        '
        'IngresoDataGridView
        '
        Me.IngresoDataGridView.AutoGenerateColumns = False
        Me.IngresoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngresoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.IngresoDataGridView.DataSource = Me.IngresoBindingSource
        Me.IngresoDataGridView.Location = New System.Drawing.Point(1376, 38)
        Me.IngresoDataGridView.Name = "IngresoDataGridView"
        Me.IngresoDataGridView.RowTemplate.Height = 28
        Me.IngresoDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.IngresoDataGridView.TabIndex = 74
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "id_ingreso"
        Me.DataGridViewTextBoxColumn15.HeaderText = "id_ingreso"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn16.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn17.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "factura_compra"
        Me.DataGridViewTextBoxColumn18.HeaderText = "factura_compra"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "precio_compra"
        Me.DataGridViewTextBoxColumn19.HeaderText = "precio_compra"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "fecha_ingreso"
        Me.DataGridViewTextBoxColumn20.HeaderText = "fecha_ingreso"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(1376, 273)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.RowTemplate.Height = 28
        Me.ClienteDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ClienteDataGridView.TabIndex = 74
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn21.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "nombre_cliente"
        Me.DataGridViewTextBoxColumn22.HeaderText = "nombre_cliente"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "apellido_cliente"
        Me.DataGridViewTextBoxColumn23.HeaderText = "apellido_cliente"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "numero_cliente"
        Me.DataGridViewTextBoxColumn24.HeaderText = "numero_cliente"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "ruc_cliente"
        Me.DataGridViewTextBoxColumn25.HeaderText = "ruc_cliente"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'facturas
        '
        Me.facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.factura})
        Me.facturas.Location = New System.Drawing.Point(679, 18)
        Me.facturas.Name = "facturas"
        Me.facturas.Size = New System.Drawing.Size(263, 150)
        Me.facturas.TabIndex = 75
        Me.facturas.Visible = False
        '
        'numero
        '
        Me.numero.HeaderText = "numero"
        Me.numero.Name = "numero"
        '
        'factura
        '
        Me.factura.HeaderText = "factura"
        Me.factura.Name = "factura"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 463)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Siguiente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(15, 463)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Anterior"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(665, 502)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.facturas)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.IngresoDataGridView)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Controls.Add(Me.VentaDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.n_factura_textbox)
        Me.Controls.Add(Me.label_n_factura)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.label_ruc_venta)
        Me.Controls.Add(Me.text_total)
        Me.Controls.Add(Me.label_total)
        Me.Controls.Add(Me.text_iva)
        Me.Controls.Add(Me.label_iva)
        Me.Controls.Add(Me.text_sub_total)
        Me.Controls.Add(Me.label_subtotal)
        Me.Controls.Add(Me.venta_guardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.label_fecha)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.label_venta_cliente)
        Me.Controls.Add(Me.text_ruc_venta)
        Me.Controls.Add(Me.label_ruc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(610, 100)
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ventas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents n_factura_textbox As TextBox
    Friend WithEvents label_n_factura As Label
    Friend WithEvents Button24 As Button
    Friend WithEvents label_ruc_venta As Label
    Friend WithEvents text_total As TextBox
    Friend WithEvents label_total As Label
    Friend WithEvents text_iva As TextBox
    Friend WithEvents label_iva As Label
    Friend WithEvents text_sub_total As TextBox
    Friend WithEvents label_subtotal As Label
    Friend WithEvents venta_guardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents label_fecha As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents label_venta_cliente As Label
    Friend WithEvents text_ruc_venta As TextBox
    Friend WithEvents label_ruc As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents IngresoBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Punit As DataGridViewTextBoxColumn
    Friend WithEvents cant As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents VentaTableAdapter As DataSet1TableAdapters.ventaTableAdapter
    Friend WithEvents VentaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents StockTableAdapter As DataSet1TableAdapters.stockTableAdapter
    Friend WithEvents StockDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents IngresoTableAdapter As DataSet1TableAdapters.ingresoTableAdapter
    Friend WithEvents IngresoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents ClienteTableAdapter As DataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents facturas As DataGridView
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents factura As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
