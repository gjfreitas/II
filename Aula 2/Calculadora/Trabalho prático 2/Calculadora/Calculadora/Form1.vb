Public Class Form1
    Dim operator1 As String
    Dim operator2 As String
    Dim operation As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Format(Now, "HH:mm:ss")
        TimerDate.Interval = 500
        TimerDate.Enabled = True
    End Sub

    Private Sub SetOperationAndOperator1(operation_arg As String, operator1_arg As String)
        operation = operation_arg
        operator1 = operator1_arg

        txtResultado.Text = ""
        txtOP1.Text = operator1
        txtOP.Text = operation
    End Sub
    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        SetOperationAndOperator1("+", txtResultado.Text)
    End Sub
    Private Sub bttnMinus_Click(sender As Object, e As EventArgs) Handles bttnMinus.Click
        SetOperationAndOperator1("-", txtResultado.Text)
    End Sub

    Private Sub bttnMulti_Click(sender As Object, e As EventArgs) Handles bttnMulti.Click
        SetOperationAndOperator1("x", txtResultado.Text)
    End Sub

    Private Sub bttnDivid_Click(sender As Object, e As EventArgs) Handles bttnDivid.Click
        SetOperationAndOperator1("/", txtResultado.Text)
    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtResultado.Text = ""
        txtOP1.Text = ""
        txtOP.Text = ""
        txtOP2.Text = ""
    End Sub

    Private Sub bttnEqual_Click(sender As Object, e As EventArgs) Handles bttnEqual.Click
        operator2 = txtResultado.Text

        txtOP2.Text = operator2

        If IsNumeric(operator1) And IsNumeric(operator2) Then
            If operation = "+" Then
                txtResultado.Text = CDbl(operator1) + CDbl(operator2)
            ElseIf operation = "-" Then
                txtResultado.Text = CDbl(operator1) - CDbl(operator2)
            ElseIf operation = "x" Then
                txtResultado.Text = CDbl(operator1) * CDbl(operator2)
            ElseIf operation = "/" Then
                txtResultado.Text = CDbl(operator1) / CDbl(operator2)
            End If
        Else
            txtResultado.Text = "Erro"

        End If
    End Sub

    Private Sub bttnClose_Click(sender As Object, e As EventArgs) Handles bttnClose.Click
        End
    End Sub

    Private Sub TimerDate_Tick(sender As Object, e As EventArgs) Handles TimerDate.Tick
        ToolStripStatusLabel1.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtResultado.Text = txtResultado.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtResultado.Text = txtResultado.Text + "2"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtResultado.Text = txtResultado.Text + "3"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtResultado.Text = txtResultado.Text + "4"
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtResultado.Text = txtResultado.Text + "5"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtResultado.Text = txtResultado.Text + "6"
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtResultado.Text = txtResultado.Text + "7"
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtResultado.Text = txtResultado.Text + "8"
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtResultado.Text = txtResultado.Text + "9"
    End Sub
    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        txtResultado.Text = txtResultado.Text + "0"
    End Sub
End Class
