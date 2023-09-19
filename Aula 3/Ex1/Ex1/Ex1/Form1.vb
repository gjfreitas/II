Public Class Form1
    Dim data_recieved As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxSend.Text = "My first Message"
    End Sub

    Private Sub Configure_Click(sender As Object, e As EventArgs) Handles Configure.Click
        With SerialPort1
            .PortName = "COM2"
            .BaudRate = 19200
            .Parity = IO.Ports.Parity.Even
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .Encoding = System.Text.Encoding.UTF8
        End With
    End Sub

    Private Sub BttnOpen_Click(sender As Object, e As EventArgs) Handles BttnOpen.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            BttnOpen.Text = "Open Port"
            BttnOpen.BackColor = Color.LightGray
        Else
            SerialPort1.Open()
            BttnOpen.Text = "Close Port"
            BttnOpen.BackColor = Color.Red
        End If
    End Sub

    Private Sub BttnSend_Click(sender As Object, e As EventArgs) Handles BttnSend.Click
        SerialPort1.Write(TextBoxSend.Text)
    End Sub

    Private Sub BttnReceb_Click(sender As Object, e As EventArgs) Handles BttnReceb.Click
        data_recieved = data_recieved & SerialPort1.ReadExisting
        TextBoxReceber.Text = data_recieved
        data_recieved = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SerialPort1.IsOpen() Then
            If SerialPort1.BytesToRead > 0 Then
                TextBoxReceber.Text = SerialPort1.ReadExisting()
            End If
        End If


    End Sub
End Class
