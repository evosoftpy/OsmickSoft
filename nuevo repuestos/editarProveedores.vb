Public Class editarProveedores
    Private Sub ProveedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProveedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub editarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.proveedor' table. You can move, or remove it, as needed.
        Me.ProveedorTableAdapter.Fill(Me.DataSet1.proveedor)
        Dim i As Integer
        Dim t As New herramientas
        i = moduloDatos.i
        clienteNomTxt.Text = DataSet1.Tables("proveedor").Rows(i).Item("nombre_proveedor")
        clienteApTxt.Text = DataSet1.Tables("proveedor").Rows(i).Item("numero_proveedor")
        clienteRucTxt.Text = DataSet1.Tables("proveedor").Rows(i).Item("ruc_proveedor")

    End Sub

    Private Sub clienteBorBtn_Click(sender As Object, e As EventArgs)
        clienteNomTxt.Text = ""
        clienteApTxt.Text = ""
        clienteRucTxt.Text = ""
    End Sub

    Private Sub clienteEditarBtn_Click(sender As Object, e As EventArgs) Handles clienteEditarBtn.Click


        Dim i As Integer
        'Dim f1 As New Cliente
        i = moduloDatos.i

        Dim ban_existe As Integer
        Dim a As Integer
        ban_existe = 0

        Try

            For a = 0 To DataSet1.Tables("proveedor").Rows.Count - 1
                If a <> i And DataSet1.Tables("proveedor").Rows(a).Item("ruc_proveedor") = clienteRucTxt.Text Then
                    ban_existe = 1
                End If
            Next
            If ban_existe = 0 Then
                DataSet1.Tables("proveedor").Rows(i).Item("nombre_proveedor") = clienteNomTxt.Text
                DataSet1.Tables("proveedor").Rows(i).Item("ruc_proveedor") = clienteRucTxt.Text
                DataSet1.Tables("proveedor").Rows(i).Item("numero_proveedor") = clienteApTxt.Text

                Validate()
                ProveedorBindingSource.EndEdit()
                ProveedorTableAdapter.Update(DataSet1.proveedor)
                MsgBox("Proveedor editado con éxito")

                clienteNomTxt.Text = ""
                clienteApTxt.Text = ""
                clienteRucTxt.Text = ""

                '   f1.Show()
                form_manager.prov.Button1.PerformClick()

                Me.Hide()
                moduloDatos.reset = True
            Else
                MsgBox("Ruc del proveedor ya existe")
                clienteRucTxt.Focus()


            End If

        Catch ex As Exception
            MsgBox("Error durante la edición")

        End Try
    End Sub
End Class