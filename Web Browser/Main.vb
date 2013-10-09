Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtURL.Focus()
        wbrMain.Navigate("http://www.google.co.uk")

    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        Try
            If Mid(txtURL.Text, 1, 7) = "http://" Then
                wbrMain.Navigate(txtURL.Text)
            Else
                wbrMain.Navigate("http://" & txtURL.Text)
                txtURL.Text = "http://" & txtURL.Text
            End If

        Catch ex As Exception

            MsgBox("You are missing http:// please correct your mistake by adding http:// to the begining of your URL E.g. http://" & txtURL.Text)

        End Try
        

    End Sub

    Private Sub txtURL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtURL.KeyPress

        If Asc(e.KeyChar) = 13 Then

            cmdGo.PerformClick()

        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        Dim duplicate As Boolean = False

        For Each item In cmbFavourites.Items

            If LCase(item) = LCase(txtURL.Text) Then

                duplicate = True

            End If
        Next

        If duplicate = False Then

            cmbFavourites.Items.Add(txtURL.Text)

        Else

            MsgBox("Already Added!")

        End If

    End Sub

    Private Sub fav_Click(ByVal sender As ToolStripMenuItem, ByVal byvale As System.EventArgs)

        wbrMain.Navigate(sender.Tag)

    End Sub

    Private Sub cmdHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHome.Click

        wbrMain.GoHome()

    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click

        wbrMain.GoBack()

    End Sub

    Private Sub wbrMain_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbrMain.DocumentCompleted

        txtURL.Text = wbrMain.Url.ToString
        Me.Text = wbrMain.DocumentTitle & " | DiamentiumUK Browser"

        If My.Settings.History.Count > 0 Then
            If Not My.Settings.History.Item(My.Settings.History.Count - 1) = wbrMain.Url.ToString Then
                My.Settings.History.Add(wbrMain.Url.ToString)
            End If
        Else
            My.Settings.History.Add(wbrMain.Url.ToString)
        End If

        History.updateHistory()

    End Sub

    Private Sub wbrMain_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles wbrMain.ProgressChanged

        Try

            pgbDone.Maximum = e.MaximumProgress
            pgbDone.Value = e.CurrentProgress
            lblStatus.Text = wbrMain.StatusText

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click

        Application.Exit()

    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click

        History.ShowDialog()

    End Sub
End Class
