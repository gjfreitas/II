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
        Me.ButtonLigar = New System.Windows.Forms.Button()
        Me.ButtonDesligar = New System.Windows.Forms.Button()
        Me.CheckBoxY0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX3 = New System.Windows.Forms.CheckBox()
        Me.TextBoxEstadoLigacao = New System.Windows.Forms.TextBox()
        Me.TextBoxVelocidadeMotorLida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonEnviarCheckBox = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxVelocidadeMotor = New System.Windows.Forms.TextBox()
        Me.TimerReceive = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButtonLigar
        '
        Me.ButtonLigar.Location = New System.Drawing.Point(24, 57)
        Me.ButtonLigar.Name = "ButtonLigar"
        Me.ButtonLigar.Size = New System.Drawing.Size(151, 36)
        Me.ButtonLigar.TabIndex = 0
        Me.ButtonLigar.Text = "Ligar a 127.0.0.1"
        Me.ButtonLigar.UseVisualStyleBackColor = True
        '
        'ButtonDesligar
        '
        Me.ButtonDesligar.Location = New System.Drawing.Point(24, 115)
        Me.ButtonDesligar.Name = "ButtonDesligar"
        Me.ButtonDesligar.Size = New System.Drawing.Size(151, 43)
        Me.ButtonDesligar.TabIndex = 1
        Me.ButtonDesligar.Text = "Desligar 127.0.0.1"
        Me.ButtonDesligar.UseVisualStyleBackColor = True
        '
        'CheckBoxY0
        '
        Me.CheckBoxY0.AutoSize = True
        Me.CheckBoxY0.Location = New System.Drawing.Point(215, 64)
        Me.CheckBoxY0.Name = "CheckBoxY0"
        Me.CheckBoxY0.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxY0.TabIndex = 2
        Me.CheckBoxY0.Text = "Y0"
        Me.CheckBoxY0.UseVisualStyleBackColor = True
        '
        'CheckBoxY1
        '
        Me.CheckBoxY1.AutoSize = True
        Me.CheckBoxY1.Location = New System.Drawing.Point(215, 94)
        Me.CheckBoxY1.Name = "CheckBoxY1"
        Me.CheckBoxY1.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxY1.TabIndex = 3
        Me.CheckBoxY1.Text = "Y1"
        Me.CheckBoxY1.UseVisualStyleBackColor = True
        '
        'CheckBoxY2
        '
        Me.CheckBoxY2.AutoSize = True
        Me.CheckBoxY2.Location = New System.Drawing.Point(215, 125)
        Me.CheckBoxY2.Name = "CheckBoxY2"
        Me.CheckBoxY2.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxY2.TabIndex = 4
        Me.CheckBoxY2.Text = "Y2"
        Me.CheckBoxY2.UseVisualStyleBackColor = True
        '
        'CheckBoxX2
        '
        Me.CheckBoxX2.AutoSize = True
        Me.CheckBoxX2.Location = New System.Drawing.Point(24, 334)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX2.TabIndex = 7
        Me.CheckBoxX2.Text = "X2"
        Me.CheckBoxX2.UseVisualStyleBackColor = True
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.AutoSize = True
        Me.CheckBoxX1.Location = New System.Drawing.Point(24, 303)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX1.TabIndex = 6
        Me.CheckBoxX1.Text = "X1"
        Me.CheckBoxX1.UseVisualStyleBackColor = True
        '
        'CheckBoxX0
        '
        Me.CheckBoxX0.AutoSize = True
        Me.CheckBoxX0.Location = New System.Drawing.Point(24, 273)
        Me.CheckBoxX0.Name = "CheckBoxX0"
        Me.CheckBoxX0.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX0.TabIndex = 5
        Me.CheckBoxX0.Text = "X0"
        Me.CheckBoxX0.UseVisualStyleBackColor = True
        '
        'CheckBoxX3
        '
        Me.CheckBoxX3.AutoSize = True
        Me.CheckBoxX3.Location = New System.Drawing.Point(24, 364)
        Me.CheckBoxX3.Name = "CheckBoxX3"
        Me.CheckBoxX3.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX3.TabIndex = 8
        Me.CheckBoxX3.Text = "X3"
        Me.CheckBoxX3.UseVisualStyleBackColor = True
        '
        'TextBoxEstadoLigacao
        '
        Me.TextBoxEstadoLigacao.Location = New System.Drawing.Point(24, 217)
        Me.TextBoxEstadoLigacao.Name = "TextBoxEstadoLigacao"
        Me.TextBoxEstadoLigacao.Size = New System.Drawing.Size(379, 26)
        Me.TextBoxEstadoLigacao.TabIndex = 9
        '
        'TextBoxVelocidadeMotorLida
        '
        Me.TextBoxVelocidadeMotorLida.Location = New System.Drawing.Point(184, 362)
        Me.TextBoxVelocidadeMotorLida.Name = "TextBoxVelocidadeMotorLida"
        Me.TextBoxVelocidadeMotorLida.Size = New System.Drawing.Size(219, 26)
        Me.TextBoxVelocidadeMotorLida.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Velocidade do motor lida"
        '
        'ButtonEnviarCheckBox
        '
        Me.ButtonEnviarCheckBox.Location = New System.Drawing.Point(215, 164)
        Me.ButtonEnviarCheckBox.Name = "ButtonEnviarCheckBox"
        Me.ButtonEnviarCheckBox.Size = New System.Drawing.Size(188, 38)
        Me.ButtonEnviarCheckBox.TabIndex = 13
        Me.ButtonEnviarCheckBox.Text = "Enviar CheckBoxes"
        Me.ButtonEnviarCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Velocidade do motor"
        '
        'TextBoxVelocidadeMotor
        '
        Me.TextBoxVelocidadeMotor.Location = New System.Drawing.Point(306, 94)
        Me.TextBoxVelocidadeMotor.Name = "TextBoxVelocidadeMotor"
        Me.TextBoxVelocidadeMotor.Size = New System.Drawing.Size(145, 26)
        Me.TextBoxVelocidadeMotor.TabIndex = 14
        '
        'TimerReceive
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxVelocidadeMotor)
        Me.Controls.Add(Me.ButtonEnviarCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxVelocidadeMotorLida)
        Me.Controls.Add(Me.TextBoxEstadoLigacao)
        Me.Controls.Add(Me.CheckBoxX3)
        Me.Controls.Add(Me.CheckBoxX2)
        Me.Controls.Add(Me.CheckBoxX1)
        Me.Controls.Add(Me.CheckBoxX0)
        Me.Controls.Add(Me.CheckBoxY2)
        Me.Controls.Add(Me.CheckBoxY1)
        Me.Controls.Add(Me.CheckBoxY0)
        Me.Controls.Add(Me.ButtonDesligar)
        Me.Controls.Add(Me.ButtonLigar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonLigar As Button
    Friend WithEvents ButtonDesligar As Button
    Friend WithEvents CheckBoxY0 As CheckBox
    Friend WithEvents CheckBoxY1 As CheckBox
    Friend WithEvents CheckBoxY2 As CheckBox
    Friend WithEvents CheckBoxX2 As CheckBox
    Friend WithEvents CheckBoxX1 As CheckBox
    Friend WithEvents CheckBoxX0 As CheckBox
    Friend WithEvents CheckBoxX3 As CheckBox
    Friend WithEvents TextBoxEstadoLigacao As TextBox
    Friend WithEvents TextBoxVelocidadeMotorLida As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonEnviarCheckBox As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxVelocidadeMotor As TextBox
    Friend WithEvents TimerReceive As Timer
End Class
