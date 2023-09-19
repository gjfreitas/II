Public Class Form1
    Private Sub Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnClose.Click
        End ' Terminar programa
    End Sub
    Private Sub Btn_Soma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnAdd.Click
        ' Adição
        If IsNumeric(txtOP1.Text) And IsNumeric(txtOP2.Text) Then
            txtResult.Text = CInt(txtOP1.Text) + CInt(txtOP2.Text)
        Else
            txtResult.Text = "Erro"
        End If
    End Sub
    Private Sub Btn_Sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMinus.Click
        ' Subtracção
        If IsNumeric(txtOP1.Text) And IsNumeric(txtOP2.Text) Then
            txtResult.Text = CInt(txtOP1.Text) - CInt(txtOP2.Text)
        Else
            txtResult.Text = "Erro"
        End If

    End Sub
    Private Sub Btn_Mul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnMulti.Click
        ' Multiplicação
        If IsNumeric(txtOP1.Text) And IsNumeric(txtOP2.Text) Then
            txtResult.Text = CInt(txtOP1.Text) * CInt(txtOP2.Text)
        Else
            txtResult.Text = "Erro"
        End If
    End Sub
    Private Sub Btn_Div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnDivid.Click
        ' Divisão
        If IsNumeric(txtOP1.Text) And IsNumeric(txtOP2.Text) Then
            txtResult.Text = CInt(txtOP1.Text) / CInt(txtOP2.Text)
        Else
            txtResult.Text = "Erro"
        End If
    End Sub

    Private Sub bttnSave_Click(sender As Object, e As EventArgs) Handles bttnSave.Click
        FileOpen(1, "C:\Users\freit\OneDrive - Universidade de Aveiro\Mestrado\4 ano\2 Semestre\II\Prática\Aula 2\resultados.txt", OpenMode.Append)
        PrintLine(1, "Resultado= " + txtResult.Text)
        FileClose()
    End Sub

    Private Sub bttnRead_Click(sender As Object, e As EventArgs) Handles bttnRead.Click
        FileOpen(1, "C:\Users\freit\OneDrive - Universidade de Aveiro\Mestrado\4 ano\2 Semestre\II\Prática\Aula 2\resultados.txt", OpenMode.Input)
        txtFile.Text = ""
        While (EOF(1) = False)
            txtFile.Text = txtFile.Text + LineInput(1) + vbCrLf
        End While
        FileClose()
    End Sub

End Class