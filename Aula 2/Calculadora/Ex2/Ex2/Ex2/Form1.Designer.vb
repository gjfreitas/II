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
        Me.bttnAdd = New System.Windows.Forms.Button()
        Me.bttnMulti = New System.Windows.Forms.Button()
        Me.bttnMinus = New System.Windows.Forms.Button()
        Me.bttnDivid = New System.Windows.Forms.Button()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.bttnSave = New System.Windows.Forms.Button()
        Me.bttnRead = New System.Windows.Forms.Button()
        Me.txtOP1 = New System.Windows.Forms.TextBox()
        Me.txtOP2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bttnAdd
        '
        Me.bttnAdd.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttnAdd.Location = New System.Drawing.Point(46, 200)
        Me.bttnAdd.Name = "bttnAdd"
        Me.bttnAdd.Size = New System.Drawing.Size(112, 72)
        Me.bttnAdd.TabIndex = 0
        Me.bttnAdd.Text = "+"
        Me.bttnAdd.UseVisualStyleBackColor = True
        '
        'bttnMulti
        '
        Me.bttnMulti.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttnMulti.Location = New System.Drawing.Point(46, 278)
        Me.bttnMulti.Name = "bttnMulti"
        Me.bttnMulti.Size = New System.Drawing.Size(112, 72)
        Me.bttnMulti.TabIndex = 1
        Me.bttnMulti.Text = "x"
        Me.bttnMulti.UseVisualStyleBackColor = True
        '
        'bttnMinus
        '
        Me.bttnMinus.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttnMinus.Location = New System.Drawing.Point(195, 200)
        Me.bttnMinus.Name = "bttnMinus"
        Me.bttnMinus.Size = New System.Drawing.Size(112, 72)
        Me.bttnMinus.TabIndex = 2
        Me.bttnMinus.Text = "-"
        Me.bttnMinus.UseVisualStyleBackColor = True
        '
        'bttnDivid
        '
        Me.bttnDivid.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttnDivid.Location = New System.Drawing.Point(195, 278)
        Me.bttnDivid.Name = "bttnDivid"
        Me.bttnDivid.Size = New System.Drawing.Size(112, 72)
        Me.bttnDivid.TabIndex = 3
        Me.bttnDivid.Text = "/"
        Me.bttnDivid.UseVisualStyleBackColor = True
        '
        'bttnClose
        '
        Me.bttnClose.Location = New System.Drawing.Point(46, 382)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(112, 34)
        Me.bttnClose.TabIndex = 4
        Me.bttnClose.Text = "Sair"
        Me.bttnClose.UseVisualStyleBackColor = True
        '
        'bttnSave
        '
        Me.bttnSave.Location = New System.Drawing.Point(484, 202)
        Me.bttnSave.Name = "bttnSave"
        Me.bttnSave.Size = New System.Drawing.Size(112, 34)
        Me.bttnSave.TabIndex = 5
        Me.bttnSave.Text = "Gravar"
        Me.bttnSave.UseVisualStyleBackColor = True
        '
        'bttnRead
        '
        Me.bttnRead.Location = New System.Drawing.Point(642, 202)
        Me.bttnRead.Name = "bttnRead"
        Me.bttnRead.Size = New System.Drawing.Size(112, 34)
        Me.bttnRead.TabIndex = 6
        Me.bttnRead.Text = "Ler"
        Me.bttnRead.UseVisualStyleBackColor = True
        '
        'txtOP1
        '
        Me.txtOP1.Location = New System.Drawing.Point(26, 131)
        Me.txtOP1.Name = "txtOP1"
        Me.txtOP1.Size = New System.Drawing.Size(150, 31)
        Me.txtOP1.TabIndex = 7
        '
        'txtOP2
        '
        Me.txtOP2.Location = New System.Drawing.Point(195, 131)
        Me.txtOP2.Name = "txtOP2"
        Me.txtOP2.Size = New System.Drawing.Size(150, 31)
        Me.txtOP2.TabIndex = 8
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(372, 131)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(150, 31)
        Me.txtResult.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Operador 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Operador 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Resultado"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(484, 258)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(270, 148)
        Me.txtFile.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtOP2)
        Me.Controls.Add(Me.txtOP1)
        Me.Controls.Add(Me.bttnRead)
        Me.Controls.Add(Me.bttnSave)
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.bttnDivid)
        Me.Controls.Add(Me.bttnMinus)
        Me.Controls.Add(Me.bttnMulti)
        Me.Controls.Add(Me.bttnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnAdd As Button
    Friend WithEvents bttnMulti As Button
    Friend WithEvents bttnMinus As Button
    Friend WithEvents bttnDivid As Button
    Friend WithEvents bttnClose As Button
    Friend WithEvents bttnSave As Button
    Friend WithEvents bttnRead As Button
    Friend WithEvents txtOP1 As TextBox
    Friend WithEvents txtOP2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFile As TextBox
End Class
