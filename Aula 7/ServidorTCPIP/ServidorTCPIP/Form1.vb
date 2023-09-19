Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    ' The ip of the server
    Dim local_address As IPAddress = IPAddress.Parse("127.0.0.1")

    ' A server object will accpet connection requests
    Dim server As New TcpListener(local_address, 81)

    ' A connection object will receive data
    Dim connection As New TcpClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start the TCP server. Will wait for clients to connect
        server.Start()
        Me.Text = "Servidor TCPIP"
        TextBoxVelocidadeMotor.Text = 0
        TextBoxVelocidadeMotorLida.Text = 0
        TimerReceive.Enabled = True
        TimerSend.Enabled = True
        TimerVerifyConnection.Enabled = True
    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        ' Accept a connection if there is a pending request
        If server.Pending() = True Then
            connection = server.AcceptTcpClient()
        End If

        If connection.Connected Then
            Dim message_size As Integer = connection.Available

            ' Read message if size is > 0
            If message_size > 0 Then
                ' Copy stream to byte array buff
                Dim message_in_stream As NetworkStream = connection.GetStream()
                Dim buffer(5000) As Byte ' a buffer to copy the received data
                message_in_stream.Read(buffer, 0, message_size)

                ' Convert byte array buffer to string message_in
                Dim message_in As String = ""
                Dim i As Integer
                For i = 0 To message_size - 1
                    message_in += Chr(buffer(i))
                Next i

                ' Copy to textbox
                TextBoxReceber.Text = message_in + vbCrLf + TextBoxReceber.Text

                ' Process message to get values for Y0, Y1, Y2 and level
                CheckBoxY0.Checked = Mid(message_in, 1, 1)
                CheckBoxY1.Checked = Mid(message_in, 2, 1)
                CheckBoxY2.Checked = Mid(message_in, 3, 1)

                TextBoxVelocidadeMotor.Text = Asc(Mid(message_in, 4, 1))
            End If
        End If

    End Sub

    Private Sub TimerVerifyConnection_Tick(sender As Object, e As EventArgs) Handles TimerVerifyConnection.Tick
        TextBoxEstadoLigacao.Text = connection.Connected
    End Sub

    Private Sub TimerSend_Tick(sender As Object, e As EventArgs) Handles TimerSend.Tick
        If connection.Connected = True Then
            ' Declare a byte array and set it according to the state of X0 to X3
            Dim buffer(5) As Byte
            buffer(0) = CheckBoxX0.CheckState + 48
            buffer(1) = CheckBoxX1.CheckState + 48
            buffer(2) = CheckBoxX2.CheckState + 48
            buffer(3) = CheckBoxX3.CheckState + 48

            If TextBoxVelocidadeMotorLida.Text <> "" Then
                buffer(4) = CInt(TextBoxVelocidadeMotorLida.Text)
            End If

            ' Now send the array
            Dim message_out_stream As NetworkStream
            message_out_stream = connection.GetStream()
            message_out_stream.Write(buffer, 0, 5)
        End If

    End Sub

End Class
