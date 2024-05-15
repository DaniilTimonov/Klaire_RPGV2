Public Class Main_Menu

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Engine_Form.Show()

        Me.Hide()

    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub


    Private opening As Boolean = True

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If GroupBox1.Visible Then
            GroupBox1.Visible = False
        End If
        'GroupBox1.Visible = False
        'opening = False
        'Timer1.Start()
    End Sub


    Private targetWidth As Integer
    Private stepWidth As Integer = 120 ' Шаг изменения высоты

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


        If Not GroupBox1.Visible Then
            targetWidth = 816 ' Целевая ширина GroupBox1
            GroupBox1.Width = 0 ' Начальная ширина
            GroupBox1.Visible = True
            Timer1.Start()
        End If


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If opening Then
            If GroupBox1.Width < targetWidth Then
                GroupBox1.Width += stepWidth
            Else
                Timer1.Stop()
            End If
        Else
            If GroupBox1.Width > 0 Then
                GroupBox1.Width -= stepWidth
            Else
                GroupBox1.Visible = False
                Timer1.Stop()
            End If
        End If
    End Sub


End Class

