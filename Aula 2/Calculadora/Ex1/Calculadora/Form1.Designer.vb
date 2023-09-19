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
        Me.txtOP1 = New System.Windows.Forms.TextBox()
        Me.txtOP2 = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnMinus = New System.Windows.Forms.Button()
        Me.bttnMulti = New System.Windows.Forms.Button()
        Me.bttnDivid = New System.Windows.Forms.Button()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOP1
        '
        Me.txtOP1.Location = New System.Drawing.Point(93, 49)
        Me.txtOP1.Name = "txtOP1"
        Me.txtOP1.Size = New System.Drawing.Size(150, 31)
        Me.txtOP1.TabIndex = 0
        '
        'txtOP2
        '
        Me.txtOP2.Location = New System.Drawing.Point(322, 49)
        Me.txtOP2.Name = "txtOP2"
        Me.txtOP2.Size = New System.Drawing.Size(150, 31)
        Me.txtOP2.TabIndex = 1
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(537, 49)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(150, 31)
        Me.Result.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Operador 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Operador 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(537, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado"
        '
        'bttnAdd
        '
        Me.bttnAdd.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttnAdd.Location = New System.Drawing.Point(93, 153)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(112, 83)
        Me.bttnAdd.TabIndex = 6
        Me.bttnAdd.Text = "+"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnMinus
        '
        Me.bttnMinus.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttnMinus.Location = New System.Drawing.Point(222, 153)
        Me.bttnMinus.Name = "bttnMinus"
        Me.bttnMinus.Size = New System.Drawing.Size(112, 83)
        Me.bttnMinus.TabIndex = 7
        Me.bttnMinus.Text = "-"
        Me.bttnMinus.UseVisualStyleBackColor = True
        '
        'bttnMulti
        '
        Me.bttnMulti.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttnMulti.Location = New System.Drawing.Point(93, 242)
        Me.bttnMulti.Name = "bttnMulti"
        Me.bttnMulti.Size = New System.Drawing.Size(112, 83)
        Me.bttnMulti.TabIndex = 8
        Me.bttnMulti.Text = "x"
        Me.bttnMulti.UseVisualStyleBackColor = True
        '
        'bttnDivid
        '
        Me.bttnDivid.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttnDivid.Location = New System.Drawing.Point(222, 242)
        Me.bttnDivid.Name = "bttnDivid"
        Me.bttnDivid.Size = New System.Drawing.Size(112, 83)
        Me.bttnDivid.TabIndex = 9
        Me.bttnDivid.Text = "/"
        Me.bttnDivid.UseVisualStyleBackColor = True
        '
        'bttnClose
        '
        Me.bttnClose.Location = New System.Drawing.Point(537, 202)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(150, 73)
        Me.bttnClose.TabIndex = 10
        Me.bttnClose.Text = "Sair"
        Me.bttnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.bttnDivid)
        Me.Controls.Add(Me.bttnMulti)
        Me.Controls.Add(Me.bttnMinus)
        Me.Controls.Add(Me.bttnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.txtOP2)
        Me.Controls.Add(Me.txtOP1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOP1 As TextBox
    Friend WithEvents txtOP2 As TextBox
    Friend WithEvents Result As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnMinus As Button
    Friend WithEvents bttnMulti As Button
    Friend WithEvents bttnDivid As Button
    Friend WithEvents bttnClose As Button
End Class
