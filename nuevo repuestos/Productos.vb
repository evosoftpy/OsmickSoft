Public Class Productos
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
            End If
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



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

    Private Sub StockBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StockBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StockBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.DataSet1.stock)



    End Sub

    Private Sub DataGridViewStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStock.CellContentClick

    End Sub

    Private Sub DataGridViewStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStock.CellClick

    End Sub

    Private Sub DataGridViewStock_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStock.CellDoubleClick

        Dim index As Integer
        index = DataGridViewStock.CurrentRow.Index
        Dim j As Integer


        Dim i As Integer

        form_manager.sell.DataGridView1.Rows.Add()
        j = form_manager.sell.DataGridView1.Rows.Count - 2


        form_manager.sell.DataGridView1.Item(0, j).Value = DataGridViewStock.Item(0, index).Value
        form_manager.sell.DataGridView1.Item(1, j).Value = DataGridViewStock.Item(2, index).Value
        form_manager.sell.DataGridView1.Item(2, j).Value = DataGridViewStock.Item(3, index).Value
        form_manager.sell.DataGridView1.Item(3, j).Value = DataGridViewStock.Item(4, index).Value
        form_manager.sell.DataGridView1.Focus()
        form_manager.sell.DataGridView1.Focus()
        form_manager.sell.DataGridView1.CurrentCell = form_manager.sell.DataGridView1.Item(4, j)





    End Sub
End Class