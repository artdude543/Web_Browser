<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.pnlBrowser = New System.Windows.Forms.Panel()
        Me.wbrMain = New System.Windows.Forms.WebBrowser()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.cmdGo = New System.Windows.Forms.Button()
        Me.cmbFavourites = New System.Windows.Forms.ComboBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdHome = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.pgbDone = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBrowser.SuspendLayout()
        Me.msMain.SuspendLayout()
        Me.ssMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBrowser
        '
        Me.pnlBrowser.Controls.Add(Me.wbrMain)
        Me.pnlBrowser.Location = New System.Drawing.Point(12, 66)
        Me.pnlBrowser.Name = "pnlBrowser"
        Me.pnlBrowser.Size = New System.Drawing.Size(954, 528)
        Me.pnlBrowser.TabIndex = 0
        '
        'wbrMain
        '
        Me.wbrMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbrMain.Location = New System.Drawing.Point(0, 0)
        Me.wbrMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbrMain.Name = "wbrMain"
        Me.wbrMain.Size = New System.Drawing.Size(954, 528)
        Me.wbrMain.TabIndex = 0
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(174, 30)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(462, 20)
        Me.txtURL.TabIndex = 1
        '
        'cmdGo
        '
        Me.cmdGo.Location = New System.Drawing.Point(642, 30)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(75, 21)
        Me.cmdGo.TabIndex = 2
        Me.cmdGo.Text = "Go"
        Me.cmdGo.UseVisualStyleBackColor = True
        '
        'cmbFavourites
        '
        Me.cmbFavourites.FormattingEnabled = True
        Me.cmbFavourites.Location = New System.Drawing.Point(723, 30)
        Me.cmbFavourites.Name = "cmbFavourites"
        Me.cmbFavourites.Size = New System.Drawing.Size(162, 21)
        Me.cmbFavourites.TabIndex = 3
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(891, 30)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 21)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdHome
        '
        Me.cmdHome.Location = New System.Drawing.Point(12, 30)
        Me.cmdHome.Name = "cmdHome"
        Me.cmdHome.Size = New System.Drawing.Size(75, 21)
        Me.cmdHome.TabIndex = 5
        Me.cmdHome.Text = "Home"
        Me.cmdHome.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(93, 30)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 21)
        Me.cmdBack.TabIndex = 6
        Me.cmdBack.Text = "Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HistoryToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(978, 24)
        Me.msMain.TabIndex = 7
        Me.msMain.Text = "MenuStrip1"
        '
        'ssMain
        '
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pgbDone, Me.lblStatus})
        Me.ssMain.Location = New System.Drawing.Point(0, 614)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(978, 22)
        Me.ssMain.TabIndex = 8
        Me.ssMain.Text = "StatusStrip1"
        '
        'pgbDone
        '
        Me.pgbDone.Name = "pgbDone"
        Me.pgbDone.Size = New System.Drawing.Size(100, 16)
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(35, 17)
        Me.lblStatus.Text = "Done"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 636)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdHome)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmbFavourites)
        Me.Controls.Add(Me.cmdGo)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.pnlBrowser)
        Me.Controls.Add(Me.msMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.msMain
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Untitled | DiamentiumUK Browser"
        Me.pnlBrowser.ResumeLayout(False)
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBrowser As System.Windows.Forms.Panel
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents wbrMain As System.Windows.Forms.WebBrowser
    Friend WithEvents cmbFavourites As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdHome As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents ssMain As System.Windows.Forms.StatusStrip
    Friend WithEvents pgbDone As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
