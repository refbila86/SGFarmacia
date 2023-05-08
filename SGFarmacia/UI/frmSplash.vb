Public Class frmSplash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 2
        If (ProgressBar1.Value = 10) Then
            Label1.Text = "Reading modules.."
        ElseIf (ProgressBar1.Value = 20) Then
            Label1.Text = "Turning on modules."
        ElseIf (ProgressBar1.Value = 40) Then
            Label1.Text = "Starting modules.."
        ElseIf (ProgressBar1.Value = 60) Then
            Label1.Text = "Loading modules.."
        ElseIf (ProgressBar1.Value = 80) Then
            Label1.Text = "Done Loading modules.."
        ElseIf (ProgressBar1.Value = 100) Then
            Me.Hide()
            mdiPrincipal.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class