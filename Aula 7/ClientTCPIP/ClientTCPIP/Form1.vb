Imports System.Net
Imports System.Net.Sockets
Public Class Form1
    ' The ip adress of the server
    Dim ip_address As IPAddress = IPAddress.Parse("127.0.0.1")

    ' A client object will request connection req
    Dim client As New Sockets.TcpClient

    Private Sub ButtonLigar_Click(sender As Object, e As EventArgs) Handles ButtonLigar.Click
        client.Connect(ip_address, 81)
        ButtonLigar.Enabled = False
        ButtonDesligar.Enabled = True
        TimerReceive.Enabled = True
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        ' Update connection state
        TextBoxEstadoLigacao.Text = client.Connected

        If client.Connected Then
            Dim message_size As Integer = client.Available

            ' Read message if size is > 0
            If message_size > 0 Then

                'Copy stream to byte array buffer
                Dim message_in_stream As NetworkStream = client.GetStream()
                Dim buffer(5000) As Byte ' a buffer to copy then receive data
                message_in_stream.Read(buffer, 0, message_size)

                'Convert byte array buffer to string message_in
                Dim message_in As String = ""
                Dim i As Integer
                For i = 0 To message_size - 1
                    message_in += Chr(buffer(i))
                Next i

                'Process message to get values for X0 to X3
                CheckBoxX0.Checked = Mid(message_in, 1, 1)
                CheckBoxX1.Checked = Mid(message_in, 2, 1)
                CheckBoxX2.Checked = Mid(message_in, 3, 1)
                CheckBoxX3.Checked = Mid(message_in, 4, 1)
                TextBoxVelocidadeMotorLida.Text = Asc(Mid(message_in, 5, 1))
            End If
        End If

    End Sub

    Private Sub ButtonDesligar_Click(sender As Object, e As EventArgs) Handles ButtonDesligar.Click
        client.Close()
        client = New Sockets.TcpClient
        ButtonLigar.Enabled = True
        ButtonDesligar.Enabled = False
        TimerReceive.Enabled = False
    End Sub

    Private Sub ButtonEnviarCheckBox_Click(sender As Object, e As EventArgs) Handles ButtonEnviarCheckBox.Click
        If client.Connected = True Then
            'Declare a byte array and set it according to the state of X0 to X3
            Dim buffer(5) As Byte
            buffer(0) = CheckBoxY0.CheckState + 48
            buffer(1) = CheckBoxY1.CheckState + 48
            buffer(2) = CheckBoxY2.CheckState + 48
            If TextBoxVelocidadeMotor.Text <> "" Then
                buffer(3) = CInt(TextBoxVelocidadeMotor.Text)
            End If

            'Now send the array
            Dim message_out_stream As NetworkStream
            message_out_stream = client.GetStream()
            message_out_stream.Write(buffer, 0, 4)

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonLigar.Enabled = True
        ButtonDesligar.Enabled = False
        Me.Text = "Cliente TCPIP"
        TextBoxVelocidadeMotorLida.Text = 0
        TextBoxVelocidadeMotor.Text = 0
    End Sub
End Class
