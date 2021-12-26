Imports System.IO
Imports System.Threadi
Imports System.Threading
Imports System.Environment

Public Class Form1
    Private Sub ValleyTheme1_Click(sender As Object, e As EventArgs) Handles ValleyTheme1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' System.IO.File.WriteAllBytes("C:\Windows\System32\global.apk", My.Resources._global)
        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\global.apk")

            End If
        End Using
        MsgBox("done :)")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '     System.IO.File.WriteAllBytes("C:\Windows\System32\global.apk", My.Resources._global)
        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\global.apk")

            End If
        End Using
        MsgBox("done :)")
    End Sub

    Private Sub ValleyClose1_Click(sender As Object, e As EventArgs) Handles ValleyClose1.Click
        System.IO.File.Delete("C:\Windows\System32\global.apk")
        System.IO.File.Delete("C:\Windows\System32\vn.apk")
        System.IO.File.Delete("C:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb")
        System.IO.File.Delete("C:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb")
        System.IO.File.Delete("C:\Windows\System32\kr.apk")
        System.IO.File.Delete("C:\Windows\System32\TW.apk")
        System.IO.File.Delete("C:\Windows\System32\vpn.apk")
        System.IO.File.Delete("C:\Windows\System32\esileexpolrer.apk")
        System.IO.File.Delete("C:\Windows\System32\xapk.apk")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '    System.IO.File.WriteAllBytes("C:\Windows\System32\global.apk", My.Resources._global)
        Process.Start("C:\Windows\System32\global.apk")

        MsgBox("done :)")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' System.IO.File.WriteAllBytes("C:\Windows\System32\vng.apk", My.Resources.vng)

        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\vng.apk")

            End If
        End Using
        MsgBox("done :)")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' System.IO.File.WriteAllBytes("C:\Windows\System32\vng.apk", My.Resources.vng)

        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\vng.apk")

            End If
        End Using

        MsgBox("done :)")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next
        MkDir("C:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("D:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("G:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("E:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("L:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("J:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("Y:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("X:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("F:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("Z:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("I:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        On Error Resume Next
        'System.IO.File.WriteAllBytes("C:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("D:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("G:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("E:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("L:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("J:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("Y:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("X:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("F:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("Z:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("I:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        On Error Resume Next
        '  System.IO.File.WriteAllBytes("C:\Windows\System32\TW.apk", My.Resources.TW)

        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\TW.apk")

            End If
        End Using

        MsgBox("done :)")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        On Error Resume Next
        MkDir("C:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("D:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("G:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("E:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("L:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("J:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("Y:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("X:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("F:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("Z:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("I:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        On Error Resume Next
        'System.IO.File.WriteAllBytes("C:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("D:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("G:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("L:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("J:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("Y:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("X:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("F:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("Z:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        'System.IO.File.WriteAllBytes("I:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)
        On Error Resume Next
        '  System.IO.File.WriteAllBytes("C:\Windows\System32\TW.apk", My.Resources.TW)

        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\TW.apk")

            End If
        End Using

        MsgBox("done :)")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MkDir("C:\Users\" & UserName & "\Documents\XuanZhi\Pictures\Android\obb\com.pubg.krmobile")
        'System.IO.File.WriteAllBytes("C:\Windows\System32\TW.apk", My.Resources.TW)
        Process.Start("C:\Windows\System32\TW.apk")
        '     System.IO.File.WriteAllBytes("C:\Users\" & UserName & "\Documents\XuanZhi\Pictures\Android\obb\com.pubg.krmobile\main.14470.com.rekoo.pubgm.obb", My.Resources.main.14470.com.rekoo.pubgm.obb)

        MsgBox("done :)")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MkDir("C:\Users\" & UserName & "\Documents\XuanZhi\Pictures\Android\obb\com.pubg.krmobile")
        'System.IO.File.WriteAllBytes("C:\Windows\System32\kr.apk", My.Resources.kr)
        Process.Start("C:\Windows\System32\kr.apk")
        '     System.IO.File.WriteAllBytes("C:\Users\" & UserName & "\Documents\XuanZhi\Pictures\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)

        MsgBox("done :)")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error Resume Next
        MkDir("C:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("D:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("G:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("E:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("L:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("J:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("Y:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("X:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("F:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("Z:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        MkDir("I:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile")
        On Error Resume Next
        'System.IO.File.WriteAllBytes("C:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        'System.IO.File.WriteAllBytes("D:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        'System.IO.File.WriteAllBytes("G:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        'System.IO.File.WriteAllBytes("E:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        'System.IO.File.WriteAllBytes("L:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        'System.IO.File.WriteAllBytes("J:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        'System.IO.File.WriteAllBytes("Y:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        'System.IO.File.WriteAllBytes("X:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        'System.IO.File.WriteAllBytes("F:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        'System.IO.File.WriteAllBytes("Z:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        'System.IO.File.WriteAllBytes("I:\Program Files (x86)\SmartGaGa\ProjectTitan\Engine\sharefs\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        On Error Resume Next
        ' System.IO.File.WriteAllBytes("C:\Windows\System32\KR.apk", My.Resources.KR)

        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\KR.apk")

            End If
        End Using

        MsgBox("done :)")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' System.IO.File.WriteAllBytes("C:\Windows\System32\VN.apk", My.Resources.VN)
        Process.Start("C:\Windows\System32\VN.apk")

        MsgBox("done :)")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next
        MkDir("C:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("D:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("G:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("E:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("L:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("J:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("Y:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("X:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("F:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("Z:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        MkDir("I:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile")
        On Error Resume Next
        '  System.IO.File.WriteAllBytes("C:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        '  System.IO.File.WriteAllBytes("D:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        '  System.IO.File.WriteAllBytes("G:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        '  System.IO.File.WriteAllBytes("L:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        '  System.IO.File.WriteAllBytes("J:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        '  System.IO.File.WriteAllBytes("Y:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        '  System.IO.File.WriteAllBytes("X:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        '   System.IO.File.WriteAllBytes("F:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        '   System.IO.File.WriteAllBytes("Z:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        '   System.IO.File.WriteAllBytes("I:\Temp\TxGameDownload\MobileGamePCShared\Android\obb\com.pubg.krmobile\main.14460.com.pubg.krmobile.obb", My.Resources.main.14460.com.pubg.krmobile.obb)
        On Error Resume Next
        '   System.IO.File.WriteAllBytes("C:\Windows\System32\KR.apk", My.Resources.KR)

        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\KR.apk")

            End If
        End Using

        MsgBox("done :)")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        '  System.IO.File.WriteAllBytes("C:\Windows\System32\xapk.apk", My.Resources.xapk)
        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\xapk.apk")

            End If
        End Using

        MsgBox("done :)")
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        '  System.IO.File.WriteAllBytes("C:\Windows\System32\xapk.apk", My.Resources.xapk)
        Process.Start("C:\Windows\System32\xapk.apk")

        MsgBox("done :)")
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        'System.IO.File.WriteAllBytes("C:\Windows\System32\vpn.apk", My.Resources.vpn)
        Process.Start("C:\Windows\System32\vpn.apk")

        MsgBox("done :)")
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        'System.IO.File.WriteAllBytes("C:\Windows\System32\esfileexplorer.apk", My.Resources.esfileexplorer)
        Process.Start("C:\Windows\System32\esfileexplorer.apk")

        MsgBox("done :)")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'System.IO.File.WriteAllBytes("C:\Windows\System32\vpn.apk", My.Resources.vpn)
        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\vpn.apk")

            End If
        End Using

        MsgBox("done :)")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        '  System.IO.File.WriteAllBytes("C:\Windows\System32\esfileexpolrer.apk", My.Resources.esfileecpolrer)
        Dim process As Process = New Process()
        process.StartInfo = New ProcessStartInfo() With {.FileName = "cmd.exe", .CreateNoWindow = True, .RedirectStandardInput = True, .UseShellExecute = False}
        process.Start()
        Using standardInput As StreamWriter = process.StandardInput
            Dim flag As Boolean = Not standardInput.BaseStream.CanWrite
            If Not flag Then
                standardInput.WriteLine("@echo off")
                standardInput.WriteLine("adb kill-server")
                standardInput.WriteLine("adb start-server")
                standardInput.WriteLine("adb device")
                standardInput.WriteLine("adb install C:\Windows\System32\esfileexpolrer.apk")

            End If
        End Using

        MsgBox("done :)")
    End Sub
End Class
