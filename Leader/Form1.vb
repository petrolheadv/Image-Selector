Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = My.Resources.Forest
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.Ocean
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = My.Resources.Land
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = Nothing
    End Sub
End Class
