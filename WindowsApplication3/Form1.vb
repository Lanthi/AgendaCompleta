Imports System
Imports System.Text
Imports System.Text.RegularExpressions.Regex

Public Class Form1
    Dim HorasMAngelesLunes = {"09:00", "09:45", "10:30P", "11:30", "12:15", "-----", "16:15", "17:00P", "18:00", "18:45", "--:--", "--:--"}
    Dim HorasMAngelesMartes = {"09:00", "09:45P", "10:45", "11:30", "--:--", "-----", "16:00", "16:45", "17:30P", "18:30", "19:15", "--:--"}
    Dim HorasMAngelesMiercoles = {"09:00", "09:45", "10:30P", "11:30", "12:15", "-----", "16:00", "17:00", "18:00", "18:45", "--:--", "--:--"}
    Dim HorasMAngelesJueves = {"09:00", "09:45P", "10:45", "11:30", "--:--", "-----", "16:00", "16:45", "17:30P", "18:30", "19:15", "--:--"}
    Dim HorasMAngelesViernes = {"09:00", "09:45", "10:30", "11:15", "--:--", "-----", "16:00", "16:45", "17:30", "18:15", "19:00", "--:--"}

    Dim HorasMariaLunes = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:30", "17:15", "18:00", "18:45", "19:30P", "--:--"}
    Dim HorasMariaMartes = {"09:00", "09:45", "10:30", "11:30", "--:--", "-----", "16:15", "17:00", "17:45", "18:30", "19:15", "20:00P"}
    Dim HorasMariaMiercoles = {"09:00", "09:45", "10:30", "11:30", "12:15", "-----", "16:30", "17:15", "18:00", "18:45", "19:30P", "--:--"}
    Dim HorasMariaJueves = {"09:00", "09:45", "10:30", "11:30", "12:15", "-----", "16:15", "17:00", "17:45", "18:30", "19:15", "20:00P"}
    Dim HorasMariaViernes = {"09:00", "09:45", "10:30", "11:30", "12:15", "-----", "16:00", "16:45", "17:30", "18:15", "19:00", "19:45"}

    Dim HorasGloriaLunes = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:00", "16:45", "17:30", "18:15", "19:00", "19:45"}
    Dim HorasGloriaMartes = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:30", "17:15", "18:00", "18:45", "19:30", "20:15"}
    Dim HorasGloriaMiercoles = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:00", "16:45", "17:30", "18:15", "19:00", "19:45"}
    Dim HorasGloriaJueves = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:30", "17:15", "18:00", "18:45", "19:30", "20:15"}
    Dim HorasGloriaViernes = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:00", "16:45", "17:30", "18:15", "--:--", "--:--"}

    Dim HorasMartaLunes = {"09:00", "09:45", "10:30", "11:15", "--:--", "-----", "16:00", "16:45", "17:30", "18:15", "19:00", "19:45"}
    Dim HorasMartaMartes = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:30", "17:15", "18:00", "18:45", "19:30", "20:15"}
    Dim HorasMartaMiercoles = {"09:00", "09:45", "10:30", "11:15", "--:--", "-----", "16:00", "16:45", "17:30", "18:15", "19:00", "19:45"}
    Dim HorasMartaJueves = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:30", "17:15", "18:00", "18:45", "19:30", "20:15"}
    Dim HorasMartaViernes = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:00", "16:45", "17:30", "18:15", "19:00", "19:45"}

    Dim HorasSergioLunes = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:00", "16:45", "17:30", "18:15", "19:00", "19:45"}
    Dim HorasSergioMartes = {"09:00", "09:45", "10:30", "11:15", "--:--", "-----", "16:30", "17:15", "18:00", "18:45", "19:30", "20:15"}
    Dim HorasSergioMiercoles = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:00", "16:45", "17:30", "18:15", "19:00", "19:45"}
    Dim HorasSergioJueves = {"09:00", "09:45", "10:30", "11:15", "--:--", "-----", "16:30", "17:15", "18:00", "18:45", "19:30", "20:15"}
    Dim HorasSergioViernes = {"09:00", "09:45", "10:30", "11:15", "12:00", "-----", "16:00", "16:45", "17:30", "18:15", "19:00", "19:45"}

    Dim Horasfinde = {"??:??", "??:??", "??:??", "??:??", "??:??", "-----", "??:??", "??:??", "??:??", "??:??", "??:??", "??:??"}
    Dim DiaSemanaSeleccionado As String

    Private Sub IdentificacionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles IdentificacionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.IdentificacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CONSULV4DataSet)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CONSULV4DataSet.Historias' Puede moverla o quitarla según sea necesario.
        Me.HistoriasTableAdapter.Fill(Me.CONSULV4DataSet.Historias)
        Me.IdentificacionTableAdapter.Fill(Me.CONSULV4DataSet.Identificacion)
        Dim ContadorDePacientes As Integer = BindingNavigatorCountItem.Text
        For I = 1 To ContadorDePacientes
            Dim reg As RegularExpressions.Regex
            Dim textoOriginal As String = NombreTextBox.Text
            Dim textoNormalizado As String = textoOriginal.Normalize(NormalizationForm.FormD)
            reg = New RegularExpressions.Regex("[^a-zA-Z0-9ªº() ]")
            Dim textoSinAcentos As String = reg.Replace(textoNormalizado, "")
            ListBox2.Items.Add(textoSinAcentos)
            IdentificacionBindingSource.MoveNext()
        Next
        DiaSemanaSeleccionado = DateTimePicker1.Value.DayOfWeek.ToString
        TextBox2.Text = DiaSemanaSeleccionado
        GroupBox1.Visible = False
        CargarColumnas()
    End Sub

    Private Sub ListBox2_Click(sender As Object, e As EventArgs) Handles ListBox2.Click
        LblSelec.Text = ListBox2.Text
        BuscarRegistro(ListBox2.Text)
    End Sub
    Private Sub CargarColumnas()
        TreeView1.Nodes.Clear()
        TreeView2.Nodes.Clear()
        TreeView3.Nodes.Clear()
        TreeView4.Nodes.Clear()
        TreeView5.Nodes.Clear()
        Dim VariableColumna
        Select Case DiaSemanaSeleccionado
            Case "Monday" : VariableColumna = HorasMAngelesLunes
            Case "Tuesday" : VariableColumna = HorasMAngelesMartes
            Case "Wednesday" : VariableColumna = HorasMAngelesMiercoles
            Case "Thursday" : VariableColumna = HorasMAngelesJueves
            Case "Friday" : VariableColumna = HorasMAngelesViernes
            Case Else : VariableColumna = Horasfinde
        End Select
        For I = 0 To VariableColumna.GetUpperBound(0)
            If VariableColumna(I) = "-----" Then
                TreeView1.Nodes.Add("___________________________")
            ElseIf VariableColumna(I) = "--:--" Then
                TreeView1.Nodes.Add("")
            ElseIf VariableColumna(I) = "??:??" Then
                TreeView1.Nodes.Clear()
            Else
                If VariableColumna(I) = "10:30P" Then
                    TreeView1.Nodes.Add("10:30: Pilates")
                ElseIf VariableColumna(I) = "09:45P" Then
                    TreeView1.Nodes.Add("09:45: Pilates")
                ElseIf VariableColumna(I) = "17:00P" Then
                    TreeView1.Nodes.Add("17:00 Pilates")
                ElseIf VariableColumna(I) = "17:30P" Then
                    TreeView1.Nodes.Add("17:30: Pilates")
                ElseIf VariableColumna(I) = "19:30P" Then
                    TreeView1.Nodes.Add("19:30: Pilates")
                ElseIf VariableColumna(I) = "20:00P" Then
                    TreeView1.Nodes.Add("20:00: Pilates")
                Else
                    TreeView1.Nodes.Add(VariableColumna(I) & ": ---")
                End If
            End If
        Next
        Select Case DiaSemanaSeleccionado
            Case "Monday" : VariableColumna = HorasMariaLunes
            Case "Tuesday" : VariableColumna = HorasMariaMartes
            Case "Wednesday" : VariableColumna = HorasMariaMiercoles
            Case "Thursday" : VariableColumna = HorasMariaJueves
            Case "Friday" : VariableColumna = HorasMariaViernes
            Case Else : VariableColumna = Horasfinde
        End Select
        For I = 0 To VariableColumna.GetUpperBound(0)
            If VariableColumna(I) = "-----" Then
                TreeView2.Nodes.Add("___________________________")
            ElseIf VariableColumna(I) = "--:--" Then
                TreeView2.Nodes.Add("")
            ElseIf VariableColumna(I) = "??:??" Then
                TreeView2.Nodes.Clear()
            Else
                If VariableColumna(I) = "10:30P" Then
                    TreeView2.Nodes.Add("10:30: Pilates")
                ElseIf VariableColumna(I) = "9:45P" Then
                    TreeView2.Nodes.Add("9:45: Pilates")
                ElseIf VariableColumna(I) = "17:00P" Then
                    TreeView2.Nodes.Add("17:00 Pilates")
                ElseIf VariableColumna(I) = "17:30P" Then
                    TreeView2.Nodes.Add("17:30: Pilates")
                ElseIf VariableColumna(I) = "19:30P" Then
                    TreeView2.Nodes.Add("19:30: Pilates")
                ElseIf VariableColumna(I) = "20:00P" Then
                    TreeView2.Nodes.Add("20:00: Pilates")
                Else
                    TreeView2.Nodes.Add(VariableColumna(I) & ": ---")
                End If
            End If
        Next
        Select Case DiaSemanaSeleccionado
            Case "Monday" : VariableColumna = HorasGloriaLunes
            Case "Tuesday" : VariableColumna = HorasGloriaMartes
            Case "Wednesday" : VariableColumna = HorasGloriaMiercoles
            Case "Thursday" : VariableColumna = HorasGloriaJueves
            Case "Friday" : VariableColumna = HorasGloriaViernes
            Case Else : VariableColumna = Horasfinde
        End Select
        For I = 0 To VariableColumna.GetUpperBound(0)
            If VariableColumna(I) = "-----" Then
                TreeView3.Nodes.Add("___________________________")
            ElseIf VariableColumna(I) = "--:--" Then
                TreeView3.Nodes.Add("")
            ElseIf VariableColumna(I) = "??:??" Then
                TreeView3.Nodes.Clear()
            Else
                TreeView3.Nodes.Add(VariableColumna(I) & ": ---")
            End If
        Next

        Select Case DiaSemanaSeleccionado
            Case "Monday" : VariableColumna = HorasMartaLunes
            Case "Tuesday" : VariableColumna = HorasMartaMartes
            Case "Wednesday" : VariableColumna = HorasMartaMiercoles
            Case "Thursday" : VariableColumna = HorasMartaJueves
            Case "Friday" : VariableColumna = HorasMartaViernes
            Case Else : VariableColumna = Horasfinde
        End Select
        For I = 0 To VariableColumna.GetUpperBound(0)
            If VariableColumna(I) = "-----" Then
                TreeView4.Nodes.Add("___________________________")
            ElseIf VariableColumna(I) = "--:--" Then
                TreeView4.Nodes.Add("")
            ElseIf VariableColumna(I) = "??:??" Then
                TreeView4.Nodes.Clear()
            Else
                TreeView4.Nodes.Add(VariableColumna(I) & ": ---")
            End If
        Next
        Select Case DiaSemanaSeleccionado
            Case "Monday" : VariableColumna = HorasSergioLunes
            Case "Tuesday" : VariableColumna = HorasSergioMartes
            Case "Wednesday" : VariableColumna = HorasSergioMiercoles
            Case "Thursday" : VariableColumna = HorasSergioJueves
            Case "Friday" : VariableColumna = HorasSergioViernes
            Case Else : VariableColumna = Horasfinde
        End Select
        For I = 0 To VariableColumna.GetUpperBound(0)
            If VariableColumna(I) = "-----" Then
                TreeView5.Nodes.Add("___________________________")
            ElseIf VariableColumna(I) = "--:--" Then
                TreeView5.Nodes.Add("")
            ElseIf VariableColumna(I) = "??:??" Then
                TreeView5.Nodes.Clear()
            Else
                TreeView5.Nodes.Add(VariableColumna(I) & ": ---")
            End If
        Next
        VaciarDatos()
    End Sub
    Private Sub VaciarDatos()
        NombreTextBox1.Text = ""
        NumIDTextBox.Text = ""
        DomicilioTextBox.Text = ""
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True

        Button1.Enabled = True
        Button1.Enabled = True
        Button1.Enabled = True
        VaciarDatosPaciente()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        FindMyString(TextBox1.Text)
    End Sub
    Private Sub FindMyString(ByVal searchString As String)
        ' Ensure we have a proper string to search for.
        If searchString <> String.Empty Then
            ' Find the item in the list and store the index to the item.
            Dim index As Integer = ListBox2.FindString(searchString)
            ' Determine if a valid index is returned. Select the item if it is valid.
            If index <> -1 Then
                ListBox2.SetSelected(index, True)
                ListBox2.TopIndex = ListBox2.SelectedIndex
                ListBox2.SetSelected(index, False)
            End If
        End If
    End Sub
    Private Sub BuscarRegistro(ByVal TextoBuscar As String)
        VaciarDatos()
        IdentificacionBindingSource.MoveFirst()
        Dim ContadorDePacientes As Integer = BindingNavigatorCountItem.Text
        ' BindingNavigatorCountItem.Text = "de {0}"
        For I = 1 To ContadorDePacientes
            Dim reg As RegularExpressions.Regex
            Dim textoOriginal As String = NombreTextBox1.Text
            Dim textoNormalizado As String = textoOriginal.Normalize(NormalizationForm.FormD)
            reg = New RegularExpressions.Regex("[^a-zA-Z0-9ªº() ]")
            Dim textoSinAcentos As String = reg.Replace(textoNormalizado, "")
            If textoSinAcentos = LblSelec.Text Then
                Exit For
            Else
                IdentificacionBindingSource.MoveNext()
            End If
        Next

    End Sub
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Label1.Text = TreeView1.SelectedNode.Text
        If Mid(TreeView1.SelectedNode.Text, 8) = "---" Then
            GroupBox1.Visible = True
        End If
    End Sub
    Private Sub CargarDatosPaciente()

    End Sub
    Private Sub VaciarDatosPaciente()
        NombreTextBox2.Text = ""
        DomicilioTextBox1.Text = ""
        ObservacionesTextBox.Text = ""
        NumIDTextBox1.Text = ""
        TelTextBox.Text = ""
        ProxCitaTextBox.Text = ""
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DiaSemanaSeleccionado = DateTimePicker1.Value.DayOfWeek.ToString
        TextBox2.Text = DiaSemanaSeleccionado
        CargarColumnas()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.Enabled = False
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

    End Sub

    Private Sub BirthDateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles BirthDateDateTimePicker.ValueChanged

    End Sub
End Class
