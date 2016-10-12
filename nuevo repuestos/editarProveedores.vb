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
        clienteApTxt.Text = DataSet1.Tables("proveedor").Rows(i).Item("ruc_proveedor")
        clienteRucTxt.Text = DataSet1.Tables("proveedor").Rows(i).Item("numero_proveedor")

    End Sub

    Private Sub clienteBorBtn_Click(sender As Object, e As EventArgs) Handles clienteBorBtn.Click
        clienteNomTxt.Text = ""
        clienteApTxt.Text = ""
        clienteRucTxt.Text = ""
    End Sub

    Private Sub clienteEditarBtn_Click(sender As Object, e As EventArgs) Handles clienteEditarBtn.Click
        Dim i As Integer
        'Dim f1 As New Cliente
        i = moduloDatos.i
        Try


            DataSet1.Tables("proveedor").Rows(i).Item("nombre_proveedor") = clienteNomTxt.Text
            DataSet1.Tables("proveedor").Rows(i).Item("ruc_proveedor") = clienteApTxt.Text
            DataSet1.Tables("proveedor").Rows(i).Item("numero_proveedor") = clienteRucTxt.Text

            Validate()
            ProveedorBindingSource.EndEdit()
            ProveedorTableAdapter.Update(DataSet1.proveedor)
            MsgBox("Proveedor editado con éxito")

            clienteNomTxt.Text = ""
            clienteApTxt.Text = ""
            clienteRucTxt.Text = ""

            '   f1.Show()

            Me.Hide()
            moduloDatos.reset = True
        Catch ex As Exception
            MsgBox("Error durante la edición")

        End Try
    End Sub
End Class