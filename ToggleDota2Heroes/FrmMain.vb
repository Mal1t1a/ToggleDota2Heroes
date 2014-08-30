Public Class FrmMain

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProductVersion.Text = String.Format("Version: {0}", ProductVersion.ToString)
        txtProductDescription.Focus()
        txtProductDescription.DeselectAll()
        For Each line As String In txtProductDescription.Text.Split(vbLf)
            line = line.Trim
            If line = "" Then
                Continue For
            End If
            If line.StartsWith("Description:") Or line.StartsWith("Features:") Or line.StartsWith("Important notice:") Or line.StartsWith("Privacy:") Then
                txtProductDescription.Select(txtProductDescription.Text.IndexOf(line), line.Length)
                txtProductDescription.SelectionFont = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)
            End If
        Next
        txtProductDescription.Select(0, 1)
        txtProductDescription.DeselectAll()
    End Sub

    Private Sub btnSelectHeroes_Click(sender As Object, e As EventArgs) Handles btnSelectHeroes.Click
        If FrmToggleHeroes.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim heroes As List(Of String) = FrmToggleHeroes.Heroes
            txtHeroes.Text = """whitelist""" & vbNewLine & "{" & vbNewLine
            Dim compStr As String = ""
            For Each hero As String In heroes
                hero = ConvertHeroToNpc(hero)
                If hero = "" Then
                    Continue For
                End If
                compStr += vbTab & """" & hero & """ ""1""" & vbNewLine
            Next
            txtHeroes.Text += compStr & "}"
        End If
    End Sub

    Private Sub btnSavefile_Click(sender As Object, e As EventArgs) Handles btnSavefile.Click
        If sfdExport.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFilelocation.Text = sfdExport.FileName
            Try
                Dim content As String = txtHeroes.Text
                Dim sfile As New IO.StreamWriter(sfdExport.FileName)
                Try
                    sfile.Write(content)
                    MessageBox.Show("File successfully saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex2 As Exception
                    MessageBox.Show("Your file could not be saved.", "An error has occured.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                sfile.Close()
            Catch ex2 As Exception
                MessageBox.Show("Your file could not be saved.", "An error has occured.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnAutodetect_Click(sender As Object, e As EventArgs) Handles btnAutodetect.Click
        Dim possiblelocations As New List(Of String)
        possiblelocations.Add("C:\Program Files\Steam\")
        possiblelocations.Add("C:\Program Files (x86)\Steam\")
        possiblelocations.Add("C:\Steam\")
        Dim found As String = ""
        For Each possibility In possiblelocations
            If found = "" Then
                If My.Computer.FileSystem.DirectoryExists(possibility & "SteamApps\common\dota 2 beta\dota\scripts") Then
                    found = possibility
                    Exit For
                End If
            End If
        Next
        If Not found = "" Then
            txtLocation.Text = found
            If Not My.Computer.FileSystem.DirectoryExists(found & "SteamApps\common\dota 2 beta\dota\scripts\NPC") Then
                My.Computer.FileSystem.CreateDirectory(found & "SteamApps\common\dota 2 beta\dota\scripts\NPC")
            End If
            Try
                Dim content As String = txtHeroes.Text
                Dim sfile As New IO.StreamWriter(found & "SteamApps\common\dota 2 beta\dota\scripts\NPC\activelist.txt")
                Try
                    sfile.Write(content)
                    MessageBox.Show("File successfully saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex2 As Exception
                    MessageBox.Show("Your file could not be saved.", "An error has occured.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                sfile.Close()
            Catch ex2 As Exception
                MessageBox.Show("Your file could not be saved.", "An error has occured.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Could not detect steam directory, try browsing for it manually.", "Error 404, Steam Library not found!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If fbdBrowse.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim found As String = fbdBrowse.SelectedPath
            If My.Computer.FileSystem.DirectoryExists(found & "\SteamApps\common\dota 2 beta\dota\scripts") Then
                found = found & "\SteamApps\common\dota 2 beta\dota\scripts\"
            ElseIf My.Computer.FileSystem.DirectoryExists(found & "\common\dota 2 beta\dota\scripts") Then
                found = found & "\SteamApps\common\dota 2 beta\dota\scripts\"
            Else
                found = ""
            End If
            If Not found = "" Then
                txtLocation.Text = found
                If Not My.Computer.FileSystem.DirectoryExists(found & "NPC") Then
                    My.Computer.FileSystem.CreateDirectory(found & "NPC")
                End If
                Try
                    Dim content As String = txtHeroes.Text
                    Dim sfile As New IO.StreamWriter(found & "NPC\activelist.txt")
                    Try
                        sfile.Write(content)
                        MessageBox.Show("File successfully saved!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex2 As Exception
                        MessageBox.Show("Your file could not be saved.", "An error has occured.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    sfile.Close()
                Catch ex2 As Exception
                    MessageBox.Show("Your file could not be saved.", "An error has occured.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Could not detect a dota 2 beta installation.", "Error 404, Dota 2 not found!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub tabSettings_Click(sender As Object, e As EventArgs) Handles tabSettings.Click

    End Sub

    Private Sub pbCompanyLogo_Click(sender As Object, e As EventArgs) Handles pbCompanyLogo.Click
        Process.Start("http://Mal1t1a.ca/")
    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        Process.Start("steam://run/570/-console/-override_vpk")
    End Sub
End Class
