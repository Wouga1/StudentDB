﻿Public Class Form1
    'set up a record or "class" for a student
    Class STUDENT
        Public firstname As String
        Public lastname As String
        Public DOB As Date
        Public gender As Char
        Public avMk As Single
        Public phoneNo As String
        Public paid As Boolean
    End Class
    Dim students(20) As STUDENT
    Dim studentCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        For i = 0 To 20
            students(i) = New STUDENT
        Next
        'load 4 test records
        students(0).firstname = "Johnny"
        students(0).lastname = "Depp"
        students(0).DOB = "9/6/63"
        students(0).gender = "m"
        students(0).avMk = 78.2
        students(0).phoneNo = "0123456789"
        students(0).paid = False
        students(1).firstname = "Jennifer"
        students(1).lastname = "Lawrence"
        students(1).DOB = "15/8/90"
        students(1).gender = "f"
        students(1).avMk = 88.2
        students(1).phoneNo = "0987654321"
        students(1).paid = True
        students(2).firstname = "George"
        students(2).lastname = "Clooney"
        students(2).DOB = "6/5/61"
        students(2).gender = "f"
        students(2).avMk = 68.2
        students(3).firstname = "Scarlett"
        students(3).lastname = "Johansson"
        students(3).DOB = "22/11/84"
        students(3).gender = "f"
        students(3).avMk = 72.2
        students(4).firstname = "Johnny"
        students(4).lastname = "Deppy"
        students(4).DOB = "9/6/68"
        students(4).gender = "m"
        students(4).avMk = 78.2
        students(4).phoneNo = "0123456789"
        students(4).paid = False
        students(5).firstname = "Fred"
        students(5).lastname = "Bear"
        students(5).DOB = "9/4/63"
        students(5).gender = "m"
        students(5).avMk = 78.2
        students(5).phoneNo = "0123456789"
        students(5).paid = False
        students(6).firstname = "Mickey"
        students(6).lastname = "Mouse"
        students(6).DOB = "28/12/98"
        students(6).gender = "m"
        students(6).avMk = 78.2
        students(6).phoneNo = "0123456789"
        students(6).paid = False
        students(7).firstname = "Fred"
        students(7).lastname = "Flintstone"
        students(7).DOB = "4/11/03"
        students(7).gender = "m"
        students(7).avMk = 78.2
        students(7).phoneNo = "0123456789"
        students(7).paid = False
        students(8).firstname = "Minnie"
        students(8).lastname = "Mouse"
        students(8).DOB = "9/6/63"
        students(8).gender = "f"
        students(8).avMk = 78.2
        students(8).phoneNo = "0123455555"
        students(8).paid = True
        students(9).firstname = "Boo"
        students(9).lastname = "Depp"
        students(9).DOB = "9/6/01"
        students(9).gender = "m"
        students(9).avMk = 99
        students(9).phoneNo = "0123456789"
        students(9).paid = False
        students(10).firstname = "Lori Anne"
        students(10).lastname = "Allison"
        students(10).DOB = "9/6/63"
        students(10).gender = "f"
        students(10).avMk = 66
        students(10).phoneNo = "0123456789"
        students(10).paid = False
        students(11).firstname = "Amber"
        students(11).lastname = "Heard"
        students(11).DOB = "28/2/00"
        students(11).gender = "f"
        students(11).avMk = 77
        students(11).phoneNo = "0123456789"
        students(11).paid = False
        students(12).firstname = "Pistol"
        students(12).lastname = "Depp"
        students(12).DOB = "9/6/98"
        students(12).gender = "m"
        students(12).avMk = 3
        students(12).phoneNo = "0123456789"
        students(12).paid = False
        'set the student count to the number of students which have been entered
        studentCount = 13
        displayList()
    End Sub
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        If txtFirstName.Text = "" Then
            MsgBox("Please enter a first name", MsgBoxStyle.Exclamation, "Problem with First Name")
            txtFirstName.Focus()
            Exit Sub
        End If
        If txtLastName.Text = "" Then
            MsgBox("Please enter a last name", MsgBoxStyle.Exclamation, "Problem with Last Name")
            txtLastName.Focus()
            Exit Sub
        End If

        If txtGender.Text <> "f" And txtGender.Text <> "m" Then
            MsgBox("Please enter 'm' or 'f'", MsgBoxStyle.Exclamation, "Problem with Gender")
            txtGender.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtAvMk.Text) Then
            MsgBox("Please enter a number", MsgBoxStyle.Exclamation, "Problem with Average Mark")
            txtAvMk.Focus()
            Exit Sub
        ElseIf txtAvMk.Text < 0 Or txtAvMk.Text > 100 Then
            MsgBox("Please enter a number between 0 and 100", MsgBoxStyle.Exclamation, "Problem with Average Mark")
            txtAvMk.Focus()
            Exit Sub
        End If

        If Not Len(Trim(txtPhone.Text)) = 12 Then
            MsgBox("Please enter a 10 digit phone number", MsgBoxStyle.Exclamation, "Problem with Phone Number")
            txtPhone.Focus()
            Exit Sub
        End If
        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstname = txtFirstName.Text
        students(studentCount).lastname = txtLastName.Text
        students(studentCount).DOB = txtDOB.Text
        students(studentCount).gender = txtGender.Text
        students(studentCount).avMk = txtAvMk.Text
        students(studentCount).phoneNo = txtPhone.Text
        students(studentCount).paid = chkPaid.Checked
        studentCount += 1
        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDOB.Text = ""
        txtGender.Text = ""
        txtAvMk.Text = ""
        txtPhone.Text = ""
        displayList()
        txtFirstName.Focus()
    End Sub
    Private Sub displayList()
        'clear the list box as it keeps the earlier loop
        lstStud.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            lstStud.Items.Add(students(i).firstname & " - " & students(i).lastname & " - " &
                              students(i).DOB & " - " & students(i).gender & " - " & students(i).avMk & "-" & students(i).phoneNo & "-" & students(i).paid & ".")
        Next
        lstStud.SelectedIndex = studentCount - 1
    End Sub

    Private Sub btnFindStud_Click(sender As Object, e As EventArgs) Handles btnFindStud.Click
        If txtLastName.Text = "" Then
            MsgBox("Please enter a last name", MsgBoxStyle.Exclamation, "Problem with Last Name")
            txtLastName.Focus()
            Exit Sub
        End If
        Dim foundName As Boolean
        Dim searchCount As Integer
        While searchCount < studentCount And foundName = False
            If students(searchCount).lastname = txtLastName.Text Then
                foundName = True
                lstStud.SelectedIndex = searchCount
            End If
            searchCount += 1
        End While
        If Not foundName Then
            txtSelectedItem.Text = "This student could not be found!"
        End If
    End Sub

    Private Sub lstStud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStud.SelectedIndexChanged
        txtSelectedItem.Text = lstStud.SelectedItem
        txtSelectedIndex.Text = lstStud.SelectedIndex
    End Sub
End Class
