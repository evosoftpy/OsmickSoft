Imports System
Imports System.IO
Imports System.Text
Module moduloDatos
    Public i As Integer
    Public reset As Boolean = False
    Public dia As String = "none"
    Public correo As String = "ninguno"

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

        Dim ruta As String = "dataMail.conf"
        My.Computer.FileSystem.DeleteFile(ruta)
        Dim escritor As StreamWriter
        escritor = File.AppendText(ruta)
        escritor.Write(moduloDatos.correo + escritor.NewLine + moduloDatos.dia)
        escritor.Flush()
        escritor.Close()
    End Sub

    Public Sub leerArchivo()
        Dim objReader As New StreamReader("dataMail.conf")
        Dim sLine As String = ""
        Dim ban As Boolean = False
        'Dim arrText As New ArrayList()

        Do
            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then
                'arrText.Add(sLine)
                If correo <> "none" Then
                    If ban = False Then
                        moduloDatos.correo = sLine
                        ban = True
                    Else
                        moduloDatos.dia = sLine
                    End If
                End If
            End If
        Loop Until sLine Is Nothing
        objReader.Close()
        'MsgBox(correo + dia)
    End Sub
End Module
