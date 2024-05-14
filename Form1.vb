'Public Class Form1
'    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
'        Dim stepSize As Integer = 18
'        Select Case e.KeyCode



'            Case Keys.Up
'                If PictureBox1.Top > 0 AndAlso Not IsColliding(PictureBox1, New Point(PictureBox1.Location.X, PictureBox1.Location.Y - stepSize)) Then
'                    PictureBox1.Top -= stepSize


'                End If
'            Case Keys.Down
'                If PictureBox1.Bottom < Me.ClientSize.Height - 20 AndAlso Not IsColliding(PictureBox1, New Point(PictureBox1.Location.X, PictureBox1.Location.Y + stepSize)) Then
'                    PictureBox1.Top += stepSize
'                End If
'            Case Keys.Left
'                If PictureBox1.Left > 0 AndAlso Not IsColliding(PictureBox1, New Point(PictureBox1.Location.X - stepSize, PictureBox1.Location.Y)) Then
'                    PictureBox1.Left -= stepSize
'                    PictureBox1.Image = My.Resources.claire_left

'                End If
'            Case Keys.Right
'                If PictureBox1.Right < Me.ClientSize.Width - 20 AndAlso Not IsColliding(PictureBox1, New Point(PictureBox1.Location.X + stepSize, PictureBox1.Location.Y)) Then
'                    PictureBox1.Left += stepSize
'                    PictureBox1.Image = My.Resources.claire_right

'                End If


'        End Select





'    End Sub

'    Private Function IsColliding(pictureBox As PictureBox, proposedLocation As Point) As Boolean
'        Dim proposedRectangle As New Rectangle(proposedLocation, pictureBox.Size)

'        Return proposedRectangle.IntersectsWith(PictureBox2.Bounds)

'    End Function



'End Class



Imports System.Reflection.Emit

Public Class Form1
    Private hasCollided As Boolean = False

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                MovePictureBox(PictureBox1, 0, -5)
            Case Keys.Down
                MovePictureBox(PictureBox1, 0, 5)
            Case Keys.Left
                MovePictureBox(PictureBox1, -5, 0)
                PictureBox1.Image = My.Resources.claire_left
            Case Keys.Right
                MovePictureBox(PictureBox1, 5, 0)
                PictureBox1.Image = My.Resources.claire_right
            Case Keys.Enter
                If hasCollided Then
                    'MessageBox.Show("Столкновение произошло!")
                    GroupBox1.Visible = True
                    Label1.Visible = False
                    PictureBox3.Visible = False
                End If
        End Select
    End Sub

    Private Sub MovePictureBox(pbox As PictureBox, xChange As Integer, yChange As Integer)
        Dim newX As Integer = pbox.Location.X + xChange
        Dim newY As Integer = pbox.Location.Y + yChange

        ' Проверка столкновения
        Dim newRect As New Rectangle(newX, newY, pbox.Width, pbox.Height)
        If newRect.IntersectsWith(PictureBox2.Bounds) Then
            hasCollided = True
            PictureBox3.Visible = True
            Label1.Visible = True

            Return ' Не двигаем, если будет столкновение

        Else
            hasCollided = False
            PictureBox3.Visible = False
            Label1.Visible = False
            GroupBox1.Visible = False
        End If

        ' Проверка выхода за границы формы
        If newX < 0 OrElse newY < 0 OrElse newX + pbox.Width > Me.ClientSize.Width OrElse newY + pbox.Height > Me.ClientSize.Height Then
            Return ' Не двигаем, если выходит за пределы формы
        End If

        pbox.Location = New Point(newX, newY)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        GroupBox1.Visible = False
    End Sub
End Class