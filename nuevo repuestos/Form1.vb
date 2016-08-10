Imports System.Net.Mail
Public Class Form1
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DataSet1.cliente)
        consultas.Start()
        avisos.Start()

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

        correo.From = New MailAddress("gab753@gmail.com", "Repuestos Evosoft", System.Text.Encoding.UTF8)
        correo.To.Add("dahianasaguier@gmail.com")
        correo.SubjectEncoding = System.Text.Encoding.UTF8
        correo.Subject = "Asunto de tu mensaje"
        correo.Body = "Cuerpo del mensaje"
        correo.BodyEncoding = System.Text.Encoding.UTF8
        correo.IsBodyHtml = False
        correo.Priority = MailPriority.High

        smtp.Credentials = New System.Net.NetworkCredential("gab753@gmail.com", "password")
        smtp.Port = 587
        smtp.Host = "smtp.gmail.com"
        smtp.EnableSsl = True

        smtp.Send(correo)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub avisos_Tick(sender As Object, e As EventArgs) Handles avisos.Tick
        Dim dia As Date
        dia = Date.Now

        Try
            If dia.DayOfWeek.ToString = "Wednesday" Then
                MsgBox("Es miercoles")
            End If
        Catch ex As Exception
        End Try

        avisos.Stop()
        avisos.Interval = 3600000
        avisos.Start()
    End Sub

    Private Sub consultas_Tick(sender As Object, e As EventArgs) Handles consultas.Tick


        Try
            'verificar si hay consultar en el correo
        Catch ex As Exception
        End Try

        consultas.Stop()
        consultas.Interval = 600000
        consultas.Start()
    End Sub

    Function buscarStockBajo()
        Dim stock As String
        Dim cod As String
        Dim codigos As List(Of String)
        Dim i, n As Integer
        n = DataSet1.Tables("stock").Rows.Count
        Try
            For i = 0 To n
                cod = DataSet1.Tables("stock").Rows(i).Item("codigo")
                If codigos.Exists(cod) Then

                End If
            Next


        Catch ex As Exception

        End Try


        Return stock
    End Function
End Class
