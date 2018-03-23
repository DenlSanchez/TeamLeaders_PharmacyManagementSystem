Public Class PharmacyOffice

    Private Sub PharmacyOffice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeamLeaders_PharmacyMSDataSet.Pharmacy_Office' table. You can move, or remove it, as needed.
        Me.Pharmacy_OfficeTableAdapter.Fill(Me.TeamLeaders_PharmacyMSDataSet.Pharmacy_Office)

    End Sub
End Class