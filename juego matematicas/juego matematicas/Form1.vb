Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i, j As Integer
        Select CmbSprint.SelectedIndex
            Case 0
                If LblTiempoAbs.Text = "30" Then
                    Timer1.Enabled = False
                    TextBoxRes.Enabled = False
                End If
            Case 2
                If LblTiempoAbs.Text = "60" Then
                    Timer1.Enabled = False
                    TextBoxRes.Enabled = False
                End If
            Case 3
                If LblTiempoAbs.Text = "120" Then
                    Timer1.Enabled = False
                    TextBoxRes.Enabled = False
                End If
            Case 4
                If LblTiempoAbs.Text = "180" Then
                    Timer1.Enabled = False
                    TextBoxRes.Enabled = False
                End If
            Case 5
                If LblTiempoAbs.Text = "240" Then
                    Timer1.Enabled = False
                    TextBoxRes.Enabled = False
                End If
            Case 6
                If LblTiempoAbs.Text = "320" Then
                    Timer1.Enabled = False
                    TextBoxRes.Enabled = False
                End If
            Case Else
                If LblTiempoAbs.Text = "30" Then
                    Timer1.Enabled = False
                    TextBoxRes.Enabled = False
                End If
        End Select

        i = CInt(LblTiempo.Text)
        LblTiempo.Text = CStr(i + 1)
        j = CInt(LblTiempoAbs.Text)
        LblTiempoAbs.Text = CStr(j + 1)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Enabled = True
        TextBoxRes.Enabled = True
        Dim numero, numerox As Integer
        Dim Random As New Random()
        ' generar un random  
        Select Case CmbNivel.SelectedIndex
            Case 0
                numero = Random.Next(1, 5)
                numerox = Random.Next(1, 5)
            Case 1
                numero = Random.Next(1, 10)
                numerox = Random.Next(1, 10)
            Case 2
                numero = Random.Next(1, 15)
                numerox = Random.Next(1, 15)
            Case 3
                numero = Random.Next(1, 20)
                numerox = Random.Next(1, 20)
            Case 4
                numero = Random.Next(1, 25)
                numerox = Random.Next(1, 25)
            Case 5
                numero = Random.Next(1, 30)
                numerox = Random.Next(1, 30)
            Case 6
                numero = Random.Next(10, 35)
                numerox = Random.Next(10, 35)
            Case 7
                numero = Random.Next(10, 50)
                numerox = Random.Next(10, 50)
            Case 8
                numero = Random.Next(10, 70)
                numerox = Random.Next(10, 70)
            Case 9
                numero = Random.Next(10, 1000)
                numerox = Random.Next(10, 1000)
            Case 10
                numero = Random.Next(10, 5000)
                numerox = Random.Next(10, 5000)
            Case 11

            Case Else
                numero = Random.Next(1, 5)
                numerox = Random.Next(1, 5)
        End Select

        
        lblX.Text = CStr(numero)

        LblY.Text = CStr(numerox)
        TextBoxRes.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LblSigno.Text = "+"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LblSigno.Text = "*"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LblSigno.Text = "-"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        LblSigno.Text = "/"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Timer1.Enabled = False
        LblTiempo.Text = "1"
    End Sub

    Private Sub TextBoxRes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxRes.KeyDown
        Dim resultado As Decimal
        Dim A As Char
        If e.KeyCode = Keys.Enter Then

            A = LblSigno.Text
            Select Case A
                Case "+"
                    resultado = CInt(lblX.Text) + CInt(LblY.Text)
                Case "-"
                    resultado = CInt(lblX.Text) - CInt(LblY.Text)
                Case "*"
                    resultado = CInt(lblX.Text) * CInt(LblY.Text)
                Case "/"
                    resultado = CInt(lblX.Text) / CInt(LblY.Text)
                Case Else
            End Select
            If (TextBoxRes.Text <> "") Then

                If CInt(TextBoxRes.Text) = resultado Then

                    TextBoxRes.Clear()
                    TextBoxRes.Focus()
                    LblPuntos.Text = CStr(resultado / CStr(LblTiempo.Text))
                    LblSumaPuntos.Text = LblSumaPuntos.Text + CDbl(LblPuntos.Text)
                    LblTiempo.Text = "1"

                    Call Button5_Click(sender, e)

                End If
            End If
        End If
    End Sub

    
End Class
