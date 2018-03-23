Public Class MainMenu

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TLPMS_UsersDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.TLPMS_UsersDataSet.Users)

        btndoctor.Enabled = False
        btngpa.Enabled = False
        btnpatient.Enabled = False
        btnpayment.Enabled = False
        btnpharmacy.Enabled = False
        btnpharoffice.Enabled = False
        btnlogout.Enabled = False

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndoctor.Click
        Doctor.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngpa.Click
        GPA.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpatient.Click
        Patient.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayment.Click
        Pharmacy.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpharmacy.Click
        Payment.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpharoffice.Click
        PharmacyOffice.Show()
    End Sub

    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        tbuser.Clear()
        tbpass.Clear()

        btndoctor.Enabled = False
        btngpa.Enabled = False
        btnpatient.Enabled = False
        btnpayment.Enabled = False
        btnpharmacy.Enabled = False
        btnpharoffice.Enabled = False
        btnlogout.Enabled = False
        btnlogin.Enabled = True
        btnclear.Enabled = True
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        ConfirmExit.Exitsystem()
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TLPMS_UsersDataSet)

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim log = Me.UsersTableAdapter.Userdetails(Me.tbuser.Text, Me.tbpass.Text)

        If log Is Nothing Then
            tbuser.Clear()
            tbpass.Clear()
            MessageBox.Show("Invalid Username/Password, Please check your details", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbuser.Focus()

        Else
            btndoctor.Enabled = True
            btngpa.Enabled = True
            btnpatient.Enabled = True
            btnpayment.Enabled = True
            btnpharmacy.Enabled = True
            btnpharoffice.Enabled = True
            btnlogout.Enabled = True
            btnlogin.Enabled = False
            btnclear.Enabled = False
        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        tbpass.Clear()
        tbuser.Clear()
    End Sub
End Class
