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
        Me.IP_tb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Config_btn = New System.Windows.Forms.Button()
        Me.Start_btn = New System.Windows.Forms.Button()
        Me.Stop_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ns_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.s_tb = New System.Windows.Forms.TextBox()
        Me.Read_btn = New System.Windows.Forms.Button()
        Me.read_tb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Write_btn = New System.Windows.Forms.Button()
        Me.write_tb = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'IP_tb
        '
        Me.IP_tb.Location = New System.Drawing.Point(79, 41)
        Me.IP_tb.Name = "IP_tb"
        Me.IP_tb.Size = New System.Drawing.Size(245, 26)
        Me.IP_tb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP"
        '
        'Config_btn
        '
        Me.Config_btn.Location = New System.Drawing.Point(97, 89)
        Me.Config_btn.Name = "Config_btn"
        Me.Config_btn.Size = New System.Drawing.Size(197, 30)
        Me.Config_btn.TabIndex = 2
        Me.Config_btn.Text = "Update_configuration"
        Me.Config_btn.UseVisualStyleBackColor = True
        '
        'Start_btn
        '
        Me.Start_btn.Location = New System.Drawing.Point(97, 141)
        Me.Start_btn.Name = "Start_btn"
        Me.Start_btn.Size = New System.Drawing.Size(197, 30)
        Me.Start_btn.TabIndex = 3
        Me.Start_btn.Text = "Start_configuration"
        Me.Start_btn.UseVisualStyleBackColor = True
        '
        'Stop_btn
        '
        Me.Stop_btn.Location = New System.Drawing.Point(97, 199)
        Me.Stop_btn.Name = "Stop_btn"
        Me.Stop_btn.Size = New System.Drawing.Size(197, 30)
        Me.Stop_btn.TabIndex = 4
        Me.Stop_btn.Text = "Stop_configuration"
        Me.Stop_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ns"
        '
        'ns_tb
        '
        Me.ns_tb.Location = New System.Drawing.Point(92, 269)
        Me.ns_tb.Name = "ns_tb"
        Me.ns_tb.Size = New System.Drawing.Size(245, 26)
        Me.ns_tb.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "s"
        '
        's_tb
        '
        Me.s_tb.Location = New System.Drawing.Point(92, 318)
        Me.s_tb.Name = "s_tb"
        Me.s_tb.Size = New System.Drawing.Size(245, 26)
        Me.s_tb.TabIndex = 7
        '
        'Read_btn
        '
        Me.Read_btn.Location = New System.Drawing.Point(132, 373)
        Me.Read_btn.Name = "Read_btn"
        Me.Read_btn.Size = New System.Drawing.Size(114, 30)
        Me.Read_btn.TabIndex = 9
        Me.Read_btn.Text = "Read"
        Me.Read_btn.UseVisualStyleBackColor = True
        '
        'read_tb
        '
        Me.read_tb.Location = New System.Drawing.Point(69, 409)
        Me.read_tb.Multiline = True
        Me.read_tb.Name = "read_tb"
        Me.read_tb.Size = New System.Drawing.Size(245, 111)
        Me.read_tb.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Read_info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 553)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Write_info"
        '
        'Write_btn
        '
        Me.Write_btn.Location = New System.Drawing.Point(132, 548)
        Me.Write_btn.Name = "Write_btn"
        Me.Write_btn.Size = New System.Drawing.Size(114, 30)
        Me.Write_btn.TabIndex = 12
        Me.Write_btn.Text = "Write"
        Me.Write_btn.UseVisualStyleBackColor = True
        '
        'write_tb
        '
        Me.write_tb.Location = New System.Drawing.Point(92, 596)
        Me.write_tb.Name = "write_tb"
        Me.write_tb.Size = New System.Drawing.Size(245, 26)
        Me.write_tb.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 648)
        Me.Controls.Add(Me.write_tb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Write_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.read_tb)
        Me.Controls.Add(Me.Read_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.s_tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ns_tb)
        Me.Controls.Add(Me.Stop_btn)
        Me.Controls.Add(Me.Start_btn)
        Me.Controls.Add(Me.Config_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IP_tb)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IP_tb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Config_btn As Button
    Friend WithEvents Start_btn As Button
    Friend WithEvents Stop_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ns_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents s_tb As TextBox
    Friend WithEvents Read_btn As Button
    Friend WithEvents read_tb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Write_btn As Button
    Friend WithEvents write_tb As TextBox
End Class
