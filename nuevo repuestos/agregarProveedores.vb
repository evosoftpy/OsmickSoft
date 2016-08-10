Public Class agregarProveedores
    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub agregarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)

    End Sub

    Private Sub clienteEditarBtn_Click(sender As Object, e As EventArgs) Handles clienteEditarBtn.Click

        Try
            Dim newCliente As DataRow = DataSet1.Tables("proveedor").NewRow()

            If (clienteNomTxt.Text <> "" And clienteRucTxt.Text <> "") Or (clienteApTxt.Text <> "" And clienteRucTxt.Text <> "") Then

                If comprobar() Then
                    newCliente("nombre_proveedor") = clienteNomTxt.Text.ToString
                    newCliente("numero_proveedor") = clienteApTxt.Text.ToString
                    newCliente("ruc_proveedor") = clienteRucTxt.Text.ToString

                    DataSet1.Tables("proveedor").Rows.Add(newCliente)

                    Validate()
                    ProveedorBindingSource.EndEdit()
                    ProveedorTableAdapter.Update(DataSet1.proveedor)
                    MsgBox("Proveedor creado con exito")
                    clienteNomTxt.Text = ""
                    clienteApTxt.Text = ""
                    clienteRucTxt.Text = ""
                    Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)
                    Me.Hide()
                Else
                    MsgBox("El proveedor ya existe")
                End If
            Else
                MsgBox("Favor complete con el Nombre o el RUC como minimo")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Function comprobar()
        Dim a, b, d As Integer
        Dim t As New herramientas
        a = t.buscar_en_tablas(DataSet1, "proveedor", "nombre_proveedor", clienteNomTxt.Text.ToString)
        d = t.buscar_en_tablas(DataSet1, "proveedor", "ruc_proveedor", clienteRucTxt.Text.ToString)
        b = d = t.buscar_en_tablas(DataSet1, "proveedor", "numero_proveedor", clienteApTxt.Text.ToString)

        If a = d And a = -1 And d = -1 Then
            Return True
        ElseIf b = d And b = -1 And d = -1 Then
            Return True
        ElseIf a = b = d And a = -1 And b = -1 And d = -1 Then
            Return True
        End If

        Return False
    End Function

    Private Sub clienteBorBtn_Click(sender As Object, e As EventArgs) Handles clienteBorBtn.Click
        clienteNomTxt.Text = ""
        clienteApTxt.Text = ""
        clienteRucTxt.Text = ""
    End Sub
End Class