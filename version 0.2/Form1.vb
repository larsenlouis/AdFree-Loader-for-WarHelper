Imports System.IO
Public Class Form1
    Private WithEvents MyProcess As Process
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" ( _
     ByVal lpApplicationName As String, _
     ByVal lpKeyName As String, ByVal lpdefault As String, _
     ByVal lpretrunedstring As String, ByVal nSize As Int32, _
     ByVal lpFilename As String) As Int32

    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" ( _
    ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFilename As String) As Int32
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MyProcess As New Process
        Dim StartupDate As Date
        Dim CurrentTime As String
        StartupDate = Date.Now
        CurrentTime = StartupDate.ToString("yyyy-MM-dd HH:mm")
        Dim StartupPath As String = Application.StartupPath
        Dim AppPath As String = ""
        Try
            AppPath = StartupPath + "\º”º”÷˙ ÷.exe"
            If File.Exists(AppPath) Then
                Dim Str As New String(" ", 256)
                GetPrivateProfileString("War3Main", "ADData", "ERROR", Str, 256, StartupPath + "\WH_Set.ini")
                Dim iniDate As Date = String.Format(Trim(Str), "yyyy-MM-dd HH:mm")
                If Date.Compare(iniDate.Date, StartupDate.Date) < 0 Then
                    WritePrivateProfileString("War3Main", "ADData", CurrentTime, StartupPath + "\WH_Set.ini")
                    MyProcess.StartInfo.FileName = AppPath
                    MyProcess.StartInfo.WorkingDirectory = AppPath
                    MyProcess.Start()
                End If
                End
            End If

            AppPath = StartupPath + "\Warhelper.exe"
            If File.Exists(AppPath) Then
                Dim Str As New String(" ", 256)
                GetPrivateProfileString("War3Main", "ADData", "ERROR", Str, 256, StartupPath + "\WH_Set.ini")
                Dim iniDate As Date = String.Format(Trim(Str), "yyyy-MM-dd HH:mm")
                If Date.Compare(iniDate.Date, StartupDate.Date) < 0 Then
                    WritePrivateProfileString("War3Main", "ADData", CurrentTime, StartupPath + "\WH_Set.ini")
                    MyProcess.StartInfo.FileName = AppPath
                    MyProcess.StartInfo.WorkingDirectory = AppPath
                    MyProcess.Start()
                End If
                End
            End If

            AppPath = StartupPath + "\WarKey.exe"
            If File.Exists(AppPath) Then
                Dim Str As New String(" ", 256)
                GetPrivateProfileString("Main", "IEData", "ERROR", Str, 256, StartupPath + "\WKSet.ini")
                Dim iniDate As Date = String.Format(Trim(Str), "yyyy-MM-dd HH:mm")
                If Date.Compare(iniDate.Date, StartupDate.Date) < 0 Then
                    WritePrivateProfileString("Main", "IEData", CurrentTime, StartupPath + "\WKSet.ini")
                    MyProcess.StartInfo.FileName = AppPath
                    MyProcess.StartInfo.WorkingDirectory = AppPath
                    MyProcess.Start()
                    End
                End If
            End If

            AppPath = StartupPath + "\MouseKey.exe"
            If File.Exists(AppPath) Then
                Dim Str As New String(" ", 256)
                GetPrivateProfileString("Main", "IEData", "ERROR", Str, 256, StartupPath + "\MouseKey.ini")
                Dim iniDate As Date = String.Format(Trim(Str), "yyyy-MM-dd HH:mm")
                If Date.Compare(iniDate.Date, StartupDate.Date) < 0 Then
                    WritePrivateProfileString("Main", "IEData", CurrentTime, StartupPath + "\MouseKey.ini")
                    MyProcess.StartInfo.FileName = AppPath
                    MyProcess.StartInfo.WorkingDirectory = AppPath
                    MyProcess.Start()
                    End
                End If
            End If
        Catch
            Dim ex As New Exception
            Label1.Text = "¥ÌŒÛ:" + vbCrLf + ex.Message
        End Try
    End Sub
End Class
