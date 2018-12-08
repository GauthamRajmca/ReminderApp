Public Class Form1

    Dim currenttime As String
    Dim messagetime As String


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currenttime = TimeOfDay.ToString("hh:mm:ss tt")
        Label1.Text = currenttime
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        messagetime = MaskedTextBox1.Text + " " + ComboBox1.Text
        Label4.Text = "Reminder set for:" + messagetime

        If currenttime = messagetime Then
            Timer2.Stop()
            MsgBox(TextBox1.Text)
            Button1.Enabled = True
            Button2.Enabled = False
            Label4.Text = ""
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer2.Start()
        Button1.Enabled = False
        Button2.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Timer2.Stop()
        Button1.Enabled = True
        Button2.Enabled = False
        Label4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NotifyIcon1.Visible = True
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(3000)

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        Me.Show()
        NotifyIcon1.Visible = False

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub
End Class
