<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sorter
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
        Me.ascendingBtn = New System.Windows.Forms.Button()
        Me.namesLstBox = New System.Windows.Forms.ListBox()
        Me.sortedLstBox = New System.Windows.Forms.ListBox()
        Me.descendingBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.readNamesBtn = New System.Windows.Forms.Button()
        Me.rawLbl = New System.Windows.Forms.Label()
        Me.sortedLbl = New System.Windows.Forms.Label()
        Me.contentAmountLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ascendingBtn
        '
        Me.ascendingBtn.Location = New System.Drawing.Point(275, 166)
        Me.ascendingBtn.Name = "ascendingBtn"
        Me.ascendingBtn.Size = New System.Drawing.Size(101, 23)
        Me.ascendingBtn.TabIndex = 0
        Me.ascendingBtn.Text = "&Ascending Order"
        Me.ascendingBtn.UseVisualStyleBackColor = True
        '
        'namesLstBox
        '
        Me.namesLstBox.FormattingEnabled = True
        Me.namesLstBox.Location = New System.Drawing.Point(12, 53)
        Me.namesLstBox.Name = "namesLstBox"
        Me.namesLstBox.Size = New System.Drawing.Size(257, 498)
        Me.namesLstBox.TabIndex = 1
        '
        'sortedLstBox
        '
        Me.sortedLstBox.FormattingEnabled = True
        Me.sortedLstBox.Location = New System.Drawing.Point(382, 53)
        Me.sortedLstBox.Name = "sortedLstBox"
        Me.sortedLstBox.Size = New System.Drawing.Size(257, 498)
        Me.sortedLstBox.TabIndex = 2
        '
        'descendingBtn
        '
        Me.descendingBtn.Location = New System.Drawing.Point(275, 359)
        Me.descendingBtn.Name = "descendingBtn"
        Me.descendingBtn.Size = New System.Drawing.Size(101, 23)
        Me.descendingBtn.TabIndex = 3
        Me.descendingBtn.Text = "&Descending Order"
        Me.descendingBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(538, 585)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(101, 23)
        Me.exitBtn.TabIndex = 4
        Me.exitBtn.Text = "E&xit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'readNamesBtn
        '
        Me.readNamesBtn.Location = New System.Drawing.Point(63, 557)
        Me.readNamesBtn.Name = "readNamesBtn"
        Me.readNamesBtn.Size = New System.Drawing.Size(149, 23)
        Me.readNamesBtn.TabIndex = 5
        Me.readNamesBtn.Text = "&Read in names.txt"
        Me.readNamesBtn.UseVisualStyleBackColor = True
        '
        'rawLbl
        '
        Me.rawLbl.AutoSize = True
        Me.rawLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rawLbl.Location = New System.Drawing.Point(77, 30)
        Me.rawLbl.Name = "rawLbl"
        Me.rawLbl.Size = New System.Drawing.Size(113, 20)
        Me.rawLbl.TabIndex = 6
        Me.rawLbl.Text = "Raw Content"
        '
        'sortedLbl
        '
        Me.sortedLbl.AutoSize = True
        Me.sortedLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortedLbl.Location = New System.Drawing.Point(445, 30)
        Me.sortedLbl.Name = "sortedLbl"
        Me.sortedLbl.Size = New System.Drawing.Size(132, 20)
        Me.sortedLbl.TabIndex = 7
        Me.sortedLbl.Text = "Sorted Content"
        '
        'contentAmountLbl
        '
        Me.contentAmountLbl.AutoSize = True
        Me.contentAmountLbl.Location = New System.Drawing.Point(9, 595)
        Me.contentAmountLbl.Name = "contentAmountLbl"
        Me.contentAmountLbl.Size = New System.Drawing.Size(95, 13)
        Me.contentAmountLbl.TabIndex = 8
        Me.contentAmountLbl.Text = "Content Amount: 0"
        '
        'Sorter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 620)
        Me.Controls.Add(Me.contentAmountLbl)
        Me.Controls.Add(Me.sortedLbl)
        Me.Controls.Add(Me.rawLbl)
        Me.Controls.Add(Me.readNamesBtn)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.descendingBtn)
        Me.Controls.Add(Me.sortedLstBox)
        Me.Controls.Add(Me.namesLstBox)
        Me.Controls.Add(Me.ascendingBtn)
        Me.Name = "Sorter"
        Me.Text = "File Sorter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ascendingBtn As Button
    Friend WithEvents namesLstBox As ListBox
    Friend WithEvents sortedLstBox As ListBox
    Friend WithEvents descendingBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents readNamesBtn As Button
    Friend WithEvents rawLbl As Label
    Friend WithEvents sortedLbl As Label
    Friend WithEvents contentAmountLbl As Label
End Class
