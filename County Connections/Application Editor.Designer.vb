<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Application_Editor
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
        Me.lblApplicationName = New System.Windows.Forms.Label()
        Me.txtApplicationName = New System.Windows.Forms.TextBox()
        Me.txtApplicationPath = New System.Windows.Forms.TextBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.chkApplicationIsDefault = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblApplicationName
        '
        Me.lblApplicationName.AutoSize = True
        Me.lblApplicationName.Location = New System.Drawing.Point(12, 35)
        Me.lblApplicationName.Name = "lblApplicationName"
        Me.lblApplicationName.Size = New System.Drawing.Size(35, 13)
        Me.lblApplicationName.TabIndex = 0
        Me.lblApplicationName.Text = "Name"
        '
        'txtApplicationName
        '
        Me.txtApplicationName.Location = New System.Drawing.Point(57, 32)
        Me.txtApplicationName.Name = "txtApplicationName"
        Me.txtApplicationName.Size = New System.Drawing.Size(199, 20)
        Me.txtApplicationName.TabIndex = 1
        '
        'txtApplicationPath
        '
        Me.txtApplicationPath.Location = New System.Drawing.Point(57, 80)
        Me.txtApplicationPath.Multiline = True
        Me.txtApplicationPath.Name = "txtApplicationPath"
        Me.txtApplicationPath.Size = New System.Drawing.Size(242, 55)
        Me.txtApplicationPath.TabIndex = 3
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(12, 83)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(29, 13)
        Me.lblPath.TabIndex = 2
        Me.lblPath.Text = "Path"
        '
        'chkApplicationIsDefault
        '
        Me.chkApplicationIsDefault.AutoSize = True
        Me.chkApplicationIsDefault.Location = New System.Drawing.Point(12, 156)
        Me.chkApplicationIsDefault.Name = "chkApplicationIsDefault"
        Me.chkApplicationIsDefault.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkApplicationIsDefault.Size = New System.Drawing.Size(107, 17)
        Me.chkApplicationIsDefault.TabIndex = 4
        Me.chkApplicationIsDefault.Text = "Default Selection"
        Me.chkApplicationIsDefault.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(15, 229)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 33)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(205, 229)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 33)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Application_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 307)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkApplicationIsDefault)
        Me.Controls.Add(Me.txtApplicationPath)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.txtApplicationName)
        Me.Controls.Add(Me.lblApplicationName)
        Me.Name = "Application_Editor"
        Me.Text = "Application Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblApplicationName As Label
    Friend WithEvents txtApplicationName As TextBox
    Friend WithEvents txtApplicationPath As TextBox
    Friend WithEvents lblPath As Label
    Friend WithEvents chkApplicationIsDefault As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
