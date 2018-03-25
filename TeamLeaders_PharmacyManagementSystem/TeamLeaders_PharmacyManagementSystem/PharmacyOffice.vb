Imports System.Data.OleDb

Public Class PharmacyOffice

    Dim provider As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub PharmacyOffice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.Pharmacy_Office' table. You can move, or remove it, as needed.
        Me.Pharmacy_OfficeTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.Pharmacy_Office)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Pharmacy_OfficeBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Pharmacy_OfficeBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Pharmacy_OfficeBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Pharmacy_OfficeBindingSource.MoveNext()
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
        str = "Insert into Pharmacy_Office([Reference No], [Patient ID], [Doctor's NHS No], [Medical Center Name], [DoctorForm.GP Appointment Reference No], [Patient Reference No], [GPAForm.GP Appointment Reference No], [Billing Name], [NI No], [Firstname], [Surname], [Date of Birth], [Address], [Country], [City], [Amount Paid], [Method of Payment], [Patient NHS No], [Patient NHS No], [Invoice No]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Reference No", CType(pharoff1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient ID", CType(pharoff2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Doctor's NHS No", CType(pharoff3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Medical Center Name", CType(pharoff4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DoctorForm.GP Appointment Reference No", CType(pharoff5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient Reference No", CType(pharoff6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("GPAForm.GP Appointment Reference No", CType(pharoff7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Billing Name", CType(pharoff8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("NI No", CType(pharoff9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Firstname", CType(pharoff10.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Surname", CType(pharoff11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date of Birth", CType(pharoff12.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(pharoff13.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Country", CType(pharoff14.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("City", CType(pharoff15.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Amount Paid", CType(pharoff16.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Method of Payment", CType(pharoff17.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient NHS No", CType(pharoff18.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Invoice No", CType(pharoff19.Text, String)))

        On Error GoTo SaveErr
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        myConnection.Close()
        pharoff1.Clear()
        pharoff2.Clear()
        pharoff3.Clear()
        pharoff4.Clear()
        pharoff5.Clear()
        pharoff6.Clear()
        pharoff7.Clear()
        pharoff8.Clear()
        pharoff9.Clear()
        pharoff10.Clear()
        pharoff11.Clear()
        pharoff12.Clear()
        pharoff13.Clear()
        pharoff14.Clear()
        pharoff15.Clear()
        pharoff16.Clear()
        pharoff17.Clear()
        pharoff18.Clear()
        pharoff19.Clear()
        Me.Pharmacy_OfficeBindingSource.EndEdit()
        MessageBox.Show("Saved Successfully.", "Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
SaveErr:
        myConnection.Close()
    End Sub
End Class