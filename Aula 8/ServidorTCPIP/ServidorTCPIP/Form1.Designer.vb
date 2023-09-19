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
        Me.CheckBoxX0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY2 = New System.Windows.Forms.CheckBox()
        Me.TxtBox_WL = New System.Windows.Forms.TextBox()
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
        Me.TextBoxReceber.Size = New System.Drawing.Size(277, 269)
        Me.TextBoxReceber.TabIndex = 0
        '
        'CheckBoxX0
        '
        Me.CheckBoxX0.AutoSize = True
        Me.CheckBoxX0.Location = New System.Drawing.Point(372, 24)
        Me.CheckBoxX0.Name = "CheckBoxX0"
        Me.CheckBoxX0.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX0.TabIndex = 2
        Me.CheckBoxX0.Text = "X0"
        Me.CheckBoxX0.UseVisualStyleBackColor = True
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.AutoSize = True
        Me.CheckBoxX1.Location = New System.Drawing.Point(372, 54)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX1.TabIndex = 3
        Me.CheckBoxX1.Text = "X1"
        Me.CheckBoxX1.UseVisualStyleBackColor = True
        '
        'CheckBoxX2
        '
        Me.CheckBoxX2.AutoSize = True
        Me.CheckBoxX2.Location = New System.Drawing.Point(372, 84)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX2.TabIndex = 4
        Me.CheckBoxX2.Text = "X2"
        Me.CheckBoxX2.UseVisualStyleBackColor = True
        '
        'CheckBoxX3
        '
        Me.CheckBoxX3.AutoSize = True
        Me.CheckBoxX3.Location = New System.Drawing.Point(372, 114)
        Me.CheckBoxX3.Name = "CheckBoxX3"
        Me.CheckBoxX3.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxX3.TabIndex = 5
        Me.CheckBoxX3.Text = "X3"
        Me.CheckBoxX3.UseVisualStyleBackColor = True
        '
        'CheckBoxY0
        '
        Me.CheckBoxY0.AutoSize = True
        Me.CheckBoxY0.Location = New System.Drawing.Point(299, 24)
        Me.CheckBoxY0.Name = "CheckBoxY0"
        Me.CheckBoxY0.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxY0.TabIndex = 6
        Me.CheckBoxY0.Text = "Y0"
        Me.CheckBoxY0.UseVisualStyleBackColor = True
        '
        'CheckBoxY1
        '
        Me.CheckBoxY1.AutoSize = True
        Me.CheckBoxY1.Location = New System.Drawing.Point(299, 70)
        Me.CheckBoxY1.Name = "CheckBoxY1"
        Me.CheckBoxY1.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxY1.TabIndex = 7
        Me.CheckBoxY1.Text = "Y1"
        Me.CheckBoxY1.UseVisualStyleBackColor = True
        '
        'CheckBoxY2
        '
        Me.CheckBoxY2.AutoSize = True
        Me.CheckBoxY2.Location = New System.Drawing.Point(299, 114)
        Me.CheckBoxY2.Name = "CheckBoxY2"
        Me.CheckBoxY2.Size = New System.Drawing.Size(55, 24)
        Me.CheckBoxY2.TabIndex = 8
        Me.CheckBoxY2.Text = "Y2"
        Me.CheckBoxY2.UseVisualStyleBackColor = True
        '
        'TxtBox_WL
        '
        Me.TxtBox_WL.Location = New System.Drawing.Point(299, 191)
        Me.TxtBox_WL.Name = "TxtBox_WL"
        Me.TxtBox_WL.Size = New System.Drawing.Size(148, 26)
        Me.TxtBox_WL.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Water Lever"
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
        Me.ClientSize = New System.Drawing.Size(546, 313)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBox_WL)
        Me.Controls.Add(Me.CheckBoxY2)
        Me.Controls.Add(Me.CheckBoxY1)
        Me.Controls.Add(Me.CheckBoxY0)
        Me.Controls.Add(Me.CheckBoxX3)
        Me.Controls.Add(Me.CheckBoxX2)
        Me.Controls.Add(Me.CheckBoxX1)
        Me.Controls.Add(Me.CheckBoxX0)
        Me.Controls.Add(Me.TextBoxReceber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxReceber As TextBox
    Friend WithEvents CheckBoxX0 As CheckBox
    Friend WithEvents CheckBoxX1 As CheckBox
    Friend WithEvents CheckBoxX2 As CheckBox
    Friend WithEvents CheckBoxX3 As CheckBox
    Friend WithEvents CheckBoxY0 As CheckBox
    Friend WithEvents CheckBoxY1 As CheckBox
    Friend WithEvents CheckBoxY2 As CheckBox
    Friend WithEvents TxtBox_WL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TimerSend As Timer
    Friend WithEvents TimerReceive As Timer
    Friend WithEvents TimerVerifyConnection As Timer
End Class
