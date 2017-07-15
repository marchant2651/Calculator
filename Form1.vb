Public Class Calculator

    Dim total1 As Decimal
    Dim total2 As Decimal
    Dim sign As String = "add"
    Dim afterEquals As Boolean = False

    Sub SignSum()

        Select Case sign
            Case "add"
                total1 += Val(txtDisplay.Text)
            Case "multiply"
                total1 = total1 * Val(txtDisplay.Text)
            Case "subtract"
                total1 = total1 - Val(txtDisplay.Text)
            Case "divide"
                total1 = total1 / Val(txtDisplay.Text)
        End Select
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtDisplay.Text = txtDisplay.Text & btnZero.Text
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtDisplay.Text = txtDisplay.Text & btnOne.Text
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtDisplay.Text = txtDisplay.Text & btnTwo.Text
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtDisplay.Text = txtDisplay.Text & btnThree.Text
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtDisplay.Text = txtDisplay.Text & btnFour.Text
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtDisplay.Text = txtDisplay.Text & btnFive.Text
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtDisplay.Text = txtDisplay.Text & btnSix.Text
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtDisplay.Text = txtDisplay.Text & btnSeven.Text
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtDisplay.Text = txtDisplay.Text & btnEight.Text
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtDisplay.Text = txtDisplay.Text & btnNine.Text
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        sign = "add"
        If total1 = 0 Or afterEquals = True Then
            total1 = Val(txtDisplay.Text)
        Else
            total1 = total1 + Val(txtDisplay.Text)
        End If
        txtDisplay.Clear()
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        SignSum()
        txtDisplay.Text = total1
        afterEquals = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
        total1 = 0
        total2 = 0
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        txtDisplay.Text = txtDisplay.Text & btnDecimal.Text
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        sign = "subtract"
        If total1 = 0 Or afterEquals = True Then
            total1 = Val(txtDisplay.Text)
        Else
            total1 = total1 - Val(txtDisplay.Text)
        End If
        txtDisplay.Clear()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        sign = "divide"
        If total1 = 0 Or afterEquals = True Then
            total1 = Val(txtDisplay.Text)
        Else
            total1 = total1 / Val(txtDisplay.Text)
        End If
        txtDisplay.Clear()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        sign = "multiply"
        If total1 = 0 Or afterEquals = True Then
            total1 = Val(txtDisplay.Text)
        Else
            total1 = total1 * Val(txtDisplay.Text)
        End If
        txtDisplay.Clear()
        afterEquals = False
    End Sub
End Class
