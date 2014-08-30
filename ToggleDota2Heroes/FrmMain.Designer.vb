<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.txtProductDescription = New System.Windows.Forms.RichTextBox()
        Me.pbCompanyLogo = New System.Windows.Forms.PictureBox()
        Me.lblProductCreator = New System.Windows.Forms.Label()
        Me.lblProductVersion = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTypical = New System.Windows.Forms.Label()
        Me.txtFilelocation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSavefile = New System.Windows.Forms.Button()
        Me.grpHeroeslist = New System.Windows.Forms.GroupBox()
        Me.txtHeroes = New System.Windows.Forms.TextBox()
        Me.btnSelectHeroes = New System.Windows.Forms.Button()
        Me.grpBrowse = New System.Windows.Forms.GroupBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblLibrarylocation = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnAutodetect = New System.Windows.Forms.Button()
        Me.fbdBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.sfdExport = New System.Windows.Forms.SaveFileDialog()
        Me.tabLauncher = New System.Windows.Forms.TabPage()
        Me.grpLauncher = New System.Windows.Forms.GroupBox()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        CType(Me.pbCompanyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSettings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpHeroeslist.SuspendLayout()
        Me.grpBrowse.SuspendLayout()
        Me.tabLauncher.SuspendLayout()
        Me.grpLauncher.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabAbout)
        Me.TabControl1.Controls.Add(Me.tabSettings)
        Me.TabControl1.Controls.Add(Me.tabLauncher)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(462, 430)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.txtProductDescription)
        Me.tabAbout.Controls.Add(Me.pbCompanyLogo)
        Me.tabAbout.Controls.Add(Me.lblProductCreator)
        Me.tabAbout.Controls.Add(Me.lblProductVersion)
        Me.tabAbout.Controls.Add(Me.lblProductName)
        Me.tabAbout.Location = New System.Drawing.Point(4, 22)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAbout.Size = New System.Drawing.Size(454, 404)
        Me.tabAbout.TabIndex = 0
        Me.tabAbout.Text = "About"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductDescription.BackColor = System.Drawing.SystemColors.Window
        Me.txtProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProductDescription.Location = New System.Drawing.Point(6, 56)
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.ReadOnly = True
        Me.txtProductDescription.Size = New System.Drawing.Size(306, 345)
        Me.txtProductDescription.TabIndex = 10
        Me.txtProductDescription.Text = resources.GetString("txtProductDescription.Text")
        '
        'pbCompanyLogo
        '
        Me.pbCompanyLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCompanyLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbCompanyLogo.Image = Global.ToggleDota2Heroes.My.Resources.Resources.Lexsym_icon_128x128
        Me.pbCompanyLogo.Location = New System.Drawing.Point(318, 6)
        Me.pbCompanyLogo.Name = "pbCompanyLogo"
        Me.pbCompanyLogo.Size = New System.Drawing.Size(128, 128)
        Me.pbCompanyLogo.TabIndex = 9
        Me.pbCompanyLogo.TabStop = False
        '
        'lblProductCreator
        '
        Me.lblProductCreator.AutoSize = True
        Me.lblProductCreator.Location = New System.Drawing.Point(3, 40)
        Me.lblProductCreator.Name = "lblProductCreator"
        Me.lblProductCreator.Size = New System.Drawing.Size(102, 13)
        Me.lblProductCreator.TabIndex = 7
        Me.lblProductCreator.Text = "Created by: Mal1t1a"
        '
        'lblProductVersion
        '
        Me.lblProductVersion.AutoSize = True
        Me.lblProductVersion.Location = New System.Drawing.Point(3, 21)
        Me.lblProductVersion.Name = "lblProductVersion"
        Me.lblProductVersion.Size = New System.Drawing.Size(91, 13)
        Me.lblProductVersion.TabIndex = 6
        Me.lblProductVersion.Text = "Version: {Version}"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(3, 3)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(204, 13)
        Me.lblProductName.TabIndex = 5
        Me.lblProductName.Text = "Mal1t1a - Hero Enabler and Hero Disabler"
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.GroupBox1)
        Me.tabSettings.Controls.Add(Me.grpHeroeslist)
        Me.tabSettings.Controls.Add(Me.grpBrowse)
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(454, 404)
        Me.tabSettings.TabIndex = 1
        Me.tabSettings.Text = "Settings"
        Me.tabSettings.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblTypical)
        Me.GroupBox1.Controls.Add(Me.txtFilelocation)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSavefile)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 266)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 130)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Optionally you can directly choose the file save location for Activelist.txt"
        '
        'lblTypical
        '
        Me.lblTypical.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTypical.Location = New System.Drawing.Point(6, 16)
        Me.lblTypical.Name = "lblTypical"
        Me.lblTypical.Size = New System.Drawing.Size(428, 37)
        Me.lblTypical.TabIndex = 4
        Me.lblTypical.Text = "Typically this file is saved to: C:\Program Files (x86)\Steam\SteamApps\common\do" & _
    "ta 2 beta\dota\scripts\NPC\activelist.txt"
        '
        'txtFilelocation
        '
        Me.txtFilelocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilelocation.Location = New System.Drawing.Point(6, 104)
        Me.txtFilelocation.Name = "txtFilelocation"
        Me.txtFilelocation.Size = New System.Drawing.Size(428, 20)
        Me.txtFilelocation.TabIndex = 3
        Me.txtFilelocation.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "File location:"
        '
        'btnSavefile
        '
        Me.btnSavefile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSavefile.Location = New System.Drawing.Point(7, 56)
        Me.btnSavefile.Name = "btnSavefile"
        Me.btnSavefile.Size = New System.Drawing.Size(428, 29)
        Me.btnSavefile.TabIndex = 0
        Me.btnSavefile.TabStop = False
        Me.btnSavefile.Text = "Choose save location"
        Me.btnSavefile.UseVisualStyleBackColor = True
        '
        'grpHeroeslist
        '
        Me.grpHeroeslist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpHeroeslist.Controls.Add(Me.txtHeroes)
        Me.grpHeroeslist.Controls.Add(Me.btnSelectHeroes)
        Me.grpHeroeslist.Location = New System.Drawing.Point(6, 6)
        Me.grpHeroeslist.Name = "grpHeroeslist"
        Me.grpHeroeslist.Size = New System.Drawing.Size(440, 115)
        Me.grpHeroeslist.TabIndex = 1
        Me.grpHeroeslist.TabStop = False
        Me.grpHeroeslist.Text = "Hero selection"
        '
        'txtHeroes
        '
        Me.txtHeroes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHeroes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHeroes.Location = New System.Drawing.Point(3, 45)
        Me.txtHeroes.Multiline = True
        Me.txtHeroes.Name = "txtHeroes"
        Me.txtHeroes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtHeroes.Size = New System.Drawing.Size(434, 67)
        Me.txtHeroes.TabIndex = 0
        Me.txtHeroes.TabStop = False
        Me.txtHeroes.Text = """whitelist""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}"
        '
        'btnSelectHeroes
        '
        Me.btnSelectHeroes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSelectHeroes.Location = New System.Drawing.Point(3, 16)
        Me.btnSelectHeroes.Name = "btnSelectHeroes"
        Me.btnSelectHeroes.Size = New System.Drawing.Size(434, 29)
        Me.btnSelectHeroes.TabIndex = 0
        Me.btnSelectHeroes.TabStop = False
        Me.btnSelectHeroes.Text = "Select heroes"
        Me.btnSelectHeroes.UseVisualStyleBackColor = True
        '
        'grpBrowse
        '
        Me.grpBrowse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBrowse.Controls.Add(Me.txtLocation)
        Me.grpBrowse.Controls.Add(Me.lblLibrarylocation)
        Me.grpBrowse.Controls.Add(Me.btnBrowse)
        Me.grpBrowse.Controls.Add(Me.btnAutodetect)
        Me.grpBrowse.Location = New System.Drawing.Point(6, 127)
        Me.grpBrowse.Name = "grpBrowse"
        Me.grpBrowse.Size = New System.Drawing.Size(440, 133)
        Me.grpBrowse.TabIndex = 1
        Me.grpBrowse.TabStop = False
        Me.grpBrowse.Text = "Save hero lists via steam game library location"
        '
        'txtLocation
        '
        Me.txtLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocation.Location = New System.Drawing.Point(6, 102)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(428, 20)
        Me.txtLocation.TabIndex = 3
        Me.txtLocation.TabStop = False
        '
        'lblLibrarylocation
        '
        Me.lblLibrarylocation.AutoSize = True
        Me.lblLibrarylocation.Location = New System.Drawing.Point(6, 86)
        Me.lblLibrarylocation.Name = "lblLibrarylocation"
        Me.lblLibrarylocation.Size = New System.Drawing.Size(81, 13)
        Me.lblLibrarylocation.TabIndex = 2
        Me.lblLibrarylocation.Text = "Library location:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(6, 54)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(428, 29)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.TabStop = False
        Me.btnBrowse.Text = "Browse for folder if auto detect fails"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnAutodetect
        '
        Me.btnAutodetect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAutodetect.Location = New System.Drawing.Point(6, 19)
        Me.btnAutodetect.Name = "btnAutodetect"
        Me.btnAutodetect.Size = New System.Drawing.Size(428, 29)
        Me.btnAutodetect.TabIndex = 0
        Me.btnAutodetect.TabStop = False
        Me.btnAutodetect.Text = "Auto detect folder location"
        Me.btnAutodetect.UseVisualStyleBackColor = True
        '
        'fbdBrowse
        '
        Me.fbdBrowse.Description = "Browse for your Steam folder"
        '
        'sfdExport
        '
        Me.sfdExport.CheckFileExists = True
        Me.sfdExport.DefaultExt = "txt"
        Me.sfdExport.FileName = "activelist.txt"
        Me.sfdExport.Filter = "Text files|*.txt|All files|*.*"
        Me.sfdExport.Title = "activelist.txt file export location"
        '
        'tabLauncher
        '
        Me.tabLauncher.Controls.Add(Me.grpLauncher)
        Me.tabLauncher.Location = New System.Drawing.Point(4, 22)
        Me.tabLauncher.Name = "tabLauncher"
        Me.tabLauncher.Size = New System.Drawing.Size(454, 404)
        Me.tabLauncher.TabIndex = 2
        Me.tabLauncher.Text = "Dota 2 launcher"
        Me.tabLauncher.UseVisualStyleBackColor = True
        '
        'grpLauncher
        '
        Me.grpLauncher.Controls.Add(Me.btnLaunch)
        Me.grpLauncher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpLauncher.Location = New System.Drawing.Point(0, 0)
        Me.grpLauncher.Name = "grpLauncher"
        Me.grpLauncher.Size = New System.Drawing.Size(454, 404)
        Me.grpLauncher.TabIndex = 0
        Me.grpLauncher.TabStop = False
        Me.grpLauncher.Text = "Launch Dota 2 through steam"
        '
        'btnLaunch
        '
        Me.btnLaunch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLaunch.Location = New System.Drawing.Point(3, 16)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(448, 385)
        Me.btnLaunch.TabIndex = 0
        Me.btnLaunch.Text = "Click me baby one more time"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 430)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmMain"
        Me.Text = "Hero Enabler/Disabler by Mal1t1a"
        Me.TabControl1.ResumeLayout(False)
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        CType(Me.pbCompanyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSettings.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpHeroeslist.ResumeLayout(False)
        Me.grpHeroeslist.PerformLayout()
        Me.grpBrowse.ResumeLayout(False)
        Me.grpBrowse.PerformLayout()
        Me.tabLauncher.ResumeLayout(False)
        Me.grpLauncher.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabAbout As System.Windows.Forms.TabPage
    Friend WithEvents tabSettings As System.Windows.Forms.TabPage
    Friend WithEvents grpBrowse As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnAutodetect As System.Windows.Forms.Button
    Friend WithEvents btnSelectHeroes As System.Windows.Forms.Button
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblLibrarylocation As System.Windows.Forms.Label
    Friend WithEvents fbdBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents grpHeroeslist As System.Windows.Forms.GroupBox
    Friend WithEvents txtHeroes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFilelocation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSavefile As System.Windows.Forms.Button
    Friend WithEvents sfdExport As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lblTypical As System.Windows.Forms.Label
    Friend WithEvents pbCompanyLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblProductCreator As System.Windows.Forms.Label
    Friend WithEvents lblProductVersion As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtProductDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents tabLauncher As System.Windows.Forms.TabPage
    Friend WithEvents grpLauncher As System.Windows.Forms.GroupBox
    Friend WithEvents btnLaunch As System.Windows.Forms.Button

End Class
