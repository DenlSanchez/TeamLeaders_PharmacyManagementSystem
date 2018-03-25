Imports System.Data.OleDb

Public Class Doctor

    Dim provider As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Doctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.DoctorForm' table. You can move, or remove it, as needed.
        Me.DoctorFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.DoctorForm)

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Me.DoctorFormBindingSource.AddNew()
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Me.DoctorFormBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        Me.DoctorFormBindingSource.MovePrevious()
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        Me.DoctorFormBindingSource.MoveNext()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to close this window?", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Me.Close()
            MainMenu.Show()
        End If
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Denmark Sanchez\Desktop\New folder\TeamLeaders_PharmacyManagementSystem\TeamLeaders_PharmacyManagementSystem\bin\Debug\TeamLeaders_PharmacyMS.accdb"
        connString = provider
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into DoctorForm([Doctor's Ref No], [Doctor's NHS No], [Firstname], [Surname], [Medical Center Name], [Address of Medical Center], [Phone No], [Email Address], [Patient Reference No], [GP Appointment Reference No], [Patient ID]) values (?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Doctor's Ref No", CType(doc1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Doctor's NHS No", CType(doc2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Firstname", CType(doc3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Surname", CType(doc4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Medical Center Name", CType(doc5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address of Medical Center", CType(doc6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone No", CType(doc7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Email Address", CType(doc8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient Reference No", CType(doc9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("GP Appointment Reference No", CType(doc10.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient ID", CType(doc11.Text, String)))

        On Error GoTo SaveErr
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        myConnection.Close()
        doc1.Clear()
        doc2.Clear()
        doc3.Clear()
        doc4.Clear()
        doc5.Clear()
        doc6.Clear()
        doc7.Clear()
        doc8.Clear()
        doc9.Clear()
        doc10.Clear()
        doc11.Clear()
        Me.DoctorFormBindingSource.EndEdit()
        Me.DoctorFormTableAdapter.Update(TeamLeaders_PharmacyMSDataSet.DoctorForm)
        MessageBox.Show("Saved Successfully.", "Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
SaveErr:
        myConnection.Close()
    End Sub
End Class