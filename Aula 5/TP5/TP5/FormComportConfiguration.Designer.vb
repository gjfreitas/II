<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComportConfiguration
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
        Me.BttnOk = New System.Windows.Forms.Button()
        Me.BttnCancel = New System.Windows.Forms.Button()
        Me.ComboBoxParity = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBR = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxDataBits = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxStopBits = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BttnOk
        '
        Me.BttnOk.Location = New System.Drawing.Point(223, 296)
        Me.BttnOk.Name = "BttnOk"
        Me.BttnOk.Size = New System.Drawing.Size(96, 39)
        Me.BttnOk.TabIndex = 15
        Me.BttnOk.Text = "Ok"
        Me.BttnOk.UseVisualStyleBackColor = True
        '
        'BttnCancel
        '
        Me.BttnCancel.Location = New System.Drawing.Point(30, 296)
        Me.BttnCancel.Name = "BttnCancel"
        Me.BttnCancel.Size = New System.Drawing.Size(96, 39)
        Me.BttnCancel.TabIndex = 14
        Me.BttnCancel.Text = "Cancel"
        Me.BttnCancel.UseVisualStyleBackColor = True
        '
        'ComboBoxParity
        '
        Me.ComboBoxParity.FormattingEnabled = True
        Me.ComboBoxParity.Location = New System.Drawing.Point(223, 152)
        Me.ComboBoxParity.Name = "ComboBoxParity"
        Me.ComboBoxParity.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxParity.TabIndex = 13
        '
        'ComboBoxBR
        '
        Me.ComboBoxBR.FormattingEnabled = True
        Me.ComboBoxBR.Location = New System.Drawing.Point(223, 88)
        Me.ComboBoxBR.Name = "ComboBoxBR"
        Me.ComboBoxBR.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxBR.TabIndex = 12
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(223, 19)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxPort.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Parity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "BaudRate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Port"
        '
        'ComboBoxDataBits
        '
        Me.ComboBoxDataBits.FormattingEnabled = True
        Me.ComboBoxDataBits.Location = New System.Drawing.Point(223, 204)
        Me.ComboBoxDataBits.Name = "ComboBoxDataBits"
        Me.ComboBoxDataBits.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxDataBits.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Data Bits"
        '
        'ComboBoxStopBits
        '
        Me.ComboBoxStopBits.FormattingEnabled = True
        Me.ComboBoxStopBits.Location = New System.Drawing.Point(223, 253)
        Me.ComboBoxStopBits.Name = "ComboBoxStopBits"
        Me.ComboBoxStopBits.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxStopBits.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Stop Bits"
        '
        'FormComportConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 393)
        Me.Controls.Add(Me.ComboBoxStopBits)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxDataBits)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BttnOk)
        Me.Controls.Add(Me.BttnCancel)
        Me.Controls.Add(Me.ComboBoxParity)
        Me.Controls.Add(Me.ComboBoxBR)
        Me.Controls.Add(Me.ComboBoxPort)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormComportConfiguration"
        Me.Text = "FormComportConfiguration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BttnOk As Button
    Friend WithEvents BttnCancel As Button
    Friend WithEvents ComboBoxParity As ComboBox
    Friend WithEvents ComboBoxBR As ComboBox
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxDataBits As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxStopBits As ComboBox
    Friend WithEvents Label5 As Label
End Class
