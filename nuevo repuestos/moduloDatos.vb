Imports System
Imports System.IO
Imports System.Text
Module moduloDatos
    Public i As Integer
    Public reset As Boolean = False
    Public dia As String = "none"
    Public correo As String = "ninguno"
    Public avisoEnviado As String = "false"

    Public Sub crearArchivo()


        ' Dim path As String = "dataMail.conf"
        ' Create or overwrite the file.


        'Dim fs As FileStream = File.Create(path)
        '' Add text to the file.
        'Dim info As Byte() = New UTF8Encoding(True).GetBytes(moduloDatos.correo)
        'fs.Write(info, 0, info.Length)
        'info = New UTF8Encoding(True).GetBytes(vbCr)
        'fs.Write(info, 0, info.Length)
        'info = New UTF8Encoding(True).GetBytes(moduloDatos.dia)
        'fs.Write(info, 0, info.Length)
        'fs.Close()
        MsgBox(avisoEnviado)
        Dim ruta As String = "dataMail.conf"
        Dim escritor As StreamWriter
        Try
            MsgBox(avisoEnviado.ToString + "hola")
            If My.Computer.FileSystem.FileExists(ruta) Then
                My.Computer.FileSystem.DeleteFile(ruta)
            End If

            escritor = File.AppendText(ruta)
            escritor.Write(moduloDatos.correo + escritor.NewLine + moduloDatos.dia + escritor.NewLine + moduloDatos.avisoEnviado)
            escritor.Flush()
            escritor.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Sub leerArchivo()
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

    End Sub
End Module
