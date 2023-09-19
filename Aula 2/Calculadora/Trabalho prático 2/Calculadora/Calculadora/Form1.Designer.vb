<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnMinus = New System.Windows.Forms.Button()
        Me.bttnMulti = New System.Windows.Forms.Button()
        Me.bttnDivid = New System.Windows.Forms.Button()
        Me.bttnEqual = New System.Windows.Forms.Button()
        Me.bttnClear = New System.Windows.Forms.Button()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOP1 = New System.Windows.Forms.TextBox()
        Me.txtOP2 = New System.Windows.Forms.TextBox()
        Me.txtOP = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.TimerDate = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 434)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(719, 32)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(180, 25)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(167, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 34)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(34, 180)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 34)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(167, 180)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 34)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(299, 129)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 34)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(299, 180)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 34)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(34, 232)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 34)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(167, 232)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 34)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(299, 232)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(112, 34)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Location = New System.Drawing.Point(34, 285)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(112, 34)
        Me.Button0.TabIndex = 10
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'bttnAdd
        '
        Me.bttnAdd.Location = New System.Drawing.Point(451, 129)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(112, 34)
        Me.bttnAdd.TabIndex = 11
        Me.bttnAdd.Text = "+"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnMinus
        '
        Me.bttnMinus.Location = New System.Drawing.Point(451, 180)
        Me.bttnMinus.Name = "bttnMinus"
        Me.bttnMinus.Size = New System.Drawing.Size(112, 34)
        Me.bttnMinus.TabIndex = 12
        Me.bttnMinus.Text = "-"
        Me.bttnMinus.UseVisualStyleBackColor = True
        '
        'bttnMulti
        '
        Me.bttnMulti.Location = New System.Drawing.Point(451, 232)
        Me.bttnMulti.Name = "bttnMulti"
        Me.bttnMulti.Size = New System.Drawing.Size(112, 34)
        Me.bttnMulti.TabIndex = 13
        Me.bttnMulti.Text = "x"
        Me.bttnMulti.UseVisualStyleBackColor = True
        '
        'bttnDivid
        '
        Me.bttnDivid.Location = New System.Drawing.Point(451, 285)
        Me.bttnDivid.Name = "bttnDivid"
        Me.bttnDivid.Size = New System.Drawing.Size(112, 34)
        Me.bttnDivid.TabIndex = 14
        Me.bttnDivid.Text = "/"
        Me.bttnDivid.UseVisualStyleBackColor = True
        '
        'bttnEqual
        '
        Me.bttnEqual.Location = New System.Drawing.Point(584, 129)
        Me.bttnEqual.Name = "bttnEqual"
        Me.bttnEqual.Size = New System.Drawing.Size(112, 34)
        Me.bttnEqual.TabIndex = 15
        Me.bttnEqual.Text = "="
        Me.bttnEqual.UseVisualStyleBackColor = True
        '
        'bttnClear
        '
        Me.bttnClear.Location = New System.Drawing.Point(584, 180)
        Me.bttnClear.Name = "bttnClear"
        Me.bttnClear.Size = New System.Drawing.Size(112, 34)
        Me.bttnClear.TabIndex = 16
        Me.bttnClear.Text = "C"
        Me.bttnClear.UseVisualStyleBackColor = True
        '
        'bttnClose
        '
        Me.bttnClose.Location = New System.Drawing.Point(584, 285)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(112, 34)
        Me.bttnClose.TabIndex = 17
        Me.bttnClose.Text = "Sair"
        Me.bttnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Operador 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Operador 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(410, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Operação"
        '
        'txtOP1
        '
        Me.txtOP1.Location = New System.Drawing.Point(42, 384)
        Me.txtOP1.Name = "txtOP1"
        Me.txtOP1.ReadOnly = True
        Me.txtOP1.Size = New System.Drawing.Size(150, 31)
        Me.txtOP1.TabIndex = 21
        '
        'txtOP2
        '
        Me.txtOP2.Location = New System.Drawing.Point(223, 384)
        Me.txtOP2.Name = "txtOP2"
        Me.txtOP2.ReadOnly = True
        Me.txtOP2.Size = New System.Drawing.Size(150, 31)
        Me.txtOP2.TabIndex = 22
        '
        'txtOP
        '
        Me.txtOP.Location = New System.Drawing.Point(410, 384)
        Me.txtOP.Name = "txtOP"
        Me.txtOP.ReadOnly = True
        Me.txtOP.Size = New System.Drawing.Size(150, 31)
        Me.txtOP.TabIndex = 23
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(34, 83)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(150, 31)
        Me.txtResultado.TabIndex = 25
        '
        'TimerDate
        '
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(34, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(300, 31)
        Me.DateTimePicker1.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 466)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtOP)
        Me.Controls.Add(Me.txtOP2)
        Me.Controls.Add(Me.txtOP1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.bttnClear)
        Me.Controls.Add(Me.bttnEqual)
        Me.Controls.Add(Me.bttnDivid)
        Me.Controls.Add(Me.bttnMulti)
        Me.Controls.Add(Me.bttnMinus)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnMinus As Button
    Friend WithEvents bttnMulti As Button
    Friend WithEvents bttnDivid As Button
    Friend WithEvents bttnEqual As Button
    Friend WithEvents bttnClear As Button
    Friend WithEvents bttnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOP1 As TextBox
    Friend WithEvents txtOP2 As TextBox
    Friend WithEvents txtOP As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents TimerDate As Timer
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
