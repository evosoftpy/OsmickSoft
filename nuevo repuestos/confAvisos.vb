Public Class confAvisos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(ComboBox1.SelectedItem)
        If ComboBox1.SelectedItem = "Lunes" Then
            moduloDatos.dia = "Monday"
        ElseIf ComboBox1.SelectedItem = "Martes" Then
            moduloDatos.dia = "Tuesday"
        ElseIf ComboBox1.SelectedItem = "Miercoles" Then
            moduloDatos.dia = "Wednesday"
        ElseIf ComboBox1.SelectedItem = "Jueves" Then
            moduloDatos.dia = "Thursday"
        ElseIf ComboBox1.SelectedItem = "Viernes" Then
            moduloDatos.dia = "Friday"
        ElseIf ComboBox1.SelectedItem = "Sabado" Then
            moduloDatos.dia = "Saturday"
        ElseIf ComboBox1.SelectedItem = "Domingo" Then
            moduloDatos.dia = "Sunday"
        Else
            moduloDatos.dia = "none"
        End If

        moduloDatos.correo = TextBox1.Text
        moduloDatos.crearArchivo()
        moduloDatos.leerArchivo()

        Me.Hide()
    End Sub


End Class