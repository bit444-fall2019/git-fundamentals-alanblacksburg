Class MainWindow
    Private Sub OkButton_Click(sender As Object, e As RoutedEventArgs) Handles OkButton.Click
        Dim languageInput As String = LanguageTextbox.Text.ToLower()

        If languageInput = "vb.net" Then
            MsgBox("good choice")
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As RoutedEventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

End Class
