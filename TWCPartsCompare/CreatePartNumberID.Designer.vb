﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatePartNumberID
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
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.txtPartID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboTransactionID
        '
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(11, 11)
        Me.cboTransactionID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(145, 21)
        Me.cboTransactionID.TabIndex = 67
        '
        'txtPartID
        '
        Me.txtPartID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartID.Location = New System.Drawing.Point(11, 40)
        Me.txtPartID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPartID.Name = "txtPartID"
        Me.txtPartID.Size = New System.Drawing.Size(145, 20)
        Me.txtPartID.TabIndex = 68
        '
        'CreatePartNumberID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 86)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.txtPartID)
        Me.Name = "CreatePartNumberID"
        Me.Text = "CreatePartNumberID"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents txtPartID As System.Windows.Forms.TextBox
End Class
