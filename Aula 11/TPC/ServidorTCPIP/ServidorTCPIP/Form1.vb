Imports MySql.Data.MySqlClient
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement



Public Class Form1
    ' The ip adress of the server
    Dim local_address As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim server As New TcpListener(local_address, 81)
    Dim ligacao As New TcpClient

    Dim fs As New FaconSvr.FaconServer
    Dim is_fs_connected As Boolean = False
    Dim CSG As String = "Channel0.Station0.Group0"

    Dim caminho_pasta_html = "C:\Users\gfrei\OneDrive - Universidade de Aveiro\Mestrado\4 ano\2 Semestre\II\Prática\Aula 10\"
    Dim stream As NetworkStream

    ' Definir objetos globais
    Dim cn As New MySqlConnection ' Ligação
    Dim cmd As New MySqlCommand ' Manda comandos
    Dim data_reader As MySqlDataReader ' Recebe respostas


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server.Start()
        TimerReceive.Enabled = True
        Me.Text = "Servidor"
        TimerReceive.Interval = 100
        fs.OpenProject("C:\Users\gfrei\OneDrive - Universidade de Aveiro\Mestrado\4 ano\2 Semestre\II\Prática\Aula 11\tp6.fcs")

        ' Configurar o obj tipo cn
        cn.ConnectionString = "Server=localhost; User Id=root; Password=gfreitas82; Database=reservatorio"

        ' Verificações de erros de ligação
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
                MsgBox("Ligação Correcta à Base de Dados alunos...")
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox("Ligação Incorrecta à Base de Dados alunos...")
        End Try
        cmd.Connection = cn

    End Sub

    Private Sub TimerReceive_Tick(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        If server.Pending() Then
            ligacao = server.AcceptTcpClient()
            stream = ligacao.GetStream
        End If
        If ligacao.Connected Then
            Dim caracteres_disponiveis As Integer
            caracteres_disponiveis = ligacao.Available
            If caracteres_disponiveis = 0 Then
                Return
            End If

            Dim caracteres(caracteres_disponiveis) As Byte

            stream.Read(caracteres, 0, caracteres_disponiveis)
            Dim texto_recebido As String

            Dim i As Integer
            texto_recebido = ""
            For i = 0 To caracteres_disponiveis - 1
                texto_recebido += Chr(caracteres(i))
            Next i

            TextBoxReceber.Text = texto_recebido

            If texto_recebido.Length > 1 Then
                Dim primeira_linha = texto_recebido.Substring(0, texto_recebido.IndexOf(vbCrLf))
                Dim itens_primeira_linha = primeira_linha.Split(" ")
                Dim metodo = itens_primeira_linha(0)
                Dim caminho = itens_primeira_linha(1)

                'txt_receber.Text = primeira_linha
                Dim Y00 As Integer
                Dim Y11 As Integer
                Dim Y22 As Integer

                If InStr(primeira_linha, "Y0=1") Then
                    fs.SetItem(CSG, "Y0", 1)
                    Y00 = 1
                    cmd.CommandText = "Insert into controlo(Y0) Values('" & Y00 & "')"
                    cmd.ExecuteNonQuery()
                ElseIf InStr(primeira_linha, "Y0=0") Then
                    fs.SetItem(CSG, "Y0", 0)
                    Y00 = 0
                    cmd.CommandText = "Insert into controlo(Y0) Values('" & Y00 & "')"
                    cmd.ExecuteNonQuery()
                    ' Vamos dar set a items ao Y1
                ElseIf InStr(primeira_linha, "Y1=1") Then
                    fs.SetItem(CSG, "Y1", 1)
                    Y11 = 1
                    cmd.CommandText = "Insert into controlo(Y1) Values('" & Y11 & "')"
                    cmd.ExecuteNonQuery()
                ElseIf InStr(primeira_linha, "Y1=0") Then
                    fs.SetItem(CSG, "Y1", 0)
                    Y11 = 0
                    cmd.CommandText = "Insert into controlo(Y1) Values('" & Y11 & "')"
                    cmd.ExecuteNonQuery()
                    ' Vamos dar set a items ao Y2
                ElseIf InStr(primeira_linha, "Y2=1") Then
                    fs.SetItem(CSG, "Y2", 1)
                    Y22 = 1
                    cmd.CommandText = "Insert into controlo(Y2) Values('" & Y22 & "')"
                    cmd.ExecuteNonQuery()
                ElseIf InStr(primeira_linha, "Y2=0") Then
                    fs.SetItem(CSG, "Y2", 0)
                    Y22 = 0
                    cmd.CommandText = "Insert into controlo(Y2) Values('" & Y22 & "')"
                    cmd.ExecuteNonQuery()
                End If



                If InStr(caminho, "Supervisao.html") Then
                    Enviar_Ficheiro(caminho_pasta_html + "Supervisao.html")
                ElseIf InStr(caminho, "Controlo.html") Then
                    Enviar_Ficheiro(caminho_pasta_html + "Controlo.html")
                ElseIf InStr(caminho, "Reservatorio.html") Then
                    Enviar_Ficheiro(caminho_pasta_html + "Reservatorio.html")
                ElseIf InStr(caminho, "Reservatorio2.html") Then
                    Enviar_Ficheiro(caminho_pasta_html + "Reservatorio2.html")
                ElseIf InStr(caminho, "Rodape.html") Then
                    Enviar_Ficheiro(caminho_pasta_html + "Rodape.html")
                ElseIf InStr(caminho, "Logo.html") Then
                    Enviar_Ficheiro(caminho_pasta_html + "Logo.html")
                End If
            End If
            ligacao.Close()
            ligacao = New TcpClient
        End If

    End Sub

    Private Sub Enviar_Ficheiro(ByVal caminho_do_ficheiro As String)
        If ligacao.Connected Then
            Dim stream_do_ficheiro As StreamReader = New StreamReader(caminho_do_ficheiro)
            Dim string_do_ficheiro As String = stream_do_ficheiro.ReadToEnd()
            stream_do_ficheiro.Close()

            ''Dim v_a_mon() As String = {"X0", "X1", "X2", "X3", "Y0", "Y1", "Y2"}

            Dim X0 = Mid(fs.GetItem(CSG, "X0"), 1, 1)
            Dim X1 = Mid(fs.GetItem(CSG, "X1"), 1, 1)
            Dim X2 = Mid(fs.GetItem(CSG, "X2"), 1, 1)
            Dim X3 = Mid(fs.GetItem(CSG, "X3"), 1, 1)
            Dim Y0 = Mid(fs.GetItem(CSG, "Y0"), 1, 1)
            Dim Y1 = Mid(fs.GetItem(CSG, "Y1"), 1, 1)
            Dim Y2 = Mid(fs.GetItem(CSG, "Y2"), 1, 1)

            string_do_ficheiro = Replace(string_do_ficheiro, "VALORX0", X0)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORX1", X1)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORX2", X2)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORX3", X3)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORY0", Y0)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORY1", Y1)
            string_do_ficheiro = Replace(string_do_ficheiro, "VALORY2", Y2)

            Dim header = "HTTP/1.1 200 OK" + vbNewLine + "Content-Type: text/html; charset=utf-8" + vbNewLine + vbNewLine
            Dim reply = header + string_do_ficheiro

            Dim reply_bytes() As Byte = Encoding.UTF8.GetBytes(reply)
            stream.Write(reply_bytes, 0, reply_bytes.Length)

            cmd.CommandText = "Insert into supervisao(Y0, Y1, Y2, X0, X1, X2, X3) Values(" & Y0 & "," & Y1 & "," & Y2 & "," & X0 & "," & X1 & "," & X2 & "," & X3 & ")"
            cmd.ExecuteNonQuery()
        End If
    End Sub

End Class
