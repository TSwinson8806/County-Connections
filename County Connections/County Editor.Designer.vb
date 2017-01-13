<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class County_Editor
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtCountyName = New System.Windows.Forms.TextBox()
        Me.txtCountyDomain = New System.Windows.Forms.TextBox()
        Me.lblDomain = New System.Windows.Forms.Label()
        Me.txtCountyUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.chkCountyIsDefault = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(24, 58)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtCountyName
        '
        Me.txtCountyName.Location = New System.Drawing.Point(65, 55)
        Me.txtCountyName.Name = "txtCountyName"
        Me.txtCountyName.Size = New System.Drawing.Size(172, 20)
        Me.txtCountyName.TabIndex = 1
        '
        'txtCountyDomain
        '
        Me.txtCountyDomain.Location = New System.Drawing.Point(65, 92)
        Me.txtCountyDomain.Name = "txtCountyDomain"
        Me.txtCountyDomain.Size = New System.Drawing.Size(172, 20)
        Me.txtCountyDomain.TabIndex = 3
        '
        'lblDomain
        '
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Location = New System.Drawing.Point(16, 95)
        Me.lblDomain.Name = "lblDomain"
        Me.lblDomain.Size = New System.Drawing.Size(43, 13)
        Me.lblDomain.TabIndex = 2
        Me.lblDomain.Text = "Domain"
        '
        'txtCountyUsername
        '
        Me.txtCountyUsername.Location = New System.Drawing.Point(65, 133)
        Me.txtCountyUsername.Name = "txtCountyUsername"
        Me.txtCountyUsername.Size = New System.Drawing.Size(170, 20)
        Me.txtCountyUsername.TabIndex = 5
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(4, 133)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Username"
        '
        'chkCountyIsDefault
        '
        Me.chkCountyIsDefault.AutoSize = True
        Me.chkCountyIsDefault.Location = New System.Drawing.Point(19, 170)
        Me.chkCountyIsDefault.Name = "chkCountyIsDefault"
        Me.chkCountyIsDefault.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkCountyIsDefault.Size = New System.Drawing.Size(60, 17)
        Me.chkCountyIsDefault.TabIndex = 7
        Me.chkCountyIsDefault.Text = "Default"
        Me.chkCountyIsDefault.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(205, 247)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 33)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(15, 247)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 33)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(244, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(55, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(65, 15)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(53, 20)
        Me.txtId.TabIndex = 12
        Me.txtId.Visible = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(42, 18)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(16, 13)
        Me.lblId.TabIndex = 11
        Me.lblId.Text = "Id"
        Me.lblId.Visible = False
        '
        'County_Editor
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(311, 314)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkCountyIsDefault)
        Me.Controls.Add(Me.txtCountyUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtCountyDomain)
        Me.Controls.Add(Me.lblDomain)
        Me.Controls.Add(Me.txtCountyName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "County_Editor"
        Me.Text = "County Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtCountyName As TextBox
    Friend WithEvents txtCountyDomain As TextBox
    Friend WithEvents lblDomain As Label
    Friend WithEvents txtCountyUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents chkCountyIsDefault As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
End Class
