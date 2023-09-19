'Imports the OPC-UA library
Imports Opc.UaFx.Client
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class Form1
    'Global variables creation
    Dim IP 'OPC-UA's server endpoint 
    Dim client 'Client instance
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Start up configurations (not needed)
        IP_tb.Text = "ibhlinkua_011088:48010"
        ns_tb.Text = "7"
        s_tb.Text = ".Publish.struct1.u11"
        write_tb.Text = "True"
        'Button Configuration
        Stop_btn.Enabled = True
        Start_btn.Enabled = False
        Stop_btn.Enabled = False
        Read_btn.Enabled = False
        Write_btn.Enabled = False
    End Sub
    Private Sub Config_btn_Click(sender As Object, e As EventArgs) Handles Config_btn.Click
        'Updates OPC-UA's server endpoint
        IP = "opc.tcp://" & IP_tb.Text 'OPC-UA's server endpoint 
        'Button Configuration
        Stop_btn.Enabled = True
        Start_btn.Enabled = True
        Stop_btn.Enabled = False
        Read_btn.Enabled = False
        Write_btn.Enabled = False
    End Sub
    Private Sub Start_btn_Click(sender As Object, e As EventArgs) Handles Start_btn.Click
        'Starts the connection with the OPC-UA Server
        client = New OpcClient(Convert.ToString(IP)) 'Converts the Object from a textbox to a String and creates A New OPC-UA Client
        client.Connect() 'Tries to stablish a connection with the OPC-UA Server

        'Button Configuration
        Stop_btn.Enabled = False
        Start_btn.Enabled = False
        Stop_btn.Enabled = True
        Read_btn.Enabled = True
        Write_btn.Enabled = True
    End Sub
    Private Sub Stop_btn_Click(sender As Object, e As EventArgs) Handles Stop_btn.Click
        'Ends the connection with the OPC-AU Server
        client.Disconnect() 'Finishes to stablish a connection with the OPC-UA Server
        'Button Configuration
        Stop_btn.Enabled = True
        Start_btn.Enabled = True
        Stop_btn.Enabled = False
        Read_btn.Enabled = False
        Write_btn.Enabled = False
    End Sub
    Private Sub Read_btn_Click(sender As Object, e As EventArgs) Handles Read_btn.Click
        'Request to read a variable from the OPC-UA Server
        Dim id = "ns=" & ns_tb.Text & ";s=" & s_tb.Text 'Variable endpoint identification
        Dim OPCValue = client.ReadNode(Convert.ToString(id)) 'Converts the Object from a textbox to a 
        'String And requests the variables info
        read_tb.Text = Convert.ToString(OPCValue) 'Converts the Object from the request to a String 
        'And updates the read textbox
    End Sub
    Private Sub Write_btn_Click(sender As Object, e As EventArgs) Handles Write_btn.Click
        'Submits to write a variable from the OPC-UA Server
        Dim id = "ns=" & ns_tb.Text & ";s=" & s_tb.Text 'Variable endpoint identification
        Dim OPCValue = client.WriteNode(Convert.ToString(id), Convert.ToString(write_tb.Text))
        'Converts the Object from a textbox to a String and requests to write a varibale from the OPC-UA 
        'Server
    End Sub

End Class