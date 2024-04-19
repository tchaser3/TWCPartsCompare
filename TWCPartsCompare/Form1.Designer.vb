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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.cboMainPartID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMainPartNumber = New System.Windows.Forms.TextBox()
        Me.txtMainPartDescription = New System.Windows.Forms.TextBox()
        Me.txtMainTWCPart = New System.Windows.Forms.TextBox()
        Me.txtMainPrice = New System.Windows.Forms.TextBox()
        Me.txtMainActive = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTransactionPartDescription = New System.Windows.Forms.TextBox()
        Me.txtTransactionPartNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboTransactionPartID = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(306, 225)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(140, 46)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(306, 173)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(140, 46)
        Me.btnProcess.TabIndex = 1
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'cboMainPartID
        '
        Me.cboMainPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMainPartID.FormattingEnabled = True
        Me.cboMainPartID.Location = New System.Drawing.Point(145, 109)
        Me.cboMainPartID.Name = "cboMainPartID"
        Me.cboMainPartID.Size = New System.Drawing.Size(121, 21)
        Me.cboMainPartID.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Part ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMainPartNumber
        '
        Me.txtMainPartNumber.Location = New System.Drawing.Point(145, 137)
        Me.txtMainPartNumber.Name = "txtMainPartNumber"
        Me.txtMainPartNumber.ReadOnly = True
        Me.txtMainPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtMainPartNumber.TabIndex = 4
        '
        'txtMainPartDescription
        '
        Me.txtMainPartDescription.Location = New System.Drawing.Point(145, 163)
        Me.txtMainPartDescription.Name = "txtMainPartDescription"
        Me.txtMainPartDescription.ReadOnly = True
        Me.txtMainPartDescription.Size = New System.Drawing.Size(121, 20)
        Me.txtMainPartDescription.TabIndex = 5
        '
        'txtMainTWCPart
        '
        Me.txtMainTWCPart.Location = New System.Drawing.Point(145, 189)
        Me.txtMainTWCPart.Name = "txtMainTWCPart"
        Me.txtMainTWCPart.ReadOnly = True
        Me.txtMainTWCPart.Size = New System.Drawing.Size(121, 20)
        Me.txtMainTWCPart.TabIndex = 6
        '
        'txtMainPrice
        '
        Me.txtMainPrice.Location = New System.Drawing.Point(145, 215)
        Me.txtMainPrice.Name = "txtMainPrice"
        Me.txtMainPrice.ReadOnly = True
        Me.txtMainPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtMainPrice.TabIndex = 7
        '
        'txtMainActive
        '
        Me.txtMainActive.Location = New System.Drawing.Point(145, 241)
        Me.txtMainActive.Name = "txtMainActive"
        Me.txtMainActive.ReadOnly = True
        Me.txtMainActive.Size = New System.Drawing.Size(121, 20)
        Me.txtMainActive.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Part Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Description"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "TWC Part"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Price"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Active"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(433, 41)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "TWC Part Number Comparison"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 382)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Description"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 359)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Part Number"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTransactionPartDescription
        '
        Me.txtTransactionPartDescription.Location = New System.Drawing.Point(145, 385)
        Me.txtTransactionPartDescription.Name = "txtTransactionPartDescription"
        Me.txtTransactionPartDescription.ReadOnly = True
        Me.txtTransactionPartDescription.Size = New System.Drawing.Size(121, 20)
        Me.txtTransactionPartDescription.TabIndex = 18
        '
        'txtTransactionPartNumber
        '
        Me.txtTransactionPartNumber.Location = New System.Drawing.Point(145, 359)
        Me.txtTransactionPartNumber.Name = "txtTransactionPartNumber"
        Me.txtTransactionPartNumber.ReadOnly = True
        Me.txtTransactionPartNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtTransactionPartNumber.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(39, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Part ID"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboTransactionPartID
        '
        Me.cboTransactionPartID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransactionPartID.FormattingEnabled = True
        Me.cboTransactionPartID.Location = New System.Drawing.Point(145, 331)
        Me.cboTransactionPartID.Name = "cboTransactionPartID"
        Me.cboTransactionPartID.Size = New System.Drawing.Size(121, 21)
        Me.cboTransactionPartID.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTransactionPartDescription)
        Me.Controls.Add(Me.txtTransactionPartNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboTransactionPartID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMainActive)
        Me.Controls.Add(Me.txtMainPrice)
        Me.Controls.Add(Me.txtMainTWCPart)
        Me.Controls.Add(Me.txtMainPartDescription)
        Me.Controls.Add(Me.txtMainPartNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMainPartID)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents cboMainPartID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMainPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtMainPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtMainTWCPart As System.Windows.Forms.TextBox
    Friend WithEvents txtMainPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtMainActive As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTransactionPartDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtTransactionPartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboTransactionPartID As System.Windows.Forms.ComboBox

End Class
