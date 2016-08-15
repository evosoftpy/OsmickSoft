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

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ProgressBar1.Value = 30
        form_manager.stock.Hide()
        form_manager.sell.Hide()
        form_manager.client.Hide()
        form_manager.prov.Hide()
        form_manager.product.Hide()
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
        form_manager.product.Hide()
        ProgressBar1.Value = 70
        form_manager.prov.MdiParent = Me
        form_manager.prov.StartPosition = FormStartPosition.CenterScreen
        form_manager.prov.Show()

        ProgressBar1.Value = 100
        Refresh()



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

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        ProgressBar1.Value = 30
        form_manager.informe.MdiParent = Me
        form_manager.informe.StartPosition = FormStartPosition.CenterScreen
        form_manager.product.Hide()
        ProgressBar1.Value = 70
        form_manager.informe.Show()
        ProgressBar1.Value = 100
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
