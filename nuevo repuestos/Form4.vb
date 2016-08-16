Public Class info_p_falta
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.DataSet1.stock)
        'TODO: This line of code loads data into the 'DataSet1.venta' table. You can move, or remove it, as needed.
        Me.VentaTableAdapter.Fill(Me.DataSet1.venta)
        'TODO: This line of code loads data into the 'DataSet1.ingreso' table. You can move, or remove it, as needed.
        Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)

        'TODO: This line of code loads data into the 'DataSet1.ingreso' table. You can move, or remove it, as needed.
        Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
        'TODO: This line of code loads data into the 'DataSet1.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.DataSet1.stock)
        'TODO: This line of code loads data into the 'DataSet1.venta' table. You can move, or remove it, as needed.
        Me.VentaTableAdapter.Fill(Me.DataSet1.venta)

        Dim string_salida As String
        string_salida = "CANTIDAD" + vbTab + vbTab + "NOMBRE" + vbTab + vbTab + vbTab + "DESCRIPCIÓN" + vbCr


        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        k = 0


        Dim cantidad_en_stock As Integer
        cantidad_en_stock = 0

        Dim cantidad_stock As Integer
        cantidad_stock = DataSet1.Tables("stock").Rows.Count - 1

        Dim cantidad_ingreso As Integer
        cantidad_ingreso = DataSet1.Tables("ingreso").Rows.Count - 1

        Dim cantidad_venta As Integer
        cantidad_venta = DataSet1.Tables("venta").Rows.Count - 1

        '''HACE ESTO POR CADA ITEM DEL STOCK
        For i = 0 To cantidad_stock
            '  MsgBox("entra al for i")
            '''SUMA LOS INGRESOS
            For j = 0 To cantidad_ingreso
                ' MsgBox("entra al For ingresa")
                If DataSet1.Tables("stock").Rows(i).Item("id_stock") = DataSet1.Tables("ingreso").Rows(j).Item("id_stock") Then
                    cantidad_en_stock = cantidad_en_stock + DataSet1.Tables("ingreso").Rows(j).Item("cantidad")
                End If
            Next

            '''RESTA LOS EGRESOS
            For j = 0 To cantidad_venta
                'MsgBox("entra al For venta")
                If DataSet1.Tables("stock").Rows(i).Item("id_stock") = DataSet1.Tables("venta").Rows(j).Item("id_stock") Then
                    cantidad_en_stock = cantidad_en_stock - DataSet1.Tables("venta").Rows(j).Item("cantidad_venta")
                End If
            Next

            '''SI LA CANTIDAD DEL STOCK(i) ES INSUFICIENTE, LO EXPLICITA EN LA TABLA
            If cantidad_en_stock <= 2 Then
                'MsgBox(DataSet1.Tables("stock").Rows(i).Item("nombre"))
                DataGridViewFalta.Rows.Add()

                DataGridViewFalta.Item(0, k).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
                DataGridViewFalta.Item(1, k).Value = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                DataGridViewFalta.Item(2, k).Value = cantidad_en_stock
                k = k + 1

                string_salida = string_salida + cantidad_en_stock.ToString + vbTab + vbTab + vbTab + DataSet1.Tables("stock").Rows(i).Item("nombre").ToString + vbTab + vbTab + vbTab + DataSet1.Tables("stock").Rows(i).Item("descripcion").ToString + vbCr

            End If
            cantidad_en_stock = 0
        Next
        'MsgBox(string_salida)

    End Sub

    Private Sub IngresoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IngresoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IngresoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub
End Class