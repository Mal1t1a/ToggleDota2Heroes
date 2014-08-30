Public Class FrmToggleHeroes

    Private _heroes As New List(Of String)
    Public ReadOnly Property Heroes() As List(Of String)
        Get
            Return _heroes
        End Get
    End Property


    Public Sub CheckValidChoices(ByRef list As List(Of String))
        Dim isValid As Boolean = False
        If list.Count > 0 Then
            For Each item In list
                If Not chkHeroes.GetItemText(chkHeroes.Items(chkHeroes.Items.IndexOf(item))).StartsWith("=") Then
                    isValid = True
                    Exit For
                End If
            Next
        End If
        If isValid Then
            _heroes = list
            BtnAccept.Enabled = True
        Else
            BtnAccept.Enabled = False
        End If
    End Sub

    Private Sub chkHeroes_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkHeroes.ItemCheck
        Dim isValid As Boolean = False
        Dim list As List(Of String) = _heroes
        If chkHeroes.SelectedItems.Count > 0 Then
            For Each item In chkHeroes.SelectedItems
                If Not chkHeroes.GetItemText(item).StartsWith("=") Then
                    isValid = True
                    list.Add(chkHeroes.GetItemText(item))
                End If
            Next
        End If
        If isValid Then
            _heroes = list
            BtnAccept.Enabled = True
        Else
            BtnAccept.Enabled = False
        End If
    End Sub

    Private Sub CheckAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckAllToolStripMenuItem.Click
        Dim list As New List(Of String)
        For i As Integer = 0 To chkHeroes.Items.Count - 1
            chkHeroes.SetItemCheckState(i, CheckState.Checked)
            list.Add(chkHeroes.GetItemText(chkHeroes.Items(i)))
        Next
        CheckValidChoices(list)
    End Sub

    Private Sub UncheckAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UncheckAllToolStripMenuItem.Click
        Dim list As New List(Of String)
        For i As Integer = 0 To chkHeroes.Items.Count - 1
            chkHeroes.SetItemCheckState(i, CheckState.Unchecked)
        Next
        CheckValidChoices(list)
    End Sub

    Private Sub AgilityOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgilityOnlyToolStripMenuItem.Click
        Dim list As New List(Of String)
        Dim hasFound As Boolean = False
        For i As Integer = 0 To chkHeroes.Items.Count - 1
            Dim item As Object = chkHeroes.Items(i)
            If chkHeroes.GetItemText(item) = "=== Agility Heroes ===" Then
                chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Checked)
                hasFound = True
                Continue For
            ElseIf hasFound Then
                If chkHeroes.GetItemText(item).StartsWith("===") Then
                    Exit For
                Else
                    chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Checked)
                    If Not list.Contains(chkHeroes.GetItemText(item)) Then
                        list.Add(chkHeroes.GetItemText(item))
                    End If
                End If
            End If
        Next
        CheckValidChoices(list)
    End Sub

    Private Sub IntelligenceOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntelligenceOnlyToolStripMenuItem.Click
        Dim list As New List(Of String)
        Dim hasFound As Boolean = False
        For i As Integer = 0 To chkHeroes.Items.Count - 1
            Dim item As Object = chkHeroes.Items(i)
            If chkHeroes.GetItemText(item) = "=== Intelligence Heroes ===" Then
                chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Checked)
                hasFound = True
                Continue For
            ElseIf hasFound Then
                If chkHeroes.GetItemText(item).StartsWith("===") Then
                    Exit For
                Else
                    chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Checked)
                    If Not list.Contains(chkHeroes.GetItemText(item)) Then
                        list.Add(chkHeroes.GetItemText(item))
                    End If
                End If
            End If
        Next
        CheckValidChoices(list)
    End Sub

    Private Sub StrengthOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrengthOnlyToolStripMenuItem.Click
        Dim list As New List(Of String)
        Dim hasFound As Boolean = False
        For i As Integer = 0 To chkHeroes.Items.Count - 1
            Dim item As Object = chkHeroes.Items(i)
            If chkHeroes.GetItemText(item) = "=== Strength Heroes ===" Then
                chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Checked)
                hasFound = True
                Continue For
            ElseIf hasFound Then
                If chkHeroes.GetItemText(item).StartsWith("===") Then
                    Exit For
                Else
                    chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Checked)
                    If Not list.Contains(chkHeroes.GetItemText(item)) Then
                        list.Add(chkHeroes.GetItemText(item))
                    End If
                End If
            End If
        Next
        CheckValidChoices(list)
    End Sub

    Private Sub FrmToggleHeroes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckAllToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub AgilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgilityToolStripMenuItem.Click
        Dim list As New List(Of String)
        Dim hasFound As Boolean = False
        For i As Integer = 0 To chkHeroes.Items.Count - 1
            Dim item As Object = chkHeroes.Items(i)
            If chkHeroes.GetItemText(item) = "=== Agility Heroes ===" Then
                chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Unchecked)
                list.Remove(chkHeroes.GetItemText(item))
                hasFound = True
                Continue For
            ElseIf hasFound Then
                If chkHeroes.GetItemText(item).StartsWith("===") Then
                    Exit For
                Else
                    chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Unchecked)
                    list.Remove(chkHeroes.GetItemText(item))
                End If
            End If
        Next
        CheckValidChoices(list)
    End Sub

    Private Sub IntelligenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntelligenceToolStripMenuItem.Click
        Dim list As New List(Of String)
        Dim hasFound As Boolean = False
        For i As Integer = 0 To chkHeroes.Items.Count - 1
            Dim item As Object = chkHeroes.Items(i)
            If chkHeroes.GetItemText(item) = "=== Intelligence Heroes ===" Then
                chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Unchecked)
                list.Remove(chkHeroes.GetItemText(item))
                hasFound = True
                Continue For
            ElseIf hasFound Then
                If chkHeroes.GetItemText(item).StartsWith("===") Then
                    Exit For
                Else
                    chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Unchecked)
                    list.Remove(chkHeroes.GetItemText(item))
                End If
            End If
        Next
        CheckValidChoices(list)
    End Sub

    Private Sub StrengthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrengthToolStripMenuItem.Click
        Dim list As New List(Of String)
        Dim hasFound As Boolean = False
        For i As Integer = 0 To chkHeroes.Items.Count - 1
            Dim item As Object = chkHeroes.Items(i)
            If chkHeroes.GetItemText(item) = "=== Strength Heroes ===" Then
                chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Unchecked)
                list.Remove(chkHeroes.GetItemText(item))
                hasFound = True
                Continue For
            ElseIf hasFound Then
                If chkHeroes.GetItemText(item).StartsWith("===") Then
                    Exit For
                Else
                    chkHeroes.SetItemCheckState(chkHeroes.Items.IndexOf(item), CheckState.Unchecked)
                    list.Remove(chkHeroes.GetItemText(item))
                End If
            End If
        Next
        CheckValidChoices(list)
    End Sub
End Class