Public Class editarClientes


    Private Sub clienteEditarBtn_Click(sender As Object, e As EventArgs) Handles clienteEditarBtn.Click

        Dim i As Integer
        'Dim f1 As New Cliente
        i = moduloDatos.i
        Try


            DataSet1.Tables("cliente").Rows(i).Item("nombre_cliente") = clienteNomTxt.Text
            DataSet1.Tables("cliente").Rows(i).Item("apellido_cliente") = clienteApTxt.Text
            DataSet1.Tables("cliente").Rows(i).Item("numero_cliente") = clienteNcTxt.Text
            DataSet1.Tables("cliente").Rows(i).Item("ruc_cliente") = clienteRucTxt.Text

            Validate()
            ClienteBindingSource.EndEdit()
            ClienteTableAdapter.Update(DataSet1.cliente)
            MsgBox("Cliente editado con exito")

            clienteNomTxt.Text = ""
            clienteApTxt.Text = ""
            clienteNcTxt.Text = ""
            clienteRucTxt.Text = ""

            '   f1.Show()
            form_manager.client.ClienteTableAdapter.Fill(DataSet1.cliente)
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error durante la edicion")

        End Try


    End Sub

    Private Sub editarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)
        Dim i As Integer
        Dim t As New herramientas
        i = moduloDatos.i
        clienteNomTxt.Text = DataSet1.Tables("cliente").Rows(i).Item("nombre_cliente")
        clienteApTxt.Text = DataSet1.Tables("cliente").Rows(i).Item("apellido_cliente")
        clienteNcTxt.Text = DataSet1.Tables("cliente").Rows(i).Item("numero_cliente")
        clienteRucTxt.Text = DataSet1.Tables("cliente").Rows(i).Item("ruc_cliente")

    End Sub

    Private Sub clienteBorBtn_Click(sender As Object, e As EventArgs) Handles clienteBorBtn.Click
        clienteNomTxt.Text = ""
        clienteApTxt.Text = ""
        clienteNcTxt.Text = ""
        clienteRucTxt.Text = ""
    End Sub
End Class