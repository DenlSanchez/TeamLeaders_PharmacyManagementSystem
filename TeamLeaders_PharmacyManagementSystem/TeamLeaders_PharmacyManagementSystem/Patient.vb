Imports System.Data.OleDb

Public Class Patient

    Dim provider As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Patient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.PatientForm' table. You can move, or remove it, as needed.
        Me.PatientFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.PatientForm)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PatientFormBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PatientFormBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PatientFormBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.PatientFormBindingSource.MoveNext()
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
        str = "Insert into PatientForm([NI No], [Firstname], [Surname], [Date of Birth], [Billing Name], [Address], [Postal Code], [City], [Country], [Phone Number], [Patient ID], [Patient NHS No], [GP Appointment Reference No]) values (?,?,?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("NI No", CType(pat1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Firstname", CType(pat2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Surname", CType(pat3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date of Birth", CType(pat4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Billing Name", CType(pat5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(pat6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Postal Code", CType(pat7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("City", CType(pat8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Country", CType(pat9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone Number", CType(pat10.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient ID", CType(pat11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient NHS No", CType(pat12.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("GP Appointment Reference No", CType(pat13.Text, String)))
        On Error GoTo SaveErr
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        myConnection.Close()
        pat1.Clear()
        pat2.Clear()
        pat3.Clear()
        pat4.Clear()
        pat5.Clear()
        pat6.Clear()
        pat7.Clear()
        pat8.Clear()
        pat9.Clear()
        pat10.Clear()
        pat11.Clear()
        pat12.Clear()
        pat13.Clear()
        Me.PatientFormBindingSource.EndEdit()
        Me.PatientFormTableAdapter.Update(TeamLeaders_PharmacyMSDataSet.PatientForm)
        MessageBox.Show("Saved Successfully.", "Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
SaveErr:
        myConnection.Close()
    End Sub
End Class