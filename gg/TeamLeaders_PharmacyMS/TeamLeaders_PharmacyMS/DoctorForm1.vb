Imports System.Data.OleDb

Public Class DoctorForm1

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub DoctorFormBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorFormBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DoctorForm1Binding.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLeaders_PharmacyMSDataSet)

    End Sub

    Private Sub DoctorForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.DoctorForm1' table. You can move, or remove it, as needed.
        Me.DoctorForm1TableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.DoctorForm1)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblDoctor.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.DoctorForm1BindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.DoctorForm1BindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ConfirmExitForm.Exitsystem()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DoctorForm1BindingSource.AddNew()

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\Denmark Sanchez\Desktop\New folder\TeamLeaders_PharmacyMS.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into DoctorForm([Doctor's Ref No],[Doctor's NHS No],[Firstname],[Surname],[Medical Center Name],[Address of Medical Center],[Phone No],[Email Address],[Patient Reference No],[GP Appointment Reference No],[Patient ID]) values (?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Doctor's Ref No", CType(Doctor_s_Ref_NoTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Doctor's NHS No", CType(Doctor_s_NHS_NoTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Firstname", CType(FirstnameTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Surname", CType(SurnameTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Medical Center Name", CType(Medical_Center_NameTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address of Medical Center", CType(Address_of_Medical_CenterTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone No", CType(Phone_NoTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Email Address", CType(Email_AddressTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient Reference No", CType(Patient_Reference_NoTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("GP Appointment Reference No", CType(GP_Appointment_Refererence_NoTextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient ID", CType(Patient_IDTextBox1.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            Doctor_s_Ref_NoTextBox1.Clear()
            Doctor_s_NHS_NoTextBox1.Clear()
            FirstnameTextBox1.Clear()
            SurnameTextBox1.Clear()
            Medical_Center_NameTextBox1.Clear()
            Address_of_Medical_CenterTextBox1.Clear()
            Phone_NoTextBox1.Clear()
            Email_AddressTextBox1.Clear()
            Patient_Reference_NoTextBox1.Clear()
            GP_Appointment_Refererence_NoTextBox1.Clear()
            Patient_IDTextBox1.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DoctorForm1BindingSource.RemoveCurrent()
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


    Private Sub DoctorForm1BindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorForm1BindingNavigator.RefreshItems

    End Sub

    Private Sub DoctorForm1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.DoctorForm1BindingSource.AddNew()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.DoctorForm1BindingSource.RemoveCurrent()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.DoctorForm1BindingSource.MoveNext()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.DoctorForm1BindingSource.MovePrevious()
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