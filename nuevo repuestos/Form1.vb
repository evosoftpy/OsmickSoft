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

    'Dim CallConsultarStock As New Functio(AddressOf Me.consultarStock)
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.cliente' Puede moverla o quitarla según sea necesario.

        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)
        Try
            Me.consulta = New Thread(consultaStart)
            consulta.IsBackground = True
            consulta.Name = "consultas"
            consulta.Start()
        Catch ex As Exception
        End Try

        Try
            Me.avisosProgramados = New Thread(avisosStart)
            avisosProgramados.IsBackground = True
            avisosProgramados.Name = "avisos"
            avisosProgramados.Start()
        Catch ex As Exception
        End Try

    End Sub

    Dim stock As New Form2
    Dim sell As New Venta
    Dim client As New Cliente
    Dim prov As New Proveedor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        stock.Hide()
        sell.Hide()
        client.Hide()
        prov.Hide()


        stock.MdiParent = Me
        stock.StartPosition = FormStartPosition.CenterScreen


        stock.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        stock.Hide()
        sell.Hide()
        client.Hide()
        prov.Hide()

        sell.MdiParent = Me
        sell.StartPosition = FormStartPosition.CenterScreen


        sell.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        stock.Hide()
        sell.Hide()
        client.Hide()
        prov.Hide()

        client.MdiParent = Me
        client.StartPosition = FormStartPosition.CenterScreen

        client.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        stock.Hide()
        sell.Hide()
        client.Hide()
        prov.Hide()

        prov.MdiParent = Me
        prov.StartPosition = FormStartPosition.CenterScreen
        prov.Show()

    End Sub





    Public Sub EnvioMail()

        Dim correo As New MailMessage
        Dim smtp As New SmtpClient()
        moduloDatos.leerArchivo()
        correo.From = New MailAddress("evotestpy@gmail.com", "Repuestos Evosoft", System.Text.Encoding.UTF8)
        correo.To.Add(moduloDatos.correo)
        correo.SubjectEncoding = System.Text.Encoding.UTF8
        correo.Subject = "Productos en falta"
        correo.Body = consultarStock()
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



    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub activarTareas()
        'avisos.Interval = 2000
        'avisos.Start()

        'consultas.Interval = 3600000
        'consultas.Start()
    End Sub

    Private Sub aviso()
        Dim DateNow As Date
        Dim objReader As New StreamReader("dataMail.conf")
        Dim sLine As String = ""

        While True
            If My.Computer.FileSystem.FileExists("dataMail.conf") Then
                DateNow = Date.Now

                Me.BeginInvoke(callLectura)
                If DateNow.DayOfWeek.ToString = dia And avisoEnviado = "false" Then
                    MsgBox(avisoEnviado)
                    Me.BeginInvoke(CallEnvioMail)
                    moduloDatos.avisoEnviado = "true"
                    'MsgBox(avisoEnviado)
                    Dim objReader As New StreamReader("dataMail.conf")
                    Dim sLine As String = ""
                    Dim ban As Integer = 0
                    'Dim arrText As New ArrayList()
                    Try
                        Do
                            sLine = objReader.ReadLine()
                            If Not sLine Is Nothing Then
                                'arrText.Add(sLine)
                                If correo <> "none" Then
                                    If ban = 0 Then
                                        moduloDatos.correo = sLine
                                        ban = 1
                                    ElseIf ban = 1 Then
                                        moduloDatos.dia = sLine
                                        ban = 2
                                    Else
                                        moduloDatos.avisoEnviado = sLine

                                    End If
                                End If
                            End If
                        Loop Until sLine Is Nothing
                        objReader.Close()
                        'MsgBox(correo + dia)
                    Catch ex As Exception
                        objReader.Close()
                    End Try
                End If

                Thread.Sleep(10000)
            Else
                Thread.Sleep(10000)
            End If
        End While
    End Sub

    Private Sub consultas()

        While True
            Try
                'verificar si hay consultar en el correo
                If GetMails("evosoftpy@gmail.com", "pr1nt3f3", "cpaezpy@gmail.com") Then
                    'MsgBox("VERDERO")

                    BeginInvoke(CallEnvioMail)
                    BeginInvoke(callEnviaremail2)
                End If
            Catch ex As Exception

        End Try
            Thread.Sleep(15000)
        End While

    End Sub



    Private Function GetMails(mail As String, clave As String, consultor As String)
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
            client.Connect("pop.gmail.com", 995, True)
            client.Authenticate(mail, clave)

            Dim messageCount As Integer = client.GetMessageCount()
            subj = client.GetMessage(messageCount).Headers.Subject
            from = client.GetMessage(messageCount).Headers.From.Address

            If subj = "Consulta stock" And from = consultor Then
                client.DeleteMessage(messageCount)
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error al conectarse con el servidor")
        End Try
        Return False
    End Function

    Private Function consultarStock()
        ''TODO: This line of code loads data into the 'DataSet1.ingreso' table. You can move, or remove it, as needed.
        'Me.IngresoTableAdapter.Fill(Me.DataSet1.ingreso)
        ''TODO: This line of code loads data into the 'DataSet1.stock' table. You can move, or remove it, as needed.
        'Me.StockTableAdapter.Fill(Me.DataSet1.stock)
        ''TODO: This line of code loads data into the 'DataSet1.venta' table. You can move, or remove it, as needed.
        'Me.VentaTableAdapter.Fill(Me.DataSet1.venta)

        Dim string_salida As String
        string_salida = "CANTIDAD" + vbTab + vbTab + "NOMBRE" + vbTab + vbTab + vbTab + "DESCRIPCIÓN" + vbCr


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

        '''HACE ESTO POR CADA ITEM DEL STOCK
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
        Return string_salida
    End Function

    Private Sub Buttoncorreo_Click(sender As Object, e As EventArgs) Handles Buttoncorreo.Click



        stock.Hide()
        sell.Hide()
        client.Hide()
        prov.Hide()
        confAvisos.Hide()
        confAvisos.MdiParent = Me
        confAvisos.StartPosition = FormStartPosition.CenterScreen
        consulta.Abort()
        confAvisos.Show()


    End Sub
End Class
