Public Class Form1
    Public timesec



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Maximum = timesec + 500
        Timer1.Start()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()

        ProgressBar1.Value = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If timesec > ProgressBar1.Value Then
            ProgressBar1.Value = ProgressBar1.Value + 1000

        Else
            Timer1.Stop()
            ProgressBar1.Value = 0
            My.Computer.Audio.Play(My.Resources.alarm2, AudioPlayMode.Background)

            MessageBox.Show("Time to get paid more!", "Stop Working!")

        End If
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub


    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If Timer1.Enabled = True Then
            timesec = timesec
        Else
            timesec = 2880000
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged


        If Timer1.Enabled = True Then
            timesec = timesec
        Else
            timesec = 1800000
        End If



    End Sub

    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    

    
End Class
