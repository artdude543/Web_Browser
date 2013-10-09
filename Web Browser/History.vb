Public Class History

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Friend Sub updateHistory()

        lstHistory.Items.Clear()
        If My.Settings.History.Count > 0 Then

            For Each historyitem As String In My.Settings.History
                lstHistory.Items.Add(historyitem)

            Next
        Else
            cmdDeleteAll.Enabled = False

        End If

    End Sub

    Private Sub lstHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHistory.SelectedIndexChanged

        cmdDelete.Enabled = True

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        My.Settings.History.RemoveAt(lstHistory.SelectedIndex)
        My.Settings.Save()
        updateHistory()
        cmdDelete.Enabled = False

    End Sub

    Private Sub cmdDeleteAll_Click(sender As Object, e As EventArgs) Handles cmdDeleteAll.Click

        My.Settings.History.Clear()
        My.Settings.Save()
        updateHistory()

    End Sub
End Class