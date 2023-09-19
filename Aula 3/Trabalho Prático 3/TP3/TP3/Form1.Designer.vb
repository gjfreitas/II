<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxReceive = New System.Windows.Forms.TextBox()
        Me.TextBoxSend = New System.Windows.Forms.TextBox()
        Me.BttnSend = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxHistory = New System.Windows.Forms.TextBox()
        Me.BttnExit = New System.Windows.Forms.Button()
        Me.BttnConfigure = New System.Windows.Forms.Button()
        Me.BttnOpen = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerReceived = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Receive Data"
        '
        'TextBoxReceive
        '
        Me.TextBoxReceive.Location = New System.Drawing.Point(296, 89)
        Me.TextBoxReceive.Multiline = True
        Me.TextBoxReceive.Name = "TextBoxReceive"
        Me.TextBoxReceive.ReadOnly = True
        Me.TextBoxReceive.Size = New System.Drawing.Size(193, 229)
        Me.TextBoxReceive.TabIndex = 3
        '
        'TextBoxSend
        '
        Me.TextBoxSend.Location = New System.Drawing.Point(56, 89)
        Me.TextBoxSend.Multiline = True
        Me.TextBoxSend.Name = "TextBoxSend"
        Me.TextBoxSend.Size = New System.Drawing.Size(193, 229)
        Me.TextBoxSend.TabIndex = 4
        '
        'BttnSend
        '
        Me.BttnSend.Location = New System.Drawing.Point(191, 344)
        Me.BttnSend.Name = "BttnSend"
        Me.BttnSend.Size = New System.Drawing.Size(158, 48)
        Me.BttnSend.TabIndex = 5
        Me.BttnSend.Text = "Send"
        Me.BttnSend.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data to Send"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(694, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Communication History"
        '
        'TextBoxHistory
        '
        Me.TextBoxHistory.Location = New System.Drawing.Point(698, 89)
        Me.TextBoxHistory.Multiline = True
        Me.TextBoxHistory.Name = "TextBoxHistory"
        Me.TextBoxHistory.ReadOnly = True
        Me.TextBoxHistory.Size = New System.Drawing.Size(193, 229)
        Me.TextBoxHistory.TabIndex = 7
        '
        'BttnExit
        '
        Me.BttnExit.Location = New System.Drawing.Point(698, 358)
        Me.BttnExit.Name = "BttnExit"
        Me.BttnExit.Size = New System.Drawing.Size(158, 48)
        Me.BttnExit.TabIndex = 8
        Me.BttnExit.Text = "Exit"
        Me.BttnExit.UseVisualStyleBackColor = True
        '
        'BttnConfigure
        '
        Me.BttnConfigure.Location = New System.Drawing.Point(509, 103)
        Me.BttnConfigure.Name = "BttnConfigure"
        Me.BttnConfigure.Size = New System.Drawing.Size(158, 48)
        Me.BttnConfigure.TabIndex = 9
        Me.BttnConfigure.Text = "Configure Port"
        Me.BttnConfigure.UseVisualStyleBackColor = True
        '
        'BttnOpen
        '
        Me.BttnOpen.Location = New System.Drawing.Point(509, 171)
        Me.BttnOpen.Name = "BttnOpen"
        Me.BttnOpen.Size = New System.Drawing.Size(158, 48)
        Me.BttnOpen.TabIndex = 10
        Me.BttnOpen.Text = "Open Port"
        Me.BttnOpen.UseVisualStyleBackColor = True
        '
        'TimerReceived
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 450)
        Me.Controls.Add(Me.BttnOpen)
        Me.Controls.Add(Me.BttnConfigure)
        Me.Controls.Add(Me.BttnExit)
        Me.Controls.Add(Me.TextBoxHistory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BttnSend)
        Me.Controls.Add(Me.TextBoxSend)
        Me.Controls.Add(Me.TextBoxReceive)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxReceive As TextBox
    Friend WithEvents TextBoxSend As TextBox
    Friend WithEvents BttnSend As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxHistory As TextBox
    Friend WithEvents BttnExit As Button
    Friend WithEvents BttnConfigure As Button
    Friend WithEvents BttnOpen As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerReceived As Timer
End Class
