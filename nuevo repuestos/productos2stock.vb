Public Class productos2stock
    Private Sub productos2stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.DataSet1.stock)


        '''MOSTRAR TODO'''
        DataGridViewStock.Rows.Clear()


        Dim i As Integer
        Dim j As Integer
        j = 0
        Dim cant_cont As Integer
        cant_cont = DataSet1.Tables("stock").Rows.Count - 1


        For i = 0 To cant_cont

            DataGridViewStock.Rows.Add()

            DataGridViewStock.Item(0, i).Value = DataSet1.Tables("stock").Rows(i).Item("codigo")
            DataGridViewStock.Item(1, i).Value = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
            DataGridViewStock.Item(2, i).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
            DataGridViewStock.Item(3, i).Value = DataSet1.Tables("stock").Rows(i).Item("descripcion")
            DataGridViewStock.Item(4, i).Value = DataSet1.Tables("stock").Rows(i).Item("precio_venta")

        Next

    End Sub

    Private Sub StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub StockBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        DataGridViewStock.Rows.Clear()


        Dim i As Integer
        Dim j As Integer
        j = 0
        Dim cant_cont As Integer
        cant_cont = DataSet1.Tables("stock").Rows.Count - 1


        For i = 0 To cant_cont
            '''SI LA CADENA EXISTE EN EL NOMBRE
            If TextBoxBuscar.TextLength <= DataSet1.Tables("stock").Rows(i).Item("nombre").ToString.Length Then
                If TextBoxBuscar.Text.ToString = DataSet1.Tables("stock").Rows(i).Item("nombre").Substring(0, TextBoxBuscar.TextLength) Then

                    DataGridViewStock.Rows.Add()

                    DataGridViewStock.Item(0, j).Value = DataSet1.Tables("stock").Rows(i).Item("codigo")
                    DataGridViewStock.Item(1, j).Value = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
                    DataGridViewStock.Item(2, j).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
                    DataGridViewStock.Item(3, j).Value = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                    DataGridViewStock.Item(4, j).Value = DataSet1.Tables("stock").Rows(i).Item("precio_venta")
                    j = j + 1
                Else
                    '''SI LA CADENA EXISTE EN DESCRIPCION
                    If TextBoxBuscar.TextLength <= DataSet1.Tables("stock").Rows(i).Item("descripcion").ToString.Length Then
                        If TextBoxBuscar.Text.ToString = DataSet1.Tables("stock").Rows(i).Item("descripcion").Substring(0, TextBoxBuscar.TextLength) Then
                            DataGridViewStock.Rows.Add()

                            DataGridViewStock.Item(0, j).Value = DataSet1.Tables("stock").Rows(i).Item("codigo")
                            DataGridViewStock.Item(1, j).Value = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
                            DataGridViewStock.Item(2, j).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
                            DataGridViewStock.Item(3, j).Value = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                            DataGridViewStock.Item(4, j).Value = DataSet1.Tables("stock").Rows(i).Item("precio_venta")
                            j = j + 1

                        End If
                    End If
                End If
            Else
                '''SI LA CADENA EXISTE EN DESCRIPCION
                If TextBoxBuscar.TextLength <= DataSet1.Tables("stock").Rows(i).Item("descripcion").ToString.Length Then
                    If TextBoxBuscar.Text.ToString = DataSet1.Tables("stock").Rows(i).Item("descripcion").Substring(0, TextBoxBuscar.TextLength) Then
                        DataGridViewStock.Rows.Add()

                        DataGridViewStock.Item(0, j).Value = DataSet1.Tables("stock").Rows(i).Item("codigo")
                        DataGridViewStock.Item(1, j).Value = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
                        DataGridViewStock.Item(2, j).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
                        DataGridViewStock.Item(3, j).Value = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                        DataGridViewStock.Item(4, j).Value = DataSet1.Tables("stock").Rows(i).Item("precio_venta")
                        j = j + 1

                    End If
                End If
            End If
        Next



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '''UPDATEO
        StockTableAdapter.Fill(Me.DataSet1.stock)

        '''MOSTRAR TODO'''
        DataGridViewStock.Rows.Clear()


        Dim i As Integer
        Dim j As Integer
        j = 0
        Dim cant_cont As Integer
        cant_cont = DataSet1.Tables("stock").Rows.Count - 1


        For i = 0 To cant_cont

            DataGridViewStock.Rows.Add()

            DataGridViewStock.Item(0, i).Value = DataSet1.Tables("stock").Rows(i).Item("codigo")
            DataGridViewStock.Item(1, i).Value = DataSet1.Tables("stock").Rows(i).Item("codigo_barras")
            DataGridViewStock.Item(2, i).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
            DataGridViewStock.Item(3, i).Value = DataSet1.Tables("stock").Rows(i).Item("descripcion")
            DataGridViewStock.Item(4, i).Value = DataSet1.Tables("stock").Rows(i).Item("precio_venta")

        Next

    End Sub

    Private Sub DataGridViewStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStock.CellContentClick

    End Sub

    Private Sub DataGridViewStock_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewStock.DoubleClick

    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

        Button2.PerformClick()

    End Sub

    Private Sub DataGridViewStock_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStock.CellDoubleClick

        If DataGridViewStock.Rows.Count <> 0 Then
            Dim index As Integer
            index = DataGridViewStock.CurrentRow.Index

            If form_manager.stock.GroupBoxIngresarProducto.Visible = True Then
                '''EN CASO DE QUE SEA "INSERTAR PRODUCTO"
                Dim varCodigoDeBarras As String
                Dim varCodigo As String
                Dim varNombre As String
                Dim varDescripcion As String
                Dim varPrecioDeVenta As Integer

                '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                If IsDBNull(DataGridViewStock.Item(1, index).Value) = False Then
                    varCodigoDeBarras = DataGridViewStock.Item(1, index).Value
                End If
                '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                If IsDBNull(DataGridViewStock.Item(0, index).Value) = False Then
                    varCodigo = DataGridViewStock.Item(0, index).Value
                End If
                varNombre = DataGridViewStock.Item(2, index).Value
                varDescripcion = DataGridViewStock.Item(3, index).Value
                varPrecioDeVenta = DataGridViewStock.Item(4, index).Value

                form_manager.stock.TextBoxCodigoDeBarras.Text = varCodigoDeBarras
                form_manager.stock.TextBoxCodigo.Text = varCodigo
                form_manager.stock.TextBoxNombre.Text = varNombre
                form_manager.stock.TextBoxDescripcion.Text = varDescripcion
                form_manager.stock.TextBoxPrecioDeVenta.Text = varPrecioDeVenta

                form_manager.stock.TextBoxCantidad.Focus()
            Else
                '''EN CASO DE QUE SEA "MODIFICAR PRODUCTO"
                Dim varCodigoDeBarras As String
                Dim varCodigo As String
                Dim varNombre As String
                Dim varDescripcion As String
                Dim varPrecioDeVenta As Integer

                '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                If IsDBNull(DataGridViewStock.Item(1, index).Value) = False Then
                    varCodigoDeBarras = DataGridViewStock.Item(1, index).Value
                End If
                '''SE PONE ESTO PORQUE SI ES NULL EN LA BD EXPLOTA, ENTONCES SALTAMOS ESE DBNULL
                If IsDBNull(DataGridViewStock.Item(0, index).Value) = False Then
                    varCodigo = DataGridViewStock.Item(0, index).Value
                End If
                varNombre = DataGridViewStock.Item(2, index).Value
                varDescripcion = DataGridViewStock.Item(3, index).Value
                varPrecioDeVenta = DataGridViewStock.Item(4, index).Value

                form_manager.stock.TextBoxModificarNuevoCodigoDeBarras.Text = varCodigoDeBarras
                form_manager.stock.TextBoxModificarNuevoCodigo.Text = varCodigo
                form_manager.stock.TextBoxModificarNuevoNombre.Text = varNombre
                form_manager.stock.TextBoxModificarNuevaDescripcion.Text = varDescripcion
                form_manager.stock.TextBoxModificarNuevoPrecioDeVenta.Text = varPrecioDeVenta


                ''''ESTA ES LA PARTE PARA GUARDAR EL id_stock
                Dim cantidad_stock As Integer
                cantidad_stock = DataSet1.Tables("stock").Rows.Count

                Dim es_la_fila_que_queremo As Integer
                For i = 0 To (cantidad_stock - 1)
                    es_la_fila_que_queremo = 1

                    ''''''ACÁ LO QUE HACEMOS ES CONTROLAR QUE EL CODIGO, CODIGO DE BARRAS Y DESCRIPCION COINCIDAN CON LO QUE ACABAMOS DE INSERTAR, ESE ES NUESTRO PRODUCTO QUE BUSCAMOS
                    If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo")) = False And IsDBNull(DataGridViewStock.Item(0, index).Value) = False Then
                        If DataSet1.Tables("stock").Rows(i).Item("codigo") <> DataGridViewStock.Item(0, index).Value Then
                            es_la_fila_que_queremo = 0
                        End If
                    End If
                    If IsDBNull(DataSet1.Tables("stock").Rows(i).Item("codigo_barras")) = False And IsDBNull(DataGridViewStock.Item(1, index).Value) = False Then
                        If DataSet1.Tables("stock").Rows(i).Item("codigo_barras") <> DataGridViewStock.Item(1, index).Value Then
                            es_la_fila_que_queremo = 0
                        End If
                    End If
                    If DataSet1.Tables("stock").Rows(i).Item("descripcion") <> DataGridViewStock.Item(3, index).Value Then
                        es_la_fila_que_queremo = 0
                    End If


                    '''SI LA FILA ACTUAL (en este recorrido) ES LA QUE QUEREMOS
                    If es_la_fila_que_queremo = 1 Then
                        form_manager.stock.LabelIdQueNoSeVe.Text = DataSet1.Tables("stock").Rows(i).Item("id_stock")
                    End If
                Next



            End If
        End If



    End Sub
End Class