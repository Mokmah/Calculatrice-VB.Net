<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculatrice
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.zeroButton = New System.Windows.Forms.Button()
        Me.plusButton = New System.Windows.Forms.Button()
        Me.threeButton = New System.Windows.Forms.Button()
        Me.twoButton = New System.Windows.Forms.Button()
        Me.oneButton = New System.Windows.Forms.Button()
        Me.minusButton = New System.Windows.Forms.Button()
        Me.sixButton = New System.Windows.Forms.Button()
        Me.fiveButton = New System.Windows.Forms.Button()
        Me.fourButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.nineButton = New System.Windows.Forms.Button()
        Me.eightButton = New System.Windows.Forms.Button()
        Me.divideButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.clearEntryButton = New System.Windows.Forms.Button()
        Me.backspaceButton = New System.Windows.Forms.Button()
        Me.calculationTextBox = New System.Windows.Forms.TextBox()
        Me.equalButton = New System.Windows.Forms.Button()
        Me.sevenButton = New System.Windows.Forms.Button()
        Me.historyTextBox = New System.Windows.Forms.TextBox()
        Me.saveHistoryButton = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'zeroButton
        '
        Me.zeroButton.Location = New System.Drawing.Point(17, 363)
        Me.zeroButton.Name = "zeroButton"
        Me.zeroButton.Size = New System.Drawing.Size(124, 55)
        Me.zeroButton.TabIndex = 39
        Me.zeroButton.Text = "0"
        Me.zeroButton.UseVisualStyleBackColor = true
        '
        'plusButton
        '
        Me.plusButton.Location = New System.Drawing.Point(212, 302)
        Me.plusButton.Name = "plusButton"
        Me.plusButton.Size = New System.Drawing.Size(59, 55)
        Me.plusButton.TabIndex = 38
        Me.plusButton.Text = "+"
        Me.plusButton.UseVisualStyleBackColor = true
        '
        'threeButton
        '
        Me.threeButton.Location = New System.Drawing.Point(147, 302)
        Me.threeButton.Name = "threeButton"
        Me.threeButton.Size = New System.Drawing.Size(59, 55)
        Me.threeButton.TabIndex = 37
        Me.threeButton.Text = "3"
        Me.threeButton.UseVisualStyleBackColor = true
        '
        'twoButton
        '
        Me.twoButton.Location = New System.Drawing.Point(82, 302)
        Me.twoButton.Name = "twoButton"
        Me.twoButton.Size = New System.Drawing.Size(59, 55)
        Me.twoButton.TabIndex = 36
        Me.twoButton.Text = "2"
        Me.twoButton.UseVisualStyleBackColor = true
        '
        'oneButton
        '
        Me.oneButton.Location = New System.Drawing.Point(17, 302)
        Me.oneButton.Name = "oneButton"
        Me.oneButton.Size = New System.Drawing.Size(59, 55)
        Me.oneButton.TabIndex = 35
        Me.oneButton.Text = "1"
        Me.oneButton.UseVisualStyleBackColor = true
        '
        'minusButton
        '
        Me.minusButton.Location = New System.Drawing.Point(212, 241)
        Me.minusButton.Name = "minusButton"
        Me.minusButton.Size = New System.Drawing.Size(59, 55)
        Me.minusButton.TabIndex = 34
        Me.minusButton.Text = "-"
        Me.minusButton.UseVisualStyleBackColor = true
        '
        'sixButton
        '
        Me.sixButton.Location = New System.Drawing.Point(147, 241)
        Me.sixButton.Name = "sixButton"
        Me.sixButton.Size = New System.Drawing.Size(59, 55)
        Me.sixButton.TabIndex = 33
        Me.sixButton.Text = "6"
        Me.sixButton.UseVisualStyleBackColor = true
        '
        'fiveButton
        '
        Me.fiveButton.Location = New System.Drawing.Point(82, 241)
        Me.fiveButton.Name = "fiveButton"
        Me.fiveButton.Size = New System.Drawing.Size(59, 55)
        Me.fiveButton.TabIndex = 32
        Me.fiveButton.Text = "5"
        Me.fiveButton.UseVisualStyleBackColor = true
        '
        'fourButton
        '
        Me.fourButton.Location = New System.Drawing.Point(17, 241)
        Me.fourButton.Name = "fourButton"
        Me.fourButton.Size = New System.Drawing.Size(59, 55)
        Me.fourButton.TabIndex = 31
        Me.fourButton.Text = "4"
        Me.fourButton.UseVisualStyleBackColor = true
        '
        'multiplyButton
        '
        Me.multiplyButton.Location = New System.Drawing.Point(212, 180)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(59, 55)
        Me.multiplyButton.TabIndex = 30
        Me.multiplyButton.Text = "*"
        Me.multiplyButton.UseVisualStyleBackColor = true
        '
        'nineButton
        '
        Me.nineButton.Location = New System.Drawing.Point(147, 180)
        Me.nineButton.Name = "nineButton"
        Me.nineButton.Size = New System.Drawing.Size(59, 55)
        Me.nineButton.TabIndex = 29
        Me.nineButton.Text = "9"
        Me.nineButton.UseVisualStyleBackColor = true
        '
        'eightButton
        '
        Me.eightButton.Location = New System.Drawing.Point(82, 180)
        Me.eightButton.Name = "eightButton"
        Me.eightButton.Size = New System.Drawing.Size(59, 55)
        Me.eightButton.TabIndex = 28
        Me.eightButton.Text = "8"
        Me.eightButton.UseVisualStyleBackColor = true
        '
        'divideButton
        '
        Me.divideButton.Location = New System.Drawing.Point(212, 119)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(59, 55)
        Me.divideButton.TabIndex = 27
        Me.divideButton.Text = "/"
        Me.divideButton.UseVisualStyleBackColor = true
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(147, 119)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(59, 55)
        Me.clearButton.TabIndex = 26
        Me.clearButton.Text = "C"
        Me.clearButton.UseVisualStyleBackColor = true
        '
        'clearEntryButton
        '
        Me.clearEntryButton.Location = New System.Drawing.Point(82, 119)
        Me.clearEntryButton.Name = "clearEntryButton"
        Me.clearEntryButton.Size = New System.Drawing.Size(59, 55)
        Me.clearEntryButton.TabIndex = 25
        Me.clearEntryButton.Text = "CE"
        Me.clearEntryButton.UseVisualStyleBackColor = true
        '
        'backspaceButton
        '
        Me.backspaceButton.Location = New System.Drawing.Point(17, 119)
        Me.backspaceButton.Name = "backspaceButton"
        Me.backspaceButton.Size = New System.Drawing.Size(59, 55)
        Me.backspaceButton.TabIndex = 23
        Me.backspaceButton.Text = "<-"
        Me.backspaceButton.UseVisualStyleBackColor = true
        '
        'calculationTextBox
        '
        Me.calculationTextBox.Enabled = false
        Me.calculationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.calculationTextBox.Location = New System.Drawing.Point(17, 17)
        Me.calculationTextBox.Multiline = true
        Me.calculationTextBox.Name = "calculationTextBox"
        Me.calculationTextBox.ReadOnly = true
        Me.calculationTextBox.Size = New System.Drawing.Size(254, 96)
        Me.calculationTextBox.TabIndex = 24
        Me.calculationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'equalButton
        '
        Me.equalButton.Location = New System.Drawing.Point(147, 363)
        Me.equalButton.Name = "equalButton"
        Me.equalButton.Size = New System.Drawing.Size(124, 55)
        Me.equalButton.TabIndex = 40
        Me.equalButton.Text = "="
        Me.equalButton.UseVisualStyleBackColor = true
        '
        'sevenButton
        '
        Me.sevenButton.Location = New System.Drawing.Point(17, 180)
        Me.sevenButton.Name = "sevenButton"
        Me.sevenButton.Size = New System.Drawing.Size(59, 55)
        Me.sevenButton.TabIndex = 22
        Me.sevenButton.Text = "7"
        Me.sevenButton.UseVisualStyleBackColor = true
        '
        'historyTextBox
        '
        Me.historyTextBox.Enabled = false
        Me.historyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.historyTextBox.Location = New System.Drawing.Point(277, 17)
        Me.historyTextBox.Multiline = true
        Me.historyTextBox.Name = "historyTextBox"
        Me.historyTextBox.ReadOnly = true
        Me.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.historyTextBox.Size = New System.Drawing.Size(98, 340)
        Me.historyTextBox.TabIndex = 41
        '
        'saveHistoryButton
        '
        Me.saveHistoryButton.Location = New System.Drawing.Point(277, 363)
        Me.saveHistoryButton.Name = "saveHistoryButton"
        Me.saveHistoryButton.Size = New System.Drawing.Size(98, 55)
        Me.saveHistoryButton.TabIndex = 42
        Me.saveHistoryButton.Text = "Dernières sauvegardes"
        Me.saveHistoryButton.UseVisualStyleBackColor = true
        '
        'frmCalculatrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 435)
        Me.Controls.Add(Me.zeroButton)
        Me.Controls.Add(Me.plusButton)
        Me.Controls.Add(Me.threeButton)
        Me.Controls.Add(Me.twoButton)
        Me.Controls.Add(Me.oneButton)
        Me.Controls.Add(Me.minusButton)
        Me.Controls.Add(Me.sixButton)
        Me.Controls.Add(Me.fiveButton)
        Me.Controls.Add(Me.fourButton)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.nineButton)
        Me.Controls.Add(Me.eightButton)
        Me.Controls.Add(Me.divideButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.clearEntryButton)
        Me.Controls.Add(Me.backspaceButton)
        Me.Controls.Add(Me.calculationTextBox)
        Me.Controls.Add(Me.equalButton)
        Me.Controls.Add(Me.sevenButton)
        Me.Controls.Add(Me.historyTextBox)
        Me.Controls.Add(Me.saveHistoryButton)
        Me.Name = "frmCalculatrice"
        Me.Text = "Calculatrice"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents zeroButton As Button
    Friend WithEvents plusButton As Button
    Friend WithEvents threeButton As Button
    Friend WithEvents twoButton As Button
    Friend WithEvents oneButton As Button
    Friend WithEvents minusButton As Button
    Friend WithEvents sixButton As Button
    Friend WithEvents fiveButton As Button
    Friend WithEvents fourButton As Button
    Friend WithEvents multiplyButton As Button
    Friend WithEvents nineButton As Button
    Friend WithEvents eightButton As Button
    Friend WithEvents divideButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents clearEntryButton As Button
    Friend WithEvents backspaceButton As Button
    Friend WithEvents calculationTextBox As TextBox
    Friend WithEvents equalButton As Button
    Friend WithEvents sevenButton As Button
    Friend WithEvents historyTextBox As TextBox
    Friend WithEvents saveHistoryButton As Button
End Class
