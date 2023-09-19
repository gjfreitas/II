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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerReceived = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BttnOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BttnY0 = New System.Windows.Forms.Button()
        Me.BttnY1 = New System.Windows.Forms.Button()
        Me.BttnY2 = New System.Windows.Forms.Button()
        Me.CheckBoxY0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxY2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxX3 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxLevel = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 586)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1035, 32)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(201, 25)
        Me.ToolStripStatusLabel1.Text = "Configuração Desligada"
        '
        'TimerReceived
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraçãoToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1035, 33)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguraçãoToolStripMenuItem
        '
        Me.ConfiguraçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurarToolStripMenuItem, Me.BttnOpen})
        Me.ConfiguraçãoToolStripMenuItem.Name = "ConfiguraçãoToolStripMenuItem"
        Me.ConfiguraçãoToolStripMenuItem.Size = New System.Drawing.Size(134, 29)
        Me.ConfiguraçãoToolStripMenuItem.Text = "Configuração"
        '
        'ConfigurarToolStripMenuItem
        '
        Me.ConfigurarToolStripMenuItem.Name = "ConfigurarToolStripMenuItem"
        Me.ConfigurarToolStripMenuItem.Size = New System.Drawing.Size(198, 34)
        Me.ConfigurarToolStripMenuItem.Text = "Configurar"
        '
        'BttnOpen
        '
        Me.BttnOpen.Name = "BttnOpen"
        Me.BttnOpen.Size = New System.Drawing.Size(198, 34)
        Me.BttnOpen.Text = "Ligar"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(55, 29)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebugToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'BttnY0
        '
        Me.BttnY0.Location = New System.Drawing.Point(71, 508)
        Me.BttnY0.Name = "BttnY0"
        Me.BttnY0.Size = New System.Drawing.Size(108, 33)
        Me.BttnY0.TabIndex = 3
        Me.BttnY0.Text = "Ativar Y0"
        Me.BttnY0.UseVisualStyleBackColor = True
        '
        'BttnY1
        '
        Me.BttnY1.Location = New System.Drawing.Point(285, 401)
        Me.BttnY1.Name = "BttnY1"
        Me.BttnY1.Size = New System.Drawing.Size(108, 33)
        Me.BttnY1.TabIndex = 4
        Me.BttnY1.Text = "Ativar Y1"
        Me.BttnY1.UseVisualStyleBackColor = True
        '
        'BttnY2
        '
        Me.BttnY2.Location = New System.Drawing.Point(802, 522)
        Me.BttnY2.Name = "BttnY2"
        Me.BttnY2.Size = New System.Drawing.Size(108, 33)
        Me.BttnY2.TabIndex = 5
        Me.BttnY2.Text = "Ativar Y2"
        Me.BttnY2.UseVisualStyleBackColor = True
        '
        'CheckBoxY0
        '
        Me.CheckBoxY0.AutoSize = True
        Me.CheckBoxY0.Location = New System.Drawing.Point(71, 206)
        Me.CheckBoxY0.Name = "CheckBoxY0"
        Me.CheckBoxY0.Size = New System.Drawing.Size(110, 24)
        Me.CheckBoxY0.TabIndex = 6
        Me.CheckBoxY0.Text = "Y0 (Pump)"
        Me.CheckBoxY0.UseVisualStyleBackColor = True
        '
        'CheckBoxY1
        '
        Me.CheckBoxY1.AutoSize = True
        Me.CheckBoxY1.Location = New System.Drawing.Point(297, 177)
        Me.CheckBoxY1.Name = "CheckBoxY1"
        Me.CheckBoxY1.Size = New System.Drawing.Size(83, 24)
        Me.CheckBoxY1.TabIndex = 7
        Me.CheckBoxY1.Text = "Y1 (In)"
        Me.CheckBoxY1.UseVisualStyleBackColor = True
        '
        'CheckBoxY2
        '
        Me.CheckBoxY2.AutoSize = True
        Me.CheckBoxY2.Location = New System.Drawing.Point(802, 305)
        Me.CheckBoxY2.Name = "CheckBoxY2"
        Me.CheckBoxY2.Size = New System.Drawing.Size(95, 24)
        Me.CheckBoxY2.TabIndex = 8
        Me.CheckBoxY2.Text = "Y2 (Out)"
        Me.CheckBoxY2.UseVisualStyleBackColor = True
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.AutoSize = True
        Me.CheckBoxX1.Location = New System.Drawing.Point(657, 356)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(109, 24)
        Me.CheckBoxX1.TabIndex = 9
        Me.CheckBoxX1.Text = "X1 (Empy)"
        Me.CheckBoxX1.UseVisualStyleBackColor = True
        '
        'CheckBoxX0
        '
        Me.CheckBoxX0.AutoSize = True
        Me.CheckBoxX0.Location = New System.Drawing.Point(657, 430)
        Me.CheckBoxX0.Name = "CheckBoxX0"
        Me.CheckBoxX0.Size = New System.Drawing.Size(148, 24)
        Me.CheckBoxX0.TabIndex = 10
        Me.CheckBoxX0.Text = "X0 (Alarme min)"
        Me.CheckBoxX0.UseVisualStyleBackColor = True
        '
        'CheckBoxX2
        '
        Me.CheckBoxX2.AutoSize = True
        Me.CheckBoxX2.Location = New System.Drawing.Point(657, 221)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(94, 24)
        Me.CheckBoxX2.TabIndex = 11
        Me.CheckBoxX2.Text = "X2 (Full)"
        Me.CheckBoxX2.UseVisualStyleBackColor = True
        '
        'CheckBoxX3
        '
        Me.CheckBoxX3.AutoSize = True
        Me.CheckBoxX3.Location = New System.Drawing.Point(657, 177)
        Me.CheckBoxX3.Name = "CheckBoxX3"
        Me.CheckBoxX3.Size = New System.Drawing.Size(152, 24)
        Me.CheckBoxX3.TabIndex = 12
        Me.CheckBoxX3.Text = "X3 (Alarme max)"
        Me.CheckBoxX3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.TP5.My.Resources.Resources.Reservatorio_sem_labels_transparente
        Me.PictureBox1.Location = New System.Drawing.Point(51, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(918, 491)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(481, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Water Level"
        '
        'TextBoxLevel
        '
        Me.TextBoxLevel.Enabled = False
        Me.TextBoxLevel.Location = New System.Drawing.Point(485, 105)
        Me.TextBoxLevel.Name = "TextBoxLevel"
        Me.TextBoxLevel.ReadOnly = True
        Me.TextBoxLevel.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxLevel.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 618)
        Me.Controls.Add(Me.TextBoxLevel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBoxX3)
        Me.Controls.Add(Me.CheckBoxX2)
        Me.Controls.Add(Me.CheckBoxX0)
        Me.Controls.Add(Me.CheckBoxX1)
        Me.Controls.Add(Me.CheckBoxY2)
        Me.Controls.Add(Me.CheckBoxY1)
        Me.Controls.Add(Me.CheckBoxY0)
        Me.Controls.Add(Me.BttnY2)
        Me.Controls.Add(Me.BttnY1)
        Me.Controls.Add(Me.BttnY0)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TimerReceived As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConfiguraçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BttnOpen As ToolStripMenuItem
    Friend WithEvents BttnY0 As Button
    Friend WithEvents BttnY1 As Button
    Friend WithEvents BttnY2 As Button
    Friend WithEvents CheckBoxY0 As CheckBox
    Friend WithEvents CheckBoxY1 As CheckBox
    Friend WithEvents CheckBoxY2 As CheckBox
    Friend WithEvents CheckBoxX1 As CheckBox
    Friend WithEvents CheckBoxX0 As CheckBox
    Friend WithEvents CheckBoxX2 As CheckBox
    Friend WithEvents CheckBoxX3 As CheckBox
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxLevel As TextBox
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As ToolStripMenuItem
End Class
