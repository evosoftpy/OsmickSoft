Public Class herramientas
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
End Class