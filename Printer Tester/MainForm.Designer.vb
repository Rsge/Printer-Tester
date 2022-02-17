<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PrinterList = New System.Windows.Forms.ComboBox()
        Me.InputTxt = New System.Windows.Forms.TextBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrinterChoiceLabel = New System.Windows.Forms.Label()
        Me.InputTxtLabel = New System.Windows.Forms.Label()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PrinterList
        '
        Me.PrinterList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PrinterList.FormattingEnabled = True
        Me.PrinterList.Location = New System.Drawing.Point(12, 27)
        Me.PrinterList.Name = "PrinterList"
        Me.PrinterList.Size = New System.Drawing.Size(440, 23)
        Me.PrinterList.Sorted = True
        Me.PrinterList.TabIndex = 0
        '
        'InputTxt
        '
        Me.InputTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputTxt.Location = New System.Drawing.Point(12, 107)
        Me.InputTxt.Multiline = True
        Me.InputTxt.Name = "InputTxt"
        Me.InputTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InputTxt.Size = New System.Drawing.Size(440, 150)
        Me.InputTxt.TabIndex = 1
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Location = New System.Drawing.Point(12, 263)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(440, 46)
        Me.PrintButton.TabIndex = 2
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrinterChoiceLabel
        '
        Me.PrinterChoiceLabel.AutoSize = True
        Me.PrinterChoiceLabel.Location = New System.Drawing.Point(12, 9)
        Me.PrinterChoiceLabel.Name = "PrinterChoiceLabel"
        Me.PrinterChoiceLabel.Size = New System.Drawing.Size(101, 15)
        Me.PrinterChoiceLabel.TabIndex = 3
        Me.PrinterChoiceLabel.Text = "Printer to print on"
        '
        'InputTxtLabel
        '
        Me.InputTxtLabel.AutoSize = True
        Me.InputTxtLabel.Location = New System.Drawing.Point(12, 89)
        Me.InputTxtLabel.Name = "InputTxtLabel"
        Me.InputTxtLabel.Size = New System.Drawing.Size(77, 15)
        Me.InputTxtLabel.TabIndex = 4
        Me.InputTxtLabel.Text = "What to print"
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.Location = New System.Drawing.Point(12, 56)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(440, 30)
        Me.RefreshButton.TabIndex = 5
        Me.RefreshButton.Text = "Refresh Printers"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 321)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.InputTxtLabel)
        Me.Controls.Add(Me.PrinterChoiceLabel)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.InputTxt)
        Me.Controls.Add(Me.PrinterList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(184, 244)
        Me.Name = "MainForm"
        Me.Text = "Printer Tester"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrinterList As ComboBox
    Friend WithEvents InputTxt As TextBox
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrinterChoiceLabel As Label
    Friend WithEvents InputTxtLabel As Label
    Friend WithEvents RefreshButton As Button
End Class
