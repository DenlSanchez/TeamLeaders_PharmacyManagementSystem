Imports System.Data.OleDb

Public Class Payment

    Dim provider As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet1.PaymentForm' table. You can move, or remove it, as needed.
        Me.PaymentFormTableAdapter1.Fill(Me.TeamLeaders_PharmacyMSDataSet2.PaymentForm)
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.PaymentForm' table. You can move, or remove it, as needed.
        Me.PaymentFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.PaymentForm)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PaymentFormBindingSource1.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PaymentFormBindingSource1.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PaymentFormBindingSource1.MovePrevious()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.PaymentFormBindingSource1.MoveNext()
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
        str = "Insert into PaymentForm([Invoice No], [Amount Paid], [Method of Payment], [Patient ID], [Per Paid Plan], [Patient NHS No], [Paid Thru Cash], [Paid Thru Credit Card], [Paid Thru Debit Card]) values (?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Invoice No", CType(pay1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Amount Paid", CType(pay2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Method of Payment", CType(pay3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient ID", CType(pay4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Per Paid Plan", CType(pay5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient NHS No", CType(pay6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Paid Thru Cash", CType(pay7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Paid Thru Credit Card", CType(pay8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Paid Thru Debit Card", CType(pay9.Text, String)))

        On Error GoTo SaveErr
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        myConnection.Close()
        pay1.Clear()
        pay2.Clear()
        pay3.Clear()
        pay4.Clear()
        pay5.Clear()
        pay6.Clear()
        pay7.Clear()
        pay8.Clear()
        pay9.Clear()
        Me.PaymentFormBindingSource1.EndEdit()
        Me.PaymentFormTableAdapter1.Update(TeamLeaders_PharmacyMSDataSet2.PaymentForm)
        MessageBox.Show("Saved Successfully.", "Pharmacy Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
SaveErr:
        myConnection.Close()
    End Sub
End Class