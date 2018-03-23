Public Class PharmacyMS

    Private Sub PharmacyMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TLPMS_UsersDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.TLPMS_UsersDataSet.Users)
        BtnDoctor.Enabled = False
        BtnGPA.Enabled = False
        BtnPatient.Enabled = False
        BtnPayment.Enabled = False
        BtnPharmacy.Enabled = False
        BtnPharmacyOffice.Enabled = False
        BtnClose.Enabled = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTitle1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTitle2.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        ConfirmExitForm.Exitsystem()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBPassword.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDoctor.Click
        DoctorForm.Show()
    End Sub

    Private Sub BtnGPA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGPA.Click
        GPAForm.Show()
    End Sub

    Private Sub BtnPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPatient.Click
        PatientForm.Show()
    End Sub

    Private Sub BtnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPayment.Click
        PaymentForm.Show()
    End Sub

    Private Sub BtnPharmacy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPharmacy.Click
        PharmacyForm.Show()
    End Sub

    Private Sub BtnPharmacyOffice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPharmacyOffice.Click
        PharmacyOfficeForm.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        TBUsername.Clear()
        TBPassword.Clear()

        BtnDoctor.Enabled = False
        BtnGPA.Enabled = False
        BtnPatient.Enabled = False
        BtnPayment.Enabled = False
        BtnPharmacy.Enabled = False
        BtnPharmacyOffice.Enabled = False
        BtnClose.Enabled = False
        BtnLogin.Enabled = True
        BtnClear.Enabled = True
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TLPMS_UsersDataSet)

    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Dim log = Me.UsersTableAdapter.UserDetails(Me.TBUsername.Text, Me.TBPassword.Text)

        If log Is Nothing Then
            TBUsername.Clear()
            TBPassword.Clear()
            MessageBox.Show("Invalid Username/Password, Please check your details", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TBUsername.Focus()

        Else
            BtnDoctor.Enabled = True
            BtnGPA.Enabled = True
            BtnPatient.Enabled = True
            BtnPayment.Enabled = True
            BtnPharmacy.Enabled = True
            BtnPharmacyOffice.Enabled = True
            BtnClose.Enabled = True
            BtnLogin.Enabled = False
            BtnClear.Enabled = False
        End If
    End Sub

    Private Sub LblPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblPassword.Click

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TBPassword.Clear()
        TBUsername.Clear()
    End Sub
End Class
