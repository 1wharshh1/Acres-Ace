﻿Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Login.Show()
            Me.Hide()

        End If

    End Sub
End Class
