Public Class editarClientes

    Public Function buscar_en_tablas(ByVal dataSet1 As DataSet, ByVal tabla As String, ByVal columna As String, ByVal buscado As String)

        'buscar 
        Dim i As Integer
        Dim cantidad As Integer
        Dim posicion As Integer
        Dim ban As Integer
        ban = 0


        cantidad = dataSet1.Tables(tabla).Rows.Count

        cantidad = cantidad - 1
        For i = 0 To cantidad
            If buscado = dataSet1.Tables(tabla).Rows(i).Item(columna) Then

                posicion = i
                ban = 1
            End If
        Next

        If ban = 0 Then
            posicion = -1 'no se encontro el registro
        End If
        Return posicion


    End Function


    Private Sub clienteEditarBtn_Click(sender As Object, e As EventArgs) Handles clienteEditarBtn.Click

        Dim i As Integer
        Dim ban_existe As Integer
        Dim a As Integer
        ban_existe = 0
        'Dim f1 As New Cliente
        i = moduloDatos.i
        Try

            For a = 0 To DataSet1.Tables("cliente").Rows.Count - 1
                If a <> i And DataSet1.Tables("cliente").Rows(a).Item("ruc_cliente") = clienteRucTxt.Text Then
                    ban_existe = 1
                End If
            Next
            If ban_existe = 0 Then
                DataSet1.Tables("cliente").Rows(i).Item("nombre_cliente") = clienteNomTxt.Text
                DataSet1.Tables("cliente").Rows(i).Item("apellido_cliente") = clienteApTxt.Text
                DataSet1.Tables("cliente").Rows(i).Item("numero_cliente") = clienteNcTxt.Text
                DataSet1.Tables("cliente").Rows(i).Item("ruc_cliente") = clienteRucTxt.Text
                Validate()
                ClienteBindingSource.EndEdit()
                ClienteTableAdapter.Update(DataSet1.cliente)
                MsgBox("Cliente editado con éxito")

                clienteNomTxt.Text = ""
                clienteApTxt.Text = ""
                clienteNcTxt.Text = ""
                clienteRucTxt.Text = ""

                '   f1.Show()
                form_manager.client.ClienteTableAdapter.Fill(DataSet1.cliente)
                form_manager.client.Button1.PerformClick()

                Me.Hide()
            Else
                MsgBox("Ruc del cliente existe")
                clienteRucTxt.Focus()

            End If


        Catch ex As Exception
            MsgBox("Error durante la edición")

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

    Private Sub clienteBorBtn_Click(sender As Object, e As EventArgs)
        clienteNomTxt.Text = ""
        clienteApTxt.Text = ""
        clienteNcTxt.Text = ""
        clienteRucTxt.Text = ""
    End Sub
End Class