Public Class Form1

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i, j As Integer

        If LblTiempoAbs.Text = "59" Then
            Timer1.Enabled = False
            MaskedTextBox1.Enabled = False
        End If
        i = CInt(LblTiempo.Text)
        LblTiempo.Text = CStr(i + 1)
        j = CInt(LblTiempoAbs.Text)
        LblTiempoAbs.Text = CStr(j + 1)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer1.Enabled = True
        MaskedTextBox1.Enabled = True
        Dim Random As New Random()

        ' generar un random  
        Dim numero As Integer = Random.Next(1, 10)
        Dim numerox As Integer = Random.Next(1, 10)

        lblX.Text = CStr(numero)

        LblY.Text = CStr(numerox)
        MaskedTextBox1.Focus()
    End Sub

    Private Sub Button5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Button5.KeyPress

        'If e.KeyChar =  Then
        'End If
        'End If
        'Timer1.Enabled = True
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

    Private Sub MaskedTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
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
            If (MaskedTextBox1.Text <> "") Then

                If CInt(MaskedTextBox1.Text) = resultado Then

                    MaskedTextBox1.Clear()
                    MaskedTextBox1.Focus()
                    LblPuntos.Text = CStr(resultado / CStr(LblTiempo.Text))
                    LblSumaPuntos.Text = LblSumaPuntos.Text + CDbl(LblPuntos.Text)
                    LblTiempo.Text = "1"
                    
                    Call Button5_Click(sender, e)

                End If
            End If
        End If


    End Sub

    

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Timer1.Enabled = False
        LblTiempo.Text = "1"
    End Sub
End Class
