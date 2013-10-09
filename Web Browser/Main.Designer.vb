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
        Me.pnlBrowser.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBrowser
        '
        Me.pnlBrowser.Controls.Add(Me.wbrMain)
        Me.pnlBrowser.Location = New System.Drawing.Point(12, 104)
        Me.pnlBrowser.Name = "pnlBrowser"
        Me.pnlBrowser.Size = New System.Drawing.Size(907, 510)
        Me.pnlBrowser.TabIndex = 0
        '
        'wbrMain
        '
        Me.wbrMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbrMain.Location = New System.Drawing.Point(0, 0)
        Me.wbrMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbrMain.Name = "wbrMain"
        Me.wbrMain.Size = New System.Drawing.Size(907, 510)
        Me.wbrMain.TabIndex = 0
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(174, 77)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(415, 20)
        Me.txtURL.TabIndex = 1
        '
        'cmdGo
        '
        Me.cmdGo.Location = New System.Drawing.Point(595, 78)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(75, 20)
        Me.cmdGo.TabIndex = 2
        Me.cmdGo.Text = "Go"
        Me.cmdGo.UseVisualStyleBackColor = True
        '
        'cmbFavourites
        '
        Me.cmbFavourites.FormattingEnabled = True
        Me.cmbFavourites.Location = New System.Drawing.Point(676, 77)
        Me.cmbFavourites.Name = "cmbFavourites"
        Me.cmbFavourites.Size = New System.Drawing.Size(162, 21)
        Me.cmbFavourites.TabIndex = 3
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(844, 77)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 20)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdHome
        '
        Me.cmdHome.Location = New System.Drawing.Point(12, 76)
        Me.cmdHome.Name = "cmdHome"
        Me.cmdHome.Size = New System.Drawing.Size(75, 20)
        Me.cmdHome.TabIndex = 5
        Me.cmdHome.Text = "Home"
        Me.cmdHome.UseVisualStyleBackColor = True
        '
        'cmdBack
        '
        Me.cmdBack.Location = New System.Drawing.Point(93, 77)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(75, 20)
        Me.cmdBack.TabIndex = 6
        Me.cmdBack.Text = "Back"
        Me.cmdBack.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 626)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdHome)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmbFavourites)
        Me.Controls.Add(Me.cmdGo)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.pnlBrowser)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlBrowser.ResumeLayout(False)
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

End Class
