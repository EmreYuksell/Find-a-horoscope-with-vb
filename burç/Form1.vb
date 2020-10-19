Public Class Form1
    Dim gun, ay As Integer

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        gun = DateTimePicker1.Value.Day 'Sadece gün bilgisi alınıyor.
        ay = DateTimePicker1.Value.Month 'Sadece ay bilgisi alınıyor.
        If (ay = 12 And gun >= 23) Or (ay = 1 And gun <= 20) Then
            burc.Text = "OĞLAK"
        End If/
        If (ay = 9 And gun >= 22) Or (ay = 10 And gun <= 23) Then
            burc.Text = "TERAZİ"
        End If
        If (ay = 1 And gun >= 21) Or (ay = 2 And gun <= 19) Then
            burc.Text = "KOVA"
        End If
        If (ay = 2 And gun >= 20) Or (ay = 3 And gun <= 20) Then
            burc.Text = "BALIK"
        End If
        If (ay = 3 And gun >= 21) Or (ay = 4 And gun <= 20) Then
            burc.Text = "KOÇ"
        End If
        If (ay = 4 And gun >= 21) Or (ay = 5 And gun <= 21) Then
            burc.Text = "BOĞA"
        End If
        If (ay = 5 And gun >= 22) Or (ay = 6 And gun <= 21) Then
            burc.Text = "İKİZLER"
        End If
        If (ay = 6 And gun >= 22) Or (ay = 7 And gun <= 23) Then
            burc.Text = "YENGEÇ"
        End If
        If (ay = 7 And gun >= 24) Or (ay = 8 And gun <= 23) Then
            burc.Text = "ASLAN"
        End If
        If (ay = 8 And gun >= 24) Or (ay = 9 And gun <= 23) Then
            burc.Text = "BAŞAK"
        End If
        If (ay = 10 And gun >= 23) Or (ay = 11 And gun <= 22) Then
            burc.Text = "AKREP"
        End If
        If (ay = 11 And gun >= 23) Or (ay = 12 And gun <= 22) Then
            burc.Text = "YAY"
        End If
    End Sub


End Class