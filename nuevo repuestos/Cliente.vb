Public Class Cliente
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)

    End Sub

    Private Sub clienteAgreBtn_Click(sender As Object, e As EventArgs) Handles clienteAgreBtn.Click
        Dim CC As New crearClientes
        CC.Show()

        CC.clienteNomTxt.Focus()

    End Sub

    Private Sub clienteSalBtn_Click(sender As Object, e As EventArgs) Handles clienteSalBtn.Click
        Me.Hide()
    End Sub

    Private Sub clienteBusBtn_Click(sender As Object, e As EventArgs) Handles clienteBusBtn.Click

        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)
        Dim t As New herramientas
        Dim j, cant1, cant2, cant3 As Integer
        Dim cad1, cad2, dato As String
        Dim ban As Boolean = False
        Dim b As Integer = 1
        Dim c As Integer = 0
        cad1 = clienteParTxt.Text
        cant1 = cad1.LongCount
        cant2 = DataSet1.Tables("cliente").Rows.Count
        dato = "nombre_cliente"
        clienteNombreList.Items.Clear()
        clienteApellidoList.Items.Clear()
        clienteNumeroList.Items.Clear()
        clienteRucList.Items.Clear()
        ClienteTableAdapter.Update(DataSet1.cliente)
        If cad1 <> "" Then
            For j = 0 To cant2 - 1
                cad2 = DataSet1.Tables("cliente").Rows(j).Item(dato)
                'MsgBox(cad2)
                cant3 = cad2.LongCount
                If cant1 <= cant3 Then
                    If cad1 = cad2.Substring(0, cant1) Then
                        ban = True
                    End If
                End If
                If ban Then
                    If Not (clienteNombreList.Items.Contains(DataSet1.Tables("cliente").Rows(j).Item("nombre_cliente")) And clienteApellidoList.Items.Contains(DataSet1.Tables("cliente").Rows(j).Item("apellido_cliente")) And clienteNumeroList.Items.Contains(DataSet1.Tables("cliente").Rows(j).Item("numero_cliente")) And clienteRucList.Items.Contains(DataSet1.Tables("cliente").Rows(j).Item("ruc_cliente"))) Then
                        clienteNombreList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("nombre_cliente"))
                        clienteApellidoList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("apellido_cliente"))
                        clienteNumeroList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("numero_cliente"))
                        clienteRucList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("ruc_cliente"))
                    End If
                    ban = False
                End If
                If j = cant2 - 1 Then
                    If b = 1 Then
                        dato = "apellido_cliente"
                        j = -1
                        b = 2
                    ElseIf b = 2 Then
                        dato = "ruc_cliente"
                        j = -1
                        b = 3
                    ElseIf b = 3 Then
                        dato = "numero_cliente"
                        j = -1
                        b = 4
                    End If
                End If
            Next
        Else
            MsgBox("Favor ingrese el parámetro de búsqueda")
        End If
    End Sub

    Private Sub clienteNombreList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteNombreList.SelectedIndexChanged

        clienteApellidoList.SelectedIndex = clienteNombreList.SelectedIndex
        clienteNumeroList.SelectedIndex = clienteNombreList.SelectedIndex
        clienteRucList.SelectedIndex = clienteNombreList.SelectedIndex
    End Sub

    Private Sub clienteApellidoList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteApellidoList.SelectedIndexChanged
        clienteNombreList.SelectedIndex = clienteApellidoList.SelectedIndex
        clienteNumeroList.SelectedIndex = clienteApellidoList.SelectedIndex
        clienteRucList.SelectedIndex = clienteApellidoList.SelectedIndex
    End Sub

    Private Sub clienteNumeroList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteNumeroList.SelectedIndexChanged
        clienteApellidoList.SelectedIndex = clienteNumeroList.SelectedIndex
        clienteRucList.SelectedIndex = clienteNumeroList.SelectedIndex
        clienteNombreList.SelectedIndex = clienteNumeroList.SelectedIndex
    End Sub

    Private Sub clienteRucList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clienteRucList.SelectedIndexChanged
        clienteNombreList.SelectedIndex = clienteRucList.SelectedIndex
        clienteNumeroList.SelectedIndex = clienteRucList.SelectedIndex
        clienteApellidoList.SelectedIndex = clienteRucList.SelectedIndex
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        Dim i, j, k As Integer
        Dim t As New herramientas
        'Dim ban As Integer = True

        i = clienteNombreList.SelectedIndex
        If i > -1 Then

            i = t.buscar_en_tablas(DataSet1, "cliente", "nombre_cliente", clienteNombreList.SelectedItem)
            ' MsgBox(clienteNombreList.SelectedItem)
            If i > -1 Then
                j = t.buscar_en_tablas(DataSet1, "cliente", "apellido_cliente", clienteApellidoList.SelectedItem)
            End If
            k = t.buscar_en_tablas(DataSet1, "cliente", "ruc_cliente", clienteRucList.SelectedItem)
            If (i > -1 Or j > -1) And k > -1 Then
                If i = k Or j = k Then

                    Dim f1 As New editarClientes
                    moduloDatos.i = k
                    f1.Show()
                    clienteNombreList.Items.Clear()
                    clienteApellidoList.Items.Clear()
                    clienteNumeroList.Items.Clear()
                    clienteRucList.Items.Clear()
                    'Me.Refresh()
                    'MsgBox("hola mundo")

                    'refrescar()
                End If
            End If
        Else
            MsgBox("Por favor seleccione la opción a editar antes, realizando un click izquierdo sobre el mismo")
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim d As DialogResult
        Dim i, j, k As Integer
        Dim t As New herramientas
        'Dim ban As Integer = True

        i = clienteNombreList.SelectedIndex


        If i > -1 Then

            i = t.buscar_en_tablas(DataSet1, "cliente", "nombre_cliente", clienteNombreList.SelectedItem)
            ' MsgBox(clienteNombreList.SelectedItem)
            If i > -1 Then
                j = t.buscar_en_tablas(DataSet1, "cliente", "apellido_cliente", clienteApellidoList.SelectedItem)
            End If
            k = t.buscar_en_tablas(DataSet1, "cliente", "ruc_cliente", clienteRucList.SelectedItem)
            If (i > -1 Or j > -1) And k > -1 Then
                If i = k Or j = k Then
                    d = MessageBox.Show("Está seguro que desea eliminar este cliente", "¿Eliminar?", MessageBoxButtons.YesNo)
                    If d = DialogResult.Yes Then
                        Try
                            DataSet1.Tables("cliente").Rows(k).Delete()
                            Validate()
                            ClienteBindingSource.EndEdit()
                            ClienteTableAdapter.Update(DataSet1.cliente)
                            ClienteTableAdapter.Fill(DataSet1.cliente)
                            clienteNombreList.Items.Clear()
                            clienteApellidoList.Items.Clear()
                            clienteNumeroList.Items.Clear()
                            clienteRucList.Items.Clear()

                        Catch ex As Exception
                            MsgBox("Error al borrar")
                        End Try
                    End If
                    'MsgBox("hola mundo")
                End If
            End If
        Else
            MsgBox("Por favor seleccione la opción a editar antes realizando un click izquierdo sobre el mismo")
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j, can As Integer
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)
        can = DataSet1.Tables("cliente").Rows.Count
        clienteNombreList.Items.Clear()
        clienteApellidoList.Items.Clear()
        clienteNumeroList.Items.Clear()
        clienteRucList.Items.Clear()
        ClienteTableAdapter.Update(DataSet1.cliente)

        For j = 0 To can - 1
            clienteNombreList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("nombre_cliente"))
            clienteApellidoList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("apellido_cliente"))
            clienteNumeroList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("numero_cliente"))
            clienteRucList.Items.Add(DataSet1.Tables("cliente").Rows(j).Item("ruc_cliente"))
        Next

    End Sub
End Class