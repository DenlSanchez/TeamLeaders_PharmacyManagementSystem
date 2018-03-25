Imports System.Data.OleDb

Public Class GPA

    Dim provider As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub GPA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.GPAForm' table. You can move, or remove it, as needed.
        Me.GPAFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.GPAForm)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.GPAFormBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.GPAFormBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.GPAFormBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.GPAFormBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to close this window? Please make sure that you saved yung operation, else this will erase all data. Continue?", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Me.Close()
            MainMenu.Show()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Denmark Sanchez\Desktop\New folder\TeamLeaders_PharmacyManagementSystem\TeamLeaders_PharmacyManagementSystem\bin\Debug\TeamLeaders_PharmacyMS.accdb"
        connString = provider
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into GPAForm([GP Appointment Reference No], [Patient NHS No], [GP Appointment], [Patient Full Name], [Patient ID], [Medical Center Name], [Doctor's NHS No]) values (?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("GP Appointment Reference No", CType(gpa1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient NHS No", CType(gpa2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("GP Appointment", CType(gpa3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient Full Name", CType(gpa4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient ID", CType(gpa5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Medical Center Name", CType(gpa6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Doctor's NHS No", CType(gpa7.Text, String)))

        On Error GoTo SaveErr
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        myConnection.Close()
        gpa1.Clear()
        gpa2.Clear()
        gpa3.Clear()
        gpa4.Clear()
        gpa5.Clear()
        gpa6.Clear()
        gpa7.Clear()
        Me.GPAFormBindingSource.EndEdit()
        Me.GPAFormTableAdapter.Update(TeamLeaders_PharmacyMSDataSet.GPAForm)
        MessageBox.Show("Saved Successfully.", "Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
SaveErr:
        myConnection.Close()
    End Sub
End Class