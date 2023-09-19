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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBR = New System.Windows.Forms.ComboBox()
        Me.ComboBoxParity = New System.Windows.Forms.ComboBox()
        Me.BttnCancel = New System.Windows.Forms.Button()
        Me.BttnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BaudRate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Parity"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(239, 50)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxPort.TabIndex = 3
        '
        'ComboBoxBR
        '
        Me.ComboBoxBR.FormattingEnabled = True
        Me.ComboBoxBR.Location = New System.Drawing.Point(239, 119)
        Me.ComboBoxBR.Name = "ComboBoxBR"
        Me.ComboBoxBR.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxBR.TabIndex = 4
        '
        'ComboBoxParity
        '
        Me.ComboBoxParity.FormattingEnabled = True
        Me.ComboBoxParity.Location = New System.Drawing.Point(239, 183)
        Me.ComboBoxParity.Name = "ComboBoxParity"
        Me.ComboBoxParity.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxParity.TabIndex = 5
        '
        'BttnCancel
        '
        Me.BttnCancel.Location = New System.Drawing.Point(46, 241)
        Me.BttnCancel.Name = "BttnCancel"
        Me.BttnCancel.Size = New System.Drawing.Size(96, 39)
        Me.BttnCancel.TabIndex = 6
        Me.BttnCancel.Text = "Cancel"
        Me.BttnCancel.UseVisualStyleBackColor = True
        '
        'BttnOk
        '
        Me.BttnOk.Location = New System.Drawing.Point(239, 241)
        Me.BttnOk.Name = "BttnOk"
        Me.BttnOk.Size = New System.Drawing.Size(96, 39)
        Me.BttnOk.TabIndex = 7
        Me.BttnOk.Text = "Ok"
        Me.BttnOk.UseVisualStyleBackColor = True
        '
        'FormComportConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 292)
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

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ComboBoxBR As ComboBox
    Friend WithEvents ComboBoxParity As ComboBox
    Friend WithEvents BttnCancel As Button
    Friend WithEvents BttnOk As Button
End Class
