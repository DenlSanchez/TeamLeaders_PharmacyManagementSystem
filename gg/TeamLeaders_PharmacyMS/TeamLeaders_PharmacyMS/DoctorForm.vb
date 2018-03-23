Imports System.Data.OleDb

Public Class DoctorForm

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub DoctorFormBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorFormBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DoctorFormBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLeaders_PharmacyMSDataSet)

    End Sub

    Private Sub DoctorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.DoctorForm' table. You can move, or remove it, as needed.
        Me.DoctorFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.DoctorForm)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblDoctor.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.DoctorFormBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.DoctorFormBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ConfirmExitForm.Exitsystem()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DoctorFormBindingSource.AddNew()

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Denmark Sanchez\Desktop\New folder\TeamLeaders_PharmacyMS.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into DoctorForm([Doctor's Ref No],[Doctor's NHS No],[Firstname],[Surname],[Medical Center Name],[Address of Medical Center],[Phone No],[Email Address],[Patient Reference No],[GP Appointment Reference No],[Patient ID]) values (?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Doctor's Ref No", CType(Doctor_s_Ref_NoTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Doctor's NHS No", CType(Doctor_s_NHS_NoTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Firstname", CType(FirstnameTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Surname", CType(SurnameTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Medical Center Name", CType(Medical_Center_NameTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address of Medical Center", CType(Address_of_Medical_CenterTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone No", CType(Phone_NoTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Email Address", CType(Email_AddressTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient Reference No", CType(Patient_Reference_NoTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("GP Appointment Reference No", CType(GP_Appointment_Refererence_NoTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient ID", CType(Patient_IDTextBox.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            Doctor_s_Ref_NoTextBox.Clear()
            Doctor_s_NHS_NoTextBox.Clear()
            FirstnameTextBox.Clear()
            SurnameTextBox.Clear()
            Medical_Center_NameTextBox.Clear()
            Address_of_Medical_CenterTextBox.Clear()
            Phone_NoTextBox.Clear()
            Email_AddressTextBox.Clear()
            Patient_Reference_NoTextBox.Clear()
            GP_Appointment_Refererence_NoTextBox.Clear()
            Patient_IDTextBox.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DoctorFormBindingSource.RemoveCurrent()
    End Sub

    Private Sub Phone_NoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Doctor_s_Ref_NoLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Doctor_s_Ref_NoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Doctor_s_NHS_NoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FirstnameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SurnameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Medical_Center_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Address_of_Medical_CenterTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Medical_Center_NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Address_of_Medical_CenterLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SurnameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FirstnameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Doctor_s_NHS_NoLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub DoctorFormBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorFormBindingNavigator.RefreshItems

    End Sub

    Private Sub DoctorForm_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DoctorFormBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorFormBindingSource1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DoctorFormBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.TeamLeaders_PharmacyMSDataSet1)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.DoctorFormBindingSource.AddNew()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.DoctorFormBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.DoctorFormBindingSource.MoveNext()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.DoctorFormBindingSource.MovePrevious()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ConfirmExitForm.Exitsystem()
    End Sub
End Class