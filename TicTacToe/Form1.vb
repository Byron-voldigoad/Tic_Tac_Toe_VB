Public Class Form1
    Dim p1 = "O"
    Dim p2 = "X"
    Dim player() As Integer = {1, 2}

    Dim randomindex As Integer = player(Int(player.Length * Rnd()))

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        randomindex = player(Int(player.Length * Rnd()))
        If randomindex = 1 Then
            Label1.Text = "Player " + p1 + " tur"
        Else
            Label1.Text = "Player " + p2 + " tur"
        End If

    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button10.Text = ""
        Button2.BackColor = Color.LightGray
        Button3.BackColor = Color.LightGray
        Button4.BackColor = Color.LightGray
        Button5.BackColor = Color.LightGray
        Button6.BackColor = Color.LightGray
        Button7.BackColor = Color.LightGray
        Button8.BackColor = Color.LightGray
        Button9.BackColor = Color.LightGray
        Button10.BackColor = Color.LightGray
        Randomize()
        randomindex = player(Int(player.Length * Rnd()))
        If randomindex = 1 Then
            Label1.Text = "Player " + p1 + " tur"
        Else
            Label1.Text = "Player " + p2 + " tur"
        End If
    End Sub

    Private Sub Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Button2.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        If randomindex = 1 And CType(sender, Button).Text = "" Then
            CType(sender, Button).Text = p1
            CType(sender, Button).ForeColor = Color.Blue
        ElseIf randomindex = 2 And CType(sender, Button).Text = "" Then
            CType(sender, Button).Text = p2
            CType(sender, Button).ForeColor = Color.Red
        End If

        Dim vc As String = CType(sender, Button).Text
        If vc = p1 Then
            randomindex = 2
        End If
        Dim vc2 As String = CType(sender, Button).Text
        If vc2 = p2 Then
            randomindex = 1
        End If
        If Button2.Text = Button3.Text Then
            Label1.Text = "Player " + Button3.Text + " Win"
        End If
        If randomindex = 1 Then
            Label1.Text = "Player " + p1 + " tur"
        Else
            Label1.Text = "Player " + p2 + " tur"
        End If
        Dim w = " win"
        ''''first win''''''''''''
        If Button2.Text <> "" Then
            If Button2.Text = Button3.Text And Button2.Text = Button4.Text Then
                Label1.Text = "Player " + Button2.Text + w
                randomindex = 0
                Button2.BackColor = Color.Green
                Button3.BackColor = Color.Green
                Button4.BackColor = Color.Green
            End If
        End If
        '''''''''second win'''''''''''
        If Button2.Text <> "" Then
            If Button2.Text = Button5.Text And Button2.Text = Button8.Text Then
                Label1.Text = "Player " + Button2.Text + w
                randomindex = 0
                Button2.BackColor = Color.Green
                Button5.BackColor = Color.Green
                Button8.BackColor = Color.Green
            End If
        End If
        ''''''''''tird win'''''''''''''
        If Button2.Text <> "" Then
            If Button2.Text = Button6.Text And Button2.Text = Button10.Text Then
                Label1.Text = "Player " + Button2.Text + w
                randomindex = 0
                Button2.BackColor = Color.Green
                Button6.BackColor = Color.Green
                Button10.BackColor = Color.Green
            End If
        End If
        ''''''''''fougth win ''''''''''''''''
        If Button3.Text <> "" Then
            If Button3.Text = Button6.Text And Button3.Text = Button9.Text Then
                Label1.Text = "Player " + Button3.Text + w
                randomindex = 0
                Button6.BackColor = Color.Green
                Button3.BackColor = Color.Green
                Button9.BackColor = Color.Green
            End If
        End If
        '''''''''''five win''''''''''''''''''
        If Button4.Text <> "" Then
            If Button4.Text = Button7.Text And Button10.Text = Button4.Text Then
                Label1.Text = "Player " + Button4.Text + w
                randomindex = 0
                Button7.BackColor = Color.Green
                Button10.BackColor = Color.Green
                Button4.BackColor = Color.Green
            End If
        End If
        '''''''''sixt win'''''''''''
        If Button4.Text <> "" Then
            If Button4.Text = Button6.Text And Button8.Text = Button4.Text Then
                Label1.Text = "Player " + Button4.Text + w
                randomindex = 0
                Button6.BackColor = Color.Green
                Button8.BackColor = Color.Green
                Button4.BackColor = Color.Green
            End If
        End If
        ''sevent win'''''''''''''
        If Button5.Text <> "" Then
            If Button5.Text = Button6.Text And Button5.Text = Button7.Text Then
                Label1.Text = "Player " + Button5.Text + w
                randomindex = 0
                Button5.BackColor = Color.Green
                Button6.BackColor = Color.Green
                Button7.BackColor = Color.Green
            End If
        End If
        ''''''''''hegth win ''''''''''''''''
        If Button8.Text <> "" Then
            If Button8.Text = Button9.Text And Button8.Text = Button10.Text Then
                Label1.Text = "Player " + Button8.Text + w
                randomindex = 0
                Button8.BackColor = Color.Green
                Button9.BackColor = Color.Green
                Button10.BackColor = Color.Green
            End If
        End If
        If Button2.Text <> "" And Button3.Text <> "" And Button3.Text <> "" And Button4.Text <> "" And Button5.Text <> "" And Button6.Text <> "" And Button7.Text <> "" And Button8.Text <> "" And Button9.Text <> "" And Button10.Text <> "" Then
            If Not Label1.Text.Contains(w) Then
                Me.Label1.Left = 125
                Me.Label1.Top = 20
                Label1.Text = "       TIE!! "
                Button2.BackColor = Color.Yellow
                Button3.BackColor = Color.Yellow
                Button4.BackColor = Color.Yellow
                Button5.BackColor = Color.Yellow
                Button6.BackColor = Color.Yellow
                Button7.BackColor = Color.Yellow
                Button8.BackColor = Color.Yellow
                Button9.BackColor = Color.Yellow
                Button10.BackColor = Color.Yellow
            End If

        End If
    End Sub

    
End Class
