Public Class MainForm
    ''' <summary>
    ''' Label for print job in print queue.
    ''' </summary>
    Private Shared ReadOnly _printJobLabel As String = "Test Print"

    ''' <summary>
    ''' Creates list of printers in PrinterList.
    ''' </summary>
    ''' <param name="printer">Name of printer to select.</param>
    Private Sub ListPrinters(Optional printer As String = vbNullString)
        For Each printer In Printing.PrinterSettings.InstalledPrinters
            PrinterList.Items.Add(printer)
        Next
        If String.IsNullOrEmpty(printer) Then
            PrinterList.SelectedIndex = 0
        Else
            PrinterList.SelectedItem = printer
        End If
    End Sub

    ''' <summary>
    ''' On loading the form, populates printer list.
    ''' </summary>
    ''' <param name="sender">Event sender.</param>
    ''' <param name="e">Triggering event.</param>
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With My.Settings
            .Reload()
            If .Printer.Length > 0 Then
                ListPrinters(.Printer)
            Else
                ListPrinters()
            End If
        End With
    End Sub

    ''' <summary>
    ''' On change of slected item, changes the settings accordingly.
    ''' </summary>
    ''' <param name="sender">Event sender.</param>
    ''' <param name="e">Triggering event.</param>
    Private Sub PrinterList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PrinterList.SelectedIndexChanged
        With My.Settings
            .Printer = PrinterList.SelectedItem
            .Save()
        End With
    End Sub

    ''' <summary>
    ''' On clicking the print button, sends InputTxt's content to printer.
    ''' </summary>
    ''' <param name="sender">Event sender.</param>
    ''' <param name="e">Triggering event.</param>
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        SendStringToPrinter(PrinterList.SelectedItem, InputTxt.Text, _printJobLabel)
        'Dim path As New ManagementPath With {
        '    .Server = ".",
        '    .NamespacePath = "root\CIMV2"
        '}
        'Dim scope As New ManagementScope(path)
        'Dim query As New ObjectQuery("SELECT * FROM Win32_PnPEntity")
        'Dim searcher As New ManagementObjectSearcher(scope, query)
        'Dim queryCollection As ManagementObjectCollection = searcher.Get()
        'Dim m As ManagementObject
        'For Each m In queryCollection
        '    Debug.Print(m("Name"))
        'Next
    End Sub

    ''' <summary>
    ''' On clicking the refresh button, refreshes printer list.
    ''' </summary>
    ''' <param name="sender">Event sender.</param>
    ''' <param name="e">Triggering event.</param>
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Dim printer As String = PrinterList.SelectedItem
        PrinterList.Items.Clear()
        ListPrinters(printer)
    End Sub
End Class
