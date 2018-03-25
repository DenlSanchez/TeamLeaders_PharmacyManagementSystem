Imports System.Data.OleDb

Public Class Pharmacy

    Dim provider As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.PharmacyForm' table. You can move, or remove it, as needed.
        Me.PharmacyFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.PharmacyForm)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PharmacyFormBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PharmacyFormBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PharmacyFormBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.PharmacyFormBindingSource.MoveNext()
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
        str = "Insert into PharmacyForm([Reference No], [Name of Tablets], [Dose(mg)], [Number of Tablets], [Issued Date], [Expiration Date], [Daily Dose], [Possible Side Effects], [Further Information], [Storage Advice], [Administration], [Driving and Using Machines], [How to Use Medication], [Patient ID], [Doctor's NHS No]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Reference No", CType(phar1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name of Tablets", CType(phar2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Dose(mg)", CType(phar3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Number of Tablets", CType(phar4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Issued Date", CType(phar5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Expiration Date", CType(phar6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Daily Dose", CType(phar7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Possible Side Effects", CType(phar8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Further Information", CType(phar9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Storage Advice", CType(phar10.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Administration", CType(phar11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Driving and Using Machines", CType(phar12.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("How to Use Medication", CType(phar13.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient ID", CType(phar14.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Doctor's NHS No", CType(phar15.Text, String)))

        On Error GoTo SaveErr
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        myConnection.Close()
        phar1.Clear()
        phar2.Clear()
        phar3.Clear()
        phar4.Clear()
        phar5.Clear()
        phar6.Clear()
        phar7.Clear()
        phar8.Clear()
        phar9.Clear()
        phar10.Clear()
        phar11.Clear()
        phar12.Clear()
        phar13.Clear()
        phar14.Clear()
        phar15.Clear()
        Me.PharmacyFormBindingSource.EndEdit()
        Me.PharmacyFormTableAdapter.Update(TeamLeaders_PharmacyMSDataSet.PharmacyForm)
        MessageBox.Show("Saved Successfully.", "Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
SaveErr: myConnection.Close()
    End Sub
End Class