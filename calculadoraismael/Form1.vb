Public Class Form1
    Dim v1, v2, r As Double
    Dim op As String
    Dim k As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If k = True Then
            Label1.Text = 1
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & 1
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        v1 = Val(Label1.Text)
        Label1.Text = ""
        op = "+"
        Label2.Text = Str(v1) & op
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        v2 = Val(Label1.Text)
        If op = "+" Then
            r = v1 + v2

        ElseIf op = "-" Then
            r = v1 - v2

        ElseIf op = "*" Then
            r = v1 * v2

        ElseIf op = "/" Then
            r = v1 / v2

        ElseIf op = "" Then
            v1 = Val(Label1.Text)
            r = v1
        End If

        Label1.Text = Str(r)
        Label2.Text = ""
        k = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If k = True Then
            Label1.Text = 2
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & 2
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If k = True Then
            Label1.Text = 3
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & 3
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If k = True Then
            Label1.Text = 4
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & 4
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If k = True Then
            Label1.Text = 5
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & 5
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If k = True Then
            Label1.Text = 6
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & 6
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If k = True Then
            Label1.Text = 7
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & 7
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If k = True Then
            Label1.Text = 8
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & 8
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If k = True Then
            Label1.Text = 9
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & 9
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If k = True Then
            Label1.Text = "0."
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & "."
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        r = 0
        v1 = 0
        v2 = 0
        op = ""
        Label1.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        v1 = Val(Label1.Text)
        v1 = v1 / 100
        Label1.Text = Str(v1)
        k = True
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        v2 = Val(Label1.Text)
        r = v2 * v2
        Label1.Text = Str(r)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If k = True Then
            Label1.Text = 0
            k = False
        ElseIf k = False Then
            Label1.Text = Label1.Text & 0
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        v2 = Val(Label1.Text)
        v2 = Math.Sqrt(v2)
        Label1.Text = Str(v2)
        k = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        v1 = Val(Label1.Text)
        Label1.Text = ""
        op = "/"
        Label2.Text = Str(v1) & op
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        v1 = Val(Label1.Text)
        Label1.Text = ""
        op = "*"
        Label2.Text = Str(v1) & op
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        v1 = Val(Label1.Text)
        Label1.Text = ""
        op = "-"
        Label2.Text = Str(v1) & op
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        k = True
    End Sub
End Class
