<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.DataSet1 = New nuevo_repuestos.DataSet1()
        Me.IngresoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IngresoTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.ingresoTableAdapter()
        Me.TableAdapterManager = New nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager()
        Me.ProveedorTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.proveedorTableAdapter()
        Me.StockTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.stockTableAdapter()
        Me.VentaTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.ventaTableAdapter()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBoxIngresarProducto = New System.Windows.Forms.GroupBox()
        Me.TextBoxFecha = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxNumeroProveedor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxRUCproveedor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxFactura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelInsertarProducto = New System.Windows.Forms.Label()
        Me.ButtonInsertarProducto = New System.Windows.Forms.Button()
        Me.TextBoxPrecioDeVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCodigoDeBarras = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.Label41a = New System.Windows.Forms.Label()
        Me.ButtonModificarProducto = New System.Windows.Forms.Button()
        Me.ButtonIngresarProducto = New System.Windows.Forms.Button()
        Me.GroupBoxModificarProducto = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LabelModificarProducto = New System.Windows.Forms.Label()
        Me.TextBoxModificarNuevoPrecioDeVenta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxModificarNuevaDescripcion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxModificarNuevoNombre = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxModificarNuevoCodigoDeBarras = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxModificarNuevoCodigo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.clienteTableAdapter()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngresoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingreso_proveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingreso_proveedorTableAdapter = New nuevo_repuestos.DataSet1TableAdapters.ingreso_proveedorTableAdapter()
        Me.Ingreso_proveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelIdQueNoSeVe = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxIngresarProducto.SuspendLayout()
        Me.GroupBoxModificarProducto.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngresoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingreso_proveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingreso_proveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IngresoBindingSource
        '
        Me.IngresoBindingSource.DataMember = "ingreso"
        Me.IngresoBindingSource.DataSource = Me.DataSet1
        '
        'IngresoTableAdapter
        '
        Me.IngresoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.ingreso_proveedorTableAdapter = Nothing
        Me.TableAdapterManager.ingresoTableAdapter = Me.IngresoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.stockTableAdapter = Me.StockTableAdapter
        Me.TableAdapterManager.UpdateOrder = nuevo_repuestos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ventaTableAdapter = Me.VentaTableAdapter
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.DataSet1
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
        'GroupBoxIngresarProducto
        '
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxFecha)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label11)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Button1)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxNumeroProveedor)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label8)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxNombreProveedor)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label9)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxRUCproveedor)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label10)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxPrecio)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label4)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxFactura)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label6)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxCantidad)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label7)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.LabelInsertarProducto)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.ButtonInsertarProducto)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxPrecioDeVenta)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label5)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxDescripcion)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label2)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxNombre)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label3)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxCodigoDeBarras)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label1)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.TextBoxCodigo)
        Me.GroupBoxIngresarProducto.Controls.Add(Me.Label41a)
        Me.GroupBoxIngresarProducto.Location = New System.Drawing.Point(137, 44)
        Me.GroupBoxIngresarProducto.Name = "GroupBoxIngresarProducto"
        Me.GroupBoxIngresarProducto.Size = New System.Drawing.Size(304, 424)
        Me.GroupBoxIngresarProducto.TabIndex = 56
        Me.GroupBoxIngresarProducto.TabStop = False
        Me.GroupBoxIngresarProducto.Text = "Ingresar Producto"
        '
        'TextBoxFecha
        '
        Me.TextBoxFecha.Location = New System.Drawing.Point(124, 244)
        Me.TextBoxFecha.Name = "TextBoxFecha"
        Me.TextBoxFecha.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxFecha.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(82, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Fecha:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 24)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Borrar Campos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxNumeroProveedor
        '
        Me.TextBoxNumeroProveedor.Location = New System.Drawing.Point(124, 333)
        Me.TextBoxNumeroProveedor.Name = "TextBoxNumeroProveedor"
        Me.TextBoxNumeroProveedor.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxNumeroProveedor.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Número del Proveedor:"
        '
        'TextBoxNombreProveedor
        '
        Me.TextBoxNombreProveedor.Location = New System.Drawing.Point(124, 307)
        Me.TextBoxNombreProveedor.Name = "TextBoxNombreProveedor"
        Me.TextBoxNombreProveedor.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxNombreProveedor.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Nombre del Proveedor:"
        '
        'TextBoxRUCproveedor
        '
        Me.TextBoxRUCproveedor.Location = New System.Drawing.Point(124, 281)
        Me.TextBoxRUCproveedor.Name = "TextBoxRUCproveedor"
        Me.TextBoxRUCproveedor.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxRUCproveedor.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "RUC del Proveedor:"
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(124, 218)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxPrecio.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Costo:"
        '
        'TextBoxFactura
        '
        Me.TextBoxFactura.Location = New System.Drawing.Point(124, 192)
        Me.TextBoxFactura.Name = "TextBoxFactura"
        Me.TextBoxFactura.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxFactura.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Factura:"
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(124, 166)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCantidad.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cantidad:"
        '
        'LabelInsertarProducto
        '
        Me.LabelInsertarProducto.AutoSize = True
        Me.LabelInsertarProducto.Location = New System.Drawing.Point(64, 362)
        Me.LabelInsertarProducto.Name = "LabelInsertarProducto"
        Me.LabelInsertarProducto.Size = New System.Drawing.Size(111, 13)
        Me.LabelInsertarProducto.TabIndex = 15
        Me.LabelInsertarProducto.Text = "LabelInsertarProducto"
        Me.LabelInsertarProducto.Visible = False
        '
        'ButtonInsertarProducto
        '
        Me.ButtonInsertarProducto.Location = New System.Drawing.Point(38, 386)
        Me.ButtonInsertarProducto.Name = "ButtonInsertarProducto"
        Me.ButtonInsertarProducto.Size = New System.Drawing.Size(96, 24)
        Me.ButtonInsertarProducto.TabIndex = 11
        Me.ButtonInsertarProducto.Text = "Insertar Producto"
        Me.ButtonInsertarProducto.UseVisualStyleBackColor = True
        '
        'TextBoxPrecioDeVenta
        '
        Me.TextBoxPrecioDeVenta.Location = New System.Drawing.Point(124, 130)
        Me.TextBoxPrecioDeVenta.Name = "TextBoxPrecioDeVenta"
        Me.TextBoxPrecioDeVenta.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxPrecioDeVenta.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Precio de venta:"
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(124, 104)
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxDescripcion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(124, 78)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre:"
        '
        'TextBoxCodigoDeBarras
        '
        Me.TextBoxCodigoDeBarras.Location = New System.Drawing.Point(124, 15)
        Me.TextBoxCodigoDeBarras.Name = "TextBoxCodigoDeBarras"
        Me.TextBoxCodigoDeBarras.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCodigoDeBarras.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Código de barras:"
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Location = New System.Drawing.Point(124, 41)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxCodigo.TabIndex = 1
        '
        'Label41a
        '
        Me.Label41a.AutoSize = True
        Me.Label41a.Location = New System.Drawing.Point(79, 45)
        Me.Label41a.Name = "Label41a"
        Me.Label41a.Size = New System.Drawing.Size(43, 13)
        Me.Label41a.TabIndex = 4
        Me.Label41a.Text = "Código:"
        '
        'ButtonModificarProducto
        '
        Me.ButtonModificarProducto.Location = New System.Drawing.Point(26, 137)
        Me.ButtonModificarProducto.Name = "ButtonModificarProducto"
        Me.ButtonModificarProducto.Size = New System.Drawing.Size(72, 34)
        Me.ButtonModificarProducto.TabIndex = 59
        Me.ButtonModificarProducto.Text = "Modificar Producto"
        Me.ButtonModificarProducto.UseVisualStyleBackColor = True
        '
        'ButtonIngresarProducto
        '
        Me.ButtonIngresarProducto.Location = New System.Drawing.Point(26, 81)
        Me.ButtonIngresarProducto.Name = "ButtonIngresarProducto"
        Me.ButtonIngresarProducto.Size = New System.Drawing.Size(72, 34)
        Me.ButtonIngresarProducto.TabIndex = 58
        Me.ButtonIngresarProducto.Text = "Ingresar Producto"
        Me.ButtonIngresarProducto.UseVisualStyleBackColor = True
        '
        'GroupBoxModificarProducto
        '
        Me.GroupBoxModificarProducto.Controls.Add(Me.Button2)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Button3)
        Me.GroupBoxModificarProducto.Controls.Add(Me.LabelModificarProducto)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarNuevoPrecioDeVenta)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label14)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarNuevaDescripcion)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label15)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarNuevoNombre)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label16)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarNuevoCodigoDeBarras)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label17)
        Me.GroupBoxModificarProducto.Controls.Add(Me.TextBoxModificarNuevoCodigo)
        Me.GroupBoxModificarProducto.Controls.Add(Me.Label18)
        Me.GroupBoxModificarProducto.Location = New System.Drawing.Point(143, 40)
        Me.GroupBoxModificarProducto.Name = "GroupBoxModificarProducto"
        Me.GroupBoxModificarProducto.Size = New System.Drawing.Size(304, 424)
        Me.GroupBoxModificarProducto.TabIndex = 57
        Me.GroupBoxModificarProducto.TabStop = False
        Me.GroupBoxModificarProducto.Text = "Modificar Producto"
        Me.GroupBoxModificarProducto.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 24)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Borrar Campos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 24)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Modificar Producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LabelModificarProducto
        '
        Me.LabelModificarProducto.AutoSize = True
        Me.LabelModificarProducto.Location = New System.Drawing.Point(136, 271)
        Me.LabelModificarProducto.Name = "LabelModificarProducto"
        Me.LabelModificarProducto.Size = New System.Drawing.Size(119, 13)
        Me.LabelModificarProducto.TabIndex = 49
        Me.LabelModificarProducto.Text = "LabelModificarProducto"
        Me.LabelModificarProducto.Visible = False
        '
        'TextBoxModificarNuevoPrecioDeVenta
        '
        Me.TextBoxModificarNuevoPrecioDeVenta.Location = New System.Drawing.Point(135, 195)
        Me.TextBoxModificarNuevoPrecioDeVenta.Name = "TextBoxModificarNuevoPrecioDeVenta"
        Me.TextBoxModificarNuevoPrecioDeVenta.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarNuevoPrecioDeVenta.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 199)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Nuevo Precio de venta:"
        '
        'TextBoxModificarNuevaDescripcion
        '
        Me.TextBoxModificarNuevaDescripcion.Location = New System.Drawing.Point(135, 167)
        Me.TextBoxModificarNuevaDescripcion.Name = "TextBoxModificarNuevaDescripcion"
        Me.TextBoxModificarNuevaDescripcion.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarNuevaDescripcion.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 171)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Nueva Descripción:"
        '
        'TextBoxModificarNuevoNombre
        '
        Me.TextBoxModificarNuevoNombre.Location = New System.Drawing.Point(135, 139)
        Me.TextBoxModificarNuevoNombre.Name = "TextBoxModificarNuevoNombre"
        Me.TextBoxModificarNuevoNombre.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarNuevoNombre.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(51, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Nuevo Nombre:"
        '
        'TextBoxModificarNuevoCodigoDeBarras
        '
        Me.TextBoxModificarNuevoCodigoDeBarras.Location = New System.Drawing.Point(135, 83)
        Me.TextBoxModificarNuevoCodigoDeBarras.Name = "TextBoxModificarNuevoCodigoDeBarras"
        Me.TextBoxModificarNuevoCodigoDeBarras.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarNuevoCodigoDeBarras.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 87)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Nuevo Código de barras:"
        '
        'TextBoxModificarNuevoCodigo
        '
        Me.TextBoxModificarNuevoCodigo.Location = New System.Drawing.Point(135, 111)
        Me.TextBoxModificarNuevoCodigo.Name = "TextBoxModificarNuevoCodigo"
        Me.TextBoxModificarNuevoCodigo.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxModificarNuevoCodigo.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(55, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Nuevo Código:"
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
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(395, 99)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(109, 66)
        Me.ClienteDataGridView.TabIndex = 59
        Me.ClienteDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre_cliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre_cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "apellido_cliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "apellido_cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "numero_cliente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "numero_cliente"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ruc_cliente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ruc_cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'IngresoDataGridView
        '
        Me.IngresoDataGridView.AutoGenerateColumns = False
        Me.IngresoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngresoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.IngresoDataGridView.DataSource = Me.IngresoBindingSource
        Me.IngresoDataGridView.Location = New System.Drawing.Point(395, 99)
        Me.IngresoDataGridView.Name = "IngresoDataGridView"
        Me.IngresoDataGridView.Size = New System.Drawing.Size(109, 66)
        Me.IngresoDataGridView.TabIndex = 59
        Me.IngresoDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_ingreso"
        Me.DataGridViewTextBoxColumn7.HeaderText = "id_ingreso"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "factura_compra"
        Me.DataGridViewTextBoxColumn10.HeaderText = "factura_compra"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "precio_compra"
        Me.DataGridViewTextBoxColumn11.HeaderText = "precio_compra"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "fecha_ingreso"
        Me.DataGridViewTextBoxColumn12.HeaderText = "fecha_ingreso"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Ingreso_proveedorBindingSource
        '
        Me.Ingreso_proveedorBindingSource.DataMember = "ingreso_proveedor"
        Me.Ingreso_proveedorBindingSource.DataSource = Me.DataSet1
        '
        'Ingreso_proveedorTableAdapter
        '
        Me.Ingreso_proveedorTableAdapter.ClearBeforeFill = True
        '
        'Ingreso_proveedorDataGridView
        '
        Me.Ingreso_proveedorDataGridView.AutoGenerateColumns = False
        Me.Ingreso_proveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ingreso_proveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Ingreso_proveedorDataGridView.DataSource = Me.Ingreso_proveedorBindingSource
        Me.Ingreso_proveedorDataGridView.Location = New System.Drawing.Point(395, 99)
        Me.Ingreso_proveedorDataGridView.Name = "Ingreso_proveedorDataGridView"
        Me.Ingreso_proveedorDataGridView.Size = New System.Drawing.Size(109, 66)
        Me.Ingreso_proveedorDataGridView.TabIndex = 59
        Me.Ingreso_proveedorDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn13.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "id_ingreso"
        Me.DataGridViewTextBoxColumn14.HeaderText = "id_ingreso"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(395, 99)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(109, 66)
        Me.ProveedorDataGridView.TabIndex = 59
        Me.ProveedorDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn15.HeaderText = "id_proveedor"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ruc_proveedor"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ruc_proveedor"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "nombre_proveedor"
        Me.DataGridViewTextBoxColumn17.HeaderText = "nombre_proveedor"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "numero_proveedor"
        Me.DataGridViewTextBoxColumn18.HeaderText = "numero_proveedor"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AutoGenerateColumns = False
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.VentaDataGridView.DataSource = Me.VentaBindingSource
        Me.VentaDataGridView.Location = New System.Drawing.Point(395, 242)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.Size = New System.Drawing.Size(109, 66)
        Me.VentaDataGridView.TabIndex = 59
        Me.VentaDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "id_venta"
        Me.DataGridViewTextBoxColumn25.HeaderText = "id_venta"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn26.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn27.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "cantidad_venta"
        Me.DataGridViewTextBoxColumn28.HeaderText = "cantidad_venta"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "factura_venta"
        Me.DataGridViewTextBoxColumn29.HeaderText = "factura_venta"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "fecha_venta"
        Me.DataGridViewTextBoxColumn30.HeaderText = "fecha_venta"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn31.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'StockDataGridView
        '
        Me.StockDataGridView.AutoGenerateColumns = False
        Me.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.StockDataGridView.DataSource = Me.StockBindingSource
        Me.StockDataGridView.Location = New System.Drawing.Point(397, 166)
        Me.StockDataGridView.Name = "StockDataGridView"
        Me.StockDataGridView.Size = New System.Drawing.Size(107, 70)
        Me.StockDataGridView.TabIndex = 59
        Me.StockDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "id_stock"
        Me.DataGridViewTextBoxColumn19.HeaderText = "id_stock"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn20.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "codigo_barras"
        Me.DataGridViewTextBoxColumn21.HeaderText = "codigo_barras"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn22.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn23.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "precio_venta"
        Me.DataGridViewTextBoxColumn24.HeaderText = "precio_venta"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'LabelIdQueNoSeVe
        '
        Me.LabelIdQueNoSeVe.AutoSize = True
        Me.LabelIdQueNoSeVe.Location = New System.Drawing.Point(12, 466)
        Me.LabelIdQueNoSeVe.Name = "LabelIdQueNoSeVe"
        Me.LabelIdQueNoSeVe.Size = New System.Drawing.Size(102, 13)
        Me.LabelIdQueNoSeVe.TabIndex = 60
        Me.LabelIdQueNoSeVe.Text = "LabelIdQueNoSeVe"
        Me.LabelIdQueNoSeVe.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelIdQueNoSeVe)
        Me.Controls.Add(Me.ButtonModificarProducto)
        Me.Controls.Add(Me.ButtonIngresarProducto)
        Me.Controls.Add(Me.VentaDataGridView)
        Me.Controls.Add(Me.ProveedorDataGridView)
        Me.Controls.Add(Me.Ingreso_proveedorDataGridView)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.IngresoDataGridView)
        Me.Controls.Add(Me.StockDataGridView)
        Me.Controls.Add(Me.GroupBoxModificarProducto)
        Me.Controls.Add(Me.GroupBoxIngresarProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(615, 100)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Stock"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxIngresarProducto.ResumeLayout(False)
        Me.GroupBoxIngresarProducto.PerformLayout()
        Me.GroupBoxModificarProducto.ResumeLayout(False)
        Me.GroupBoxModificarProducto.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngresoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingreso_proveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingreso_proveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents IngresoBindingSource As BindingSource
    Friend WithEvents IngresoTableAdapter As DataSet1TableAdapters.ingresoTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ProveedorTableAdapter As DataSet1TableAdapters.proveedorTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents StockTableAdapter As DataSet1TableAdapters.stockTableAdapter
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As DataSet1TableAdapters.ventaTableAdapter
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents GroupBoxIngresarProducto As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxNumeroProveedor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxNombreProveedor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxRUCproveedor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxFactura As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelInsertarProducto As Label
    Friend WithEvents ButtonInsertarProducto As Button
    Friend WithEvents TextBoxPrecioDeVenta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCodigoDeBarras As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCodigo As TextBox
    Friend WithEvents Label41a As Label
    Friend WithEvents ButtonModificarProducto As Button
    Friend WithEvents ButtonIngresarProducto As Button
    Friend WithEvents GroupBoxModificarProducto As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LabelModificarProducto As Label
    Friend WithEvents TextBoxModificarNuevoPrecioDeVenta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxModificarNuevaDescripcion As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxModificarNuevoNombre As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxModificarNuevoCodigoDeBarras As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxModificarNuevoCodigo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBoxFecha As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As DataSet1TableAdapters.clienteTableAdapter
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents IngresoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Ingreso_proveedorBindingSource As BindingSource
    Friend WithEvents Ingreso_proveedorTableAdapter As DataSet1TableAdapters.ingreso_proveedorTableAdapter
    Friend WithEvents Ingreso_proveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents VentaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents LabelIdQueNoSeVe As Label
End Class
