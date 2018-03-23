Public Class GPA

    Private Sub GPAFormBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GPAFormBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GPAFormBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLeaders_PharmacyMSDataSet)

    End Sub

    Private Sub GPA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.GPAForm' table. You can move, or remove it, as needed.
        Me.GPAFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.GPAForm)

    End Sub
End Class