﻿Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtURL.Focus()
        wbrMain.Navigate("http://www.google.co.uk")

    End Sub

    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click


        If Mid(txtURL.Text, 1, 7) = "http://" Then
            wbrMain.Navigate(txtURL.Text)
        Else
            MsgBox("You are missing http:// please correct your mistake by adding http:// to the begining of your URL E.g. http://www.google.co.uk")
        End If

        ' wbrMain.Navigate(txtURL.Text)

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

    Private Sub cmdHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHome.Click

        wbrMain.GoHome()

    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click

        wbrMain.GoBack()

    End Sub

End Class