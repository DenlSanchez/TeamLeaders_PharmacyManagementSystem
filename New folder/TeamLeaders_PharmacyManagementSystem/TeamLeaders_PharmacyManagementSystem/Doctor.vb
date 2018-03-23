Public Class Doctor

    Private Sub DoctorFormBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorFormBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DoctorFormBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLeaders_PharmacyMSDataSet)

    End Sub

    Private Sub Doctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.DoctorForm' table. You can move, or remove it, as needed.
        Me.DoctorFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.DoctorForm)

    End Sub
End Class