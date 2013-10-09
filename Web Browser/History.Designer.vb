<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdDeleteAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstHistory
        '
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.Location = New System.Drawing.Point(12, 12)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(356, 160)
        Me.lstHistory.TabIndex = 0
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(12, 178)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(94, 23)
        Me.cmdDelete.TabIndex = 1
        Me.cmdDelete.Text = "Delete Selected"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdDeleteAll
        '
        Me.cmdDeleteAll.Location = New System.Drawing.Point(293, 178)
        Me.cmdDeleteAll.Name = "cmdDeleteAll"
        Me.cmdDeleteAll.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleteAll.TabIndex = 2
        Me.cmdDeleteAll.Text = "Delete All"
        Me.cmdDeleteAll.UseVisualStyleBackColor = True
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 219)
        Me.Controls.Add(Me.cmdDeleteAll)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.lstHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "History"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstHistory As System.Windows.Forms.ListBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteAll As System.Windows.Forms.Button
End Class
