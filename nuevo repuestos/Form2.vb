Public Class Form2
    Private Sub IngresoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.IngresoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ingreso_proveedor' table. You can move, or remove it, as needed.
        Me.Ingreso_proveedorTableAdapter.Fill(Me.DataSet1.ingreso_proveedor)
        'TODO: This line of code loads data into the 'DataSet1.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.DataSet1.venta)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.DataSet1.stock)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ingreso' Puede moverla o quitarla según sea necesario.
        Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
        TextBoxFecha.Text = Today()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonInsertarProducto.Click
        Dim habilitado As Integer
        habilitado = 1

        Dim cantidad_stock As Integer
        cantidad_stock = DataSet1.Tables("stock").Rows.Count

        Dim j As Integer

        If TextBoxCodigo.Text = "" And TextBoxCodigoDeBarras.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete al menos un campo de Código"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxNombre.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete el campo 'Nombre'"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxPrecioDeVenta.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete el Precio de Venta"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxCantidad.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete el campo 'Cantidad'"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxPrecio.Text = "" Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Complete el campo 'Costo'"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If IsNumeric(TextBoxCantidad.Text) = False Then

            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Ingrese un número en 'Cantidad'"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If IsNumeric(TextBoxPrecioDeVenta.Text) = False Then

            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "'Precio De Venta' Incorrecto"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If IsDate(TextBoxFecha.Text) = False Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Ingrese fecha válida"
            LabelInsertarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        ''' SI LOS CAMPOS IMPORTANTES NO ESTAN VACIOS, SE PROCEDE AL INGRESO
        If habilitado = 1 Then

            ''''''''''''''''''''''''''''''''''''''''''''''' ESTA ES LA PARTE DE AÑADIR A LA TABLA STOCK ''''''''''
            Dim codigo_existe As Integer
            codigo_existe = 0

            Dim ya_se_inserto_nueva_fila As Integer
            ya_se_inserto_nueva_fila = 0

            Dim codigo_con_descripcion_existe As Integer
            codigo_con_descripcion_existe = 0

            Dim i As Integer

            '''''''''''''''''''''''''''''''''''''PARTE DEL CÓDIGO es no nulo y NO EXISTE'''''''''''''''''''''''''''''''''''''
            ''' BUSCA SI EXISTE PRODUCTO CON "CODIGO" YA INGRESADO
            For i = 0 To (cantidad_stock - 1)
                '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo")) = False Then
                    'Si el CODIGO ingresado existe'
                    If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxCodigo.Text Then
                        codigo_existe = 1
                    End If
                End If
            Next
            'SI EL CODIGO ES NO NULO, Y NO EXISTE EN LA BASE DE DATOS, SE INSERTA UNA NUEVA FILA
            If codigo_existe = 0 And TextBoxCodigo.Text <> "" Then
                Dim nuevo_stock As DataRow = DataSet1.Tables("stock").NewRow()

                nuevo_stock("codigo") = TextBoxCodigo.Text
                nuevo_stock("codigo_barras") = TextBoxCodigoDeBarras.Text
                nuevo_stock("nombre") = TextBoxNombre.Text
                nuevo_stock("descripcion") = TextBoxDescripcion.Text
                nuevo_stock("precio_venta") = TextBoxPrecioDeVenta.Text

                DataSet1.Tables("stock").Rows.Add(nuevo_stock)

                Validate()
                StockBindingSource.EndEdit()
                StockTableAdapter.Update(DataSet1.stock)

                ya_se_inserto_nueva_fila = 1
            End If
            '''''''''''''''''''''''''''''''''''''/PARTE DEL CÓDIGO'''''''''''''''''''''''''''''''''''''


            '''''''''''''''''''''''''''''''''''''PARTE DEL CÓDIGO es no nulo y  EXISTE'''''''''''''''''''''''''''''''''''''
            If codigo_existe = 1 Then ''esto se toma de la función anterior
                ''' BUSCA SI YA EXISTE CODIGO CON ESA DESCRIPCION
                For i = 0 To (cantidad_stock - 1)
                    '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                    If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo")) = False Then
                        'Si el CODIGO ingresado existe y YA EXISTE ESA DESCRIPCIÓN'
                        If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxCodigo.Text And DataSet1.Tables("stock").Rows(i).Item("descripcion") = TextBoxDescripcion.Text Then
                            codigo_con_descripcion_existe = 1
                        End If
                    End If
                Next

                'SI EL CODIGO EXISTE EN LA BASE DE DATOS, PERO NO CON ESE COMENTARIO, SE INSERTA UNA NUEVA FILA'
                If codigo_con_descripcion_existe = 0 Then

                    Dim nuevo_stock As DataRow = DataSet1.Tables("stock").NewRow()

                    nuevo_stock("codigo") = TextBoxCodigo.Text
                    nuevo_stock("codigo_barras") = TextBoxCodigoDeBarras.Text
                    nuevo_stock("nombre") = TextBoxNombre.Text
                    nuevo_stock("descripcion") = TextBoxDescripcion.Text
                    nuevo_stock("precio_venta") = TextBoxPrecioDeVenta.Text

                    DataSet1.Tables("stock").Rows.Add(nuevo_stock)

                    Validate()
                    StockBindingSource.EndEdit()
                    StockTableAdapter.Update(DataSet1.stock)

                    ya_se_inserto_nueva_fila = 1

                End If
            End If

            '''''''''''''''''''''''''''''''''''''/PARTE DEL CÓDIGO'''''''''''''''''''''''''''''''''''''


            '''''''''''''''''''''''''''''''''''''PARTE DEL CÓDIGO DE BARRAS en no nulo y NO EXISTE'''''''''''''''''''''''''''''''''''''
            If ya_se_inserto_nueva_fila = 0 Then 'si ya se inseró la fila, es innecesario esto, así que se pasa wexd
                ''' BUSCA SI EXISTE PRODUCTO CON "CODIGO DE BARRAS" YA INGRESADO
                For i = 0 To (cantidad_stock - 1)
                    '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                    If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo_barras")) = False Then
                        'Si el CODIGO DE BARRAS ingresado existe'
                        If TextBoxCodigoDeBarras.Text <> "" And DataSet1.Tables("stock").Rows(i).Item("codigo_barras") = TextBoxCodigoDeBarras.Text Then
                            codigo_existe = 1
                        End If
                    End If
                Next

                'SI EL CODIGO DE BARRAS ES NO NULO, Y NO EXISTE EN LA BASE DE DATOS, SE INSERTA UNA NUEVA FILA
                If codigo_existe = 0 And TextBoxCodigoDeBarras.Text <> "" Then
                    Dim nuevo_stock As DataRow = DataSet1.Tables("stock").NewRow()

                    nuevo_stock("codigo") = TextBoxCodigo.Text
                    nuevo_stock("codigo_barras") = TextBoxCodigoDeBarras.Text
                    nuevo_stock("nombre") = TextBoxNombre.Text
                    nuevo_stock("descripcion") = TextBoxDescripcion.Text
                    nuevo_stock("precio_venta") = TextBoxPrecioDeVenta.Text

                    DataSet1.Tables("stock").Rows.Add(nuevo_stock)

                    Validate()
                    StockBindingSource.EndEdit()
                    StockTableAdapter.Update(DataSet1.stock)

                    ya_se_inserto_nueva_fila = 1
                End If
            End If
            '''''''''''''''''''''''''''''''''''''/PARTE DEL CÓDIGO DE BARRAS'''''''''''''''''''''''''''''''''''''



            ''''''''''''''''''''''''''''''''''''''''''''''' ESTA ES LA PARTE DEL PROVEEDOR ''''''''''
            If TextBoxRUCproveedor.Text <> "" Then
                Dim proveedor_existe As Integer
                proveedor_existe = 0

                Dim cantidad_proveedores As Integer
                cantidad_proveedores = DataSet1.Tables("proveedor").Rows.Count

                For i = 0 To (cantidad_proveedores - 1)
                    'Si el PROVEEDOR ingresado existe'
                    If DataSet1.Tables("proveedor").Rows(i).Item("ruc_proveedor") = TextBoxRUCproveedor.Text Then
                        proveedor_existe = 1
                    End If
                Next

                'si el proveedor NO EXISTE, se INSERTA nuevo
                If proveedor_existe = 0 Then

                    Dim nuevo_proveedor As DataRow = DataSet1.Tables("proveedor").NewRow()

                    nuevo_proveedor("ruc_proveedor") = TextBoxRUCproveedor.Text
                    nuevo_proveedor("nombre_proveedor") = TextBoxNombreProveedor.Text
                    nuevo_proveedor("numero_proveedor") = TextBoxNumeroProveedor.Text

                    DataSet1.Tables("proveedor").Rows.Add(nuevo_proveedor)

                    Validate()
                    ProveedorBindingSource.EndEdit()
                    ProveedorTableAdapter.Update(DataSet1.proveedor)

                End If
            End If

            '''cache_update
            Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)
            Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
            Me.StockTableAdapter.Fill(Me.DataSet1.stock)
            '''


            ''''''''''''''''''''''''''''''''''''''''''''''' ESTA ES LA PARTE DE ACTUALIZAR EN CASO DE QUE YA EXISTA Y HAYA ALGUN CAMBIO EN LOS CAMPOS DE STOCK ''''''''''
            Dim es_la_fila_que_queremo As Integer

            For i = 0 To (cantidad_stock - 1)
                es_la_fila_que_queremo = 1

                ''''''ACÁ LO QUE HACEMOS ES CONTROLAR QUE EL CODIGO, CODIGO DE BARRAS Y DESCRIPCION COINCIDAN CON LO QUE ACABAMOS DE INSERTAR, ESE ES NUESTRO PRODUCTO QUE BUSCAMOS
                If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo")) = False Then
                    If DataSet1.Tables("stock").Rows(i).Item("codigo") <> TextBoxCodigo.Text Then
                        es_la_fila_que_queremo = 0
                    End If
                End If
                If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo_barras")) = False Then
                    If DataSet1.Tables("stock").Rows(i).Item("codigo_barras") <> TextBoxCodigoDeBarras.Text Then
                        es_la_fila_que_queremo = 0
                    End If
                End If
                If DataSet1.Tables("stock").Rows(i).Item("descripcion") <> TextBoxDescripcion.Text Then
                    es_la_fila_que_queremo = 0
                End If


                '''SI LA FILA ACTUAL (en este recorrido) ES LA QUE QUEREMOS
                If es_la_fila_que_queremo = 1 Then
                    'DataSet1.Tables("stock").Rows(i).Item("codigo_barras") = TextBoxCodigoDeBarras.Text
                    'DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxCodigo.Text
                    DataSet1.Tables("stock").Rows(i).Item("nombre") = TextBoxNombre.Text
                    'DataSet1.Tables("stock").Rows(i).Item("descripcion") = TextBoxDescripcion.Text
                    DataSet1.Tables("stock").Rows(i).Item("precio_venta") = TextBoxPrecioDeVenta.Text

                    Validate()
                    StockBindingSource.EndEdit()
                    StockTableAdapter.Update(DataSet1.stock)

                End If
            Next


            '''cache_update DOS
            Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)
            Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
            Me.StockTableAdapter.Fill(Me.DataSet1.stock)

            cantidad_stock = DataSet1.Tables("stock").Rows.Count


            ''''''''''''''''''''''''''''''''''''''''''''''' ESTA ES LA PARTE PARA METER EN INGRESO ''''''''''
            Dim es_la_fila_que_queremos As Integer

            For i = 0 To (cantidad_stock - 1)
                es_la_fila_que_queremos = 1

                ''''''ACÁ LO QUE HACEMOS ES CONTROLAR QUE EL CODIGO, CODIGO DE BARRAS Y DESCRIPCION COINCIDAN CON LO QUE ACABAMOS DE INSERTAR, ESE ES NUESTRO PRODUCTO QUE BUSCAMOS
                If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo")) = False Then
                    If DataSet1.Tables("stock").Rows(i).Item("codigo") <> TextBoxCodigo.Text Then
                        es_la_fila_que_queremos = 0
                    End If
                End If
                If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo_barras")) = False Then
                    If DataSet1.Tables("stock").Rows(i).Item("codigo_barras") <> TextBoxCodigoDeBarras.Text Then
                        es_la_fila_que_queremos = 0
                    End If
                End If
                If DataSet1.Tables("stock").Rows(i).Item("descripcion") <> TextBoxDescripcion.Text Then
                    es_la_fila_que_queremos = 0
                End If


                '''SI LA FILA ACTUAL (en este recorrido) ES LA QUE QUEREMOS
                If es_la_fila_que_queremos = 1 Then
                    Dim nuevo_ingreso As DataRow = DataSet1.Tables("ingreso").NewRow()

                    nuevo_ingreso("id_stock") = DataSet1.Tables("stock").Rows(i).Item("id_stock")
                    nuevo_ingreso("cantidad") = TextBoxCantidad.Text
                    nuevo_ingreso("factura_compra") = TextBoxFactura.Text
                    nuevo_ingreso("precio_compra") = TextBoxPrecio.Text
                    nuevo_ingreso("fecha_ingreso") = TextBoxFecha.Text

                    DataSet1.Tables("ingreso").Rows.Add(nuevo_ingreso)

                    Validate()
                    IngresoBindingSource.EndEdit()
                    IngresoTableAdapter.Update(DataSet1.ingreso)
                End If
            Next

            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Insertado Correctamente"
            LabelInsertarProducto.ForeColor = Color.Green

            ButtonInsertarProducto.Focus()

            '''DESPUES DE INSERTAR, UPDATEO
            Me.StockTableAdapter.Fill(Me.DataSet1.stock)

            ''' MOSTRAR TODO '''
            form_manager.productos2stock.Button1.PerformClick()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCodigoDeBarras.TextChanged


    End Sub

    Private Sub TextBoxCodigo_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCodigo.LostFocus

        Dim cantidad_stock As Integer
        cantidad_stock = DataSet1.Tables("stock").Rows.Count

        Dim cantidad_de_codigo As Integer
        cantidad_de_codigo = 0

        If TextBoxCodigo.Text <> "" Then

            For i As Integer = 0 To (cantidad_stock - 1)
                '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo")) = False Then
                    '''SI EL CODIGO EXISTE
                    If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxCodigo.Text Then
                        cantidad_de_codigo = cantidad_de_codigo + 1
                    End If
                End If
            Next

            '''SOLO SI HAY UN PRODUCTO CON ESE CODIGO SE AUTOCOMPLETA (SINO HAY QUE DAR CLIC EN PRODUCTOS2)
            If cantidad_de_codigo = 1 Then
                For i As Integer = 0 To (cantidad_stock - 1)
                    '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                    If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo")) = False Then
                        'Si el PRODUCTO ingresado existe'
                        If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxCodigo.Text Then

                            LabelInsertarProducto.Hide()

                            TextBoxCodigoDeBarras.Text = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
                            TextBoxNombre.Text = DataSet1.Tables("stock").Rows(i).Item("nombre")
                            TextBoxDescripcion.Text = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                            TextBoxPrecioDeVenta.Text = DataSet1.Tables("stock").Rows(i).Item("precio_venta")

                            TextBoxCantidad.Focus()

                        End If
                    End If
                Next
            End If
        End If


    End Sub

    Private Sub TextBoxCodigo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCodigo.TextChanged

        form_manager.productos2stock.DataGridViewStock.Rows.Clear()


        Dim i As Integer
        Dim j As Integer
        j = 0
        Dim cant_cont As Integer
        cant_cont = DataSet1.Tables("stock").Rows.Count - 1


        For i = 0 To cant_cont
            '''SI LA CADENA EXISTE EN EL CODIGO
            If TextBoxCodigo.TextLength <= DataSet1.Tables("stock").Rows(i).Item("codigo").ToString.Length Then
                '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo")) = False Then
                    If TextBoxCodigo.Text.ToString = DataSet1.Tables("stock").Rows(i).Item("codigo").Substring(0, TextBoxCodigo.TextLength) Then

                        form_manager.productos2stock.DataGridViewStock.Rows.Add()

                        form_manager.productos2stock.DataGridViewStock.Item(0, j).Value = DataSet1.Tables("stock").Rows(i).Item("codigo")
                        form_manager.productos2stock.DataGridViewStock.Item(1, j).Value = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
                        form_manager.productos2stock.DataGridViewStock.Item(2, j).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
                        form_manager.productos2stock.DataGridViewStock.Item(3, j).Value = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                        form_manager.productos2stock.DataGridViewStock.Item(4, j).Value = DataSet1.Tables("stock").Rows(i).Item("precio_venta")
                        j = j + 1

                    End If
                End If
            End If
        Next

    End Sub

    Private Sub TextBoxCantidad_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCantidad.LostFocus

    End Sub

    Private Sub TextBoxPrecio_LostFocus(sender As Object, e As EventArgs) Handles TextBoxPrecio.LostFocus

        LabelInsertarProducto.Hide()
        If IsNumeric(TextBoxPrecio.Text) = False Then

            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Ingrese un número en 'Costo'"
            LabelInsertarProducto.ForeColor = Color.Red

            TextBoxPrecio.Text = ""
            'TextBoxPrecio.Focus()
        End If

    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBoxRUCproveedor.LostFocus
        Dim cantidad_proveedores As Integer
        cantidad_proveedores = DataSet1.Tables("proveedor").Rows.Count

        For i As Integer = 0 To (cantidad_proveedores - 1)
            'Si el PROVEEDOR ingresado existe'
            If DataSet1.Tables("proveedor").Rows(i).Item("ruc_proveedor") = TextBoxRUCproveedor.Text Then
                LabelInsertarProducto.Hide()

                TextBoxNombreProveedor.Text = DataSet1.Tables("proveedor").Rows(i).Item("nombre_proveedor")
                TextBoxNumeroProveedor.Text = DataSet1.Tables("proveedor").Rows(i).Item("numero_proveedor")

                ButtonInsertarProducto.Focus()
            End If
        Next

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        TextBoxCodigo.Clear()
        TextBoxCodigoDeBarras.Clear()
        TextBoxNombre.Clear()
        TextBoxDescripcion.Clear()
        TextBoxPrecioDeVenta.Clear()

        TextBoxCantidad.Clear()
        TextBoxFactura.Clear()
        TextBoxPrecio.Clear()

        TextBoxRUCproveedor.Clear()
        TextBoxNombreProveedor.Clear()
        TextBoxNumeroProveedor.Clear()

        LabelInsertarProducto.Visible = False

        TextBoxCodigoDeBarras.Focus()

    End Sub

    Private Sub TextBoxModificarNuevoCodigoDeBarras_TextChanged(sender As Object, e As EventArgs)

        '''''Dim cantidad_stock As Integer
        '''''cantidad_stock = DataSet1.Tables("stock").Rows.Count

        '''''If TextBoxModificarNuevoCodigoDeBarras.Text <> "" Then
        '''''    For i As Integer = 0 To (cantidad_stock - 1)
        '''''        'Si el PRODUCTO ingresado existe'
        '''''        If DataSet1.Tables("stock").Rows(i).Item("codigo_barras") = TextBoxModificarNuevoCodigoDeBarras.Text Then

        '''''            LabelModificarProducto.Hide()

        '''''            TextBoxModificarNuevoCodigo.Text = DataSet1.Tables("stock").Rows(i).Item("codigo")

        '''''            TextBoxModificarNuevoCodigoDeBarras.Text = TextBoxModificarNuevoCodigoDeBarras.Text
        '''''            TextBoxModificarNuevoCodigo.Text = DataSet1.Tables("stock").Rows(i).Item("codigo")
        '''''            TextBoxModificarNuevoNombre.Text = DataSet1.Tables("stock").Rows(i).Item("nombre")
        '''''            TextBoxModificarNuevaDescripcion.Text = DataSet1.Tables("stock").Rows(i).Item("descripcion")
        '''''            TextBoxModificarNuevoPrecioDeVenta.Text = DataSet1.Tables("stock").Rows(i).Item("precio_venta")


        '''''            'TextBoxCantidad.Focus()
        '''''        End If
        '''''    Next

        '''''End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ''TextBoxModificarNuevoCodigoDeBarras.Clear()
        ''TextBoxModificarNuevoCodigo.Clear()

        TextBoxModificarNuevoCodigoDeBarras.Clear()
        TextBoxModificarNuevoCodigo.Clear()
        TextBoxModificarNuevoNombre.Clear()
        TextBoxModificarNuevaDescripcion.Clear()
        TextBoxModificarNuevoPrecioDeVenta.Clear()

        LabelModificarProducto.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim habilitado As Integer
        habilitado = 1

        LabelModificarProducto.Hide()

        If TextBoxModificarNuevoCodigo.Text = "" And TextBoxModificarNuevoCodigoDeBarras.Text = "" Then
            LabelModificarProducto.Show()
            LabelModificarProducto.Text = "Complete al menos un campo de Código"
            LabelModificarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxModificarNuevoNombre.Text = "" Then
            LabelModificarProducto.Show()
            LabelModificarProducto.Text = "Complete el campo 'Nombre'"
            LabelModificarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        If TextBoxModificarNuevoPrecioDeVenta.Text = "" Then
            LabelModificarProducto.Show()
            LabelModificarProducto.Text = "Complete el Precio de Venta"
            LabelModificarProducto.ForeColor = Color.Red

            habilitado = 0
        End If

        Dim existe_codigo As Integer
        existe_codigo = 0


        If habilitado = 1 Then
            Dim cantidad_stock As Integer
            cantidad_stock = DataSet1.Tables("stock").Rows.Count

            Dim id_stock_nuevo As Integer
            Dim id_stock_viejo As Integer

            If TextBoxModificarNuevoCodigo.Text <> "" Then

                For i As Integer = 0 To (cantidad_stock - 1)
                    'si hubo una modificacion en el codigo
                    If TextBoxModificarNuevoCodigo.Text <> TextBoxModificarNuevoCodigo.Text Then
                        'Si el nuevo CODIGO ingresado YA existe'
                        If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxModificarNuevoCodigo.Text Then
                            existe_codigo = 1
                            id_stock_nuevo = DataSet1.Tables("stock").Rows(i).Item("id_stock")
                        End If
                    End If
                Next

                For i As Integer = 0 To (cantidad_stock - 1)
                    'buscar cual es el id_stock a reemplazar
                    If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxModificarNuevoCodigo.Text Then
                        id_stock_viejo = DataSet1.Tables("stock").Rows(i).Item("id_stock")
                    End If
                Next

                ''' si el codigo existe
                ''' no inserto, cambio todos los id_stock del INGRESO al id_stock del codigo
                ''' y se borra la linea que se queria "modificar"

                If existe_codigo = 1 Then
                    Dim cantidad_ingreso As Integer
                    cantidad_ingreso = DataSet1.Tables("ingreso").Rows.Count

                    '''MODIFICACION EN TABLA STOCK
                    For i = 0 To (cantidad_ingreso - 1)
                        If DataSet1.Tables("ingreso").Rows(i).Item("id_stock") = id_stock_viejo Then 'si es que encuentra en INGRESO el codigo viejo
                            'cambia al id_stock nuevo
                            DataSet1.Tables("ingreso").Rows(i).Item("id_stock") = id_stock_nuevo

                            Validate()
                            IngresoBindingSource.EndEdit()
                            IngresoTableAdapter.Update(DataSet1.ingreso)
                        End If
                    Next

                    '''MODIFICACION EN TABLA VENTA
                    Dim cantidad_venta As Integer
                    cantidad_venta = DataSet1.Tables("venta").Rows.Count

                    For i = 0 To (cantidad_venta - 1)
                        If DataSet1.Tables("venta").Rows(i).Item("id_stock") = id_stock_viejo Then 'si es que encuentra en VENTA el codigo viejo
                            'cambia al id_stock nuevo
                            DataSet1.Tables("venta").Rows(i).Item("id_stock") = id_stock_nuevo

                            Validate()
                            VentaBindingSource.EndEdit()
                            VentaTableAdapter.Update(DataSet1.venta)
                        End If
                    Next

                    '''ESTA PARTE ES PARA BORRAR LA LINEA EN TABLA INGRESO QUE SE QUERIA MODIFICAR
                    cantidad_stock = DataSet1.Tables("stock").Rows.Count

                    For i = 0 To (cantidad_stock - 1)
                        If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxModificarNuevoCodigo.Text Then

                            DataSet1.Tables("stock").Rows(i).Delete()
                        End If
                    Next
                    Validate()
                    StockBindingSource.EndEdit()
                    StockTableAdapter.Update(DataSet1.stock)

                Else    'si el codigo insertado/modificado NO existe, se modifica direcamente en la tabla STOCK

                    'Dim cantidad_stock As Integer
                    cantidad_stock = DataSet1.Tables("stock").Rows.Count

                    For i As Integer = 0 To (cantidad_stock - 1)
                        If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxModificarNuevoCodigo.Text Then

                            DataSet1.Tables("stock").Rows(i).Item("codigo_barras") = TextBoxModificarNuevoCodigoDeBarras.Text
                            DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxModificarNuevoCodigo.Text
                            DataSet1.Tables("stock").Rows(i).Item("nombre") = TextBoxModificarNuevoNombre.Text
                            DataSet1.Tables("stock").Rows(i).Item("descripcion") = TextBoxModificarNuevaDescripcion.Text
                            DataSet1.Tables("stock").Rows(i).Item("precio_venta") = TextBoxModificarNuevoPrecioDeVenta.Text

                        End If
                    Next

                    Validate()
                    StockBindingSource.EndEdit()
                    StockTableAdapter.Update(DataSet1.stock)


                End If

            Else ' si el codigo es vacio
                'Dim cantidad_stock As Integer
                cantidad_stock = DataSet1.Tables("stock").Rows.Count

                For i As Integer = 0 To (cantidad_stock - 1)
                    If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxModificarNuevoCodigo.Text Then

                        DataSet1.Tables("stock").Rows(i).Item("codigo_barras") = TextBoxModificarNuevoCodigoDeBarras.Text
                        DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxModificarNuevoCodigo.Text
                        DataSet1.Tables("stock").Rows(i).Item("nombre") = TextBoxModificarNuevoNombre.Text
                        DataSet1.Tables("stock").Rows(i).Item("descripcion") = TextBoxModificarNuevaDescripcion.Text
                        DataSet1.Tables("stock").Rows(i).Item("precio_venta") = TextBoxModificarNuevoPrecioDeVenta.Text

                    End If
                Next

                Validate()
                StockBindingSource.EndEdit()
                StockTableAdapter.Update(DataSet1.stock)

            End If

            LabelModificarProducto.Show()
            LabelModificarProducto.Text = "Modificardo Correctamente"
            LabelModificarProducto.ForeColor = Color.Green

            Button3.Focus()

            '''DESPUES DE MODIFICAR
            '''UPDATEO
            'TODO: esta línea de código carga datos en la tabla 'DataSet1.stock' Puede moverla o quitarla según sea necesario.
            Me.StockTableAdapter.Fill(Me.DataSet1.stock)

            '''MOSTRAR TODO'''
            form_manager.productos2stock.Button1.PerformClick()

        End If
    End Sub

    Private Sub TextBoxModificarNuevoCodigo_TextChanged(sender As Object, e As EventArgs)

        Dim cantidad_stock As Integer
        cantidad_stock = DataSet1.Tables("stock").Rows.Count

        If TextBoxModificarNuevoCodigo.Text <> "" Then

            For i As Integer = 0 To (cantidad_stock - 1)
                'Si el PRODUCTO ingresado existe'
                If DataSet1.Tables("stock").Rows(i).Item("codigo") = TextBoxModificarNuevoCodigo.Text Then

                    LabelModificarProducto.Hide()

                    TextBoxModificarNuevoCodigoDeBarras.Text = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")

                    TextBoxModificarNuevoCodigo.Text = DataSet1.Tables("stock").Rows(i).Item("codigo")
                    TextBoxModificarNuevoCodigoDeBarras.Text = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
                    TextBoxModificarNuevoNombre.Text = DataSet1.Tables("stock").Rows(i).Item("nombre")
                    TextBoxModificarNuevaDescripcion.Text = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                    TextBoxModificarNuevoPrecioDeVenta.Text = DataSet1.Tables("stock").Rows(i).Item("precio_venta")

                    '                    TextBoxCantidad.Focus()

                End If
            Next

        End If


    End Sub

    Private Sub ButtonIngresarProducto_Click(sender As Object, e As EventArgs) Handles ButtonIngresarProducto.Click

        GroupBoxIngresarProducto.Show()
        GroupBoxModificarProducto.Hide()

        '''BORRAR CAMPOS

        TextBoxCodigo.Clear()
        TextBoxCodigoDeBarras.Clear()
        TextBoxNombre.Clear()
        TextBoxDescripcion.Clear()
        TextBoxPrecioDeVenta.Clear()

        TextBoxCantidad.Clear()
        TextBoxFactura.Clear()
        TextBoxPrecio.Clear()

        TextBoxRUCproveedor.Clear()
        TextBoxNombreProveedor.Clear()
        TextBoxNumeroProveedor.Clear()

        LabelInsertarProducto.Visible = False

        TextBoxCodigoDeBarras.Focus()

        '''FECHA HOY
        TextBoxFecha.Text = Today()

    End Sub

    Private Sub ButtonModificarProducto_Click(sender As Object, e As EventArgs) Handles ButtonModificarProducto.Click
        GroupBoxIngresarProducto.Hide()
        GroupBoxModificarProducto.Show()

        '''BORRAR CAMPOS

        TextBoxModificarNuevoCodigoDeBarras.Clear()
        TextBoxModificarNuevoCodigo.Clear()

        TextBoxModificarNuevoCodigoDeBarras.Clear()
        TextBoxModificarNuevoCodigo.Clear()
        TextBoxModificarNuevoNombre.Clear()
        TextBoxModificarNuevaDescripcion.Clear()
        TextBoxModificarNuevoPrecioDeVenta.Clear()

        LabelModificarProducto.Visible = False
    End Sub

    Private Sub ButtonInsertarProducto_LostFocus(sender As Object, e As EventArgs) Handles ButtonInsertarProducto.LostFocus

        LabelInsertarProducto.Hide()
    End Sub

    Private Sub Button3_LostFocus(sender As Object, e As EventArgs) Handles Button3.LostFocus
        LabelModificarProducto.Hide()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxFecha.TextChanged

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBoxFecha.LostFocus

        'LabelInsertarProducto.Hide()
        If IsDate(TextBoxFecha.Text) = False Then
            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Ingrese fecha válida"
            LabelInsertarProducto.ForeColor = Color.Red

            'TextBoxFecha.Focus()
        End If

    End Sub

    Private Sub TextBoxDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDescripcion.TextChanged

        form_manager.productos2stock.DataGridViewStock.Rows.Clear()


        Dim i As Integer
        Dim j As Integer
        j = 0
        Dim cant_cont As Integer
        cant_cont = DataSet1.Tables("stock").Rows.Count - 1


        For i = 0 To cant_cont
            '''SI LA CADENA EXISTE EN DESCRIPCION
            If TextBoxDescripcion.TextLength <= DataSet1.Tables("stock").Rows(i).Item("descripcion").ToString.Length Then
                If TextBoxDescripcion.Text.ToString = DataSet1.Tables("stock").Rows(i).Item("descripcion").Substring(0, TextBoxDescripcion.TextLength) Then

                    form_manager.productos2stock.DataGridViewStock.Rows.Add()

                    form_manager.productos2stock.DataGridViewStock.Item(0, j).Value = DataSet1.Tables("stock").Rows(i).Item("codigo")
                    form_manager.productos2stock.DataGridViewStock.Item(1, j).Value = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
                    form_manager.productos2stock.DataGridViewStock.Item(2, j).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
                    form_manager.productos2stock.DataGridViewStock.Item(3, j).Value = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                    form_manager.productos2stock.DataGridViewStock.Item(4, j).Value = DataSet1.Tables("stock").Rows(i).Item("precio_venta")
                    j = j + 1

                End If
            End If
        Next


    End Sub

    Private Sub TextBoxCantidad_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCantidad.TextChanged
        'LabelInsertarProducto.Hide()
        If IsNumeric(TextBoxCantidad.Text) = False Then

            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "Ingrese un número en 'Cantidad'"
            LabelInsertarProducto.ForeColor = Color.Red

            'TextBoxCantidad.Text = ""
            'TextBoxCantidad.Focus()
        Else
            LabelInsertarProducto.Hide()
        End If
    End Sub

    Private Sub TextBoxCantidad_GotFocus(sender As Object, e As EventArgs) Handles TextBoxCantidad.GotFocus

        '''MOSTRAR TODO'''
        form_manager.productos2stock.DataGridViewStock.Rows.Clear()

        Dim i As Integer
        Dim j As Integer
        j = 0
        Dim cant_cont As Integer
        cant_cont = DataSet1.Tables("stock").Rows.Count - 1


        For i = 0 To cant_cont

            form_manager.productos2stock.DataGridViewStock.Rows.Add()

            form_manager.productos2stock.DataGridViewStock.Item(0, i).Value = DataSet1.Tables("stock").Rows(i).Item("codigo")
            form_manager.productos2stock.DataGridViewStock.Item(1, i).Value = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
            form_manager.productos2stock.DataGridViewStock.Item(2, i).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
            form_manager.productos2stock.DataGridViewStock.Item(3, i).Value = DataSet1.Tables("stock").Rows(i).Item("descripcion")
            form_manager.productos2stock.DataGridViewStock.Item(4, i).Value = DataSet1.Tables("stock").Rows(i).Item("precio_venta")

        Next

    End Sub

    Private Sub TextBoxCodigoDeBarras_LostFocus(sender As Object, e As EventArgs) Handles TextBoxCodigoDeBarras.LostFocus


        Dim cantidad_stock As Integer
        cantidad_stock = DataSet1.Tables("stock").Rows.Count

        If TextBoxCodigoDeBarras.Text <> "" Then
            For i As Integer = 0 To (cantidad_stock - 1)
                '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo_barras")) = False Then
                    'Si el PRODUCTO ingresado existe'
                    If DataSet1.Tables("stock").Rows(i).Item("codigo_barras") = TextBoxCodigoDeBarras.Text Then

                        LabelInsertarProducto.Hide()

                        TextBoxCodigo.Text = DataSet1.Tables("stock").Rows(i).Item("codigo")
                        TextBoxNombre.Text = DataSet1.Tables("stock").Rows(i).Item("nombre")
                        TextBoxDescripcion.Text = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                        TextBoxPrecioDeVenta.Text = DataSet1.Tables("stock").Rows(i).Item("precio_venta")


                        TextBoxCantidad.Focus()
                    End If
                End If
            Next

        End If

    End Sub

    Private Sub TextBoxPrecioDeVenta_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrecioDeVenta.TextChanged
        'LabelInsertarProducto.Hide()
        If IsNumeric(TextBoxPrecioDeVenta.Text) = False Then

            LabelInsertarProducto.Show()
            LabelInsertarProducto.Text = "'Precio De Venta' Incorrecto"
            LabelInsertarProducto.ForeColor = Color.Red

            'TextBoxCantidad.Text = ""
            'TextBoxCantidad.Focus()
        Else
            LabelInsertarProducto.Hide()
        End If
    End Sub

    Private Sub TextBoxFactura_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFactura.TextChanged

    End Sub

    Private Sub TextBoxPrecio_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrecio.TextChanged

    End Sub
End Class