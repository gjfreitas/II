Public Class Form1
    Dim data_received As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxSend.Text = "My first Message"
        TimerReceived.Interval = 300
        TimerReceived.Enabled = False

        ModuleComPortParameters.configuration_is_valid = True

        'Bloquear os botões que posteriormente vão ser livres
        BttnOpen.Enabled = False ' Livre quando a configuração é válida
        BttnSend.Enabled = False  ' Livre quando a porta esta aberta

    End Sub

    Private Sub BttnConfigure_Click(sender As Object, e As EventArgs) Handles BttnConfigure.Click
        FormComportConfiguration.StartPosition = FormStartPosition.CenterParent
        FormComportConfiguration.ShowDialog()

        If ModuleComPortParameters.configuration_is_valid = True Then
            With SerialPort1
                .PortName = ModuleComPortParameters.port
                .BaudRate = ModuleComPortParameters.baud_rate
                .Parity = ModuleComPortParameters.parity
            End With
            BttnOpen.Enabled = True
        End If
    End Sub

    Private Sub BttnOpen_Click(sender As Object, e As EventArgs) Handles BttnOpen.Click
        If ModuleComPortParameters.configuration_is_valid = True Then
            If SerialPort1.IsOpen Then
                SerialPort1.Close()
                BttnOpen.Text = "Open Port"
                BttnOpen.BackColor = Color.LightGray
                TimerReceived.Enabled = False
                BttnSend.Enabled = False
            Else
                SerialPort1.Open()
                BttnOpen.Text = "Close Port"
                BttnOpen.BackColor = Color.Red
                TimerReceived.Enabled = True
                BttnSend.Enabled = True
            End If
        Else
            MsgBox("Cannot open port with a invalid configuration!")
        End If
    End Sub

    Private Sub BttnSend_Click(sender As Object, e As EventArgs) Handles BttnSend.Click
        SerialPort1.Write(TextBoxSend.Text)
    End Sub

    Private Sub TimerReceived_Tick(sender As Object, e As EventArgs) Handles TimerReceived.Tick
        data_received = data_received & SerialPort1.ReadExisting

        If Len(data_received) > 0 Then
            TextBoxReceive.Text = data_received
            TextBoxHistory.Text = TimeOfDay.ToLongTimeString + ": " +
                data_received + vbNewLine + TextBoxHistory.Text
            data_received = ""
        End If
    End Sub

    Private Sub BttnExit_Click(sender As Object, e As EventArgs) Handles BttnExit.Click
        End
    End Sub
End Class
