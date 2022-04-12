Imports System.Runtime.InteropServices

'Stuff needed for printing
''' <summary>
''' Allows for printing raw information to printer.
''' </summary>
Module RawPrinter
    'Structure and API declarions
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Structure DOCINFOW
        <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
        <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
    End Structure

    'DLL imports
    <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW",
   SetLastError:=True, CharSet:=CharSet.Unicode,
   ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Function OpenPrinter(src As String, ByRef hPrinter As IntPtr, pd As Integer) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="ClosePrinter",
   SetLastError:=True, CharSet:=CharSet.Unicode,
   ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Function ClosePrinter(hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW",
   SetLastError:=True, CharSet:=CharSet.Unicode,
   ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Function StartDocPrinter(hPrinter As IntPtr, level As Integer, ByRef pDI As DOCINFOW) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter",
   SetLastError:=True, CharSet:=CharSet.Unicode,
   ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Function EndDocPrinter(hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter",
   SetLastError:=True, CharSet:=CharSet.Unicode,
   ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Function StartPagePrinter(hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter",
   SetLastError:=True, CharSet:=CharSet.Unicode,
   ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Function EndPagePrinter(hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", EntryPoint:="WritePrinter",
   SetLastError:=True, CharSet:=CharSet.Unicode,
   ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
    Private Function WritePrinter(hPrinter As IntPtr, pBytes As IntPtr, dwCount As Integer, ByRef dwWritten As Integer) As Boolean
    End Function

    'Actually sending stuff to printer
    ''' <summary>
    ''' Sends bytes to the printer spooler.
    ''' </summary>
    ''' <param name="szPrinterName">Printer spooler name.</param>
    ''' <param name="pBytes">Unmanaged array of bytes.</param>
    ''' <param name="dwCount">Number of bytes to send.</param>
    ''' <param name="filename">Name for job in print queue.</param>
    ''' <returns><c>True</c> if successful, <c>False</c> otherwise.</returns>
    Public Function SendBytesToPrinter(szPrinterName As String, pBytes As IntPtr, dwCount As Integer, filename As String) As Boolean
        'Printer handle
        Dim hPrinter As IntPtr
        'Last error - in case there was trouble
        Dim dwError As Integer
        'Document description (name, port, data type)
        Dim di As DOCINFOW
        'Number of bytes written by WritePrinter()
        Dim dwWritten As Integer
        'Success code
        Dim bSuccess As Boolean

        'Setting up the DOCINFO structure
        di = New DOCINFOW
        With di
            .pDocName = filename
            .pDataType = "RAW"
        End With
        'Assuming failure unless specifically succeeded
        bSuccess = False
        If OpenPrinter(szPrinterName, hPrinter, 0) Then
            If StartDocPrinter(hPrinter, 1, di) Then
                If StartPagePrinter(hPrinter) Then
                    'Write your printer-specific bytes to the printer
                    bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                    EndPagePrinter(hPrinter)
                End If
                EndDocPrinter(hPrinter)
            End If
            ClosePrinter(hPrinter)
        End If
        'If not succeeded, GetLastError may give information about why
        If bSuccess = False Then
            dwError = Marshal.GetLastWin32Error()
        End If
        Return bSuccess
    End Function
    ''' <summary>
    ''' Sends string to printer as raw bytes.
    ''' </summary>
    ''' <param name="szPrinterName">Printer spooler name.</param>
    ''' <param name="szString">String to print.</param>
    ''' <param name="filename">Name for job in print queue.</param>
    Public Sub SendStringToPrinter(szPrinterName As String, szString As String, filename As String)
        Dim pBytes As IntPtr
        Dim dwCount As Integer
        dwCount = szString.Length()
        'Assuming the printer is expecting ANSI text, and converting the string to ANSI text
        pBytes = Marshal.StringToCoTaskMemAnsi(szString)
        'Sending converted ANSI string to printer
        SendBytesToPrinter(szPrinterName, pBytes, dwCount, filename)
        Marshal.FreeCoTaskMem(pBytes)
    End Sub
End Module
