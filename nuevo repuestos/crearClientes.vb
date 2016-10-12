Public Class crearClientes
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub crearClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)

    End Sub

    Private Sub clienteBorBtn_Click(sender As Object, e As EventArgs) Handles clienteBorBtn.Click

        clienteNomTxt.Text = ""
        clienteApTxt.Text = ""
        clienteNcTxt.Text = ""
        clienteRucTxt.Text = ""
    End Sub

    Private Sub clienteCargarBtn_Click(sender As Object, e As EventArgs) Handles clienteCargarBtn.Click


        Try
            Dim newCliente As DataRow = DataSet1.Tables("cliente").NewRow()

            If (clienteNomTxt.Text <> "" And clienteRucTxt.Text <> "") Or (clienteApTxt.Text <> "" And clienteRucTxt.Text <> "") Then

                If comprobar() Then
                    newCliente("nombre_cliente") = clienteNomTxt.Text.ToString
                    newCliente("apellido_cliente") = clienteApTxt.Text.ToString
                    newCliente("numero_cliente") = clienteNcTxt.Text.ToString
                    newCliente("ruc_cliente") = clienteRucTxt.Text.ToString




                    DataSet1.Tables("cliente").Rows.Add(newCliente)

                    Validate()
                    ClienteBindingSource.EndEdit()
                    ClienteTableAdapter.Update(DataSet1.cliente)
                    MsgBox("Cliente creado con exito")


                    ''''ESTO ES CODIGO DE PASTORE NO TOCAR'''

                    If form_manager.ban_venta = 1 Then
                        form_manager.sell.update_cache()
                        form_manager.sell.text_ruc_venta.Text = clienteRucTxt.Text
                        form_manager.sell.text_ruc_venta.Focus()

                    End If

                    '''''''''''''''''''''''''''''''''''''''''
                    clienteNomTxt.Text = ""
                    clienteApTxt.Text = ""
                    clienteNcTxt.Text = ""
                    clienteRucTxt.Text = ""
                    Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)
                    Me.Hide()

                Else
                    MsgBox("El cliente ya existe")
                End If
            Else
                MsgBox("Favor complete con el Nombre o el apellido y el RUC como minimo")

            End If

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try


    End Sub

    Private Function comprobar()
        Dim a, b, d As Integer
        Dim t As New herramientas
        a = t.buscar_en_tablas(DataSet1, "cliente", "nombre_cliente", clienteNomTxt.Text.ToString)
        d = t.buscar_en_tablas(DataSet1, "cliente", "ruc_cliente", clienteRucTxt.Text.ToString)
        b = d = t.buscar_en_tablas(DataSet1, "cliente", "apellido_cliente", clienteApTxt.Text.ToString)

        If a = d And a = -1 And d = -1 Then
            Return True
        ElseIf b = d And b = -1 And d = -1 Then
            Return True
        ElseIf a = b = d And a = -1 And b = -1 And d = -1 Then
            Return True
        End If

        Return False
    End Function

    Private Sub clienteAgregarBtn_Click(sender As Object, e As EventArgs) Handles clienteCargarBtn.Click

    End Sub

    Private Sub clienteAgreGroup_Enter(sender As Object, e As EventArgs) Handles clienteAgreGroup.Enter

    End Sub
End Class