Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text


Public Class Form1
    ' The ip adress of the server
    Dim local_address As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim server As New TcpListener(local_address, 81)
    Dim ligacao As New TcpClient

    Dim is_fs_connected As Boolean = False
    Dim CSG As String = "Channel0.Station0.Group0"

    Dim caminho_pasta_html = "C:\Users\gfrei\OneDrive - Universidade de Aveiro\Mestrado\4 ano\2 Semestre\II\Prática\Aula 9\"
    Dim stream As NetworkStream


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server.Start()
        TimerReceive.Enabled = True

    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        If server.Pending() Then
            ligacao = server.AcceptTcpClient()
            stream = ligacao.GetStream()
        End If

        If ligacao.Connected Then
            Dim caraters_disponiveis As Integer
            caraters_disponiveis = ligacao.Available

            If caraters_disponiveis = 0 Then
                Return
            End If


            Dim caracters(caraters_disponiveis) As Byte
            stream.Read(caracters, 0, caraters_disponiveis)

            Dim texto_recebido As String

            Dim i As Integer
            texto_recebido = ""
            For i = 0 To caraters_disponiveis - 1
                texto_recebido = texto_recebido + Chr(caracters(i))
            Next i

            TextBoxReceber.Text = texto_recebido

            Dim primeira_linha = texto_recebido.Substring(0, texto_recebido.IndexOf(vbCrLf))
            Dim itens_primeira_linha = primeira_linha.Split(" ")
            Dim metodo = itens_primeira_linha(0)
            Dim caminho = itens_primeira_linha(1)

            If InStr(caminho, "Logo.html") Then
                EnviarFicheiro(caminho_pasta_html + "Logo.html")
            ElseIf InStr(caminho, "Rodape.html") Then
                EnviarFicheiro(caminho_pasta_html + "Rodape.html")
            ElseIf InStr(caminho, "Reservatorio2.html") Then
                EnviarFicheiro(caminho_pasta_html + "Reservatorio2.html")
            End If
        End If
    End Sub

    Private Sub EnviarFicheiro(ByVal caminho_do_ficheiro As String)
        If ligacao.Connected Then
            Dim stream_do_ficheiro As StreamReader = New StreamReader(caminho_do_ficheiro)
            Dim string_do_ficheiro As String = stream_do_ficheiro.ReadToEnd()

            Dim estado = "HTTP/1.1 200 OK"
            Dim cabecalho = "Content-Type: text/html; charset=utf-8"

            Dim resposta = estado + vbNewLine + cabecalho + vbNewLine + vbNewLine + string_do_ficheiro

            Dim bytes_enviar() As Byte = Encoding.UTF8.GetBytes(resposta)
            stream.Write(bytes_enviar, 0, bytes_enviar.Length)



        End If
    End Sub

End Class
