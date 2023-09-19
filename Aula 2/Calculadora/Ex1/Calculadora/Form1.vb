Public Class Form1
    Private Sub Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        End ' Terminar programa
    End Sub
    Private Sub Btn_Soma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAdd.Click
        ' Adição
        If IsNumeric(txtOP1.Text) And IsNumeric(txtOP2.Text) Then
            Result.Text = CInt(txtOP1.Text) + CInt(txtOP2.Text)
        Else
            Result.Text = "Erro"
        End If
    End Sub
    Private Sub Btn_Sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMinus.Click
        ' Subtracção
        If IsNumeric(txtOP1.Text) And IsNumeric(txtOP2.Text) Then
            Result.Text = CInt(txtOP1.Text) - CInt(txtOP2.Text)
        Else
            Result.Text = "Erro"
        End If

    End Sub
    Private Sub Btn_Mul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMulti.Click
        ' Multiplicação
        If IsNumeric(txtOP1.Text) And IsNumeric(txtOP2.Text) Then
            Result.Text = CInt(txtOP1.Text) * CInt(txtOP2.Text)
        Else
            Result.Text = "Erro"
        End If
    End Sub
    Private Sub Btn_Div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDivid.Click
        ' Divisão
        If IsNumeric(txtOP1.Text) And IsNumeric(txtOP2.Text) Then
            Result.Text = CInt(txtOP1.Text) / CInt(txtOP2.Text)
        Else
            Result.Text = "Erro"
        End If
    End Sub
End Class
