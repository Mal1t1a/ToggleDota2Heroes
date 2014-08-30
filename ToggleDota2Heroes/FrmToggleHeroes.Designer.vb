<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmToggleHeroes
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
        Me.components = New System.ComponentModel.Container()
        Me.chkHeroes = New System.Windows.Forms.CheckedListBox()
        Me.BtnAccept = New System.Windows.Forms.Button()
        Me.BtnDecline = New System.Windows.Forms.Button()
        Me.msToggles = New System.Windows.Forms.MenuStrip()
        Me.CheckAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UncheckAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgilityOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntelligenceOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrengthOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupUncheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntelligenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrengthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrValidChoice = New System.Windows.Forms.Timer(Me.components)
        Me.msToggles.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkHeroes
        '
        Me.chkHeroes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkHeroes.FormattingEnabled = True
        Me.chkHeroes.Items.AddRange(New Object() {"=== Agility Heroes ===", "Antimage", "Bloodseeker", "Bounty Hunter", "Broodmother", "Clinkz", "Drow Ranger", "Ember Spirit", "Faceless Void", "Gyrocopter", "Juggernaut", "Lone Druid", "Luna", "Medusa", "Meepo", "Mirana", "Morphling", "Naga Siren", "Nyx Assassin", "Phantom Assassin", "Phantom Lancer", "Riki", "Razor", "Shadow Fiend", "Slark", "Sniper", "Spectre", "Templar Assassin", "Terrorblade", "Troll Warlord", "Ursa", "Vengeful Spirit", "Venomancer", "Viper", "Weaver", "=== Intelligence Heroes ===", "Ancient Apparition", "Bane", "Batrider", "Chen", "Crystal Maiden", "Dark Seer", "Dazzle", "Death Prophet", "Disruptor", "Enchantress", "Enigma", "Invoker", "Jakiro", "Keeper of the Light", "Leshrac", "Lich", "Lina", "Lion", "Puck", "Nature's Prophet", "Necrolyte", "Ogre Magi", "Outworld Destroyer", "Pugna", "Queen of Pain", "Rubick", "Shadow Demon", "Shadow Shaman", "Silencer", "Skywrath Mage", "Storm Spirit", "Techies", "Tinker", "Visage", "Warlock", "Windranger", "Witch Doctor", "Zeus", "=== Strength Heroes ===", "Abaddon", "Alchemist", "Axe", "Beastmaster", "Brewmaster", "Centaur Warrunner", "Chaos Knight", "Clockwerk", "Doom Bringer", "Dragon Knight", "Earthshaker", "Earth Spirit", "Elder Titan", "Huskar", "Io", "Kunkka", "Legion Commander", "Lifestealer", "Lycan", "Magnus", "Night Stalker", "Omniknight", "Phoenix", "Pudge", "Sand King", "Slardar", "Spirit Breaker", "Sven", "Tidehunter", "Timbersaw", "Tiny", "Treant Protector", "Tusk", "Undying", "Wraith King"})
        Me.chkHeroes.Location = New System.Drawing.Point(0, 26)
        Me.chkHeroes.Name = "chkHeroes"
        Me.chkHeroes.Size = New System.Drawing.Size(369, 154)
        Me.chkHeroes.TabIndex = 0
        '
        'BtnAccept
        '
        Me.BtnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnAccept.Enabled = False
        Me.BtnAccept.Location = New System.Drawing.Point(257, 189)
        Me.BtnAccept.Name = "BtnAccept"
        Me.BtnAccept.Size = New System.Drawing.Size(99, 31)
        Me.BtnAccept.TabIndex = 1
        Me.BtnAccept.Text = "Accept"
        Me.BtnAccept.UseVisualStyleBackColor = True
        '
        'BtnDecline
        '
        Me.BtnDecline.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDecline.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnDecline.Location = New System.Drawing.Point(12, 189)
        Me.BtnDecline.Name = "BtnDecline"
        Me.BtnDecline.Size = New System.Drawing.Size(99, 31)
        Me.BtnDecline.TabIndex = 2
        Me.BtnDecline.Text = "Decline"
        Me.BtnDecline.UseVisualStyleBackColor = True
        '
        'msToggles
        '
        Me.msToggles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckAllToolStripMenuItem, Me.UncheckAllToolStripMenuItem, Me.GroupCheckToolStripMenuItem, Me.GroupUncheckToolStripMenuItem})
        Me.msToggles.Location = New System.Drawing.Point(0, 0)
        Me.msToggles.Name = "msToggles"
        Me.msToggles.Size = New System.Drawing.Size(368, 24)
        Me.msToggles.TabIndex = 3
        Me.msToggles.Text = "MenuStrip1"
        '
        'CheckAllToolStripMenuItem
        '
        Me.CheckAllToolStripMenuItem.Name = "CheckAllToolStripMenuItem"
        Me.CheckAllToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CheckAllToolStripMenuItem.Text = "Check all"
        '
        'UncheckAllToolStripMenuItem
        '
        Me.UncheckAllToolStripMenuItem.Name = "UncheckAllToolStripMenuItem"
        Me.UncheckAllToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.UncheckAllToolStripMenuItem.Text = "Uncheck all"
        '
        'GroupCheckToolStripMenuItem
        '
        Me.GroupCheckToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgilityOnlyToolStripMenuItem, Me.IntelligenceOnlyToolStripMenuItem, Me.StrengthOnlyToolStripMenuItem})
        Me.GroupCheckToolStripMenuItem.Name = "GroupCheckToolStripMenuItem"
        Me.GroupCheckToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.GroupCheckToolStripMenuItem.Text = "Group Check"
        '
        'AgilityOnlyToolStripMenuItem
        '
        Me.AgilityOnlyToolStripMenuItem.Name = "AgilityOnlyToolStripMenuItem"
        Me.AgilityOnlyToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AgilityOnlyToolStripMenuItem.Text = "Agility"
        '
        'IntelligenceOnlyToolStripMenuItem
        '
        Me.IntelligenceOnlyToolStripMenuItem.Name = "IntelligenceOnlyToolStripMenuItem"
        Me.IntelligenceOnlyToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.IntelligenceOnlyToolStripMenuItem.Text = "Intelligence"
        '
        'StrengthOnlyToolStripMenuItem
        '
        Me.StrengthOnlyToolStripMenuItem.Name = "StrengthOnlyToolStripMenuItem"
        Me.StrengthOnlyToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.StrengthOnlyToolStripMenuItem.Text = "Strength"
        '
        'GroupUncheckToolStripMenuItem
        '
        Me.GroupUncheckToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgilityToolStripMenuItem, Me.IntelligenceToolStripMenuItem, Me.StrengthToolStripMenuItem})
        Me.GroupUncheckToolStripMenuItem.Name = "GroupUncheckToolStripMenuItem"
        Me.GroupUncheckToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.GroupUncheckToolStripMenuItem.Text = "Group Uncheck"
        '
        'AgilityToolStripMenuItem
        '
        Me.AgilityToolStripMenuItem.Name = "AgilityToolStripMenuItem"
        Me.AgilityToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AgilityToolStripMenuItem.Text = "Agility"
        '
        'IntelligenceToolStripMenuItem
        '
        Me.IntelligenceToolStripMenuItem.Name = "IntelligenceToolStripMenuItem"
        Me.IntelligenceToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.IntelligenceToolStripMenuItem.Text = "Intelligence"
        '
        'StrengthToolStripMenuItem
        '
        Me.StrengthToolStripMenuItem.Name = "StrengthToolStripMenuItem"
        Me.StrengthToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.StrengthToolStripMenuItem.Text = "Strength"
        '
        'FrmToggleHeroes
        '
        Me.AcceptButton = Me.BtnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnDecline
        Me.ClientSize = New System.Drawing.Size(368, 226)
        Me.Controls.Add(Me.BtnDecline)
        Me.Controls.Add(Me.BtnAccept)
        Me.Controls.Add(Me.chkHeroes)
        Me.Controls.Add(Me.msToggles)
        Me.MainMenuStrip = Me.msToggles
        Me.Name = "FrmToggleHeroes"
        Me.Text = "Hero Selection"
        Me.msToggles.ResumeLayout(False)
        Me.msToggles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkHeroes As System.Windows.Forms.CheckedListBox
    Friend WithEvents BtnAccept As System.Windows.Forms.Button
    Friend WithEvents BtnDecline As System.Windows.Forms.Button
    Friend WithEvents msToggles As System.Windows.Forms.MenuStrip
    Friend WithEvents CheckAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgilityOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntelligenceOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StrengthOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UncheckAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrValidChoice As System.Windows.Forms.Timer
    Friend WithEvents GroupUncheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntelligenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StrengthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
