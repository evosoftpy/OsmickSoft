Imports System
Imports System.Net.Mail
Imports System.Threading
Imports System.IO
Imports System.Text
Public Class Form1
    'primer hilo indenpendiente para consultas
    Dim consulta As Thread
    Dim consultaStart As New ThreadStart(AddressOf consultas)
    Dim CallEnvioMail As New MethodInvoker(AddressOf Me.EnvioMail)

    Dim avisosProgramados As Thread
    Dim avisosStart As New ThreadStart(AddressOf aviso)
    Dim callEscribir As New MethodInvoker(AddressOf crearArchivo)
    Dim callEnviaremail2 As New MethodInvoker(AddressOf EnvioMail2)

    Dim callLectura As New MethodInvoker(AddressOf leerArchivo)
    Dim callCrear As New MethodInvoker(AddressOf crearArchivo)
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.DataSet1.venta)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ingreso' Puede moverla o quitarla según sea necesario.
        Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.stock' Puede moverla o quitarla según sea necesario.
        Me.StockTableAdapter.Fill(Me.DataSet1.stock)
        'TODO: This line of code loads data into the 'DataSet1.cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)

        moduloDatos.leerArchivo()
        Dim ruta As String = "dataMail.conf"
        Dim escritor As StreamWriter
        Try
            'MsgBox(avisoEnviado.ToString + "hola")
            If My.Computer.FileSystem.FileExists(ruta) Then
                My.Computer.FileSystem.DeleteFile(ruta)
            End If

            escritor = File.AppendText(ruta)
            escritor.Write(moduloDatos.correo + escritor.NewLine + moduloDatos.dia + escritor.NewLine + "false")
            escritor.Flush()
            escritor.Close()
        Catch ex As Exception

        End Try
        Try
            Me.consulta = New Thread(consultaStart)
            consulta.IsBackground = True
            consulta.Name = "procesoConsulta"
            consulta.Start()
        Catch ex As Exception
        End Try

        Try
            Me.avisosProgramados = New Thread(avisosStart)
            avisosProgramados.IsBackground = True
            avisosProgramados.Name = "procesoAvisos"
            avisosProgramados.Start()

        Catch ex As Exception
        End Try

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ProgressBar1.Value = 30
        form_manager.stock.Hide()
        form_manager.sell.Hide()
        form_manager.client.Hide()
        form_manager.prov.Hide()
        form_manager.product.Hide()
        form_manager.informe.Hide()

        ProgressBar1.Value = 70


        form_manager.stock.MdiParent = Me
        form_manager.stock.StartPosition = FormStartPosition.CenterScreen


        stock.Show()

        ProgressBar1.Value = 100
        Refresh()

        ' ProgressBar1.Value = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Show()

        ProgressBar1.Value = 30
        form_manager.stock.Hide()
        form_manager.sell.Hide()
        form_manager.client.Hide()
        form_manager.prov.Hide()
        form_manager.informe.Hide()


        form_manager.sell.MdiParent = Me
        form_manager.sell.Show()


        ProgressBar1.Value = 70
        form_manager.product.MdiParent = Me


        form_manager.product.Show()
        Refresh()

        ProgressBar1.Value = 100
        Panel1.Hide()
        'ProgressBar1.Value = 0


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ProgressBar1.Value = 30
        form_manager.stock.Hide()
        form_manager.sell.Hide()
        form_manager.client.Hide()
        form_manager.prov.Hide()
        form_manager.product.Hide()
        form_manager.informe.Hide()
        ProgressBar1.Value = 70
        form_manager.client.MdiParent = Me
        form_manager.client.StartPosition = FormStartPosition.CenterScreen

        form_manager.client.Show()
        ProgressBar1.Value = 100

        Refresh()

        ' ProgressBar1.Value = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ProgressBar1.Value = 30
        form_manager.stock.Hide()
        form_manager.sell.Hide()
        form_manager.client.Hide()
        form_manager.prov.Hide()
        form_manager.informe.Hide()
        form_manager.product.Hide()
        ProgressBar1.Value = 70
        form_manager.prov.MdiParent = Me
        form_manager.prov.StartPosition = FormStartPosition.CenterScreen
        form_manager.prov.Show()

        ProgressBar1.Value = 100
        Refresh()



    End Sub





    'Public Sub EnvioMail()

    '    Dim correo As New MailMessage
    '    Dim smtp As New SmtpClient()

    '    correo.From = New MailAddress("gab753@gmail.com", "Repuestos Evosoft", System.Text.Encoding.UTF8)
    '    correo.To.Add("dahianasaguier@gmail.com")
    '    correo.SubjectEncoding = System.Text.Encoding.UTF8
    '    correo.Subject = "Asunto de tu mensaje"
    '    correo.Body = "Cuerpo del mensaje"
    '    correo.BodyEncoding = System.Text.Encoding.UTF8
    '    correo.IsBodyHtml = False
    '    correo.Priority = MailPriority.High

    '    smtp.Credentials = New System.Net.NetworkCredential("gab753@gmail.com", "password")
    '    smtp.Port = 587
    '    smtp.Host = "smtp.gmail.com"
    '    smtp.EnableSsl = True

    '    smtp.Send(correo)

    'End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        ProgressBar1.Value = 30

        form_manager.stock.Hide()
        form_manager.sell.Hide()
        form_manager.client.Hide()
        form_manager.prov.Hide()
        form_manager.product.Hide()
        form_manager.stock.Hide()

        form_manager.informe.MdiParent = Me
        form_manager.informe.StartPosition = FormStartPosition.CenterScreen
        form_manager.product.Hide()
        ProgressBar1.Value = 70
        form_manager.informe.Show()
        ProgressBar1.Value = 100
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub ClienteBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub



    Public Sub EnvioMail()

        Dim correo As New MailMessage
        Dim smtp As New SmtpClient()
        Dim respuesta As String
        moduloDatos.leerArchivo()
        correo.From = New MailAddress("evotestpy@gmail.com", "Repuestos Evosoft", System.Text.Encoding.UTF8)
        correo.To.Add(moduloDatos.correo)
        correo.SubjectEncoding = System.Text.Encoding.UTF8
        correo.Subject = "Productos en falta"
        respuesta = consultarStock()
        correo.Body = respuesta
        correo.BodyEncoding = System.Text.Encoding.UTF8
        correo.IsBodyHtml = False
        correo.Priority = MailPriority.High

        smtp.Credentials = New System.Net.NetworkCredential("evotestpy@gmail.com", "evotest123")
        smtp.Port = 587
        smtp.Host = "smtp.gmail.com"
        smtp.EnableSsl = True

        smtp.Send(correo)


    End Sub


    Public Sub EnvioMail2()

        Dim correo As New MailMessage
        Dim smtp As New SmtpClient()
        moduloDatos.leerArchivo()
        correo.From = New MailAddress("evosoftpy@gmail.com", "Repuestos Evosoft", System.Text.Encoding.UTF8)
        correo.To.Add("evosoftpy@gmail.com")
        correo.SubjectEncoding = System.Text.Encoding.UTF8
        correo.Subject = "no Consultar stock"
        correo.Body = "cancelado el comando"
        correo.BodyEncoding = System.Text.Encoding.UTF8
        correo.IsBodyHtml = False
        correo.Priority = MailPriority.High

        smtp.Credentials = New System.Net.NetworkCredential("evotestpy@gmail.com", "evotest123")
        smtp.Port = 587
        smtp.Host = "smtp.gmail.com"
        smtp.EnableSsl = True

        smtp.Send(correo)


    End Sub

    Private Sub aviso()
        Dim DateNow As Date
        'Dim objReader As New StreamReader("dataMail.conf")
        Dim sLine As String = ""

        While True
            If My.Computer.FileSystem.FileExists("dataMail.conf") Then
                DateNow = Date.Now

                Me.BeginInvoke(callLectura)
                If DateNow.DayOfWeek.ToString = dia And avisoEnviado = "false" Then
                    'MsgBox(avisoEnviado)
                    Me.BeginInvoke(CallEnvioMail)
                    moduloDatos.avisoEnviado = "true"
                    'MsgBox(avisoEnviado)
                    Dim ruta As String = "dataMail.conf"
                    Dim escritor As StreamWriter
                    Try
                        'MsgBox(avisoEnviado.ToString + "hola")
                        If My.Computer.FileSystem.FileExists(ruta) Then
                            My.Computer.FileSystem.DeleteFile(ruta)
                        End If

                        escritor = File.AppendText(ruta)
                        escritor.Write(moduloDatos.correo + escritor.NewLine + moduloDatos.dia + escritor.NewLine + "true")
                        escritor.Flush()
                        escritor.Close()
                    Catch ex As Exception
                    End Try
                End If
            End If
            Thread.Sleep(10000)
        End While



    End Sub

    Private Sub consultas()


        While True
            'verificar si hay consultar en el correo

            If GetMails("evosoftpy@gmail.com", "pr1nt3f3") Then
                'MsgBox("VERDERO")
                BeginInvoke(CallEnvioMail)
                BeginInvoke(callEnviaremail2)

            End If
            Thread.Sleep(10000)
        End While




    End Sub


    Private Function GetMails(mail As String, clave As String)
        Dim client As OpenPop.Pop3.Pop3Client = New OpenPop.Pop3.Pop3Client()
        'Dim allMessages As List(Of OpenPop.Mime.Message) = New List(Of OpenPop.Mime.Message)(messageCount)

        'For count As Integer = 1 To messageCount
        'Try
        ' allMessages.Add(client.GetMessage(count))
        ' Catch ex As OpenPop.Pop3.Exceptions.PopServerException
        'allMessages.Add(Nothing)
        'End Try
        ' Next

        Dim subj, from As String

        Try
            'MsgBox(moduloDatos.correo)
            client.Connect("pop.gmail.com", 995, True)
            client.Authenticate(mail, clave)

            Dim messageCount As Integer = client.GetMessageCount()
            subj = client.GetMessage(messageCount).Headers.Subject
            from = client.GetMessage(messageCount).Headers.From.Address

            If subj = "Consultar stock" And from = moduloDatos.correo Then
                client.DeleteMessage(messageCount)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al conectarse con el servidor")
        End Try
        Return False
    End Function

    Private Function consultarStock()
        '''TODO: This line of code loads data into the 'DataSet1.ingreso' table. You can move, or remove it, as needed.
        'Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
        '''TODO: This line of code loads data into the 'DataSet1.stock' table. You can move, or remove it, as needed.
        'Me.StockTableAdapter.Fill(Me.DataSet1.stock)
        '''TODO: This line of code loads data into the 'DataSet1.venta' table. You can move, or remove it, as needed.
        'Me.VentaTableAdapter.Fill(Me.DataSet1.venta)

        Dim string_salida As String
        string_salida = "CANTIDAD" + vbTab + vbTab + "NOMBRE" + vbTab + vbTab + vbTab + "DESCRIPCIÓN" + vbCr
        ''MsgBox("no se porque no entra")
        'MsgBox("negrooooo wtf")
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        k = 0


        Dim cantidad_en_stock As Integer
        cantidad_en_stock = 0

        Dim cantidad_stock As Integer
        cantidad_stock = DataSet1.Tables("stock").Rows.Count - 1

        Dim cantidad_ingreso As Integer
        cantidad_ingreso = DataSet1.Tables("ingreso").Rows.Count - 1

        Dim cantidad_venta As Integer
        cantidad_venta = DataSet1.Tables("venta").Rows.Count - 1
        Try


            '''HACE ESTO POR CADA ITEM DEL STOCK
            If cantidad_en_stock > 0 Then

                For i = 0 To cantidad_stock
                    '  MsgBox("entra al for i")
                    '''SUMA LOS INGRESOS
                    For j = 0 To cantidad_ingreso
                        ' MsgBox("entra al For ingresa")
                        If DataSet1.Tables("stock").Rows(i).Item("id_stock") = DataSet1.Tables("ingreso").Rows(j).Item("id_stock") Then
                            cantidad_en_stock = cantidad_en_stock + DataSet1.Tables("ingreso").Rows(j).Item("cantidad")
                        End If
                    Next

                    '''RESTA LOS EGRESOS
                    For j = 0 To cantidad_venta
                        'MsgBox("entra al For venta")
                        If DataSet1.Tables("stock").Rows(i).Item("id_stock") = DataSet1.Tables("venta").Rows(j).Item("id_stock") Then
                            cantidad_en_stock = cantidad_en_stock - DataSet1.Tables("venta").Rows(j).Item("cantidad_venta")
                        End If
                    Next

                    '''SI LA CANTIDAD DEL STOCK(i) ES INSUFICIENTE, LO EXPLICITA EN LA TABLA


                    If cantidad_en_stock <= 2 Then
                        ''MsgBox(DataSet1.Tables("stock").Rows(i).Item("nombre"))
                        'DataGridViewFalta.Rows.Add()

                        'DataGridViewFalta.Item(0, k).Value = DataSet1.Tables("stock").Rows(i).Item("nombre")
                        'DataGridViewFalta.Item(1, k).Value = DataSet1.Tables("stock").Rows(i).Item("descripcion")
                        'DataGridViewFalta.Item(2, k).Value = cantidad_en_stock
                        'k = k + 1

                        string_salida = string_salida + cantidad_en_stock.ToString + vbTab + vbTab + vbTab + DataSet1.Tables("stock").Rows(i).Item("nombre").ToString + vbTab + vbTab + vbTab + DataSet1.Tables("stock").Rows(i).Item("descripcion").ToString + vbCr
                    End If
                    cantidad_en_stock = 0

                Next
            Else
                string_salida = "No hay ningun stock bajo en este momento"
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return string_salida
    End Function
End Class
