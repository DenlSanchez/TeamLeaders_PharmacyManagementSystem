Public Class Pharmacy

    Private Sub PharmacyFormBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PharmacyFormBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PharmacyFormBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLeaders_PharmacyMSDataSet)

    End Sub

    Private Sub Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.PharmacyForm' table. You can move, or remove it, as needed.
        Me.PharmacyFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.PharmacyForm)

    End Sub
End Class