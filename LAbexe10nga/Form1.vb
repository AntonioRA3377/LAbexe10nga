Imports System.IO

Public Class Form1

    Dim filePath As String = "numbers.txt"
    Dim numbers As New List(Of Integer)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If File.Exists(filePath) Then
            ReadNumbersFromFile()
        End If
    End Sub


    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Dim num As Integer = CInt(NumInput.Value)

        Using sw As New StreamWriter(filePath, True)
            sw.WriteLine(num)
        End Using

        MessageBox.Show("Number written to file successfully!", "WRITE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        NumInput.Value = 0
    End Sub


    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ReadNumbersFromFile()
    End Sub


    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        If numbers.Count = 0 Then
            MessageBox.Show("No numbers to sort. Please read from file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim sorted = numbers.OrderBy(Function(n) n).ToList()


        Using sw As New StreamWriter(filePath, False)
            For Each num In sorted
                sw.WriteLine(num)
            Next
        End Using

        numbers = sorted
        Listbox1.Items.Clear()
        For Each num In numbers
            Listbox1.Items.Add(num)
        Next

        MessageBox.Show("Numbers sorted, saved, and refreshed successfully!", "SORT", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub ReadNumbersFromFile()
        If Not File.Exists(filePath) Then
            MessageBox.Show("File not found! Please write numbers first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Listbox1.Items.Clear()
        numbers.Clear()

        Using sr As New StreamReader(filePath)
            While Not sr.EndOfStream
                Dim line As String = sr.ReadLine()
                Dim val As Integer
                If Integer.TryParse(line, val) Then
                    numbers.Add(val)
                    Listbox1.Items.Add(val)
                End If
            End While
        End Using

        MessageBox.Show("Numbers read successfully!", "READ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
