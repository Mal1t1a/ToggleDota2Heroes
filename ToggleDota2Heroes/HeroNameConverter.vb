Module HeroNameConverter
    Public Function ConvertHeroToNpc(ByVal Heroname As String) As String
        Select Case Heroname
            Case "=== Agility Heroes ===", "=== Intelligence Heroes ===", "=== Strength Heroes ==="
                Return ""
            Case "Clockwerk"
                Return "npc_dota_hero_rattletrap"
            Case "Centaur Warrunner"
                Return "npc_dota_hero_centaur"
            Case "Io"
                Return "npc_dota_hero_wisp"
            Case "Lifestealer"
                Return "npc_dota_hero_life_stealer"
            Case "Magnus"
                Return "npc_dota_hero_magnataur"
            Case "Nature's Prophet"
                Return "npc_dota_hero_furion"
            Case "Necrophos"
                Return "npc_dota_hero_necrolyte"
            Case "Outworld Devourer"
                Return "npc_dota_hero_obsidian_destroyer"
            Case "Queen of Pain"
                Return "npc_dota_hero_queenofpain"
            Case "Shadow Fiend"
                Return "npc_dota_hero_nevermore"
            Case "Timbersaw"
                Return "npc_dota_hero_shredder"
            Case "Treant Protector"
                Return "npc_dota_hero_treant"
            Case "Vengeful Spirit"
                Return "npc_dota_hero_vengefulspirit"
            Case "Windranger"
                Return "npc_dota_hero_windrunner"
            Case "Wraith King"
                Return "npc_dota_hero_skeleton_king"
            Case "Zeus"
                Return "npc_dota_hero_zuus"
            Case Else
                Return String.Format("{0}{1}", "npc_dota_hero_", Heroname.Replace(" ", "_").ToLower)
        End Select
    End Function
End Module
