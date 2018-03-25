Public Class ConfirmExit

    Public Shared Function Exitsystem()
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Pharmacy Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Function

End Class
