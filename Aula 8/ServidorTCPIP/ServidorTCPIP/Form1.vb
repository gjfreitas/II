Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class Form1
    ' The ip adress of the server
    Dim local_address As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim server As New TcpListener(local_address, 81)
    Dim connection As New TcpClient

    Dim fs As New FaconSvr.FaconServer
    Dim is_fs_connected As Boolean = False
    Dim CSG As String = "Channel0.Station0.Group0"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server.Start()
        TimerReceive.Interval = 400
        TimerSend.Interval = 400

        TimerReceive.Enabled = True
        TimerSend.Enabled = True
        Me.Text = "Servidor"
        fs.OpenProject("C:\Users\gfrei\OneDrive - Universidade de Aveiro\Mestrado\4 ano\2 Semestre\II\Prática\Aula 8\tp6.fcs")


    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        If server.Pending() Then
            connection = server.AcceptTcpClient()
        End If

        If connection.Connected Then
            Dim message_size As Integer = connection.Available
            Dim stream As NetworkStream = connection.GetStream
            If message_size > 0 Then
                Dim buffer(5000) As Byte
                stream.Read(buffer, 0, message_size)

                Dim message_in As String = ""
                Dim i As Integer
                For i = 0 To message_size - 1
                    message_in += Chr(buffer(i))
                Next i
                TextBoxReceber.Text = message_in + vbCrLf + TextBoxReceber.Text
                Dim Y0, Y1, Y2 As String
                Y0 = Mid(message_in, 1, 1)
                Y1 = Mid(message_in, 2, 1)
                Y2 = Mid(message_in, 3, 1)

                fs.SetItem(CSG, "Y0", Y0)
                fs.SetItem(CSG, "Y1", Y1)
                fs.SetItem(CSG, "Y2", Y2)
            End If
        End If

        CheckBoxX0.CheckState = fs.GetItem(CSG, "X0")
        CheckBoxX1.CheckState = fs.GetItem(CSG, "X1")
        CheckBoxX2.CheckState = fs.GetItem(CSG, "X2")
        CheckBoxX3.CheckState = fs.GetItem(CSG, "X3")
        CheckBoxY0.CheckState = fs.GetItem(CSG, "Y0")
        CheckBoxY1.CheckState = fs.GetItem(CSG, "Y1")
        CheckBoxY2.CheckState = fs.GetItem(CSG, "Y2")
        If connection.Connected Then
            Dim status(7) As Byte
            status(0) = CheckBoxX0.CheckState + 48
            status(1) = CheckBoxX1.CheckState + 48
            status(2) = CheckBoxX2.CheckState + 48
            status(3) = CheckBoxX3.CheckState + 48
            status(4) = CheckBoxY0.CheckState + 48
            status(5) = CheckBoxY1.CheckState + 48
            status(6) = CheckBoxY2.CheckState + 48
            Dim stream As NetworkStream = connection.GetStream
            stream.Write(status, 0, status.Length)
        End If
    End Sub



End Class
