Public Class Informes
    Private Sub StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ingreso' table. You can move, or remove it, as needed.
        Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
        'TODO: This line of code loads data into the 'DataSet1.venta' table. You can move, or remove it, as needed.
        Me.VentaTableAdapter.Fill(Me.DataSet1.venta)
        'TODO: This line of code loads data into the 'DataSet1.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.DataSet1.stock)

    End Sub

    Private Function calcular_cantidad_comprada(id_stock As Integer)
        Dim i As Integer
        Dim cantidad
        cantidad = DataSet1.Tables("ingreso").Rows.Count - 1
        Dim sum As Integer
        sum = 0

        For i = 0 To cantidad
            If DataSet1.Tables("Ingreso").Rows(i).Item("id_stock") = id_stock Then
                sum = sum + DataSet1.Tables("Ingreso").Rows(i).Item("cantidad")
            End If
        Next

        Return sum


    End Function

    Private Function calcular_cantidad_comprada2(id_stock As Integer)
        Dim i As Integer
        Dim cantidad
        cantidad = DataSet1.Tables("ingreso").Rows.Count - 1
        Dim sum As Integer
        sum = 0

        For i = 0 To cantidad
            If DataSet1.Tables("Ingreso").Rows(i).Item("id_stock") = id_stock Then
                If DataSet1.Tables("ingreso").Rows(i).Item("fecha_ingreso") >= DateTimePicker1gasto.Value And DataSet1.Tables("ingreso").Rows(i).Item("fecha_ingreso") <= DateTimePicker2gasto.Value Then
                    sum = sum + DataSet1.Tables("Ingreso").Rows(i).Item("cantidad")
                End If
            End If
        Next

        Return sum


    End Function

    Private Function calcular_cantidad_vendida(id_stock As Integer)
        Dim i As Integer
        Dim cantidad
        cantidad = DataSet1.Tables("Venta").Rows.Count - 1
        Dim sum As Integer
        sum = 0

        For i = 0 To cantidad
            If DataSet1.Tables("Venta").Rows(i).Item("id_stock") = id_stock Then
                sum = sum + DataSet1.Tables("Venta").Rows(i).Item("cantidad_venta")
            End If
        Next

        Return sum


    End Function


    Private Function calcular_cantidad_vendida2(id_stock As Integer)
        Dim i As Integer
        Dim cantidad
        cantidad = DataSet1.Tables("Venta").Rows.Count - 1
        Dim sum As Integer
        sum = 0

        For i = 0 To cantidad
            If DataSet1.Tables("Venta").Rows(i).Item("id_stock") = id_stock Then
                If DataSet1.Tables("venta").Rows(i).Item("fecha_venta") >= DateTimePicker1gasto.Value And DataSet1.Tables("venta").Rows(i).Item("fecha_venta") <= DateTimePicker2gasto.Value Then
                    sum = sum + DataSet1.Tables("Venta").Rows(i).Item("cantidad_venta")
                End If
            End If
        Next

        Return sum


    End Function

    Private Function precio_compra(id_stock As Integer)
        Dim i As Integer
        Dim precio As Integer
        Dim ultimo As Integer
        precio = 0


        For i = 0 To DataSet1.Tables("Ingreso").Rows.Count - 1
            If DataSet1.Tables("Ingreso").Rows(i).Item("id_stock") = id_stock Then
                precio = DataSet1.Tables("Ingreso").Rows(i).Item("precio_compra")
            End If
        Next
        Return precio

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer

        Dim cantidad_productos As Integer
        Dim j As Integer

        cantidad_productos = DataSet1.Tables("Stock").Rows.Count - 1
        informe_ventas.Rows.Clear()

        For i = 0 To cantidad_productos
            informe_ventas.Rows.Add()
            informe_ventas.Item(0, i).Value = DataSet1.Tables("Stock").Rows(i).Item("Codigo")
            informe_ventas.Item(1, i).Value = DataSet1.Tables("Stock").Rows(i).Item("nombre")
            informe_ventas.Item(2, i).Value = DataSet1.Tables("Stock").Rows(i).Item("descripcion")
            informe_ventas.Item(3, i).Value = calcular_cantidad_vendida(DataSet1.Tables("Stock").Rows(i).Item("id_stock"))
            informe_ventas.Item(4, i).Value = calcular_cantidad_comprada(DataSet1.Tables("Stock").Rows(i).Item("id_stock"))
            informe_ventas.Item(5, i).Value = precio_compra(DataSet1.Tables("Stock").Rows(i).Item("id_stock"))
            informe_ventas.Item(6, i).Value = DataSet1.Tables("Stock").Rows(i).Item("Precio_Venta")

            informe_ventas.Item(7, i).Value = -informe_ventas.Item(4, i).Value * informe_ventas.Item(5, i).Value + informe_ventas.Item(6, i).Value * informe_ventas.Item(3, i).Value

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        product.Show()

    End Sub

    Private Sub DateTimePicker1gasto_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1gasto.ValueChanged
        Dim i As Integer

        Dim cantidad_productos As Integer
        Dim j As Integer

        cantidad_productos = DataSet1.Tables("Stock").Rows.Count - 1
        informe_ventas.Rows.Clear()

        For i = 0 To cantidad_productos
            informe_ventas.Rows.Add()
            informe_ventas.Item(0, i).Value = DataSet1.Tables("Stock").Rows(i).Item("Codigo")
            informe_ventas.Item(1, i).Value = DataSet1.Tables("Stock").Rows(i).Item("nombre")
            informe_ventas.Item(2, i).Value = DataSet1.Tables("Stock").Rows(i).Item("descripcion")
            informe_ventas.Item(3, i).Value = calcular_cantidad_vendida2(DataSet1.Tables("Stock").Rows(i).Item("id_stock"))
            informe_ventas.Item(4, i).Value = calcular_cantidad_comprada2(DataSet1.Tables("Stock").Rows(i).Item("id_stock"))
            informe_ventas.Item(5, i).Value = precio_compra(DataSet1.Tables("Stock").Rows(i).Item("id_stock"))
            informe_ventas.Item(6, i).Value = DataSet1.Tables("Stock").Rows(i).Item("Precio_Venta")

            informe_ventas.Item(7, i).Value = -informe_ventas.Item(4, i).Value * informe_ventas.Item(5, i).Value + informe_ventas.Item(6, i).Value * informe_ventas.Item(3, i).Value

        Next

    End Sub

    Private Sub DateTimePicker2gasto_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2gasto.ValueChanged

        Dim i As Integer

        Dim cantidad_productos As Integer
        Dim j As Integer

        cantidad_productos = DataSet1.Tables("Stock").Rows.Count - 1
        informe_ventas.Rows.Clear()

        For i = 0 To cantidad_productos
            informe_ventas.Rows.Add()
            informe_ventas.Item(0, i).Value = DataSet1.Tables("Stock").Rows(i).Item("Codigo")
            informe_ventas.Item(1, i).Value = DataSet1.Tables("Stock").Rows(i).Item("nombre")
            informe_ventas.Item(2, i).Value = DataSet1.Tables("Stock").Rows(i).Item("descripcion")
            informe_ventas.Item(3, i).Value = calcular_cantidad_vendida2(DataSet1.Tables("Stock").Rows(i).Item("id_stock"))
            informe_ventas.Item(4, i).Value = calcular_cantidad_comprada2(DataSet1.Tables("Stock").Rows(i).Item("id_stock"))
            informe_ventas.Item(5, i).Value = precio_compra(DataSet1.Tables("Stock").Rows(i).Item("id_stock"))
            informe_ventas.Item(6, i).Value = DataSet1.Tables("Stock").Rows(i).Item("Precio_Venta")

            informe_ventas.Item(7, i).Value = -informe_ventas.Item(4, i).Value * informe_ventas.Item(5, i).Value + informe_ventas.Item(6, i).Value * informe_ventas.Item(3, i).Value

        Next


    End Sub
End Class