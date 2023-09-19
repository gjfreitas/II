Imports System.IO.Ports
Imports System.Net
Imports System.Net.Sockets

Public Class Form1

    ' The ip of the server
    Dim local_address As IPAddress = IPAddress.Parse("127.0.0.1")
    ' A client object will request connection req
    Dim client As New Sockets.TcpClient


    Dim Y0 As Integer
    Dim Y1 As Integer
    Dim Y2 As Integer


    Private Sub TimerReceived_Tick(sender As Object, e As EventArgs) Handles TimerReceived.Tick
        Dim Y0 As Integer
        Dim Y1 As Integer
        Dim Y2 As Integer
        Dim X0 As Integer
        Dim X1 As Integer
        Dim X2 As Integer
        Dim X3 As Integer

        If client.Connected Then
            Dim availableByesToRead = client.Available

            If availableByesToRead > 0 Then

                Dim stream As NetworkStream = client.GetStream()

                Dim buffer(availableByesToRead) As Byte
                stream.Read(buffer, 0, availableByesToRead)

                Dim i As Integer
                Dim texto_recebido = ""
                For i = 0 To availableByesToRead - 1
                    texto_recebido = texto_recebido + Chr(buffer(i))
                Next i

                X0 = Mid(texto_recebido, 1, 1)
                X1 = Mid(texto_recebido, 2, 1)
                X2 = Mid(texto_recebido, 3, 1)
                X3 = Mid(texto_recebido, 4, 1)
                Y0 = Mid(texto_recebido, 5, 1)
                Y1 = Mid(texto_recebido, 6, 1)
                Y2 = Mid(texto_recebido, 7, 1)

                ''TextBoxLevel.Text = fs.GetItem(Csg, "D300")

                CheckBoxX0.Checked = X0
                CheckBoxX1.Checked = X1
                CheckBoxX2.Checked = X2
                CheckBoxX3.Checked = X3

                CheckBoxY0.Checked = Y0
                CheckBoxY1.Checked = Y1
                CheckBoxY2.Checked = Y2
            End If

        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerReceived.Interval = 400
        TimerReceived.Enabled = True
        Timer_Send.Interval = 400

    End Sub

    Private Sub BttnOpen_Click_1(sender As Object, e As EventArgs) Handles BttnOpen.Click
        BttnY0.Enabled = True
        BttnY1.Enabled = True
        BttnY2.Enabled = True
        client.Connect(local_address, 81)
        Timer_Send.Enabled = True

    End Sub

    Private Sub BttnY0_Click(sender As Object, e As EventArgs) Handles BttnY0.Click
        Y0 = If(Y0 = 1, 0, 1)
    End Sub

    Private Sub BttnY1_Click(sender As Object, e As EventArgs) Handles BttnY1.Click
        Y1 = If(Y1 = 1, 0, 1)
    End Sub
    Private Sub BttnY2_Click(sender As Object, e As EventArgs) Handles BttnY2.Click
        Y2 = If(Y2 = 1, 0, 1)
    End Sub


    Private Sub Timer_Send_Tick(sender As Object, e As EventArgs) Handles Timer_Send.Tick
        Dim bb() As Byte = {48, 49, 48, 49, 48}

        bb(0) = Convert.ToInt32(Y0) + 48
        bb(1) = Convert.ToInt32(Y1) + 48
        bb(2) = Convert.ToInt32(Y2) + 48


        If client.Connected = True Then
            Dim stream As NetworkStream = client.GetStream()
            stream.Write(bb, 0, 3)
        End If

    End Sub
End Class
