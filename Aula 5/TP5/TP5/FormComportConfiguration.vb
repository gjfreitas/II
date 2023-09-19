Public Class FormComportConfiguration
    Private Sub FormComportConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim available_ports As Array = IO.Ports.SerialPort.GetPortNames
        Dim i As Integer
        ComboBoxPort.Items.Clear()
        For i = 0 To UBound(available_ports)
            ComboBoxPort.Items.Add(available_ports(i))
        Next
        ComboBoxPort.SelectedIndex = 1

        ComboBoxBR.Items.Clear()
        ComboBoxBR.Items.Add("4800")
        ComboBoxBR.Items.Add("9600")
        ComboBoxBR.Items.Add("19200")
        ComboBoxBR.SelectedIndex = 1

        ComboBoxParity.Items.Clear()
        ComboBoxParity.Items.Add(IO.Ports.Parity.None)
        ComboBoxParity.Items.Add(IO.Ports.Parity.Odd)
        ComboBoxParity.Items.Add(IO.Ports.Parity.Even)
        ComboBoxParity.SelectedIndex = 2

        ComboBoxDataBits.Items.Clear()
        ComboBoxDataBits.Items.Add("7")
        ComboBoxDataBits.Items.Add("8")
        ComboBoxDataBits.SelectedIndex = 0


        ComboBoxStopBits.Items.Clear()
        ComboBoxStopBits.Items.Add("1")
        ComboBoxStopBits.Items.Add("2")
        ComboBoxStopBits.SelectedIndex = 0

    End Sub

    Private Sub BttnCancel_Click(sender As Object, e As EventArgs) Handles BttnCancel.Click
        ModuleComPortParameters.port = ComboBoxPort.Text
        Me.Close()
    End Sub

    Private Sub BttnOk_Click(sender As Object, e As EventArgs) Handles BttnOk.Click
        ModuleComPortParameters.port = ComboBoxPort.Text
        ModuleComPortParameters.baud_rate = ComboBoxBR.Text
        ModuleComPortParameters.data_bits = ComboBoxDataBits.Text
        ModuleComPortParameters.stop_bits = ComboBoxStopBits.Text

        Select Case ComboBoxParity.Text
            Case "None"
                ModuleComPortParameters.parity = IO.Ports.Parity.None
            Case "Even"
                ModuleComPortParameters.parity = IO.Ports.Parity.Even
            Case "Odd"
                ModuleComPortParameters.parity = IO.Ports.Parity.Odd
        End Select

        ModuleComPortParameters.configuration_is_valid = True

        Me.Close()

    End Sub
End Class