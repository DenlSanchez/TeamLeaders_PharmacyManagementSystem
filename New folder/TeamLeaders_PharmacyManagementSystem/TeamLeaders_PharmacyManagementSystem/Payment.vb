Public Class Payment

    Private Sub PaymentFormBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentFormBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaymentFormBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TeamLeaders_PharmacyMSDataSet)

    End Sub

    Private Sub Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.PaymentForm' table. You can move, or remove it, as needed.
        Me.PaymentFormTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.PaymentForm)

    End Sub
End Class