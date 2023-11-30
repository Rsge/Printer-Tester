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
        PrinterList = New ComboBox()
        InputTxt = New TextBox()
        PrintButton = New Button()
        PrinterChoiceLabel = New Label()
        InputTxtLabel = New Label()
        RefreshButton = New Button()
        SuspendLayout()
        ' 
        ' PrinterList
        ' 
        resources.ApplyResources(PrinterList, "PrinterList")
        PrinterList.DropDownStyle = ComboBoxStyle.DropDownList
        PrinterList.FormattingEnabled = True
        PrinterList.Name = "PrinterList"
        PrinterList.Sorted = True
        ' 
        ' InputTxt
        ' 
        resources.ApplyResources(InputTxt, "InputTxt")
        InputTxt.Name = "InputTxt"
        ' 
        ' PrintButton
        ' 
        resources.ApplyResources(PrintButton, "PrintButton")
        PrintButton.Name = "PrintButton"
        PrintButton.UseVisualStyleBackColor = True
        ' 
        ' PrinterChoiceLabel
        ' 
        resources.ApplyResources(PrinterChoiceLabel, "PrinterChoiceLabel")
        PrinterChoiceLabel.Name = "PrinterChoiceLabel"
        ' 
        ' InputTxtLabel
        ' 
        resources.ApplyResources(InputTxtLabel, "InputTxtLabel")
        InputTxtLabel.Name = "InputTxtLabel"
        ' 
        ' RefreshButton
        ' 
        resources.ApplyResources(RefreshButton, "RefreshButton")
        RefreshButton.Name = "RefreshButton"
        RefreshButton.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(RefreshButton)
        Controls.Add(InputTxtLabel)
        Controls.Add(PrinterChoiceLabel)
        Controls.Add(PrintButton)
        Controls.Add(InputTxt)
        Controls.Add(PrinterList)
        Name = "MainForm"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PrinterList As ComboBox
    Friend WithEvents InputTxt As TextBox
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrinterChoiceLabel As Label
    Friend WithEvents InputTxtLabel As Label
    Friend WithEvents RefreshButton As Button
End Class
