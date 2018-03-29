Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Text

Module ReadIni
    Public Declare Auto Function GetPrivateProfileStringW Lib "kernel32" (ByVal lpAppName As String,
    ByVal lpKeyName As String,
    ByVal lpDefault As String,
    ByVal lpReturnedString As StringBuilder,
    ByVal nSize As Integer,
    ByVal lpFileName As String) As Integer

    Function ReadIni(ByVal Filename As String, ByVal AppName As String, ByVal KeyName As String)
        'make vars
        Dim Exists = False

        'Make sure file exists
        If System.IO.File.Exists(Filename) Then
            Exists = True
        End If

        'Read Ini
        If Exists = True Then
            Dim sb As New StringBuilder(500)
            Dim result As Integer = GetPrivateProfileStringW(AppName, KeyName, "", sb, sb.Capacity, Filename)
            If result > 0 Then
                Return sb.ToString()
            Else
                Dim ex As New Win32Exception(Marshal.GetLastWin32Error())
                Return "ERROR: " + ex.Message
            End If
        Else
            Return "Error: File not found"
        End If
    End Function
End Module
