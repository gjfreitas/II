Imports System.IO.Ports

Public Class Form1
    Dim Y0 As Integer
    Dim Y1 As Integer
    Dim Y2 As Integer

    Dim X0 As Integer
    Dim X1 As Integer
    Dim X2 As Integer
    Dim X3 As Integer

    Private Sub ConfigurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarToolStripMenuItem.Click
        FormComportConfiguration.StartPosition = FormStartPosition.CenterParent
        FormComportConfiguration.ShowDialog()

        If ModuleComPortParameters.configuration_is_valid = True Then
            With SerialPort1
                .PortName = ModuleComPortParameters.port
                .BaudRate = ModuleComPortParameters.baud_rate
                .Parity = ModuleComPortParameters.parity
            End With
        End If
    End Sub

    Private Sub BttnOpen_Click(sender As Object, e As EventArgs) Handles BttnOpen.Click
        If ModuleComPortParameters.configuration_is_valid = True Then
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
                BttnOpen.Text = "Open Port"
                BttnOpen.BackColor = Color.LightGray
                TimerReceived.Enabled = False
                ToolStripStatusLabel1.Text = "Configuração Desligada"
            Else
                SerialPort1.Open()
                BttnOpen.Text = "Close Port"
                BttnOpen.BackColor = Color.Red
                TimerReceived.Enabled = True
                ToolStripStatusLabel1.Text = "Configuração Ligada"
            End If
        Else
            MsgBox("Cannot open port with a invalid configuration!")
        End If
    End Sub

    Private Sub TimerReceived_Tick(sender As Object, e As EventArgs) Handles TimerReceived.Tick
        If SerialPort1.BytesToRead = 0 Then
            Return
        End If

        ' Read serial port reception buffer and append to data_recived
        Dim data = SerialPort1.ReadExisting()

        ' Search for the start of the message
        Dim start_position = InStr(data, "s")

        If start_position = 0 Then
            Return
        End If

        ' Search for the end of the message
        Dim end_position = InStr(data, "e")

        Dim data_cropped As String = Mid(data, start_position, end_position - start_position + 1)

        ' Check if we have a completed message
        ' Only do this if message length is fixed
        If Not Len(data_cropped) = Len("s_ToPC0000000A_e") Then
            Return
        End If

        DisplayMessages.txtRecebido.Text += Now.ToString + " " + data_cropped + vbCrLf

        CheckBoxY0.Checked = Mid(data_cropped, 7, 1)
        CheckBoxY1.Checked = Mid(data_cropped, 8, 1)
        CheckBoxY2.Checked = Mid(data_cropped, 9, 1)

        X0 = Mid(data_cropped, 10, 1)
        X1 = Mid(data_cropped, 11, 1)
        X2 = Mid(data_cropped, 12, 1)
        X3 = Mid(data_cropped, 13, 1)

        CheckBoxX0.Checked = X0
        CheckBoxX1.Checked = X1
        CheckBoxX2.Checked = X2
        CheckBoxX3.Checked = X3

        Dim level = Asc(Mid(data_cropped, 14, 1))
        TextBoxLevel.Text = level

        'Dim a = CDbl(level_bottom_y - level_start_y) * (1 - (level / 100.0))
        'PictureBoxLevel.Location = New Point(PictureBoxLevel.Location.X)


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click
        DisplayMessages.Show()
    End Sub

    Private Sub BttnY0_Click(sender As Object, e As EventArgs) Handles BttnY0.Click
        Y0 = If(Y0 = 1, 0, 1)
        SendCommand()
    End Sub

    Private Sub BttnY1_Click(sender As Object, e As EventArgs) Handles BttnY1.Click
        Y1 = If(Y1 = 1, 0, 1)
        SendCommand()
    End Sub

    Private Sub BttnY2_Click(sender As Object, e As EventArgs) Handles BttnY2.Click
        Y2 = If(Y2 = 1, 0, 1)
        SendCommand()
    End Sub

    Private Sub SendCommand()
        Dim output As String = "s_ToPLC" + CStr(Y0) + CStr(Y1) + CStr(Y2) + "e"
        SerialPort1.Write(output)
        DisplayMessages.txtEnviado.Text += Now.ToString + " " + output + vbCrLf

        UpdateButtonImages()
    End Sub

    Private Sub UpdateButtonImages()
        If Y0 = 1 Then
            CheckBoxY0.Checked = True
        End If
        If Y1 = 1 Then
            CheckBoxY1.Checked = True
        End If
        If Y2 = 1 Then
            CheckBoxY2.Checked = True
        End If

        If Y0 = 0 Then
            CheckBoxY0.Checked = False
        End If
        If Y1 = 0 Then
            CheckBoxY1.Checked = False
        End If
        If Y2 = 0 Then
            CheckBoxY2.Checked = False
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TimerReceived.Interval = 100
    End Sub
End Class
