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
        Me.BttnSend = New System.Windows.Forms.Button()
        Me.TextBoxSend = New System.Windows.Forms.TextBox()
        Me.TextBoxReceber = New System.Windows.Forms.TextBox()
        Me.BttnReceb = New System.Windows.Forms.Button()
        Me.Configure = New System.Windows.Forms.Button()
        Me.BttnOpen = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BttnSend
        '
        Me.BttnSend.Location = New System.Drawing.Point(42, 281)
        Me.BttnSend.Name = "BttnSend"
        Me.BttnSend.Size = New System.Drawing.Size(194, 39)
        Me.BttnSend.TabIndex = 2
        Me.BttnSend.Text = "Send"
        Me.BttnSend.UseVisualStyleBackColor = True
        '
        'TextBoxSend
        '
        Me.TextBoxSend.Location = New System.Drawing.Point(42, 27)
        Me.TextBoxSend.Multiline = True
        Me.TextBoxSend.Name = "TextBoxSend"
        Me.TextBoxSend.Size = New System.Drawing.Size(194, 248)
        Me.TextBoxSend.TabIndex = 4
        '
        'TextBoxReceber
        '
        Me.TextBoxReceber.Location = New System.Drawing.Point(287, 27)
        Me.TextBoxReceber.Multiline = True
        Me.TextBoxReceber.Name = "TextBoxReceber"
        Me.TextBoxReceber.Size = New System.Drawing.Size(194, 248)
        Me.TextBoxReceber.TabIndex = 5
        '
        'BttnReceb
        '
        Me.BttnReceb.Location = New System.Drawing.Point(287, 281)
        Me.BttnReceb.Name = "BttnReceb"
        Me.BttnReceb.Size = New System.Drawing.Size(194, 39)
        Me.BttnReceb.TabIndex = 6
        Me.BttnReceb.Text = "Receive"
        Me.BttnReceb.UseVisualStyleBackColor = True
        '
        'Configure
        '
        Me.Configure.Location = New System.Drawing.Point(562, 21)
        Me.Configure.Name = "Configure"
        Me.Configure.Size = New System.Drawing.Size(194, 39)
        Me.Configure.TabIndex = 7
        Me.Configure.Text = "Configure Port"
        Me.Configure.UseVisualStyleBackColor = True
        '
        'BttnOpen
        '
        Me.BttnOpen.Location = New System.Drawing.Point(562, 88)
        Me.BttnOpen.Name = "BttnOpen"
        Me.BttnOpen.Size = New System.Drawing.Size(194, 39)
        Me.BttnOpen.TabIndex = 8
        Me.BttnOpen.Text = "Open Port"
        Me.BttnOpen.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(562, 281)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(194, 39)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Sair"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 350)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BttnOpen)
        Me.Controls.Add(Me.Configure)
        Me.Controls.Add(Me.BttnReceb)
        Me.Controls.Add(Me.TextBoxReceber)
        Me.Controls.Add(Me.TextBoxSend)
        Me.Controls.Add(Me.BttnSend)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BttnSend As Button
    Friend WithEvents TextBoxSend As TextBox
    Friend WithEvents TextBoxReceber As TextBox
    Friend WithEvents BttnReceb As Button
    Friend WithEvents Configure As Button
    Friend WithEvents BttnOpen As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
End Class
