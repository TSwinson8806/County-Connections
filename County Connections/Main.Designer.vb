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
        Me.components = New System.ComponentModel.Container()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstCounty = New System.Windows.Forms.ListBox()
        Me.lstApplication = New System.Windows.Forms.ListBox()
        Me.lstServerList = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAdditionalInfo = New System.Windows.Forms.Label()
        Me.btnCopyServerSelection = New System.Windows.Forms.Button()
        Me.lblConnectionText = New System.Windows.Forms.Label()
        Me.txtConnectionText = New System.Windows.Forms.TextBox()
        Me.btnShowConnectionText = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnAddCounty = New System.Windows.Forms.Button()
        Me.btnDeleteCounty = New System.Windows.Forms.Button()
        Me.btnDeleteApplication = New System.Windows.Forms.Button()
        Me.btnAddApplication = New System.Windows.Forms.Button()
        Me.btnDeleteAdditionalInfo = New System.Windows.Forms.Button()
        Me.btnAddAdditionalInfo = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExecute
        '
        Me.btnExecute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExecute.Location = New System.Drawing.Point(149, 398)
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
        Me.Label2.Location = New System.Drawing.Point(116, 9)
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
        Me.lstApplication.Location = New System.Drawing.Point(119, 25)
        Me.lstApplication.Name = "lstApplication"
        Me.lstApplication.Size = New System.Drawing.Size(140, 82)
        Me.lstApplication.TabIndex = 8
        '
        'lstServerList
        '
        Me.lstServerList.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstServerList.FormattingEnabled = True
        Me.lstServerList.Location = New System.Drawing.Point(12, 185)
        Me.lstServerList.Name = "lstServerList"
        Me.lstServerList.Size = New System.Drawing.Size(258, 82)
        Me.lstServerList.TabIndex = 10
        Me.lstServerList.Visible = False
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
        'lblAdditionalInfo
        '
        Me.lblAdditionalInfo.AutoSize = True
        Me.lblAdditionalInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditionalInfo.Location = New System.Drawing.Point(12, 161)
        Me.lblAdditionalInfo.Name = "lblAdditionalInfo"
        Me.lblAdditionalInfo.Size = New System.Drawing.Size(89, 13)
        Me.lblAdditionalInfo.TabIndex = 11
        Me.lblAdditionalInfo.Text = "Additional Info"
        Me.lblAdditionalInfo.Visible = False
        '
        'btnCopyServerSelection
        '
        Me.btnCopyServerSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyServerSelection.Location = New System.Drawing.Point(107, 157)
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
        Me.lblConnectionText.Location = New System.Drawing.Point(13, 315)
        Me.lblConnectionText.Name = "lblConnectionText"
        Me.lblConnectionText.Size = New System.Drawing.Size(100, 13)
        Me.lblConnectionText.TabIndex = 16
        Me.lblConnectionText.Text = "Connection Text"
        Me.lblConnectionText.Visible = False
        '
        'txtConnectionText
        '
        Me.txtConnectionText.Location = New System.Drawing.Point(12, 331)
        Me.txtConnectionText.Multiline = True
        Me.txtConnectionText.Name = "txtConnectionText"
        Me.txtConnectionText.Size = New System.Drawing.Size(258, 48)
        Me.txtConnectionText.TabIndex = 17
        Me.txtConnectionText.Visible = False
        '
        'btnShowConnectionText
        '
        Me.btnShowConnectionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowConnectionText.Location = New System.Drawing.Point(12, 398)
        Me.btnShowConnectionText.Name = "btnShowConnectionText"
        Me.btnShowConnectionText.Size = New System.Drawing.Size(121, 47)
        Me.btnShowConnectionText.TabIndex = 18
        Me.btnShowConnectionText.Text = "Show Connection Text"
        Me.btnShowConnectionText.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(288, 65)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(108, 95)
        Me.ListBox1.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(345, 238)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 20
        '
        'btnAddCounty
        '
        Me.btnAddCounty.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCounty.Location = New System.Drawing.Point(16, 108)
        Me.btnAddCounty.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAddCounty.Name = "btnAddCounty"
        Me.btnAddCounty.Size = New System.Drawing.Size(23, 23)
        Me.btnAddCounty.TabIndex = 21
        Me.btnAddCounty.Text = "+"
        Me.btnAddCounty.UseVisualStyleBackColor = True
        '
        'btnDeleteCounty
        '
        Me.btnDeleteCounty.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCounty.Location = New System.Drawing.Point(70, 108)
        Me.btnDeleteCounty.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteCounty.Name = "btnDeleteCounty"
        Me.btnDeleteCounty.Size = New System.Drawing.Size(23, 23)
        Me.btnDeleteCounty.TabIndex = 22
        Me.btnDeleteCounty.Text = "-"
        Me.btnDeleteCounty.UseVisualStyleBackColor = True
        '
        'btnDeleteApplication
        '
        Me.btnDeleteApplication.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteApplication.Location = New System.Drawing.Point(236, 108)
        Me.btnDeleteApplication.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteApplication.Name = "btnDeleteApplication"
        Me.btnDeleteApplication.Size = New System.Drawing.Size(23, 23)
        Me.btnDeleteApplication.TabIndex = 24
        Me.btnDeleteApplication.Text = "-"
        Me.btnDeleteApplication.UseVisualStyleBackColor = True
        '
        'btnAddApplication
        '
        Me.btnAddApplication.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddApplication.Location = New System.Drawing.Point(119, 108)
        Me.btnAddApplication.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAddApplication.Name = "btnAddApplication"
        Me.btnAddApplication.Size = New System.Drawing.Size(23, 23)
        Me.btnAddApplication.TabIndex = 23
        Me.btnAddApplication.Text = "+"
        Me.btnAddApplication.UseVisualStyleBackColor = True
        '
        'btnDeleteAdditionalInfo
        '
        Me.btnDeleteAdditionalInfo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAdditionalInfo.Location = New System.Drawing.Point(247, 268)
        Me.btnDeleteAdditionalInfo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteAdditionalInfo.Name = "btnDeleteAdditionalInfo"
        Me.btnDeleteAdditionalInfo.Size = New System.Drawing.Size(23, 23)
        Me.btnDeleteAdditionalInfo.TabIndex = 26
        Me.btnDeleteAdditionalInfo.Text = "-"
        Me.btnDeleteAdditionalInfo.UseVisualStyleBackColor = True
        Me.btnDeleteAdditionalInfo.Visible = False
        '
        'btnAddAdditionalInfo
        '
        Me.btnAddAdditionalInfo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAdditionalInfo.Location = New System.Drawing.Point(12, 268)
        Me.btnAddAdditionalInfo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAddAdditionalInfo.Name = "btnAddAdditionalInfo"
        Me.btnAddAdditionalInfo.Size = New System.Drawing.Size(23, 23)
        Me.btnAddAdditionalInfo.TabIndex = 25
        Me.btnAddAdditionalInfo.Text = "+"
        Me.btnAddAdditionalInfo.UseVisualStyleBackColor = True
        Me.btnAddAdditionalInfo.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(345, 264)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 20)
        Me.TextBox2.TabIndex = 27
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(345, 290)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(133, 20)
        Me.TextBox3.TabIndex = 28
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(345, 316)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(133, 20)
        Me.TextBox4.TabIndex = 30
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(345, 342)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(133, 20)
        Me.TextBox5.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(372, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(357, 161)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(99, 20)
        Me.TextBox6.TabIndex = 32
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(402, 65)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 33
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(333, 368)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(159, 95)
        Me.ListBox3.TabIndex = 34
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(360, 214)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 35
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(475, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(47, 23)
        Me.btnClose.TabIndex = 36
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AcceptButton = Me.btnExecute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 476)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnDeleteAdditionalInfo)
        Me.Controls.Add(Me.btnAddAdditionalInfo)
        Me.Controls.Add(Me.btnDeleteApplication)
        Me.Controls.Add(Me.btnAddApplication)
        Me.Controls.Add(Me.btnDeleteCounty)
        Me.Controls.Add(Me.btnAddCounty)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnShowConnectionText)
        Me.Controls.Add(Me.txtConnectionText)
        Me.Controls.Add(Me.lblConnectionText)
        Me.Controls.Add(Me.btnCopyServerSelection)
        Me.Controls.Add(Me.lblAdditionalInfo)
        Me.Controls.Add(Me.lstServerList)
        Me.Controls.Add(Me.lstApplication)
        Me.Controls.Add(Me.lstCounty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExecute)
        Me.Name = "Main"
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
    Friend WithEvents lblAdditionalInfo As System.Windows.Forms.Label
    Friend WithEvents btnCopyServerSelection As System.Windows.Forms.Button
    Friend WithEvents lblConnectionText As System.Windows.Forms.Label
    Friend WithEvents txtConnectionText As System.Windows.Forms.TextBox
    Friend WithEvents btnShowConnectionText As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAddCounty As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCounty As System.Windows.Forms.Button
    Friend WithEvents btnDeleteApplication As System.Windows.Forms.Button
    Friend WithEvents btnAddApplication As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAdditionalInfo As System.Windows.Forms.Button
    Friend WithEvents btnAddAdditionalInfo As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
