Public Class Patient

    Private Sub PatientFormBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientFormBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PatientFormBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLeaders_PharmacyMSDataSet)

    End Sub

    Private Sub Patient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.PatientForm' table. You can move, or remove it, as needed.
        Me.PatientFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.PatientForm)

    End Sub
End Class