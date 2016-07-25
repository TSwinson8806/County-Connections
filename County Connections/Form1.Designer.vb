<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstCounty = New System.Windows.Forms.ListBox()
        Me.lstApplication = New System.Windows.Forms.ListBox()
        Me.lstServerList = New System.Windows.Forms.ListBox()
        Me.lblServerList = New System.Windows.Forms.Label()
        Me.btnCopyServerSelection = New System.Windows.Forms.Button()
        Me.lblConnectionText = New System.Windows.Forms.Label()
        Me.txtConnectionText = New System.Windows.Forms.TextBox()
        Me.btnShowConnectionText = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExecute
        '
        Me.btnExecute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExecute.Location = New System.Drawing.Point(149, 350)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(121, 47)
        Me.btnExecute.TabIndex = 0
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "County"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Application"
        '
        'lstCounty
        '
        Me.lstCounty.FormattingEnabled = True
        Me.lstCounty.Location = New System.Drawing.Point(16, 25)
        Me.lstCounty.Name = "lstCounty"
        Me.lstCounty.Size = New System.Drawing.Size(77, 82)
        Me.lstCounty.TabIndex = 5
        '
        'lstApplication
        '
        Me.lstApplication.FormattingEnabled = True
        Me.lstApplication.Location = New System.Drawing.Point(111, 25)
        Me.lstApplication.Name = "lstApplication"
        Me.lstApplication.Size = New System.Drawing.Size(140, 82)
        Me.lstApplication.TabIndex = 8
        '
        'lstServerList
        '
        Me.lstServerList.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstServerList.FormattingEnabled = True
        Me.lstServerList.Location = New System.Drawing.Point(12, 165)
        Me.lstServerList.Name = "lstServerList"
        Me.lstServerList.Size = New System.Drawing.Size(258, 82)
        Me.lstServerList.TabIndex = 10
        Me.lstServerList.Visible = False
        '
        'lblServerList
        '
        Me.lblServerList.AutoSize = True
        Me.lblServerList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerList.Location = New System.Drawing.Point(12, 141)
        Me.lblServerList.Name = "lblServerList"
        Me.lblServerList.Size = New System.Drawing.Size(68, 13)
        Me.lblServerList.TabIndex = 11
        Me.lblServerList.Text = "Server List"
        Me.lblServerList.Visible = False
        '
        'btnCopyServerSelection
        '
        Me.btnCopyServerSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyServerSelection.Location = New System.Drawing.Point(86, 137)
        Me.btnCopyServerSelection.Name = "btnCopyServerSelection"
        Me.btnCopyServerSelection.Size = New System.Drawing.Size(76, 22)
        Me.btnCopyServerSelection.TabIndex = 14
        Me.btnCopyServerSelection.Text = "Copy Selection"
        Me.btnCopyServerSelection.UseVisualStyleBackColor = True
        Me.btnCopyServerSelection.Visible = False
        '
        'lblConnectionText
        '
        Me.lblConnectionText.AutoSize = True
        Me.lblConnectionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnectionText.Location = New System.Drawing.Point(13, 267)
        Me.lblConnectionText.Name = "lblConnectionText"
        Me.lblConnectionText.Size = New System.Drawing.Size(100, 13)
        Me.lblConnectionText.TabIndex = 16
        Me.lblConnectionText.Text = "Connection Text"
        Me.lblConnectionText.Visible = False
        '
        'txtConnectionText
        '
        Me.txtConnectionText.Location = New System.Drawing.Point(12, 284)
        Me.txtConnectionText.Multiline = True
        Me.txtConnectionText.Name = "txtConnectionText"
        Me.txtConnectionText.Size = New System.Drawing.Size(258, 48)
        Me.txtConnectionText.TabIndex = 17
        Me.txtConnectionText.Visible = False
        '
        'btnShowConnectionText
        '
        Me.btnShowConnectionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowConnectionText.Location = New System.Drawing.Point(12, 350)
        Me.btnShowConnectionText.Name = "btnShowConnectionText"
        Me.btnShowConnectionText.Size = New System.Drawing.Size(121, 47)
        Me.btnShowConnectionText.TabIndex = 18
        Me.btnShowConnectionText.Text = "Show Connection Text"
        Me.btnShowConnectionText.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(103, 26)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnExecute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 409)
        Me.Controls.Add(Me.btnShowConnectionText)
        Me.Controls.Add(Me.txtConnectionText)
        Me.Controls.Add(Me.lblConnectionText)
        Me.Controls.Add(Me.btnCopyServerSelection)
        Me.Controls.Add(Me.lblServerList)
        Me.Controls.Add(Me.lstServerList)
        Me.Controls.Add(Me.lstApplication)
        Me.Controls.Add(Me.lstCounty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExecute)
        Me.Name = "Form1"
        Me.Text = "Launch App"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstCounty As System.Windows.Forms.ListBox
    Friend WithEvents lstApplication As System.Windows.Forms.ListBox
    Friend WithEvents lstServerList As System.Windows.Forms.ListBox
    Friend WithEvents lblServerList As System.Windows.Forms.Label
    Friend WithEvents btnCopyServerSelection As System.Windows.Forms.Button
    Friend WithEvents lblConnectionText As System.Windows.Forms.Label
    Friend WithEvents txtConnectionText As System.Windows.Forms.TextBox
    Friend WithEvents btnShowConnectionText As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
