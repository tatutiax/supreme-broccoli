<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPri
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.But1 = New System.Windows.Forms.Button()
        Me.But2 = New System.Windows.Forms.Button()
        Me.GPB1 = New System.Windows.Forms.GroupBox()
        Me.Rdb7 = New System.Windows.Forms.RadioButton()
        Me.Rdb6 = New System.Windows.Forms.RadioButton()
        Me.Rdb5 = New System.Windows.Forms.RadioButton()
        Me.Rdb4 = New System.Windows.Forms.RadioButton()
        Me.Rdb3 = New System.Windows.Forms.RadioButton()
        Me.Rdb2 = New System.Windows.Forms.RadioButton()
        Me.Rdb1 = New System.Windows.Forms.RadioButton()
        Me.GPB1.SuspendLayout()
        Me.SuspendLayout()
        '
        'But1
        '
        Me.But1.Location = New System.Drawing.Point(12, 243)
        Me.But1.Name = "But1"
        Me.But1.Size = New System.Drawing.Size(268, 23)
        Me.But1.TabIndex = 0
        Me.But1.Text = "Informações sobre o progama"
        Me.But1.UseVisualStyleBackColor = True
        '
        'But2
        '
        Me.But2.Location = New System.Drawing.Point(12, 214)
        Me.But2.Name = "But2"
        Me.But2.Size = New System.Drawing.Size(268, 23)
        Me.But2.TabIndex = 4
        Me.But2.Text = "Informações sobre a doença"
        Me.But2.UseVisualStyleBackColor = True
        '
        'GPB1
        '
        Me.GPB1.Controls.Add(Me.Rdb7)
        Me.GPB1.Controls.Add(Me.Rdb6)
        Me.GPB1.Controls.Add(Me.Rdb5)
        Me.GPB1.Controls.Add(Me.Rdb4)
        Me.GPB1.Controls.Add(Me.Rdb3)
        Me.GPB1.Controls.Add(Me.Rdb2)
        Me.GPB1.Controls.Add(Me.Rdb1)
        Me.GPB1.Location = New System.Drawing.Point(12, 12)
        Me.GPB1.Name = "GPB1"
        Me.GPB1.Size = New System.Drawing.Size(268, 196)
        Me.GPB1.TabIndex = 5
        Me.GPB1.TabStop = False
        Me.GPB1.Text = "Doenças"
        '
        'Rdb7
        '
        Me.Rdb7.AutoSize = True
        Me.Rdb7.Location = New System.Drawing.Point(6, 172)
        Me.Rdb7.Name = "Rdb7"
        Me.Rdb7.Size = New System.Drawing.Size(65, 19)
        Me.Rdb7.TabIndex = 6
        Me.Rdb7.TabStop = True
        Me.Rdb7.Text = "Câncer "
        Me.Rdb7.UseVisualStyleBackColor = True
        '
        'Rdb6
        '
        Me.Rdb6.AutoSize = True
        Me.Rdb6.Location = New System.Drawing.Point(6, 147)
        Me.Rdb6.Name = "Rdb6"
        Me.Rdb6.Size = New System.Drawing.Size(58, 19)
        Me.Rdb6.TabIndex = 5
        Me.Rdb6.TabStop = True
        Me.Rdb6.Text = "Asma "
        Me.Rdb6.UseVisualStyleBackColor = True
        '
        'Rdb5
        '
        Me.Rdb5.AutoSize = True
        Me.Rdb5.Location = New System.Drawing.Point(6, 122)
        Me.Rdb5.Name = "Rdb5"
        Me.Rdb5.Size = New System.Drawing.Size(129, 19)
        Me.Rdb5.TabIndex = 4
        Me.Rdb5.TabStop = True
        Me.Rdb5.Text = "hipertensão arterial "
        Me.Rdb5.UseVisualStyleBackColor = True
        '
        'Rdb4
        '
        Me.Rdb4.AutoSize = True
        Me.Rdb4.Location = New System.Drawing.Point(6, 97)
        Me.Rdb4.Name = "Rdb4"
        Me.Rdb4.Size = New System.Drawing.Size(72, 19)
        Me.Rdb4.TabIndex = 3
        Me.Rdb4.TabStop = True
        Me.Rdb4.Text = "diabetes "
        Me.Rdb4.UseVisualStyleBackColor = True
        '
        'Rdb3
        '
        Me.Rdb3.AutoSize = True
        Me.Rdb3.Location = New System.Drawing.Point(6, 72)
        Me.Rdb3.Name = "Rdb3"
        Me.Rdb3.Size = New System.Drawing.Size(120, 19)
        Me.Rdb3.TabIndex = 2
        Me.Rdb3.TabStop = True
        Me.Rdb3.Text = "Esclerose múltipla"
        Me.Rdb3.UseVisualStyleBackColor = True
        '
        'Rdb2
        '
        Me.Rdb2.AutoSize = True
        Me.Rdb2.Location = New System.Drawing.Point(6, 47)
        Me.Rdb2.Name = "Rdb2"
        Me.Rdb2.Size = New System.Drawing.Size(178, 19)
        Me.Rdb2.TabIndex = 1
        Me.Rdb2.TabStop = True
        Me.Rdb2.Text = "Acidente vascular encefálico "
        Me.Rdb2.UseVisualStyleBackColor = False
        '
        'Rdb1
        '
        Me.Rdb1.AutoSize = True
        Me.Rdb1.Location = New System.Drawing.Point(6, 22)
        Me.Rdb1.Name = "Rdb1"
        Me.Rdb1.Size = New System.Drawing.Size(111, 19)
        Me.Rdb1.TabIndex = 0
        Me.Rdb1.TabStop = True
        Me.Rdb1.Text = "Ataque cardíaco"
        Me.Rdb1.UseVisualStyleBackColor = True
        '
        'FrmPri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 272)
        Me.Controls.Add(Me.GPB1)
        Me.Controls.Add(Me.But2)
        Me.Controls.Add(Me.But1)
        Me.Name = "FrmPri"
        Me.Text = "ASSISTENTE MÉDICO"
        Me.GPB1.ResumeLayout(False)
        Me.GPB1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents But1 As Button
    Friend WithEvents But2 As Button
    Friend WithEvents GPB1 As GroupBox
    Friend WithEvents Rdb7 As RadioButton
    Friend WithEvents Rdb6 As RadioButton
    Friend WithEvents Rdb5 As RadioButton
    Friend WithEvents Rdb4 As RadioButton
    Friend WithEvents Rdb3 As RadioButton
    Friend WithEvents Rdb2 As RadioButton
    Friend WithEvents Rdb1 As RadioButton
End Class
