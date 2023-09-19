Imports System.IO.Ports

Public Class Form1
    Dim fs As New FaconSvr.FaconServer
    Dim is_facon_connected As Boolean = False
    Dim Csg = "Channel0.Station0.Group0"

    Dim Y0 As Integer
    Dim Y1 As Integer
    Dim Y2 As Integer
    Dim X0 As Integer
    Dim X1 As Integer
    Dim X2 As Integer
    Dim X3 As Integer

    Private Sub ConfigurarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Connect()

        fs.OpenProject("C:\Users\freit\OneDrive - Universidade de Aveiro\Mestrado\4 ano\2 Semestre\II\Prática\Aula 6\tp6.fcs")

        is_facon_connected = True
        TimerReceived.Enabled = True
        BttnOpen.Text = "Close Port"
        BttnOpen.BackColor = Color.Red
        TimerReceived.Enabled = True
        ToolStripStatusLabel1.Text = "Configuração Ligada"

        BttnY0.Enabled = True
        BttnY1.Enabled = True
        BttnY2.Enabled = True

    End Sub

    Private Sub Disconnect()
        TimerReceived.Enabled = False
        fs.Disconnect()
        is_facon_connected = False

        BttnOpen.Text = "Open Port"
        BttnOpen.BackColor = Color.LightGray
        TimerReceived.Enabled = False

        BttnY0.Enabled = False
        BttnY1.Enabled = False
        BttnY2.Enabled = False

        ToolStripStatusLabel1.Text = "Configuração Desligada"

    End Sub

    Private Sub TimerReceived_Tick(sender As Object, e As EventArgs) Handles TimerReceived.Tick

        Y0 = fs.GetItem(Csg, "Y0")
        Y1 = fs.GetItem(Csg, "Y1")
        Y2 = fs.GetItem(Csg, "Y2")
        X0 = fs.GetItem(Csg, "X0")
        X1 = fs.GetItem(Csg, "X1")
        X2 = fs.GetItem(Csg, "X2")
        X3 = fs.GetItem(Csg, "X3")

        ''TextBoxLevel.Text = fs.GetItem(Csg, "D300")

        CheckBoxX0.Checked = X0
        CheckBoxX1.Checked = X1
        CheckBoxX2.Checked = X2
        CheckBoxX3.Checked = X3

        CheckBoxY0.Checked = Y0
        CheckBoxY1.Checked = Y1
        CheckBoxY2.Checked = Y2

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerReceived.Interval = 500
        TimerAutoMode.Interval = 100

        Disconnect()
    End Sub

    Private Sub CheckAudoMode_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAutoMode.CheckedChanged
        If CheckAutoMode.Checked = True Then
            TimerAutoMode.Enabled = True
            BttnY0.Enabled = False
            BttnY1.Enabled = False
            BttnY2.Enabled = False
            ToolStripStatusLabelAutoMode.Text = "Auto Mode: enabled"
            ToolStripStatusLabelAlarms.Text = "Alarme: none"
        Else
            TimerAutoMode.Enabled = False
            BttnY0.Enabled = True
            BttnY1.Enabled = True
            BttnY2.Enabled = True
            ToolStripStatusLabelAutoMode.Text = "Auto Mode: disabled"

        End If
    End Sub

    Private Sub BttnY2_Click(sender As Object, e As EventArgs) Handles BttnY2.Click
        Y2 = If(Y2 = 1, 0, 1)
        fs.SetItem(Csg, "Y2", Y2)
    End Sub

    Private Sub BttnY1_Click(sender As Object, e As EventArgs) Handles BttnY1.Click
        Y1 = If(Y1 = 1, 0, 1)
        fs.SetItem(Csg, "Y1", Y1)
    End Sub

    Private Sub BttnY0_Click(sender As Object, e As EventArgs) Handles BttnY0.Click
        Y0 = If(Y0 = 1, 0, 1)
        fs.SetItem(Csg, "Y0", Y0)
    End Sub

    Private Sub TimerAutoMode_Tick(sender As Object, e As EventArgs) Handles TimerAutoMode.Tick
        Static is_filling As Boolean = True

        ToolStripStatusLabelAlarms.Text = "Alarme: "
        ToolStripStatusLabelAutoMode.Text = "Auto Mode (Enabled): "

        Y0 = fs.GetItem(Csg, "Y0")
        Y1 = fs.GetItem(Csg, "Y1")
        Y2 = fs.GetItem(Csg, "Y2")
        X0 = fs.GetItem(Csg, "X0")
        X1 = fs.GetItem(Csg, "X1")
        X2 = fs.GetItem(Csg, "X2")
        X3 = fs.GetItem(Csg, "X3")

        If X0 = 0 Then
            ToolStripStatusLabelAlarms.Text += "Tank is empty"
        End If
        If X3 = 1 Then
            ToolStripStatusLabelAlarms.Text += "Tank is full"
        End If

        If X1 = 0 Then
            ToolStripStatusLabelAutoMode.Text += "Water level low, Motor ON, EVIN ON and EVOUT OFF"
            Y0 = 1
            Y1 = 1
            Y2 = 0
            is_filling = True

        ElseIf X2 = 1 Then
            ToolStripStatusLabelAutoMode.Text += "Water level full, Motor OFF, EVIN OFF and EVOUT ON"
            Y0 = 0
            Y1 = 0
            Y2 = 1
            is_filling = False

        ElseIf is_filling = True Then
            ToolStripStatusLabelAutoMode.Text += "Filling, Motor ON, EVIN ON and EVOUT ON"
            Y0 = 1
            Y1 = 1
            Y2 = 1

        Else
            ToolStripStatusLabelAutoMode.Text += "Idle, Motor OFF, EVIN OFF and EVOUT ON"
            Y0 = 0
            Y1 = 0
            Y2 = 1
        End If

        fs.SetItem(Csg, "Y0", Y0)
        fs.SetItem(Csg, "Y1", Y1)
        fs.SetItem(Csg, "Y2", Y2)
        fs.SetItem(Csg, "X0", X0)
        fs.SetItem(Csg, "X1", X1)
        fs.SetItem(Csg, "X2", X2)
        fs.SetItem(Csg, "X3", X3)

    End Sub

    Private Sub BttnOpen_Click_1(sender As Object, e As EventArgs) Handles BttnOpen.Click
        If is_facon_connected = True Then
            Disconnect()
        Else
            Connect()
        End If
    End Sub
End Class
