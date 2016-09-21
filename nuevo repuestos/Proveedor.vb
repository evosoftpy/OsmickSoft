Public Class Proveedor
    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)

    End Sub



    Private Sub clienteBusBtn_Click(sender As Object, e As EventArgs) Handles clienteBusBtn.Click

        Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)
        Dim t As New herramientas
        Dim j, cant1, cant2, cant3 As Integer
        Dim cad1, cad2, dato As String
        Dim ban As Boolean = False
        Dim b As Integer = 1
        cad1 = clienteParTxt.Text.ToString
        cant1 = cad1.LongCount
        cant2 = DataSet1.Tables("proveedor").Rows.Count
        dato = "nombre_proveedor"
        clienteNombreList.Items.Clear()
        clienteApellidoList.Items.Clear()
        clienteNumeroList.Items.Clear()
        ProveedorTableAdapter.Update(DataSet1.proveedor)
        If cad1 <> "" Then
            For j = 0 To cant2 - 1
                cad2 = DataSet1.Tables("proveedor").Rows(j).Item(dato)
                cant3 = cad2.LongCount
                If cant1 <= cant3 Then
                    If cad1 = cad2.Substring(0, cant1) Then
                        ban = True
                    End If
                End If
                If ban Then
                    clienteNombreList.Items.Add(DataSet1.Tables("proveedor").Rows(j).Item("ruc_proveedor"))
                    clienteApellidoList.Items.Add(DataSet1.Tables("proveedor").Rows(j).Item("nombre_proveedor"))
                    clienteNumeroList.Items.Add(DataSet1.Tables("proveedor").Rows(j).Item("numero_proveedor"))
                    ban = False
                End If
                If j = cant2 - 1 Then

                    If b = 1 Then
                        dato = "ruc_proveedor"
                        b = 2
                        j = -1
                    End If
                End If
            Next
        Else
            MsgBox("Favor ingrese el parametro de busqueda")
        End If
    End Sub

    Private Sub clienteAgreBtn_Click(sender As Object, e As EventArgs) Handles clienteAgreBtn.Click
        Dim CC As New agregarProveedores

        CC.Show()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Dim i, k As Integer
        Dim t As New herramientas
        'Dim ban As Integer = True

        i = clienteApellidoList.SelectedIndex
        If i > -1 Then

            i = t.buscar_en_tablas(DataSet1, "proveedor", "nombre_proveedor", clienteApellidoList.SelectedItem)
            ' MsgBox(clienteNombreList.SelectedItem)
            k = t.buscar_en_tablas(DataSet1, "proveedor", "ruc_proveedor", clienteNombreList.SelectedItem)
            If i > -1 And k > -1 Then
                If i = k Or i = k Then

                    Dim f1 As New editarProveedores
                    moduloDatos.i = k
                    f1.Show()
                    'Me.Refresh()
                    'MsgBox("hola mundo")

                    Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)

                    clienteNombreList.Items.Clear()
                    clienteApellidoList.Items.Clear()
                    clienteNumeroList.Items.Clear()
                End If
            End If
        Else
            MsgBox("Por favor seleccione la opcion a editar antes realizando un click izquierdo sobre el mismo")
        End If
    End Sub



    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        Dim d As DialogResult
        Dim i, j, k As Integer
        Dim t As New herramientas
        'Dim ban As Integer = True

        i = clienteApellidoList.SelectedIndex


        If i > -1 Then

            i = t.buscar_en_tablas(DataSet1, "proveedor", "nombre_proveedor", clienteApellidoList.SelectedItem)
            ' MsgBox(clienteNombreList.SelectedItem)
            If i > -1 Then
                j = t.buscar_en_tablas(DataSet1, "proveedor", "numero_proveedor", clienteNumeroList.SelectedItem)
            End If
            k = t.buscar_en_tablas(DataSet1, "proveedor", "ruc_proveedor", clienteNombreList.SelectedItem)
            If (i > -1 Or j > -1) And k > -1 Then
                If i = k Or j = k Then
                    d = MessageBox.Show("Esta seguro que desea eliminar este cliente", "Eliminar?", MessageBoxButtons.YesNo)
                    If d = DialogResult.Yes Then
                        Try
                            DataSet1.Tables("proveedor").Rows(k).Delete()
                            Validate()
                            ProveedorBindingSource.EndEdit()
                            ProveedorTableAdapter.Update(DataSet1.proveedor)
                            ProveedorTableAdapter.Fill(DataSet1.proveedor)

                            clienteNombreList.Items.Remove(clienteNombreList.SelectedItem)
                            clienteApellidoList.Items.Remove(clienteApellidoList.SelectedItem)
                            clienteNumeroList.Items.Remove(clienteNumeroList.SelectedItem)


                        Catch ex As Exception
                            MsgBox("Error al borrar")
                        End Try
                    End If
                    'MsgBox("hola mundo")
                End If
            End If
        Else
            MsgBox("Por favor seleccione la opcion a editar antes realizando un click izquierdo sobre el mismo")
        End If
    End Sub

    Private Sub clienteNombreList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteNombreList.SelectedIndexChanged
        clienteApellidoList.SelectedIndex = clienteNombreList.SelectedIndex
        clienteNumeroList.SelectedIndex = clienteNombreList.SelectedIndex
    End Sub

    Private Sub clienteApellidoList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteApellidoList.SelectedIndexChanged
        clienteNombreList.SelectedIndex = clienteApellidoList.SelectedIndex
        clienteNumeroList.SelectedIndex = clienteApellidoList.SelectedIndex

    End Sub

    Private Sub clienteNumeroList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteNumeroList.SelectedIndexChanged
        clienteNombreList.SelectedIndex = clienteNumeroList.SelectedIndex
        clienteApellidoList.SelectedIndex = clienteNumeroList.SelectedIndex
    End Sub

    Private Sub clienteSalBtn_Click(sender As Object, e As EventArgs) Handles clienteSalBtn.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j, can As Integer
        can = DataSet1.Tables("proveedor").Rows.Count
        clienteNombreList.Items.Clear()
        clienteApellidoList.Items.Clear()
        clienteNumeroList.Items.Clear()

        ProveedorTableAdapter.Update(DataSet1.proveedor)

        For j = 0 To can - 1
            clienteNombreList.Items.Add(DataSet1.Tables("proveedor").Rows(j).Item("ruc_proveedor"))
            clienteApellidoList.Items.Add(DataSet1.Tables("proveedor").Rows(j).Item("nombre_proveedor"))
            clienteNumeroList.Items.Add(DataSet1.Tables("proveedor").Rows(j).Item("numero_proveedor"))
        Next

    End Sub
End Class