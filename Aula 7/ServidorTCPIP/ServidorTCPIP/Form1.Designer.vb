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
        Me.TextBoxReceber = New System.Windows.Forms.TextBox()
        Me.TextBoxEstadoLigacao = New System.Windows.Forms.TextBox()
        Me.CheckBoxX0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY2 = New System.Windows.Forms.CheckBox()
        Me.TextBoxVelocidadeMotorLida = New System.Windows.Forms.TextBox()
        Me.TextBoxVelocidadeMotor = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerSend = New System.Windows.Forms.Timer(Me.components)
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.TimerVerifyConnection = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TextBoxReceber
        '
        Me.TextBoxReceber.Location = New System.Drawing.Point(12, 22)
        Me.TextBoxReceber.Multiline = True
        Me.TextBoxReceber.Name = "TextBoxReceber"
        Me.TextBoxReceber.Size = New System.Drawing.Size(238, 269)
        Me.TextBoxReceber.TabIndex = 0
        '
        'TextBoxEstadoLigacao
        '
        Me.TextBoxEstadoLigacao.Location = New System.Drawing.Point(12, 309)
        Me.TextBoxEstadoLigacao.Name = "TextBoxEstadoLigacao"
        Me.TextBoxEstadoLigacao.Size = New System.Drawing.Size(238, 26)
        Me.TextBoxEstadoLigacao.TabIndex = 1
        '
        'CheckBoxX0
        '
        Me.CheckBoxX0.AutoSize = True
        Me.CheckBoxX0.Location = New System.Drawing.Point(69, 353)
        Me.CheckBoxX0.Name = "CheckBoxX0"
        Me.CheckBoxX0.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX0.TabIndex = 2
        Me.CheckBoxX0.Text = "X0"
        Me.CheckBoxX0.UseVisualStyleBackColor = True
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.AutoSize = True
        Me.CheckBoxX1.Location = New System.Drawing.Point(69, 383)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX1.TabIndex = 3
        Me.CheckBoxX1.Text = "X1"
        Me.CheckBoxX1.UseVisualStyleBackColor = True
        '
        'CheckBoxX2
        '
        Me.CheckBoxX2.AutoSize = True
        Me.CheckBoxX2.Location = New System.Drawing.Point(69, 413)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX2.TabIndex = 4
        Me.CheckBoxX2.Text = "X2"
        Me.CheckBoxX2.UseVisualStyleBackColor = True
        '
        'CheckBoxX3
        '
        Me.CheckBoxX3.AutoSize = True
        Me.CheckBoxX3.Location = New System.Drawing.Point(69, 443)
        Me.CheckBoxX3.Name = "CheckBoxX3"
        Me.CheckBoxX3.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX3.TabIndex = 5
        Me.CheckBoxX3.Text = "X3"
        Me.CheckBoxX3.UseVisualStyleBackColor = True
        '
        'CheckBoxY0
        '
        Me.CheckBoxY0.AutoSize = True
        Me.CheckBoxY0.Location = New System.Drawing.Point(283, 38)
        Me.CheckBoxY0.Name = "CheckBoxY0"
        Me.CheckBoxY0.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxY0.TabIndex = 6
        Me.CheckBoxY0.Text = "Y0"
        Me.CheckBoxY0.UseVisualStyleBackColor = True
        '
        'CheckBoxY1
        '
        Me.CheckBoxY1.AutoSize = True
        Me.CheckBoxY1.Location = New System.Drawing.Point(283, 84)
        Me.CheckBoxY1.Name = "CheckBoxY1"
        Me.CheckBoxY1.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxY1.TabIndex = 7
        Me.CheckBoxY1.Text = "Y1"
        Me.CheckBoxY1.UseVisualStyleBackColor = True
        '
        'CheckBoxY2
        '
        Me.CheckBoxY2.AutoSize = True
        Me.CheckBoxY2.Location = New System.Drawing.Point(283, 128)
        Me.CheckBoxY2.Name = "CheckBoxY2"
        Me.CheckBoxY2.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxY2.TabIndex = 8
        Me.CheckBoxY2.Text = "Y2"
        Me.CheckBoxY2.UseVisualStyleBackColor = True
        '
        'TextBoxVelocidadeMotorLida
        '
        Me.TextBoxVelocidadeMotorLida.Location = New System.Drawing.Point(246, 443)
        Me.TextBoxVelocidadeMotorLida.Name = "TextBoxVelocidadeMotorLida"
        Me.TextBoxVelocidadeMotorLida.Size = New System.Drawing.Size(125, 26)
        Me.TextBoxVelocidadeMotorLida.TabIndex = 9
        '
        'TextBoxVelocidadeMotor
        '
        Me.TextBoxVelocidadeMotor.Location = New System.Drawing.Point(260, 202)
        Me.TextBoxVelocidadeMotor.Name = "TextBoxVelocidadeMotor"
        Me.TextBoxVelocidadeMotor.Size = New System.Drawing.Size(148, 26)
        Me.TextBoxVelocidadeMotor.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(303, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Desligar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Velocidade do motor lida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Velocidade do motor"
        '
        'TimerSend
        '
        '
        'TimerReceive
        '
        '
        'TimerVerifyConnection
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 505)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxVelocidadeMotor)
        Me.Controls.Add(Me.TextBoxVelocidadeMotorLida)
        Me.Controls.Add(Me.CheckBoxY2)
        Me.Controls.Add(Me.CheckBoxY1)
        Me.Controls.Add(Me.CheckBoxY0)
        Me.Controls.Add(Me.CheckBoxX3)
        Me.Controls.Add(Me.CheckBoxX2)
        Me.Controls.Add(Me.CheckBoxX1)
        Me.Controls.Add(Me.CheckBoxX0)
        Me.Controls.Add(Me.TextBoxEstadoLigacao)
        Me.Controls.Add(Me.TextBoxReceber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxReceber As TextBox
    Friend WithEvents TextBoxEstadoLigacao As TextBox
    Friend WithEvents CheckBoxX0 As CheckBox
    Friend WithEvents CheckBoxX1 As CheckBox
    Friend WithEvents CheckBoxX2 As CheckBox
    Friend WithEvents CheckBoxX3 As CheckBox
    Friend WithEvents CheckBoxY0 As CheckBox
    Friend WithEvents CheckBoxY1 As CheckBox
    Friend WithEvents CheckBoxY2 As CheckBox
    Friend WithEvents TextBoxVelocidadeMotorLida As TextBox
    Friend WithEvents TextBoxVelocidadeMotor As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TimerSend As Timer
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents TimerVerifyConnection As Timer
End Class
