Imports System.Net.Mail
Public Class Venta
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.DataSet1.venta)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.DataSet1.stock)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ingreso' Puede moverla o quitarla según sea necesario.
        Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)

    End Sub

    Public Function update_cache()
        Me.VentaTableAdapter.Fill(Me.DataSet1.venta)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.DataSet1.stock)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ingreso' Puede moverla o quitarla según sea necesario.
        Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)

    End Function

    Private Function buscar_en_tablas(tabla As String, columna As String, buscado As String)

        'buscar 
        Dim i As Integer
        Dim cantidad As Integer
        Dim posicion As Integer
        Dim ban As Integer
        ban = 0
        cantidad = DataSet1.Tables(tabla).Rows.Count
        cantidad = cantidad - 1
        For i = 0 To cantidad
            If buscado = DataSet1.Tables(tabla).Rows(i).Item(columna) Then

                posicion = i
                ban = 1
            End If
        Next

        If ban = 0 Then
            posicion = -1 'no se encontro el registro
        End If
        Return posicion


    End Function

    Private Function funcion_buscar_cliente(ruc As String)

        Dim cantidad_clientes As Integer
        Dim i As Integer
        Dim salida As Integer
        Dim bandera_salida As Integer

        bandera_salida = 0
        cantidad_clientes = DataSet1.Tables("cliente").Rows.Count
        cantidad_clientes = cantidad_clientes - 1

        For i = 0 To cantidad_clientes
            If ruc = DataSet1.Tables("cliente").Rows(i).Item("ruc_cliente") Then
                bandera_salida = 1
                salida = i
            End If
        Next

        If bandera_salida = 0 Then
            salida = -1

        End If

        Return salida

    End Function
    Private Function repeticion_cliente()
        Dim ruc As Integer
        Dim mayor As Integer
        Dim aux As String
        ruc = funcion_buscar_cliente(text_ruc_venta.Text)
        update_cache()

        If ruc < 0 Then
            label_ruc_venta.Text = "no se econtro cliente"
            label_ruc_venta.ForeColor = Color.Red
            label_ruc_venta.Visible = True
            If text_ruc_venta.Text.Length > 0 Then

                Dim c_client As New crearClientes
                c_client.Show()
                c_client.clienteRucTxt.Text = text_ruc_venta.Text

            End If


        Else
            label_ruc_venta.Visible = False
            TextBox16.Text = DataSet1.Tables("cliente").Rows(ruc).Item("nombre_cliente") + " " + DataSet1.Tables("cliente").Rows(ruc).Item("apellido_cliente")
            TextBox17.Text = Date.Now.Date
            Dim i As Integer


            n_factura_textbox.Text = "00-000-0000"
        End If

    End Function
    Private Sub text_ruc_venta_LostFocus(sender As Object, e As EventArgs) Handles text_ruc_venta.LostFocus
        Dim ruc As Integer
        Dim mayor As Integer
        Dim aux As String
        ruc = funcion_buscar_cliente(text_ruc_venta.Text)
        update_cache()

        If ruc < 0 Then
            label_ruc_venta.Text = "no se econtro cliente"
            label_ruc_venta.ForeColor = Color.Red
            label_ruc_venta.Visible = True
            If text_ruc_venta.Text.Length > 0 Then
                Dim c_client As New crearClientes
                c_client.Show()
                c_client.clienteRucTxt.Text = text_ruc_venta.Text
            End If
            text_ruc_venta.Text = ""



        Else
            label_ruc_venta.Visible = False
            TextBox16.Text = DataSet1.Tables("cliente").Rows(ruc).Item("nombre_cliente") + " " + DataSet1.Tables("cliente").Rows(ruc).Item("apellido_cliente")
            TextBox17.Text = Date.Now.Date
            Dim i As Integer


            n_factura_textbox.Text = "00-000-0000"
        End If


        ' ver 

    End Sub

    Private Sub venta_guardar_Click(sender As Object, e As EventArgs) Handles venta_guardar.Click
        Me.VentaTableAdapter.Fill(Me.DataSet1.venta)
        Dim ban = 0
        'comprobar existencia del cliente
        Dim id_cliente
        Dim ruc_cliente As Integer
        Dim ban_operacion_realizada = 0
        ruc_cliente = buscar_en_tablas("cliente", "ruc_cliente", text_ruc_venta.Text)

        Dim i As Integer
        For i = 0 To DataSet1.Tables("venta").Rows.Count - 1
            If n_factura_textbox.Text = DataSet1.Tables("venta").Rows(i).Item("factura_venta") And ban = 0 Then

                MsgBox("facutra existe se aumentara en 1 el valor")

                Dim pos As Integer
                Dim num As Integer
                Dim aux32 As String
                Dim nueva As String
                nueva = n_factura_textbox.Text

                pos = pos_ultimo_guion(n_factura_textbox.Text)
                num = n_factura_textbox.Text.Substring(pos)
                aux32 = n_factura_textbox.Text.Substring(pos)
                num = num + 1
                If num < 10 Then
                    nueva = nueva.Substring(0, pos + aux32.Length - 1) + num.ToString
                ElseIf num >= 10 And num < 100 Then
                    nueva = nueva.Substring(0, pos + aux32.Length - 2) + num.ToString
                ElseIf num >= 100 And num < 1000 Then
                    nueva = nueva.Substring(0, pos + aux32.Length - 3) + num.ToString
                ElseIf num >= 1000 And num < 10000 Then
                    nueva = nueva.Substring(0, pos + aux32.Length - 4) + num.ToString
                ElseIf num >= 10000 And num < 100000 Then
                    nueva = nueva.Substring(0, pos + aux32.Length - 5) + num.ToString
                ElseIf num >= 100000 And num < 1000000 Then
                    nueva = nueva.Substring(0, pos + aux32.Length - 6) + num.ToString
                ElseIf num >= 1000000 And num < 10000000 Then
                    nueva = nueva.Substring(0, pos + aux32.Length - 7) + num.ToString
                ElseIf num >= 10000000 And num < 100000000 Then
                    nueva = nueva.Substring(0, pos + aux32.Length - 8) + num.ToString
                ElseIf num >= 100000000 And num < 1000000000 Then
                    nueva = nueva.Substring(0, pos + aux32.Length - 9) + num.ToString
                End If

                n_factura_textbox.Text = nueva
                i = 0
            End If
        Next


        If ruc_cliente < 0 Then
            ban = 1
            MsgBox("Cliente sin registrar!")
        End If


        If ban = 0 Then

            'comprobar existencia del producto
            Dim busqueda As Integer

            For i = 0 To DataGridView1.RowCount - 1

                If DataGridView1.Item(0, i).Value IsNot "" Then
                    If DataGridView1.Item(3, i).Value IsNot Nothing Then

                        If DataGridView1.Item(3, i).Value.ToString = "" Then

                        Else
                            If DataGridView1.Item(3, i).Value IsNot "0" Then
                                id_cliente = DataSet1.Tables("cliente").Rows(ruc_cliente).Item("id_cliente")
                                'cargar_venta(DataGridView1.Item(0, i).Value, id_cliente, TextBox17.Text, DataGridView1.Item(3, i).Value)
                                Dim nueva_venta As DataRow = DataSet1.Tables("venta").NewRow
                                Dim id_producto As Integer
                                busqueda = buscar_en_tablas("stock", "codigo", DataGridView1.Item(0, i).Value)
                                If busqueda > -1 Then
                                    id_producto = DataSet1.Tables("stock").Rows(busqueda).Item("id_stock")
                                Else
                                    id_producto = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "codigo_barras", DataGridView1.Item(0, i).Value)).Item("id_stock")
                                End If
                                nueva_venta("id_cliente") = id_cliente
                                nueva_venta("id_stock") = id_producto
                                nueva_venta("cantidad_venta") = DataGridView1.Item(3, i).Value
                                nueva_venta("factura_venta") = n_factura_textbox.Text

                                DataSet1.Tables("venta").Rows.Add(nueva_venta)
                                Validate()
                                VentaBindingSource.EndEdit()
                                VentaTableAdapter.Update(DataSet1.venta)
                                MsgBox("Guardado Exitosamente")
                            End If
                        End If
                    End If
                End If


            Next

        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Function cantidad_producto_disponible(idproducto As Integer)
        'funcion que devuelve la cantidad del producto seleccionado disponible
        Dim ingresos As Integer
        Dim salidas As Integer
        Dim i As Integer


        ingresos = 0
        salidas = 0

        For i = 0 To DataSet1.Tables("ingreso").Rows.Count - 1
            If DataSet1.Tables("ingreso").Rows(i).Item("id_stock") = idproducto Then
                ingresos = ingresos + DataSet1.Tables("ingreso").Rows(i).Item("cantidad")
            End If
        Next

        For i = 0 To DataSet1.Tables("venta").Rows.Count - 1
            If DataSet1.Tables("venta").Rows(i).Item("id_stock") = idproducto Then
                salidas = salidas + DataSet1.Tables("venta").Rows(i).Item("cantidad_venta")
            End If
        Next

        Return ingresos - salidas

    End Function

    Public Sub EnvioMail(mensaje As String)

        Dim correo As New MailMessage
        Dim smtp As New SmtpClient()

        correo.From = New MailAddress("evotestpy@gmail.com", "Repuestos Evosoft", System.Text.Encoding.UTF8)
        correo.To.Add("hejasako@gmail.com")
        correo.SubjectEncoding = System.Text.Encoding.UTF8
        correo.Subject = "Productos en falta"
        correo.Body = mensaje
        correo.BodyEncoding = System.Text.Encoding.UTF8
        correo.IsBodyHtml = False
        correo.Priority = MailPriority.High

        smtp.Credentials = New System.Net.NetworkCredential("evotestpy@gmail.com", "evotest123")
        smtp.Port = 587
        smtp.Host = "smtp.gmail.com"
        smtp.EnableSsl = True

        smtp.Send(correo)

    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim cod As String
        Dim i As Integer
        Dim curen As Integer
        Dim suma As Integer
        Dim iva As Integer
        Dim total As Integer
        Dim idproducto As Integer
        Dim cantidad_product As Integer
        Dim ban As Integer
        Dim ban_exist_product As Integer
        ban_exist_product = 0


        curen = DataGridView1.CurrentRow.Index

        suma = 0

        If DataGridView1.CurrentCellAddress.X = 2 Then
            If IsNumeric(DataGridView1.Item(2, curen).Value) Then

            Else
                MsgBox("Ingrese un precio unitario numerico")
                DataGridView1.Item(2, curen).Value = ""
            End If
        End If


        If (DataGridView1.Item(0, curen).Value = "") Then

        Else
            cod = DataGridView1.Item(0, curen).Value

            For i = 0 To DataSet1.Tables("stock").Rows.Count - 1


                If cod = DataSet1.Tables("stock").Rows(i).Item("codigo") Or cod = DataSet1.Tables("stock").Rows(i).Item("codigo_barras") Then

                    DataGridView1.Item(1, curen).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
                    DataGridView1.Item(2, curen).Value = DataSet1.Tables("stock").Rows(i).Item("precio_venta")
                    idproducto = DataSet1.Tables("stock").Rows(i).Item("id_stock")
                    ban_exist_product = 1
                End If

            Next
            If ban_exist_product = 0 Then
                DataGridView1.Item(0, curen).Value = ""
                MsgBox("Codigo de producto no existe!")
            End If

        End If

        If DataGridView1.Item(3, curen).Value = "" Then

        Else
            cantidad_product = cantidad_producto_disponible(idproducto)
            For i = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Item(0, i).Value IsNot "" Then
                    If DataGridView1.Item(0, i).Value = 0 Then
                        suma = suma + DataGridView1.Item(4, i).Value
                        text_sub_total.Text = Puntos(suma.ToString)
                        iva = suma * 0.1
                        text_iva.Text = Puntos(iva.ToString)
                        total = suma + iva

                        text_total.Text = Puntos(total.ToString)




                    End If
                End If



            Next

            If IsNumeric(DataGridView1.Item(3, curen).Value) = False Then
                MsgBox("Ingrese numero")
                DataGridView1.Item(3, curen).Value = ""
            Else

                If cantidad_product - DataGridView1.Item(3, curen).Value < 0 Then
                    Dim mensaje As String
                    MsgBox("cantidad de " + DataGridView1.Item(1, curen).Value.ToString + " supera stock:  " + cantidad_product.ToString)


                    DataGridView1.CurrentCell.Value = 0

                    If cantidad_product - DataGridView1.Item(3, curen).Value < 2 Then
                        mensaje = "Producto " + DataGridView1.Item(1, curen).Value.ToString + " sobra  " + cantidad_product.ToString
                        EnvioMail(mensaje)
                    End If

                End If
                If IsNumeric(DataGridView1.Item(2, curen).Value) Then
                    DataGridView1.Item(4, curen).Value = DataGridView1.Item(3, curen).Value * DataGridView1.Item(2, curen).Value
                    suma = 0
                    For i = 0 To DataGridView1.RowCount - 1
                        If DataGridView1.Item(4, i).Value IsNot "" Then
                            suma = suma + DataGridView1.Item(4, i).Value
                            text_sub_total.Text = Puntos(suma.ToString)
                            iva = suma * 0.1
                            text_iva.Text = Puntos(iva.ToString)
                            total = suma + iva

                            text_total.Text = Puntos(total.ToString)
                        End If
                    Next
                Else
                    MsgBox("Ingrese un precio unitario numerico")
                    DataGridView1.Item(2, curen).Value = ""
                End If
            End If
        End If

        'ordenar los los grid
        Dim j, k As Integer
        For k = 0 To DataGridView1.RowCount
            For i = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Item(0, i).Value = "" Then
                    If i + 1 < DataGridView1.RowCount Then

                        If DataGridView1.Item(0, i + 1).Value IsNot "" Then
                            For j = 0 To 4
                                DataGridView1.Item(j, i).Value = DataGridView1.Item(j, i + 1).Value
                                DataGridView1.Item(j, i + 1).Value = ""
                            Next
                        End If
                    End If
                End If

            Next
        Next


    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Me.VentaTableAdapter.Fill(Me.DataSet1.venta)
        Dim factura_buscada As String
        Dim pos As Integer
        Dim i As Integer
        Dim ruc As String

        Dim fecha As String
        Dim pos_cliente As Integer
        Dim nom_cliente As String

        Dim cont As Integer
        cont = 0

        factura_buscada = n_factura_textbox.Text
        pos = buscar_en_tablas("venta", "factura_venta", factura_buscada)

        If pos >= 0 Then
            ruc = DataSet1.Tables("venta").Rows(pos).Item("id_cliente")
            pos_cliente = buscar_en_tablas("cliente", "id_cliente", ruc)
            ruc = DataSet1.Tables("cliente").Rows(pos_cliente).Item("ruc_cliente")
            nom_cliente = DataSet1.Tables("cliente").Rows(pos_cliente).Item("nombre_cliente") + " " + DataSet1.Tables("cliente").Rows(pos_cliente).Item("apellido_cliente")
            'fecha = DataSet1.Tables("venta_producto").Rows(pos).Item("fecha_venta")
            'agregar fecha
            text_ruc_venta.Text = ruc
            TextBox16.Text = nom_cliente
            'TextBox17.Text = fecha

            For i = 0 To DataSet1.Tables("venta").Rows.Count - 1

                If factura_buscada = DataSet1.Tables("venta").Rows(i).Item("factura_venta") Then

                    DataGridView1.Rows.Add()

                    DataGridView1.Item(0, cont).Value = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "id_stock", DataSet1.Tables("venta").Rows(i).Item("id_stock"))).Item("codigo")
                    DataGridView1.Item(1, cont).Value = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "id_stock", DataSet1.Tables("venta").Rows(i).Item("id_stock"))).Item("nombre")
                    DataGridView1.Item(2, cont).Value = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "id_stock", DataSet1.Tables("venta").Rows(i).Item("id_stock"))).Item("precio_venta")
                    DataGridView1.Item(3, cont).Value = DataSet1.Tables("venta").Rows(i).Item("cantidad_venta")

                    cont = cont + 1
                End If


            Next


        Else
            MsgBox("Factura no existe")
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        text_ruc_venta.Clear()
        TextBox16.Clear()
        DataGridView1.Rows.Clear()
    End Sub

    Private Function pos_ultimo_guion(n_factura As String)
        Dim i As Integer

        Dim aux As Integer
        aux = -1

        For i = 0 To n_factura.Length - 1
            If n_factura.Chars(i) = "-" Then
                aux = i + 1
            End If

        Next
        Return aux

    End Function

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click


        Dim pos As Integer
        Dim num As Integer
        Dim aux As String
        Dim nueva As String
        Dim cant_ceros As Integer
        nueva = n_factura_textbox.Text

        pos = pos_ultimo_guion(n_factura_textbox.Text)
        num = n_factura_textbox.Text.Substring(pos)
        aux = n_factura_textbox.Text.Substring(pos)
        num = num - 1
        If num < 10 Then
            nueva = nueva.Substring(0, pos + aux.Length - 1) + num.ToString
        ElseIf num >= 10 And num < 100 Then
            nueva = nueva.Substring(0, pos + aux.Length - 2) + num.ToString
        ElseIf num >= 100 And num < 1000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 3) + num.ToString
        ElseIf num >= 1000 And num < 10000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 4) + num.ToString
        ElseIf num >= 10000 And num < 100000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 5) + num.ToString
        ElseIf num >= 100000 And num < 1000000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 6) + num.ToString
        ElseIf num >= 1000000 And num < 10000000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 7) + num.ToString
        ElseIf num >= 10000000 And num < 100000000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 8) + num.ToString
        ElseIf num >= 100000000 And num < 1000000000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 9) + num.ToString
        End If

        n_factura_textbox.Text = nueva

        Dim factura_buscada As String

        Dim i As Integer
        Dim ruc As String

        Dim fecha As String
        Dim pos_cliente As Integer
        Dim nom_cliente As String

        Dim cont As Integer
        cont = 0

        factura_buscada = nueva
        pos = buscar_en_tablas("venta", "factura_venta", factura_buscada)

        If pos >= 0 Then
            ruc = DataSet1.Tables("venta").Rows(pos).Item("id_cliente")
            pos_cliente = buscar_en_tablas("cliente", "id_cliente", ruc)
            ruc = DataSet1.Tables("cliente").Rows(pos_cliente).Item("ruc_cliente")
            nom_cliente = DataSet1.Tables("cliente").Rows(pos_cliente).Item("nombre_cliente") + " " + DataSet1.Tables("cliente").Rows(pos_cliente).Item("apellido_cliente")
            'fecha = DataSet1.Tables("venta_producto").Rows(pos).Item("fecha_venta")
            'agregar fecha
            text_ruc_venta.Text = ruc
            TextBox16.Text = nom_cliente
            'TextBox17.Text = fecha

            For i = 0 To DataSet1.Tables("venta").Rows.Count - 1

                If factura_buscada = DataSet1.Tables("venta").Rows(i).Item("factura_venta") Then

                    DataGridView1.Rows.Add()

                    DataGridView1.Item(0, cont).Value = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "id_stock", DataSet1.Tables("venta").Rows(i).Item("id_stock"))).Item("codigo")
                    DataGridView1.Item(1, cont).Value = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "id_stock", DataSet1.Tables("venta").Rows(i).Item("id_stock"))).Item("nombre")
                    DataGridView1.Item(2, cont).Value = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "id_stock", DataSet1.Tables("venta").Rows(i).Item("id_stock"))).Item("precio_venta")
                    DataGridView1.Item(3, cont).Value = DataSet1.Tables("venta").Rows(i).Item("cantidad_venta")

                    cont = cont + 1
                End If


            Next
            n_factura_textbox.Text = nueva

        Else
            MsgBox("Factura no existe")
            text_ruc_venta.Clear()
            TextBox16.Clear()
            DataGridView1.Rows.Clear()
        End If


    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim pos As Integer
        Dim num As Integer
        Dim aux As String
        Dim nueva As String
        Dim cant_ceros As Integer
        nueva = n_factura_textbox.Text

        pos = pos_ultimo_guion(n_factura_textbox.Text)
        num = n_factura_textbox.Text.Substring(pos)
        aux = n_factura_textbox.Text.Substring(pos)
        num = num + 1
        If num < 10 Then
            nueva = nueva.Substring(0, pos + aux.Length - 1) + num.ToString
        ElseIf num >= 10 And num < 100 Then
            nueva = nueva.Substring(0, pos + aux.Length - 2) + num.ToString
        ElseIf num >= 100 And num < 1000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 3) + num.ToString
        ElseIf num >= 1000 And num < 10000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 4) + num.ToString
        ElseIf num >= 10000 And num < 100000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 5) + num.ToString
        ElseIf num >= 100000 And num < 1000000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 6) + num.ToString
        ElseIf num >= 1000000 And num < 10000000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 7) + num.ToString
        ElseIf num >= 10000000 And num < 100000000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 8) + num.ToString
        ElseIf num >= 100000000 And num < 1000000000 Then
            nueva = nueva.Substring(0, pos + aux.Length - 9) + num.ToString
        End If

        n_factura_textbox.Text = nueva


        Dim factura_buscada As String

        Dim i As Integer
        Dim ruc As String

        Dim fecha As String
        Dim pos_cliente As Integer
        Dim nom_cliente As String

        Dim cont As Integer
        cont = 0

        factura_buscada = nueva
        pos = buscar_en_tablas("venta", "factura_venta", factura_buscada)

        If pos >= 0 Then
            ruc = DataSet1.Tables("venta").Rows(pos).Item("id_cliente")
            pos_cliente = buscar_en_tablas("cliente", "id_cliente", ruc)
            ruc = DataSet1.Tables("cliente").Rows(pos_cliente).Item("ruc_cliente")
            nom_cliente = DataSet1.Tables("cliente").Rows(pos_cliente).Item("nombre_cliente") + " " + DataSet1.Tables("cliente").Rows(pos_cliente).Item("apellido_cliente")
            'fecha = DataSet1.Tables("venta_producto").Rows(pos).Item("fecha_venta")
            'agregar fecha
            text_ruc_venta.Text = ruc
            TextBox16.Text = nom_cliente
            'TextBox17.Text = fecha

            For i = 0 To DataSet1.Tables("venta").Rows.Count - 1

                If factura_buscada = DataSet1.Tables("venta").Rows(i).Item("factura_venta") Then

                    DataGridView1.Rows.Add()

                    DataGridView1.Item(0, cont).Value = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "id_stock", DataSet1.Tables("venta").Rows(i).Item("id_stock"))).Item("codigo")
                    DataGridView1.Item(1, cont).Value = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "id_stock", DataSet1.Tables("venta").Rows(i).Item("id_stock"))).Item("nombre")
                    DataGridView1.Item(2, cont).Value = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "id_stock", DataSet1.Tables("venta").Rows(i).Item("id_stock"))).Item("precio_venta")
                    DataGridView1.Item(3, cont).Value = DataSet1.Tables("venta").Rows(i).Item("cantidad_venta")

                    cont = cont + 1
                End If


            Next
            n_factura_textbox.Text = nueva

        Else
            MsgBox("Factura no existe")
            text_ruc_venta.Clear()
            TextBox16.Clear()
            DataGridView1.Rows.Clear()
        End If

    End Sub


    Public Function Puntos(ByVal strValor As String, Optional ByVal intNumDecimales As Integer = 0) As String

        Dim strAux As String
        Dim strComas As String
        Dim strPuntos As String
        Dim intX As Integer
        Dim bolMenos As Boolean = False

        strComas = ""
        strValor = strValor.Replace(".", "")
        If InStr(strValor, ",") > 0 Then
            strAux = Mid(strValor, 1, InStr(strValor, ",") - 1)
            strComas = Mid(strValor, InStr(strValor, ","))
        Else
            strAux = strValor
        End If

        If Mid(strAux, 1, 1) = "-" Then
            bolMenos = True
            strAux = Mid(strAux, 2)
        End If

        strPuntos = strAux
        strAux = ""
        While strPuntos.Length > 3
            strAux = "." & Mid(strPuntos, strPuntos.Length - 2, 3) & strAux
            strPuntos = Mid(strPuntos, 1, strPuntos.Length - 3)
        End While
        If intNumDecimales <> 0 Then
            If strComas = "" Then strComas = ","
            For intX = Len(strComas) - 1 To intNumDecimales - 1
                strComas = strComas & "0"
            Next

        End If
        strAux = strPuntos & strAux & strComas
        If Mid(strAux, 1, 1) = "." Then strAux = Mid(strAux, 2)
        If bolMenos Then strAux = "-" & strAux

        Return strAux
    End Function
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.VentaTableAdapter.Fill(Me.DataSet1.venta)
        Dim factura As String
        Dim ruc_cliente As Integer
        Dim ban_operacion_realizada = 0
        Dim id_cliente
        ruc_cliente = buscar_en_tablas("cliente", "ruc_cliente", text_ruc_venta.Text)

        factura = n_factura_textbox.Text
        Dim i As Integer

        For i = 0 To DataSet1.Tables("venta").Rows.Count - 1
            If factura = DataSet1.Tables("venta").Rows(i).Item("factura_venta") Then
                DataSet1.Tables("venta").Rows(i).Delete()
            End If
        Next

        For i = 0 To DataGridView1.RowCount - 1

            If DataGridView1.Item(0, i).Value IsNot "" Then
                If DataGridView1.Item(3, i).Value IsNot Nothing Then

                    If DataGridView1.Item(3, i).Value.ToString = "" Then

                    Else
                        If DataGridView1.Item(3, i).Value IsNot "0" Then
                            id_cliente = DataSet1.Tables("cliente").Rows(ruc_cliente).Item("id_cliente")
                            'cargar_venta(DataGridView1.Item(0, i).Value, id_cliente, TextBox17.Text, DataGridView1.Item(3, i).Value)
                            Dim nueva_venta As DataRow = DataSet1.Tables("venta").NewRow
                            Dim id_producto As Integer
                            id_producto = DataSet1.Tables("stock").Rows(buscar_en_tablas("stock", "codigo", DataGridView1.Item(0, i).Value)).Item("id_stock")

                            nueva_venta("id_cliente") = id_cliente
                            nueva_venta("id_stock") = id_producto
                            nueva_venta("cantidad_venta") = DataGridView1.Item(3, i).Value
                            nueva_venta("factura_venta") = n_factura_textbox.Text

                            DataSet1.Tables("venta").Rows.Add(nueva_venta)
                            Validate()
                            VentaBindingSource.EndEdit()
                            VentaTableAdapter.Update(DataSet1.venta)
                            MsgBox("Guardado Exitosamente")
                        End If
                    End If
                End If
            End If


        Next
        Validate()
        VentaBindingSource.EndEdit()
        VentaTableAdapter.Update(DataSet1.venta)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim factura As String


        factura = n_factura_textbox.Text
        Dim i As Integer

        For i = 0 To DataSet1.Tables("venta").Rows.Count - 1
            If factura = DataSet1.Tables("venta").Rows(i).Item("factura_venta") Then
                DataSet1.Tables("venta").Rows(i).Delete()

            End If
        Next
        Validate()
        VentaBindingSource.EndEdit()
        VentaTableAdapter.Update(DataSet1.venta)
    End Sub

    Private Sub text_ruc_venta_TextChanged(sender As Object, e As EventArgs) Handles text_ruc_venta.TextChanged

    End Sub
End Class