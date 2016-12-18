Imports TSSAssistant.OpenFolderDialog
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports System.IO

Public Class Form1
    Private Sub Launch_Btn_Click(sender As Object, e As EventArgs) Handles Launch_Btn.Click

        Dim modelID As String
        Dim ecid As String
        Dim ios As String
        Dim nonceList As New List(Of String)
        Dim nonce As String
        Dim rnd As New Random

        modelID = identifier_txt.Text
        ecid = ECID_txt.Text
        ios = iosVer_txt.Text

        nonceList.Add("603be133ff0bdfa0f83f21e74191cf6770ea43bb")
        nonceList.Add("352dfad1713834f4f94c5ff3c3e5e99477347b95")
        nonceList.Add("42c88f5a7b75bc944c288a7215391dc9c73b6e9f")
        nonceList.Add("42c88f5a7b75bc944c288a7215391dc9c73b6e9f")
        nonceList.Add("9804d99e85bbafd4bb1135a1044773b4df9f1ba3")

        nonce = nonceList(rnd.Next(0, 4))

        If (Not System.IO.Directory.Exists(SaveLoc_txt.Text)) Then
            System.IO.Directory.CreateDirectory(SaveLoc_txt.Text)
        End If

        Delay(1)

        If Not ECID_txt.Text = "" And SaveLoc_txt.Text = Application.StartupPath Then
            If My.Computer.FileSystem.FileExists("tsschecker.exe") Then
                Process.Start("CMD", "/K tsschecker.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --apnonce " + nonce)
            Else
                Process.Start("CMD", "/K tsschecker_windows.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --apnonce " + nonce)
            End If
        ElseIf Not ECID_txt.Text = "" And Not SaveLoc_txt.Text = Application.StartupPath Then
            If My.Computer.FileSystem.FileExists("tsschecker.exe") Then
                Process.Start("CMD", "/K tsschecker.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --save-path " + SaveLoc_txt.Text + " --apnonce " + nonce)
            Else
                Process.Start("CMD", "/K tsschecker_windows.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --save-path " + SaveLoc_txt.Text + " --apnonce " + nonce)
            End If
        ElseIf ECID_txt.Text = "" And SaveLoc_txt.Text = Application.StartupPath Then
            If My.Computer.FileSystem.FileExists("tsschecker.exe") Then
                Process.Start("CMD", "/K tsschecker.exe -d " + modelID + " -s -i " + ios + " --apnonce " + nonce)
            Else
                Process.Start("CMD", "/K tsschecker_windows.exe -d " + modelID + " -s -i " + ios + " --apnonce " + nonce)
            End If
        ElseIf ECID_txt.Text = "" And Not SaveLoc_txt.Text = Application.StartupPath Then
            If My.Computer.FileSystem.FileExists("tsschecker.exe") Then
                Process.Start("CMD", "/K tsschecker.exe -d " + modelID + " -s -i " + ios + " --save-path " + SaveLoc_txt.Text + " --apnonce " + nonce)
            Else
                Process.Start("CMD", "/K tsschecker_windows.exe -d " + modelID + " -s -i " + ios + " --save-path " + SaveLoc_txt.Text + " --apnonce " + nonce)
            End If
            'ElseIf Not ECID_txt.Text = "" And SaveLoc_txt.Text = Application.StartupPath And EveryApnounce_rBtn.Checked = True Then
            '    If My.Computer.FileSystem.FileExists("tsschecker.exe") Then
            '        Process.Start("CMD", "/K tsschecker.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --apnonce 603be133ff0bdfa0f83f21e74191cf6770ea43bb" + "&" + "/K tsschecker.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --apnonce 352dfad1713834f4f94c5ff3c3e5e99477347b95" + "&" "/K tsschecker.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --apnonce 42c88f5a7b75bc944c288a7215391dc9c73b6e9f" + "&" "/K tsschecker.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --apnonce 42c88f5a7b75bc944c288a7215391dc9c73b6e9f" + "&" "/K tsschecker.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --apnonce 9804d99e85bbafd4bb1135a1044773b4df9f1ba3" + "&" "/K tsschecker.exe -d " + modelID + " -e " + ecid + " -s -i " + ios)
            '    Else
            '        Process.Start("CMD", "/K tsschecker_windows.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --apnonce " + nonce)
            '    End If
            'ElseIf Not ECID_txt.Text = "" And Not SaveLoc_txt.Text = Application.StartupPath And EveryApnounce_rBtn.Checked = True Then
            '    If My.Computer.FileSystem.FileExists("tsschecker.exe") Then
            '        Process.Start("CMD", "/K tsschecker.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --save-path " + SaveLoc_txt.Text + " --apnonce " + nonce)
            '    Else
            '        Process.Start("CMD", "/K tsschecker_windows.exe -d " + modelID + " -e " + ecid + " -s -i " + ios + " --save-path " + SaveLoc_txt.Text + " --apnonce " + nonce)
            '    End If
            'ElseIf ECID_txt.Text = "" And SaveLoc_txt.Text = Application.StartupPath And EveryApnounce_rBtn.Checked = True Then
            '    If My.Computer.FileSystem.FileExists("tsschecker.exe") Then
            '        Process.Start("CMD", "/K tsschecker.exe -d " + modelID + " -s -i " + ios + " --apnonce " + nonce)
            '    Else
            '        Process.Start("CMD", "/K tsschecker_windows.exe -d " + modelID + " -s -i " + ios + " --apnonce " + nonce)
            '    End If
            'ElseIf ECID_txt.Text = "" And Not SaveLoc_txt.Text = Application.StartupPath And EveryApnounce_rBtn.Checked = True Then
            '    If My.Computer.FileSystem.FileExists("tsschecker.exe") Then
            '        Process.Start("CMD", "/K tsschecker.exe -d " + modelID + " -s -i " + ios + " --save-path " + SaveLoc_txt.Text + " --apnonce " + nonce)
            '    Else
            '        Process.Start("CMD", "/K tsschecker_windows.exe -d " + modelID + " -s -i " + ios + " --save-path " + SaveLoc_txt.Text + " --apnonce " + nonce)
            '    End If
        End If

        Dim folderpath As String
        Dim foldername As String

        folderpath = SaveLoc_txt.Text
        foldername = System.IO.Path.GetFileName(folderpath)
        If FindWindow(vbNullString, foldername) = 0 Then
            Process.Start("explorer.exe", folderpath)
        Else
            AppActivate(foldername)
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("tsschecker.exe") Or My.Computer.FileSystem.FileExists("tsschecker_windows.exe") Then

        Else
            MessageBox.Show("We couldn't detect tsschecker.exe or tsschecker_windows.exe." + vbNewLine + vbNewLine + "Make sure the executable is in the same folder as Assistant.", "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End
        End If

        SaveLoc_txt.Text = Application.StartupPath()
    End Sub

    Private Sub Browse_btn_Click(sender As Object, e As EventArgs) Handles Browse_btn.Click
        Dim frm As New OpenFolderDialog()

        Dim D = frm.ShowDialog(Me)

        If D = DialogResult.OK Then
            SaveLoc_txt.Text = frm.Folder
        Else

        End If

    End Sub

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function
    Private Sub LocOpen_btn_Click(sender As Object, e As EventArgs) Handles LocOpen_btn.Click
        Dim folderpath As String
        Dim foldername As String

        folderpath = SaveLoc_txt.Text
        foldername = System.IO.Path.GetFileName(folderpath)
        If FindWindow(vbNullString, foldername) = 0 Then
            Process.Start("explorer.exe", folderpath)
        Else
            AppActivate(foldername)
        End If
    End Sub

    Private Sub RstLocation_btn_Click(sender As Object, e As EventArgs) Handles RstLocation_btn.Click
        SaveLoc_txt.Text = Application.StartupPath
    End Sub
End Class
